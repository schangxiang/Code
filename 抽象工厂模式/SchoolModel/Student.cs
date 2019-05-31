using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolModel
{
   public class Student
    {
       public int ID { get; set; }
       public string StuId { get; set; }
       public string StuName { get; set; }
       public bool StuSex { get; set; }
       public DateTime StuBornDate { get; set; }
       public string GradeId { get; set; }
    }
}
