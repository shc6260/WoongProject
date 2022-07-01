using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoongWpfStudyProject.ViewModels.MainViewModels;

namespace WoongWpfStudyProject.ViewModels.Main
{
    internal class MainListViewModel : ViewModelBase
    {
        private ObservableCollection<MainListItemViewModel> _items;

        public ObservableCollection<MainListItemViewModel> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        private MainListItemViewModel _selectedType;

        public MainListItemViewModel SelectedType
        {
            get => _selectedType;
            set
            {
                if(SetProperty(ref _selectedType, value))
                {
                    OnChangedSelectedType();
                }
            }
        }

        public EventHandler ChangedSelectedType;

        private void OnChangedSelectedType()
        {
            ChangedSelectedType?.Invoke(this, EventArgs.Empty);
        }
    }
}
