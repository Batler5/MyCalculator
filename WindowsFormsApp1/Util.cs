using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Util
    {
        string deistvie = "";
        double num1;
        double num2;
        double num3;
        bool znak = true;
        
        public bool Znak { get { return znak; } set { znak = value; } }
        public double Num1 { get { return num1; } set { num1 = value; } }
        public double Num2 { get { return num2; } set { num2 = value; } }
        public double Num3 { get { return num3; } set { num3 = value; } }
        public string Deistvie { get { return deistvie; } set { deistvie = value; } }
        public void Operation() 
        {
            switch (deistvie)
            {
                case "+": num3 = num1 + num2; break;
                case "-": num3 = num1 - num2; break;
                case "X": num3 = num1 * num2; break;
                case ":":
                    if (num2 != 0)
                    {
                        num3 = num1 / num2;
                    }
                    else { num3 = 298312265; }
                    break;
            }
            num1 = num3;
            num2=0;
        }
        public int sum(int x, int y)
        {
            return x + y;
        }
        public int sumX(int x, int y)
        {
            return x - y;
        }

    }
    
}
