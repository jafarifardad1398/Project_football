using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TableFootball.Controller;
using System.Threading;

namespace TableFootball
{
    public partial class Play : Telerik.WinControls.UI.RadForm
    {
        bool sec = false;
        public Play()
        {
            InitializeComponent();
        }

        #region Getlig
        private void comboLigset(RadMultiColumnComboBox combo, RadMultiColumnComboBox combo2)
        {
            MLig lig = new MLig();
            var lst = lig.GetLigs();
            foreach (var item in lst)
            {
                Image newImage = Image.FromFile(item.Address);
                combo.MultiColumnComboBoxElement.Rows.Add(item.ID.ToString(), item.LigName.ToString(), newImage);
                combo2.MultiColumnComboBoxElement.Rows.Add(item.ID.ToString(), item.LigName.ToString(), newImage);
            }
        }
        #endregion

        #region GetTeam
        private void comboTeamset(RadMultiColumnComboBox combo, int idlig)
        {
            TeamController team = new TeamController();
            var lst = team.GetTeams(idlig);
            foreach (var item in lst)
            {
                if (item.LOGO != null)
                {
                    Image newImage = Image.FromFile(item.LOGO);
                    combo.MultiColumnComboBoxElement.Rows.Add(item.IDTeam.ToString(), item.TeamName.ToString(), newImage);
                }
                else
                    combo.MultiColumnComboBoxElement.Rows.Add(item.IDTeam.ToString(), item.TeamName.ToString(), "");

            }
        }
        #endregion

        #region frm_Load
        private void Play_Load(object sender, EventArgs e)
        {
            comboLigset(COMBO_LIG1, COMBO_LIG2);
            sec = true;
        }
        #endregion

        #region load combo
        private void COMBO_TEAM1_SelectedValueChanged(object sender, EventArgs e)
        {

        }


        private void COMBO_LIG1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sec == true)
            {
                comboTeamset(COMBO_TEAM1, int.Parse(COMBO_LIG1.Text.Trim()));
            }
        }

        private void COMBO_TEAM2_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void COMBO_LIG2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sec == true)
            {
                comboTeamset(COMBO_TEAM2, int.Parse(COMBO_LIG2.Text.Trim()));
            }
        }
        #endregion

        #region btn_register_team1
        private void RadButton2_Click(object sender, EventArgs e)
        {
            if (COMBO_TEAM1.Text.Length > 0)
            {
                TeamController team = new TeamController();
                TEAMPIC1.Image = team.Getpic(int.Parse(COMBO_TEAM1.Text.Trim()));
                COMBO_LIG1.Enabled = false;
                COMBO_TEAM1.Enabled = false;
                radButton2.Visible = false;
                radButton2.Visible = false;
            }
            else
            {
                RadMessageBox.Show("تیم را ایتدا انتخاب کنید", "هشدار", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }

        }
        #endregion

        #region btn_register_team2
        private void RadButton1_Click(object sender, EventArgs e)
        {
            if (COMBO_TEAM2.Text.Length > 0)
            {
                TeamController team = new TeamController();
                TEAMPIC2.Image = team.Getpic(int.Parse(COMBO_TEAM2.Text.Trim()));
                COMBO_LIG2.Enabled = false;
                COMBO_TEAM2.Enabled = false;
                radButton1.Visible = false;
            }
            else
            {
                RadMessageBox.Show("تیم را ایتدا انتخاب کنید", "هشدار", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }

        }
        #endregion

        private void TEAMPIC1_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_submit_Click(object sender, EventArgs e)
        {
            bool res;
            TeamController team = new TeamController();
            if (num_team1.Value > num_team2.Value)
            {
                res = team.UpdatePoint(int.Parse(COMBO_TEAM1.Text), true);
                TEAMPIC1.Image = TableFootball.Properties.Resources.award;
            }
            else if (num_team1.Value == num_team2.Value)
            {
                res = team.UpdatePoint(int.Parse(COMBO_TEAM1.Text), false);
                res = team.UpdatePoint(int.Parse(COMBO_TEAM2.Text), false);
                TEAMPIC1.Image = TableFootball.Properties.Resources.equal_sign;
                TEAMPIC2.Image = TableFootball.Properties.Resources.equal_sign;

            }
            else
            {
                res = team.UpdatePoint(int.Parse(COMBO_TEAM2.Text), true);
                TEAMPIC2.Image = TableFootball.Properties.Resources.award;
            }

            if (res)
            {
                RadMessageBox.Show("نتیجه با موفقیت ثبت شد", "اعلان", MessageBoxButtons.OK, RadMessageIcon.Info);
                this.Close();
            }
            else
            {
                RadMessageBox.Show("ثبت نتیجه با مشکل رویرو شد", "خطا", MessageBoxButtons.OK, RadMessageIcon.Exclamation);

            }
        }
    }
}
