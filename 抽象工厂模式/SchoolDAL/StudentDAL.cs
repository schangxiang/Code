using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolModel;
using DBUtility;
using System.Data.SqlClient;
using System.Data;
using IDAL;


namespace SQL.DAL
{
    public class StudentDAL:IStudent
    {
        /// <summary>
        /// 查询所有的Student和Grade表信息
        /// </summary>
        /// <returns>StudentExt对象集合</returns>
        public List<StudentExt> GetAllStudentsFromStudentExt()
        {
            List<StudentExt> stuExtList = new List<StudentExt>();
            string strSql = @"SELECT S.ID,S.StuId,S.StuName,S.StuSex
                                                  ,S.StuBornDate,S.GradeId,G.GradeName FROM Student S
                                                   INNER JOIN Grade G ON S.GradeId=G.GradeId 
                            ";

            using (SqlDataReader sdr = DbHelperSQL.ExecuteReader(CommandType.Text,strSql))
            {
                while (sdr.Read())
                {
                    //数据库字段顺序ID StuId StuName StuSex StuBornDate GradeId
                    StudentExt stuExt= new StudentExt();
                    stuExt.ID = sdr.GetInt32(0); //ID
                    stuExt.StuId = sdr.GetString(1).ToString();//StuId
                    stuExt.StuName = sdr.GetString(2).ToString();//StuName
                    stuExt.StuSex = sdr.GetBoolean(3);//StuSex
                    stuExt.StuBornDate = sdr.GetDateTime(4);//StuBornDate]
                    stuExt.GradeId = sdr.GetString(5).ToString();//GradeId
                    stuExt.GradeName = sdr.GetString(6).ToString();//GradeName

                    stuExtList.Add(stuExt);
                }
                return stuExtList;
            }
           
        }
        /// <summary>
        /// 根据stuId获取该学生信息
        /// </summary>
        /// <param name="stuId"></param>
        /// <returns></returns>
        public StudentExt GetStudentExt(string stuId)
        {
            string strSql = "select * from Student s,Grade g where StuId=@stuId and s.GradeId=g.GradeId";
            SqlParameter parm = new SqlParameter("@stuId",SqlDbType.VarChar,10);
            parm.Value = stuId;

            StudentExt stuExt=null;
            using (SqlDataReader sdr = DbHelperSQL.ExecuteReader(CommandType.Text, strSql, parm))
            {
                while (sdr.Read())
                {
                    stuExt = new StudentExt();
                    stuExt.ID = sdr.GetInt32(0); //ID
                    stuExt.StuId = sdr.GetString(1).ToString();//StuId
                    stuExt.StuName = sdr.GetString(2).ToString();//StuName
                    stuExt.StuSex = sdr.GetBoolean(3);//StuSex
                    stuExt.StuBornDate = sdr.GetDateTime(4);//StuBornDate]
                    stuExt.GradeId = sdr.GetString(5).ToString();//GradeId
                    stuExt.GradeName = sdr.GetString(6).ToString();//GradeName

                    break;
                }
                return stuExt;
            }
            
        }
        /// <summary>
        /// 添加一个学生，通过Sql语句
        /// </summary>
        /// <param name="stu">学生实体</param>
        /// <returns>受影响的行数</returns>
        public int AddStudent(Student stu)
        {
            string strSql = @"INSERT INTO Student(StuId,StuName,StuSex,StuBornDate,GradeId)
                        VALUES(@stuId,@stuName,@stuSex,@stuBornDate,@gradeId)";

            SqlParameter[] paras =
             {
                  new SqlParameter("@stuId",stu.StuId),
                  new SqlParameter("@stuName",stu.StuName),
                  new SqlParameter("@stuSex",stu.StuSex),
                  new SqlParameter("@stuBornDate",stu.StuBornDate),
                  new SqlParameter("@gradeId",stu.GradeId)
             };

            int val=DbHelperSQL.ExecuteNonQuery(CommandType.Text, strSql, paras);
            return val;
        }

