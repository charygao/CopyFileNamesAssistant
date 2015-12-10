using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//发声库
using System.Text.RegularExpressions;//正则表达式库
using System.Runtime.InteropServices;//动态库导入

namespace CopyFileNamesAssistant
{

    public partial class FormCopyFileNames : Form
    {
        #region 启动内核报警 bibi声
        [DllImport("kernel32.dll")] // Declare the interop API
        public static extern bool Beep(uint dwFreq, uint dwDuration);
        #endregion

        #region 全局变量
        public int totalnum = 0; //统计文件数目
        public string currentPath = null; //记录当前路径
        #endregion
        public FormCopyFileNames()
        {
            InitializeComponent();
            txbPrefix.Text = txbFallName.Text = null;
            //String commandLineString = System.Environment.CommandLine;
            String[] args = System.Environment.GetCommandLineArgs();
            foreach (string var in args)
            {
                if (totalnum != 0)
                {
                    currentPath = Path.GetDirectoryName(var);
                    this.txbFallName.Text += Path.GetFileName(var) + Environment.NewLine;
                    this.txbPrefix.Text += Path.GetFileNameWithoutExtension(var) + Environment.NewLine;
                }
                //MessageBox.Show(currentPath);
                totalnum++;
            }
            totalnum--;
            this.toolStripStatusLabelNumber.Text = totalnum.ToString();
            this.txbFallName.AllowDrop = true;
            this.txbFallName.DragDrop += new System.Windows.Forms.DragEventHandler(this.txbFallName_DragDrop);
            this.txbFallName.DragEnter += new System.Windows.Forms.DragEventHandler(this.txbFallName_DragEnter);

        }

