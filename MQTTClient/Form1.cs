using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 // including the M2Mqtt Library
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTTClient
{
    public partial class Form1 : Form
    {

        string connectionString;

        string sqlUsername;
        string sqlPassword;
        string sqlServerName;
        string sqlDatabase;
        string sqlConnectionString;
        //MqttClient client = new MqttClient(IPAddress.Parse("192.168.10.53"));
        MqttClient client;
        string clientId;

        public Form1()
        {
            InitializeComponent();
            string BrokerAddress = "52.157.232.196";

            client = new MqttClient(BrokerAddress);

            // register a callback-function (we have to implement, see below) which is called by the library when a message was received
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            // use a unique id as client id, each time we start the application
            clientId = Guid.NewGuid().ToString();

            client.Connect(clientId);
        }

        protected override void OnClosed(EventArgs e)
        {
            client.Disconnect();

            base.OnClosed(e);
           //Application.Current.Shutdown();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        void client_MqttMsgUnsubscribed(object sender, MqttMsgUnsubscribedEventArgs e)
        {
            // write your code
        }

        void client_MqttMsgSubscribed(object sender, MqttMsgSubscribedEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
      
        }

        private void btnUbsubscribe_Click(object sender, EventArgs e)
        {
            string[] topics = { "sensor/temp", "sensor/humidity" };

            client.Unsubscribe(topics);
        }

        public void toSQL(string message, string topic)
        {
            sqlDatabase = "OMNITREND_TOOLS";//Properties.Settings.Default.sqlDatabase.ToString();
            sqlPassword = "Yello100";//Properties.Settings.Default.sqlPassword.ToString();
            sqlServerName = "ytsdtsql";//Properties.Settings.Default.sqlServerName.ToString();
            sqlUsername = "sa";//Properties.Settings.Default.sqlUsername.ToString();

            string connString = "user id=" + sqlUsername + ";password=" + sqlPassword + "; server=" + sqlServerName + "; database= " + sqlDatabase + ";connection timeout=30";

            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    String query = "INSERT INTO [MQTT] ([topic], [message]) VALUES (@val1, @val2)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@val1", topic);
                        command.Parameters.AddWithValue("@val2", message);

                        connection.Open();

                        int result = command.ExecuteNonQuery();
                        connection.Close();

                        // Check Error
                        if (result < 0)
                            MessageBox.Show("Could not add to database", "There was a problem.",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            //MessageBox.Show("Added");
                        }
                    }
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show("Could not add the finding data DETAILS - " + exe.Message, "There was a problem.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            if (txtTopicSubscribe.Text != "")
            {
                // whole topic
                string Topic = txtTopicSubscribe.Text;

                // subscribe to the topic with QoS 1
                client.Subscribe(new string[] { Topic }, new byte[] { 1 });   // we need arrays as parameters because we can subscribe to different topics with one call
              
                 txtReceived.Text = "";
            }
            else
            {
                txtInfo.Text = txtInfo.Text + "You have to enter a topic to subscribe!/r/n";
            }
        }

        // this code runs when a message was received
        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);
          //  string ReceivedTopic = Encoding.UTF8.GetString(e.Topic);


            txtReceived.Invoke((MethodInvoker)(() => txtReceived.Text = ReceivedMessage));
            toSQL(ReceivedMessage, e.Topic.ToString());


        }

    }
}
