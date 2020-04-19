using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.InteropServices;

namespace GameProgrammingProject
{
    public partial class Form游戏 : Form
    {
        private static int 时间间隔 = 500;//控制拖动生成图片的时间间隔，单位为毫秒
        private static int 当前关卡序号 = 0;//记录玩家的选择的关卡
        private static int 关卡数 = 0;
        private static String 当前难度 = "";

        private bool 初始化完成 = false;//初始化未完成时，点击、拖动鼠标无效果
        private bool 已按下鼠标按钮 = false;//初始化完成后，按下鼠标按钮时，开始绘制结果图片
        private Stage 当前关卡;
        private int 计数次数 = 0;
        [DllImport("winmm")]
        public static extern bool PlaySound(string szSound, int hMod, int i);

        public Form游戏(int 被选择关卡, int 关卡数, String 难度)
        {
            初始化完成 = false;
            时间间隔 = Form游戏.查询时间间隔(难度);
            当前关卡序号 = 被选择关卡;
            Form游戏.关卡数 = 关卡数;
            当前难度 = 难度;
            InitializeComponent();
            关卡初始化();
            初始化完成 = true;
            label整体得分值.Text = "0";
        }
        private void 关卡初始化()
        {
            label关卡.Text = "关卡：" + 当前关卡序号;
            label难度.Text = "难度：" + 当前难度;
            当前关卡 = new Stage();
            /* TODO:
             * 1.设置并显示当前关卡.BackgroundImage作为关卡背景图像
             * 2.设置播放当前关卡.BackgroundMusic作为关卡背景音乐
             * 以上两步补在该函数开始位置
             */


            XmlDocument stageXml = new XmlDocument();
            stageXml.Load("stages.xml");
            XmlElement stageElement = stageXml.DocumentElement;
            string StrTarget = string.Format("/stages/stage[@index=\"{0}\"]", 当前关卡序号.ToString());
            XmlNode stageSelected = stageElement.SelectSingleNode(StrTarget);//选取index对应的关卡           
            XmlNodeList cards = stageSelected.ChildNodes;
            Card card = null;
            XmlElement cardXml = null;
            XmlNodeList xys = null;//使用ChildNodes属性获取单个Card的x坐标和y坐标，默认Item(0)为x坐标，Item(1)为y坐标
            foreach(XmlNode eachCard in cards)
            {
                card = new Card();
                cardXml = (XmlElement)eachCard;
                //卡片索引可通过下述代码获得，留作备用
                //int 卡片索引 = Convert.ToInt32(cardXml.GetAttribute("index").ToString());
                xys = cardXml.ChildNodes;
                card.X = Convert.ToInt32(xys.Item(0).InnerText);
                card.Y = Convert.ToInt32(xys.Item(1).InnerText);
                当前关卡.答案图片.Add(card);
            }
            计数次数 = 当前关卡.答案图片.Count - 1;//最开始按左键生成一张，计数次数减1
            单次得分上限 = 100.0 / 当前关卡.答案图片.Count;
        }

        private static int 查询时间间隔(String 难度)//根据难度控制生成图片的时间间隔，单位为毫秒
        {
            switch (难度)
            {
                case "简单": return 1000;
                case "普通": return 500;
                case "困难": return 100;
                default: return 500;
            }
        }

        private void Form游戏_FormClosing(object sender, FormClosingEventArgs e)//保存游戏进度和难度
        {
            XmlDocument recordXml = new XmlDocument();
            recordXml.Load("settings.xml");
            XmlElement xe = recordXml.DocumentElement;
            string xpath = "/record";
            XmlElement selectedXe = (XmlElement)xe.SelectSingleNode(xpath);
            selectedXe.GetElementsByTagName("stage").Item(0).InnerText = (当前关卡序号 - 1).ToString();
            selectedXe.GetElementsByTagName("difficulty").Item(0).InnerText = 当前难度;
            recordXml.Save("settings.xml");
        }

        private void timer_Tick(object sender, EventArgs e)//计时器
        {
            if (计数次数 > 0)
            {
                绘制结果图片(PointToClient(Cursor.Position).X, PointToClient(Cursor.Position).Y);
                计数次数--;
            }

        }

        private readonly String 得分资源文件夹路径 = ".\\Resources\\Score\\";
        private double 单次得分上限;
        /*
         * 总体得分算法： 
         * 用100去除以卡牌数，得到单次得分上限
         * 根据每次的评价，获得一个比例系数（0~1），用这个比例系数乘以得分上限，即为单次得分
         * 总体得分即为单次得分之和
         * 提前结束游戏，之后的单次得分均为0
         */

