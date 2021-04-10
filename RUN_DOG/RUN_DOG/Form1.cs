using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUN_DOG
{
    public partial class Form1 : Form
    {
        Guy[] Guys = new Guy[3];
        Greyhound[] Greyhounds = new Greyhound[4];
        
        int MiniBet = 5;//设置最小下注额
        int MaxBet = 15;//设置最大下注额
        
        Random MyRandomizer = new Random();//随机数
        
        public Form1()
        {
            InitializeComponent();

            //初始化最小和最大下注额
            numericUpDown1.Minimum = MiniBet;
            numericUpDown1.Maximum = MaxBet;

            //在label中显示最小和最大下注额
            MinimumAndMaxBetLabel.Text = "MinimumBet : " + MiniBet + "  MaximumBet : " + MaxBet;
            
            //初始化3个人

            //Joe
            Guys[0] = new Guy() { Name = "Joe", Cash = 50, MyRadioButton = JoeRadioButton, MyLabel = JoeBetLabel };
            
            //Bob
            Guys[1] = new Guy() { Name = "Bob", Cash = 75, MyRadioButton = BobRadioButton, MyLabel = BobBetLabel };
            
            //AI
            Guys[2] = new Guy() { Name = "AI", Cash = 45, MyRadioButton = AIRadioButton, MyLabel = AIBetLabel };
            
            //初始化4个狗
            
            //狗1
            Greyhounds[0] = new Greyhound()
            {
                MyPictureBox = dog_picture_1,
                StartPosition = dog_picture_1.Left,
                RacetrackLength = racetrack_picture.Width - dog_picture_1.Width,
                Randomizer = MyRandomizer
            };
            
            //狗2
            Greyhounds[1] = new Greyhound()
            {
                MyPictureBox = dog_picture_2,
                StartPosition = dog_picture_2.Left,
                RacetrackLength = racetrack_picture.Width - dog_picture_2.Width,
                Randomizer = MyRandomizer
            };
            
            //狗3
            Greyhounds[2] = new Greyhound()
            {
                MyPictureBox = dog_picture_3,
                StartPosition = dog_picture_3.Left,
                RacetrackLength = racetrack_picture.Width - dog_picture_3.Width,
                Randomizer = MyRandomizer
            };
            
            //狗4
            Greyhounds[3] = new Greyhound()
            {
                MyPictureBox = dog_picture_4,
                StartPosition = dog_picture_4.Left,
                RacetrackLength = racetrack_picture.Width - dog_picture_4.Width,
                Randomizer = MyRandomizer
            };

            update_show();//初始化3人现金数及下注情况
        }

        public void update_show() //用于初始化3人在radiobutton中显示的现金以及下注情况
        {
            JoeRadioButton.Text = "Joe has " + Guys[0].Cash + " bucks.";
            BobRadioButton.Text = "Bob has " + Guys[1].Cash + " bucks.";
            AIRadioButton.Text = "AI has " + Guys[2].Cash + " bucks.";

            JoeBetLabel.Text = "Joe hasn't placed a bet.";
            BobBetLabel.Text = "Bob hasn't placed a bet.";
            AIBetLabel.Text = "AI hasn't placed a bet.";
        }

        private void StartRace_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 4; i++) {
                if (Greyhounds[i].Run())
                {
                    timer1.Stop();
                    
                    MessageBox.Show("Dog #" + (i+1).ToString() + " won the race!");

                    for (int j = 0;j < 3;j++)
                    {
                        Guys[j].Collect(i + 1);
                        Guys[j].MyBet = null;
                        Guys[j].UpdateLabels();
                    }

                    for(int j = 0; j < 4; j++) 
                        Greyhounds[j].TakeStartPosition();
                    
                    return;
                }   
            }
        }

        private void Bet_decide_button_Click(object sender, EventArgs e)
        {
            //点击bet按钮后，运行PlaceBet检查现金是否够赌注
            //如果够则更新显示现金与赌注，否则显示一个对话框报错
            if (Who.Text == "Joe")
            {
                if (Guys[0].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value))//如果现金比赌金多，则更新显示现金与赌注
                    Guys[0].UpdateLabels();
                else//否则显示一个对话框报错
                    MessageBox.Show(Guys[0].Name + " doesn't have enough cash!");
            }
            if (Who.Text == "Bob")
            {
                if(Guys[1].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value))
                    Guys[1].UpdateLabels();
                else
                    MessageBox.Show(Guys[1].Name + " doesn't have enough cash!");
            }
            if (Who.Text == "AI")
            {
                if(Guys[2].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value))
                    Guys[2].UpdateLabels();
                else
                    MessageBox.Show(Guys[2].Name + " doesn't have enough cash!");
            }
        }

        private void JoeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Who.Text = "Joe";
        }

        private void BobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Who.Text = "Bob";
        }

        private void AIRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Who.Text = "AI";
        }
    }
}
