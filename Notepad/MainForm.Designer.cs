namespace Notepad
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
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pagesetupFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.printFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.copyEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.findEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.findnextEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.selectallEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.timedateEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.wordwrapFormatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fontFormatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.restoreDefaultZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusbarViewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewhelpHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutnotepadHelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.statusContent = new System.Windows.Forms.StatusStrip();
            this.PositionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1_ZoomFactor = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.status_zoom_factor = new System.Windows.Forms.ToolStripStatusLabel();
            this.menubar.SuspendLayout();
            this.statusContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // menubar
            // 
            this.menubar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.formatMenu,
            this.viewMenu,
            this.viewhelpHelpMenu});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(873, 28);
            this.menubar.TabIndex = 0;
            this.menubar.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenu,
            this.newWindowToolStripMenuItem,
            this.openFileMenu,
            this.saveFileMenu,
            this.saveasFileMenu,
            this.toolStripSeparator1,
            this.pagesetupFileMenu,
            this.printFileMenu,
            this.toolStripSeparator2,
            this.exitFileMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(46, 26);
            this.fileMenu.Text = "File";
            // 
            // newFileMenu
            // 
            this.newFileMenu.Name = "newFileMenu";
            this.newFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileMenu.Size = new System.Drawing.Size(278, 26);
            this.newFileMenu.Text = "New";
            this.newFileMenu.Click += new System.EventHandler(this.newFileMenu_Click);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.newWindowToolStripMenuItem.Text = "New Window ";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // openFileMenu
            // 
            this.openFileMenu.Name = "openFileMenu";
            this.openFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenu.Size = new System.Drawing.Size(278, 26);
            this.openFileMenu.Text = "Open...";
            this.openFileMenu.Click += new System.EventHandler(this.openFileMenu_Click);
            // 
            // saveFileMenu
            // 
            this.saveFileMenu.Name = "saveFileMenu";
            this.saveFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileMenu.Size = new System.Drawing.Size(278, 26);
            this.saveFileMenu.Text = "Save";
            this.saveFileMenu.Click += new System.EventHandler(this.saveFileMenu_Click);
            // 
            // saveasFileMenu
            // 
            this.saveasFileMenu.Name = "saveasFileMenu";
            this.saveasFileMenu.Size = new System.Drawing.Size(278, 26);
            this.saveasFileMenu.Text = "Save As...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(275, 6);
            // 
            // pagesetupFileMenu
            // 
            this.pagesetupFileMenu.Name = "pagesetupFileMenu";
            this.pagesetupFileMenu.Size = new System.Drawing.Size(278, 26);
            this.pagesetupFileMenu.Text = "Page Setup...";
            this.pagesetupFileMenu.Click += new System.EventHandler(this.pagesetupFileMenu_Click);
            // 
            // printFileMenu
            // 
            this.printFileMenu.Name = "printFileMenu";
            this.printFileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printFileMenu.Size = new System.Drawing.Size(278, 26);
            this.printFileMenu.Text = "Print";
            this.printFileMenu.Click += new System.EventHandler(this.printFileMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
            // 
            // exitFileMenu
            // 
            this.exitFileMenu.Name = "exitFileMenu";
            this.exitFileMenu.Size = new System.Drawing.Size(278, 26);
            this.exitFileMenu.Text = "Exit";
            this.exitFileMenu.Click += new System.EventHandler(this.exitFileMenu_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoEditMenu,
            this.toolStripSeparator3,
            this.cutEditMenu,
            this.copyEditMenu,
            this.pasteEditMenu,
            this.deleteEditMenu,
            this.toolStripSeparator4,
            this.findEditMenu,
            this.findnextEditMenu,
            this.replaceEditMenu,
            this.gotoEditMenu,
            this.toolStripSeparator5,
            this.selectallEditMenu,
            this.timedateEditMenu});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(49, 26);
            this.editMenu.Text = "Edit";
            this.editMenu.Click += new System.EventHandler(this.editMenu_Click);
            this.editMenu.MouseEnter += new System.EventHandler(this.editMenu_MouseEnter);
            // 
            // undoEditMenu
            // 
            this.undoEditMenu.Name = "undoEditMenu";
            this.undoEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoEditMenu.Size = new System.Drawing.Size(207, 26);
            this.undoEditMenu.Text = "Undo";
            this.undoEditMenu.Click += new System.EventHandler(this.undoEditMenu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(204, 6);
            // 
            // cutEditMenu
            // 
            this.cutEditMenu.Enabled = false;
            this.cutEditMenu.Name = "cutEditMenu";
            this.cutEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutEditMenu.Size = new System.Drawing.Size(207, 26);
            this.cutEditMenu.Text = "Cut";
            this.cutEditMenu.Click += new System.EventHandler(this.cutEditMenu_Click);
            // 
            // copyEditMenu
            // 
            this.copyEditMenu.Enabled = false;
            this.copyEditMenu.Name = "copyEditMenu";
            this.copyEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.copyEditMenu.Size = new System.Drawing.Size(207, 26);
            this.copyEditMenu.Text = "Copy";
            this.copyEditMenu.Click += new System.EventHandler(this.copyEditMenu_Click);
            // 
            // pasteEditMenu
            // 
            this.pasteEditMenu.Enabled = false;
            this.pasteEditMenu.Name = "pasteEditMenu";
            this.pasteEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteEditMenu.Size = new System.Drawing.Size(207, 26);
            this.pasteEditMenu.Text = "Paste";
            this.pasteEditMenu.Click += new System.EventHandler(this.pasteEditMenu_Click_1);
            // 
            // deleteEditMenu
            // 
            this.deleteEditMenu.Name = "deleteEditMenu";
            this.deleteEditMenu.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteEditMenu.Size = new System.Drawing.Size(207, 26);
            this.deleteEditMenu.Text = "Delete";
            this.deleteEditMenu.Click += new System.EventHandler(this.deleteEditMenu_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(204, 6);
            // 
            // findEditMenu
            // 
            this.findEditMenu.Name = "findEditMenu";
            this.findEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findEditMenu.Size = new System.Drawing.Size(207, 26);
            this.findEditMenu.Text = "Find...";
            this.findEditMenu.Click += new System.EventHandler(this.findEditMenu_Click);
            // 
            // findnextEditMenu
            // 
            this.findnextEditMenu.Name = "findnextEditMenu";
            this.findnextEditMenu.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.findnextEditMenu.Size = new System.Drawing.Size(207, 26);
            this.findnextEditMenu.Text = "Find Next";
            this.findnextEditMenu.Click += new System.EventHandler(this.findnextEditMenu_Click);
            // 
            // replaceEditMenu
            // 
            this.replaceEditMenu.Name = "replaceEditMenu";
            this.replaceEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceEditMenu.Size = new System.Drawing.Size(207, 26);
            this.replaceEditMenu.Text = "Replace...";
            this.replaceEditMenu.Click += new System.EventHandler(this.replaceEditMenu_Click_1);
            // 
            // gotoEditMenu
            // 
            this.gotoEditMenu.Name = "gotoEditMenu";
            this.gotoEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.gotoEditMenu.Size = new System.Drawing.Size(207, 26);
            this.gotoEditMenu.Text = "Go To...";
            this.gotoEditMenu.Click += new System.EventHandler(this.gotoEditMenu_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(204, 6);
            // 
            // selectallEditMenu
            // 
            this.selectallEditMenu.Name = "selectallEditMenu";
            this.selectallEditMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectallEditMenu.Size = new System.Drawing.Size(207, 26);
            this.selectallEditMenu.Text = "Select All";
            this.selectallEditMenu.Click += new System.EventHandler(this.selectallEditMenu_Click);
            // 
            // timedateEditMenu
            // 
            this.timedateEditMenu.Name = "timedateEditMenu";
            this.timedateEditMenu.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.timedateEditMenu.Size = new System.Drawing.Size(207, 26);
            this.timedateEditMenu.Text = "Time/Date";
            this.timedateEditMenu.Click += new System.EventHandler(this.timedateEditMenu_Click);
            // 
            // formatMenu
            // 
            this.formatMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordwrapFormatMenu,
            this.fontFormatMenu});
            this.formatMenu.Name = "formatMenu";
            this.formatMenu.Size = new System.Drawing.Size(70, 26);
            this.formatMenu.Text = "Format";
            // 
            // wordwrapFormatMenu
            // 
            this.wordwrapFormatMenu.CheckOnClick = true;
            this.wordwrapFormatMenu.Name = "wordwrapFormatMenu";
            this.wordwrapFormatMenu.Size = new System.Drawing.Size(168, 26);
            this.wordwrapFormatMenu.Text = "Word Wrap";
            this.wordwrapFormatMenu.CheckedChanged += new System.EventHandler(this.wordwrapFormatMenu_CheckedChanged);
            // 
            // fontFormatMenu
            // 
            this.fontFormatMenu.Name = "fontFormatMenu";
            this.fontFormatMenu.Size = new System.Drawing.Size(168, 26);
            this.fontFormatMenu.Text = "Font...";
            this.fontFormatMenu.Click += new System.EventHandler(this.fontFormatMenu_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.statusbarViewMenu});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(55, 26);
            this.viewMenu.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.toolStripSeparator7,
            this.restoreDefaultZoomToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.K)));
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(248, 6);
            // 
            // restoreDefaultZoomToolStripMenuItem
            // 
            this.restoreDefaultZoomToolStripMenuItem.Name = "restoreDefaultZoomToolStripMenuItem";
            this.restoreDefaultZoomToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.restoreDefaultZoomToolStripMenuItem.Text = "Restore Default Zoom";
            this.restoreDefaultZoomToolStripMenuItem.Click += new System.EventHandler(this.restoreDefaultZoomToolStripMenuItem_Click);
            // 
            // statusbarViewMenu
            // 
            this.statusbarViewMenu.CheckOnClick = true;
            this.statusbarViewMenu.Name = "statusbarViewMenu";
            this.statusbarViewMenu.Size = new System.Drawing.Size(158, 26);
            this.statusbarViewMenu.Text = "Status Bar";
            this.statusbarViewMenu.CheckedChanged += new System.EventHandler(this.statusbarViewMenu_CheckedChanged);
            // 
            // viewhelpHelpMenu
            // 
            this.viewhelpHelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.sendFeedbackToolStripMenuItem,
            this.toolStripSeparator6,
            this.aboutnotepadHelpMenu});
            this.viewhelpHelpMenu.Name = "viewhelpHelpMenu";
            this.viewhelpHelpMenu.Size = new System.Drawing.Size(55, 26);
            this.viewhelpHelpMenu.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // sendFeedbackToolStripMenuItem
            // 
            this.sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            this.sendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.sendFeedbackToolStripMenuItem.Text = "Send Feedback";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(193, 6);
            // 
            // aboutnotepadHelpMenu
            // 
            this.aboutnotepadHelpMenu.Name = "aboutnotepadHelpMenu";
            this.aboutnotepadHelpMenu.Size = new System.Drawing.Size(196, 26);
            this.aboutnotepadHelpMenu.Text = "About Notepad";
            this.aboutnotepadHelpMenu.Click += new System.EventHandler(this.aboutnotepadHelpMenu_Click);
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(0, 28);
            this.txtContent.Margin = new System.Windows.Forms.Padding(4);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(873, 414);
            this.txtContent.TabIndex = 1;
            this.txtContent.Text = "";
            this.txtContent.SelectionChanged += new System.EventHandler(this.txtContent_SelectionChanged);
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            this.txtContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContent_KeyDown);
            // 
            // statusContent
            // 
            this.statusContent.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusContent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PositionStatus,
            this.toolStripStatusLabel1_ZoomFactor,
            this.status_zoom_factor});
            this.statusContent.Location = new System.Drawing.Point(0, 416);
            this.statusContent.Name = "statusContent";
            this.statusContent.Size = new System.Drawing.Size(873, 26);
            this.statusContent.TabIndex = 2;
            this.statusContent.Text = "statusContent";
            // 
            // PositionStatus
            // 
            this.PositionStatus.Name = "PositionStatus";
            this.PositionStatus.Size = new System.Drawing.Size(77, 20);
            this.PositionStatus.Text = "Ln 1, Col 1";
            // 
            // toolStripStatusLabel1_ZoomFactor
            // 
            this.toolStripStatusLabel1_ZoomFactor.Name = "toolStripStatusLabel1_ZoomFactor";
            this.toolStripStatusLabel1_ZoomFactor.Size = new System.Drawing.Size(0, 20);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // status_zoom_factor
            // 
            this.status_zoom_factor.Name = "status_zoom_factor";
            this.status_zoom_factor.Size = new System.Drawing.Size(45, 20);
            this.status_zoom_factor.Text = "100%";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 442);
            this.Controls.Add(this.statusContent);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.menubar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menubar;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.statusContent.ResumeLayout(false);
            this.statusContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newFileMenu;
        private System.Windows.Forms.ToolStripMenuItem openFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenu;
        private System.Windows.Forms.ToolStripMenuItem saveasFileMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pagesetupFileMenu;
        private System.Windows.Forms.ToolStripMenuItem printFileMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem formatMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem viewhelpHelpMenu;
        private System.Windows.Forms.ToolStripMenuItem undoEditMenu;
        private System.Windows.Forms.ToolStripMenuItem cutEditMenu;
        private System.Windows.Forms.ToolStripMenuItem copyEditMenu;
        private System.Windows.Forms.ToolStripMenuItem pasteEditMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteEditMenu;
        private System.Windows.Forms.ToolStripMenuItem findEditMenu;
        private System.Windows.Forms.ToolStripMenuItem findnextEditMenu;
        private System.Windows.Forms.ToolStripMenuItem replaceEditMenu;
        private System.Windows.Forms.ToolStripMenuItem gotoEditMenu;
        private System.Windows.Forms.ToolStripMenuItem selectallEditMenu;
        private System.Windows.Forms.ToolStripMenuItem timedateEditMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem wordwrapFormatMenu;
        private System.Windows.Forms.ToolStripMenuItem fontFormatMenu;
        private System.Windows.Forms.ToolStripMenuItem statusbarViewMenu;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutnotepadHelpMenu;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.StatusStrip statusContent;
        private System.Windows.Forms.ToolStripStatusLabel PositionStatus;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem restoreDefaultZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1_ZoomFactor;
        private System.Windows.Forms.ToolStripStatusLabel status_zoom_factor;
    }
}

