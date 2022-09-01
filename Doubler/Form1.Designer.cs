namespace Doubler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button5 = new System.Windows.Forms.Button();
            this.labelComputerNumber = new System.Windows.Forms.Label();
            this.labelCurrentNumber = new System.Windows.Forms.Label();
            this.NewGame = new System.Windows.Forms.Button();
            this.Double = new System.Windows.Forms.Button();
            this.PlusOne = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.labelSteps = new System.Windows.Forms.Label();
            this.PlayGuessTheNumber = new System.Windows.Forms.Button();
            this.PlayDoubler = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.EnterTheNumber = new System.Windows.Forms.Button();
            this.labelEnterNumber = new System.Windows.Forms.Label();
            this.textBoxPlayerNumber = new System.Windows.Forms.TextBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 67);
            this.button5.TabIndex = 1;
            this.button5.Text = "Вернуться в Главное меню";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelComputerNumber
            // 
            this.labelComputerNumber.AutoSize = true;
            this.labelComputerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerNumber.Location = new System.Drawing.Point(22, 92);
            this.labelComputerNumber.Name = "labelComputerNumber";
            this.labelComputerNumber.Size = new System.Drawing.Size(174, 25);
            this.labelComputerNumber.TabIndex = 2;
            this.labelComputerNumber.Text = "Получите число: ";
            // 
            // labelCurrentNumber
            // 
            this.labelCurrentNumber.AutoSize = true;
            this.labelCurrentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentNumber.Location = new System.Drawing.Point(22, 137);
            this.labelCurrentNumber.Name = "labelCurrentNumber";
            this.labelCurrentNumber.Size = new System.Drawing.Size(164, 25);
            this.labelCurrentNumber.TabIndex = 3;
            this.labelCurrentNumber.Text = "Текущее число: ";
            // 
            // NewGame
            // 
            this.NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.Location = new System.Drawing.Point(315, 28);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(125, 59);
            this.NewGame.TabIndex = 4;
            this.NewGame.Text = "Новая игра";
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Double
            // 
            this.Double.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Double.Location = new System.Drawing.Point(315, 104);
            this.Double.Name = "Double";
            this.Double.Size = new System.Drawing.Size(125, 59);
            this.Double.TabIndex = 5;
            this.Double.Text = "x2";
            this.Double.UseVisualStyleBackColor = true;
            this.Double.Click += new System.EventHandler(this.Double_Click);
            // 
            // PlusOne
            // 
            this.PlusOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusOne.Location = new System.Drawing.Point(315, 169);
            this.PlusOne.Name = "PlusOne";
            this.PlusOne.Size = new System.Drawing.Size(125, 59);
            this.PlusOne.TabIndex = 6;
            this.PlusOne.Text = "+1";
            this.PlusOne.UseVisualStyleBackColor = true;
            this.PlusOne.Click += new System.EventHandler(this.PlusOne_Click);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(315, 234);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(125, 59);
            this.Back.TabIndex = 7;
            this.Back.Text = "Отменить";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSteps.Location = new System.Drawing.Point(22, 182);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(188, 25);
            this.labelSteps.TabIndex = 8;
            this.labelSteps.Text = "Количество ходов:";
            // 
            // PlayGuessTheNumber
            // 
            this.PlayGuessTheNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGuessTheNumber.Location = new System.Drawing.Point(135, 122);
            this.PlayGuessTheNumber.Name = "PlayGuessTheNumber";
            this.PlayGuessTheNumber.Size = new System.Drawing.Size(175, 56);
            this.PlayGuessTheNumber.TabIndex = 1;
            this.PlayGuessTheNumber.Text = "Играть в Угадай число";
            this.PlayGuessTheNumber.UseVisualStyleBackColor = true;
            this.PlayGuessTheNumber.Click += new System.EventHandler(this.button3_Click);
            // 
            // PlayDoubler
            // 
            this.PlayDoubler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayDoubler.ForeColor = System.Drawing.Color.Black;
            this.PlayDoubler.Location = new System.Drawing.Point(135, 26);
            this.PlayDoubler.Name = "PlayDoubler";
            this.PlayDoubler.Size = new System.Drawing.Size(175, 62);
            this.PlayDoubler.TabIndex = 0;
            this.PlayDoubler.Text = "Играть в Удворитель";
            this.PlayDoubler.UseVisualStyleBackColor = true;
            this.PlayDoubler.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(149, 214);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(150, 50);
            this.Exit.TabIndex = 2;
            this.Exit.TabStop = false;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Студент: Грачёв Виктор Алексеевич";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(482, 358);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.ForestGreen;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.PlayGuessTheNumber);
            this.tabPage1.Controls.Add(this.Exit);
            this.tabPage1.Controls.Add(this.PlayDoubler);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(474, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.ForestGreen;
            this.tabPage2.Controls.Add(this.Back);
            this.tabPage2.Controls.Add(this.labelSteps);
            this.tabPage2.Controls.Add(this.PlusOne);
            this.tabPage2.Controls.Add(this.Double);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.NewGame);
            this.tabPage2.Controls.Add(this.labelComputerNumber);
            this.tabPage2.Controls.Add(this.labelCurrentNumber);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(474, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.ForestGreen;
            this.tabPage3.Controls.Add(this.labelOutput);
            this.tabPage3.Controls.Add(this.EnterTheNumber);
            this.tabPage3.Controls.Add(this.labelEnterNumber);
            this.tabPage3.Controls.Add(this.textBoxPlayerNumber);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(474, 332);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // EnterTheNumber
            // 
            this.EnterTheNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterTheNumber.Location = new System.Drawing.Point(270, 163);
            this.EnterTheNumber.Name = "EnterTheNumber";
            this.EnterTheNumber.Size = new System.Drawing.Size(53, 30);
            this.EnterTheNumber.TabIndex = 5;
            this.EnterTheNumber.Text = "Enter";
            this.EnterTheNumber.UseVisualStyleBackColor = true;
            this.EnterTheNumber.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelEnterNumber
            // 
            this.labelEnterNumber.AutoSize = true;
            this.labelEnterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterNumber.Location = new System.Drawing.Point(159, 135);
            this.labelEnterNumber.Name = "labelEnterNumber";
            this.labelEnterNumber.Size = new System.Drawing.Size(151, 25);
            this.labelEnterNumber.TabIndex = 4;
            this.labelEnterNumber.Text = "Введите число";
            // 
            // textBoxPlayerNumber
            // 
            this.textBoxPlayerNumber.Location = new System.Drawing.Point(164, 169);
            this.textBoxPlayerNumber.Name = "textBoxPlayerNumber";
            this.textBoxPlayerNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerNumber.TabIndex = 3;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.Location = new System.Drawing.Point(81, 15);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(135, 25);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "Угадай число";
            this.labelOutput.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игры Удвоитель и Угадай число";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Label labelCurrentNumber;
        private System.Windows.Forms.Label labelComputerNumber;
        private System.Windows.Forms.Button PlusOne;
        private System.Windows.Forms.Button Double;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button PlayDoubler;
        private System.Windows.Forms.Button PlayGuessTheNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button EnterTheNumber;
        private System.Windows.Forms.Label labelEnterNumber;
        private System.Windows.Forms.TextBox textBoxPlayerNumber;
        private System.Windows.Forms.Label labelOutput;
    }
}