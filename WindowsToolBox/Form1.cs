using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace WindowsToolBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenCmd_Click(object sender, EventArgs e)
        {
            string systemInfo = "打开时的cmd目录不是system32,请自行用cd命令修改!";
            MessageBox.Show(systemInfo, "警告");
            Process.Start("cmd.exe");
        }

        private void OpenTaskmgr_Click(object sender, EventArgs e)
        {
            Process.Start("Taskmgr.exe");
        }

        private void AboutMe_Click(object sender, EventArgs e)
        {
            string AboutMe = "Ashui工具箱 Copyright © 2024 Ashui Team.All rights reserved.                                   软件当前为内部Beta版，请勿泄露:)";
            MessageBox.Show(AboutMe, "关于");
        }

        private void OpenNotepad_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void OpenControlPatel_Click(object sender, EventArgs e)
        {
            Process.Start("control.exe");
        }

        private void OpenWindowsSettings_Click(object sender, EventArgs e)
        {
            Process.Start("ms-settings:");
        }
        
        private void hahaha_Click(object sender, EventArgs e)
        {
            string hahaha = "你对此做出的选择，作者均不承担责任。是否继续？";
            MessageBox.Show(hahaha, "警告");
            System.Diagnostics.Process.Start("https://www.bilibili.com/video/BV1GJ411x7h7/?spm_id_from=333.337.search-card.all.click&vd_source=d4d19cc967caa350e71d7b7ac46aa7ae");
        }

        private void ShowSystemInfo_Click(object sender, EventArgs e)
        {
            // 获取系统信息
            string systemInfo = GetSystemInfo();

            // 弹出窗口显示系统信息
            MessageBox.Show(systemInfo, "系统信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetSystemInfo()
        {
            //获取系统信息
            string info = "操作系统: " + Environment.OSVersion.ToString() + Environment.NewLine;
            info += "计算机名: " + Environment.MachineName + Environment.NewLine;
            info += "用户名: " + Environment.UserName + Environment.NewLine;
            info += "CPU核心数: " + Environment.ProcessorCount + Environment.NewLine;
            info += "CPU架构: " + Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE") + Environment.NewLine;
            info += "逻辑驱动器数量: " + Environment.GetLogicalDrives().Length;

            //return
            return info;
        }

        private void OpenExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("Explorer.exe");
        }

        private void Opencleanmgr_Click(object sender, EventArgs e)
        {
            Process.Start("cleanmgr.exe");
        }

        private void bilibili_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://space.bilibili.com/3546660927966069");
        }

        private void tiktok_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.douyin.com/user/MS4wLjABAAAARj0RLPedraGJVl9Zrf02yxf_hFEsJgxuTX8RMvIviKTU5U2-LdnLPeE1o5ct0_rU?_sw=1278091237526244&from_tab_name=main");
        }
    }
}
