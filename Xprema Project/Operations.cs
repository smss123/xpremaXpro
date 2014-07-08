using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xprema_Project
{

   
    class Operations
    {
        private static readonly string deleteMessage = "هل انت متأكد/ة من عملية الحذف؟";

        public static string DeleteMessage
        {
            get { return Operations.deleteMessage; }
        }

        private static readonly string enterName = "من فضلك ادخل الاسم";

        public static string EnterName
        {
            get { return Operations.enterName; }
        }

        private static readonly string saveMessage = "هل تريد حفظ التغيرات؟؟";

        public static string SaveMessage
        {
            get { return Operations.saveMessage; }
           
        }

        private static readonly string editMessage = "تمت عملية التعديل";

        public static string EditMessage
        {
            get { return Operations.editMessage; }
            
        }

        private static readonly string saveMessageDone = "تمت عملية الاضافة";

        public static string SaveMessageDone
        {
            get { return Operations.saveMessageDone; }
          
        }

         
    }
}
