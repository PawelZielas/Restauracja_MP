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
using System.Windows.Shapes;
using System.Net.Mail;
using System.Text.RegularExpressions;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;

namespace Restauracja_MP
{
    /// <summary>
    /// Interaction logic for Accept_Order_Window.xaml
    /// </summary>
    public partial class Accept_Order_Window : Window
    {
       
        public void Connect()
        {
            MySqlCommand insertOrder;
            string connectionString = "server=localhost;user=root;database=restauracja;password=";
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                MessageBox.Show("Connecting to MySQL...");
                connection.Open();
                // Perform database operations

                string sql = "INSERT INTO orders (comment,email,price) VALUES ({0})";
                MySqlCommand command = new MySqlCommand(sql,connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
               MessageBox.Show("Błąd połączenia.");
            }
            connection.Close();
            MessageBox.Show("Done.");
        }
    

        public void SendEmail (string email, string comment)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.wp.pl";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("pawel.mezczyzna.q@wp.pl", "Test1234");

            MailMessage mm = new MailMessage("pawel.mezczyzna.q@wp.pl", email, "Potwierdzenie zamowienia", "Zamówiłeś w naszej restauracji:"+"Dodatkowe uwagi"+comment);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
        }

        public Accept_Order_Window()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"\A[a-z0-9]+([-._][a-z0-9]+)*@([a-z0-9]+(-[a-z0-9]+)*\.)+[a-z]{2,4}\z")
                && Regex.IsMatch(email, @"^(?=.{1,64}@.{4,64}$)(?=.{6,100}$).*");
        }

        private void SendConfirmationEmail(object sender, RoutedEventArgs e)
        {
            Connect();

            /*
            if (IsValidEmail(EmailField.Text) == true )
            {
                if (CommentField.Text == "Wpisz tutaj swoje uwagi")
                    CommentField.Text = "Brak uwag.";
                Connect();
                SendEmail(EmailField.Text, CommentField.Text);

                MessageBox.Show("Wysłano potwierdzenie pod Adres:"+ EmailField.Text +". Dziękujemy! :)","Zamówienie potwierdzone");
                this.Close();
            } else MessageBox.Show("Format adresu email jest niepoprawny. Sprawdz swoj adres i sprobuj ponownie","Bledny email");
            */
     
        }

        private void ChangeOrderButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
