using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.ServiceProcess;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace msconfuck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PenisCheck_CheckedChanged(object sender, EventArgs e)
        {
            Penis1.Enabled = PenisCheck.Checked;
            Penis2.Enabled = PenisCheck.Checked;
        }

        private void NormalButtonStartup_CheckedChanged(object sender, EventArgs e)
        {
            Penis1.Checked = true;
            Penis2.Checked = true;
        }

        private void DiagButtonPen_CheckedChanged(object sender, EventArgs e)
        {
            Penis1.Checked = false;
            Penis2.Checked = false;
        }

        private void HelpMyPenisBurns_Click(object sender, EventArgs e)
        {
            Process.Start("https://go.microsoft.com/fwlink/?LinkId=517009");
        }

        private void CancelMyProstateExam_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AlrightDocMyPenisIsFineThanks_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Add_Services()
        {
            foreach (ServiceController service in ServiceController.GetServices())
            {
                ListViewItem item = new ListViewItem(service.DisplayName);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, "Microsoft Corporation"));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, "Running"));
                item.Checked = true;
                Services.Items.Add(item);
            }
        }

        public static string GetOSFriendlyName()
        {
            string result = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
            foreach (ManagementObject os in searcher.Get())
            {
                result = os["Caption"].ToString();
                break;
            }
            result = Regex.Replace(result, @"\D+", "");

            return result;
        }

        Tuple<string,string,string> tup(string a, string b, string c) { return new Tuple<string, string, string>(a, b, c); }

        Dictionary<string, string> tool_cmd_map = new Dictionary<string, string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            TheBootBois.Items.Clear();
            TheBootBois.Items.Add("Windows "+GetOSFriendlyName()+" (C:\\Windows) : Current OS; Default OS");
            TheBootBois.SetSelected(0, true);

            //kill me please
            List<Tuple<string, string, string>> tools_items = new List<Tuple<string, string, string>>();
            tools_items.Add(tup("About Windows", "Display Windows version information.", "C:\\Windows\\system32\\winver.exe"));
            tools_items.Add(tup("Change UAC Settings", "Change User Account Control settings.", "C:\\Windows\\System32\\UserAccountControlSettings.exe"));
            tools_items.Add(tup("Security and Maintenance", "Open Security and Maintenance.", "C:\\Windows\\System32\\wscui.cpl"));
            tools_items.Add(tup("Windows Troubleshooting", "Troubleshoot problems with your computer.", "C:\\Windows\\System32\\control.exe /name Microsoft.Troubleshooting"));
            tools_items.Add(tup("Computer Management", "View and configure system settings and components.", "C:\\Windows\\System32\\compmgmt.msc"));
            tools_items.Add(tup("System Information", "View advanced information about hardware and software settings.", "C:\\Windows\\System32\\msinfo32.exe"));
            tools_items.Add(tup("Event Viewer", "View monitoring and troubleshooting messages.", "C:\\Windows\\System32\\eventvwr.exe"));
            tools_items.Add(tup("Programs", "Launch, add, or remove programs and Windows components.", "C:\\Windows\\System32\\appwiz.cpl"));
            tools_items.Add(tup("System Properties", "View basic information about your computer system settings.", "C:\\Windows\\System32\\control.exe system"));
            tools_items.Add(tup("Internet Options", "View Internet Properties.", "C:\\Windows\\System32\\inetcpl.cpl"));
            tools_items.Add(tup("Internet Protocol Configuration", "View and configure network address settings.", "C:\\Windows\\System32\\cmd.exe /k %windir%\\system32\\ipconfig.exe%%%ADV/all"));
            tools_items.Add(tup("Performance Monitor", "Monitor the performance of local or remote computers.", "C:\\Windows\\System32\\perfmon.exe%%%ADV/sys"));
            tools_items.Add(tup("Resource Monitor", "Monitor the performance and resource usage of the local computer.", "C:\\Windows\\System32\\resmon.exe"));
            tools_items.Add(tup("Task Manager", "View details about programs and processes running on your computer.", "C:\\Windows\\System32\\taskmgr.exe /7"));
            tools_items.Add(tup("Command Prompt", "Open a command prompt window.", "C:\\Windows\\System32\\cmd.exe"));
            tools_items.Add(tup("Registry Editor", "Make changes to the Windows registry.", "C:\\Windows\\System32\\regedt32.exe"));
            tools_items.Add(tup("Remote Assistance", "Receive help from (or offer help to) a friend over the Internet.", "C:\\Windows\\System32\\msra.exe"));
            tools_items.Add(tup("System Restore", "Restore your computer system to an earlier state.", "C:\\Windows\\System32\\rstrui.exe"));
            foreach(Tuple<string,string,string> tool in tools_items)
            {
                ListViewItem item = new ListViewItem(tool.Item1);
                item.SubItems.Add(tool.Item2);
                tool_cmd_map.Add(tool.Item1, tool.Item3);
                ToolsBoys.Items.Add(item);
            }

            Add_Services();
        }

        private void SafeBootMan_CheckedChanged(object sender, EventArgs e)
        {
            Lol1.Enabled = SafeBootMan.Checked;
            Lol2.Enabled = SafeBootMan.Checked;
            Lol3.Enabled = SafeBootMan.Checked;
            Lol4.Enabled = SafeBootMan.Checked;
        }

        private void OpenMeUpDaddyo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("taskmgr");
        }

        private void ShowMeMoreBootsPapa_Click(object sender, EventArgs e)
        {
            using (AdvancedBootBoy b = new AdvancedBootBoy()) b.ShowDialog();
        }

        private void ExecToolCmd_Click(object sender, EventArgs e)
        {
            //split into command data
            if (string.IsNullOrEmpty(ToolCMD.Text)) return;
            List<string> cmd_split = ToolCMD.Text.Split(' ').ToList();
            string bin = cmd_split[0];
            cmd_split.RemoveAt(0);
            string args = string.Join(" ", cmd_split.ToArray());

            //launch binary with args
            Process.Start(new ProcessStartInfo(bin, args));
        }

        private void AdvancedToolCMD_CheckedChanged(object sender, EventArgs e)
        {
            if (current_cmd_dat == null) return;

            //if we checked, add the extra feature
            //if not, set to the raw command
            if (AdvancedToolCMD.Checked) ToolCMD.Text = current_cmd_dat[0] + " " + current_cmd_dat[1];
            else ToolCMD.Text = current_cmd_dat[0];
        }

        string[] current_cmd_dat = null;
        private void ToolsBoys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ToolsBoys.SelectedItems.Count == 0) return;
            current_cmd_dat = tool_cmd_map[ToolsBoys.SelectedItems[0].Text].Split(new string[] { "%%%ADV" }, StringSplitOptions.RemoveEmptyEntries);

            //add tool cmd
            ToolCMD.Text = current_cmd_dat[0];
            if (current_cmd_dat.Length == 2 && AdvancedToolCMD.Checked) ToolCMD.Text += " " + current_cmd_dat[1];
            AdvancedToolCMD.Visible = current_cmd_dat.Length == 2;
        }

        void ToggleServiceCheck(bool check)
        {
            foreach (ListViewItem item in Services.Items) item.Checked = check;
        }
        private void DisableServ_Click(object sender, EventArgs e)
        {
            ToggleServiceCheck(false);
        }

        private void EnableServ_Click(object sender, EventArgs e)
        {
            ToggleServiceCheck(true);
        }

        private void HideMicroServices_CheckedChanged(object sender, EventArgs e)
        {
            if (HideMicroServices.Checked) Services.Items.Clear();
            else Add_Services();
        }

        private void ApplyMyPenisOintment_MouseEnter(object sender, EventArgs e)
        {
            ApplyMyPenisOintment.Enabled = false;
        }

        private void ApplyMyPenisOintment_MouseLeave(object sender, EventArgs e)
        {
            ApplyMyPenisOintment.Enabled = true;
        }
    }
}
