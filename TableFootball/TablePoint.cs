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

namespace TableFootball
{
    public partial class TablePoint : Telerik.WinControls.UI.RadForm
    {
        public TablePoint(int id)
        {
            InitializeComponent();
            GetData(id);
        }

        #region funk dataLoad
        private void GetData(int id)
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
                        radGridView1.Rows.Add(item.TeamName, item.Color1, item.Color2, item.SpanserName, teamc.GetName(item.LigID), item.Point, item.IDTeam, "");
                    }
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
