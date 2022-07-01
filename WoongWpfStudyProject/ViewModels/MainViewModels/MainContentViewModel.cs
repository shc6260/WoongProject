using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoongWpfStudyProject.ViewModels;

namespace WoongWpfStudyProject.ViewModels.Main
{
    internal class MainContentViewModel : ViewModelBase
    {
        private ViewModelBase _content;

        public ViewModelBase Content
        {
            get => _content;
            set
            {
                SetProperty(ref _content, value);
                RaisePropertyChanged(nameof(Content));
            }
        }
    }
}
