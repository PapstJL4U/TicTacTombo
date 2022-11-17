namespace TicTacToe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_Spieler1 = new System.Windows.Forms.Label();
            this.lb_Spieler2 = new System.Windows.Forms.Label();
            this.bt_00 = new System.Windows.Forms.Button();
            this.bt_01 = new System.Windows.Forms.Button();
            this.bt_02 = new System.Windows.Forms.Button();
            this.bt_10 = new System.Windows.Forms.Button();
            this.bt_11 = new System.Windows.Forms.Button();
            this.bt_12 = new System.Windows.Forms.Button();
            this.bt_20 = new System.Windows.Forms.Button();
            this.bt_21 = new System.Windows.Forms.Button();
            this.bt_22 = new System.Windows.Forms.Button();
            this.lb_spieler1_won = new System.Windows.Forms.Label();
            this.lb_spieler2_won = new System.Windows.Forms.Label();
            this.bt_reset = new System.Windows.Forms.Button();
            this.lb_output = new System.Windows.Forms.Label();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.bt_farbe_1 = new System.Windows.Forms.Button();
            this.bt_farbe_2 = new System.Windows.Forms.Button();
            this.MyImages = new System.Windows.Forms.ImageList(this.components);
            this.pb_arrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_arrow)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Spieler1
            // 
            this.lb_Spieler1.AutoSize = true;
            this.lb_Spieler1.Location = new System.Drawing.Point(54, 24);
            this.lb_Spieler1.Name = "lb_Spieler1";
            this.lb_Spieler1.Size = new System.Drawing.Size(48, 13);
            this.lb_Spieler1.TabIndex = 0;
            this.lb_Spieler1.Text = "Spieler 1";
            this.lb_Spieler1.Click += new System.EventHandler(this.lb_Spieler1_Click);
            // 
            // lb_Spieler2
            // 
            this.lb_Spieler2.AutoSize = true;
            this.lb_Spieler2.Location = new System.Drawing.Point(385, 24);
            this.lb_Spieler2.Name = "lb_Spieler2";
            this.lb_Spieler2.Size = new System.Drawing.Size(48, 13);
            this.lb_Spieler2.TabIndex = 1;
            this.lb_Spieler2.Text = "Spieler 2";
            // 
            // bt_00
            // 
            this.bt_00.Location = new System.Drawing.Point(57, 66);
            this.bt_00.Name = "bt_00";
            this.bt_00.Size = new System.Drawing.Size(134, 128);
            this.bt_00.TabIndex = 2;
            this.bt_00.Text = "00";
            this.bt_00.UseVisualStyleBackColor = true;
            this.bt_00.Click += new System.EventHandler(this.bt_00_Click);
            // 
            // bt_01
            // 
            this.bt_01.Location = new System.Drawing.Point(220, 66);
            this.bt_01.Name = "bt_01";
            this.bt_01.Size = new System.Drawing.Size(134, 128);
            this.bt_01.TabIndex = 3;
            this.bt_01.Text = "01";
            this.bt_01.UseVisualStyleBackColor = true;
            this.bt_01.Click += new System.EventHandler(this.bt_01_Click);
            // 
            // bt_02
            // 
            this.bt_02.Location = new System.Drawing.Point(388, 66);
            this.bt_02.Name = "bt_02";
            this.bt_02.Size = new System.Drawing.Size(134, 128);
            this.bt_02.TabIndex = 4;
            this.bt_02.Text = "02";
            this.bt_02.UseVisualStyleBackColor = true;
            this.bt_02.Click += new System.EventHandler(this.bt_02_Click);
            // 
            // bt_10
            // 
            this.bt_10.Location = new System.Drawing.Point(57, 223);
            this.bt_10.Name = "bt_10";
            this.bt_10.Size = new System.Drawing.Size(134, 128);
            this.bt_10.TabIndex = 5;
            this.bt_10.Text = "10";
            this.bt_10.UseVisualStyleBackColor = true;
            this.bt_10.Click += new System.EventHandler(this.bt_10_Click);
            // 
            // bt_11
            // 
            this.bt_11.Location = new System.Drawing.Point(220, 223);
            this.bt_11.Name = "bt_11";
            this.bt_11.Size = new System.Drawing.Size(134, 128);
            this.bt_11.TabIndex = 6;
            this.bt_11.Text = "11";
            this.bt_11.UseVisualStyleBackColor = true;
            this.bt_11.Click += new System.EventHandler(this.bt_11_Click);
            // 
            // bt_12
            // 
            this.bt_12.Location = new System.Drawing.Point(388, 223);
            this.bt_12.Name = "bt_12";
            this.bt_12.Size = new System.Drawing.Size(134, 128);
            this.bt_12.TabIndex = 7;
            this.bt_12.Text = "12";
            this.bt_12.UseVisualStyleBackColor = true;
            this.bt_12.Click += new System.EventHandler(this.bt_12_Click);
            // 
            // bt_20
            // 
            this.bt_20.Location = new System.Drawing.Point(57, 382);
            this.bt_20.Name = "bt_20";
            this.bt_20.Size = new System.Drawing.Size(134, 128);
            this.bt_20.TabIndex = 8;
            this.bt_20.Text = "20";
            this.bt_20.UseVisualStyleBackColor = true;
            this.bt_20.Click += new System.EventHandler(this.bt_20_Click);
            // 
            // bt_21
            // 
            this.bt_21.Location = new System.Drawing.Point(220, 382);
            this.bt_21.Name = "bt_21";
            this.bt_21.Size = new System.Drawing.Size(134, 128);
            this.bt_21.TabIndex = 9;
            this.bt_21.Text = "21";
            this.bt_21.UseVisualStyleBackColor = true;
            this.bt_21.Click += new System.EventHandler(this.bt_21_Click);
            // 
            // bt_22
            // 
            this.bt_22.Location = new System.Drawing.Point(388, 382);
            this.bt_22.Name = "bt_22";
            this.bt_22.Size = new System.Drawing.Size(134, 128);
            this.bt_22.TabIndex = 10;
            this.bt_22.Text = "22";
            this.bt_22.UseVisualStyleBackColor = true;
            this.bt_22.Click += new System.EventHandler(this.bt_22_Click);
            // 
            // lb_spieler1_won
            // 
            this.lb_spieler1_won.AutoSize = true;
            this.lb_spieler1_won.Location = new System.Drawing.Point(178, 24);
            this.lb_spieler1_won.Name = "lb_spieler1_won";
            this.lb_spieler1_won.Size = new System.Drawing.Size(13, 13);
            this.lb_spieler1_won.TabIndex = 11;
            this.lb_spieler1_won.Text = "0";
            this.lb_spieler1_won.Click += new System.EventHandler(this.lb_spieler1_won_Click);
            // 
            // lb_spieler2_won
            // 
            this.lb_spieler2_won.AutoSize = true;
            this.lb_spieler2_won.Location = new System.Drawing.Point(509, 24);
            this.lb_spieler2_won.Name = "lb_spieler2_won";
            this.lb_spieler2_won.Size = new System.Drawing.Size(13, 13);
            this.lb_spieler2_won.TabIndex = 12;
            this.lb_spieler2_won.Text = "0";
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(57, 532);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(134, 23);
            this.bt_reset.TabIndex = 13;
            this.bt_reset.Text = "Neues Spiel";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // lb_output
            // 
            this.lb_output.AutoSize = true;
            this.lb_output.Location = new System.Drawing.Point(217, 532);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(89, 13);
            this.lb_output.TabIndex = 14;
            this.lb_output.Text = "Programm Output";
            this.lb_output.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_output
            // 
            this.tb_output.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_output.Location = new System.Drawing.Point(321, 529);
            this.tb_output.Name = "tb_output";
            this.tb_output.Size = new System.Drawing.Size(201, 20);
            this.tb_output.TabIndex = 15;
            this.tb_output.Text = "What is the App doing...";
            // 
            // bt_farbe_1
            // 
            this.bt_farbe_1.Enabled = false;
            this.bt_farbe_1.Location = new System.Drawing.Point(149, 19);
            this.bt_farbe_1.Name = "bt_farbe_1";
            this.bt_farbe_1.Size = new System.Drawing.Size(23, 23);
            this.bt_farbe_1.TabIndex = 16;
            this.bt_farbe_1.Text = "F";
            this.bt_farbe_1.UseVisualStyleBackColor = true;
            // 
            // bt_farbe_2
            // 
            this.bt_farbe_2.Enabled = false;
            this.bt_farbe_2.Location = new System.Drawing.Point(480, 19);
            this.bt_farbe_2.Name = "bt_farbe_2";
            this.bt_farbe_2.Size = new System.Drawing.Size(23, 23);
            this.bt_farbe_2.TabIndex = 17;
            this.bt_farbe_2.Text = "F";
            this.bt_farbe_2.UseVisualStyleBackColor = true;
            // 
            // MyImages
            // 
            this.MyImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MyImages.ImageStream")));
            this.MyImages.TransparentColor = System.Drawing.Color.Transparent;
            this.MyImages.Images.SetKeyName(0, "arrow_left.png");
            this.MyImages.Images.SetKeyName(1, "arrow_right.png");
            // 
            // pb_arrow
            // 
            this.pb_arrow.Image = global::TicTacToe.Properties.Resources.arrow_left;
            this.pb_arrow.Location = new System.Drawing.Point(263, 12);
            this.pb_arrow.Name = "pb_arrow";
            this.pb_arrow.Size = new System.Drawing.Size(52, 40);
            this.pb_arrow.TabIndex = 18;
            this.pb_arrow.TabStop = false;
            this.pb_arrow.Click += new System.EventHandler(this.pb_arrow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 564);
            this.Controls.Add(this.pb_arrow);
            this.Controls.Add(this.bt_farbe_2);
            this.Controls.Add(this.bt_farbe_1);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.lb_spieler2_won);
            this.Controls.Add(this.lb_spieler1_won);
            this.Controls.Add(this.bt_22);
            this.Controls.Add(this.bt_21);
            this.Controls.Add(this.bt_20);
            this.Controls.Add(this.bt_12);
            this.Controls.Add(this.bt_11);
            this.Controls.Add(this.bt_10);
            this.Controls.Add(this.bt_02);
            this.Controls.Add(this.bt_01);
            this.Controls.Add(this.bt_00);
            this.Controls.Add(this.lb_Spieler2);
            this.Controls.Add(this.lb_Spieler1);
            this.Name = "Form1";
            this.Text = "TicTacToe in Farbe";
            ((System.ComponentModel.ISupportInitialize)(this.pb_arrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Spieler1;
        private System.Windows.Forms.Label lb_Spieler2;
        private System.Windows.Forms.Button bt_00;
        private System.Windows.Forms.Button bt_01;
        private System.Windows.Forms.Button bt_02;
        private System.Windows.Forms.Button bt_10;
        private System.Windows.Forms.Button bt_11;
        private System.Windows.Forms.Button bt_12;
        private System.Windows.Forms.Button bt_20;
        private System.Windows.Forms.Button bt_21;
        private System.Windows.Forms.Button bt_22;
        private System.Windows.Forms.Label lb_spieler1_won;
        private System.Windows.Forms.Label lb_spieler2_won;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Label lb_output;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Button bt_farbe_1;
        private System.Windows.Forms.Button bt_farbe_2;
        private System.Windows.Forms.ImageList MyImages;
        private System.Windows.Forms.PictureBox pb_arrow;
    }
}

