using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolModel;
using System.Data;
using System.Data.SqlClient;
using DBUtility;
using IDAL;

namespace SQL.DAL
{
    public class GradeDAL:IGrade
    {
        public List<Grade> GetAllGrades()
        {
            List<Grade> gradeList = new List<Grade>();

            string strSql = "select * from grade";

            using (SqlDataReader sdr = DbHelperSQL.ExecuteReader(CommandType.Text, strSql))
            {
                while (sdr.Read())
                {
                    Grade grade = new Grade();
                    grade.GradeId = sdr.GetString(0).ToString();
                    grade.GradeName = sdr.GetString(1).ToString();

                    gradeList.Add(grade);
                }
                return gradeList;
            }
        }
    }
}
