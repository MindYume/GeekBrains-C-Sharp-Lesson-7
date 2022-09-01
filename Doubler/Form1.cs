using System;
using System.Windows.Forms;

namespace Doubler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartMainMenu();
        }

        public void StartMainMenu()
        {
            tabControl1.SelectTab(0);
        }

        public void StartDoubler()
        {
            tabControl1.SelectTab(1);
            DoublerClass.StartGame(ref labelComputerNumber, ref labelCurrentNumber, ref labelSteps);
        }

        public void StartGuessTheNumber()
        {
            tabControl1.SelectTab(2);
            GuessTheNumberClass.StartGame(ref textBoxPlayerNumber, ref labelOutput);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartGuessTheNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartDoubler();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StartMainMenu();
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            StartDoubler();
        }

        private void Double_Click(object sender, EventArgs e)
        {
            DoublerClass.Double(ref labelCurrentNumber, ref labelSteps);
            DoublerClass.CheckWin(this, ref labelComputerNumber, ref labelCurrentNumber, ref labelSteps);
        }

        private void PlusOne_Click(object sender, EventArgs e)
        {
            DoublerClass.PlusOne(ref labelCurrentNumber, ref labelSteps);
            DoublerClass.CheckWin(this, ref labelComputerNumber, ref labelCurrentNumber, ref labelSteps);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            DoublerClass.Back(ref labelCurrentNumber, ref labelSteps);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GuessTheNumberClass.CheckNumber(this, ref textBoxPlayerNumber, ref labelOutput);
        }
    }
}
