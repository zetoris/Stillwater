using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stillwater
{
    public partial class Form2 : Form
    {
        string localServerURL;
        string mainServerIP = "";
        string mainServerPort = "";
        int localServerPort;

        bool localServerWorking = true;

        private Timer tmrPing;//таймер проверки доступности сервера

        public Form2()
        {
            InitializeComponent();

            this.Text = "Stillwater Browser " + Application.ProductVersion;

            button_browser_back.Click += new EventHandler(button_browser_back_Click);
            button_browser_forward.Click += new EventHandler(button_browser_forward_Click);
            button_browser_go.Click += new EventHandler(button_browser_go_Click);
            button_browser_reload.Click += new EventHandler(button_browser_reload_Click);
            button_server_status.Click += new EventHandler(button_server_status_Click);
           
            label_logo.Click += new EventHandler(label_logo_Click);

            if (File.Exists(@"localServerIP")) { mainServerIP = File.ReadAllText("localServerIP"); } else { File.WriteAllText("localServerIP", @"127.0.0.1"); }
            if (File.Exists(@"localServerPort")) { mainServerPort = File.ReadAllText("localServerPort"); } else { File.WriteAllText("localServerPort", @"1984"); }

            webBrowser.Navigated += new WebBrowserNavigatedEventHandler(webBrowser_Navigated);

            tmrPing = new Timer();
            tmrPing.Interval = 1000;
            tmrPing.Tick += tmrPing_Tick;
            tmrPing.Enabled = true;
            tmrPing.Start();


            string porttemp = File.ReadAllText("localServerPort");
            Int32.TryParse(porttemp, out localServerPort);// 80;

            localServerURL = "http://"+ mainServerIP + ":"+localServerPort;
            webBrowser.Navigate(localServerURL);
        }


        private void tmrPing_Tick(object sender, EventArgs e)
        {
            bool ping = PingHost(mainServerIP, localServerPort);
            if (ping)
            {
                button_server_status.Image = global::Stillwater.Properties.Resources.icon_ok2;
                //label_server_status.Text = "SERVER\nONLINE";
                this.button_server_status.BackColor = System.Drawing.Color.White;
                localServerWorking = true;
            }
            else
            {
                this.button_server_status.Image = global::Stillwater.Properties.Resources.icon_warning4;
                //label_server_status.Text = "SERVER\nOFFLINE";
                this.button_server_status.BackColor = System.Drawing.Color.Red;
                localServerWorking = false;
            }
        }




        private bool PingHost(string _HostURI, int _PortNumber)
        {
            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                try
                {
                    socket.Connect(_HostURI, _PortNumber);
                }
                catch (SocketException ex)
                {
                    if (ex.SocketErrorCode == SocketError.ConnectionRefused)
                    {
                        tmrPing.Stop();
                        return false;
                    }
                }
                socket.Disconnect(false);
                return true;
            }

        }



        private void button_browser_back_Click(object sender, System.EventArgs e) //OK
        {
            if (webBrowser.CanGoBack)
            {
                webBrowser.GoBack();
            }
        }
        private void button_browser_forward_Click(object sender, System.EventArgs e) //OK
        {
            if (webBrowser.CanGoForward)
            {
                webBrowser.GoForward();
            }
        }
        private void button_browser_go_Click(object sender, System.EventArgs e) //OK
        {
            NavigateTo(textBox_browser_url.Text);

        }
        private void button_browser_reload_Click(object sender, System.EventArgs e) //OK
        {
                webBrowser.Refresh();
        }

        private void button_server_status_Click(object sender, System.EventArgs e) //OK
        {
            if (!localServerWorking)
            {
                MessageBox.Show("Local server is offline. Restart the application.", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label_logo_Click(object sender, System.EventArgs e) //OK
        {
            webBrowser.Navigate(localServerURL);

        }


        private void NavigateTo(string address)
        {
            if (string.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") && !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }


        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox_browser_url.Text = webBrowser.Url.ToString();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
