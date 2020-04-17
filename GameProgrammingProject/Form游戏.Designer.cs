namespace GameProgrammingProject
{
    partial class Form游戏
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label关卡 = new System.Windows.Forms.Label();
            this.label难度 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label整体得分 = new System.Windows.Forms.Label();
            this.label整体得分值 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label关卡
            // 
            this.label关卡.AutoSize = true;
            this.label关卡.Location = new System.Drawing.Point(12, 9);
            this.label关卡.Name = "label关卡";
            this.label关卡.Size = new System.Drawing.Size(45, 15);
            this.label关卡.TabIndex = 0;
            this.label关卡.Text = "关卡:";
            // 
            // label难度
            // 
            this.label难度.AutoSize = true;
            this.label难度.Location = new System.Drawing.Point(130, 9);
            this.label难度.Name = "label难度";
            this.label难度.Size = new System.Drawing.Size(45, 15);
            this.label难度.TabIndex = 1;
            this.label难度.Text = "难度:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label整体得分
            // 
            this.label整体得分.AutoSize = true;
            this.label整体得分.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label整体得分.Location = new System.Drawing.Point(9, 35);
            this.label整体得分.Name = "label整体得分";
            this.label整体得分.Size = new System.Drawing.Size(110, 31);
            this.label整体得分.TabIndex = 2;
            this.label整体得分.Text = "整体得分";
            // 
            // label整体得分值
            // 
            this.label整体得分值.AutoSize = true;
            this.label整体得分值.Font = new System.Drawing.Font("华文琥珀", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label整体得分值.Location = new System.Drawing.Point(125, 35);
            this.label整体得分值.Name = "label整体得分值";
            this.label整体得分值.Size = new System.Drawing.Size(41, 41);
            this.label整体得分值.TabIndex = 3;
            this.label整体得分值.Text = "0";
            // 
            // Form游戏
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label整体得分值);
            this.Controls.Add(this.label整体得分);
            this.Controls.Add(this.label难度);
            this.Controls.Add(this.label关卡);
            this.MaximizeBox = false;
            this.Name = "Form游戏";
            this.Text = "游戏窗口";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form游戏_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form游戏_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form游戏_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form游戏_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label关卡;
        private System.Windows.Forms.Label label难度;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label整体得分;
        private System.Windows.Forms.Label label整体得分值;
    }
}