        #region page1 复制
        private void txbFallName_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void txbFallName_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //获取拖放的文件地址
                string StrFileName = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                this.txbFallName.Text = StrFileName;
                //将文件内容放入RichTextBox中
                string[] MyPathArray = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string MyPath in MyPathArray)
                {
                    txbPrefix.Text = File.ReadAllText(MyPath, System.Text.Encoding.Default);
                }
            }
        }
        private void btnCopyFallName_Click(object sender, EventArgs e)
        {
            if (this.txbFallName.Text != null && this.txbFallName.Text.Length >= 1)
            {
                //richTextBox2.SelectAll();
                //Clipboard.Clear();
                //Clipboard.SetText(richTextBox2.Text.Replace("\n", "\r\n"), TextDataFormat.UnicodeText);
                this.txbFallName.SelectAll();
                this.txbFallName.Copy();
                //MessageBox.Show(richTextBox1.Text.Replace("\n", "@@"));
                //Clipboard.SetData("text",richTextBox2.Text);// 
            }

            // Make the interop call:
            if (!Beep(440, 250))
            {
                // If the call the beep fails (if the computer has no sound card
                // for example) display a warning dialog in its place.
                MessageBox.Show("Alert.");
            }
            Application.Exit(); Environment.Exit(0);

        }

        private void btnCopyFileNameOnly_Click(object sender, EventArgs e)
        {
            if (this.txbPrefix.Text != null && this.txbPrefix.Text.Length >= 1)
            {
                this.txbPrefix.SelectAll();
                this.txbPrefix.Copy();
                //richTextBox1.SelectAll();
                //Clipboard.Clear();
                //string alltext = null;
                //string[] stext = richTextBox1.Text.Replace("\r\n","\r").Split('\r');
                //foreach (string item in stext)
                //{
                //    alltext = item +"\r\n";
                //}
                //Clipboard.SetText(richTextBox1.Text.Replace("\n", "\r\n").ToString());//,TextDataFormat.UnicodeText);
                //richTextBox1.Text = richTextBox2.Text.Replace("\n", "\r\n");
                //richTextBox1.Text.cop
                //MessageBox.Show(richTextBox1.Text.Replace("\n", "@@"));
            }

            // Make the interop call:
            if (!Beep(440, 250))
            {
                // If the call the beep fails (if the computer has no sound card
                // for example) display a warning dialog in its place.
                MessageBox.Show("Alert.");
            }
            Application.Exit(); Environment.Exit(0);

        }
        #endregion

        #region page2 创建目录
        private void btnCreatFolders_Click(object sender, EventArgs e)
        {
            if (!Beep(440, 250))
            {
                // If the call the beep fails (if the computer has no sound card
                // for example) display a warning dialog in its place.
                MessageBox.Show("Alert.");
            }
            string input = txbPrefix.Text;
            //Regex myRegex = new Regex("");
            string all = input.Replace("\\", "#").Replace
                                      ("/", "#").Replace
                                      (":", "#").Replace
                                      ("*", "#").Replace
                                      ("?", "#").Replace
                                      ("\"", "#").Replace
                                      ("<", "#").Replace
                                      (">", "#").Replace
                                      ("|", "#");
            //string newfoldpath = null;
            string[] lines = all.Split(Environment.NewLine.ToArray());
            foreach (string str in lines)
            {
                //newfoldpath = str + currentPath.Replace("\\", "").Replace(":", "");
                if (currentPath != null)
                {
                    if (File.Exists(currentPath + "\\" + str) == false && Directory.Exists(currentPath + "\\" + str) == false)
                    {
                        Directory.CreateDirectory(currentPath + "\\" + str);
                    }

                }
                else
                {
                    MessageBox.Show("当前路径为空！");
                }

            }
        }
        #endregion

        #region page3 归档
        private void tabControl_Click(object sender, EventArgs e)
        {
            if (currentPath != null && tabControl.SelectedIndex == 2)
            {
                DirectoryInfo TheFolder = new DirectoryInfo(currentPath);

                //foreach (DirectoryInfo NextFolder in TheFolder.GetDirectories())//遍历文件夹
                //this.listBox1.Items.Add(NextFolder.Name);//遍历文件
                this.labTotal.Text = "共计" + TheFolder.GetFiles().Length + "个文件,每几个文件归档一个文件夹?";
                foreach (FileInfo NextFile in TheFolder.GetFiles())
                    this.libFiles.Items.Add(NextFile.Name);
            }
            else if (tabControl.SelectedIndex == 3)
            {
                MessageBox.Show("点击图片访问我的blog:http://www.cnblogs.com/Chary/ \n \n 同时,如果您需要更加完善的功能,请联系我的支付宝付费开发,也希望您能对我进行捐助.","提示" );
            }
            else if (tabControl.SelectedIndex == 4)
            {
                MessageBox.Show("如果您需要更加完善的功能,请联系我的微信付费开发,也希望您能对我进行捐助.", "提示");
            }
        }

        private void btnCatelog_Click(object sender, EventArgs e)
        {
            if (!Beep(440, 250))
            {
                // If the call the beep fails (if the computer has no sound card
                // for example) display a warning dialog in its place.
                MessageBox.Show("Alert.");
            }
            int iDirectPath = 0;
            string sDirectPath = currentPath + "\\@归档" + iDirectPath;

            string OrignFile, NewFile;
            OrignFile=NewFile=null;
            for (int i = 0; i < libFiles.Items.Count; i++)
            {
                if (i % nudScales.Value == 0 && currentPath != null)
                {
                    sDirectPath = currentPath + "\\@归档" + iDirectPath + "\\";
                    if (File.Exists(sDirectPath) == false && Directory.Exists(sDirectPath) == false)
                    {
                        Directory.CreateDirectory(sDirectPath);
                    }
                    iDirectPath++;
                }
                OrignFile = currentPath +"\\"+ libFiles.Items[i];
                NewFile = sDirectPath + libFiles.Items[i];
                File.Move(OrignFile, NewFile);
            }
        }

        #endregion

        #region page4 帮助

        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cnblogs.com/Chary/");
        }
    }
}
