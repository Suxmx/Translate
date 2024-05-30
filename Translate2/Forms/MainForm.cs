using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translate2.Data;
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
            cleanEditor();
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
            int txtHeight = 9;//设置单行的行高
            Size size = TextRenderer.MeasureText(txt1.Text, txt1.Font);
            int itxtLine = size.Width / txt1.Width + txt1.Lines.Count() + 1;
            txt1.Height = txtHeight * itxtLine;
        }
        private void TransferText2MachineView(object sender, EventArgs e)
        {
            MachineTranslateView.inputBox.Text = textBoxLabelPairs[(TextBox)(sender)].Text;
            MachineTranslateView.outputBox.Text = string.Empty;
            MachineTranslateView.TextBox = (TextBox)(sender);

        }

        private void OnClickSaveProj(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "保存文件";
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Filter = "Json 文件 (*.json)|*.json";
            DialogResult result = saveFileDialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }
            string path = saveFileDialog.FileName;
            ProjectSaveData data = new ProjectSaveData(path);

            foreach (var pair in textBoxLabelPairs)
            {
                data.OriginTexts.Add(pair.Value.Text);
                data.TranslateTexts.Add(pair.Key.Text);
            }

            data.Save();
        }


        private void onClickImportDoc(object sender, EventArgs e)
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
            if (d != null)
            {
                cleanEditor();
                for (int i = 0; i < d.ParaCount; i++)
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
                    newBox.BackColor = System.Drawing.SystemColors.Menu;
                    newBox.BorderStyle = BorderStyle.None;

                    Label label = new Label();
                    label.Text = d.GetParaByIndex(i);
                    label.Dock = DockStyle.Fill;
                    label.AutoSize = true;

                    textBoxLabelPairs.Add(newBox, label);

                    EditorTableLayout.Controls.Add(newBox, 0, testCnt);
                    EditorTableLayout.Controls.Add(label, 0, testCnt++);
                }
            }
        }
        private void cleanEditor()
        {
            testCnt = 0;
            textBoxLabelPairs.Clear();
            EditorTableLayout.Controls.Clear();
        }

        private async void  onClickOpenProject(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择文件";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Json 文件 (*.json)|*.json";
            DialogResult result = openFileDialog.ShowDialog();
            List<TextBox> newBoxs=new List<TextBox>();
            if (result != DialogResult.OK)
            {
                return;
            }
            string path = openFileDialog.FileName;
            ProjectSaveData data = new ProjectSaveData(path);
            data.Load();
            cleanEditor();
            for (int i = 0; i < data.OriginTexts.Count; i++)
            {
                if(i>0)
                {
                    RowStyle style = new RowStyle(SizeType.AutoSize);
                    EditorTableLayout.RowStyles.Add(style);
                    EditorTableLayout.RowCount++;
                }
                else
                {
                    EditorTableLayout.RowStyles[0]= new RowStyle(SizeType.AutoSize);
                }

                TextBox newBox = new TextBox();
                newBox.Dock = DockStyle.Fill;
                newBox.Multiline = true;
                newBox.WordWrap = true;
                newBox.Click += TransferText2MachineView;
                newBox.BackColor = System.Drawing.SystemColors.Menu;
                newBox.BorderStyle = BorderStyle.None;
                newBox.TextChanged += SettxtHeight;
                newBoxs.Add(newBox);
                //newBox.Text = i < data.TranslateTexts.Count ? data.TranslateTexts[i] : string.Empty;


                Label label = new Label();
                label.Dock = DockStyle.Fill;
                label.AutoSize = true;
                //await Task.Delay(50);  
                label.Text = data.OriginTexts[i];
                

                textBoxLabelPairs.Add(newBox, label);

                EditorTableLayout.Controls.Add(newBox, 0, testCnt);
                EditorTableLayout.Controls.Add(label, 0, testCnt++);
            }
            await Task.Delay(50);
            for (int i = 0; i < data.OriginTexts.Count; i++)
            {
                TextBox newBox = newBoxs[i];
                newBox.Text = i < data.TranslateTexts.Count ? data.TranslateTexts[i] : string.Empty;
            }
        }

        private void onClickExport(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "导出文件";
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Filter = "txt 文件 (*.txt)|*.txt";
            DialogResult result = saveFileDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            string path = saveFileDialog.FileName;
            using (StreamWriter writer=new StreamWriter(path))
            {
                foreach (var pair in textBoxLabelPairs)
                {
                    if(string.IsNullOrEmpty(pair.Key.Text))
                    {
                        writer.WriteLine(pair.Value.Text);
                    }
                    else
                    {
                        writer.WriteLine(pair.Key.Text);
                    }
                }
            }
        }
    }
}
