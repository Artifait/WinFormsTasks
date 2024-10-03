using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using UniversalDBConnection;
using Microsoft.Extensions.Configuration;

namespace WinFormsTasks
{
    public partial class Form1 : Form
    {
        private PointDB _db;

        public Form1()
        {
            InitializeComponent();
            LoadProviders();
        }

        private void LoadProviders()
        {
            DataTable providers = DbProviderFactories.GetFactoryClasses();
            Provieders.Items.Clear();
            foreach (DataRow row in providers.Rows)
            {
                Provieders.Items.Add(row["InvariantName"]);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Получаем строку подключения из конфигурации
                string selectedProvider = Provieders.SelectedItem.ToString();
                string connectionString = Program.Configuration.GetConnectionString(comboBox2.SelectedItem.ToString());

                _db = new PointDB(selectedProvider, connectionString);
                _db.OpenConnection();
                MessageBox.Show("Подключение успешно установлено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = QueryInputer.Text;
                DataTable result = _db.ExecuteQuery(query);

                View.DataSource = null;
                View.DataSource = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _db.UpdateData();
                MessageBox.Show("Данные успешно обновлены в базе данных.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка обновления данных: {ex.Message}");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _db?.CloseConnection();
        }

        private void Providers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProvider = Provieders.SelectedItem.ToString();
            comboBox2.Items.Clear();

            var connectionStrings = Program.Configuration.GetSection("ConnectionStrings").GetChildren();
            foreach (var connectionString in connectionStrings)
            {
                comboBox2.Items.Add(connectionString.Key);
            }
        }
    }
}
