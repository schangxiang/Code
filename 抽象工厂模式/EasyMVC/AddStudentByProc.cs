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
    public partial class AddStudentByProc : Form
    {
        public MainFrm mFrm { get; set; }
        public string StuId { get; set; }
        StudentExt stuExt = null;
        public AddStudentByProc()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.StuId != null)
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

                int i = new StudentBLL().UpdateStudentByProc(stu1);
                if (i> 0)
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
                return;
                this.Close();

                this.mFrm.LoadDataGridView();
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

            int j = new StudentBLL().AddStudentByProc(stu);
            if (j > 0)
            {
                MessageBox.Show("添加成功");
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void AddStudentByProc_Load(object sender, EventArgs e)
        {
            List<Grade> gradeList = new GradeBLL().GetAllGrades();
            this.cboGarde.DataSource = gradeList;
            this.cboGarde.DisplayMember = "GradeName";
            this.cboGarde.ValueMember = "GradeId";


            if (this.StuId != null)
            {
                //查找此StuId的信息

                stuExt = new StudentBLL().GetStudentExt(this.StuId);

                this.tbStuId.Text = stuExt.StuId;
                this.tbStuName.Text = stuExt.StuName.ToString();
                this.tbBronDate.Text = stuExt.StuBornDate.ToShortDateString();
                //this.cboGarde.SelectedItem = stuExt.GradeName.ToString();

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
