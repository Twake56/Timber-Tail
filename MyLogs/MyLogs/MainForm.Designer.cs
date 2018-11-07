﻿namespace MyLogs
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
         this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
         this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
         this.followTailCheckBox = new System.Windows.Forms.CheckBox();
         this.FileLengthTB = new System.Windows.Forms.TextBox();
         this.FileSizeTB = new System.Windows.Forms.TextBox();
         this.TabControlParent = new System.Windows.Forms.TabControl();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.menuStrip2 = new System.Windows.Forms.MenuStrip();
         this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
         this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
         this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
         this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
         this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
         this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
         this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
         this.LogRichTextBox1 = new System.Windows.Forms.RichTextBox();
         this.tableLayoutPanel4.SuspendLayout();
         this.TabControlParent.SuspendLayout();
         this.menuStrip2.SuspendLayout();
         this.MainTableLayoutPanel.SuspendLayout();
         this.tableLayoutPanel3.SuspendLayout();
         this.SuspendLayout();
         // 
         // openFileDialog3
         // 
         this.openFileDialog3.FileName = "openFileDialog3";
         // 
         // tableLayoutPanel4
         // 
         this.tableLayoutPanel4.ColumnCount = 3;
         this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
         this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
         this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
         this.tableLayoutPanel4.Controls.Add(this.FileSizeTB, 0, 0);
         this.tableLayoutPanel4.Controls.Add(this.FileLengthTB, 1, 0);
         this.tableLayoutPanel4.Controls.Add(this.followTailCheckBox, 2, 0);
         this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 372);
         this.tableLayoutPanel4.Name = "tableLayoutPanel4";
         this.tableLayoutPanel4.RowCount = 1;
         this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel4.Size = new System.Drawing.Size(844, 24);
         this.tableLayoutPanel4.TabIndex = 3;
         // 
         // followTailCheckBox
         // 
         this.followTailCheckBox.AutoSize = true;
         this.followTailCheckBox.Location = new System.Drawing.Point(339, 3);
         this.followTailCheckBox.Name = "followTailCheckBox";
         this.followTailCheckBox.Size = new System.Drawing.Size(76, 17);
         this.followTailCheckBox.TabIndex = 2;
         this.followTailCheckBox.Text = "Follow Tail";
         this.followTailCheckBox.UseVisualStyleBackColor = true;
         // 
         // FileLengthTB
         // 
         this.FileLengthTB.Dock = System.Windows.Forms.DockStyle.Fill;
         this.FileLengthTB.Location = new System.Drawing.Point(171, 3);
         this.FileLengthTB.Name = "FileLengthTB";
         this.FileLengthTB.ReadOnly = true;
         this.FileLengthTB.Size = new System.Drawing.Size(162, 20);
         this.FileLengthTB.TabIndex = 1;
         // 
         // FileSizeTB
         // 
         this.FileSizeTB.Dock = System.Windows.Forms.DockStyle.Fill;
         this.FileSizeTB.Location = new System.Drawing.Point(3, 3);
         this.FileSizeTB.Name = "FileSizeTB";
         this.FileSizeTB.ReadOnly = true;
         this.FileSizeTB.Size = new System.Drawing.Size(162, 20);
         this.FileSizeTB.TabIndex = 0;
         // 
         // TabControlParent
         // 
         this.TabControlParent.Controls.Add(this.tabPage1);
         this.TabControlParent.Controls.Add(this.tabPage2);
         this.TabControlParent.Dock = System.Windows.Forms.DockStyle.Fill;
         this.TabControlParent.Location = new System.Drawing.Point(3, 26);
         this.TabControlParent.Multiline = true;
         this.TabControlParent.Name = "TabControlParent";
         this.TabControlParent.SelectedIndex = 0;
         this.TabControlParent.Size = new System.Drawing.Size(844, 316);
         this.TabControlParent.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
         this.TabControlParent.TabIndex = 1;
         // 
         // tabPage2
         // 
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(836, 294);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "tabPage2";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // tabPage1
         // 
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(836, 290);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "tabPage1";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // menuStrip2
         // 
         this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
         this.menuStrip2.Location = new System.Drawing.Point(0, 0);
         this.menuStrip2.Name = "menuStrip2";
         this.menuStrip2.Size = new System.Drawing.Size(850, 23);
         this.menuStrip2.TabIndex = 0;
         this.menuStrip2.Text = "menuStrip2";
         // 
         // fileToolStripMenuItem
         // 
         this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
         this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
         this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
         this.fileToolStripMenuItem.Text = "&File";
         // 
         // newToolStripMenuItem
         // 
         this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
         this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.newToolStripMenuItem.Name = "newToolStripMenuItem";
         this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
         this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
         this.newToolStripMenuItem.Text = "&New";
         // 
         // openToolStripMenuItem
         // 
         this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
         this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.openToolStripMenuItem.Name = "openToolStripMenuItem";
         this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
         this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
         this.openToolStripMenuItem.Text = "&Open";
         this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
         // 
         // toolStripSeparator
         // 
         this.toolStripSeparator.Name = "toolStripSeparator";
         this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
         // 
         // saveToolStripMenuItem
         // 
         this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
         this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
         this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
         this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
         this.saveToolStripMenuItem.Text = "&Save";
         // 
         // saveAsToolStripMenuItem
         // 
         this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
         this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
         this.saveAsToolStripMenuItem.Text = "Save &As";
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
         // 
         // printToolStripMenuItem
         // 
         this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
         this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.printToolStripMenuItem.Name = "printToolStripMenuItem";
         this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
         this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
         this.printToolStripMenuItem.Text = "&Print";
         // 
         // printPreviewToolStripMenuItem
         // 
         this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
         this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
         this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
         this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
         // 
         // toolStripSeparator2
         // 
         this.toolStripSeparator2.Name = "toolStripSeparator2";
         this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
         // 
         // exitToolStripMenuItem
         // 
         this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
         this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
         this.exitToolStripMenuItem.Text = "E&xit";
         // 
         // editToolStripMenuItem
         // 
         this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
         this.editToolStripMenuItem.Name = "editToolStripMenuItem";
         this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
         this.editToolStripMenuItem.Text = "&Edit";
         // 
         // undoToolStripMenuItem
         // 
         this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
         this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
         this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
         this.undoToolStripMenuItem.Text = "&Undo";
         // 
         // redoToolStripMenuItem
         // 
         this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
         this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
         this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
         this.redoToolStripMenuItem.Text = "&Redo";
         // 
         // toolStripSeparator3
         // 
         this.toolStripSeparator3.Name = "toolStripSeparator3";
         this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
         // 
         // cutToolStripMenuItem
         // 
         this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
         this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
         this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
         this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
         this.cutToolStripMenuItem.Text = "Cu&t";
         // 
         // copyToolStripMenuItem
         // 
         this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
         this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
         this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
         this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
         this.copyToolStripMenuItem.Text = "&Copy";
         // 
         // pasteToolStripMenuItem
         // 
         this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
         this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
         this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
         this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
         this.pasteToolStripMenuItem.Text = "&Paste";
         // 
         // toolStripSeparator4
         // 
         this.toolStripSeparator4.Name = "toolStripSeparator4";
         this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
         // 
         // selectAllToolStripMenuItem
         // 
         this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
         this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
         this.selectAllToolStripMenuItem.Text = "Select &All";
         // 
         // toolsToolStripMenuItem
         // 
         this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
         this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
         this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
         this.toolsToolStripMenuItem.Text = "&Tools";
         // 
         // customizeToolStripMenuItem
         // 
         this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
         this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
         this.customizeToolStripMenuItem.Text = "&Customize";
         // 
         // optionsToolStripMenuItem
         // 
         this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
         this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
         this.optionsToolStripMenuItem.Text = "&Options";
         // 
         // helpToolStripMenuItem
         // 
         this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
         this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
         this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
         this.helpToolStripMenuItem.Text = "&Help";
         // 
         // contentsToolStripMenuItem
         // 
         this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
         this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
         this.contentsToolStripMenuItem.Text = "&Contents";
         // 
         // indexToolStripMenuItem
         // 
         this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
         this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
         this.indexToolStripMenuItem.Text = "&Index";
         // 
         // searchToolStripMenuItem
         // 
         this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
         this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
         this.searchToolStripMenuItem.Text = "&Search";
         // 
         // toolStripSeparator5
         // 
         this.toolStripSeparator5.Name = "toolStripSeparator5";
         this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
         // 
         // aboutToolStripMenuItem
         // 
         this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
         this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
         this.aboutToolStripMenuItem.Text = "&About...";
         // 
         // MainTableLayoutPanel
         // 
         this.MainTableLayoutPanel.ColumnCount = 1;
         this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.MainTableLayoutPanel.Controls.Add(this.menuStrip2, 0, 0);
         this.MainTableLayoutPanel.Controls.Add(this.TabControlParent, 0, 1);
         this.MainTableLayoutPanel.Controls.Add(this.tableLayoutPanel3, 0, 2);
         this.MainTableLayoutPanel.Controls.Add(this.tableLayoutPanel4, 0, 3);
         this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
         this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
         this.MainTableLayoutPanel.RowCount = 4;
         this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
         this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 322F));
         this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
         this.MainTableLayoutPanel.Size = new System.Drawing.Size(850, 399);
         this.MainTableLayoutPanel.TabIndex = 0;
         // 
         // tableLayoutPanel3
         // 
         this.tableLayoutPanel3.ColumnCount = 2;
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel3.Controls.Add(this.LogRichTextBox1, 1, 0);
         this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 348);
         this.tableLayoutPanel3.Name = "tableLayoutPanel3";
         this.tableLayoutPanel3.RowCount = 1;
         this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
         this.tableLayoutPanel3.Size = new System.Drawing.Size(844, 18);
         this.tableLayoutPanel3.TabIndex = 1;
         // 
         // LogRichTextBox1
         // 
         this.LogRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.LogRichTextBox1.Location = new System.Drawing.Point(143, 3);
         this.LogRichTextBox1.Name = "LogRichTextBox1";
         this.LogRichTextBox1.ReadOnly = true;
         this.LogRichTextBox1.Size = new System.Drawing.Size(698, 12);
         this.LogRichTextBox1.TabIndex = 0;
         this.LogRichTextBox1.Text = "";
         // 
         // MainForm
         // 
         this.ClientSize = new System.Drawing.Size(850, 399);
         this.Controls.Add(this.MainTableLayoutPanel);
         this.MainMenuStrip = this.menuStrip2;
         this.Name = "MainForm";
         this.Text = "Timber Tail";
         this.tableLayoutPanel4.ResumeLayout(false);
         this.tableLayoutPanel4.PerformLayout();
         this.TabControlParent.ResumeLayout(false);
         this.menuStrip2.ResumeLayout(false);
         this.menuStrip2.PerformLayout();
         this.MainTableLayoutPanel.ResumeLayout(false);
         this.MainTableLayoutPanel.PerformLayout();
         this.tableLayoutPanel3.ResumeLayout(false);
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
      private System.Windows.Forms.TextBox FileSizeTB;
      private System.Windows.Forms.TextBox FileLengthTB;
      private System.Windows.Forms.CheckBox followTailCheckBox;
      private System.Windows.Forms.TabControl TabControlParent;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.MenuStrip menuStrip2;
      private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
      private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
      private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
      private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
      private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
      private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
      private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
      private System.Windows.Forms.RichTextBox LogRichTextBox1;
   }
}

