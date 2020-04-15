using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProgrammingProject
{
    public partial class Form初始 : Form
    {
        public Form初始()
        {
            InitializeComponent();
            初始化_listBox关卡();
            初始化_radioButton难度();
        }

        public static int 时间间隔 = 500;//控制拖动生成图片的时间间隔，单位为毫秒
        private bool 游戏已开始 = false;//控制无法多开游戏窗口

        private void 初始化_listBox关卡()//默认选择上次退出游戏时的难度，若为初次进入游戏则选择第0项
        {

        }
        
        private void 初始化_radioButton难度()//默认选择上次退出游戏时的难度，若为初次进入游戏则选择普通难度
        {

        }

        private void 开始游戏按钮_Click(object sender, EventArgs e)
        {
            if (!游戏已开始)
            {
                Form游戏 游戏窗口 = new Form游戏();
                游戏已开始 = true;
                游戏窗口.Show();
            }
            else
            {
                MessageBox.Show("游戏已开启，请勿多开窗口", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 困难难度选项_CheckedChanged(object sender, EventArgs e)
        {
            时间间隔 = 100;
        }

        private void 普通难度选项_CheckedChanged(object sender, EventArgs e)
        {
            时间间隔 = 500;
        }

        private void 简单难度选项_CheckedChanged(object sender, EventArgs e)
        {
            时间间隔 = 1000;
        }

        private void listBox关卡_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
