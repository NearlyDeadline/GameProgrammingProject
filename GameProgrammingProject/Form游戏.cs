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
    public partial class Form游戏 : Form
    {
        private static int 时间间隔 = 500;//控制拖动生成图片的时间间隔，单位为毫秒
        private static int 当前关卡序号 = 0;//记录玩家的选择的关卡

        private bool 初始化完成 = false;//初始化未完成时，点击、拖动鼠标无效果
        private bool 已按下鼠标按钮 = false;//初始化完成后，按下鼠标按钮时，开始绘制结果图片
        private Stage 当前关卡;
        private int 计数次数 = 0;
        public Form游戏()
        {
            初始化完成 = false;
            时间间隔 = Form游戏.查询时间间隔(Form初始.当前难度);
            当前关卡序号 = Form初始.被选择关卡;
            InitializeComponent();
            label关卡.Text = "关卡：" + 当前关卡序号;
            label难度.Text = "难度：" + Form初始.当前难度;
            关卡初始化();

            初始化完成 = true;

            //TODO: 提示玩家可以开始游戏

        }
        private void 关卡初始化()
        {
            //当前关卡 = new Stage();
            /* TODO:
             * 1.设置当前关卡.BackBackgroundImage，BackgroundMusic，CardPattern变量
             * 2.显示背景图片，播放背景音乐
             * 3.根据当前关卡序号，到stages.xml中读取所有卡牌的中心坐标，创建相应的Card实例，将其加入当前关卡.Answers，绘制图案
             */
            //计数次数 = 当前关卡.Answers.Count - 1;//最开始按左键生成一张，计数次数减1
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
            XmlDocument record = new XmlDocument();
            record.Load("settings.xml");
            XmlElement xe = record.DocumentElement;
            string xpath = "/record";
            XmlElement selectedXe = (XmlElement)xe.SelectSingleNode(xpath);
            selectedXe.GetElementsByTagName("stage").Item(0).InnerText = (当前关卡序号 - 1).ToString();
            selectedXe.GetElementsByTagName("difficulty").Item(0).InnerText = Form初始.当前难度;
            record.Save("settings.xml");
        }

        private void timer_Tick(object sender, EventArgs e)//计时器
        {

            DrawResult(Cursor.Position.X, Cursor.Position.Y);
        }

        private double GetScore(Card answer, Card result)
        /*
         * 参数：answer为给定的一张答案图片，result为玩家现场绘制一张的结果图片
         * 过程：计算单次的得分，根据得分显示Perfect/Excellent/Miss等提示字样，播放相应音效
         * 返回值：单次的得分，用于后续计算整体分数
         */
        {
            return 0;
        }

        private void DrawResult(int x, int y)
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

        }

        private void Form游戏_MouseDown(object sender, MouseEventArgs e)
        {
            if (初始化完成)
            {
                DrawResult(e.X, e.Y);
                已按下鼠标按钮 = true;
                timer.Interval = 时间间隔;
                timer.Enabled = true;
            }
        }

        private void Form游戏_MouseMove(object sender, MouseEventArgs e)
        {
            //似乎没用，通过Cursor可以得到鼠标的坐标，直接把代码移到Timer_tick方法里就行
        }

        private void Form游戏_MouseUp(object sender, MouseEventArgs e)
        {
            if (初始化完成 && 已按下鼠标按钮)
            {
                已按下鼠标按钮 = false;
                
                //TODO: 1.提示游戏结束，计算总成绩
                //      2.选择再次挑战/下一关/退出
            }
        }
    }
}
