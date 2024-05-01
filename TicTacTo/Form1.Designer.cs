namespace TicTacTo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbXO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblXO = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btn3_3 = new System.Windows.Forms.Button();
            this.btn3_2 = new System.Windows.Forms.Button();
            this.btn3_1 = new System.Windows.Forms.Button();
            this.btn2_3 = new System.Windows.Forms.Button();
            this.btn2_2 = new System.Windows.Forms.Button();
            this.btn2_1 = new System.Windows.Forms.Button();
            this.btn1_3 = new System.Windows.Forms.Button();
            this.btn1_2 = new System.Windows.Forms.Button();
            this.btn1_1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(132, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Your Sign";
            // 
            // cbXO
            // 
            this.cbXO.FormattingEnabled = true;
            this.cbXO.Items.AddRange(new object[] {
            "O",
            "X"});
            this.cbXO.Location = new System.Drawing.Point(290, 74);
            this.cbXO.Name = "cbXO";
            this.cbXO.Size = new System.Drawing.Size(121, 28);
            this.cbXO.TabIndex = 1;
            this.cbXO.SelectedIndexChanged += new System.EventHandler(this.cbXO_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(471, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PC Sign";
            // 
            // lblXO
            // 
            this.lblXO.AutoSize = true;
            this.lblXO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblXO.Location = new System.Drawing.Point(563, 74);
            this.lblXO.Name = "lblXO";
            this.lblXO.Size = new System.Drawing.Size(111, 20);
            this.lblXO.TabIndex = 3;
            this.lblXO.Text = "-Not Selected-";
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gamePanel.Controls.Add(this.lbl1);
            this.gamePanel.Controls.Add(this.panel4);
            this.gamePanel.Controls.Add(this.panel3);
            this.gamePanel.Controls.Add(this.panel2);
            this.gamePanel.Controls.Add(this.panel1);
            this.gamePanel.Controls.Add(this.lblPlayer);
            this.gamePanel.Controls.Add(this.btn3_3);
            this.gamePanel.Controls.Add(this.btn3_2);
            this.gamePanel.Controls.Add(this.btn3_1);
            this.gamePanel.Controls.Add(this.btn2_3);
            this.gamePanel.Controls.Add(this.btn2_2);
            this.gamePanel.Controls.Add(this.btn2_1);
            this.gamePanel.Controls.Add(this.btn1_3);
            this.gamePanel.Controls.Add(this.btn1_2);
            this.gamePanel.Controls.Add(this.btn1_1);
            this.gamePanel.Location = new System.Drawing.Point(193, 124);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(326, 314);
            this.gamePanel.TabIndex = 4;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.Lime;
            this.lbl1.Location = new System.Drawing.Point(222, 15);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 20);
            this.lbl1.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Chartreuse;
            this.panel4.Location = new System.Drawing.Point(43, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 3);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Chartreuse;
            this.panel3.Location = new System.Drawing.Point(43, 214);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 3);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Chartreuse;
            this.panel2.Location = new System.Drawing.Point(210, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 240);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.Location = new System.Drawing.Point(122, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 240);
            this.panel1.TabIndex = 5;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.ForeColor = System.Drawing.Color.Lime;
            this.lblPlayer.Location = new System.Drawing.Point(109, 15);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(104, 20);
            this.lblPlayer.TabIndex = 5;
            this.lblPlayer.Text = "YOUR TURN";
            // 
            // btn3_3
            // 
            this.btn3_3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn3_3.Location = new System.Drawing.Point(222, 223);
            this.btn3_3.Name = "btn3_3";
            this.btn3_3.Size = new System.Drawing.Size(45, 45);
            this.btn3_3.TabIndex = 8;
            this.btn3_3.UseVisualStyleBackColor = false;
            this.btn3_3.Click += new System.EventHandler(this.btn3_3_Click);
            // 
            // btn3_2
            // 
            this.btn3_2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn3_2.Location = new System.Drawing.Point(141, 223);
            this.btn3_2.Name = "btn3_2";
            this.btn3_2.Size = new System.Drawing.Size(45, 45);
            this.btn3_2.TabIndex = 7;
            this.btn3_2.UseVisualStyleBackColor = false;
            this.btn3_2.Click += new System.EventHandler(this.btn3_2_Click);
            // 
            // btn3_1
            // 
            this.btn3_1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn3_1.Location = new System.Drawing.Point(65, 223);
            this.btn3_1.Name = "btn3_1";
            this.btn3_1.Size = new System.Drawing.Size(45, 45);
            this.btn3_1.TabIndex = 6;
            this.btn3_1.UseVisualStyleBackColor = false;
            this.btn3_1.Click += new System.EventHandler(this.btn3_1_Click);
            // 
            // btn2_3
            // 
            this.btn2_3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn2_3.Location = new System.Drawing.Point(222, 161);
            this.btn2_3.Name = "btn2_3";
            this.btn2_3.Size = new System.Drawing.Size(45, 45);
            this.btn2_3.TabIndex = 5;
            this.btn2_3.UseVisualStyleBackColor = false;
            this.btn2_3.Click += new System.EventHandler(this.btn2_3_Click);
            // 
            // btn2_2
            // 
            this.btn2_2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn2_2.Location = new System.Drawing.Point(141, 161);
            this.btn2_2.Name = "btn2_2";
            this.btn2_2.Size = new System.Drawing.Size(45, 45);
            this.btn2_2.TabIndex = 4;
            this.btn2_2.UseVisualStyleBackColor = false;
            this.btn2_2.Click += new System.EventHandler(this.btn2_2_Click);
            // 
            // btn2_1
            // 
            this.btn2_1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn2_1.Location = new System.Drawing.Point(65, 161);
            this.btn2_1.Name = "btn2_1";
            this.btn2_1.Size = new System.Drawing.Size(45, 45);
            this.btn2_1.TabIndex = 3;
            this.btn2_1.UseVisualStyleBackColor = false;
            this.btn2_1.Click += new System.EventHandler(this.btn2_1_Click);
            // 
            // btn1_3
            // 
            this.btn1_3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn1_3.Location = new System.Drawing.Point(222, 89);
            this.btn1_3.Name = "btn1_3";
            this.btn1_3.Size = new System.Drawing.Size(45, 45);
            this.btn1_3.TabIndex = 2;
            this.btn1_3.UseVisualStyleBackColor = false;
            this.btn1_3.Click += new System.EventHandler(this.btn1_3_Click);
            // 
            // btn1_2
            // 
            this.btn1_2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn1_2.Location = new System.Drawing.Point(141, 89);
            this.btn1_2.Name = "btn1_2";
            this.btn1_2.Size = new System.Drawing.Size(45, 45);
            this.btn1_2.TabIndex = 1;
            this.btn1_2.UseVisualStyleBackColor = false;
            this.btn1_2.Click += new System.EventHandler(this.btn1_2_Click);
            // 
            // btn1_1
            // 
            this.btn1_1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn1_1.Location = new System.Drawing.Point(65, 89);
            this.btn1_1.Name = "btn1_1";
            this.btn1_1.Size = new System.Drawing.Size(45, 45);
            this.btn1_1.TabIndex = 0;
            this.btn1_1.UseVisualStyleBackColor = false;
            this.btn1_1.Click += new System.EventHandler(this.btn1_1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.lblXO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbXO);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gamePanel.ResumeLayout(false);
            this.gamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbXO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblXO;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Button btn1_1;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btn3_3;
        private System.Windows.Forms.Button btn3_2;
        private System.Windows.Forms.Button btn3_1;
        private System.Windows.Forms.Button btn2_3;
        private System.Windows.Forms.Button btn2_2;
        private System.Windows.Forms.Button btn2_1;
        private System.Windows.Forms.Button btn1_3;
        private System.Windows.Forms.Button btn1_2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button button1;
    }
}

