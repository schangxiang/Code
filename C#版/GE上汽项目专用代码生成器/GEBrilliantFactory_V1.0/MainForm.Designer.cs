﻿namespace GenerateCode_GEBrilliantFactory
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPath = new System.Windows.Forms.Button();
            this.lblds = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn_CreateFile = new System.Windows.Forms.Button();
            this.tb_TableName = new System.Windows.Forms.TextBox();
            this.tb_FileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_WCF_NameSpacePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ChinaComment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_CreatePerson = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Primary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_EntityProName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_EntityName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_OrderBy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_PrimaryName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_Modulelogo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_InsertSql = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(382, 347);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(97, 23);
            this.btnPath.TabIndex = 1;
            this.btnPath.Text = "选择生成路径";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblds
            // 
            this.lblds.AutoSize = true;
            this.lblds.Location = new System.Drawing.Point(52, 11);
            this.lblds.Name = "lblds";
            this.lblds.Size = new System.Drawing.Size(35, 12);
            this.lblds.TabIndex = 2;
            this.lblds.Text = "表名:";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(50, 347);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(253, 21);
            this.tbPath.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(573, 454);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 67);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_CreateFile
            // 
            this.btn_CreateFile.Location = new System.Drawing.Point(122, 454);
            this.btn_CreateFile.Name = "btn_CreateFile";
            this.btn_CreateFile.Size = new System.Drawing.Size(157, 67);
            this.btn_CreateFile.TabIndex = 14;
            this.btn_CreateFile.Text = "生成文件";
            this.btn_CreateFile.UseVisualStyleBackColor = true;
            this.btn_CreateFile.Click += new System.EventHandler(this.btn_CreateFile_Click);
            // 
            // tb_TableName
            // 
            this.tb_TableName.Location = new System.Drawing.Point(122, 8);
            this.tb_TableName.Name = "tb_TableName";
            this.tb_TableName.Size = new System.Drawing.Size(183, 21);
            this.tb_TableName.TabIndex = 15;
            this.tb_TableName.TextChanged += new System.EventHandler(this.tb_TableName_TextChanged);
            // 
            // tb_FileName
            // 
            this.tb_FileName.Location = new System.Drawing.Point(251, 91);
            this.tb_FileName.Name = "tb_FileName";
            this.tb_FileName.Size = new System.Drawing.Size(199, 21);
            this.tb_FileName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "文件名称(用于给各个类名的前缀):";
            // 
            // tb_WCF_NameSpacePath
            // 
            this.tb_WCF_NameSpacePath.Location = new System.Drawing.Point(249, 194);
            this.tb_WCF_NameSpacePath.Name = "tb_WCF_NameSpacePath";
            this.tb_WCF_NameSpacePath.Size = new System.Drawing.Size(197, 21);
            this.tb_WCF_NameSpacePath.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "WCF项目命名空间:";
            // 
            // tb_ChinaComment
            // 
            this.tb_ChinaComment.Location = new System.Drawing.Point(249, 240);
            this.tb_ChinaComment.Name = "tb_ChinaComment";
            this.tb_ChinaComment.Size = new System.Drawing.Size(197, 21);
            this.tb_ChinaComment.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = "表的中文注解:";
            // 
            // tb_CreatePerson
            // 
            this.tb_CreatePerson.Location = new System.Drawing.Point(249, 286);
            this.tb_CreatePerson.Name = "tb_CreatePerson";
            this.tb_CreatePerson.Size = new System.Drawing.Size(199, 21);
            this.tb_CreatePerson.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "你的名字拼音缩写:";
            // 
            // tb_Primary
            // 
            this.tb_Primary.Location = new System.Drawing.Point(368, 8);
            this.tb_Primary.Name = "tb_Primary";
            this.tb_Primary.Size = new System.Drawing.Size(145, 21);
            this.tb_Primary.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "主键:";
            // 
            // tb_EntityProName
            // 
            this.tb_EntityProName.Location = new System.Drawing.Point(521, 47);
            this.tb_EntityProName.Name = "tb_EntityProName";
            this.tb_EntityProName.Size = new System.Drawing.Size(183, 21);
            this.tb_EntityProName.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "实体类对象名/表别名:";
            // 
            // tb_EntityName
            // 
            this.tb_EntityName.Location = new System.Drawing.Point(122, 47);
            this.tb_EntityName.Name = "tb_EntityName";
            this.tb_EntityName.Size = new System.Drawing.Size(183, 21);
            this.tb_EntityName.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 28;
            this.label8.Text = "实体类名:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(498, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 34;
            this.label9.Text = "排序:";
            // 
            // tb_OrderBy
            // 
            this.tb_OrderBy.Location = new System.Drawing.Point(539, 97);
            this.tb_OrderBy.Name = "tb_OrderBy";
            this.tb_OrderBy.Size = new System.Drawing.Size(145, 21);
            this.tb_OrderBy.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(703, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 36;
            this.label10.Text = "(默认降序)";
            // 
            // tb_PrimaryName
            // 
            this.tb_PrimaryName.Location = new System.Drawing.Point(599, 8);
            this.tb_PrimaryName.Name = "tb_PrimaryName";
            this.tb_PrimaryName.Size = new System.Drawing.Size(145, 21);
            this.tb_PrimaryName.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(537, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 37;
            this.label11.Text = "主键名称:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(781, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 12);
            this.label12.TabIndex = 39;
            this.label12.Text = "(用于查询单个实体)";
            // 
            // tb_Modulelogo
            // 
            this.tb_Modulelogo.Location = new System.Drawing.Point(251, 142);
            this.tb_Modulelogo.Name = "tb_Modulelogo";
            this.tb_Modulelogo.Size = new System.Drawing.Size(199, 21);
            this.tb_Modulelogo.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 12);
            this.label3.TabIndex = 40;
            this.label3.Text = "模块简写(用于给各个方法名):";
            // 
            // btn_InsertSql
            // 
            this.btn_InsertSql.Location = new System.Drawing.Point(356, 454);
            this.btn_InsertSql.Name = "btn_InsertSql";
            this.btn_InsertSql.Size = new System.Drawing.Size(157, 67);
            this.btn_InsertSql.TabIndex = 42;
            this.btn_InsertSql.Text = "生成InsertSQL";
            this.btn_InsertSql.UseVisualStyleBackColor = true;
            this.btn_InsertSql.Click += new System.EventHandler(this.btn_InsertSql_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 580);
            this.Controls.Add(this.btn_InsertSql);
            this.Controls.Add(this.tb_Modulelogo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_PrimaryName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_OrderBy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_EntityProName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_EntityName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_Primary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_CreatePerson);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_ChinaComment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_WCF_NameSpacePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_FileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_TableName);
            this.Controls.Add(this.btn_CreateFile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lblds);
            this.Controls.Add(this.btnPath);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "代码生成器(科致专用)V1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label lblds;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn_CreateFile;
        private System.Windows.Forms.TextBox tb_TableName;
        private System.Windows.Forms.TextBox tb_FileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_WCF_NameSpacePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ChinaComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_CreatePerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Primary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_EntityProName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_EntityName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_OrderBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_PrimaryName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_Modulelogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_InsertSql;
    }
}

