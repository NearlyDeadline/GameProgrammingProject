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
    public partial class Form游戏 : Form
    {
        public static int 时间间隔 = 100;//控制拖动生成图片的时间间隔，单位为毫秒
        public static int 关卡 = 0;//记录玩家的选择的关卡
        public Form游戏()
        {
            时间间隔 = Form初始.时间间隔;
            关卡 = Form初始.关卡;
            InitializeComponent();
            label关卡.Text = "关卡：" + 关卡;
            label难度.Text = "难度：" + 时间间隔;
        }
    }
}
