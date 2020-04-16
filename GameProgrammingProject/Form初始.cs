using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GameProgrammingProject
{
    public partial class Form初始 : Form
    {
        public Form初始()
        {
            InitializeComponent();
            XmlDocument record = new XmlDocument();
            record.Load("settings.xml");
            XmlNode xn = record.SelectSingleNode("record");
            XmlNodeList xnl = xn.ChildNodes;
            int 关卡索引 = Convert.ToInt32(xnl.Item(0).InnerText);
            初始化_listBox关卡(关卡索引);
            String 难度 = xnl.Item(1).InnerText;
            初始化_radioButton难度(难度);
        }

        public static String 当前难度 = "";
        public static bool 游戏窗口已开启 = false;//控制无法多开游戏窗口
        public static int 被选择关卡 = 0;//记录玩家的选择的关卡
        
        private void 初始化_listBox关卡(int 关卡索引)//默认选择上次退出游戏时的难度，若为初次进入游戏则选择第0项
        {
            //TODO: 为了获取一共有多少关卡，需要读取stages.xml文件以获取关卡总数
            listBox关卡.Items.Add("1");
            listBox关卡.Items.Add("2");
            listBox关卡.Items.Add("3");
            listBox关卡.SelectedIndex = 关卡索引;
        }
        
        private void 初始化_radioButton难度(String 难度)//默认选择上次退出游戏时的难度，若为初次进入游戏则选择普通难度
        {
            switch (难度)
            {
                case "简单": { this.radioButton简单难度.Checked = true;  break; }
                case "普通": { this.radioButton普通难度.Checked = true; break; }
                case "困难": { this.radioButton困难难度.Checked = true; break; }
                default: { this.radioButton普通难度.Checked = true; break; }
            }

        }

        private void 开始游戏按钮_Click(object sender, EventArgs e)
        {
            if (!游戏窗口已开启)
            {
                Form游戏 游戏窗口 = new Form游戏();
                游戏窗口已开启 = true;
                游戏窗口.Show();
            }
            else
            {
                MessageBox.Show("游戏已开启，请勿多开窗口", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 困难难度选项_CheckedChanged(object sender, EventArgs e)
        {
            当前难度 = "困难";
        }

        private void 普通难度选项_CheckedChanged(object sender, EventArgs e)
        {
            当前难度 = "普通";
        }

        private void 简单难度选项_CheckedChanged(object sender, EventArgs e)
        {
            当前难度 = "简单";
        }

        private void listBox关卡_SelectedIndexChanged(object sender, EventArgs e)
        {
            被选择关卡 = listBox关卡.SelectedIndex + 1;//为了不从0显示 +1 了
        }
    }
}
