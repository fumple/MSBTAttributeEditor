﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSBTEditor
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
            this.Hide();
        }
        public void newLog(string text)
        {
            textBox1.Text += $"\r\n[{DateTime.Now.ToString()}] {text}";
        }

        private void Log_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
