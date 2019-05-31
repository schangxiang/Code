using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolModel;
using SQL.DAL;
using IDAL;
using DALFactory;

namespace School.BLL
{
   public class GradeBLL
    {
       private IGrade gradeDAL = DALFactory.DataAccess.CreateGrade();
       public List<Grade> GetAllGrades()
       {
           return gradeDAL.GetAllGrades();
       }
    }
}
