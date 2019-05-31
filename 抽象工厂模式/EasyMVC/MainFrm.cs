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
    public partial class MainFrm : Form
    {
        StudentBLL stuBll = new StudentBLL();
        GradeBLL graBLL = new GradeBLL();
        public StudentExt StudentExt { get; set; }
        
        public MainFrm()
        {
            InitializeComponent();

            LoadDataGridView();
           
        }
       
        public void LoadDataGridView()
        {
            //加载年级信息
            List<Grade> gra = graBLL.GetAllGrades();
            this.dgvGrade.DataSource = gra;
            //加载学生信息
            List<StudentExt> stuExtList = stuBll.GetAllStudentsFromStudentExt();

            this.dgvStudent.DataSource = stuExtList;
            this.dgvStudent.Columns.Clear();
            this.dgvStudent.AutoGenerateColumns = false;


            DisplayCol(dgvStudent, "ID", "学生ID");
            DisplayCol(dgvStudent, "StuId", "学生编号");
            DisplayCol(dgvStudent, "StuName", "学生姓名");
            DisplayCol(dgvStudent, "StuSex", "学生性别");
            DisplayCol(dgvStudent, "StuBornDate", "学生出生日期");
            DisplayCol(dgvStudent, "GradeId", "年级编号");
            DisplayCol(dgvStudent, "GradeName", "年级名称");


            //设置显示顺序
            AdjustColumnOrder();
           
            //设置该控件的右键菜单
            this.dgvStudent.ContextMenuStrip = this.cmsStudent;

        }

        /// <summary>
        /// 代码实现DataGridView中绑定列
        /// </summary>
        /// <param name="dgv">DataGridView对象名</param>
        /// <param name="dataPropertyName">绑定的字段名</param>
        /// <param name="headerText">显示的标题名</param>

        public void DisplayCol(DataGridView dgv, String dataPropertyName, String headerText)
        {
            DataGridViewTextBoxColumn obj = new DataGridViewTextBoxColumn();
            obj.DataPropertyName = dataPropertyName;
            obj.HeaderText = headerText;
            obj.Name = dataPropertyName;
            obj.Resizable = DataGridViewTriState.True;
            dgv.Columns.AddRange(new DataGridViewColumn[]{obj});
        }
        /// <summary>
        /// 重新调整显示顺序
        /// </summary>
        private void AdjustColumnOrder()
        {
            dgvStudent.Columns["ID"].DisplayIndex=0;
            dgvStudent.Columns["StuId"].DisplayIndex = 1;
            dgvStudent.Columns["StuName"].DisplayIndex =2;
            dgvStudent.Columns["StuSex"].DisplayIndex = 3; 
            dgvStudent.Columns["StuBornDate"].DisplayIndex = 4;
            dgvStudent.Columns["GradeId"].DisplayIndex = 5;
            dgvStudent.Columns["GradeName"].DisplayIndex = 6;

 

            //foreach (DataGridViewRow row in dgvStudent.Rows)
            //{
            //    if (Convert.ToInt32(row.Cells[5].Value)==1)
            //    {
            //        row.Cells[3].Value = "男";
            //    }
            //    else
            //    {
            //        row.Cells[3].Value = "女";
            //    }
            //}
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSql_Click(object sender, EventArgs e)
        {
           
            AddStudentFrm addStuFrm = new AddStudentFrm();
            addStuFrm.ShowDialog();

            LoadDataGridView();
        }

        private void btnAddProc_Click(object sender, EventArgs e)
        {
            AddStudentByProc addStuByProcFrm = new AddStudentByProc();
            addStuByProcFrm.ShowDialog();

            LoadDataGridView();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string stuId = this.dgvStudent.SelectedCells[0].OwningRow.Cells["StuId"].Value.ToString();
            int j=new StudentBLL().DeleteStudent(stuId);

            if (j > 0)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
            LoadDataGridView();
        }

        private void 删除存储过程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string stuId = this.dgvStudent.SelectedCells[0].OwningRow.Cells["StuId"].Value.ToString();
            int j = new StudentBLL().DeleteStudentByProc(stuId);

            if (j > 0)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
            LoadDataGridView();
        }

        private void 修改存储过程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string stuId = this.dgvStudent.SelectedCells[0].OwningRow.Cells["StuId"].Value.ToString();

            AddStudentByProc addstuByProcFrm = new AddStudentByProc();
            addstuByProcFrm.StuId= stuId;
            addstuByProcFrm.ShowDialog();

            LoadDataGridView();
            
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string stuId = this.dgvStudent.SelectedCells[0].OwningRow.Cells["StuId"].Value.ToString();

            AddStudentFrm addStuFrm = new AddStudentFrm();
            addStuFrm.StuId = stuId;
            addStuFrm.ShowDialog();

            LoadDataGridView();
        }





 

    }
}
