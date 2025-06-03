using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHECKTOOL.Model;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using System.Windows;

namespace CHECKTOOL.ViewModel
{
    public class BarcodeViewModel : ObservableObject
    {
        private string _barcode;
        private readonly BarcodeModel barcodeModel;
        public ICommand CheckBarCodeCommand =>  new RelayCommand(checkBarCode);
        public BarcodeViewModel()
        {
            barcodeModel = new BarcodeModel();
        }

        public string Barcode
        {
            get => _barcode;
            set => SetProperty(ref _barcode, value);
        }

        public void checkBarCode()
        {
            string trimmedBarcode = Barcode.Trim();
            if (trimmedBarcode != null && trimmedBarcode.Length >0)
            {
                bool isExist = barcodeModel.alreadyExist(trimmedBarcode);
                if (isExist)
                {
                    MessageBox.Show("Mã vạch đã tồn tại.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    bool isAdded = barcodeModel.addBarcode(trimmedBarcode);
                    string message = isAdded ? "Thêm mã vạch thành công" : "Thêm mã vạch thất bại";
                    MessageBox.Show(message, "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
               MessageBox.Show("Vui lòng nhập mã vạch hợp lệ.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Warning);
            } 
        }

    }
    }

