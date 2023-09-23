using MVVM_Tutorial.Model;
using MVVM_Tutorial.MVVM;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace MVVM_Tutorial.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public RelayCommand AddCommand => new RelayCommand(execute => AddItem());
        public RelayCommand DeleteCommand => new RelayCommand(execute => DeleteItem(), canExecute => SelectedItem != null);

        public RelayCommand SaveCommand => new RelayCommand(execute => Save(), canExecute => canSave());
        public MainWindowViewModel()
        {
        Items= new ObservableCollection<Item>();
        }

        private Item selectedItem;

        public Item SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value;
                onPropertyChanged();
            }
        }

        private void AddItem()
        {
            Items.Add(new Item
            {
                Name = "New Item",
                SerialNumber = "XXXX",
                Quantity = 0
            });
        }

        private void DeleteItem()
        {
            Items.Remove(selectedItem);
        }

        private void Save()
        {

        }

        private bool CanSave()
        {
            return true;
        }

       
    }
}
