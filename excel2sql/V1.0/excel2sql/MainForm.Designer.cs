namespace Excel2SQL
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_InsertSQLForCodeTable = new System.Windows.Forms.Button();
            this.btn_CreateTable = new System.Windows.Forms.Button();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.tb_FilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TableName = new System.Windows.Forms.TextBox();
            this.tb_ChinaName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Author = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_UniqueIndex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_PrimaryKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_InsertSQLForCodeTable
            // 
            this.btn_InsertSQLForCodeTable.Location = new System.Drawing.Point(368, 144);
            this.btn_InsertSQLForCodeTable.Name = "btn_InsertSQLForCodeTable";
            this.btn_InsertSQLForCodeTable.Size = new System.Drawing.Size(194, 67);
            this.btn_InsertSQLForCodeTable.TabIndex = 0;
            this.btn_InsertSQLForCodeTable.Text = "码表生成InsertSQL";
            this.btn_InsertSQLForCodeTable.UseVisualStyleBackColor = true;
            this.btn_InsertSQLForCodeTable.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_CreateTable
            // 
            this.btn_CreateTable.Location = new System.Drawing.Point(21, 378);
            this.btn_CreateTable.Name = "btn_CreateTable";
            this.btn_CreateTable.Size = new System.Drawing.Size(219, 67);
            this.btn_CreateTable.TabIndex = 1;
            this.btn_CreateTable.Text = "生成建表SQL";
            this.btn_CreateTable.UseVisualStyleBackColor = true;
            this.btn_CreateTable.Click += new System.EventHandler(this.btn_CreateTable_Click);
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Location = new System.Drawing.Point(188, 74);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(99, 34);
            this.btn_SelectFile.TabIndex = 2;
            this.btn_SelectFile.Text = "选择文件";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // tb_FilePath
            // 
            this.tb_FilePath.Enabled = false;
            this.tb_FilePath.Location = new System.Drawing.Point(21, 37);
            this.tb_FilePath.Name = "tb_FilePath";
            this.tb_FilePath.Size = new System.Drawing.Size(568, 21);
            this.tb_FilePath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "表名：";
            // 
            // tb_TableName
            // 
            this.tb_TableName.Location = new System.Drawing.Point(138, 141);
            this.tb_TableName.Name = "tb_TableName";
            this.tb_TableName.Size = new System.Drawing.Size(176, 21);
            this.tb_TableName.TabIndex = 5;
            // 
            // tb_ChinaName
            // 
            this.tb_ChinaName.Location = new System.Drawing.Point(138, 184);
            this.tb_ChinaName.Name = "tb_ChinaName";
            this.tb_ChinaName.Size = new System.Drawing.Size(176, 21);
            this.tb_ChinaName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "表中文名：";
            // 
            // tb_Author
            // 
            this.tb_Author.Location = new System.Drawing.Point(138, 320);
            this.tb_Author.Name = "tb_Author";
            this.tb_Author.Size = new System.Drawing.Size(176, 21);
            this.tb_Author.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "作者：";
            // 
            // tb_UniqueIndex
            // 
            this.tb_UniqueIndex.Location = new System.Drawing.Point(138, 269);
            this.tb_UniqueIndex.Name = "tb_UniqueIndex";
            this.tb_UniqueIndex.Size = new System.Drawing.Size(176, 21);
            this.tb_UniqueIndex.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "唯一索引：";
            // 
            // tb_PrimaryKey
            // 
            this.tb_PrimaryKey.Location = new System.Drawing.Point(138, 224);
            this.tb_PrimaryKey.Name = "tb_PrimaryKey";
            this.tb_PrimaryKey.Size = new System.Drawing.Size(176, 21);
            this.tb_PrimaryKey.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "主键：";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(308, 378);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(219, 67);
            this.btn_Exit.TabIndex = 14;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 490);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.tb_PrimaryKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_UniqueIndex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Author);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_ChinaName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_TableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_FilePath);
            this.Controls.Add(this.btn_SelectFile);
            this.Controls.Add(this.btn_CreateTable);
            this.Controls.Add(this.btn_InsertSQLForCodeTable);
            this.Name = "MainForm";
            this.Text = "Excel2SQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_InsertSQLForCodeTable;
        private System.Windows.Forms.Button btn_CreateTable;
        private System.Windows.Forms.Button btn_SelectFile;
        private System.Windows.Forms.TextBox tb_FilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TableName;
        private System.Windows.Forms.TextBox tb_ChinaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_UniqueIndex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_PrimaryKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Exit;
    }
}

