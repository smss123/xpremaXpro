using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xprema.Data.CommandClass
{
   public class xUsersSystem
    {
        
        private   dbContainer db = new dbContainer();


        public bool AddUser(UserSystem Usr, int xid )
        {

            UserGroup Grp = new UserGroup();
            Grp = (from u in db.UserGroups where u.Id == xid select u).Single();
            Grp.UserSystems.Add(Usr);
            db.SaveChanges();
            return true;
        }




        public bool UpDateUser( int UsrID, string nam ,string pass ,int XGID )
        {
    
            try
            {
                UserSystem  U = db.UserSystems.Where(p => p.Id == UsrID).SingleOrDefault();
                UserGroup g = db.UserGroups.Where(gg => gg.Id == XGID).SingleOrDefault();
                if (U.Id != null)
                {
                    U .Password = pass ; U.UserName = nam ; 
                    U.UserGroup = g;
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

                                  
          
   

       
        public  bool  UserLogin(string UsrName, string UsrPass)
        {

            try
            {

                var GetUsr = (from U in db.UserSystems
                              where U.UserName == UsrName && U.Password == UsrPass
                              select U).SingleOrDefault();
                if (GetUsr.Id != null)
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception)
            {
                return false;
              
            }
        }


        public bool DeleteUser(int UsrID)
        {
            try
            {
                var U = db.UserSystems.Where(p => p.Id == UsrID).SingleOrDefault();
                if (U.Id != null)
                {
                    db.UserSystems.Remove(U);
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



        public List<UserSystem> GetAllUsers() { 
         var  AllUsers = ( from u in db.UserSystems   orderby u.UserName ascending select u ).ToList();
         return AllUsers;
        }

        public List<UserGroup> GetAllGroups() { return (db.UserGroups).ToList(); }

    }
    }

