namespace Stillwater
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_main_start = new System.Windows.Forms.Button();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_main_opendefbr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = global::Stillwater.Properties.Resources.logo_new;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 173);
            this.label1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Stillwater.Properties.Resources.icon_archive;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(107, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 42);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Stillwater.Properties.Resources.icon_unarchive;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(61, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 42);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_main_start
            // 
            this.button_main_start.BackgroundImage = global::Stillwater.Properties.Resources.icon_play;
            this.button_main_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_main_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_main_start.FlatAppearance.BorderSize = 0;
            this.button_main_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_main_start.ForeColor = System.Drawing.Color.Black;
            this.button_main_start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_main_start.Location = new System.Drawing.Point(12, 195);
            this.button_main_start.Name = "button_main_start";
            this.button_main_start.Size = new System.Drawing.Size(155, 47);
            this.button_main_start.TabIndex = 1;
            this.button_main_start.Text = "Stillwater\r\n browser";
            this.button_main_start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_main_start.UseVisualStyleBackColor = true;
            // 
            // button_settings
            // 
            this.button_settings.BackgroundImage = global::Stillwater.Properties.Resources.icon_settings;
            this.button_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Location = new System.Drawing.Point(15, 333);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(40, 42);
            this.button_settings.TabIndex = 10;
            this.button_settings.UseVisualStyleBackColor = true;
            // 
            // button_main_opendefbr
            // 
            this.button_main_opendefbr.BackgroundImage = global::Stillwater.Properties.Resources.icon_play;
            this.button_main_opendefbr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_main_opendefbr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_main_opendefbr.FlatAppearance.BorderSize = 0;
            this.button_main_opendefbr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_main_opendefbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_main_opendefbr.ForeColor = System.Drawing.Color.Black;
            this.button_main_opendefbr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_main_opendefbr.Location = new System.Drawing.Point(181, 195);
            this.button_main_opendefbr.Name = "button_main_opendefbr";
            this.button_main_opendefbr.Size = new System.Drawing.Size(152, 47);
            this.button_main_opendefbr.TabIndex = 11;
            this.button_main_opendefbr.Text = "Default \r\nbrowser";
            this.button_main_opendefbr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_main_opendefbr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 387);
            this.Controls.Add(this.button_main_opendefbr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_main_start);
            this.Controls.Add(this.button_settings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stillwater";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_main_start;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_main_opendefbr;
    }
}

