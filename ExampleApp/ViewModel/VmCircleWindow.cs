using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ExampleApp.ViewModel
{
    public class VmCircleWindow : ViewModelBase
    {
        public VmCircleWindow()
        {
            CmdCalculateCi = new RelayCommand(execCmdCalculateCi);
        }

        private void execCmdCalculateCi(object obj)
        {
            CheckData(Radius);
        }

        public ICommand CmdCalculateCi { get; private set; }

        private int _Radius;
        public int Radius
        {
            get
            {
                return _Radius;
            }
            set
            {
                _Radius = value;
                OnPropertyChanged("Radius");
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

        public void CheckData(int x)
        {
            if (x == 0 || x < 0)
            {
                MessageBox.Show("Please enter value positive and different from 0!");
            }
            else
            {
                Result = Math.PI * Radius * Radius;
            }
        }
    }
}
