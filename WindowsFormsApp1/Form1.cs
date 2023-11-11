using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void roundBtn1_Click(object sender, EventArgs e)
        {
            label2.Text = "Вы выбрали завтрак, ожидайте 10 минут";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roundBtn2_Click(object sender, EventArgs e)
        {
            label2.Text = "Вы выбрали обед, ожидайте 20 минут";
        }

        private void roundBtn3_Click(object sender, EventArgs e)
        {
            label2.Text = "Вы выбрали ужин, ожидайте 15 минут";
        }

        private void roundBtn4_Click(object sender, EventArgs e)
        {
            label2.Text = "Чай, кофе или звкуски в следующем меню";
        }

        private void roundBtn1_Click_1(object sender, EventArgs e)
        {
            label2.Text = "Вы выбрали завтрак, ожидайте 10 минут";
        }
    }
}
