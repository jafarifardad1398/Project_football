using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableFootball.Model;
using TableFootball.Classes;
namespace TableFootball.Controller
{
    class MLig
    {
        #region Add Lig
        public bool Addlig(Model.Lig ligmodel)
        {
            try
            {
                DataContext db = new DataContext();
                db.Ligs.Add(ligmodel);
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

        #region Delete Lig
        public bool deleteLig(int? code)
        {
            try
            {
                DataContext db = new DataContext();
                var q = db.Ligs.SingleOrDefault(z => z.ID == code);
                db.Ligs.Remove(q);
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

        #region select all

        public List<Lig> GetLigs()
        {
            DataContext db = new DataContext();
            return db.Ligs.ToList();
        }

        #endregion

       

    }

}
