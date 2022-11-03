using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerSupportLogger.Models
{
    public class CustLogInfoModel
    {
        public int LogId { get; set; }
        public string CustEmail { get; set; }
        public string CustName { get; set; }
        public string LogStatus { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
    }
}