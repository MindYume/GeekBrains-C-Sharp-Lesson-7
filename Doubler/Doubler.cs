using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Doubler
{
    public static class DoublerClass
    {
        private static int computerNumber;
        private static int currentNumber;
        private static int clicksAmount;
        private static Stack<int> steps = new Stack<int>();

        public static int ComputerNumber
        {
            get { return computerNumber; }
        }

        public static void StartGame(ref Label labelComputerNumber, ref Label labelCurrentNumber, ref Label labelSteps)
        {
            Random random = new Random();
            computerNumber = random.Next(10, 101);
            currentNumber = 0;
            clicksAmount = 0;
            steps.Clear();
            steps.Push(0);

            labelCurrentNumber.Text = "Текущее число: 0";
            labelComputerNumber.Text = $"Получите число: {computerNumber}";
            labelSteps.Text = $"Количество ходов: {clicksAmount}";
            MessageBox.Show($"Компьютер загадал число {computerNumber}", "Удвоитель", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void CheckWin(Form form, ref Label labelComputerNumber, ref Label labelCurrentNumber, ref Label labelSteps)
        {
            if (currentNumber == computerNumber)
            {
                DialogResult newGame = MessageBox.Show(
                    $"Вы победили!\nЖелаете сыгать ещё раз?",
                    "Удвоитель",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (newGame == DialogResult.Yes)
                {
                    StartGame(ref labelComputerNumber, ref labelCurrentNumber, ref labelSteps);
                }
                else
                    form.Close();
            }
            else if (currentNumber > computerNumber)
            {
                DialogResult newGame = MessageBox.Show(
                    $"Вы проиграли!\nЖелаете сыгать ещё раз?",
                    "Удвоитель",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (newGame == DialogResult.Yes)
                {
                    StartGame(ref labelComputerNumber, ref labelCurrentNumber, ref labelSteps);
                }
                else
                    form.Close();
            }
        }

        public static void Double(ref Label labelComputerNumber, ref Label labelSteps)
        {
            currentNumber *= 2;
            labelComputerNumber.Text = $"Текущее число: {currentNumber}";
            clicksAmount++;
            steps.Push(currentNumber);
            labelSteps.Text = $"Количество ходов: {clicksAmount}";
        }

        public static void PlusOne(ref Label labelComputerNumber, ref Label labelSteps)
        {
            currentNumber++;
            labelComputerNumber.Text = $"Текущее число: {currentNumber}";
            clicksAmount++;
            steps.Push(currentNumber);
            labelSteps.Text = $"Количество ходов: {clicksAmount}";
        }

        public static void Back(ref Label labelComputerNumber, ref Label labelSteps)
        {
            if (steps.Peek() != 0)
            {
                steps.Pop();
                currentNumber = steps.Peek();
                clicksAmount--;
                labelComputerNumber.Text = $"Текущее число: {steps.Peek()}";
                labelSteps.Text = $"Количество ходов: {clicksAmount}";
            }
            else 
            {
                DialogResult newGame = MessageBox.Show(
                    $"Вы не можете отменить ход в начале игры",
                    "Удвоитель",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
