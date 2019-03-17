namespace RandomLabelMove
{
    partial class game
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
            this.Race_Button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.updownbike = new System.Windows.Forms.NumericUpDown();
            this.label_bike = new System.Windows.Forms.Label();
            this.updownmoney = new System.Windows.Forms.NumericUpDown();
            this.bet_button = new System.Windows.Forms.Button();
            this.labelBetterName = new System.Windows.Forms.Label();
            this.labeljatin = new System.Windows.Forms.Label();
            this.labelsum = new System.Windows.Forms.Label();
            this.labelgill = new System.Windows.Forms.Label();
            this.labelbt = new System.Windows.Forms.Label();
            this.radioButtonjatin = new System.Windows.Forms.RadioButton();
            this.radioButtonsum = new System.Windows.Forms.RadioButton();
            this.radioButtongill = new System.Windows.Forms.RadioButton();
            this.labelMinimumBet = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.racePicture = new System.Windows.Forms.PictureBox();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownbike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownmoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Race_Button
            // 
            this.Race_Button.Location = new System.Drawing.Point(661, 402);
            this.Race_Button.Name = "Race_Button";
            this.Race_Button.Size = new System.Drawing.Size(172, 85);
            this.Race_Button.TabIndex = 3;
            this.Race_Button.Text = "Race";
            this.Race_Button.UseVisualStyleBackColor = true;
            this.Race_Button.Click += new System.EventHandler(this.Racer_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.updownbike);
            this.gb1.Controls.Add(this.label_bike);
            this.gb1.Controls.Add(this.updownmoney);
            this.gb1.Controls.Add(this.bet_button);
            this.gb1.Controls.Add(this.labelBetterName);
            this.gb1.Controls.Add(this.labeljatin);
            this.gb1.Controls.Add(this.labelsum);
            this.gb1.Controls.Add(this.labelgill);
            this.gb1.Controls.Add(this.labelbt);
            this.gb1.Controls.Add(this.radioButtonjatin);
            this.gb1.Controls.Add(this.radioButtonsum);
            this.gb1.Controls.Add(this.radioButtongill);
            this.gb1.Controls.Add(this.labelMinimumBet);
            this.gb1.Location = new System.Drawing.Point(12, 346);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(612, 187);
            this.gb1.TabIndex = 9;
            this.gb1.TabStop = false;
            this.gb1.Text = "Betting Parlor";
            // 
            // updownbike
            // 
            this.updownbike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownbike.Location = new System.Drawing.Point(371, 151);
            this.updownbike.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.updownbike.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownbike.Name = "updownbike";
            this.updownbike.Size = new System.Drawing.Size(45, 22);
            this.updownbike.TabIndex = 16;
            this.updownbike.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_bike
            // 
            this.label_bike.AutoSize = true;
            this.label_bike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bike.Location = new System.Drawing.Point(228, 153);
            this.label_bike.Name = "label_bike";
            this.label_bike.Size = new System.Drawing.Size(139, 16);
            this.label_bike.TabIndex = 15;
            this.label_bike.Text = "bucks on bike number";
            // 
            // updownmoney
            // 
            this.updownmoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updownmoney.Location = new System.Drawing.Point(177, 150);
            this.updownmoney.Name = "updownmoney";
            this.updownmoney.Size = new System.Drawing.Size(45, 22);
            this.updownmoney.TabIndex = 14;
            this.updownmoney.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bet_button
            // 
            this.bet_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bet_button.Location = new System.Drawing.Point(99, 150);
            this.bet_button.Name = "bet_button";
            this.bet_button.Size = new System.Drawing.Size(54, 23);
            this.bet_button.TabIndex = 13;
            this.bet_button.Text = "Bets";
            this.bet_button.UseVisualStyleBackColor = true;
            this.bet_button.Click += new System.EventHandler(this.Bet_Click);
            // 
            // labelBetterName
            // 
            this.labelBetterName.AutoSize = true;
            this.labelBetterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBetterName.Location = new System.Drawing.Point(12, 153);
            this.labelBetterName.Name = "labelBetterName";
            this.labelBetterName.Size = new System.Drawing.Size(42, 16);
            this.labelBetterName.TabIndex = 12;
            this.labelBetterName.Text = "name";
            // 
            // labeljatin
            // 
            this.labeljatin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeljatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljatin.Location = new System.Drawing.Point(186, 118);
            this.labeljatin.Name = "labeljatin";
            this.labeljatin.Size = new System.Drawing.Size(201, 23);
            this.labeljatin.TabIndex = 11;
            this.labeljatin.Text = "jatinBetLabel";
            // 
            // labelsum
            // 
            this.labelsum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsum.Location = new System.Drawing.Point(186, 86);
            this.labelsum.Name = "labelsum";
            this.labelsum.Size = new System.Drawing.Size(201, 23);
            this.labelsum.TabIndex = 10;
            this.labelsum.Text = "sumeetBetLabel";
            // 
            // labelgill
            // 
            this.labelgill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelgill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgill.Location = new System.Drawing.Point(186, 56);
            this.labelgill.Name = "labelgill";
            this.labelgill.Size = new System.Drawing.Size(201, 25);
            this.labelgill.TabIndex = 9;
            this.labelgill.Text = "gillBetLabel";
            // 
            // labelbt
            // 
            this.labelbt.AutoSize = true;
            this.labelbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbt.Location = new System.Drawing.Point(183, 31);
            this.labelbt.Name = "labelbt";
            this.labelbt.Size = new System.Drawing.Size(39, 16);
            this.labelbt.TabIndex = 8;
            this.labelbt.Text = "Bets";
            // 
            // radioButtonjatin
            // 
            this.radioButtonjatin.AutoSize = true;
            this.radioButtonjatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonjatin.Location = new System.Drawing.Point(12, 117);
            this.radioButtonjatin.Name = "radioButtonjatin";
            this.radioButtonjatin.Size = new System.Drawing.Size(124, 20);
            this.radioButtonjatin.TabIndex = 7;
            this.radioButtonjatin.TabStop = true;
            this.radioButtonjatin.Text = "jatinRadioButton";
            this.radioButtonjatin.UseVisualStyleBackColor = true;
            this.radioButtonjatin.CheckedChanged += new System.EventHandler(this.radioButtonjatin_CheckedChanged);
            // 
            // radioButtonsum
            // 
            this.radioButtonsum.AutoSize = true;
            this.radioButtonsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonsum.Location = new System.Drawing.Point(12, 86);
            this.radioButtonsum.Name = "radioButtonsum";
            this.radioButtonsum.Size = new System.Drawing.Size(144, 20);
            this.radioButtonsum.TabIndex = 6;
            this.radioButtonsum.TabStop = true;
            this.radioButtonsum.Text = "sumeetRadioButton";
            this.radioButtonsum.UseVisualStyleBackColor = true;
            this.radioButtonsum.CheckedChanged += new System.EventHandler(this.radioButtonsum_CheckedChanged);
            // 
            // radioButtongill
            // 
            this.radioButtongill.AutoSize = true;
            this.radioButtongill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtongill.Location = new System.Drawing.Point(12, 55);
            this.radioButtongill.Name = "radioButtongill";
            this.radioButtongill.Size = new System.Drawing.Size(119, 20);
            this.radioButtongill.TabIndex = 5;
            this.radioButtongill.TabStop = true;
            this.radioButtongill.Text = "GillRadioButton";
            this.radioButtongill.UseVisualStyleBackColor = true;
            this.radioButtongill.CheckedChanged += new System.EventHandler(this.radioButtongill_CheckedChanged);
            // 
            // labelMinimumBet
            // 
            this.labelMinimumBet.AutoSize = true;
            this.labelMinimumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimumBet.Location = new System.Drawing.Point(12, 31);
            this.labelMinimumBet.Name = "labelMinimumBet";
            this.labelMinimumBet.Size = new System.Drawing.Size(130, 16);
            this.labelMinimumBet.TabIndex = 4;
            this.labelMinimumBet.Text = "minimumBetLabel";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::bikerace.Properties.Resources.cb853ddd62b115f;
            this.pictureBox5.Location = new System.Drawing.Point(788, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(684, 340);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::bikerace.Properties.Resources.unnamed;
            this.pictureBox4.Location = new System.Drawing.Point(12, 258);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(108, 56);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::bikerace.Properties.Resources.spr_bike_0;
            this.pictureBox3.Location = new System.Drawing.Point(12, 195);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(108, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::bikerace.Properties.Resources.spr_bike_0;
            this.pictureBox2.Location = new System.Drawing.Point(12, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bikerace.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // racePicture
            // 
            this.racePicture.Image = global::bikerace.Properties.Resources.images;
            this.racePicture.Location = new System.Drawing.Point(0, 0);
            this.racePicture.Name = "racePicture";
            this.racePicture.Size = new System.Drawing.Size(875, 340);
            this.racePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racePicture.TabIndex = 8;
            this.racePicture.TabStop = false;
            this.racePicture.Click += new System.EventHandler(this.raceTrackPicture_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 531);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Race_Button);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.racePicture);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "game";
            this.Text = "Form1";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownbike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownmoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Race_Button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox racePicture;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label labelMinimumBet;
        private System.Windows.Forms.NumericUpDown updownbike;
        private System.Windows.Forms.Label label_bike;
        private System.Windows.Forms.NumericUpDown updownmoney;
        private System.Windows.Forms.Button bet_button;
        private System.Windows.Forms.Label labelBetterName;
        private System.Windows.Forms.Label labeljatin;
        private System.Windows.Forms.Label labelsum;
        private System.Windows.Forms.Label labelgill;
        private System.Windows.Forms.Label labelbt;
        private System.Windows.Forms.RadioButton radioButtonjatin;
        private System.Windows.Forms.RadioButton radioButtonsum;
        private System.Windows.Forms.RadioButton radioButtongill;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

