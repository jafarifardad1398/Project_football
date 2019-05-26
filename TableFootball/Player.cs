using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TableFootball.Classes;
using TableFootball.Controller;
using Telerik.WinControls;

namespace TableFootball
{
    public partial class Player : Telerik.WinControls.UI.RadForm
    {
        public Player()
        {
            InitializeComponent();
        }

        #region frm_load
        private void Player_Load(object sender, EventArgs e)
        {
            GetLigscombo();
            GetData();
        }
        #endregion

        #region GetDatalig
        private void GetLigscombo()
        {
            TeamController team = new TeamController();
            var lst = team.GetTeams();
            txt_IDTeam.MultiColumnComboBoxElement.Rows.Add("0", "بازیکن آزاد");
            foreach (var item in lst)
            {
                txt_IDTeam.MultiColumnComboBoxElement.Rows.Add(item.IDTeam.ToString(), item.TeamName.ToString());
                txt_TeamUpdate.MultiColumnComboBoxElement.Rows.Add(item.IDTeam.ToString(), item.TeamName.ToString());
            }


        }
        #endregion

        #region btn_create player
        private void Btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                PlayerController playerC = new PlayerController();

                TableFootball.Model.Player playersam = new Model.Player();

                playersam.Name = txt_Nameplayer.Text.Trim();
                playersam.Family = txt_familyplayer.Text.Trim();
                playersam.Age = txt_ageplayer.Value.Date;
                if (txt_IDTeam.Text != "0")
                    playersam.IDTeam = int.Parse(txt_IDTeam.Text);
                if (playerC.Addplayer(playersam))
                {
                    RadMessageBox.Show("بازیکن با موفقیت ثبت شد", "اعلان", MessageBoxButtons.OK, RadMessageIcon.Info);
                    this.Close();
                }
                else
                {
                    RadMessageBox.Show("ثبت بازیکن با شکست روبرو شد", "خطا", MessageBoxButtons.OK, RadMessageIcon.Info);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Load_DATA
        private void GetData()
        {
            try
            {
                radGridView1.Rows.Clear();
                PlayerController PLAYERc = new PlayerController();
                var lst = PLAYERc.Getplaters();
                foreach (var item in lst)
                {
                    if (item.IDTeam != null)
                        radGridView1.Rows.Add(item.ID, item.Name, item.Family, calcAge.Getage(item.Age.ToString()), PLAYERc.GetName(item.IDTeam));
                    else
                        radGridView1.Rows.Add(item.ID, item.Name, item.Family, calcAge.Getage(item.Age.ToString()), "بارزیکن آزاد");
                }
            }
            catch (Exception)
            {

                RadMessageBox.Show("در بارگدپذاری اطلاعات مشکلی پیش آمده ");
            }
        }
        #endregion

        #region delete

        private void RadGridView1_Click(object sender, EventArgs e)
        {

        }

        private void RadGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                PlayerController playersample = new PlayerController();
                int id = int.Parse(radGridView1.CurrentRow.Cells[0].Value.ToString());
                if (playersample.deleteplayer(id))
                {
                    GetData();
                    RadMessageBox.Show("بازیکن مورد نظر حذف شد", "اطلاعات");
                }
            }
            catch (Exception)
            {

                RadMessageBox.Show("حذف بازیکن با شکست روبرو شد", "هشدار", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
        }
        #endregion

        #region binding data
        private void RadTextBox1_MouseLeave(object sender, EventArgs e)
        {
            if (txt_IDplayer.Text !=string.Empty)
            {
                PlayerController pc = new PlayerController();

                var res = pc.getupdate(int.Parse(txt_IDplayer.Text));

                if (res != null)
                {
                    txt_TeamUpdate.Text = res.IDTeam.ToString();
                    txt_TeamUpdate.Enabled = true;
                    txt_IDTeam.Enabled = false;
                }
                else
                {
                    RadMessageBox.Show("بازیکن وارد شده موجود نیست");
                }
            }

        }
        #endregion

        #region btn transfer
        private void Btn_transfer_Click(object sender, EventArgs e)
        {
            PlayerController pc = new PlayerController();

            if (pc.setupdate(int.Parse(txt_IDplayer.Text.Trim()), int.Parse(txt_TeamUpdate.Text.Trim())))
            {
                txt_TeamUpdate.Text = string.Empty;
                txt_TeamUpdate.Enabled = false;
                txt_IDplayer.Text = string.Empty;
                txt_IDplayer.Enabled = true;
                RadMessageBox.Show("انتقال بازیکن با موفقیت انجام شد", "اطلاع", MessageBoxButtons.OK, RadMessageIcon.Info);
            }
            else
            {
                txt_TeamUpdate.Text = string.Empty;
                txt_TeamUpdate.Enabled = false;
                txt_IDplayer.Text = string.Empty;
                txt_IDplayer.Enabled = true;
                RadMessageBox.Show("انتقال بازیکن با موفقیت انجام نشد", "خطا", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
        }
        #endregion
    }
}
