namespace Stillwater
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.textBox_browser_url = new System.Windows.Forms.TextBox();
            this.button_browser_reload = new System.Windows.Forms.Button();
            this.button_server_status = new System.Windows.Forms.Label();
            this.label_menu = new System.Windows.Forms.Button();
            this.label_logo = new System.Windows.Forms.Label();
            this.label_server_icon = new System.Windows.Forms.Label();
            this.button_browser_go = new System.Windows.Forms.Button();
            this.button_browser_forward = new System.Windows.Forms.Button();
            this.button_browser_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(0, 35);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1006, 528);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("http://localhost", System.UriKind.Absolute);
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            // 
            // textBox_browser_url
            // 
            this.textBox_browser_url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_browser_url.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_browser_url.Font = new System.Drawing.Font("Roboto Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_browser_url.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_browser_url.Location = new System.Drawing.Point(275, 3);
            this.textBox_browser_url.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.textBox_browser_url.Name = "textBox_browser_url";
            this.textBox_browser_url.Size = new System.Drawing.Size(622, 28);
            this.textBox_browser_url.TabIndex = 5;
            this.textBox_browser_url.Text = "http://localhost";
            // 
            // button_browser_reload
            // 
            this.button_browser_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_browser_reload.FlatAppearance.BorderSize = 0;
            this.button_browser_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_browser_reload.Image = global::Stillwater.Properties.Resources.icon_refresh1;
            this.button_browser_reload.Location = new System.Drawing.Point(231, 3);
            this.button_browser_reload.Name = "button_browser_reload";
            this.button_browser_reload.Size = new System.Drawing.Size(40, 28);
            this.button_browser_reload.TabIndex = 10;
            this.button_browser_reload.UseVisualStyleBackColor = true;
            // 
            // button_server_status
            // 
            this.button_server_status.BackColor = System.Drawing.Color.Transparent;
            this.button_server_status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_server_status.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_server_status.Image = global::Stillwater.Properties.Resources.icon_ok2;
            this.button_server_status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_server_status.Location = new System.Drawing.Point(95, 3);
            this.button_server_status.Name = "button_server_status";
            this.button_server_status.Size = new System.Drawing.Size(38, 28);
            this.button_server_status.TabIndex = 9;
            this.button_server_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_menu
            // 
            this.label_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_menu.FlatAppearance.BorderSize = 0;
            this.label_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_menu.Image = global::Stillwater.Properties.Resources.icon_menu;
            this.label_menu.Location = new System.Drawing.Point(962, 3);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(43, 28);
            this.label_menu.TabIndex = 8;
            this.label_menu.UseVisualStyleBackColor = true;
            // 
            // label_logo
            // 
            this.label_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_logo.Image = global::Stillwater.Properties.Resources.logo_new_30;
            this.label_logo.Location = new System.Drawing.Point(3, 2);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(30, 30);
            this.label_logo.TabIndex = 7;
            // 
            // label_server_icon
            // 
            this.label_server_icon.BackColor = System.Drawing.Color.Transparent;
            this.label_server_icon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_server_icon.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_server_icon.Image = global::Stillwater.Properties.Resources.icon_server;
            this.label_server_icon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_server_icon.Location = new System.Drawing.Point(59, 3);
            this.label_server_icon.Name = "label_server_icon";
            this.label_server_icon.Size = new System.Drawing.Size(40, 28);
            this.label_server_icon.TabIndex = 6;
            this.label_server_icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_browser_go
            // 
            this.button_browser_go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_browser_go.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_browser_go.FlatAppearance.BorderSize = 0;
            this.button_browser_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_browser_go.Image = global::Stillwater.Properties.Resources.icon_enter;
            this.button_browser_go.Location = new System.Drawing.Point(903, 3);
            this.button_browser_go.Name = "button_browser_go";
            this.button_browser_go.Size = new System.Drawing.Size(53, 28);
            this.button_browser_go.TabIndex = 4;
            this.button_browser_go.UseVisualStyleBackColor = true;
            // 
            // button_browser_forward
            // 
            this.button_browser_forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_browser_forward.FlatAppearance.BorderSize = 0;
            this.button_browser_forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_browser_forward.Image = global::Stillwater.Properties.Resources.icon_forward2;
            this.button_browser_forward.Location = new System.Drawing.Point(196, 3);
            this.button_browser_forward.Name = "button_browser_forward";
            this.button_browser_forward.Size = new System.Drawing.Size(27, 28);
            this.button_browser_forward.TabIndex = 3;
            this.button_browser_forward.UseVisualStyleBackColor = true;
            // 
            // button_browser_back
            // 
            this.button_browser_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_browser_back.FlatAppearance.BorderSize = 0;
            this.button_browser_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_browser_back.Image = global::Stillwater.Properties.Resources.icon_back2;
            this.button_browser_back.Location = new System.Drawing.Point(152, 3);
            this.button_browser_back.Name = "button_browser_back";
            this.button_browser_back.Size = new System.Drawing.Size(38, 28);
            this.button_browser_back.TabIndex = 2;
            this.button_browser_back.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.button_browser_reload);
            this.Controls.Add(this.button_server_status);
            this.Controls.Add(this.label_menu);
            this.Controls.Add(this.label_logo);
            this.Controls.Add(this.label_server_icon);
            this.Controls.Add(this.textBox_browser_url);
            this.Controls.Add(this.button_browser_go);
            this.Controls.Add(this.button_browser_forward);
            this.Controls.Add(this.button_browser_back);
            this.Controls.Add(this.webBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Stillwater Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button button_browser_back;
        private System.Windows.Forms.Button button_browser_forward;
        private System.Windows.Forms.Button button_browser_go;
        private System.Windows.Forms.TextBox textBox_browser_url;
        private System.Windows.Forms.Label label_server_icon;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.Button label_menu;
        private System.Windows.Forms.Label button_server_status;
        private System.Windows.Forms.Button button_browser_reload;
    }
}