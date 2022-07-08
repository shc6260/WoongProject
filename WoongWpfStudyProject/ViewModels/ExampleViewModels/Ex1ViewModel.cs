using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WoongWpfStudyProject.ViewModels.Main;

namespace WoongWpfStudyProject.ViewModels
{
    internal class Ex1ViewModel : ViewModelBase
    {
        private ICommand buttonNewCmd;
        public ICommand ButtonNewCmd => buttonNewCmd = buttonNewCmd ?? new RelayCommand(ButtonNewDataCmd, CanButtonCmdExe);

        private void ButtonNewDataCmd()
        {
            MessageBox.Show(" ");
        }

        private bool CanButtonCmdExe()
        {

            return true;
        }

    }
}
