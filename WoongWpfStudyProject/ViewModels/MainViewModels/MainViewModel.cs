using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoongWpfStudyProject.Managers;
using WoongWpfStudyProject.Types;
using WoongWpfStudyProject.ViewModels.MainViewModels;

namespace WoongWpfStudyProject.ViewModels.Main
{
    internal class MainViewModel : ViewModelBase
    {
        private MainListViewModel _mainListViewModel;

        public MainListViewModel MainListViewModel
        {
            get
            {
                if (_mainListViewModel == null)
                {
                    _mainListViewModel = new MainListViewModel();
                    _mainListViewModel.Items = new ObservableCollection<MainListItemViewModel>(FunctionListDataManager.Instance.GetFunctionListData().Select(MainListItemViewModel.From));
                    _mainListViewModel.ChangedSelectedType += (_, __) => OnChangedViewModel();

                }

                return _mainListViewModel;
            }
        }

        private MainContentViewModel _mainContentViewModel;

        public MainContentViewModel MainContentViewModel
        {
            get
            {
                if (_mainContentViewModel == null)
                {
                    _mainContentViewModel = new MainContentViewModel();
                }
                
                return _mainContentViewModel;
            }
        }

        private ViewModelBase _content;

        public ViewModelBase Content
        {
            get => _content;
            set => SetProperty(ref _content, value);
        }

        private void OnChangedViewModel()
        {
            switch (_mainListViewModel.SelectedType.Type)
            {
                case FunctionsType.test:
                    MainContentViewModel.Content = new ExampleViewModel();
                    break;
            }
        }
    }
}
