using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoUpdater
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void NewConfig_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=0;i<10;i++){
                Button btn = new Button();
                btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                btn.Width = appListPannel.InternalPanelWidth - btn.Margin.Right;
                btn.Text = "btn" + appListPannel.Controls.Count.ToString();
                btn.Top = ((btn.Height + btn.Margin.Top) * appListPannel.Controls.Count) - appListPannel.VerticalScroll.Value;
                appListPannel.Controls.Add(btn);
            }
        }
        
        private void Launch_Click(object sender, EventArgs e)
        {
            appListPannel.Controls.Clear();
        }
        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            appListPannel.Height = ((Control)sender).Height - newConfig.Height;
        }
        protected override void OnResize(EventArgs e)
        {
            splitContainer1.Height = Height - statusStrip1.Height - 41 /*ridiculus constant*/;
            base.OnResize(e);
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }
    }
}
 