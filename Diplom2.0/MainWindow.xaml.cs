using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Diplom2._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonMigr_Click(object sender, RoutedEventArgs e)
        {
            string connString = $"Host={AdressPGSql.Text};Username={LoginPGSql.Text};Password={PasswordPGSql.Text};Database={NameBasePGSql.Text}";
            NpgsqlConnection nc = new NpgsqlConnection(connString);
            try
            {
                nc.Open();
                var InstalComand="pip install py-mysql2pgsql";
                var ReadComand="py-mysql2pgsql";
                var MigrationScriptBD=$"mysql:" +
                    $"hostname: localhost" +
                    $"port: 3306" +
                    //$"socket: / var / run / mysqld / mysqld.sock " +
                    $"username: username" +
                    $"password: secret" +
                    $"database: source_db" +
                    $"compress: false" +
                    $"destination: if file is given, output goes to file, else postgres" +
                    $"file: pg_dump.sql " +
                    $"postgres:" +
                    $" hostname: localhost" +
                    $"port: 5432" +
                    $"username: username" +
                    $"password: secret" +
                    $"database: destination_db";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}" + "Залупа");
            }
        }
    }
}
