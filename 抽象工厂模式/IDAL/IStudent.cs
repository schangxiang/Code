using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchoolModel;

namespace IDAL
{
    public interface IStudent
    {
        List<StudentExt> GetAllStudentsFromStudentExt();
        StudentExt GetStudentExt(string stuId);
        int AddStudent(Student stu);
        int AddStudentByProc(Student stu);
        int UpdateStudent(Student stu);
        int UpdateStudentByProc(Student stu);
        int DeleteStudent(string stuId);
        int DeleteStudentByProc(string stuId);
    }
}
