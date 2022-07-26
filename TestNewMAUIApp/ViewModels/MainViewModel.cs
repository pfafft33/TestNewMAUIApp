using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace TestNewMAUIApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string name;

        [ObservableProperty]
        string phone;

        [ICommand]
        public void StoreDetailsNameCompleted(Entry myEntry)
        {
            //_appConfig.Store.MyCurrentStore.Name = myEntry.Text;
            //_storeListVM.SaveStoreList();
        }

        [ICommand]
        public void StoreDetailsPhoneCompleted(Entry myEntry)
        {
            //_appConfig.Store.MyCurrentStore.Phone = myEntry.Text;
            //_storeListVM.SaveStoreList();
        }

        public MainViewModel()
        {

        }

    }
}