        private void 得分(Card answer, Card result, int x, int y)
        /*
         * 参数：answer为给定的一张答案图片，result为玩家现场绘制一张的结果图片，x和y为鼠标位置
         * 过程：1.计算单次的得分，根据得分显示Perfect/Excellent/Miss等提示字样，播放相应音效
         *       2.更新整体得分
         * 返回值：无
         */
        {
            double 宽度偏离度 = Convert.ToDouble(Math.Abs(answer.X - result.X)) / 当前关卡.卡牌图案.Width;
            double 高度偏离度 = Convert.ToDouble(Math.Abs(answer.Y - result.Y)) / 当前关卡.卡牌图案.Height;
            Image 待绘制特效;
            double 单次得分比例;
            string 待播放音效;
            if (宽度偏离度 <= Object.Score.perfect最大偏离度 && 高度偏离度 <= Object.Score.perfect最大偏离度)
            {//perfect
                待绘制特效 = Image.FromFile(得分资源文件夹路径 + "perfect.png");
                待播放音效 = 得分资源文件夹路径 + "perfect.wav";
                单次得分比例 = 1;
            }
            else if (宽度偏离度 <= Object.Score.amazing最大偏离度 && 高度偏离度 <= Object.Score.amazing最大偏离度)
            {//amazing
                待绘制特效 = Image.FromFile(得分资源文件夹路径 + "amazing.png");
                待播放音效 = 得分资源文件夹路径 + "amazing.wav";
                单次得分比例 = 1 - (宽度偏离度 + 高度偏离度) / 2;
            }
            else if (宽度偏离度 <= Object.Score.excellent最大偏离度 && 高度偏离度 <= Object.Score.excellent最大偏离度)
            {//excellent
                待绘制特效 = Image.FromFile(得分资源文件夹路径 + "excellent.png");
                待播放音效 = 得分资源文件夹路径 + "excellent.wav";
                单次得分比例 = 1 - (宽度偏离度 + 高度偏离度) / 2;
            }
            else// miss
            {
                待绘制特效 = Image.FromFile(得分资源文件夹路径 + "miss.png");
                待播放音效 = 得分资源文件夹路径 + "miss.wav";
                单次得分比例 = 0;
            }
            PlaySound(待播放音效, 0, 1);
            Graphics g = this.CreateGraphics();
            g.DrawImage(待绘制特效, x, y);
            更新整体分数(单次得分比例 * 单次得分上限);
        }

        private Point 计算左上角(int x, int y)
        /*
         * 参数：鼠标位置的x,y坐标
         * 过程：1.默认绘制点是鼠标位置的左上角，这个方法传入中心坐标，计算左上角坐标
         * 返回值：中心坐标点
         */
        {
            return new Point(x - 当前关卡.卡牌图案.Width / 2, y - 当前关卡.卡牌图案.Height / 2);
        }

        private void 绘制结果图片(int x, int y)
        /*
         * 参数：鼠标位置的x,y坐标
         * 过程：1.以参数为中心，绘制一张result结果图片
         *       2.新建一个Card实例，XY坐标即为传进来的参数
         *       3.将该实例加入当前关卡.Results结果图片数组
         *       4.调用GetScore方法，answer为当前关卡.Answers答案图片数组里，序号相同的图片，
         *         result为第二步新建的Card，保存方法的返回值，用于计算整体分数
         * 返回值：无
         */
        {
            Graphics g = this.CreateGraphics();
            Point 左上角 = 计算左上角(x, y);
            g.DrawImage(当前关卡.卡牌图案, 左上角);
            //TODO: 把加入数组的代码用另一个线程接管
            Card result = new Card();
            result.X = 左上角.X;
            result.Y = 左上角.Y;
            当前关卡.结果图片.Add(result);
            //TODO: 把得分函数用另一个线程接管
            得分(当前关卡.答案图片.ElementAt(当前关卡.结果图片.Count - 1), result, x, y);
        }

        private void 更新整体分数(double 单次得分)
        {
            label整体得分值.Text = Convert.ToInt32((Convert.ToInt32(label整体得分值.Text) + 单次得分)).ToString();
        }

        private void Form游戏_MouseDown(object sender, MouseEventArgs e)
        {
            if (初始化完成)
            {
                绘制结果图片(e.X, e.Y);
                已按下鼠标按钮 = true;
                timer.Interval = 时间间隔;
                timer.Enabled = true;
            }
        }

        private void Form游戏_MouseUp(object sender, MouseEventArgs e)
        {
            if (计数次数 > 0)
            {
                timer.Enabled = false;
                label整体得分值.Text = Convert.ToInt32((Convert.ToDouble(label整体得分值.Text) / 计数次数)).ToString();
            }
            if (初始化完成 && 已按下鼠标按钮)
            {
                已按下鼠标按钮 = false;
                初始化完成 = false;
                if (MessageBox.Show("您的成绩为：" + label整体得分值.Text + "，是否进入下一关？"
                    , "恭喜完成关卡", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //进入下一关卡
                    if (当前关卡序号 == 关卡数)//通关，退出程序
                    {
                        MessageBox.Show("恭喜完成" + 当前难度 + "难度下所有关卡", "", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        当前关卡序号 = 1;
                        this.Close();
                    }
                    else
                    {
                        当前关卡序号++;
                    }
                }
                //else: 重新开始本关卡
                label整体得分值.Text = "0";
                timer.Enabled = false;
                关卡初始化();
                this.Refresh();
                初始化完成 = true;
            }
        }

        private void Form游戏_Paint(object sender, PaintEventArgs e)
        {
            foreach (Card card in 当前关卡.答案图片)//答案图片用黑白
            {
                e.Graphics.DrawImage(当前关卡.卡牌图案黑白, card.X, card.Y);
            }
        }
    }
}
