using System;
using System.Data.Common;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace WinFormsTasks
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; private set; }

        /// <summary> 
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Создаем конфигурацию, которая будет загружать настройки из appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath("D:\\ArturMorozov\\GitHub\\WinFormsTasks\\") // Устанавливаем путь к текущему каталогу
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true); // Добавляем appsettings.json

            Configuration = builder.Build(); // Создаем объект конфигурации

            DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory("System.Data.*Odbc*", "System.Data.Odbc.OdbcFactory, System.Data.Odbc");
            // Инициализация конфигурации приложения (для DPI и шрифтов)
            ApplicationConfiguration.Initialize();

            // Запуск формы
            Application.Run(new Form1());
        }
    }
}
