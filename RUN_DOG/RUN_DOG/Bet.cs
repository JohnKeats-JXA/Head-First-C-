using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUN_DOG
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            string ans;
            ans = Bettor.Name + " has placed " + Amount + " on dog #" + Dog.ToString() + ".";
            return ans;
        }

        public int PayOut(int Winner)
        {
            int res;

            if (Winner == Dog) //赢则消除自己的下注，退还赌金后将MyBet设置为null，PayOut返回收益（等于赌金），让现金加上收益
            {

                res = Amount;

               

                return res;
            }
            else //输则消除自己的下注，退还赌金后将MyBet设置为null,PayOut返回赌金的负数，让现金减去赌金

            {

                res = Amount * (-1);

                

                return res;
            }
        }
    }
}
