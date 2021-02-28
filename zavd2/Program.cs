using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace zavd2
{
    class Program
    {
        static bool InputDouble(ref double a, string b)
        {
            string s;
            Povtor:
            s = Interaction.InputBox(b, "Introduction", a.ToString());
            try
            {
                a = Convert.ToDouble(s);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("You did not enter a number \nDo you want to repeat?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    goto Povtor;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static bool InputInt(ref int a, string b)
        {
            string s;
            Povtor:
            s = Interaction.InputBox(b, "Introduction", a.ToString());
            try
            {
                a = Convert.ToInt32(s);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("You did not enter a number \nDo you want to repeat?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    goto Povtor;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int n = 5;
            int k = 0;
            double a = 2;

            Povtor:
            if (!InputInt(ref n, "Write n for array size: ")) return;
            if (!InputDouble(ref a, "Write a for index in array: ")) return;

            double[] array = new double[n];
            string rez = "";

            rez += "array 1:\n";

            for (int i = 0; i < n; i++)
            {
                if (!InputDouble(ref array[i], $"Write {i} element:")) return;
                rez += $"array[{i}] = {array[i]}\n";

                if (a == i) k = 1;
            }

            if (k == 0) a = 5;

            rez += "\narray 2:\n";

            for (int j = 0; j < n; j++)
            {
                if (array[j] % 2 == 0) array[j] = array[j] / a;
                rez += $"array[{j}] = {array[j]}\n";
            }

            if (MessageBox.Show($"rezultat:\n{rez} \nDo you want to repeat?", "rezultat", MessageBoxButtons.YesNo) == DialogResult.Yes)
                goto Povtor;
        }
    }
}