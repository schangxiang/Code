namespace PostSharpExample
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Room = new System.Windows.Forms.TextBox();
            this.tb_MemberName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Subscribe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间号：";
            // 
            // tb_Room
            // 
            this.tb_Room.Location = new System.Drawing.Point(110, 34);
            this.tb_Room.Name = "tb_Room";
            this.tb_Room.Size = new System.Drawing.Size(100, 21);
            this.tb_Room.TabIndex = 1;
            // 
            // tb_MemberName
            // 
            this.tb_MemberName.Location = new System.Drawing.Point(110, 84);
            this.tb_MemberName.Name = "tb_MemberName";
            this.tb_MemberName.Size = new System.Drawing.Size(100, 21);
            this.tb_MemberName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "您的姓名";
            // 
            // btn_Subscribe
            // 
            this.btn_Subscribe.Location = new System.Drawing.Point(135, 147);
            this.btn_Subscribe.Name = "btn_Subscribe";
            this.btn_Subscribe.Size = new System.Drawing.Size(75, 23);
            this.btn_Subscribe.TabIndex = 4;
            this.btn_Subscribe.Text = "预定";
            this.btn_Subscribe.UseVisualStyleBackColor = true;
            this.btn_Subscribe.Click += new System.EventHandler(this.btn_Subscribe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 262);
            this.Controls.Add(this.btn_Subscribe);
            this.Controls.Add(this.tb_MemberName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Room);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Room;
        private System.Windows.Forms.TextBox tb_MemberName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Subscribe;
    }
}

