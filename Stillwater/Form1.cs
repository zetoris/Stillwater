using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Stillwater
{
    public partial class Form1 : Form
    {
        Process process = new Process();
        string mainServerPath   = "";
        string mainServerIP     = "";
        string mainServerPort   = "";

        public Form1()
        {
            InitializeComponent();

            this.Text = "Stillwater " + Application.ProductVersion;

            //reading settings (not affecting server's settings, just for open right adress in browser)
            if (File.Exists(@"localServerPath")) {mainServerPath = File.ReadAllText("localServerPath"); } else { File.WriteAllText("localServerPath", @"server\apache\bin\httpd.exe"); }
            if (File.Exists(@"localServerIP")) {mainServerIP = File.ReadAllText("localServerIP"); } else { File.WriteAllText("localServerIP", @"127.0.0.1"); }
            if (File.Exists(@"localServerPort")) {mainServerPort = File.ReadAllText("localServerPort"); } else { File.WriteAllText("localServerPort", @"1984"); }


            button_main_start.Click += new EventHandler(button_main_start_Click);//open built-in web browser
            button_main_opendefbr.Click += new EventHandler(button_main_opendefbr_Click);//use windows default browser and navigate to server page


            if (File.Exists(mainServerPath))
            {
                AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
                try
                {
                    process.StartInfo.FileName = mainServerPath;
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.Start();
                }
                catch
                {
                    MessageBox.Show("Cannot start web server", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // start buil-in browser

        private void button_main_start_Click(object sender, System.EventArgs e)
        { 
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }


        // start user's default browser

        private void button_main_opendefbr_Click(object sender, System.EventArgs e)
        {
            Process.Start(mainServerIP+":"+ mainServerPort);//open new browser tab
            this.WindowState = FormWindowState.Minimized;//minimizing app (to-do: minimize to tray)
        }


        // stop web server on exit (kill probably not the best solution)

        private void OnProcessExit(object sender, EventArgs e)
        {
            try {
                process.Kill();
            }
            catch
            {
                MessageBox.Show("Cannot stop server process. Stop it manually.", "Cannot stop server process", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}