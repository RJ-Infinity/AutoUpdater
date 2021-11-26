
namespace autoUpdater
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.panel1 = new RJControls.PanelScroll();
            this.themeGroupBox = new System.Windows.Forms.GroupBox();
            this.aboutGroupBox = new System.Windows.Forms.GroupBox();
            this.generalGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colourSelector1 = new RJControls.ColourSelector();
            this.panel1.SuspendLayout();
            this.themeGroupBox.SuspendLayout();
            this.generalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.themeGroupBox);
            this.panel1.Controls.Add(this.aboutGroupBox);
            this.panel1.Controls.Add(this.generalGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.ShowHorizontalScrollBar = false;
            this.panel1.ShowVerticalScrollBar = true;
            this.panel1.Size = new System.Drawing.Size(259, 186);
            this.panel1.TabIndex = 0;
            // 
            // themeGroupBox
            // 
            this.themeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.themeGroupBox.Controls.Add(this.colourSelector1);
            this.themeGroupBox.Location = new System.Drawing.Point(4, 162);
            this.themeGroupBox.Name = "themeGroupBox";
            this.themeGroupBox.Size = new System.Drawing.Size(235, 100);
            this.themeGroupBox.TabIndex = 2;
            this.themeGroupBox.TabStop = false;
            this.themeGroupBox.Text = "Theme";
            // 
            // aboutGroupBox
            // 
            this.aboutGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutGroupBox.Location = new System.Drawing.Point(4, 268);
            this.aboutGroupBox.Name = "aboutGroupBox";
            this.aboutGroupBox.Size = new System.Drawing.Size(235, 100);
            this.aboutGroupBox.TabIndex = 1;
            this.aboutGroupBox.TabStop = false;
            this.aboutGroupBox.Text = "About";
            // 
            // generalGroupBox
            // 
            this.generalGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalGroupBox.Controls.Add(this.button1);
            this.generalGroupBox.Controls.Add(this.removeButton);
            this.generalGroupBox.Controls.Add(this.addButton);
            this.generalGroupBox.Controls.Add(this.textBox1);
            this.generalGroupBox.Controls.Add(this.listBox1);
            this.generalGroupBox.Location = new System.Drawing.Point(4, 4);
            this.generalGroupBox.Name = "generalGroupBox";
            this.generalGroupBox.Size = new System.Drawing.Size(235, 152);
            this.generalGroupBox.TabIndex = 0;
            this.generalGroupBox.TabStop = false;
            this.generalGroupBox.Text = "General";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Location = new System.Drawing.Point(154, 51);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "&Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(154, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 95);
            this.listBox1.TabIndex = 0;
            // 
            // colourSelector1
            // 
            this.colourSelector1.Location = new System.Drawing.Point(8, 19);
            this.colourSelector1.Name = "colourSelector1";
            this.colourSelector1.Size = new System.Drawing.Size(79, 16);
            this.colourSelector1.TabIndex = 0;
            this.colourSelector1.Text = "colourSelector1";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 186);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(275, 225);
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "SettingsForm";
            this.panel1.ResumeLayout(false);
            this.themeGroupBox.ResumeLayout(false);
            this.generalGroupBox.ResumeLayout(false);
            this.generalGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RJControls.PanelScroll panel1;
        private System.Windows.Forms.GroupBox generalGroupBox;
        private System.Windows.Forms.GroupBox aboutGroupBox;
        private System.Windows.Forms.GroupBox themeGroupBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private RJControls.ColourSelector colourSelector1;
    }
}