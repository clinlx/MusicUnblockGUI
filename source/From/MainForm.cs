using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicUnblock
{
    public partial class MainForm : Form
    {
        string ip = "127.0.0.1";
        public bool Running, Stop;
        static public int port;
        static public bool AreSet;
        Thread proxy;
        CmdSystem cmd = new CmdSystem();
        public MainForm()
        {
            InitializeComponent();
            this.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataRead();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Running = false;
            Stop = false;
            AreSet = false;
            if(Settings.selfStart)
            {
                MakeMin_Click(sender, e);
            }
            if(Settings.autoRun)
            {
                Start_Click(sender, e);
            }
        }
        public void closeNode()
        {
            Stop = true;
            Start.Text = "开启代理";
            Running = false;
            UseText.Visible = false;
            try
            {
                cmd.cmd.Kill();
            }
            catch
            {

            }
            cmd.cmd.Close();
            cmd.cmd = null;
        }
        private void Start_Click(object sender, EventArgs e)
        {
            if (Running)
            {
                closeNode();
            }
            else
            {
                if (Stop) return;
                port = PortRight(PortInput.Text);
                if (port == -1)
                {
                    ProxyMessage.Text = "代理运行失败：端口错误! 请输入 1~65534 !";
                    return;
                }
                Running = true;
                Start.Text = "关闭代理";
                ProxyMessage.Text = "代理开始运行：";
                proxy = new Thread(new ThreadStart(init));
                proxy.Start();
                UseText.Text = "代理已经开启，请在网易云音乐'设置-工具'中配置代理为：\r\n{【服务器】" + ip + " ;【端口】" + port + " }";
                UseText.Visible = true;
            }
        }
        private int PortRight(string txt)
        {
            int number = 0;
            for (int i = 0; i < txt.Length; i++)
                if ('0' <= txt[i] && txt[i] <= '9')
                {
                    number *= 10;
                    number += txt[i] - '0';
                }
                else
                    return -1;
            if (number < 1 || number >= 65535)
                return -1;
            return number;
        }
        private void init()
        {
            cmd.sendCmd(this);
        }
        private void MakeMin_Click(object sender, EventArgs e)
        {
            // 将窗体变为最小化
            this.WindowState = FormWindowState.Minimized;
            //this.Visible = false;
            this.ShowInTaskbar = false; //不显示在系统任务栏 
            MinIcon.Visible = true; //托盘图标可见 
            MinIcon.ShowBalloonTip(1);//显示气泡
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.DataWrite(PortInput.Text + "\n" + Settings.selfStart + "\n" + Settings.autoRun);
            if (cmd.cmd == null) return;
            cmd.cmd.Kill();
            cmd.cmd.Close();
            cmd.cmd = null;
        }

        private void MinIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ToMax();
        }
        private void ToMax()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                MinIcon.Visible = false;
            }
        }
        private void Info_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("说明：\r\n\r\n1:本程序为个人因兴趣爱好业余制作，不做盈利和商业用途，如遇售卖请立即退款差评\r\n\r\n2:本程序是本人为github开源项目“unblockneteasemusic”做的引导启动程序，和开源代码放在同一目录下，并没有对开源代码进行任何修改，启动器本身结构简单，\r\n源项目地址：https://github.com/UnblockNeteaseMusic/server");
        }

        private void ToSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AreSet)
                return;
            AreSet = true;
            Thread SettingForm = new Thread(delegate () { new Settings().ShowDialog(); });
            SettingForm.Start();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataRead()
        {
            int maxDataNum = 3,DataNum = 1;
            string filePath = ".\\Settings.cnf";
            try
            {
                string line;
                // 创建一个 StreamReader 的实例来读取文件 ,using 语句也能关闭 StreamReader
                using (System.IO.StreamReader sr = new System.IO.StreamReader(filePath))
                {
                    // 从文件读取并显示行，直到文件的末尾
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (DataNum > maxDataNum) 
                        {
                            break;
                        }
                        switch(DataNum)
                        {
                            case 1:
                                PortInput.Text = line.Trim();
                                break;
                            case 2:
                                switch(line.Trim())
                                {
                                    case "True":
                                        Settings.selfStart = true;
                                        break;
                                    case "False":
                                        Settings.selfStart = false;
                                        break;
                                    default:
                                        DefaultData();
                                        return;
                                }
                                break;
                            case 3:
                                switch (line.Trim())
                                {
                                    case "True":
                                        Settings.autoRun = true;
                                        break;
                                    case "False":
                                        Settings.autoRun = false;
                                        break;
                                    default:
                                        DefaultData();
                                        return;
                                }
                                break;
                        }
                        DataNum++;
                    }
                    if (DataNum <= maxDataNum)
                    {
                        DefaultData();
                        return;
                    }
                }
            }
            catch
            {
                // 向用户显示出错消息
                //Console.WriteLine("The file could not be read:");
                //Console.WriteLine(e.Message);
                DefaultData();
            }
            return;
        }

        private void IconMax_Click(object sender, EventArgs e)
        {
            ToMax();
        }

        private void IconExit_Click(object sender, EventArgs e)
        {
            Exit_Click(sender, e);
        }

        private void UseLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Thread useForm = new Thread(delegate () { new UseForm().ShowDialog(); });
            useForm.Start();
        }

        private void DefaultData()
        {
            PortInput.Text = "511";
            Settings.selfStart = false;
            Settings.autoRun = false;
        }
    }
}
