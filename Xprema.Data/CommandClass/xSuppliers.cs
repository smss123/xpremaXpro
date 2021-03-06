﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xprema.Data.CommandClass
{
    public class xSuppliers
    {
        private dbContainer db = new dbContainer();

       public bool AddNewSupplier( Supplier sp){
           try
           {
               db.Suppliers.Add(sp); 
               db.SaveChanges();
               return true;
           }
           catch (Exception)
           {

               return false;
           }
       }


       public bool EditSupplier(Supplier sp)
       {
           try
           {
               var tb = db.Suppliers.Where(p => p.ID == sp.ID).SingleOrDefault();
               if (tb.ID != null)
               {


                   tb.name = sp.name;
                   tb.PhoneNumber = sp.PhoneNumber;
                   tb.SuppliersNatural = sp.SuppliersNatural;
                   tb.Fax = sp.Fax;
                   tb.Email = sp.Email;
                   tb.Adderss = sp.Adderss;
                 
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



       public bool DeleteSupplier(int ID)
       {
           try
           {
               var tb = db.Suppliers.Where(p => p.ID == ID).SingleOrDefault();
               if (tb.ID != null)
               {

                   db.Suppliers.Remove(tb); 
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

       public List<Supplier> GetAllSuppliers() { return (db.Suppliers).ToList(); }


    }
    }

