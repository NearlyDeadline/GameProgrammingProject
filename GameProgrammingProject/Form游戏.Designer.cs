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
            this.label关卡 = new System.Windows.Forms.Label();
            this.label难度 = new System.Windows.Forms.Label();
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
            // Form游戏
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.label难度);
            this.Controls.Add(this.label关卡);
            this.MaximizeBox = false;
            this.Name = "Form游戏";
            this.Text = "游戏窗口";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label关卡;
        private System.Windows.Forms.Label label难度;
    }
}