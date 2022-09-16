namespace Logger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerMessages = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listApplicazioni = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPositive = new System.Windows.Forms.Label();
            this.panelErrors = new System.Windows.Forms.Panel();
            this.lblErrors = new System.Windows.Forms.Label();
            this.panelWarning = new System.Windows.Forms.Panel();
            this.lblWarings = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.comboTypesFilter = new System.Windows.Forms.ToolStripComboBox();
            this.btnControlTimer = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelErrors.SuspendLayout();
            this.panelWarning.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMessages
            // 
            this.timerMessages.Enabled = true;
            this.timerMessages.Interval = 10000;
            this.timerMessages.Tick += new System.EventHandler(this.timerMessages_Tick);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(279, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(699, 424);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Applicazioni Collegate (0)";
            // 
            // listApplicazioni
            // 
            this.listApplicazioni.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listApplicazioni.FormattingEnabled = true;
            this.listApplicazioni.ItemHeight = 15;
            this.listApplicazioni.Location = new System.Drawing.Point(12, 73);
            this.listApplicazioni.Name = "listApplicazioni";
            this.listApplicazioni.Size = new System.Drawing.Size(261, 424);
            this.listApplicazioni.TabIndex = 2;
            this.listApplicazioni.SelectedIndexChanged += new System.EventHandler(this.listApplicazioni_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentApplicationToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // currentApplicationToolStripMenuItem
            // 
            this.currentApplicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tXTFileToolStripMenuItem});
            this.currentApplicationToolStripMenuItem.Name = "currentApplicationToolStripMenuItem";
            this.currentApplicationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.currentApplicationToolStripMenuItem.Text = "Current Application";
            // 
            // tXTFileToolStripMenuItem
            // 
            this.tXTFileToolStripMenuItem.Name = "tXTFileToolStripMenuItem";
            this.tXTFileToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.tXTFileToolStripMenuItem.Text = "TXT File";
            this.tXTFileToolStripMenuItem.Click += new System.EventHandler(this.tXTFileToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = "";
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panelErrors);
            this.groupBox1.Controls.Add(this.panelWarning);
            this.groupBox1.Controls.Add(this.panelInfo);
            this.groupBox1.Location = new System.Drawing.Point(984, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(78, 232);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistiche";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.lblPositive);
            this.panel1.Location = new System.Drawing.Point(6, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 47);
            this.panel1.TabIndex = 9;
            // 
            // lblPositive
            // 
            this.lblPositive.AutoSize = true;
            this.lblPositive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPositive.Location = new System.Drawing.Point(16, 14);
            this.lblPositive.Name = "lblPositive";
            this.lblPositive.Size = new System.Drawing.Size(33, 21);
            this.lblPositive.TabIndex = 0;
            this.lblPositive.Text = "0%";
            // 
            // panelErrors
            // 
            this.panelErrors.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelErrors.BackColor = System.Drawing.Color.Red;
            this.panelErrors.Controls.Add(this.lblErrors);
            this.panelErrors.Location = new System.Drawing.Point(6, 179);
            this.panelErrors.Name = "panelErrors";
            this.panelErrors.Size = new System.Drawing.Size(63, 47);
            this.panelErrors.TabIndex = 10;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblErrors.Location = new System.Drawing.Point(16, 13);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(33, 21);
            this.lblErrors.TabIndex = 2;
            this.lblErrors.Text = "0%";
            // 
            // panelWarning
            // 
            this.panelWarning.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelWarning.BackColor = System.Drawing.Color.Yellow;
            this.panelWarning.Controls.Add(this.lblWarings);
            this.panelWarning.Location = new System.Drawing.Point(6, 126);
            this.panelWarning.Name = "panelWarning";
            this.panelWarning.Size = new System.Drawing.Size(63, 47);
            this.panelWarning.TabIndex = 9;
            // 
            // lblWarings
            // 
            this.lblWarings.AutoSize = true;
            this.lblWarings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWarings.Location = new System.Drawing.Point(16, 14);
            this.lblWarings.Name = "lblWarings";
            this.lblWarings.Size = new System.Drawing.Size(33, 21);
            this.lblWarings.TabIndex = 1;
            this.lblWarings.Text = "0%";
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.Controls.Add(this.lblInfo);
            this.panelInfo.Location = new System.Drawing.Point(6, 19);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(63, 47);
            this.panelInfo.TabIndex = 8;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(16, 14);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(33, 21);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "0%";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboTypesFilter,
            this.btnControlTimer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1074, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // comboTypesFilter
            // 
            this.comboTypesFilter.Name = "comboTypesFilter";
            this.comboTypesFilter.Size = new System.Drawing.Size(121, 25);
            this.comboTypesFilter.Text = "Filtra";
            this.comboTypesFilter.SelectedIndexChanged += new System.EventHandler(this.comboTypesFilter_SelectedIndexChanged_1);
            // 
            // btnControlTimer
            // 
            this.btnControlTimer.Image = ((System.Drawing.Image)(resources.GetObject("btnControlTimer.Image")));
            this.btnControlTimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnControlTimer.Name = "btnControlTimer";
            this.btnControlTimer.Size = new System.Drawing.Size(58, 22);
            this.btnControlTimer.Text = "Pause";
            this.btnControlTimer.Click += new System.EventHandler(this.btnControlTimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 517);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listApplicazioni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Logger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelErrors.ResumeLayout(false);
            this.panelErrors.PerformLayout();
            this.panelWarning.ResumeLayout(false);
            this.panelWarning.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMessages;
        private ListBox listBox1;
        private Label label1;
        private ListBox listApplicazioni;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem currentApplicationToolStripMenuItem;
        private ToolStripMenuItem tXTFileToolStripMenuItem;
        private GroupBox groupBox1;
        private Panel panelErrors;
        private Panel panelWarning;
        private Panel panelInfo;
        private Label lblInfo;
        private Label lblWarings;
        private Label lblErrors;
        private ToolStrip toolStrip1;
        private ToolStripComboBox comboTypesFilter;
        private ToolStripButton btnControlTimer;
        private Panel panel1;
        private Label lblPositive;
    }
}