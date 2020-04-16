using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameProgrammingProject
{
    public class Stage
    {
        public Image BackgroundImage { get; set; }//背景图案

        public String BackgroundMusic { get; set; }//背景音乐

        public Image CardPattern { get; set; }//卡牌图案

        public List<Card> Answers { get; set; }//答案图片

        public List<Card> Results { get; set; }//结果图片
        
    }
}
