namespace WindowsFormsApp1
{
    partial class Admin
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.Familiya = new System.Windows.Forms.TextBox();
            this.Otchestvo = new System.Windows.Forms.TextBox();
            this.Imya = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RolesList = new System.Windows.Forms.ComboBox();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Зарплата = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(842, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(33, 25);
            this.Exit.TabIndex = 27;
            this.Exit.Text = "X";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(78, 63);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(750, 149);
            this.dataGridViewEmployees.TabIndex = 28;
            // 
            // Familiya
            // 
            this.Familiya.BackColor = System.Drawing.Color.Silver;
            this.Familiya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Familiya.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Familiya.ForeColor = System.Drawing.Color.Black;
            this.Familiya.Location = new System.Drawing.Point(78, 303);
            this.Familiya.Margin = new System.Windows.Forms.Padding(4);
            this.Familiya.Name = "Familiya";
            this.Familiya.Size = new System.Drawing.Size(185, 24);
            this.Familiya.TabIndex = 29;
            // 
            // Otchestvo
            // 
            this.Otchestvo.BackColor = System.Drawing.Color.Silver;
            this.Otchestvo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Otchestvo.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Otchestvo.ForeColor = System.Drawing.Color.Black;
            this.Otchestvo.Location = new System.Drawing.Point(571, 303);
            this.Otchestvo.Margin = new System.Windows.Forms.Padding(4);
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(257, 24);
            this.Otchestvo.TabIndex = 30;
            // 
            // Imya
            // 
            this.Imya.BackColor = System.Drawing.Color.Silver;
            this.Imya.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Imya.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Imya.ForeColor = System.Drawing.Color.Black;
            this.Imya.Location = new System.Drawing.Point(348, 303);
            this.Imya.Margin = new System.Windows.Forms.Padding(4);
            this.Imya.Name = "Imya";
            this.Imya.Size = new System.Drawing.Size(188, 24);
            this.Imya.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 48);
            this.label1.TabIndex = 32;
            this.label1.Text = "Администрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(72, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(343, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 34;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(566, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(73, 342);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 29);
            this.label5.TabIndex = 36;
            this.label5.Text = "Должность";
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
            this.RolesList.Location = new System.Drawing.Point(78, 374);
            this.RolesList.Name = "RolesList";
            this.RolesList.Size = new System.Drawing.Size(185, 21);
            this.RolesList.TabIndex = 37;
            this.RolesList.SelectedIndexChanged += new System.EventHandler(this.RolesList_SelectedIndexChanged);
            // 
            // AddEmployee
            // 
            this.AddEmployee.BackColor = System.Drawing.Color.IndianRed;
            this.AddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddEmployee.FlatAppearance.BorderSize = 0;
            this.AddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEmployee.ForeColor = System.Drawing.Color.White;
            this.AddEmployee.Location = new System.Drawing.Point(78, 413);
            this.AddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(185, 35);
            this.AddEmployee.TabIndex = 38;
            this.AddEmployee.Text = "Добавить";
            this.AddEmployee.UseVisualStyleBackColor = false;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
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
            this.Search.Location = new System.Drawing.Point(348, 219);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(188, 35);
            this.Search.TabIndex = 39;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Зарплата
            // 
            this.Зарплата.AutoSize = true;
            this.Зарплата.BackColor = System.Drawing.Color.Transparent;
            this.Зарплата.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Зарплата.ForeColor = System.Drawing.Color.IndianRed;
            this.Зарплата.Location = new System.Drawing.Point(343, 341);
            this.Зарплата.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Зарплата.Name = "Зарплата";
            this.Зарплата.Size = new System.Drawing.Size(193, 29);
            this.Зарплата.TabIndex = 40;
            this.Зарплата.Text = "Основная зарплата";
            // 
            // Salary
            // 
            this.Salary.BackColor = System.Drawing.Color.Silver;
            this.Salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Salary.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Salary.ForeColor = System.Drawing.Color.Black;
            this.Salary.Location = new System.Drawing.Point(348, 374);
            this.Salary.Margin = new System.Windows.Forms.Padding(4);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(188, 24);
            this.Salary.TabIndex = 41;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 510);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Зарплата);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.RolesList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Imya);
            this.Controls.Add(this.Otchestvo);
            this.Controls.Add(this.Familiya);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.TextBox Familiya;
        private System.Windows.Forms.TextBox Otchestvo;
        private System.Windows.Forms.TextBox Imya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RolesList;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label Зарплата;
        private System.Windows.Forms.TextBox Salary;
    }
}