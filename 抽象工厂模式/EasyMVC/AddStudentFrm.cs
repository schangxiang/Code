using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SchoolModel;
using School.BLL;

namespace EasyMVC
{
    public partial class AddStudentFrm : Form
    {
        GradeBLL gradeBLL = new GradeBLL();
        StudentBLL stuBLL = new StudentBLL();

        public MainFrm mFrm { get; set; }
        public string StuId { get; set; }

        StudentExt stuExt = null;
        public AddStudentFrm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.StuId != null) //说明是修改
            {
                Student stu1 = new Student();
                stu1.ID = stuExt.ID;
                stu1.StuId = tbStuId.Text.Trim().ToString();
                stu1.StuName = tbStuName.Text.Trim().ToString();
                //获取性别输入
                stu1.StuSex = false;
                if (this.rbtnMan.Checked)
                    stu1.StuSex = false;
                else
                    stu1.StuSex = true;

                stu1.StuBornDate = Convert.ToDateTime(this.tbBronDate.Text.Trim());
                stu1.GradeId = this.cboGarde.SelectedValue.ToString();

                int z = stuBLL.UpdateStudent(stu1);
                if (z> 0)
                {
                    MessageBox.Show("修改成功");
                }
                else
                {
                    MessageBox.Show("修改失败");
                }

                return;
            }
            Student stu = new Student();

            stu.StuId = tbStuId.Text.Trim().ToString();
            stu.StuName = tbStuName.Text.Trim().ToString();
            //获取性别输入
            stu.StuSex = false;
            if (this.rbtnMan.Checked)
                stu.StuSex = false;
            else
                stu.StuSex = true;

            stu.StuBornDate = Convert.ToDateTime(this.tbBronDate.Text.Trim());
            stu.GradeId = this.cboGarde.SelectedValue.ToString();

            int j= new StudentBLL().AddStudent(stu);
            if (j> 0)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
            return;

            this.mFrm.LoadDataGridView();
           
        }

        private void AddStudentFrm_Load(object sender, EventArgs e)
        {
            List<Grade> gradeList =gradeBLL.GetAllGrades();
            this.cboGarde.DataSource = gradeList;
            this.cboGarde.DisplayMember = "GradeName";
            this.cboGarde.ValueMember = "GradeId";


            if (this.StuId!=null)
            {
               //查找此StuId的信息

                stuExt = stuBLL.GetStudentExt(this.StuId);

                this.tbStuId.Text = stuExt.StuId;
                this.tbStuName.Text = stuExt.StuName.ToString();
                this.tbBronDate.Text = stuExt.StuBornDate.ToShortDateString();
                this.cboGarde.SelectedItem = stuExt.GradeName.ToString();

                if (stuExt.StuSex)
                {
                    this.rbtnMan.Checked = true;
                }
                else
                {
                    this.rbtnWoMan.Checked = true;
                }
            }
    
        }

    }
}
