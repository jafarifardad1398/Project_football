using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using TableFootball.Model;
using TableFootball.Controller;
using TableFootball.Classes;
using captchaCode;

namespace TableFootball
{
    public partial class LoginForm : Telerik.WinControls.UI.RadForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        #region Btn Login
        private void Btn_LogIn_Click(object sender, EventArgs e)
        {
            if (CsCaptcha.validate(txt_Captcha.Text))
            {
                Acounting Ac = new Acounting();
                if (Ac.LogIn(txt_UserName.Text.Trim(), txt_Password.Text))
                {
                    Country c = new Country();
                    c.Show();
                    this.Hide();
                }
                else
                {
                    Captcha.Image = CsCaptcha.CreateImage();
                    RadMessageBox.Show("نام کاربری یا گذر واژه معتبر نیست ", "هشدار", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                 
                }
            }
            else
            {
                Captcha.Image = CsCaptcha.CreateImage();
                RadMessageBox.Show("رمزینه وارد شده اشتباه می باشد ", "اعتبار رمزینه", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
               
            }

        }
        #endregion

        #region Form Load
        private void LoginForm_Load(object sender, EventArgs e)
        {
            Captcha.Image = CsCaptcha.CreateImage();
            DataContext data = new DataContext();
            data.Users.ToList();
        }
        #endregion

    }
}
