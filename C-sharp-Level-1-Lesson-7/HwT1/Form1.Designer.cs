namespace HwT1
{
    partial class FGame
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FGame));
            this.ButPlus = new System.Windows.Forms.Button();
            this.LabCur = new System.Windows.Forms.Label();
            this.LabAct = new System.Windows.Forms.Label();
            this.ButMulti = new System.Windows.Forms.Button();
            this.ButPrev = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.MenNG = new System.Windows.Forms.ToolStripMenuItem();
            this.MenExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ButClear = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButPlus
            // 
            this.ButPlus.Location = new System.Drawing.Point(95, 35);
            this.ButPlus.Name = "ButPlus";
            this.ButPlus.Size = new System.Drawing.Size(75, 25);
            this.ButPlus.TabIndex = 0;
            this.ButPlus.Text = "+1";
            this.ButPlus.UseVisualStyleBackColor = true;
            this.ButPlus.Click += new System.EventHandler(this.ButPlus_Click);
            // 
            // LabCur
            // 
            this.LabCur.Location = new System.Drawing.Point(70, 35);
            this.LabCur.Name = "LabCur";
            this.LabCur.Size = new System.Drawing.Size(20, 25);
            this.LabCur.TabIndex = 3;
            this.LabCur.Text = "1";
            this.LabCur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabAct
            // 
            this.LabAct.Location = new System.Drawing.Point(70, 70);
            this.LabAct.Name = "LabAct";
            this.LabAct.Size = new System.Drawing.Size(20, 25);
            this.LabAct.TabIndex = 4;
            this.LabAct.Text = "0";
            this.LabAct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButMulti
            // 
            this.ButMulti.Location = new System.Drawing.Point(95, 70);
            this.ButMulti.Name = "ButMulti";
            this.ButMulti.Size = new System.Drawing.Size(75, 25);
            this.ButMulti.TabIndex = 6;
            this.ButMulti.Text = "*2";
            this.ButMulti.UseVisualStyleBackColor = true;
            this.ButMulti.Click += new System.EventHandler(this.ButMulti_Click);
            // 
            // ButPrev
            // 
            this.ButPrev.Location = new System.Drawing.Point(95, 105);
            this.ButPrev.Name = "ButPrev";
            this.ButPrev.Size = new System.Drawing.Size(75, 25);
            this.ButPrev.TabIndex = 7;
            this.ButPrev.Text = "Отменить";
            this.ButPrev.UseVisualStyleBackColor = true;
            this.ButPrev.Click += new System.EventHandler(this.ButPrev_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(174, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenNG,
            this.MenExit});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripDropDownButton1.Text = "Game";
            // 
            // MenNG
            // 
            this.MenNG.Name = "MenNG";
            this.MenNG.Size = new System.Drawing.Size(152, 22);
            this.MenNG.Text = "New game";
            this.MenNG.Click += new System.EventHandler(this.MenNG_Click);
            // 
            // MenExit
            // 
            this.MenExit.Name = "MenExit";
            this.MenExit.Size = new System.Drawing.Size(152, 22);
            this.MenExit.Text = "Exit";
            this.MenExit.Click += new System.EventHandler(this.MenExit_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.howPlayToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(41, 22);
            this.toolStripDropDownButton2.Text = "Info";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.authorToolStripMenuItem.Text = "Author";
            // 
            // howPlayToolStripMenuItem
            // 
            this.howPlayToolStripMenuItem.Name = "howPlayToolStripMenuItem";
            this.howPlayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.howPlayToolStripMenuItem.Text = "How play";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Значение";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Действий";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButClear
            // 
            this.ButClear.Location = new System.Drawing.Point(10, 105);
            this.ButClear.Name = "ButClear";
            this.ButClear.Size = new System.Drawing.Size(75, 25);
            this.ButClear.TabIndex = 11;
            this.ButClear.Text = "Сбросить";
            this.ButClear.UseVisualStyleBackColor = true;
            this.ButClear.Click += new System.EventHandler(this.ButClear_Click);
            // 
            // FGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 136);
            this.ControlBox = false;
            this.Controls.Add(this.ButClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ButPrev);
            this.Controls.Add(this.ButMulti);
            this.Controls.Add(this.LabAct);
            this.Controls.Add(this.LabCur);
            this.Controls.Add(this.ButPlus);
            this.Name = "FGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Набери: ";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButPlus;
        private System.Windows.Forms.Label LabCur;
        private System.Windows.Forms.Label LabAct;
        private System.Windows.Forms.Button ButMulti;
        private System.Windows.Forms.Button ButPrev;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem MenNG;
        private System.Windows.Forms.ToolStripMenuItem MenExit;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howPlayToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ButClear;
    }
}

