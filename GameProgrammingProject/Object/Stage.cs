using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace GameProgrammingProject
{
    public class Stage
    {
        public Stage()
        {
            答案图片 = new List<Card>();
            结果图片 = new List<Card>();
            DirectoryInfo imageFolder = new DirectoryInfo(卡牌图案文件夹路径);
            FileInfo[] imageFiles = imageFolder.GetFiles();
            图案数量 = imageFiles.Length;
            选取随机图案(imageFiles);
            生成黑白答案图片();
        }

        private void 选取随机图案(FileInfo[] imageFiles)
        {
            int index = new Random().Next(0, 图案数量 - 1);
            卡牌图案 = Image.FromFile(卡牌图案文件夹路径 + imageFiles[index].Name);
        }

        private void 生成黑白答案图片()
        {
            Bitmap temp = new Bitmap(卡牌图案);
            int width = temp.Width;
            int height = temp.Height;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color color = temp.GetPixel(x, y);
                    int value = (color.R + color.G + color.B) / 3;
                    temp.SetPixel(x, y, Color.FromArgb(value, value, value));
                }
            }
            卡牌图案黑白 = Image.FromHbitmap(temp.GetHbitmap());
        }
        private readonly int 图案数量;
        private readonly String 卡牌图案文件夹路径 = ".\\Resources\\Card\\";
        public Image 卡牌图案 { get; set; }//彩色的图案，用于绘制result结果图片

        public Image 卡牌图案黑白 { get; set; }//黑白的图案，用于绘制answer答案图片
        public List<Card> 答案图片 { get; set; }//答案图片

        public List<Card> 结果图片 { get; set; }//结果图片
        
    }
}
