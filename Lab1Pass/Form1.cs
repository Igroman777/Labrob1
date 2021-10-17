using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1Pass
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Input_Click(object sender, EventArgs e)
        {


            if (Login.Text == "Igor" && Password.Text == "0000")
            {
                Login.BackColor = Color.Green;
                Password.BackColor = Color.Green;
                MessageBox.Show("Вхід виконано");
            }
            else
            {
                Login.BackColor = Color.Red;
                Password.BackColor = Color.Red;
                MessageBox.Show("Невірний логін або пароль!");
            }
        }
    }
}
