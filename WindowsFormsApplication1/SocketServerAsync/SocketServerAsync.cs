using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace SocketServer
{

    public delegate void MessageReceived(string Message, Socket RxSocket);
    public delegate void SocketConnect(string Message, Socket RxSocket);
    public class SocketServerAsync
    {

        #region Globals
        private Socket objSocketServer;
        public event MessageReceived OnMessageReceived;


        public event SocketConnect OnSocketConnected;
        #endregion

        #region Constructors
        public SocketServerAsync(int ListeningPort)
        {
            try
            {
                NoError = true;
                Port = ListeningPort;
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, Port);
                objSocketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                objSocketServer.Bind(endpoint);
                objSocketServer.Listen(100);
                objSocketServer.BeginAccept(OnSocketConnect, null);
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                NoError = false;
            }
        }
        #endregion

        #region Properties
        public string Message { get; set; }
        public int Port { get; set; }
        public bool NoError { get; set; }
        #endregion

        #region Events
        #endregion

        #region Public Methods
        public void ShutDownServer()
        {
            //objSocketServer.Shutdown(SocketShutdown.Receive);
            //objSocketServer.Disconnect(true);

            objSocketServer.Dispose();
        }
        #endregion

        #region Supporting Methods
        private void OnSocketConnect(IAsyncResult result)
        {
            try
            {

                Socket Client = (Socket)objSocketServer.EndAccept(result);
                SocketState objSocketState = new SocketState();
                objSocketState.ClientSocket = Client;
                objSocketServer.BeginAccept(new AsyncCallback(OnSocketConnect), null);
                if (OnSocketConnected != null)
                    OnSocketConnected("New Connection established", Client);
                Client.BeginReceive(objSocketState.Buffer, 0, objSocketState.Buffer.Length, 0,
                    new AsyncCallback(OnDataRecived), objSocketState);
            }
            catch (Exception ex)
            {
            }
        }
        private void OnDataRecived(IAsyncResult result)
        {
            try
            {
                String RxMessage = String.Empty;
                SocketState objSocketState = (SocketState)result.AsyncState;
                Socket Client = objSocketState.ClientSocket;
                int bytesRead = Client.EndReceive(result);

                byte[] datarcv = new byte[bytesRead];
                Array.Copy(objSocketState.Buffer, 0, datarcv, 0, bytesRead);
                if (bytesRead > 0)
                {
                    objSocketState.MessageBuilder.Append(Encoding.ASCII.GetString(
                        objSocketState.Buffer, 0, bytesRead));
                    RxMessage = objSocketState.MessageBuilder.ToString();
                    List<string> lstMsgs = new List<string>();
                   
                        if (OnMessageReceived != null)
                            OnMessageReceived(RxMessage, Client);
                        objSocketState.Buffer = new byte[1024];
                        objSocketState.MessageBuilder.Clear();
                        Client.BeginReceive(objSocketState.Buffer, 0, objSocketState.Buffer.Length, 0,
                        new AsyncCallback(OnDataRecived), objSocketState);
                  
                }
            }
            catch (Exception ex)
            {


            }

        }
        private bool CreatePackets(string RxData, out List<string> RemainingData)
        {
            string packt = "";
            RemainingData = new List<string>();
            try
            {
               
                for (int i = 0; i < RxData.Length; i++)
                {
                    switch (RxData[i])
                    {
                        case '$':
                            if (Packet.CurrentPacket != 0x00)
                            {
                                packt += RxData[i];

                            }
                            else
                            {
                                Packet.CurrentPacket = 0x01;
                                packt += RxData[i];
                            }
                            break;
                        case '#':
                            if (Packet.CurrentPacket != 0x00)
                            {
                                packt += RxData[i];
                                RemainingData.Add(packt);
                                packt = "";
                                Packet.CurrentPacket = 0x00;

                            }
                            break;
                        default:
                            if (Packet.CurrentPacket != 0x00)
                                packt += RxData[i];
                            break;
                    }
                }

                if (packt.Length > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {

                if (packt.Length > 0)
                    return true;
                else
                    return false;
            }

        }

        #endregion
    }
    public static class Packet
    {
        public static byte CurrentPacket = 0x00;
        public static List<string> Payload;
        public static void Init()
        {
            CurrentPacket = 0x00;
            Payload = new List<string>();
        }
    }
    class SocketState
    {
        public Socket ClientSocket = null;
        public const int BufferSize = 1024;
        public byte[] Buffer = new byte[BufferSize];
        public StringBuilder MessageBuilder = new StringBuilder();
    }
}
