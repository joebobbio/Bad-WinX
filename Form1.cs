using System;
using System.Diagnostics;
namespace Bad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var url = "ms-settings:appsfeatures";
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = url;
            Process.Start(psi);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var url = "ms-settings:powersleep";
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = url;
            Process.Start(psi);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process eview = new Process();
            eview.StartInfo.FileName = "mmc.exe";
            eview.StartInfo.Arguments = "eventvwr.msc";
            eview.StartInfo.WorkingDirectory = @"c:\windows\system32";
            eview.EnableRaisingEvents = true;
            eview.Start();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var url = "ms-settings:about";
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = url;
            Process.Start(psi);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process devmgr = new Process();
            devmgr.StartInfo.FileName = "mmc.exe";
            devmgr.StartInfo.Arguments = "devmgmt.msc";
            devmgr.StartInfo.WorkingDirectory = @"c:\windows\system32";
            devmgr.EnableRaisingEvents = true;
            devmgr.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var url = "ms-settings:network";
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = url;
            Process.Start(psi);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process dismgr = new Process();
            dismgr.StartInfo.FileName = "mmc.exe";
            dismgr.StartInfo.Arguments = "diskmgmt.msc";
            dismgr.StartInfo.WorkingDirectory = @"c:\windows\system32";
            dismgr.EnableRaisingEvents = true;
            dismgr.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process compmgr = new Process();
            compmgr.StartInfo.FileName = "mmc.exe";
            compmgr.StartInfo.Arguments = "compmgmt.msc";
            compmgr.StartInfo.WorkingDirectory = @"c:\windows\system32";
            compmgr.EnableRaisingEvents = true;
            compmgr.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            var terminal = new ProcessStartInfo();
            terminal.UseShellExecute = true;
            terminal.FileName = "explorer.exe";
            terminal.Arguments = @"C:\Program Files\WindowsApps\Microsoft.WindowsTerminal_1.12.10733.0_x64__8wekyb3d8bbwe\WindowsTerminal.exe";
            Process.Start(terminal);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process terminaladmin = new Process();
            terminaladmin.StartInfo.FileName = "wt.exe";
            terminaladmin.EnableRaisingEvents = true;
            terminaladmin.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process taskmgr = new Process();
            taskmgr.StartInfo.FileName = "Taskmgr.exe";
            taskmgr.StartInfo.Arguments = "/4";
            taskmgr.StartInfo.WorkingDirectory = @"c:\windows\system32";
            taskmgr.EnableRaisingEvents = true;
            taskmgr.Start();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            var url = "ms-settings:";
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = url;
            Process.Start(psi);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process exp = new Process();
            exp.StartInfo.FileName = "explorer.exe";
            exp.StartInfo.Arguments = "/Embedding";
            exp.StartInfo.WorkingDirectory = @"c:\windows\";
            exp.EnableRaisingEvents = true;
            exp.Start();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process rund = new Process();
            rund.StartInfo.FileName = "explorer.exe";
            rund.StartInfo.Arguments = "Shell:::{2559a1f3-21d7-11d4-bdaf-00c04f60b9f0}";
            rund.StartInfo.WorkingDirectory = @"c:\windows\";
            rund.EnableRaisingEvents = true;
            rund.Start();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process logout = new Process();
            logout.StartInfo.FileName = "shutdown.exe";
            logout.StartInfo.Arguments = "/l";
            logout.StartInfo.WorkingDirectory = @"c:\windows\system32";
            logout.EnableRaisingEvents = true;
            logout.Start();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process sdown = new Process();
            sdown.StartInfo.FileName = "shutdown.exe";
            sdown.StartInfo.Arguments = "/s /t 0";
            sdown.StartInfo.WorkingDirectory = @"c:\windows\system32";
            sdown.EnableRaisingEvents = true;
            sdown.Start();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Process rstrt = new Process();
            rstrt.StartInfo.FileName = "shutdown.exe";
            rstrt.StartInfo.Arguments = "/r /t 0";
            rstrt.StartInfo.WorkingDirectory = @"c:\windows\system32";
            rstrt.EnableRaisingEvents = true;
            rstrt.Start();

        }
    }
}