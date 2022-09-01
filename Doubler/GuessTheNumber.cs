using System;
using System.Windows.Forms;

namespace Doubler
{
    public static class GuessTheNumberClass
    {
        private static int computerNumber;

        public static void StartGame(ref TextBox playerNumber, ref Label labelOutput)
        {
            Random random = new Random();
            computerNumber = random.Next(1, 101);

            labelOutput.Text = "Компьютер загадал число от 1 до 100\nУгадайте это число";
            playerNumber.Text = "0";
        }


        public static void CheckNumber(Form form,ref TextBox playerNumber, ref Label labelOutput)
        {
            int PlayerNumberInt;

            if (!int.TryParse(playerNumber.Text, out PlayerNumberInt))
            {
                labelOutput.Text = "Вы некорректно ввели чилсо\nПопробуйте ещё раз";
                return;
            }

            if (computerNumber == PlayerNumberInt)
            {
                labelOutput.Text = "Вы угадали число!";
                DialogResult dialogResult = MessageBox.Show(
                    $"Вы угадали число!\nЖелаете сыграть ещё раз?",
                    "Угадай число",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (dialogResult == DialogResult.Yes)
                {
                    StartGame(ref playerNumber, ref labelOutput);
                }
                else
                    form.Close();
            }
            else 
            {
                if (computerNumber > PlayerNumberInt)
                {
                    labelOutput.Text = "Число должно быть больше\nПопробуйте ещё раз";
                    MessageBox.Show($"Число должно быть больше\nПопробуйте ещё раз", "Угадай число", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    labelOutput.Text = "Число должно быть меньше\nПопробуйте ещё раз";
                    MessageBox.Show($"Число должно быть меньше\nПопробуйте ещё раз", "Угадай число", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
    }
}
