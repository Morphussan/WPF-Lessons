using System.Windows;

namespace WpfLarionov1
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (username == "KKT" && password == "best1") // Не забываем за шедевро логин и пароль от Руслана Сергеевича
            {
                MessageBox.Show("НАШ СЛОНЯРА!!!!");

                // После успешной проверки мы переходим к окну добавления продуктов, в данном случае к оку ProductManagerWindow
                ProductManagerWindow productManagerWindow = new ProductManagerWindow();
                productManagerWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("К добавлению продуктов шёл, но забыл главное ;(");
            }
        }
    }
}