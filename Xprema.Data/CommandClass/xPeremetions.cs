using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xprema.Data.CommandClass
{
  public  class xPeremetions
    {
       private dbContainer db = new dbContainer();
       public bool AddPermetions(SystemPermession per)
       {
           try
           {
               db.SystemPermessions.Add(per);
               db.SaveChanges();
               return true;
           }
           catch (Exception)
           {
               return false;
           }
       }



       public bool EditPermetions(SystemPermession per)
       {
           try
           {
               var tb = db.SystemPermessions.Where(p => p.Id == per.Id).SingleOrDefault();
               if (tb.Id != null)
               {
                   tb.PermessionName = per.PermessionName;
                   tb.PropertyName = per.PropertyName;
                   db.SaveChanges();
                   return true;

               }
               else { return false; }
           }
           catch (Exception)
           {
               return false;
           }
       }

       public bool DeleteCurrentPeremtions(SystemPermession per )
       {

           try
           {
               var tb = db.SystemPermessions.Where(p => p.Id == per.Id).SingleOrDefault();
               if (tb.Id != null)
               {
                   db.SystemPermessions.Remove(per);
                   db.SaveChanges();
                   return true;

               }
               else { return false; }
           }
           catch (Exception)
           {
               return false;
           }
       }
           public List <SystemPermession > GetAllPermssions(){

               return (db.SystemPermessions).ToList();
           }
      
    }
    }

