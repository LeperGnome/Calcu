using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            outputNum.Text = "...";
        }

        private void play_Click(object sender, EventArgs e)
        {
            mainOper();
        }

        private void mainOper()
        {
            if (inputNum.Text != "" && inputNum.Text != "0")
            {
                error.Text = "";
                decimal inpNum = Convert.ToDecimal(inputNum.Text);      // Считывание числа
                int ss = Convert.ToInt32(ss_select.Value);              // Считывание системы счисления

                long cCt = Convert.ToInt64(Math.Truncate(inpNum));      // Разбитие введённого числа на целую и дробную части
                decimal ostCt = inpNum - cCt;                           //
                long c10Ct;
                decimal ost10Ct;
                long kol_n = Convert.ToInt64(kol_input.Text);

                if (ss_select.Value == 10)
                {
                    c10Ct = cCt;
                    ost10Ct = ostCt;
                }
                else
                {
                    c10Ct = oper(cCt, ss);                             // Перевод частей в 10 с.с. при помощи функций oper() и oper_ost()
                    ost10Ct = oper_ost(ostCt, ss);                     //
                }

                if (ss_select_out.Value == 10)
                {
                    outputNum.Text = Convert.ToString(c10Ct + ost10Ct);
                }
                else
                {
                    int ss_out = Convert.ToInt32(ss_select_out.Value);
                    long cSsCt = oper10(c10Ct, ss_out);                         // Перевод частей из 10 с.с. в выбранную
                    decimal ostSsCt = oper10_ost(ost10Ct, ss_out, kol_n);              //

                    outputNum.Text = Convert.ToString(cSsCt + ostSsCt);
                }
            }
            else
            {
                error.Text = "Проверьте входные данные.";
            }
        }

        private static long oper10 (long num, int s)
        {
            long otv = 0;
            long ch;
            int razr = 0;

             while (num > 0)
            {
                ch = num % s;
                otv = otv + ch * (long)Math.Pow(10, razr);
                razr++;
                num = num / s;
            }
            return otv;
        }

        public decimal oper10_ost (decimal num, int s, long n)
        {
            //long n = Convert.ToInt64(kol_input.Text);
            decimal otv = 0;
            decimal ch;
            int razr = 1;
            int kol = 0;
            while (num > 0 && kol < n)
            {
                ch = Math.Truncate(num * s);
                otv = otv + ch / ((long)(Math.Pow(10, razr)));
                razr++;
                num = num * s - ch;
                kol++;
            }

            return otv;
        }

        private static decimal oper_ost(decimal num, int s)             // Перевод остатка введённого числа в 10 с.с.
        {
            decimal otv = 0;
            int step= 1;

            while (num % 1 != 0)
            {
                decimal ch = Math.Truncate(num * 10);
                otv = otv + ch * 1/(Convert.ToDecimal((long)Math.Pow(s, step)));
                step++;
                num = num * 10 - ch;
            }
            return otv;
        }
           
        private static long oper(long num, int s)                        // Перевод челой части введённого числа в 10 с.с.
        {
            long otv = 0;
            int step = 0;

            while (num > 0)
            {
                long ch = num % 10;
                otv = otv + ch * (long)Math.Pow(s, step);
                num = num / 10;
                step++;
            }
            return otv;
        }
              

        private void ss_select_ValueChanged(object sender, EventArgs e)
        {
            inputNum.Text = "";
            outputNum.Text = "...";
        }

        private void inputNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int ss = Convert.ToInt32(ss_select.Value);
            bool ind = false;

            if (Char.IsDigit(ch))                                           // Проверка введённого символа, в зависимости от с.с.
            {
                int ct = Convert.ToInt32(ch);
                for (int i = 48; i < ss + 48; i++)
                {
                    if (ct == i)
                    {
                        ind = true;
                    }
                }
                if (ind == false)
                {
                    e.Handled = true;
                }
            }
            else if (ch != 8 && ch != 44)
            {
                e.Handled = true;
            }

            if (ch == 0x0D)
            {
                mainOper();
            }
        }

        private void inputNum_TextChanged(object sender, EventArgs e)
        {
            mainOper();
            if (inputNum.Text == "")
            {
                outputNum.Text = "...";
            }
        }

        private void ss_select_out_ValueChanged(object sender, EventArgs e)
        {
            outputNum.Text = "...";
        }

        private void kol_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            if (ch == 0x0D)
            {
                mainOper();
            }
        }

        private void kol_input_TextChanged(object sender, EventArgs e)
        {
            if (kol_input.Text != "")
            {
                if (Convert.ToInt32(kol_input.Text) > 16)
                {
                    kol_input.Text = "16";
                }
            }
            else
            {
                kol_input.Text = "16";
            }
        }
    }
}
