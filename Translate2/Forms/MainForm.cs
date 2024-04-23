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
using Translate2.SubViews;

namespace Translate2
{

    public partial class MainForm : Form
    {
        private MachineTranslate machineTranslate => (MachineTranslate)RightUpTableLayout.Controls[1];
        private int testCnt = 0;
        private Dictionary<TextBox, Label> textBoxLabelPairs;
        public MainForm()
        {
            InitializeComponent();
            EditorTableLayout.RowStyles.RemoveAt(0);
            EditorTableLayout.RowCount = 0;
            textBoxLabelPairs= new Dictionary<TextBox, Label>();
            /*InitializeContextMenuStrip();

            // 关联ComboBox的SelectedIndexChanged事件到事件处理程序  
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);*/
        }

        private void onCreateNewProject(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择文件";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Word 文档 (*.docx, *.doc)|*.docx;*.doc";
            DialogResult result = openFileDialog.ShowDialog();
            Docx d = null;
            if (result == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                d = new Docx(selectedFilePath);
            }
            if (d!=null)
            {
                for(int i=0;i<d.ParaCount;i++)
                {
                    RowStyle style = new RowStyle(SizeType.AutoSize);
                    EditorTableLayout.RowStyles.Add(style);
                    EditorTableLayout.RowCount++;

                    TextBox newBox = new TextBox();
                    newBox.Dock = DockStyle.Fill;
                    newBox.Multiline = true;
                    newBox.WordWrap = true;
                    newBox.TextChanged += SettxtHeight;
                    newBox.Click += TransferText2MachineView;

                    Label label = new Label();
                    label.Text = d.GetParaByIndex(i);
                    label.Dock = DockStyle.Fill;
                    label.AutoSize = true;

                    textBoxLabelPairs.Add(newBox, label);

                    EditorTableLayout.Controls.Add(newBox, 0, testCnt);
                    EditorTableLayout.Controls.Add(label, 0, testCnt++);
                }
            }
            //RowStyle style = new RowStyle();

            //EditorTableLayout.
        }


        private void onUpComboBoxChange(object sender, EventArgs e)
        {

        }

        private void onDownComboBoxChange(object sender, EventArgs e)
        {

        }

        private void onClickTestButton(object sender, EventArgs e)
        {
            RowStyle style = new RowStyle(SizeType.AutoSize);
            EditorTableLayout.RowStyles.Add(style);
            EditorTableLayout.RowCount++;
            
            
            
            TextBox newBox = new TextBox();
            newBox.Text = "testtesttesttest";
            newBox.Dock = DockStyle.Fill;
            newBox.Multiline = true;
            newBox.WordWrap = true;
            



            Label label = new Label();
            label.Text = "tets";
            label.Dock = DockStyle.Fill;
            label.AutoSize = true;

            
            EditorTableLayout.Controls.Add(newBox, 0, testCnt);
            EditorTableLayout.Controls.Add(label, 0, testCnt++);
            
        }
        private void SettxtHeight(object sender, EventArgs e)
        {
            TextBox txt1 = (TextBox)sender;
            int txtHeight = 7;//设置单行的行高
            int MaxLineCount = 10;//设置最大行数
            Size size = TextRenderer.MeasureText(txt1.Text, txt1.Font);
            int itxtLine = size.Width / txt1.Width + txt1.Lines.Count() + 1;
            //if (itxtLine > MaxLineCount) { itxtLine = MaxLineCount; }
            txt1.Height = txtHeight * itxtLine;
        }
        private void TransferText2MachineView(object sender, EventArgs e)
        {
            MachineTranslateView.textBox1.Text = textBoxLabelPairs[(TextBox)(sender)].Text;
        }

    }
}
