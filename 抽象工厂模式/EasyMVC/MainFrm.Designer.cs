namespace EasyMVC
{
    partial class MainFrm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.cmsStudent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改存储过程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除存储过程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddSql = new System.Windows.Forms.Button();
            this.btnAddProc = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvGrade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.cmsStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(26, 67);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowTemplate.Height = 23;
            this.dgvStudent.Size = new System.Drawing.Size(643, 150);
            this.dgvStudent.TabIndex = 0;
            // 
            // cmsStudent
            // 
            this.cmsStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.修改存储过程ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.删除存储过程ToolStripMenuItem});
            this.cmsStudent.Name = "cmsStudent";
            this.cmsStudent.Size = new System.Drawing.Size(167, 136);
            // 
            // 增加ToolStripMenuItem
            // 
            this.增加ToolStripMenuItem.Name = "增加ToolStripMenuItem";
            this.增加ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.增加ToolStripMenuItem.Text = "增加";
            this.增加ToolStripMenuItem.Click += new System.EventHandler(this.增加ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.修改ToolStripMenuItem.Text = "修改（Sql语句）";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 修改存储过程ToolStripMenuItem
            // 
            this.修改存储过程ToolStripMenuItem.Name = "修改存储过程ToolStripMenuItem";
            this.修改存储过程ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.修改存储过程ToolStripMenuItem.Text = "修改（存储过程）";
            this.修改存储过程ToolStripMenuItem.Click += new System.EventHandler(this.修改存储过程ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.删除ToolStripMenuItem.Text = "删除(Sql 语句)";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 删除存储过程ToolStripMenuItem
            // 
            this.删除存储过程ToolStripMenuItem.Name = "删除存储过程ToolStripMenuItem";
            this.删除存储过程ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.删除存储过程ToolStripMenuItem.Text = "删除(存储过程)";
            this.删除存储过程ToolStripMenuItem.Click += new System.EventHandler(this.删除存储过程ToolStripMenuItem_Click);
            // 
            // btnAddSql
            // 
            this.btnAddSql.Location = new System.Drawing.Point(12, 24);
            this.btnAddSql.Name = "btnAddSql";
            this.btnAddSql.Size = new System.Drawing.Size(151, 23);
            this.btnAddSql.TabIndex = 2;
            this.btnAddSql.Text = "通过Sql语句添加数据";
            this.btnAddSql.UseVisualStyleBackColor = true;
            this.btnAddSql.Click += new System.EventHandler(this.btnAddSql_Click);
            // 
            // btnAddProc
            // 
            this.btnAddProc.Location = new System.Drawing.Point(192, 24);
            this.btnAddProc.Name = "btnAddProc";
            this.btnAddProc.Size = new System.Drawing.Size(194, 23);
            this.btnAddProc.TabIndex = 3;
            this.btnAddProc.Text = "通过存储过程添加数据";
            this.btnAddProc.UseVisualStyleBackColor = true;
            this.btnAddProc.Click += new System.EventHandler(this.btnAddProc_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(409, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvGrade
            // 
            this.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrade.Location = new System.Drawing.Point(26, 264);
            this.dgvGrade.Name = "dgvGrade";
            this.dgvGrade.RowTemplate.Height = 23;
            this.dgvGrade.Size = new System.Drawing.Size(643, 150);
            this.dgvGrade.TabIndex = 5;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 456);
            this.Controls.Add(this.dgvGrade);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAddSql);
            this.Controls.Add(this.btnAddProc);
            this.Controls.Add(this.dgvStudent);
            this.Name = "MainFrm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.cmsStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.ContextMenuStrip cmsStudent;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button btnAddSql;
        private System.Windows.Forms.Button btnAddProc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem 删除存储过程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改存储过程ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvGrade;
    }
}

