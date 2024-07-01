namespace WindowsFormsApp1
{
    partial class User
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
            this.Exit = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.RolesList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Imya = new System.Windows.Forms.TextBox();
            this.Otchestvo = new System.Windows.Forms.TextBox();
            this.Familiya = new System.Windows.Forms.TextBox();
            this.DaysOff = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Premiya = new System.Windows.Forms.TextBox();
            this.labelFinalSalary = new System.Windows.Forms.Label();
            this.labelVacationDays = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BaseSalary = new System.Windows.Forms.TextBox();
            this.labelAdvance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(755, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(33, 25);
            this.Exit.TabIndex = 27;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.IndianRed;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(28, 408);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(189, 35);
            this.Search.TabIndex = 43;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 48);
            this.label1.TabIndex = 42;
            this.label1.Text = "Пользователь";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(27, 63);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(750, 149);
            this.dataGridViewEmployees.TabIndex = 41;
            // 
            // RolesList
            // 
            this.RolesList.FormattingEnabled = true;
            this.RolesList.Items.AddRange(new object[] {
            "Менеджер",
            "Инженер",
            "Бухгалтер",
            "Программист",
            "Аналитик",
            "Тестировщик",
            "HR-специалист",
            "Дизайнер",
            "Системный администратор",
            "Маркетолог"});
            this.RolesList.Location = new System.Drawing.Point(28, 308);
            this.RolesList.Name = "RolesList";
            this.RolesList.Size = new System.Drawing.Size(189, 21);
            this.RolesList.TabIndex = 51;
            this.RolesList.SelectedIndexChanged += new System.EventHandler(this.RolesList_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(23, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 29);
            this.label5.TabIndex = 50;
            this.label5.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(516, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 49;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(271, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 48;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(22, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 47;
            this.label2.Text = "Фамилия";
            // 
            // Imya
            // 
            this.Imya.BackColor = System.Drawing.Color.Silver;
            this.Imya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Imya.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Imya.ForeColor = System.Drawing.Color.Black;
            this.Imya.Location = new System.Drawing.Point(276, 248);
            this.Imya.Margin = new System.Windows.Forms.Padding(4);
            this.Imya.Name = "Imya";
            this.Imya.Size = new System.Drawing.Size(195, 24);
            this.Imya.TabIndex = 46;
            // 
            // Otchestvo
            // 
            this.Otchestvo.BackColor = System.Drawing.Color.Silver;
            this.Otchestvo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Otchestvo.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Otchestvo.ForeColor = System.Drawing.Color.Black;
            this.Otchestvo.Location = new System.Drawing.Point(521, 248);
            this.Otchestvo.Margin = new System.Windows.Forms.Padding(4);
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(257, 24);
            this.Otchestvo.TabIndex = 45;
            // 
            // Familiya
            // 
            this.Familiya.BackColor = System.Drawing.Color.Silver;
            this.Familiya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Familiya.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Familiya.ForeColor = System.Drawing.Color.Black;
            this.Familiya.Location = new System.Drawing.Point(28, 248);
            this.Familiya.Margin = new System.Windows.Forms.Padding(4);
            this.Familiya.Name = "Familiya";
            this.Familiya.Size = new System.Drawing.Size(189, 24);
            this.Familiya.TabIndex = 44;
            // 
            // DaysOff
            // 
            this.DaysOff.BackColor = System.Drawing.Color.Silver;
            this.DaysOff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DaysOff.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DaysOff.ForeColor = System.Drawing.Color.Black;
            this.DaysOff.Location = new System.Drawing.Point(276, 305);
            this.DaysOff.Margin = new System.Windows.Forms.Padding(4);
            this.DaysOff.Name = "DaysOff";
            this.DaysOff.Size = new System.Drawing.Size(195, 24);
            this.DaysOff.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(271, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 29);
            this.label6.TabIndex = 53;
            this.label6.Text = "Кол-во дней";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(271, 342);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 29);
            this.label7.TabIndex = 55;
            this.label7.Text = "Конечная зарплата :";
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.IndianRed;
            this.Calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calculate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Calculate.FlatAppearance.BorderSize = 0;
            this.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.ForeColor = System.Drawing.Color.White;
            this.Calculate.Location = new System.Drawing.Point(521, 408);
            this.Calculate.Margin = new System.Windows.Forms.Padding(4);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(257, 35);
            this.Calculate.TabIndex = 56;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(516, 276);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 29);
            this.label8.TabIndex = 58;
            this.label8.Text = "Премия";
            // 
            // Premiya
            // 
            this.Premiya.BackColor = System.Drawing.Color.Silver;
            this.Premiya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Premiya.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Premiya.ForeColor = System.Drawing.Color.Black;
            this.Premiya.Location = new System.Drawing.Point(521, 305);
            this.Premiya.Margin = new System.Windows.Forms.Padding(4);
            this.Premiya.Name = "Premiya";
            this.Premiya.Size = new System.Drawing.Size(256, 24);
            this.Premiya.TabIndex = 57;
            // 
            // labelFinalSalary
            // 
            this.labelFinalSalary.AutoSize = true;
            this.labelFinalSalary.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinalSalary.Location = new System.Drawing.Point(273, 381);
            this.labelFinalSalary.Name = "labelFinalSalary";
            this.labelFinalSalary.Size = new System.Drawing.Size(132, 15);
            this.labelFinalSalary.TabIndex = 59;
            this.labelFinalSalary.Text = "-------------------------";
            // 
            // labelVacationDays
            // 
            this.labelVacationDays.AutoSize = true;
            this.labelVacationDays.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVacationDays.Location = new System.Drawing.Point(273, 399);
            this.labelVacationDays.Name = "labelVacationDays";
            this.labelVacationDays.Size = new System.Drawing.Size(132, 15);
            this.labelVacationDays.TabIndex = 60;
            this.labelVacationDays.Text = "-------------------------";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.IndianRed;
            this.label9.Location = new System.Drawing.Point(22, 342);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 29);
            this.label9.TabIndex = 61;
            this.label9.Text = "Основная зарплата";
            // 
            // BaseSalary
            // 
            this.BaseSalary.BackColor = System.Drawing.Color.Silver;
            this.BaseSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BaseSalary.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BaseSalary.ForeColor = System.Drawing.Color.Black;
            this.BaseSalary.Location = new System.Drawing.Point(28, 375);
            this.BaseSalary.Margin = new System.Windows.Forms.Padding(4);
            this.BaseSalary.Name = "BaseSalary";
            this.BaseSalary.Size = new System.Drawing.Size(189, 24);
            this.BaseSalary.TabIndex = 62;
            // 
            // labelAdvance
            // 
            this.labelAdvance.AutoSize = true;
            this.labelAdvance.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdvance.Location = new System.Drawing.Point(273, 417);
            this.labelAdvance.Name = "labelAdvance";
            this.labelAdvance.Size = new System.Drawing.Size(132, 15);
            this.labelAdvance.TabIndex = 63;
            this.labelAdvance.Text = "-------------------------";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.labelAdvance);
            this.Controls.Add(this.BaseSalary);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelVacationDays);
            this.Controls.Add(this.labelFinalSalary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Premiya);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DaysOff);
            this.Controls.Add(this.RolesList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Imya);
            this.Controls.Add(this.Otchestvo);
            this.Controls.Add(this.Familiya);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.ComboBox RolesList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Imya;
        private System.Windows.Forms.TextBox Otchestvo;
        private System.Windows.Forms.TextBox Familiya;
        private System.Windows.Forms.TextBox DaysOff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Premiya;
        private System.Windows.Forms.Label labelFinalSalary;
        private System.Windows.Forms.Label labelVacationDays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BaseSalary;
        private System.Windows.Forms.Label labelAdvance;
    }
}