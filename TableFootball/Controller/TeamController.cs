using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TableFootball.Model;
using System.Threading.Tasks;
using System.Drawing;

namespace TableFootball.Controller
{
    class TeamController
    {
        #region Add TEAM
        public bool Addteam(Team team)
        {
            try
            {
                DataContext db = new DataContext();
                db.Teams.Add(team);
                if (Convert.ToBoolean(db.SaveChanges()))
                {
                    db.Dispose();
                    return true;
                }
                else
                {
                    db.Dispose();
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        #endregion

        #region select All
        public List<Team> GetTeams()
        {
            DataContext db = new DataContext();
            return db.Teams.ToList();
        }
        public List<Team> GetTeams(int idlig)
        {
            DataContext db = new DataContext();
            return db.Teams.Where(z => z.LigID == idlig).ToList();
        }
        #endregion

        #region return Name
        public string GetName(int? id)
        {
            DataContext data = new DataContext();

            return data.Ligs.SingleOrDefault(z => z.ID == id).LigName;
        }


        #endregion

        #region delete
        public bool deleteTeam(int? id)
        {
            try
            {
                DataContext db = new DataContext();
                var q = db.Teams.SingleOrDefault(z => z.IDTeam == id);
                db.Teams.Remove(q);
                if (Convert.ToBoolean(db.SaveChanges()))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {

                return false;
            }
        }
        #endregion

        #region image return

        public Image Getpic(int? id)
        {
            DataContext data = new DataContext();
            string res = data.Teams.SingleOrDefault(z => z.IDTeam == id).LOGO;
            if (res != null)
            {
                Image newImage = Image.FromFile(res);
                return newImage;
            }
            else
            {
                var startupPath = TableFootball.Properties.Resources.not_available;
                return startupPath;
            }
        }
        #endregion

        #region UpdateGoal
        public bool UpdatePoint(int id, bool sec)
        {
            try
            {
                DataContext db = new DataContext();
                var q = db.Teams.SingleOrDefault(z => z.IDTeam == id);
                if (sec)
                {
                    q.Point += 3;
                }
                else
                {
                    q.Point += 1;
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        #endregion
    }
}
