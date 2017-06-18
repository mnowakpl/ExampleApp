using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ExampleApp.ViewModel
{
    public class VmSquareWindow : ViewModelBase
    {
        public VmSquareWindow()
        {
            CmdCalculateSq = new RelayCommand(execCmdCalculateSq);
        }

        private void execCmdCalculateSq(object obj)
        {
            CheckData(Side);
        }

        public ICommand CmdCalculateSq { get; private set; }

        private int _Side;
        public int Side
        {
            get
            {
                return _Side;
            }
            set
            {
                _Side = value;
                OnPropertyChanged("Side");
            }
        }

        private int _Result;
        public int Result
        {
            get
            {
                return _Result;
            }
            set
            {
                _Result = value;
                OnPropertyChanged("Result");
            }
        }

        public void CheckData(int x)
        {
            if(x==0 || x<0)
            {
                MessageBox.Show("Please enter value positive and different from 0!");
            }
            else
            {
                Result = Side * 2;
            }
        }
    }
}
