
namespace RUN_DOG
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.racetrack_picture = new System.Windows.Forms.PictureBox();
            this.dog_picture_1 = new System.Windows.Forms.PictureBox();
            this.dog_picture_2 = new System.Windows.Forms.PictureBox();
            this.dog_picture_3 = new System.Windows.Forms.PictureBox();
            this.dog_picture_4 = new System.Windows.Forms.PictureBox();
            this.StartRace = new System.Windows.Forms.Button();
            this.JoeRadioButton = new System.Windows.Forms.RadioButton();
            this.BobRadioButton = new System.Windows.Forms.RadioButton();
            this.AIRadioButton = new System.Windows.Forms.RadioButton();
            this.MinimumAndMaxBetLabel = new System.Windows.Forms.Label();
            this.Who = new System.Windows.Forms.Label();
            this.Bet_decide_button = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.show_down = new System.Windows.Forms.Label();
            this.JoeBetLabel = new System.Windows.Forms.Label();
            this.BobBetLabel = new System.Windows.Forms.Label();
            this.AIBetLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.racetrack_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog_picture_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog_picture_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog_picture_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog_picture_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrack_picture
            // 
            this.racetrack_picture.Dock = System.Windows.Forms.DockStyle.Top;
            this.racetrack_picture.Image = ((System.Drawing.Image)(resources.GetObject("racetrack_picture.Image")));
            this.racetrack_picture.Location = new System.Drawing.Point(0, 0);
            this.racetrack_picture.Name = "racetrack_picture";
            this.racetrack_picture.Size = new System.Drawing.Size(1044, 325);
            this.racetrack_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack_picture.TabIndex = 0;
            this.racetrack_picture.TabStop = false;
            // 
            // dog_picture_1
            // 
            this.dog_picture_1.Image = ((System.Drawing.Image)(resources.GetObject("dog_picture_1.Image")));
            this.dog_picture_1.Location = new System.Drawing.Point(0, 12);
            this.dog_picture_1.Name = "dog_picture_1";
            this.dog_picture_1.Size = new System.Drawing.Size(100, 50);
            this.dog_picture_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog_picture_1.TabIndex = 1;
            this.dog_picture_1.TabStop = false;
            // 
            // dog_picture_2
            // 
            this.dog_picture_2.Image = ((System.Drawing.Image)(resources.GetObject("dog_picture_2.Image")));
            this.dog_picture_2.Location = new System.Drawing.Point(0, 93);
            this.dog_picture_2.Name = "dog_picture_2";
            this.dog_picture_2.Size = new System.Drawing.Size(100, 50);
            this.dog_picture_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog_picture_2.TabIndex = 2;
            this.dog_picture_2.TabStop = false;
            // 
            // dog_picture_3
            // 
            this.dog_picture_3.Image = ((System.Drawing.Image)(resources.GetObject("dog_picture_3.Image")));
            this.dog_picture_3.Location = new System.Drawing.Point(0, 178);
            this.dog_picture_3.Name = "dog_picture_3";
            this.dog_picture_3.Size = new System.Drawing.Size(100, 50);
            this.dog_picture_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog_picture_3.TabIndex = 3;
            this.dog_picture_3.TabStop = false;
            // 
            // dog_picture_4
            // 
            this.dog_picture_4.Image = ((System.Drawing.Image)(resources.GetObject("dog_picture_4.Image")));
            this.dog_picture_4.Location = new System.Drawing.Point(0, 259);
            this.dog_picture_4.Name = "dog_picture_4";
            this.dog_picture_4.Size = new System.Drawing.Size(100, 50);
            this.dog_picture_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog_picture_4.TabIndex = 4;
            this.dog_picture_4.TabStop = false;
            // 
            // StartRace
            // 
            this.StartRace.Location = new System.Drawing.Point(761, 359);
            this.StartRace.Name = "StartRace";
            this.StartRace.Size = new System.Drawing.Size(207, 77);
            this.StartRace.TabIndex = 5;
            this.StartRace.Text = "Race!";
            this.StartRace.UseVisualStyleBackColor = true;
            this.StartRace.Click += new System.EventHandler(this.StartRace_Click);
            // 
            // JoeRadioButton
            // 
            this.JoeRadioButton.AutoSize = true;
            this.JoeRadioButton.Location = new System.Drawing.Point(33, 359);
            this.JoeRadioButton.Name = "JoeRadioButton";
            this.JoeRadioButton.Size = new System.Drawing.Size(140, 19);
            this.JoeRadioButton.TabIndex = 6;
            this.JoeRadioButton.TabStop = true;
            this.JoeRadioButton.Text = "JoeRadioButton";
            this.JoeRadioButton.UseVisualStyleBackColor = true;
            this.JoeRadioButton.CheckedChanged += new System.EventHandler(this.JoeRadioButton_CheckedChanged);
            // 
            // BobRadioButton
            // 
            this.BobRadioButton.AutoSize = true;
            this.BobRadioButton.Location = new System.Drawing.Point(33, 384);
            this.BobRadioButton.Name = "BobRadioButton";
            this.BobRadioButton.Size = new System.Drawing.Size(140, 19);
            this.BobRadioButton.TabIndex = 7;
            this.BobRadioButton.TabStop = true;
            this.BobRadioButton.Text = "BobRadioButton";
            this.BobRadioButton.UseVisualStyleBackColor = true;
            this.BobRadioButton.CheckedChanged += new System.EventHandler(this.BobRadioButton_CheckedChanged);
            // 
            // AIRadioButton
            // 
            this.AIRadioButton.AutoSize = true;
            this.AIRadioButton.Location = new System.Drawing.Point(33, 409);
            this.AIRadioButton.Name = "AIRadioButton";
            this.AIRadioButton.Size = new System.Drawing.Size(132, 19);
            this.AIRadioButton.TabIndex = 8;
            this.AIRadioButton.TabStop = true;
            this.AIRadioButton.Text = "AIRadioButton";
            this.AIRadioButton.UseVisualStyleBackColor = true;
            this.AIRadioButton.CheckedChanged += new System.EventHandler(this.AIRadioButton_CheckedChanged);
            // 
            // MinimumAndMaxBetLabel
            // 
            this.MinimumAndMaxBetLabel.AutoSize = true;
            this.MinimumAndMaxBetLabel.Location = new System.Drawing.Point(33, 334);
            this.MinimumAndMaxBetLabel.Name = "MinimumAndMaxBetLabel";
            this.MinimumAndMaxBetLabel.Size = new System.Drawing.Size(0, 15);
            this.MinimumAndMaxBetLabel.TabIndex = 9;
            // 
            // Who
            // 
            this.Who.AutoSize = true;
            this.Who.Location = new System.Drawing.Point(33, 443);
            this.Who.Name = "Who";
            this.Who.Size = new System.Drawing.Size(39, 15);
            this.Who.TabIndex = 10;
            this.Who.Text = "name";
            // 
            // Bet_decide_button
            // 
            this.Bet_decide_button.Location = new System.Drawing.Point(78, 439);
            this.Bet_decide_button.Name = "Bet_decide_button";
            this.Bet_decide_button.Size = new System.Drawing.Size(75, 23);
            this.Bet_decide_button.TabIndex = 11;
            this.Bet_decide_button.Text = "bets";
            this.Bet_decide_button.UseVisualStyleBackColor = true;
            this.Bet_decide_button.Click += new System.EventHandler(this.Bet_decide_button_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(175, 439);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 25);
            this.numericUpDown1.TabIndex = 12;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(387, 439);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(44, 25);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // show_down
            // 
            this.show_down.AutoSize = true;
            this.show_down.Location = new System.Drawing.Point(238, 443);
            this.show_down.Name = "show_down";
            this.show_down.Size = new System.Drawing.Size(143, 15);
            this.show_down.TabIndex = 14;
            this.show_down.Text = "on the dog number";
            // 
            // JoeBetLabel
            // 
            this.JoeBetLabel.AutoSize = true;
            this.JoeBetLabel.Location = new System.Drawing.Point(318, 359);
            this.JoeBetLabel.Name = "JoeBetLabel";
            this.JoeBetLabel.Size = new System.Drawing.Size(95, 15);
            this.JoeBetLabel.TabIndex = 15;
            this.JoeBetLabel.Text = "JoeBetLabel";
            // 
            // BobBetLabel
            // 
            this.BobBetLabel.AutoSize = true;
            this.BobBetLabel.Location = new System.Drawing.Point(318, 386);
            this.BobBetLabel.Name = "BobBetLabel";
            this.BobBetLabel.Size = new System.Drawing.Size(95, 15);
            this.BobBetLabel.TabIndex = 16;
            this.BobBetLabel.Text = "BobBetLabel";
            // 
            // AIBetLabel
            // 
            this.AIBetLabel.AutoSize = true;
            this.AIBetLabel.Location = new System.Drawing.Point(318, 411);
            this.AIBetLabel.Name = "AIBetLabel";
            this.AIBetLabel.Size = new System.Drawing.Size(87, 15);
            this.AIBetLabel.TabIndex = 17;
            this.AIBetLabel.Text = "AIBetLabel";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 467);
            this.Controls.Add(this.AIBetLabel);
            this.Controls.Add(this.BobBetLabel);
            this.Controls.Add(this.JoeBetLabel);
            this.Controls.Add(this.show_down);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Bet_decide_button);
            this.Controls.Add(this.Who);
            this.Controls.Add(this.MinimumAndMaxBetLabel);
            this.Controls.Add(this.AIRadioButton);
            this.Controls.Add(this.BobRadioButton);
            this.Controls.Add(this.JoeRadioButton);
            this.Controls.Add(this.StartRace);
            this.Controls.Add(this.dog_picture_4);
            this.Controls.Add(this.dog_picture_3);
            this.Controls.Add(this.dog_picture_2);
            this.Controls.Add(this.dog_picture_1);
            this.Controls.Add(this.racetrack_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.racetrack_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog_picture_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog_picture_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog_picture_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog_picture_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrack_picture;
        private System.Windows.Forms.PictureBox dog_picture_1;
        private System.Windows.Forms.PictureBox dog_picture_2;
        private System.Windows.Forms.PictureBox dog_picture_3;
        private System.Windows.Forms.PictureBox dog_picture_4;
        private System.Windows.Forms.Button StartRace;
        private System.Windows.Forms.RadioButton JoeRadioButton;
        private System.Windows.Forms.RadioButton BobRadioButton;
        private System.Windows.Forms.RadioButton AIRadioButton;
        private System.Windows.Forms.Label MinimumAndMaxBetLabel;
        private System.Windows.Forms.Label Who;
        private System.Windows.Forms.Button Bet_decide_button;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label show_down;
        private System.Windows.Forms.Label JoeBetLabel;
        private System.Windows.Forms.Label BobBetLabel;
        private System.Windows.Forms.Label AIBetLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

