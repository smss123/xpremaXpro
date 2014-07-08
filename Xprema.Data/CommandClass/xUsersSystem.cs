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

        public bool AddUserSystems( UserSystem Usr)
        {
            try
            {
      
                db.UserSystems.Add(Usr);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool EditUserSystems(UserSystem Usr)
        {
            try
            {
             var U =   db.UserSystems.Where(p => p.Id == Usr.Id).SingleOrDefault();
             if (U .Id  != null)
             {
                 U.UserName = Usr.UserName;
                 U.Password = Usr.Password;
                 U.UserGroup = Usr.UserGroup;
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
    }
    }

