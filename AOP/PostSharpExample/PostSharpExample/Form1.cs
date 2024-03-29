﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostSharpExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Subscribe_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_MemberName.Text.Trim()) && !String.IsNullOrEmpty(tb_Room.Text.Trim()))
            {
                AgvMap myParam = new AgvMap()
                {
                    agvCode = "111",
                    agvNumber = "222",
                    rfid = "555"
                };
                new CoreBusiness().Describe(tb_MemberName.Text.Trim(), tb_Room.Text.Trim(), myParam);
            }

            else
                MessageBox.Show("信息不完整", "提示");
        }
    }
}
