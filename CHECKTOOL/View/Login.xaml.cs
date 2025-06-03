using CHECKTOOL.ViewModel;
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

namespace CHECKTOOL.View
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        protected readonly LoginViewModel loginViewModel = new LoginViewModel();
        public Login()
        {
            InitializeComponent();
            loginViewModel.RequestClose += () => this.Close();
            DataContext = loginViewModel;
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is LoginViewModel vm)
            {
                vm.Password = passwordBox.Password; // Truyền mật khẩu vào ViewModel
            }
        }

    }
}
