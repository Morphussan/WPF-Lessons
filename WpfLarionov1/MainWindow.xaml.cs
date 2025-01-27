using System.Windows;

namespace WpfLarionov1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Так как я хотел изначально сделать окно аторизации и добавления продуктов раздельно, то при удалении mainwindow я не мог запустить сборку и поэтому сделал изначальное открытие окна авторизации
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }
    }
}