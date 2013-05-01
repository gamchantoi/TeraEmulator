namespace Launcher__version_0._1_beta_
{
    partial class LoginForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.button1 = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.l_login = new System.Windows.Forms.TextBox();
            this.l_password = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.r_login = new System.Windows.Forms.TextBox();
            this.r_password = new System.Windows.Forms.TextBox();
            this.r_repeat_password = new System.Windows.Forms.TextBox();
            this.r_email = new System.Windows.Forms.TextBox();
            this.r_first_name = new System.Windows.Forms.TextBox();
            this.r_last_name = new System.Windows.Forms.TextBox();
            this.register_content = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.login_content = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.register_content.SuspendLayout();
            this.login_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(468, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "вход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(468, 199);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(148, 20);
            this.login.TabIndex = 1;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(468, 238);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(148, 20);
            this.password.TabIndex = 2;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(573, 171);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(44, 20);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 385;
            this.lineShape2.X2 = 745;
            this.lineShape2.Y1 = 183;
            this.lineShape2.Y2 = 183;
            this.lineShape2.Click += new System.EventHandler(this.lineShape2_Click);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(1054, 519);
            this.shapeContainer2.TabIndex = 13;
            this.shapeContainer2.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // l_login
            // 
            this.l_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_login.BackColor = System.Drawing.SystemColors.ControlText;
            this.l_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.l_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_login.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_login.ForeColor = System.Drawing.Color.DarkOrange;
            this.l_login.Location = new System.Drawing.Point(201, 159);
            this.l_login.Multiline = true;
            this.l_login.Name = "l_login";
            this.l_login.Size = new System.Drawing.Size(361, 29);
            this.l_login.TabIndex = 7;
            this.l_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.l_login.TextChanged += new System.EventHandler(this.l_login_TextChanged);
            // 
            // l_password
            // 
            this.l_password.BackColor = System.Drawing.SystemColors.ControlText;
            this.l_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.l_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_password.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_password.ForeColor = System.Drawing.Color.DarkOrange;
            this.l_password.Location = new System.Drawing.Point(201, 212);
            this.l_password.Multiline = true;
            this.l_password.Name = "l_password";
            this.l_password.PasswordChar = '*';
            this.l_password.Size = new System.Drawing.Size(361, 29);
            this.l_password.TabIndex = 8;
            this.l_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial", 10F);
            this.button2.Location = new System.Drawing.Point(330, 262);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(242, 41);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // r_login
            // 
            this.r_login.BackColor = System.Drawing.SystemColors.InfoText;
            this.r_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.r_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.r_login.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_login.ForeColor = System.Drawing.Color.DarkOrange;
            this.r_login.Location = new System.Drawing.Point(266, 23);
            this.r_login.Multiline = true;
            this.r_login.Name = "r_login";
            this.r_login.Size = new System.Drawing.Size(318, 26);
            this.r_login.TabIndex = 1;
            this.r_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // r_password
            // 
            this.r_password.BackColor = System.Drawing.SystemColors.MenuText;
            this.r_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.r_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.r_password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_password.ForeColor = System.Drawing.Color.DarkOrange;
            this.r_password.Location = new System.Drawing.Point(266, 69);
            this.r_password.Multiline = true;
            this.r_password.Name = "r_password";
            this.r_password.PasswordChar = '*';
            this.r_password.Size = new System.Drawing.Size(318, 26);
            this.r_password.TabIndex = 2;
            this.r_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // r_repeat_password
            // 
            this.r_repeat_password.BackColor = System.Drawing.SystemColors.InfoText;
            this.r_repeat_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.r_repeat_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.r_repeat_password.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_repeat_password.ForeColor = System.Drawing.Color.DarkOrange;
            this.r_repeat_password.Location = new System.Drawing.Point(266, 116);
            this.r_repeat_password.Multiline = true;
            this.r_repeat_password.Name = "r_repeat_password";
            this.r_repeat_password.PasswordChar = '*';
            this.r_repeat_password.Size = new System.Drawing.Size(318, 26);
            this.r_repeat_password.TabIndex = 3;
            this.r_repeat_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // r_email
            // 
            this.r_email.BackColor = System.Drawing.SystemColors.InfoText;
            this.r_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.r_email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.r_email.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_email.ForeColor = System.Drawing.Color.DarkOrange;
            this.r_email.Location = new System.Drawing.Point(266, 161);
            this.r_email.Multiline = true;
            this.r_email.Name = "r_email";
            this.r_email.Size = new System.Drawing.Size(318, 26);
            this.r_email.TabIndex = 4;
            this.r_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // r_first_name
            // 
            this.r_first_name.BackColor = System.Drawing.SystemColors.InfoText;
            this.r_first_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.r_first_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.r_first_name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_first_name.ForeColor = System.Drawing.Color.DarkOrange;
            this.r_first_name.Location = new System.Drawing.Point(266, 208);
            this.r_first_name.Multiline = true;
            this.r_first_name.Name = "r_first_name";
            this.r_first_name.Size = new System.Drawing.Size(318, 26);
            this.r_first_name.TabIndex = 5;
            this.r_first_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // r_last_name
            // 
            this.r_last_name.BackColor = System.Drawing.SystemColors.InfoText;
            this.r_last_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.r_last_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.r_last_name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.r_last_name.ForeColor = System.Drawing.Color.DarkOrange;
            this.r_last_name.Location = new System.Drawing.Point(266, 259);
            this.r_last_name.Multiline = true;
            this.r_last_name.Name = "r_last_name";
            this.r_last_name.Size = new System.Drawing.Size(318, 26);
            this.r_last_name.TabIndex = 6;
            this.r_last_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // register_content
            // 
            this.register_content.BackColor = System.Drawing.SystemColors.Control;
            this.register_content.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("register_content.BackgroundImage")));
            this.register_content.Controls.Add(this.button4);
            this.register_content.Controls.Add(this.button3);
            this.register_content.Controls.Add(this.r_last_name);
            this.register_content.Controls.Add(this.r_first_name);
            this.register_content.Controls.Add(this.r_email);
            this.register_content.Controls.Add(this.r_repeat_password);
            this.register_content.Controls.Add(this.r_password);
            this.register_content.Controls.Add(this.r_login);
            this.register_content.Location = new System.Drawing.Point(647, 3);
            this.register_content.Name = "register_content";
            this.register_content.Size = new System.Drawing.Size(840, 448);
            this.register_content.TabIndex = 11;
            this.register_content.Paint += new System.Windows.Forms.PaintEventHandler(this.register_content_Paint);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOrange;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(13, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 41);
            this.button4.TabIndex = 22;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.label6_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(384, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 45);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 5;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(59, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 6;
            // 
            // login_content
            // 
            this.login_content.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_content.BackgroundImage")));
            this.login_content.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.login_content.Controls.Add(this.label1);
            this.login_content.Controls.Add(this.button5);
            this.login_content.Controls.Add(this.button2);
            this.login_content.Controls.Add(this.l_password);
            this.login_content.Controls.Add(this.l_login);
            this.login_content.Controls.Add(this.label4);
            this.login_content.Controls.Add(this.label3);
            this.login_content.Location = new System.Drawing.Point(0, 0);
            this.login_content.Name = "login_content";
            this.login_content.Size = new System.Drawing.Size(616, 451);
            this.login_content.TabIndex = 5;
            this.login_content.Visible = false;
            this.login_content.Paint += new System.Windows.Forms.PaintEventHandler(this.login_content_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("ParkAvenue BT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(360, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Create New Accaunt";
            this.label1.Click += new System.EventHandler(this.label5_Click);
            this.label1.MouseHover += new System.EventHandler(this.label5_MouseHover);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(330, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(251, 50);
            this.button5.TabIndex = 10;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 519);
            this.Controls.Add(this.register_content);
            this.Controls.Add(this.login_content);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shapeContainer2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.register_content.ResumeLayout(false);
            this.register_content.PerformLayout();
            this.login_content.ResumeLayout(false);
            this.login_content.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox l_login;
        private System.Windows.Forms.TextBox l_password;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox r_login;
        private System.Windows.Forms.TextBox r_password;
        private System.Windows.Forms.TextBox r_repeat_password;
        private System.Windows.Forms.TextBox r_email;
        private System.Windows.Forms.TextBox r_first_name;
        private System.Windows.Forms.TextBox r_last_name;
        private System.Windows.Forms.Panel register_content;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel login_content;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}

