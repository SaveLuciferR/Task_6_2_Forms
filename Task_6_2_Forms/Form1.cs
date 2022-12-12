using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6_2_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				string[] str = textBox3.Text.Split(' ');

				textBox2.Text = "";
				double[] mas;
				int n = Convert.ToInt32(textBox1.Text);

				if (str.Length != n)
				{
					throw new Exception();
				}

				if (n < 1) throw new Exception();
				mas = new double[n];
				Random r = new Random();

				for (int i = 0; i < n; i++)
				{
					mas[i] = Convert.ToDouble(str[i]);
				}

				textBox2.Text += "Исходный массив\r\n";
				int index = 0;
				double max = mas[0];
				textBox2.Text += String.Format("{0}\t", mas[0]);
				for (int i = 1; i < n; i++)
				{
					textBox2.Text += String.Format("{0}\t", mas[i]);
					if (max <= mas[i])
					{
						max = mas[i];
						index = i;
					}
				}

				textBox2.Text += String.Format("\r\nНомер последнего максимального значения: {0}", index);
			}
			catch (FormatException)
			{
				textBox2.Text = ("Введены некорректные значения");
			}
			catch
			{
				textBox2.Text = ("Размер массива должен быть больше 0. Кол-во элементов массива должно быть столько же, сколько и его размер.");
			}
		}
	}
}