        /// <summary>
        /// 添加一个学生，通过存储过程
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public int AddStudentByProc(Student stu)
        {
            SqlParameter param1=new SqlParameter ();
            param1.SqlDbType=SqlDbType.VarChar;
            param1.Size=10;
            param1.ParameterName="@stuId";
            param1.Value = stu.GradeId;

            SqlParameter param2=new SqlParameter ();
            param2.SqlDbType=SqlDbType.VarChar;
            param2.Size=50;
            param2.ParameterName="@stuName";
            param2.Value = stu.StuName;
            SqlParameter param3=new SqlParameter ();
            param3.SqlDbType=SqlDbType.Bit;
            param3.ParameterName="@stuSex";
            param3.Value = stu.StuSex;
            SqlParameter param4=new SqlParameter ();
            param4.SqlDbType=SqlDbType.DateTime;;
            param4.ParameterName="@stuBornDate";
            param4.Value = stu.StuBornDate;
             SqlParameter param5=new SqlParameter ();
            param5.SqlDbType=SqlDbType.VarChar;
            param5.Size=10;
            param5.ParameterName="@gradeId";
            param5.Value = stu.GradeId;

            //注意，这里是参数值数组，而不是参数数组,这里有5个参数
           object[] parasValues={param1.Value,param2.Value,param3.Value,param4.Value,param5.Value};

           int val = DbHelperSQL.ExecuteNonQuery("prAddStudent", parasValues);
           return val;
        }
        /// <summary>
        /// 通过Sql语句更新一个学生信息
        /// </summary>
        /// <param name="stu">Student对象</param>
        /// <returns></returns>
        public int UpdateStudent(Student stu)
        {
            string strSql = @"UPDATE Student SET StuId=@stuId,StuName=@stuName,StuSex=@stuSex,StuBornDate=@stuBornDate
                                 ,GradeId=@gradeId WHERE ID=@id";

            SqlParameter param1=new SqlParameter("@stuId",SqlDbType.VarChar,10);
            param1.Value=stu.StuId;
            SqlParameter param2=new SqlParameter ("@stuName",SqlDbType.VarChar,50);
            param2.Value=stu.StuName;
            SqlParameter param3=new SqlParameter ("@stuSex",SqlDbType.Bit);
            param3.Value=stu.StuSex;
            SqlParameter param4=new SqlParameter ("@stuBornDate",SqlDbType.DateTime);
            param4.Value=stu.StuBornDate;
            SqlParameter param5=new SqlParameter ("@gradeId",SqlDbType.VarChar,10);
            param5.Value=stu.GradeId;
            SqlParameter param6=new SqlParameter ("@id",SqlDbType.Int);
            param6.Value=stu.ID;
            SqlParameter[] paras={param1,param2,param3,param4,param5,param6};

           int j= DbHelperSQL.ExecuteNonQuery(CommandType.Text,strSql,paras);
           return j;
        }
        /// <summary>
        /// 通过存储过程更新一条学生信息
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public int UpdateStudentByProc(Student stu)
        {
            SqlParameter param1 = new SqlParameter("@stuId", SqlDbType.VarChar, 10);
            param1.Value = stu.StuId;
            SqlParameter param2 = new SqlParameter("@stuName", SqlDbType.VarChar, 50);
            param2.Value = stu.StuName;
            SqlParameter param3 = new SqlParameter("@stuSex", SqlDbType.Bit);
            param3.Value = stu.StuSex;
            SqlParameter param4 = new SqlParameter("@stuBornDate", SqlDbType.DateTime);
            param4.Value = stu.StuBornDate;
            SqlParameter param5 = new SqlParameter("@gradeId", SqlDbType.VarChar, 10);
            param5.Value = stu.GradeId;
            SqlParameter param6 = new SqlParameter("@id", SqlDbType.Int);
            param6.Value = stu.ID;
            object[] parasValues = { param1.Value, param2.Value, param3.Value, param4.Value, param5.Value, param6.Value };

           int j= DbHelperSQL.ExecuteNonQuery("prUpdateStudent", parasValues);
           return j;
        }
        /// <summary>
        /// 通过Sql语句删除一条学生记录
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public int DeleteStudent(string stuId)
        {
            string strSql="DELETE FROM Student WHERE StuId=@stuId";

            SqlParameter parm=new SqlParameter ("@stuId",SqlDbType.VarChar,10);
            parm.Value = stuId;

            int j=DbHelperSQL.ExecuteNonQuery(CommandType.Text,strSql,parm);
            return j;
        }
        /// <summary>
        /// 通过存储过程删除一条学生记录
        /// </summary>
        /// <param name="stuId"></param>
        /// <returns></returns>
        public int DeleteStudentByProc(string stuId)
        {
            SqlParameter parm = new SqlParameter("@stuId",SqlDbType.VarChar,10);
            parm.Value = stuId;
            //注意，这里传的参数是parm的参数值，如果有两个参数，则放到SqlParameter数组中
            int j = DbHelperSQL.ExecuteNonQuery("prDeleteStudent", parm.Value);
            return j;

        }
    }
}
