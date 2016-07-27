using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace SocketClient
{
    public delegate void MessageReceived(string Message, Socket RxSocket);
    public delegate void DataReceived(byte[] RawData, Socket RxSocket);
    public delegate void Connect(string IP, int Socket, string ErrorMessage = "", string AdditionalDetails = "");
    public delegate void Disconnect(string IP, int Socket, string ErrorMessage = "", string AdditionalDetails = "");
    public delegate void ErrorOccured(string Message, string Details = "");
    public class SocketClientAsync
    {

        #region Globals
        private Socket objSocketClient;
        /// <summary>
        /// This Event Provides Array of Bytes Whenever Socket Receive any Data along with Socket from Which Data is Received.
        /// </summary>
        public event DataReceived OnDataReceived;
        public event MessageReceived OnMessageReceived;
        public event Connect OnConnect;
        public event Disconnect OnDisconnect;
        public event ErrorOccured OnErrorOccured;
        private bool IsSocketConnected;
        #endregion

        #region Properties
        public string Message { get; set; }
        public string ServerIP { get; set; }
        public int ServerPort { get; set; }
        public string MessageTerminatingString { get; set; }
        public int TimeoutConnect { get; set; }
        public bool NoError { get; set; }
        public string ErrorMessage { get; private set; }

        private string ErrorMessageDetail { get; set; }
        private string Error
        {
            set
            {
                ErrorMessage = value;
                if (OnErrorOccured != null)
                    OnErrorOccured(ErrorMessage);
            }
            get
            {
                return Error;
            }
        }
        #endregion

        #region Constructors
        public SocketClientAsync(string IPAddress, int PortNumber, int TimeOut = 3000)
        {
            try
            {
                NoError = true;
                ServerIP = IPAddress;
                ServerPort = PortNumber;
                TimeoutConnect = TimeOut;
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                NoError = false;
            }
        }
        #endregion

        #region Events
        #endregion

        #region Public Methods
        public bool Connect(ref string ConnectInfo)
        {
            try
            {
                objSocketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                // Connect using a timeout (TimeoutConnect in milliseconds)
                IAsyncResult result = objSocketClient.BeginConnect(ServerIP, ServerPort, new AsyncCallback(OnSocketConnect), null);
                bool IsConnected = result.AsyncWaitHandle.WaitOne(TimeoutConnect, true); //Connect Timeout will respond immdiately if you use localhost IP i.e. 127.0.0.1

                if (!IsConnected || !objSocketClient.Connected)
                {
                    ConnectInfo = "Connection timeout failed to connect server " + ServerIP + " on port " + ServerPort + " after " + TimeoutConnect + " milliseconds.";
                    return false;
                }
                else
                {
                    ConnectInfo = "Connected successfully on server " + ServerIP + " and port.";
                    return true;
                }
            }
            catch (Exception ex)
            {
                ConnectInfo = "Unknown error occured while connecting to server.\nDetails :" + ex.Message;
                return false;
            }
        }
        public bool Disconnect(ref string DisconnectInfo)
        {
            try
            {
                objSocketClient.Shutdown(SocketShutdown.Both);
                objSocketClient.Close();
                DisconnectInfo = "Socket disconnected successfully from server " + ServerIP + " and port " + ServerPort + ".";
                return true;
            }
            catch (Exception ex)
            {
                DisconnectInfo = "Unknown error occured while disconnecting from server.\nDetails :" + ex.Message;
                return false;
            }
        }
        public void ShutDown()
        {
            //objSocketServer.Shutdown(SocketShutdown.Receive);
            //objSocketServer.Disconnect(true);

            objSocketClient.Dispose();
        }
        #endregion

        #region Supporting Methods
        /// <summary>
        /// Method to Support Socket Communication and Triggers User Events for Connection
        /// </summary>
        /// <param name="result"></param>
        private void OnSocketConnect(IAsyncResult result)
        {
            try
            {
                if (!objSocketClient.Connected)
                    return;
                objSocketClient.EndConnect(result);
                //Socket Client = (Socket)objSocketClient.EndAccept(result);
                SocketState objSocketState = new SocketState();
                if (objSocketClient != null)
                {
                    IsSocketConnected = true;
                    objSocketClient.BeginReceive(objSocketState.Buffer, 0, objSocketState.Buffer.Length, 0,
                        new AsyncCallback(OnDataRecived), objSocketState);
                    if (OnConnect != null)
                        OnConnect(ServerIP, ServerPort, "", "Triggered from OnSocketConnect");
                }

            }
            catch (SocketException ex)
            {
                if (ex.Message.Contains("No connection could be made because the target machine actively refused it"))
                {
                    if (objSocketClient != null && IsSocketConnected)
                    {
                        if (OnDisconnect != null)
                            OnDisconnect(ServerIP, ServerPort, ex.Message, "Triggered from OnSocketConnect");
                    }
                }
            }
            catch (Exception ex)
            {
                Error = "Error in Connecting, " + ex.Message + ", " + ex.InnerException + ", Location: OnSocketConnect" + ".";
            }
        }
        private void OnDataRecived(IAsyncResult result)
        {
            try
            {
                String RxMessage = String.Empty;
                int bytesRead = 0;
                //Raw Data Buffer
                byte[] RxData = null;
                SocketState objSocketState = (SocketState)result.AsyncState;
                Socket Client = objSocketClient;
                if (Client.Connected)
                    bytesRead = Client.EndReceive(result);
                if (bytesRead > 0)
                {
                    //Appending Received Data in MessageBuilder of SocketState object
                    objSocketState.MessageBuilder.Append(Encoding.ASCII.GetString(
                        objSocketState.Buffer, 0, bytesRead));
                    //Checking if Message containg TerminatingMessageString
                    RxMessage = objSocketState.MessageBuilder.ToString();
                    //Triggering Raw Data Event
                    if (OnDataReceived != null)
                    {
                        RxData = new byte[bytesRead];
                        Array.Copy(objSocketState.Buffer, 0, RxData, 0, bytesRead);
                        OnDataReceived(RxData, Client);
                    }
                    if (RxMessage.IndexOf("<EOF>") > -1)
                    {

                        //if (OnMessageReceived != null)
                        //    OnMessageReceived(objSocketState.ClientSocket.LocalEndPoint + ";" + RxMessage.Replace("<EOF>", ""));
                        if (OnMessageReceived != null)
                            OnMessageReceived(RxMessage.Replace("<EOF>", ""), Client);
                        objSocketState.Buffer = new byte[1024];
                        objSocketState.MessageBuilder.Clear();
                        Client.BeginReceive(objSocketState.Buffer, 0, objSocketState.Buffer.Length, 0,
                        new AsyncCallback(OnDataRecived), objSocketState);
                    }
                    else
                    {
                        // Not all data received. Get more.
                        Client.BeginReceive(objSocketState.Buffer, 0, objSocketState.Buffer.Length, 0,
                        new AsyncCallback(OnDataRecived), objSocketState);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorMessageDetail = "OnDataRecived";
                Error = ex.Message;
            }

        }
        /// <summary>
        /// Method to send data to connected Server Port
        /// </summary>
        /// <param name="Payload"></param>
        public void SendData(List<string> Payload)
        {
            try
            {
                if (objSocketClient.Connected)
                {
                    Payload.ForEach(P =>
                    {
                        objSocketClient.Send(Encoding.ASCII.GetBytes(P));
                    });
                }
                else
                {
                    ErrorMessageDetail = "SendData";
                    Error = "Failed to send data" + Environment.NewLine + "Details :Socket not connected.";
                }
            }
            catch (SocketException ex)
            {
                if (ex.Message.Contains("An established connection was aborted by the software in your host machine"))
                {

                    ErrorMessageDetail = "SendData";
                    Error = "Failed to send data on socket." + Environment.NewLine + "Details :" + ex.Message;
                    IsSocketConnected = false;
                    OnDisconnect(ServerIP, ServerPort, Error, ErrorMessageDetail);
                }
                else
                {
                    ErrorMessageDetail = "SendData L252";
                    Error = "Socket Eception :" + ex.Message;
                }

            }
            catch (Exception ex)
            {
                ErrorMessageDetail = "SendData";
                Error = "Unknown error occured in sending data on socket." + Environment.NewLine + "Details :" + ex.Message;
                IsSocketConnected = false;
                OnDisconnect(ServerIP, ServerPort, Error, ErrorMessageDetail);
            }
        }
        #endregion
    }
    class SocketState
    {
        public Socket ClientSocket = null;
        public const int BufferSize = 1024;
        public byte[] Buffer = new byte[BufferSize];
        public StringBuilder MessageBuilder = new StringBuilder();
    }
}
