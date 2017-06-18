using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp.Model
{
    public class Data : ViewModelBase
    {
        public int Side { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }
        public int Radius { get; set; }
    }
}
