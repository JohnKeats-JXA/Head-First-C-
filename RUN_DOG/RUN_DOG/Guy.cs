using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUN_DOG
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels(){
            
            if(MyBet != null)
               this.MyLabel.Text = MyBet.GetDescription();
            else
                this.MyLabel.Text = Name + " hasn't placed a bet.";

            this.MyRadioButton.Text = Name + " has " + Cash + " bucks.";
        }
        
        public bool PlaceBet(int BetAmount, int DogToWin){ //下注
            if(MyBet != null)//如果之前已经下过注，现在想要更改，则先退回原先的赌金再新下注
            {
                ClearBet();  
            }
            if(BetAmount > Cash)//如果现金不够赌金，则返回false
            {
                return false;
            }
            else
            {
                MyBet = new Bet()  //生成MyBet实例
                {
                    Amount = BetAmount,
                    Dog = DogToWin,
                    Bettor = this
                };
                
                Cash -= BetAmount; //在现金中减去赌金数
  
                return true;
            }

        }

        public void ClearBet() //消除自己的下注，退还赌金后将MyBet设置为null
        {
            Cash += MyBet.Amount;
        }

        
        public void Collect(int Winner) //计算输赢后的现金
        {
            ClearBet();

            Cash += MyBet.PayOut(Winner);

            UpdateLabels();
        }
    }
}
