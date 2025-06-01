using CHECKTOOL.Configuration;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CHECKTOOL.ViewModel
{
    public class LoginViewModel
    {
        private ICommand clickButtonLoginCommand;
        public ICommand LoginCommand => clickButtonLoginCommand ??= new RelayCommand(test);

        public void test()
        {
            var db = new DBconfig();
            bool isConnected = db.TestConnection();

            if (isConnected)
            {
               MessageBox.Show("Đã kết nối đến database.");
            }
            else
            {
                MessageBox.Show("Không thể kết nối đến database.");
            }
        }

    }
}
