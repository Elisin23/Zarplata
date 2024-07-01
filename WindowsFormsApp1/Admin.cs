using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        string connectionString = @"Data Source=DESKTOP-CTEHH5B\SQLEXPRESS;Initial Catalog=Zarplata;Integrated Security=True;Encrypt=False";
        public Admin()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void RolesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (RolesList.Text)
            {
                case "Менеджер":
                    Salary.Text = "70000";
                    break;
                case "Инженер":
                    Salary.Text = "80000";
                    break;
                case "Бухгалтер":
                    Salary.Text = "60000";
                    break;
                case "Программист":
                    Salary.Text = "100000";
                    break;
                case "Аналитик":
                    Salary.Text = "90000";
                    break;
                case "Тестировщик":
                    Salary.Text = "70000";
                    break;
                case "HR-специалист":
                    Salary.Text = "50000";
                    break;
                case "Дизайнер":
                    Salary.Text = "75000";
                    break;
                case "Системный администратор":
                    Salary.Text = "85000";
                    break;
                case "Маркетолог":
                    Salary.Text = "65000";
                    break;
                default:
                    Salary.Text = "";
                    break;
            }
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            string familiya = Familiya.Text;
            string imya = Imya.Text;
            string otchestvo = Otchestvo.Text;
            string role = RolesList.SelectedItem.ToString();
            decimal zarplata;

            if (!decimal.TryParse(Salary.Text, out zarplata))
            {
                MessageBox.Show("Введите правильное значение для зарплаты.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Строка подключения к базе данных
            string connectionString = "Data Source=DESKTOP-CTEHH5B\\SQLEXPRESS;Initial Catalog=Zarplata;Integrated Security=True;Encrypt=False";

            // SQL запрос для вставки данных
            string query = "INSERT INTO Employee (Фамилия, Имя, Отчество, Должность, Зарплата) VALUES (@familiya, @imya, @otchestvo, @role, @zarplata)";

            // Подключение к базе данных и выполнение запроса
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Параметры для предотвращения SQL-инъекций
                    command.Parameters.AddWithValue("@familiya", familiya);
                    command.Parameters.AddWithValue("@imya", imya);
                    command.Parameters.AddWithValue("@otchestvo", otchestvo);
                    command.Parameters.AddWithValue("@role", role);
                    command.Parameters.AddWithValue("@zarplata", zarplata);

                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Проверка на успешное выполнение команды
                        if (result > 0)
                        {
                            MessageBox.Show("Сотрудник успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Не удалось добавить сотрудника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при подключении к базе данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void ClearFields()
        {
            Familiya.Clear();
            Imya.Clear();
            Otchestvo.Clear();
            Salary.Clear();
            RolesList.SelectedIndex = -1;
        }
        private void Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employee";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        // Открываем подключение и создаем адаптер данных
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Заполняем таблицу данными из базы данных
                        adapter.Fill(dataTable);

                        // Привязываем таблицу к элементу управления DataGridView
                        dataGridViewEmployees.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
                    }
                }
            }
        }
    }
}
