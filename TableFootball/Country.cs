using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TableFootball.Controller;
using TableFootball.Model;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace TableFootball
{
    public partial class Country : Telerik.WinControls.UI.RadForm
    {
        public Country()
        {
            InitializeComponent();
        }

        #region Add lig
        private void Btn_AddLig_Click(object sender, EventArgs e)
        {
            AddLig addlig = new AddLig();
            addlig.ShowDialog();
        }
        #endregion

        #region frm load
        private void Country_Load(object sender, EventArgs e)
        {
            AddNewImageTile();
        }
        #endregion

        #region Add Item Lig
        private void AddNewImageTile()
        {
            radPanorama1.Items.Clear();
            MLig lig = new MLig();
            var lst = lig.GetLigs();
            foreach (var item in lst)
            {
                Random random = new Random();
                int a = random.Next(1, 5);
                this.radPanorama1.Items.Add(RadTile(item, a));
            }
        }
        #endregion

        #region Element Item
        private RadTileElement RadTile(Lig lig, int a)
        {

            switch (a)
            {
                case 1:
                    {
                        RadTileElement tile = new RadTileElement();
                        Image newImage = Image.FromFile(lig.Address);
                        tile.Image = newImage;
                        tile.ImageLayout = ImageLayout.Zoom;
                        tile.BackColor = Color.FromArgb(147, 194, 35);
                        tile.RowSpan = 2;
                        tile.CellPadding = new Padding(5);
                        tile.Tag = lig.ID;
                        tile.Click += new System.EventHandler(carouselItem_Click);
                        return tile;
                    }
                case 2:
                    {
                        RadTileElement tile = new RadTileElement();
                        Image newImage = Image.FromFile(lig.Address);
                        tile.Image = newImage;
                        tile.ImageLayout = ImageLayout.Zoom;
                        tile.BackColor = Color.FromArgb(147, 194, 35);
                        tile.RowSpan = 1;
                        tile.CellPadding = new Padding(2);
                        tile.Tag = lig.ID;
                        tile.Click += new System.EventHandler(carouselItem_Click);
                        return tile;
                    }
                case 3:
                    {
                        RadTileElement tile = new RadTileElement();
                        Image newImage = Image.FromFile(lig.Address);
                        tile.Image = newImage;
                        tile.ImageLayout = ImageLayout.Zoom;
                        tile.BackColor = Color.FromArgb(147, 194, 35);
                        tile.RowSpan = 3;
                        tile.CellPadding = new Padding(2);
                        tile.Tag = lig.ID;
                        tile.Click += new System.EventHandler(carouselItem_Click);
                        return tile;
                    }
                case 4:
                    {
                        RadTileElement tile = new RadTileElement();
                        Image newImage = Image.FromFile(lig.Address);
                        tile.Image = newImage;
                        tile.ImageLayout = ImageLayout.Zoom;
                        tile.BackColor = Color.FromArgb(147, 194, 35);
                        tile.RowSpan = 1;
                        tile.CellPadding = new Padding(1);
                        tile.Tag = lig.ID;
                        tile.Click += new System.EventHandler(carouselItem_Click);
                        return tile;
                    }
                default:
                    {
                        RadTileElement tile = new RadTileElement();
                        Image newImage = Image.FromFile(lig.Address);
                        tile.Image = newImage;
                        tile.ImageLayout = ImageLayout.Zoom;
                        tile.BackColor = Color.FromArgb(147, 194, 35);
                        tile.RowSpan = 5;
                        tile.CellPadding = new Padding(2);
                        tile.Tag = lig.ID;
                        tile.Click += new System.EventHandler(carouselItem_Click);
                        return tile;
                    }
            }
        }

        private void carouselItem_Click(object sender, EventArgs e)
        {
            var rad = (RadTileElement)sender;
            if (rad != null)
            {
                //MessageBox.Show(rad.Tag.ToString());
                TablePoint frmtbl = new TablePoint(int.Parse(rad.Tag.ToString()));
                frmtbl.ShowDialog();

            }
        }
        #endregion

        #region Team
        private void Btn_TeamForm_Click(object sender, EventArgs e)
        {
            TeamForm frmteam = new TeamForm();
            frmteam.ShowDialog();
        }
        #endregion

        #region btn form player
        private void Btn_frmPlayer_Click(object sender, EventArgs e)
        {
            Player frmplayer = new Player();
            frmplayer.ShowDialog();
        }
        #endregion

        #region btn Ply
        private void RadButton4_Click(object sender, EventArgs e)
        {
            Play play = new Play();
            play.ShowDialog();
        }
        #endregion

        #region BTN REFRESH
        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            AddNewImageTile();
        }
        #endregion

    }
}
