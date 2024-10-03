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
            // ������� ������������, ������� ����� ��������� ��������� �� appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath("D:\\ArturMorozov\\GitHub\\WinFormsTasks\\") // ������������� ���� � �������� ��������
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true); // ��������� appsettings.json

            Configuration = builder.Build(); // ������� ������ ������������

            DbProviderFactories.RegisterFactory("System.Data.SqlClient", SqlClientFactory.Instance);
            DbProviderFactories.RegisterFactory("System.Data.*Odbc*", "System.Data.Odbc.OdbcFactory, System.Data.Odbc");
            // ������������� ������������ ���������� (��� DPI � �������)
            ApplicationConfiguration.Initialize();

            // ������ �����
            Application.Run(new Form1());
        }
    }
}
