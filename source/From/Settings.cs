using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicUnblock
{
    public partial class Settings : Form
    {
        static MakeAutoStart MAS = new MakeAutoStart();
        static public bool selfStart, autoRun;
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SelfStart.Checked = selfStart;
            AutoRun.Checked = autoRun;
        }
        static public void DataWrite(string data)
        {
            string FileName = "Settings" + ".cnf";
            //设置目录
            string CurDir = ".\\";
            //判断路径是否存在
            if (!System.IO.Directory.Exists(CurDir))
            {
                System.IO.Directory.CreateDirectory(CurDir);//不存在就创建
            }
            
            String FilePath = CurDir + FileName;
            //文件覆盖方式添加内容
            System.IO.StreamWriter file = new System.IO.StreamWriter(FilePath, false);
            //保存数据到文件
            file.Write(data);
            //关闭文件
            file.Close();
            //释放对象
            file.Dispose();
            //return FilePath;
        }
        
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhoneSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            selfStart = SelfStart.Checked;
            autoRun = AutoRun.Checked;
            MAS.SetMeAutoStart(selfStart);
            MainForm.AreSet = false;
        }
    }
}
