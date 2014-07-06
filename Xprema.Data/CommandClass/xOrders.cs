using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xprema.Data.CommandClass
{
   public class xOrders
    {
       
         private dbContainer db = new dbContainer();

        public bool AddOrder(ProjectOrder ortb) {

            try
            {

                db.ProjectOrders.Add(ortb); db.SaveChanges(); return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool DeleteOrder(ProjectOrder ortb) {
            try
            {
                var tb = db.ProjectOrders.Where(c => c.ID == ortb.ID).SingleOrDefault();
                if (tb.ID != null)
                {
                    db.ProjectOrders.Remove(ortb);
                    db.SaveChanges(); return true;

                }
                else { return false; }
            }
            catch (Exception)
            {

                return false;
            }
        
        
        }



        public bool EditOrder(ProjectOrder ortb)
        {
            try
            {
                var tb = db.ProjectOrders.Where(c => c.ID == ortb.ID).SingleOrDefault();
                if (tb.ID != null)
                {
                    tb.OrderTitle = ortb.OrderTitle;
                    tb.OrderBody = ortb.OrderBody;
                    tb.OrderDate = ortb.OrderDate;
                  //  tb.ProjectProfile = ortb.ProjectProfile;
                    db.SaveChanges(); return true;

                }
                else { return false; }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<ProjectOrder> GetAllOrders() { return (db.ProjectOrders).ToList(); }
        public List<ProjectOrder> GetAllOrdersByDay( DateTime xdy ) 
        {
            var Ord =  ( from o in db.ProjectOrders 
                         where o.OrderDate ==  xdy 
                         orderby o.ID ascending 
                         select o ).ToList();
            return Ord;
        }


    }
    }

