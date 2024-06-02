namespace Translate2
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.EditorTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.RightUpTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.MachineTranslateView = new Translate2.SubViews.MachineTranslate();
            this.RightDownTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.termBaseUI1 = new Translate2.SubViews.TermBaseUI();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.RightUpTableLayout.SuspendLayout();
            this.RightDownTableLayout.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(965, 562);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.EditorTableLayout, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 99.99999F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(478, 558);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "编辑器";
            // 
            // EditorTableLayout
            // 
            this.EditorTableLayout.AutoScroll = true;
            this.EditorTableLayout.AutoSize = true;
            this.EditorTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditorTableLayout.ColumnCount = 1;
            this.EditorTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditorTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorTableLayout.Location = new System.Drawing.Point(4, 29);
            this.EditorTableLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditorTableLayout.Name = "EditorTableLayout";
            this.EditorTableLayout.RowCount = 1;
            this.EditorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.EditorTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 530F));
            this.EditorTableLayout.Size = new System.Drawing.Size(470, 525);
            this.EditorTableLayout.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.RightUpTableLayout, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RightDownTableLayout, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(484, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(479, 558);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // RightUpTableLayout
            // 
            this.RightUpTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.RightUpTableLayout.ColumnCount = 1;
            this.RightUpTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightUpTableLayout.Controls.Add(this.comboBox2, 0, 0);
            this.RightUpTableLayout.Controls.Add(this.MachineTranslateView, 0, 1);
            this.RightUpTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightUpTableLayout.Location = new System.Drawing.Point(2, 2);
            this.RightUpTableLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RightUpTableLayout.Name = "RightUpTableLayout";
            this.RightUpTableLayout.RowCount = 2;
            this.RightUpTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.RightUpTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightUpTableLayout.Size = new System.Drawing.Size(475, 275);
            this.RightUpTableLayout.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "机器翻译",
            "术语库"});
            this.comboBox2.Location = new System.Drawing.Point(4, 4);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(171, 20);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.onUpComboBoxChange);
            // 
            // MachineTranslateView
            // 
            this.MachineTranslateView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MachineTranslateView.Location = new System.Drawing.Point(3, 28);
            this.MachineTranslateView.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MachineTranslateView.Name = "MachineTranslateView";
            this.MachineTranslateView.Size = new System.Drawing.Size(469, 244);
            this.MachineTranslateView.TabIndex = 2;
            // 
            // RightDownTableLayout
            // 
            this.RightDownTableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.RightDownTableLayout.ColumnCount = 1;
            this.RightDownTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightDownTableLayout.Controls.Add(this.comboBox3, 0, 0);
            this.RightDownTableLayout.Controls.Add(this.termBaseUI1, 0, 1);
            this.RightDownTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightDownTableLayout.Location = new System.Drawing.Point(2, 281);
            this.RightDownTableLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RightDownTableLayout.Name = "RightDownTableLayout";
            this.RightDownTableLayout.RowCount = 2;
            this.RightDownTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.RightDownTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightDownTableLayout.Size = new System.Drawing.Size(475, 275);
            this.RightDownTableLayout.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "术语库",
            "机器翻译"});
            this.comboBox3.Location = new System.Drawing.Point(4, 4);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(171, 20);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.onDownComboBoxChange);
            // 
            // termBaseUI1
            // 
            this.termBaseUI1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.termBaseUI1.Location = new System.Drawing.Point(6, 31);
            this.termBaseUI1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.termBaseUI1.Name = "termBaseUI1";
            this.termBaseUI1.Size = new System.Drawing.Size(463, 238);
            this.termBaseUI1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.项目ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.测试ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 项目ToolStripMenuItem
            // 
            this.项目ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建项目ToolStripMenuItem,
            this.打开项目ToolStripMenuItem,
            this.保存项目ToolStripMenuItem,
            this.导入文件ToolStripMenuItem,
            this.导出文件ToolStripMenuItem});
            this.项目ToolStripMenuItem.Name = "项目ToolStripMenuItem";
            this.项目ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.项目ToolStripMenuItem.Text = "文件";
            // 
            // 新建项目ToolStripMenuItem
            // 
            this.新建项目ToolStripMenuItem.Name = "新建项目ToolStripMenuItem";
            this.新建项目ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新建项目ToolStripMenuItem.Text = "新建项目";
            this.新建项目ToolStripMenuItem.Click += new System.EventHandler(this.onCreateNewProject);
            // 
            // 打开项目ToolStripMenuItem
            // 
            this.打开项目ToolStripMenuItem.Name = "打开项目ToolStripMenuItem";
            this.打开项目ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打开项目ToolStripMenuItem.Text = "打开项目";
            this.打开项目ToolStripMenuItem.Click += new System.EventHandler(this.onClickOpenProject);
            // 
            // 保存项目ToolStripMenuItem
            // 
            this.保存项目ToolStripMenuItem.Name = "保存项目ToolStripMenuItem";
            this.保存项目ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存项目ToolStripMenuItem.Text = "保存项目";
            this.保存项目ToolStripMenuItem.Click += new System.EventHandler(this.OnClickSaveProj);
            // 
            // 导入文件ToolStripMenuItem
            // 
            this.导入文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docToolStripMenuItem});
            this.导入文件ToolStripMenuItem.Name = "导入文件ToolStripMenuItem";
            this.导入文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导入文件ToolStripMenuItem.Text = "导入文件";
            // 
            // docToolStripMenuItem
            // 
            this.docToolStripMenuItem.Name = "docToolStripMenuItem";
            this.docToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.docToolStripMenuItem.Text = "Doc";
            this.docToolStripMenuItem.Click += new System.EventHandler(this.onClickImportDoc);
            // 
            // 导出文件ToolStripMenuItem
            // 
            this.导出文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tXTToolStripMenuItem});
            this.导出文件ToolStripMenuItem.Name = "导出文件ToolStripMenuItem";
            this.导出文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导出文件ToolStripMenuItem.Text = "导出文件";
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.tXTToolStripMenuItem.Text = "TXT";
            this.tXTToolStripMenuItem.Click += new System.EventHandler(this.onClickExport);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 测试ToolStripMenuItem
            // 
            this.测试ToolStripMenuItem.Name = "测试ToolStripMenuItem";
            this.测试ToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.测试ToolStripMenuItem.Text = "测试";
            this.测试ToolStripMenuItem.Click += new System.EventHandler(this.onClickTestButton);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 586);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "翻译";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.RightUpTableLayout.ResumeLayout(false);
            this.RightDownTableLayout.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel RightUpTableLayout;
        private System.Windows.Forms.TableLayoutPanel RightDownTableLayout;
        private System.Windows.Forms.ToolStripMenuItem 新建项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开项目ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private SubViews.MachineTranslate MachineTranslateView;
        private System.Windows.Forms.TableLayoutPanel EditorTableLayout;
        private System.Windows.Forms.ToolStripMenuItem 测试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存项目ToolStripMenuItem;
        private SubViews.TermBaseUI termBaseUI1;
        private System.Windows.Forms.ToolStripMenuItem 导入文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
    }
}

