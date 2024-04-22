﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translate2.Data.DOCX;

namespace Translate2
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            /*InitializeContextMenuStrip();

            // 关联ComboBox的SelectedIndexChanged事件到事件处理程序  
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);*/
        }

        private void 新建项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择文件";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Word 文档 (*.docx, *.doc)|*.docx;*.doc";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                Docx d = new Docx(selectedFilePath);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
