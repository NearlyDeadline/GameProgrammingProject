using System;
using System.Windows.Forms;
using System.Xml;
using System.Threading;

namespace GameProgrammingProject
{
    public partial class Form初始 : Form
    {
        public Form初始()
        {
            InitializeComponent();
            XmlDocument recordXml = new XmlDocument();
            recordXml.Load("settings.xml");
            XmlNode xn = recordXml.SelectSingleNode("record");
            XmlNodeList xnl = xn.ChildNodes;
            int 关卡索引 = Convert.ToInt32(xnl.Item(0).InnerText);
            初始化_listBox关卡(关卡索引);
            String 难度 = xnl.Item(1).InnerText;
            初始化_radioButton难度(难度);
            BackgroundMusic = Application.StartupPath + "\\Resources\\" + "toby+fox+-+UNDERTALE+Soundtrack+-+14+Heartache.mp3";
            this.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "\\Resources\\" + "Mainmenu.jpg");
            PlayBGM();
            label游戏说明.Text = "欢迎体验简陋的游戏。\n请从给定的轨迹中推算起点和终点，在起点处按下鼠标左键，" +
                "按照一定的速度依次经过各个图片，最终到达终点。每隔一段时间（取决于难度）会自动在你的鼠标处绘制一张残影。";
        }
        private String BackgroundMusic { get; set; }//背景音乐

        private static String 当前难度 = "";
        private static int 被选择关卡 = 0;//记录玩家的选择的关卡
        private static int 关卡数量 = 0;
        
        private void 初始化_listBox关卡(int 关卡索引)//默认选择上次退出游戏时的难度，若为初次进入游戏则选择第0项
        {
            XmlDocument stageXml = new XmlDocument();
            stageXml.Load("stages.xml");
            XmlNode xn = stageXml.SelectSingleNode("stages");
            XmlNodeList xnl = xn.ChildNodes;
            关卡数量 = Convert.ToInt32(xnl.Item(0).InnerText);
            for(int i = 1; i<= 关卡数量; ++i)
            {
                listBox关卡.Items.Add(i.ToString());
            }
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

        private void PlayBGM()          //循环播放背景音乐
        {
            this.axWindowsMediaPlayer初始.URL = BackgroundMusic;
            axWindowsMediaPlayer初始.settings.autoStart = true;
            axWindowsMediaPlayer初始.settings.setMode("loop", true);
            axWindowsMediaPlayer初始.Ctlcontrols.play();
        }

        public static void ThreadProc()             //创建游戏窗口函数
        {
            Application.Run(new Form游戏(被选择关卡, 关卡数量, 当前难度));
        }

        private void 开始游戏按钮_Click(object sender, EventArgs e)       //新建线程保证主窗口结束后程序不关闭
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.SetApartmentState(ApartmentState.STA);

            t.Start();
            this.Close();
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

        private void button开发人员_Click(object sender, EventArgs e)
        {
            MessageBox.Show("成员：黄正坤、孙博文、李一鸣", "小组成员", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
