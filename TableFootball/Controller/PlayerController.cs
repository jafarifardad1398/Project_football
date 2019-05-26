using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableFootball.Model;

namespace TableFootball.Controller
{
    class PlayerController
    {
        #region Add player
        public bool Addplayer(Model.Player player)
        {
            try
            {
                DataContext db = new DataContext();
                db.Players.Add(player);
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
        public List<Model.Player> Getplaters()
        {
            DataContext db = new DataContext();
            return db.Players.ToList();
        }
        #endregion

        #region return Name
        public string GetName(int? id)
        {
            DataContext data = new DataContext();

            return data.Teams.SingleOrDefault(z => z.IDTeam == id).TeamName;
        }
        #endregion

        #region delete
        public bool deleteplayer(int? id)
        {
            try
            {
                DataContext db = new DataContext();
                var q = db.Players.SingleOrDefault(z => z.ID == id);
                db.Players.Remove(q);
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

        #region getupdate
        public Model.Player getupdate(int? id)
        {
            try
            {
                DataContext db = new DataContext();
                Model.Player q = db.Players.SingleOrDefault(z => z.ID == id);
                return q;
            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion

        #region setupdate
        public bool setupdate(int? id,int teamID)
        {
            try
            {
                DataContext db = new DataContext();
                Model.Player q = db.Players.SingleOrDefault(z => z.ID == id);
                q.IDTeam = teamID;
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
