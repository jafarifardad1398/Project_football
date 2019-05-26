namespace TableFootball
{
    partial class LoginForm
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
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_UserName = new Telerik.WinControls.UI.RadTextBox();
            this.txt_Password = new Telerik.WinControls.UI.RadTextBox();
            this.btn_LogIn = new Telerik.WinControls.UI.RadButton();
            this.Captcha = new System.Windows.Forms.PictureBox();
            this.txt_Captcha = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LogIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Captcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Captcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TableFootball.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(67, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_UserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.ForeColor = System.Drawing.Color.Black;
            this.txt_UserName.Location = new System.Drawing.Point(67, 212);
            this.txt_UserName.MaxLength = 15;
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Padding = new System.Windows.Forms.Padding(7);
            // 
            // 
            // 
            this.txt_UserName.RootElement.StretchVertically = true;
            this.txt_UserName.Size = new System.Drawing.Size(191, 38);
            this.txt_UserName.TabIndex = 1;
            this.txt_UserName.Text = "Enter User Name";
            this.txt_UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_UserName.ThemeName = "VisualStudio2012Dark";
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.Black;
            this.txt_Password.Location = new System.Drawing.Point(67, 268);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Padding = new System.Windows.Forms.Padding(7);
            this.txt_Password.PasswordChar = '*';
            // 
            // 
            // 
            this.txt_Password.RootElement.StretchVertically = true;
            this.txt_Password.Size = new System.Drawing.Size(191, 38);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.Text = "Enter User Password";
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.ThemeName = "VisualStudio2012Dark";
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogIn.Location = new System.Drawing.Point(96, 433);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(128, 45);
            this.btn_LogIn.TabIndex = 4;
            this.btn_LogIn.Text = "LogIn";
            this.btn_LogIn.ThemeName = "VisualStudio2012Dark";
            this.btn_LogIn.Click += new System.EventHandler(this.Btn_LogIn_Click);
            // 
            // Captcha
            // 
            this.Captcha.Location = new System.Drawing.Point(67, 321);
            this.Captcha.Name = "Captcha";
            this.Captcha.Size = new System.Drawing.Size(191, 38);
            this.Captcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Captcha.TabIndex = 5;
            this.Captcha.TabStop = false;
            // 
            // txt_Captcha
            // 
            this.txt_Captcha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Captcha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Captcha.ForeColor = System.Drawing.Color.Black;
            this.txt_Captcha.Location = new System.Drawing.Point(67, 372);
            this.txt_Captcha.MaxLength = 10;
            this.txt_Captcha.Multiline = true;
            this.txt_Captcha.Name = "txt_Captcha";
            this.txt_Captcha.Padding = new System.Windows.Forms.Padding(7);
            // 
            // 
            // 
            this.txt_Captcha.RootElement.StretchVertically = true;
            this.txt_Captcha.Size = new System.Drawing.Size(191, 38);
            this.txt_Captcha.TabIndex = 6;
            this.txt_Captcha.Text = "Enter captcha ";
            this.txt_Captcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Captcha.ThemeName = "VisualStudio2012Dark";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 489);
            this.Controls.Add(this.txt_Captcha);
            this.Controls.Add(this.Captcha);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconScaling = Telerik.WinControls.Enumerations.ImageScaling.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_LogIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Captcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Captcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadTextBox txt_UserName;
        private Telerik.WinControls.UI.RadTextBox txt_Password;
        private Telerik.WinControls.UI.RadButton btn_LogIn;
        private System.Windows.Forms.PictureBox Captcha;
        private Telerik.WinControls.UI.RadTextBox txt_Captcha;
    }
}