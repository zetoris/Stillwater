using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Stillwater
{
    public partial class Form1 : Form
    {
        Process process = new Process();

        public Form1()
        {
            InitializeComponent();

            this.Text = "Stillwater " + Application.ProductVersion;

            // button_settings.Click += new EventHandler(button_start_Click);
            button_main_start.Click += new EventHandler(button_main_start_Click);
            button_main_opendefbr.Click += new EventHandler(button_main_opendefbr_Click);
            
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            try {
                process.StartInfo.FileName = File.ReadAllText("settings");
                //process.StartInfo.Arguments = "-n";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.Start();
            }
            catch
            {
                MessageBox.Show("Cannot start server.", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button_main_start_Click(object sender, System.EventArgs e) //OK
        { 
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();//вторая форма
            this.Show();
        }


        private void button_main_opendefbr_Click(object sender, System.EventArgs e) //OK
        {
            Process.Start("http://127.0.0.1:1984");
            this.WindowState = FormWindowState.Minimized;
        }


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