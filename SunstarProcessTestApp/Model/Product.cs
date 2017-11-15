using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunstarProcessTestApp.Model
{
    class Product
    {
        public string Name { get; set; }
        public double MaxGross { get; set; }
        public double MinGross { get; set; }
        public double MaxNet { get; set; }
        public double MinNet { get; set; }
        public double ItemNet { get; set; }
        public double SpecWeight { get; set; }
        public double Tare { get; set; }
        public double TotalMinNet { get; set; }
        public double TotalMaxNet { get; set; }
        public double TotalItemNet { get; set; }
        public bool TotalNetVisibility { get; set; }
        public bool IsPartial { get; set; }
    }
}
