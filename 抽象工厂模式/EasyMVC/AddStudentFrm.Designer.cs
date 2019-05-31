namespace EasyMVC
{
    partial class AddStudentFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStuId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStuName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBronDate = new System.Windows.Forms.TextBox();
            this.rbtnMan = new System.Windows.Forms.RadioButton();
            this.rbtnWoMan = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGarde = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(68, 301);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "学生编号：";
            // 
            // tbStuId
            // 
            this.tbStuId.Location = new System.Drawing.Point(121, 41);
            this.tbStuId.Name = "tbStuId";
            this.tbStuId.Size = new System.Drawing.Size(100, 21);
            this.tbStuId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "学生姓名：";
            // 
            // tbStuName
            // 
            this.tbStuName.Location = new System.Drawing.Point(121, 88);
            this.tbStuName.Name = "tbStuName";
            this.tbStuName.Size = new System.Drawing.Size(100, 21);
            this.tbStuName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "学生性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "出生日期：";
            // 
            // tbBronDate
            // 
            this.tbBronDate.Location = new System.Drawing.Point(121, 177);
            this.tbBronDate.Name = "tbBronDate";
            this.tbBronDate.Size = new System.Drawing.Size(100, 21);
            this.tbBronDate.TabIndex = 2;
            this.tbBronDate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rbtnMan
            // 
            this.rbtnMan.AutoSize = true;
            this.rbtnMan.Location = new System.Drawing.Point(121, 134);
            this.rbtnMan.Name = "rbtnMan";
            this.rbtnMan.Size = new System.Drawing.Size(35, 16);
            this.rbtnMan.TabIndex = 3;
            this.rbtnMan.TabStop = true;
            this.rbtnMan.Text = "男";
            this.rbtnMan.UseVisualStyleBackColor = true;
            // 
            // rbtnWoMan
            // 
            this.rbtnWoMan.AutoSize = true;
            this.rbtnWoMan.Location = new System.Drawing.Point(185, 132);
            this.rbtnWoMan.Name = "rbtnWoMan";
            this.rbtnWoMan.Size = new System.Drawing.Size(35, 16);
            this.rbtnWoMan.TabIndex = 3;
            this.rbtnWoMan.TabStop = true;
            this.rbtnWoMan.Text = "女";
            this.rbtnWoMan.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "班级：";
            // 
            // cboGarde
            // 
            this.cboGarde.FormattingEnabled = true;
            this.cboGarde.Location = new System.Drawing.Point(110, 224);
            this.cboGarde.Name = "cboGarde";
            this.cboGarde.Size = new System.Drawing.Size(132, 20);
            this.cboGarde.TabIndex = 4;
            // 
            // AddStudentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 457);
            this.Controls.Add(this.cboGarde);
            this.Controls.Add(this.rbtnWoMan);
            this.Controls.Add(this.rbtnMan);
            this.Controls.Add(this.tbBronDate);
            this.Controls.Add(this.tbStuName);
            this.Controls.Add(this.tbStuId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Name = "AddStudentFrm";
            this.Text = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudentFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStuId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStuName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBronDate;
        private System.Windows.Forms.RadioButton rbtnMan;
        private System.Windows.Forms.RadioButton rbtnWoMan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboGarde;
    }
}