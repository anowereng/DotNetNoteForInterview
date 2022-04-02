using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender
{
    static class MailSettings
    {
        public static string FromEmailAddress => "[From_Address]";
        public static string FromName => "anower";
        public static string SendGridAPIKey => "[SendGrid_API_Key]"; // copy from google credentials.xls file 
    }
}
