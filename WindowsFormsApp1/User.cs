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

namespace WindowsFormsApp1
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        private void Search_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-CTEHH5B\\SQLEXPRESS;Initial Catalog=Zarplata;Integrated Security=True;Encrypt=False";
            string fam = Familiya.Text;
            string im = Imya.Text;
            string otch = Otchestvo.Text;
            string role = RolesList.SelectedItem?.ToString() ?? "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Employee WHERE Фамилия = @Фамилия AND Имя = @Имя AND Отчество = @Отчество AND Должность = @Должность";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Фамилия", fam);
                    command.Parameters.AddWithValue("@Имя", im);
                    command.Parameters.AddWithValue("@Отчество", otch);
                    command.Parameters.AddWithValue("@Должность", role);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewEmployees.DataSource = table;
                }
            }
        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            string fam = Familiya.Text;
            string im = Imya.Text;
            string otch = Otchestvo.Text;

            // Проверка ввода основной зарплаты, премии и количества дней
            if (!decimal.TryParse(BaseSalary.Text, out decimal baseSalary))
            {
                MessageBox.Show("Введите корректную основную зарплату.");
                return;
            }
            if (!decimal.TryParse(Premiya.Text, out decimal premiya))
            {
                MessageBox.Show("Введите корректную сумму премии.");
                return;
            }
            if (!int.TryParse(DaysOff.Text, out int daysOff))
            {
                MessageBox.Show("Введите корректное количество отработанных дней.");
                return;
            }

            // Расчет дневной зарплаты
            decimal dailySalary = baseSalary / 30; // Предполагаем, что базовая зарплата за 30 дней

            // Расчет итоговой зарплаты
            decimal finalSalary = CalculateFinalSalary(dailySalary, premiya, daysOff);

            // Расчет отпускных дней
            int vacationDays = CalculateVacationDays(daysOff);

            // Расчет аванса
            decimal advance = CalculateAdvance(dailySalary, daysOff);

            // Отображение результатов
            labelFinalSalary.Text = $"Конечная зарплата: {finalSalary:C2}";
            labelVacationDays.Text = $"Отпускные дни: {vacationDays}";
            labelAdvance.Text = $"Аванс: {advance:C2}";
        }
        private decimal CalculateFinalSalary(decimal dailySalary, decimal premiya, int daysOff)
        {
            // Общая зарплата за отработанные дни
            decimal salaryForDays = dailySalary * daysOff;
            return salaryForDays + premiya;
        }
        private int CalculateVacationDays(int daysOff)
        {
            // Допустим, что за каждый отработанный день полагается 0.1 отпускного дня
            return (int)(daysOff * 0.1);
        }
        private decimal CalculateAdvance(decimal dailySalary, int daysOff)
        {
            // Допустим, что аванс составляет 50% от зарплаты за отработанные дни
            return (dailySalary * daysOff) * 0.5m;
        }
        public class RoleItem
        {
            public string Role { get; }
            public decimal BaseSalary { get; }

            public RoleItem(string role, decimal baseSalary)
            {
                Role = role;
                BaseSalary = baseSalary;
            }

            public override string ToString()
            {
                return Role;
            }
        }
        private void RolesList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (RolesList.Text)
            {
                case "Менеджер":
                    BaseSalary.Text = "70000";
                    break;
                case "Инженер":
                    BaseSalary.Text = "80000";
                    break;
                case "Бухгалтер":
                    BaseSalary.Text = "60000";
                    break;
                case "Программист":
                    BaseSalary.Text = "100000";
                    break;
                case "Аналитик":
                    BaseSalary.Text = "90000";
                    break;
                case "Тестировщик":
                    BaseSalary.Text = "70000";
                    break;
                case "HR-специалист":
                    BaseSalary.Text = "50000";
                    break;
                case "Дизайнер":
                    BaseSalary.Text = "75000";
                    break;
                case "Системный администратор":
                    BaseSalary.Text = "85000";
                    break;
                case "Маркетолог":
                    BaseSalary.Text = "65000";
                    break;
                default:
                    BaseSalary.Text = "";
                    break;
            }
        }
    }
    }

