using CHECKTOOL.Configuration;
using CHECKTOOL.Model;
using CHECKTOOL.View;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CHECKTOOL.ViewModel
{
    public class LoginViewModel : ObservableObject
    {
        private readonly loginModel _loginModel;
        private ICommand _loginCommand;
        public LoginViewModel()
        {
            _loginModel = new loginModel();
        }

        private string _username;
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value); 
        }

        private string _password;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public ICommand LoginCommand => _loginCommand ??= new RelayCommand(OnLogin);

        private void OnLogin()
        {
            bool success = _loginModel.AuthenticateUser(Username, Password);

            if (success)
            {
                MessageBox.Show("Đăng nhập thành công!");
                // Có thể chuyển sang màn hình chính ở đây
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu.");
            }
        }
    }
}
