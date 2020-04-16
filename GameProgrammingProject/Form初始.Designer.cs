namespace GameProgrammingProject
{
    partial class Form初始
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button开始游戏 = new System.Windows.Forms.Button();
            this.button开发人员 = new System.Windows.Forms.Button();
            this.label选择难度 = new System.Windows.Forms.Label();
            this.radioButton简单难度 = new System.Windows.Forms.RadioButton();
            this.radioButton普通难度 = new System.Windows.Forms.RadioButton();
            this.radioButton困难难度 = new System.Windows.Forms.RadioButton();
            this.label选择关卡 = new System.Windows.Forms.Label();
            this.listBox关卡 = new System.Windows.Forms.ListBox();
            this.label游戏名称 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button开始游戏
            // 
            this.button开始游戏.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button开始游戏.Location = new System.Drawing.Point(516, 441);
            this.button开始游戏.Name = "button开始游戏";
            this.button开始游戏.Size = new System.Drawing.Size(225, 101);
            this.button开始游戏.TabIndex = 0;
            this.button开始游戏.Text = "开始游戏";
            this.button开始游戏.UseVisualStyleBackColor = true;
            this.button开始游戏.Click += new System.EventHandler(this.开始游戏按钮_Click);
            // 
            // button开发人员
            // 
            this.button开发人员.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button开发人员.Location = new System.Drawing.Point(1060, 584);
            this.button开发人员.Name = "button开发人员";
            this.button开发人员.Size = new System.Drawing.Size(173, 58);
            this.button开发人员.TabIndex = 1;
            this.button开发人员.Text = "开发人员";
            this.button开发人员.UseVisualStyleBackColor = true;
            // 
            // label选择难度
            // 
            this.label选择难度.AutoSize = true;
            this.label选择难度.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label选择难度.Location = new System.Drawing.Point(1005, 298);
            this.label选择难度.Name = "label选择难度";
            this.label选择难度.Size = new System.Drawing.Size(106, 24);
            this.label选择难度.TabIndex = 2;
            this.label选择难度.Text = "选择难度";
            // 
            // radioButton简单难度
            // 
            this.radioButton简单难度.AutoSize = true;
            this.radioButton简单难度.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton简单难度.Location = new System.Drawing.Point(1009, 380);
            this.radioButton简单难度.Name = "radioButton简单难度";
            this.radioButton简单难度.Size = new System.Drawing.Size(70, 23);
            this.radioButton简单难度.TabIndex = 3;
            this.radioButton简单难度.Text = "简单";
            this.radioButton简单难度.UseVisualStyleBackColor = true;
            this.radioButton简单难度.CheckedChanged += new System.EventHandler(this.简单难度选项_CheckedChanged);
            // 
            // radioButton普通难度
            // 
            this.radioButton普通难度.AutoSize = true;
            this.radioButton普通难度.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton普通难度.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton普通难度.Location = new System.Drawing.Point(1009, 409);
            this.radioButton普通难度.Name = "radioButton普通难度";
            this.radioButton普通难度.Size = new System.Drawing.Size(70, 23);
            this.radioButton普通难度.TabIndex = 4;
            this.radioButton普通难度.Text = "普通";
            this.radioButton普通难度.UseVisualStyleBackColor = true;
            this.radioButton普通难度.CheckedChanged += new System.EventHandler(this.普通难度选项_CheckedChanged);
            // 
            // radioButton困难难度
            // 
            this.radioButton困难难度.AutoSize = true;
            this.radioButton困难难度.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton困难难度.Location = new System.Drawing.Point(1009, 438);
            this.radioButton困难难度.Name = "radioButton困难难度";
            this.radioButton困难难度.Size = new System.Drawing.Size(70, 23);
            this.radioButton困难难度.TabIndex = 5;
            this.radioButton困难难度.Text = "困难";
            this.radioButton困难难度.UseVisualStyleBackColor = true;
            this.radioButton困难难度.CheckedChanged += new System.EventHandler(this.困难难度选项_CheckedChanged);
            // 
            // label选择关卡
            // 
            this.label选择关卡.AutoSize = true;
            this.label选择关卡.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label选择关卡.Location = new System.Drawing.Point(824, 298);
            this.label选择关卡.Name = "label选择关卡";
            this.label选择关卡.Size = new System.Drawing.Size(106, 24);
            this.label选择关卡.TabIndex = 6;
            this.label选择关卡.Text = "选择关卡";
            // 
            // listBox关卡
            // 
            this.listBox关卡.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox关卡.FormattingEnabled = true;
            this.listBox关卡.ItemHeight = 18;
            this.listBox关卡.Location = new System.Drawing.Point(828, 340);
            this.listBox关卡.Name = "listBox关卡";
            this.listBox关卡.Size = new System.Drawing.Size(104, 184);
            this.listBox关卡.TabIndex = 7;
            this.listBox关卡.SelectedIndexChanged += new System.EventHandler(this.listBox关卡_SelectedIndexChanged);
            // 
            // label游戏名称
            // 
            this.label游戏名称.AutoSize = true;
            this.label游戏名称.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label游戏名称.Location = new System.Drawing.Point(503, 66);
            this.label游戏名称.Name = "label游戏名称";
            this.label游戏名称.Size = new System.Drawing.Size(273, 78);
            this.label游戏名称.TabIndex = 8;
            this.label游戏名称.Text = "游戏名称";
            // 
            // Form初始
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label游戏名称);
            this.Controls.Add(this.listBox关卡);
            this.Controls.Add(this.label选择关卡);
            this.Controls.Add(this.radioButton困难难度);
            this.Controls.Add(this.radioButton普通难度);
            this.Controls.Add(this.radioButton简单难度);
            this.Controls.Add(this.label选择难度);
            this.Controls.Add(this.button开发人员);
            this.Controls.Add(this.button开始游戏);
            this.MaximizeBox = false;
            this.Name = "Form初始";
            this.Text = "初始窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button开始游戏;
        private System.Windows.Forms.Button button开发人员;
        private System.Windows.Forms.Label label选择难度;
        private System.Windows.Forms.RadioButton radioButton简单难度;
        private System.Windows.Forms.RadioButton radioButton普通难度;
        private System.Windows.Forms.RadioButton radioButton困难难度;
        private System.Windows.Forms.Label label选择关卡;
        private System.Windows.Forms.ListBox listBox关卡;
        private System.Windows.Forms.Label label游戏名称;
    }
}

