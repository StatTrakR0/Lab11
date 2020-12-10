namespace Lab11
{
    partial class fMain
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
            this.pnTools = new System.Windows.Forms.Panel();
            this.btnRightFar = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnLeftFar = new System.Windows.Forms.Button();
            this.btnDownFar = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnUpFar = new System.Windows.Forms.Button();
            this.cbEmblems = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnCreateNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTools
            // 
            this.pnTools.Controls.Add(this.btnRightFar);
            this.pnTools.Controls.Add(this.btnRight);
            this.pnTools.Controls.Add(this.btnLeft);
            this.pnTools.Controls.Add(this.btnLeftFar);
            this.pnTools.Controls.Add(this.btnDownFar);
            this.pnTools.Controls.Add(this.btnDown);
            this.pnTools.Controls.Add(this.btnCollapse);
            this.pnTools.Controls.Add(this.btnExpand);
            this.pnTools.Controls.Add(this.btnUp);
            this.pnTools.Controls.Add(this.btnUpFar);
            this.pnTools.Controls.Add(this.cbEmblems);
            this.pnTools.Controls.Add(this.btnShow);
            this.pnTools.Controls.Add(this.btnHide);
            this.pnTools.Controls.Add(this.btnCreateNew);
            this.pnTools.Controls.Add(this.label1);
            this.pnTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTools.Location = new System.Drawing.Point(465, 0);
            this.pnTools.Name = "pnTools";
            this.pnTools.Size = new System.Drawing.Size(229, 442);
            this.pnTools.TabIndex = 0;
            // 
            // btnRightFar
            // 
            this.btnRightFar.Location = new System.Drawing.Point(182, 275);
            this.btnRightFar.Name = "btnRightFar";
            this.btnRightFar.Size = new System.Drawing.Size(31, 52);
            this.btnRightFar.TabIndex = 14;
            this.btnRightFar.Text = ">>";
            this.btnRightFar.UseVisualStyleBackColor = true;
            this.btnRightFar.Click += new System.EventHandler(this.BtnRightFar_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(153, 275);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(23, 52);
            this.btnRight.TabIndex = 13;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(43, 275);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(23, 52);
            this.btnLeft.TabIndex = 12;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // btnLeftFar
            // 
            this.btnLeftFar.Location = new System.Drawing.Point(6, 275);
            this.btnLeftFar.Name = "btnLeftFar";
            this.btnLeftFar.Size = new System.Drawing.Size(31, 52);
            this.btnLeftFar.TabIndex = 11;
            this.btnLeftFar.Text = "<<";
            this.btnLeftFar.UseVisualStyleBackColor = true;
            this.btnLeftFar.Click += new System.EventHandler(this.BtnLeftFar_Click);
            // 
            // btnDownFar
            // 
            this.btnDownFar.Location = new System.Drawing.Point(72, 362);
            this.btnDownFar.Name = "btnDownFar";
            this.btnDownFar.Size = new System.Drawing.Size(75, 23);
            this.btnDownFar.TabIndex = 10;
            this.btnDownFar.Text = "vvv";
            this.btnDownFar.UseVisualStyleBackColor = true;
            this.btnDownFar.Click += new System.EventHandler(this.BtnDownFar_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(72, 333);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 9;
            this.btnDown.Text = "v";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCollapse.Location = new System.Drawing.Point(72, 304);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(75, 23);
            this.btnCollapse.TabIndex = 8;
            this.btnCollapse.Text = "—";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.BtnCollapse_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExpand.Location = new System.Drawing.Point(72, 275);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(75, 23);
            this.btnExpand.TabIndex = 7;
            this.btnExpand.Text = "+";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.BtnExpand_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUp.Location = new System.Drawing.Point(72, 246);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // btnUpFar
            // 
            this.btnUpFar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpFar.Location = new System.Drawing.Point(72, 217);
            this.btnUpFar.Name = "btnUpFar";
            this.btnUpFar.Size = new System.Drawing.Size(75, 23);
            this.btnUpFar.TabIndex = 5;
            this.btnUpFar.Text = "^^^";
            this.btnUpFar.UseVisualStyleBackColor = true;
            this.btnUpFar.Click += new System.EventHandler(this.BtnUpFar_Click);
            // 
            // cbEmblems
            // 
            this.cbEmblems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmblems.FormattingEnabled = true;
            this.cbEmblems.Location = new System.Drawing.Point(21, 55);
            this.cbEmblems.Name = "cbEmblems";
            this.cbEmblems.Size = new System.Drawing.Size(176, 21);
            this.cbEmblems.TabIndex = 4;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(21, 172);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(176, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Показати об\'єкт";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(21, 143);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(176, 23);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "Приховати об\'єкт";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.BtnHide_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.Location = new System.Drawing.Point(21, 114);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(176, 23);
            this.btnCreateNew.TabIndex = 1;
            this.btnCreateNew.Text = "Створити новий об\'єкт";
            this.btnCreateNew.UseVisualStyleBackColor = true;
            this.btnCreateNew.Click += new System.EventHandler(this.BtnCreateNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перелік об\'єктів";
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(459, 442);
            this.pnMain.TabIndex = 1;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 442);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnTools);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №11";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.pnTools.ResumeLayout(false);
            this.pnTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTools;
        private System.Windows.Forms.Button btnRightFar;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnLeftFar;
        private System.Windows.Forms.Button btnDownFar;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnUpFar;
        private System.Windows.Forms.ComboBox cbEmblems;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnMain;
    }
}

