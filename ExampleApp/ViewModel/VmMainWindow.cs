using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExampleApp.ViewModel
{
    public class VmMainWindow : ViewModelBase
    {
        public VmMainWindow()
        {
            CmdSquareOpen = new RelayCommand(execCmdSquareOpen);
            CmdTriangleOpen = new RelayCommand(execCmdTrianglOpen);
            CmdCircleOpen = new RelayCommand(execCmdCircleOpen);
        }

        private void execCmdCircleOpen(object obj)
        {
            View.CircleWindow AddWinC = new View.CircleWindow();
            AddWinC.ShowDialog();
        }

        private void execCmdTrianglOpen(object obj)
        {
            View.TriangleWindow AddWinT = new View.TriangleWindow();
            AddWinT.ShowDialog();
        }

        private void execCmdSquareOpen(object obj)
        {
            View.SquareWindow AddWinS = new View.SquareWindow();
            AddWinS.ShowDialog();
        }

        public ICommand CmdSquareOpen { get; private set; }
        public ICommand CmdTriangleOpen { get; private set; }
        public ICommand CmdCircleOpen { get; private set; }
    }
}
