
namespace HappyBirthDayPrincess
{
    partial class HappyBirthdayPrincess
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
            this.lbl_moves = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pbx5 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_moves
            // 
            this.lbl_moves.AutoSize = true;
            this.lbl_moves.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moves.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_moves.Location = new System.Drawing.Point(888, 572);
            this.lbl_moves.Name = "lbl_moves";
            this.lbl_moves.Size = new System.Drawing.Size(18, 19);
            this.lbl_moves.TabIndex = 3;
            this.lbl_moves.Text = "0";
            this.lbl_moves.Visible = false;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_time.Location = new System.Drawing.Point(721, 491);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(264, 80);
            this.lbl_time.TabIndex = 4;
            this.lbl_time.Text = "00:00:00";
            this.lbl_time.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(664, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 396);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Picture";
            this.groupBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(773, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Moves Made : ";
            this.label1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.UpdateTimeElapsed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HappyBirthDayPrincess.Properties.Resources._8;
            this.pictureBox1.Location = new System.Drawing.Point(826, 449);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDoubleClick);
            // 
            // pbx9
            // 
            this.pbx9.BackColor = System.Drawing.Color.Transparent;
            this.pbx9.Location = new System.Drawing.Point(405, 405);
            this.pbx9.Margin = new System.Windows.Forms.Padding(1);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(200, 200);
            this.pbx9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx9.TabIndex = 0;
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx8
            // 
            this.pbx8.BackColor = System.Drawing.Color.Transparent;
            this.pbx8.Location = new System.Drawing.Point(203, 405);
            this.pbx8.Margin = new System.Windows.Forms.Padding(1);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(200, 200);
            this.pbx8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx8.TabIndex = 0;
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx7
            // 
            this.pbx7.BackColor = System.Drawing.Color.Transparent;
            this.pbx7.Location = new System.Drawing.Point(1, 405);
            this.pbx7.Margin = new System.Windows.Forms.Padding(1);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(200, 200);
            this.pbx7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx7.TabIndex = 0;
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx6
            // 
            this.pbx6.BackColor = System.Drawing.Color.Transparent;
            this.pbx6.Location = new System.Drawing.Point(405, 203);
            this.pbx6.Margin = new System.Windows.Forms.Padding(1);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(200, 200);
            this.pbx6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx6.TabIndex = 0;
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx5
            // 
            this.pbx5.BackColor = System.Drawing.Color.Transparent;
            this.pbx5.Location = new System.Drawing.Point(203, 203);
            this.pbx5.Margin = new System.Windows.Forms.Padding(1);
            this.pbx5.Name = "pbx5";
            this.pbx5.Size = new System.Drawing.Size(200, 200);
            this.pbx5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx5.TabIndex = 0;
            this.pbx5.TabStop = false;
            this.pbx5.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx4
            // 
            this.pbx4.BackColor = System.Drawing.Color.Transparent;
            this.pbx4.Location = new System.Drawing.Point(1, 203);
            this.pbx4.Margin = new System.Windows.Forms.Padding(1);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(200, 200);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 0;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx3
            // 
            this.pbx3.BackColor = System.Drawing.Color.Transparent;
            this.pbx3.Location = new System.Drawing.Point(405, 1);
            this.pbx3.Margin = new System.Windows.Forms.Padding(1);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(200, 200);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 0;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx2
            // 
            this.pbx2.BackColor = System.Drawing.Color.Transparent;
            this.pbx2.Location = new System.Drawing.Point(203, 1);
            this.pbx2.Margin = new System.Windows.Forms.Padding(1);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(200, 200);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 0;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // pbx1
            // 
            this.pbx1.BackColor = System.Drawing.Color.Transparent;
            this.pbx1.Location = new System.Drawing.Point(1, 1);
            this.pbx1.Margin = new System.Windows.Forms.Padding(1);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(200, 200);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.SwitchPictureBox);
            // 
            // panel
            // 
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Controls.Add(this.pbx1);
            this.panel.Controls.Add(this.pbx2);
            this.panel.Controls.Add(this.pbx3);
            this.panel.Controls.Add(this.pbx4);
            this.panel.Controls.Add(this.pbx5);
            this.panel.Controls.Add(this.pbx6);
            this.panel.Controls.Add(this.pbx7);
            this.panel.Controls.Add(this.pbx8);
            this.panel.Controls.Add(this.pbx9);
            this.panel.Location = new System.Drawing.Point(24, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(606, 606);
            this.panel.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(24, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(606, 606);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(100, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 225);
            this.panel1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(793, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "by Bahattin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(580, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(349, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "To Exit The Game Click Double Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(600, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "To Start The Game Click One Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(64, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(611, 89);
            this.label3.TabIndex = 0;
            this.label3.Text = "Slide Puzzle Game";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::HappyBirthDayPrincess.Properties.Resources._5;
            this.button1.Location = new System.Drawing.Point(20, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 200);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HappyBirthdayPrincess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1051, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_moves);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HappyBirthdayPrincess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_moves;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx5;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

