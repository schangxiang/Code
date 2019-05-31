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
    public class StudentBLL
    {
        private IStudent studentDAL = DALFactory.DataAccess.CreateStudent();
        public List<StudentExt> GetAllStudentsFromStudentExt()
        {
            return studentDAL.GetAllStudentsFromStudentExt();
        }
        public StudentExt GetStudentExt(string stuId)
        {
            return studentDAL.GetStudentExt(stuId);
        }
        /// <summary>
        /// 通过Sql语句增加一条学生记录
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public int AddStudent(Student stu)
        {
            return studentDAL.AddStudent(stu);
        }
        /// <summary>
        /// 通过存储过程增加一条学生记录
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public int AddStudentByProc(Student stu)
        {
            return studentDAL.AddStudentByProc(stu);
        }
        /// <summary>
        /// 通过Sql语句更新一个学生信息
        /// </summary>
        /// <param name="stu">Student对象</param>
        /// <returns></returns>
        public int UpdateStudent(Student stu)
        {
            return studentDAL.UpdateStudent(stu);
        }
        /// <summary>
        /// 通过存储过程更新一条学生信息
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public int UpdateStudentByProc(Student stu)
        {
            return studentDAL.UpdateStudentByProc(stu);
        }
        /// <summary>
        /// 通过Sql语句删除一个学生信息
        /// </summary>
        /// <param name="stuId"></param>
        /// <returns></returns>
        public int DeleteStudent(string stuId)
        {
            return studentDAL.DeleteStudent(stuId);
        }
        /// <summary>
        /// 通过存储过程删除一条学生记录
        /// </summary>
        /// <param name="stuId"></param>
        /// <returns></returns>
        public int DeleteStudentByProc(string stuId)
        {
            return studentDAL.DeleteStudentByProc(stuId); ;
        }
    }
}
