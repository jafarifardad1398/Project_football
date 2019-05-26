using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using TableFootball.Controller;
using TableFootball.Model;
using System.IO;
using TableFootball.Classes;
using Telerik.WinControls.UI;

namespace TableFootball
{
    public partial class AddLig : Telerik.WinControls.UI.RadForm
    {
        public AddLig()
        {
            InitializeComponent();
        }

        #region Btn_Create Lig
        private void Btn_Create_Click(object sender, EventArgs e)
        {
            if (txt_Url.Text.Length > 0 && txt_NameLig.Text.Length > 0 && txt_CountryLig.Text.Length > 0)
            {
                try
                {
                    MLig ligsample = new MLig();
                    Lig ligdata = new Lig()
                    {
                        LigName = txt_NameLig.Text.Trim(),
                        CountryLig = txt_CountryLig.Text.Trim(),
                        Address = txt_Url.Text.Trim()
                    };
                    ligsample.Addlig(ligdata);
                    RadMessageBox.Show("ثبت اطلاعات با موفقیت انجام شد ", "اطلاع", MessageBoxButtons.OK, RadMessageIcon.Info);
                    this.Close();
                }
                catch (Exception)
                {

                    RadMessageBox.Show("ثبت اطلاعات با شکست روبرو شد لطفا مجدد تلاش کنید", "هشدار", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
                }
            }
            else
            {
                RadMessageBox.Show("لطفا موارد خالی را مقدار دهی کنید", "هشدار", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
            }
        }
        #endregion

        #region closed
        private void AddLig_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void AddLig_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        #endregion

        #region Btn select photo
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
        
        #region Form_Load
        private void AddLig_Load(object sender, EventArgs e)
        {
            getValuegrid();
        }
        #endregion

        #region click row
        private void RadGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                MLig ligsample = new MLig();
                int id = int.Parse(radGridView1.CurrentRow.Cells[0].Value.ToString());
                if (ligsample.deleteLig(id))
                {
                    getValuegrid();
                    RadMessageBox.Show("لیگ مورد نظر حذف شد","اطلاعات");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Load_Grid
        public  void getValuegrid()
        {
            try
            {
                radGridView1.Rows.Clear();
                MLig lig = new MLig();
                var lst = lig.GetLigs();
                foreach (var item in lst)
                {
                    Image newImage = Image.FromFile(item.Address);
                    radGridView1.Rows.Add(item.ID, item.LigName, item.CountryLig, newImage);
                }
            }
            catch (Exception)
            {

                RadMessageBox.Show("در بارگدپذاری اطلاعات مشکلی پیش آمده ");
            }
        }
        #endregion
    }
}
