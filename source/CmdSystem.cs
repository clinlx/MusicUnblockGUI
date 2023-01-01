using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicUnblock
{
    class CmdSystem
    {
        bool firstEcho;
        public Process cmd = null;
        public void sendCmd(MainForm cmdoom)
        {
            if (cmd == null)
            {
                cmd = new Process();//创建进程对象  
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = ".\\src\\nodejstool.exe";//设定需要执行的命令  
                startInfo.Arguments = ".\\app.js -p " + MainForm.port + ":" + (MainForm.port + 1);//“/C”表示执行完命令后马上退出  
                startInfo.UseShellExecute = false;//不使用系统外壳程序启动  
                startInfo.RedirectStandardInput = true;//重定向输入  
                startInfo.RedirectStandardOutput = true; //重定向输出  
                startInfo.CreateNoWindow = true;//不创建窗口  
                cmd.StartInfo = startInfo;
                firstEcho = true;
                // cmd.Start();
            }
            if (cmd.Start())//开始进程  
            {
                string log;
                while (cmdoom.Stop != true) 
                {
                    try
                    {
                        log = cmd.StandardOutput.ReadLine().Trim();
                        if (log != null)
                            updateLog(cmdoom, log);
                    }
                    catch
                    {
                        try
                        {
                            if (cmdoom != null)
                            {
                                updateLog(cmdoom, "代理运行已停止。\r\n");
                                if (cmdoom.Running == true)
                                {
                                    updateLog(cmdoom, "代理运行未正常终止。\r\n可能的原因是：\r\n1：代理已经在另一个进程运行\r\n2：目标端口被占用。\r\n");
                                    updateForm(cmdoom);
                                }
                                cmdoom.Stop = false;
                            }
                        }
                        catch
                        {
                            return;
                        }
                        cmdoom.Stop = false;
                        return;
                    }
                }
            }
            return;
        }
        private delegate void UpdateLog();

        private void updateLog(MainForm cmd, String log)
        {
            if (firstEcho == false) 
            {
                firstEcho = true;
                return;
            }
            UpdateLog set = delegate ()
            {
                cmd.ProxyMessage.AppendText("\r\n" + log);
            };
            cmd.Invoke(set);
        }

        private void updateForm(MainForm cmd)
        {
            UpdateLog set = delegate ()
            {
                cmd.closeNode();
            };
            cmd.Invoke(set);
        }
    }
}
