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
using TableFootball.Model;
using TableFootball.Classes;

namespace TableFootball
{
    public partial class TeamForm : Telerik.WinControls.UI.RadForm
    {
        public TeamForm()
        {
            InitializeComponent();
        }

        #region Color_Picker

        private void Color_1_TextChanged(object sender, EventArgs e)
        {
        }


        private void RadButton1_Click(object sender, EventArgs e)
        {
            var r = radColorDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                var btn = (RadButton)sender;
                if (btn != null)
                {
                    if (btn.Name.Equals("color_1"))
                    {
                        color_1.BackColor = Color.FromArgb(radColorDialog1.SelectedColor.ToArgb());
                    }
                    else
                    {
                        color_2.BackColor = Color.FromArgb(radColorDialog1.SelectedColor.ToArgb());
                    }
                }
            }


        }
        #endregion

        #region btn_create_team
        private void Btn_Create_Click(object sender, EventArgs e)
        {
            TeamController team = new TeamController();
            Team teamm = new Team()
            {
                TeamName = txt_NameTeam.Text.Trim(),
                Color1 = color_1.BackColor.ToArgb().ToString(),
                Color2 = color_2.BackColor.ToArgb().ToString(),
                Point = 0,
                SpanserName = txt_SpanserName.Text,
                LOGO = txt_Url.Text.Trim(),
                LigID = int.Parse(radMultiColumnComboBox1.Text.Trim())
            };
            if (team.Addteam(teamm))
            {
                RadMessageBox.Show("تیم با موفقیت ثبت شد ", "اعلان", MessageBoxButtons.OK, RadMessageIcon.Info);
                this.Close();
            }
        }
        #endregion

        #region GetDatalig
        private void GetLigscombo()
        {
            MLig lig = new MLig();
            var lst = lig.GetLigs();
            foreach (var item in lst)
            {
                radMultiColumnComboBox1.MultiColumnComboBoxElement.Rows.Add(item.ID.ToString(), item.LigName.ToString());
            }
            //radMultiColumnComboBox1.MultiColumnComboBoxElement.DataSource=lstMain;


        }
        #endregion

        #region FORM LOAD

        private void TeamForm_Load(object sender, EventArgs e)
        {
            GetData();
            GetLigscombo();
        }
        #endregion

        #region select combo item
        private void RadMultiColumnComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
        }
        #endregion

        #region Key Down
        private void RadMultiColumnComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        #endregion

        #region Load_DATA
        private void GetData()
        {
            try
            {
                radGridView1.Rows.Clear();
                TeamController teamc = new TeamController();
                var lst = teamc.GetTeams();
                foreach (var item in lst)
                {
                    if (item.LOGO != null)
                    {
                        Image newImage = Image.FromFile(item.LOGO);
                        radGridView1.Rows.Add(item.TeamName, item.Color1, item.Color2, item.SpanserName, teamc.GetName(item.LigID), item.Point, item.IDTeam, newImage);
                    }
                    else
                    {
                        radGridView1.Rows.Add(item.TeamName, item.Color1, item.Color2, item.SpanserName, teamc.GetName(item.LigID), item.Point, item.IDTeam,"");
                    }
                }
            }
            catch (Exception)
            {

                RadMessageBox.Show("در بارگدپذاری اطلاعات مشکلی پیش آمده ");
            }
        }
        #endregion

        #region delete funk
        private void RadGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TeamController teamsample = new TeamController();
                int id = int.Parse(radGridView1.CurrentRow.Cells[6].Value.ToString());
                if (teamsample.deleteTeam(id))
                {
                    GetData();
                    RadMessageBox.Show("تیم مورد نظر حذف شد", "اطلاعات");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region select logo
        private void Btn_SelectPic_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog1.FileName = String.Empty;
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                txt_Url.Text = openFileDialog1.FileName.ToString();
            }
        }
        #endregion

    }
}
