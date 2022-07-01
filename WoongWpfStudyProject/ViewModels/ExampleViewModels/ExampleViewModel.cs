using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoongWpfStudyProject.ViewModels.Main;

namespace WoongWpfStudyProject.ViewModels
{
    internal class ExampleViewModel : ViewModelBase
    {
        public ExampleViewModel()
        {
            Text = "테스트입니다.";
        }

        private string _text;

        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }
    }
}
