using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace msconfuck
{
    public partial class AdvancedBootBoy : Form
    {
        public AdvancedBootBoy()
        {
            InitializeComponent();
        }

        private void AdvancedBootBoy_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Environment.ProcessorCount; i++) BigProcessyBoys.Items.Add(i + 1);
            BigProcessyBoys.SelectedIndex = 0;
            DebugPortBoys.SelectedIndex = 4;
        }

        private void ProcessorBoys_CheckedChanged(object sender, EventArgs e)
        {
            BigProcessyBoys.Enabled = ProcessorBoys.Checked;
        }

        private void MaxMemCheck_CheckedChanged(object sender, EventArgs e)
        {
            MemoryMaxBoy.Enabled = MaxMemCheck.Checked;
        }

        private void CancelBoy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkayBuddy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DebuggyBoy_CheckedChanged(object sender, EventArgs e)
        {
            DebugBoys.Enabled = DebuggyBoy.Checked;
        }

        private void DebugCheckPort_CheckedChanged(object sender, EventArgs e)
        {
            DebugPortBoys.Enabled = DebugCheckPort.Checked;
        }

        private void BaudBoy_CheckedChanged(object sender, EventArgs e)
        {
            BaudBoys.Enabled = BaudBoy.Checked;
        }

        private void DebugPortBoys_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isCOM = ((string)DebugPortBoys.SelectedItem).Contains("COM");
            BaudBoy.Enabled = isCOM;
            if (BaudBoy.Checked && !isCOM) BaudBoy.Checked = false;

            bool isWhatever = ((string)DebugPortBoys.SelectedItem) == "1394";
            ChannelCheck.Enabled = isWhatever;
            if (ChannelCheck.Checked && !isWhatever) ChannelCheck.Checked = false;

            USBBoy.Enabled = ((string)DebugPortBoys.SelectedItem) == "USB";
        }

        private void ChannelCheck_CheckedChanged(object sender, EventArgs e)
        {
            ChannelThingy.Enabled = ChannelCheck.Checked;
        }
    }
}
