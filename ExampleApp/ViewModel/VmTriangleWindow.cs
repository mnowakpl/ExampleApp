using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ExampleApp.ViewModel
{
    public class VmTriangleWindow : ViewModelBase
    {
        public VmTriangleWindow()
        {
            CmdCalculateTr = new RelayCommand(execCmdCalculateTr);
        }

        private void execCmdCalculateTr(object obj)
        {
            CheckData(Base,Height);
        }

        public ICommand CmdCalculateTr { get; private set; }

        private int _Base;
        public int Base
        {
            get
            {
                return _Base;
            }
            set
            {
                _Base = value;
                OnPropertyChanged("Base");
            }
        }

        private int _Height;
        public int Height
        {
            get
            {
                return _Height;
            }
            set
            {
                _Height = value;
                OnPropertyChanged("Height");
            }
        }

        private double _Result;
        public double Result
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

        public void CheckData(int x, int y)
        {
            if (x == 0 || x < 0)
            {
                MessageBox.Show("Please enter value positive and different from 0!");
            }
            else if(y == 0 || y < 0)
            {
                MessageBox.Show("Please enter value positive and different from 0!");
            }
            else
            {
                Result = (Base * Height) / 2;
            }
        }
    }
}
