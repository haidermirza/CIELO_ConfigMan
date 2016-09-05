using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using SocketClient;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using Newtonsoft.Json.Linq;
using System.IO;

namespace WindowsFormsApplication1 {


  public partial class CloudForm : Form {

    #region Global Vaiables

    String secondArgument = "";
    UdpClient udpServer = new UdpClient();
    SocketClientAsync objSocketClientAsync;
    String topicPub = "";
    String topicSub = "";
    MqttClient MQTTclient;
    bool isMqttStarted = false;
    int tcpCommand = 0;
    bool isMqttDisconnected = true;
    double i_white = 0;

    double i_red = 0;
    double i_green = 0;
    double i_blue = 0;

    string red = "";
    string green = "";
    string white = "";
    string blue = "";

    #endregion

    #region My Functions

    void SendUdpCommand(string command, bool IsBroadcast = false) {

      UdpClient udpClient = new UdpClient();
      IPEndPoint ip = new IPEndPoint(IsBroadcast ? IPAddress.Broadcast : IPAddress.Parse(cbxDeviceIp.Text), 9999);
      byte[] bytes = Encoding.ASCII.GetBytes(command);
      udpClient.Send(bytes, bytes.Length, ip);
      udpClient.BeginReceive(new AsyncCallback(recv), udpClient);
    }

    void MakeConnection(String target, String command) {

      string msg = "";

      objSocketClientAsync = new SocketClientAsync(target, 9998);
      objSocketClientAsync.OnConnect += objSocketClientAsync_OnConnect;
      objSocketClientAsync.OnDataReceived += objSocketClientAsync_OnDataReceived;
      objSocketClientAsync.OnErrorOccured += objSocketClientAsync_OnErrorOccured;
      objSocketClientAsync.OnDisconnect += objSocketClientAsync_OnDisconnect;

      objSocketClientAsync.Connect(ref msg);


      List<string> lstdata = new List<string>();
      lstdata.Add(command);
      objSocketClientAsync.SendData(lstdata);
    }

    void MqttDisconnect(bool isTimerDisconnected = false) {

      if (isMqttDisconnected) {

        isMqttDisconnected = false;

        if (isTimerDisconnected == false) {

          try {
            MQTTclient.Disconnect();
          }

          catch (Exception a) {
            MessageBox.Show(a.ToString());
          }
        }

        cbxMqttConnectionServer.Enabled = true;
        cbxMqttTopic.Enabled = true;
        txtMacAddr.Enabled = true;
        btnSendMqtt.Enabled = false;
        btnCurrentConfig.Enabled = false;
        txtResponceMQTT.Text += Environment.NewLine + Environment.NewLine + "MQTT Disconnected!" + Environment.NewLine + Environment.NewLine;
        btnMqttConnect.Text = "Connect";
        picMqttState.Image = Properties.Resources.off;

      }
    }

