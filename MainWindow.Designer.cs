
namespace autoUpdater
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.appListPannel = new RJControls.PanelScroll();
            this.newConfig = new System.Windows.Forms.Button();
            this.panel1 = new RJControls.PanelScroll();
            this.autoUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.launchButton = new System.Windows.Forms.Button();
            this.appType = new System.Windows.Forms.ComboBox();
            this.appVersion = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.appListPannel);
            this.splitContainer1.Panel1.Controls.Add(this.newConfig);
            this.splitContainer1.Panel1.Resize += new System.EventHandler(this.splitContainer1_Panel1_Resize);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(314, 156);
            this.splitContainer1.SplitterDistance = 103;
            this.splitContainer1.TabIndex = 4;
            // 
            // appListPannel
            // 
            this.appListPannel.AutoScroll = true;
            this.appListPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appListPannel.Location = new System.Drawing.Point(0, 29);
            this.appListPannel.Name = "appListPannel";
            this.appListPannel.ShowHorizontalScrollBar = false;
            this.appListPannel.ShowVerticalScrollBar = true;
            this.appListPannel.Size = new System.Drawing.Size(103, 127);
            this.appListPannel.TabIndex = 5;
            // 
            // newConfig
            // 
            this.newConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.newConfig.Location = new System.Drawing.Point(0, 0);
            this.newConfig.Name = "newConfig";
            this.newConfig.Size = new System.Drawing.Size(103, 29);
            this.newConfig.TabIndex = 4;
            this.newConfig.Text = "New &Config";
            this.newConfig.UseVisualStyleBackColor = true;
            this.newConfig.Click += new System.EventHandler(this.NewConfig_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.autoUpdateCheckBox);
            this.panel1.Controls.Add(this.launchButton);
            this.panel1.Controls.Add(this.appType);
            this.panel1.Controls.Add(this.appVersion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.ShowHorizontalScrollBar = false;
            this.panel1.ShowVerticalScrollBar = true;
            this.panel1.Size = new System.Drawing.Size(207, 156);
            this.panel1.TabIndex = 5;
            // 
            // autoUpdateCheckBox
            // 
            this.autoUpdateCheckBox.AutoSize = true;
            this.autoUpdateCheckBox.BackColor = System.Drawing.SystemColors.Control;
            this.autoUpdateCheckBox.Location = new System.Drawing.Point(4, 60);
            this.autoUpdateCheckBox.Name = "autoUpdateCheckBox";
            this.autoUpdateCheckBox.Size = new System.Drawing.Size(83, 17);
            this.autoUpdateCheckBox.TabIndex = 6;
            this.autoUpdateCheckBox.Text = "&AutoUpdate";
            this.autoUpdateCheckBox.UseVisualStyleBackColor = false;
            // 
            // launchButton
            // 
            this.launchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.launchButton.Location = new System.Drawing.Point(3, 83);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(200, 23);
            this.launchButton.TabIndex = 5;
            this.launchButton.Text = "&Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.Launch_Click);
            // 
            // appType
            // 
            this.appType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appType.FormattingEnabled = true;
            this.appType.Location = new System.Drawing.Point(3, 5);
            this.appType.Name = "appType";
            this.appType.Size = new System.Drawing.Size(201, 21);
            this.appType.TabIndex = 0;
            // 
            // appVersion
            // 
            this.appVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appVersion.FormattingEnabled = true;
            this.appVersion.Location = new System.Drawing.Point(3, 32);
            this.appVersion.Name = "appVersion";
            this.appVersion.Size = new System.Drawing.Size(201, 21);
            this.appVersion.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 159);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(314, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownButtonWidth = 0;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(21, 20);
            this.toolStripSplitButton1.Text = "&Settings";
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.LimeGreen;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 17);
            this.toolStripStatusLabel1.Text = "OK";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 181);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(330, 220);
            this.Name = "mainWindow";
            this.Text = "RJ\'s Launcher";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox appType;
        private System.Windows.Forms.ComboBox appVersion;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button newConfig;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private RJControls.PanelScroll panel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private RJControls.PanelScroll appListPannel;
        private System.Windows.Forms.CheckBox autoUpdateCheckBox;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

