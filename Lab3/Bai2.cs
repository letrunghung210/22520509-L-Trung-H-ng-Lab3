using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Bai2 : Form
    {
        private Bai2 Server;
        public Bai2()
        {
            InitializeComponent();
        }

        private void listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread ServerThread = new Thread(new ThreadStart(StartUnsafeThread));
            ServerThread.Start();
        }

        private void StartUnsafeThread()
        {
            int byteReceived = 0;
            byte[] recv = new byte[1024];
            Socket clientSocket;

            try
            {
                Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                listenerSocket.Bind(ipepServer);
                listenerSocket.Listen(1);

                while (true) // Accept new connections indefinitely
                {
                    clientSocket = listenerSocket.Accept();
                    listViewCommand.Items.Add(new ListViewItem("New Client Connected"));

                    while (clientSocket.Connected)
                    {
                        string command = ""; // Accumulate commands

                        do
                        {
                            byteReceived = clientSocket.Receive(recv);
                            string str = Encoding.ASCII.GetString(recv, 0, byteReceived);
                            command += str;
                        } while (byteReceived > 0 && recv[byteReceived - 1] != '\n');

                        string receivedCommand = command.ToString();
                        listViewCommand.Items.Add(new ListViewItem(receivedCommand));

                        // Process the received command (e.g., echo it back)
                        // ...

                        // Check for potential disconnection
                        if (byteReceived == 0)
                        {
                            break; // Client disconnected
                        }
                    }

                    clientSocket.Close();
                    listViewCommand.Items.Add(new ListViewItem("Client Disconnected"));
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately
                Console.WriteLine("Error: " + ex.Message);
            }
        }


    }
}