    void MqttConnect() {

      isMqttDisconnected = true;

      String mac = txtMacAddr.Text;
      String server = cbxMqttConnectionServer.Text;

      topicPub = "$aws/things/" + mac + "/shadow/update";

      if (cbxMqttTopic.Text.ToLower() != "update")
        topicSub = "$aws/things/" + mac + "/shadow/update/" + cbxMqttTopic.Text.ToLower();
      else
        topicSub = "$aws/things/" + mac + "/shadow/update";

      MQTTclient = new MqttClient(server);

      MQTTclient.Connect(Guid.NewGuid().ToString());
      isMqttStarted = true;

      ushort msgIdSub = MQTTclient.Subscribe(new string[] { topicSub }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
      MQTTclient.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
      txtResponceMQTT.Text += Environment.NewLine + "MQTT Connected: " + server + Environment.NewLine;

      cbxMqttConnectionServer.Enabled = false;
      cbxMqttTopic.Enabled = false;
      txtMacAddr.Enabled = false;
      btnSendMqtt.Enabled = true;
      btnCurrentConfig.Enabled = true;
      btnMqttConnect.Text = "Disconnect";
      picMqttState.Image = Properties.Resources.on;
    }

    #endregion

    private void recv(IAsyncResult res) {

      UdpClient udpClient = res.AsyncState as UdpClient;
      IPEndPoint source = new IPEndPoint(0, 0);
      byte[] message = udpClient.EndReceive(res, ref source);

      this.Invoke(new Action(() => {

        String msg = Encoding.UTF8.GetString(message);
        string[] words = msg.Split(',');

        txtResponseWin.Text += Environment.NewLine + "====================" + Environment.NewLine;
        txtResponseWin.Text += "MAC:	" + words[0] + Environment.NewLine;
        txtResponseWin.Text += secondArgument + words[1] + Environment.NewLine;

        if (words.Length > 3) {
          txtResponseWin.Text += "Type:	" + words[3] + Environment.NewLine;
          txtResponseWin.Text += "WiFi:	" + words[4] + Environment.NewLine;
        }

      }));

      udpClient.BeginReceive(new AsyncCallback(recv), udpClient);
    }

    public CloudForm() {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e) {

      txtHeartbeat.MaxLength = 3;
      textBox4.Text = "nayatel321?_";

      cbxMqttDeviceServer.Items.Add("052.091.014.160");
      cbxMqttDeviceServer.Items.Add("052.090.153.021");
      cbxMqttDeviceServer.SelectedIndex = 0;

      cbxDeviceIp.Items.Add("192.168.4.1");
      cbxDeviceIp.Items.Add("192.168.100.25");
      cbxDeviceIp.SelectedIndex = 1;

      cbxMqttConnectionServer.Items.Add("52.91.14.160");
      cbxMqttConnectionServer.Items.Add("52.90.153.21");
      cbxMqttConnectionServer.SelectedIndex = 0;

      cbxMqttTopic.SelectedIndex = 0;


      List<UdpH> listUdp = new List<UdpH>();

      UdpH objUdp = new UdpH();
      objUdp.UdpName = "Get All Devices";
      objUdp.UdpCommand = "PG:ALL\n";
      listUdp.Add(objUdp);

      objUdp = new UdpH();
      objUdp.UdpName = "Ping";
      objUdp.UdpCommand = "PG:A\n";
      listUdp.Add(objUdp);

      objUdp = new UdpH();
      objUdp.UdpName = "Enable Debug";
      objUdp.UdpCommand = "DB:ON\n";
      listUdp.Add(objUdp);

      objUdp = new UdpH();
      objUdp.UdpName = "Disable Debug";
      objUdp.UdpCommand = "DB:OFF\n";
      listUdp.Add(objUdp);

      objUdp = new UdpH();
      objUdp.UdpName = "Get ESP Version";
      objUdp.UdpCommand = "VER:ESP\n";
      listUdp.Add(objUdp);

      objUdp = new UdpH();
      objUdp.UdpName = "Get ST Version";
      objUdp.UdpCommand = "VER:ST\n";
      listUdp.Add(objUdp);

      cbxUdp.DataSource = listUdp;
      cbxUdp.DisplayMember = "UdpName";
      cbxUdp.ValueMember = "UdpCommand";
    }

    private void btnUdpSend_Click(object sender, EventArgs e) {
      txtResponseWin.Text += cbxUdp.SelectedValue;
      txtResponseWin.Text = "";

      string command = cbxUdp.SelectedValue.ToString();

      if (command == "PG:ALL\n") {
        secondArgument = "IP:	";
        SendUdpCommand(command, true);
        txtResponseWin.Text = "Getting all devices on the Network..";
      }

      else if (command == "VER:ST\n") {
        txtResponseWin.Text = "Getting ST Version.." + Environment.NewLine + Environment.NewLine + "Responce: " + Environment.NewLine;
        secondArgument = "VER:	";
        SendUdpCommand(command);
      }

      else if (command == "VER:ESP\n") {
        txtResponseWin.Text = "Getting ESP Version.." + Environment.NewLine + Environment.NewLine + "Responce: " + Environment.NewLine;
        secondArgument = "VER:	";
        SendUdpCommand(command);
      }

      else if (command == "PG:A\n") {
        txtResponseWin.Text = "Sending Ping to Device.." + Environment.NewLine + Environment.NewLine + "Responce: " + Environment.NewLine;
        secondArgument = "IP:	";
        command = "PG:ALL\n";
        SendUdpCommand(command);
      }

      else if (command == "DB:ON\n") {
        txtResponseWin.Text = "Sending Debug Enable.." + Environment.NewLine + Environment.NewLine + "Responce: " + Environment.NewLine;
        secondArgument = "MSG:	";
        SendUdpCommand(command);
      }

      else if (command == "DB:OFF\n") {
        txtResponseWin.Text = "Sending Debug Disable.." + Environment.NewLine + Environment.NewLine + "Responce: " + Environment.NewLine;
        secondArgument = "MSG:	";
        SendUdpCommand(command);
      }

      else {

        txtResponseWin.Text = "Sending Command: " + command + Environment.NewLine + Environment.NewLine + "Responce: " + Environment.NewLine;
        SendUdpCommand(command);
      }
    }

    private void btnShowAllDevices_Click(object sender, EventArgs e) {
      secondArgument = "IP:	";
      String command = "PG:ALL\n";
      SendUdpCommand(command, true);
      txtResponseWin.Text = "Getting all devices on the Network..";
    }

    private void btnPing_e(object sender, EventArgs e) {
      txtResponseWin.Text = "Sending Ping to Device.." + Environment.NewLine + Environment.NewLine + "Responce: " + Environment.NewLine;
      secondArgument = "IP:	";
      String command = "PG:ALL\n";

      SendUdpCommand(command);
    }

    private void btnDebugEnable(object sender, EventArgs e) {
      txtResponseWin.Text = "Sending Debug Enable.." + Environment.NewLine + Environment.NewLine + "Responce: " + Environment.NewLine;
      secondArgument = "MSG:	";
      String command = "DB:ON\n";

      SendUdpCommand(command);
    }

    private void btnShowSTVersion_e(object sender, EventArgs e) {
      String command = "VER:ST\n";
      txtResponseWin.Text = "Getting ST Version.." + Environment.NewLine + Environment.NewLine + "Responce: " + Environment.NewLine;
      secondArgument = "VER:	";

      SendUdpCommand(command);
    }

    private void btnShowESPVersion_e(object sender, EventArgs e) {
      txtResponseWin.Text = "Getting ESP Version.." + Environment.NewLine + Environment.NewLine + "Responce: " + Environment.NewLine;
      String command = "VER:ESP\n";
      secondArgument = "VER:	";

      SendUdpCommand(command);
    }

    private void btnDebugDisable(object sender, EventArgs e) {
      txtResponseWin.Text = "Sending Debug Disable.." + Environment.NewLine + Environment.NewLine + "Responce: " + Environment.NewLine;
      secondArgument = "MSG:	";
      String command = "DB:OFF\n";

      SendUdpCommand(command);
    }

    private void btnEraseEeprom(object sender, EventArgs e) {
    }

    private void txtResponseWin_TextChanged(object sender, EventArgs e) {
      txtResponseWin.SelectionStart = txtResponseWin.Text.Length;
      txtResponseWin.ScrollToCaret();
    }

    private void btnResetLogs_Click(object sender, EventArgs e) {
      txtResponseWin.Text = "";
    }

    private void btnShowWifi(object sender, EventArgs e) {

      String command = "WL:\n";
      String target = cbxDeviceIp.Text;
      tcpCommand = 1;

      MakeConnection(target, command);
    }

    private void btnChangeWifi(object sender, EventArgs e) {
      String ssid = textBox3.Text;
      String pass = textBox4.Text;

      String command = "ST:" + ssid + "," + pass + ",\n";
      String target = cbxDeviceIp.Text;

      tcpCommand = 2;

      MakeConnection(target, command);
    }

    private void objSocketClientAsync_OnDisconnect(string IP, int Socket, string ErrorMessage = "", string AdditionalDetails = "") {
      throw new NotImplementedException();
    }

    private void objSocketClientAsync_OnErrorOccured(string Message, string Details = "") {
      MessageBox.Show("Error: haider" + Message);
    }

    private void objSocketClientAsync_OnDataReceived(byte[] RawData, Socket RxSocket) {

      String message = Encoding.ASCII.GetString(RawData);

      this.Invoke(new Action(() => {

        if (tcpCommand == 1) {

          string[] ssidsAllInfo = message.Split(',');
          int noOfSsids = ssidsAllInfo.Length;

          for (int a = 0; a < noOfSsids - 1; a++) {

            txtResponseWin.Text += Environment.NewLine + "====================";

            string[] insideInfo = ssidsAllInfo[a].Split(':');
            int noOfInsideInfo = insideInfo.Length;

            for (int b = 0; b < noOfInsideInfo; b++) {

              String text = "";
              bool isLast = false;

              if (b == 0)
                text = "SSID:	";
              else if (b == 1)
                text = "Signal:	";
              else {
                text = "Security:	";
                isLast = true;
              }
              txtResponseWin.Text += Environment.NewLine + text + insideInfo[b] + (isLast ? Environment.NewLine : "");
            }
          }
        }

        else if (tcpCommand == 2) {

          if (message == "ACK\n") {
            txtResponseWin.Text += Environment.NewLine + Environment.NewLine + "Device wifi successfuly changed!";
          }
        }

      }));
    }

    private void objSocketClientAsync_OnConnect(string IP, int Socket, string ErrorMessage = "", string AdditionalDetails = "") {

      this.Invoke(new Action(() => {

        txtResponseWin.Text = Environment.NewLine + "Connected to Device: " + IP;
        txtResponseWin.Text += Environment.NewLine + Environment.NewLine + "Please wait.." + Environment.NewLine;

      }));
    }

    private void timer1_Tick(object sender, EventArgs e) {
      toolStripStatusLabel1.Text = DateTime.Now.ToString("dddd , dd, MMM yyyy    |    hh:mm:ss");

      if (isMqttStarted == true) {

        bool MqttStatus = MQTTclient.IsConnected;

        if (MqttStatus == false) {
          MqttDisconnect(true);
        }
      }
    }

    private void btnMqttConnect_Click(object sender, EventArgs e) {

      try {

        if (btnMqttConnect.Text == "Connect")
          MqttConnect();

        else if (btnMqttConnect.Text == "Disconnect")
          MqttDisconnect();
      }

      catch (uPLibrary.Networking.M2Mqtt.Exceptions.MqttConnectionException) {
        MessageBox.Show("Network connectivity error!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      catch (Exception a) {
        MessageBox.Show(a.ToString());
      }
    }

    private void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) {

      this.Invoke(new Action(() => {

        txtResponceMQTT.Text += Environment.NewLine + Environment.NewLine + "Received MQTT message [ " + DateTime.Now.ToString("hh:mm:ss") + " ]"
                                                    + Environment.NewLine
                                                    + Environment.NewLine;

        String message = Encoding.UTF8.GetString(e.Message);

        try {
          JObject o = JObject.Parse(message);
          String state = (o["state"].ToString());
          txtResponceMQTT.Text += state;
        }

        catch (Newtonsoft.Json.JsonReaderException) {

          txtResponceMQTT.Text += "Invaid message format!" + Environment.NewLine + Environment.NewLine;
          txtResponceMQTT.Text += message;
        }


      }));
    }

    private void txtResponceMQTT_TextChanged(object sender, EventArgs e) {
      txtResponceMQTT.SelectionStart = txtResponceMQTT.Text.Length;
      txtResponceMQTT.ScrollToCaret();
    }

    private void btnEraseResponceWin_Click(object sender, EventArgs e) {
      txtResponceMQTT.Text = "";
    }

    private void txtHeartbeat_TextChanged(object sender, EventArgs e) {

      if (txtHeartbeat.Text != "") {

        int secs = Convert.ToInt32(txtHeartbeat.Text) * 30;
        double mins = (secs / 60d);
        lblHeartbeatMinutes.Text = "X 30s = " + mins.ToString() + " Min";
      }
      else
        lblHeartbeatMinutes.Text = "X 30s = " + "0" + " Min";
    }

    private void btnSendMqtt_Click(object sender, EventArgs e) {

      String MqttMsgHeartbeat = Convert.ToInt32(txtHeartbeat.Text).ToString("D3");

      String MqttMsg = "{\"state\":{\"reported\":null,\"desired\":{\"MqttServer\":\""
                                          + cbxMqttDeviceServer.Text
                                          + "\",\"ASrc\":\"Cloud\",\"CMD\":\"SETCONFIG\",\"TS\":\"1466245734\",\"Heartbeat\":\""
                                          + MqttMsgHeartbeat
                                          + "\"}}}";


      ushort msgIdPub = MQTTclient.Publish(topicPub, Encoding.UTF8.GetBytes(MqttMsg), MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, false);
    }

    private void btnCurrentConfig_Click(object sender, EventArgs e) {

      String MqttMsg = "{\"state\":{\"reported\":null,\"desired\":{\"ASrc\":\"Cloud\",\"CMD\":\"GETCONFIG\",\"TS\":\"1466245734\"}}}";

      ushort msgIdPub = MQTTclient.Publish(topicPub, Encoding.UTF8.GetBytes(MqttMsg), MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, false);
    }

    private void cbxDeviceIp_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void fullBrightToolStripMenuItem_Click(object sender, EventArgs e) {

      string command = "L4080,4080,4080,4080,\n";

      SendUdpCommand(command);
    }

    private void trkWhite_ValueChanged(object sender, EventArgs e) {

      i_white = trkWhite.Value;

      lblBright.Text = "Brightness: " + i_white.ToString();

      i_white = (i_white / 255.0) * 4080;
      white = i_white.ToString();

      string command = "L" + red + "," + green + "," + blue + "," + white + ",\n";

      SendUdpCommand(command);

    }

    private void seletColorToolStripMenuItem_Click(object sender, EventArgs e) {

      colorDialog1.ShowDialog();

      i_red = colorDialog1.Color.R;
      i_green = colorDialog1.Color.G;
      i_blue = colorDialog1.Color.B;

      txtResponseWin.Text += "==========================" + Environment.NewLine;
      txtResponseWin.Text += "Red: " + i_red.ToString() + Environment.NewLine;
      txtResponseWin.Text += "Green: " + i_green.ToString() + Environment.NewLine;
      txtResponseWin.Text += "Blue: " + i_blue.ToString() + Environment.NewLine;

      i_red = (i_red / 255.0) * 4080;
      i_green = (i_green / 255.0) * 4080;
      i_blue = (i_blue / 255.0) * 4080;
      i_white = (i_white / 225.0) * 4080;

      red = i_red.ToString();
      green = i_green.ToString();
      white = i_white.ToString();
      blue = i_blue.ToString();

      txtResponseWin.Text += Environment.NewLine;
      txtResponseWin.Text += "Command Red: " + red + Environment.NewLine;
      txtResponseWin.Text += "Command Green: " + green + Environment.NewLine;
      txtResponseWin.Text += "Command Blue: " + blue + Environment.NewLine;


      string command = "L" + red + "," + green + "," + blue + "," + white + ",\n";

      SendUdpCommand(command);
    }

    private void infoToolStripMenuItem_Click(object sender, EventArgs e) {
      MessageBox.Show("Version: 0.0.9\nAuthor: Haider Mirza", "About This Software", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }

    private void checksumCalculatorToolStripMenuItem_Click(object sender, EventArgs e) {

      txtResponseWin.Text = "";
      string path = "";
      byte ch;
      byte checkSum = 0;

      OpenFileDialog choofdlog = new OpenFileDialog();
      if (choofdlog.ShowDialog() == DialogResult.OK) {
        path = choofdlog.FileName;
        txtResponseWin.Text += Environment.NewLine + "File path: " + Environment.NewLine + path;
      }

      StreamReader reader;
      reader = new StreamReader(path);
      int removeGarbage = 0;
      do {
        ch = (byte) reader.Read();
        if (removeGarbage == 1)
          checkSum ^= ch;

        if (ch == '$')
          removeGarbage = 1;
      }

      while (!reader.EndOfStream);
      reader.Close();
      reader.Dispose();

      FileInfo f = new FileInfo(path);
      long fileSize = f.Length - 1;

      txtResponseWin.Text += Environment.NewLine + Environment.NewLine + "Checksum: " + checkSum ;
      txtResponseWin.Text += Environment.NewLine + "Size: " + fileSize;
    }
  }

  public class UdpH {

    public string UdpName { get; set; }
    public string UdpCommand { get; set; }
    public string UdpArg { get; set; }
  }

  public class DeviceServer {

    public string DeviceServerName { get; set; }
    public string DeviceServerIp { get; set; }
  }
}