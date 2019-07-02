using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTM.Common.Model
{
    public class DTO_USERS
    {
        public string USER_ID { get; set; }
        public string USER_NAME { get; set; }
        public string USER_PASSWORD { get; set; }
        public string FULLNAME { get; set; }
        public string DEPARTMENT_ID { get; set; }
        public string STATUS { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public Nullable<System.DateTime> MODIFYTIME { get; set; }
        public string REMARK { get; set; }
    }
}
