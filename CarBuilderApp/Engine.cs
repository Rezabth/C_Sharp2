using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBuilderApp
{
    internal class Engine : Part
    {
        private int qubic;

        public Engine(int qubic, decimal cost) : base(cost)
        {
            this.qubic = qubic;
        }
    }
}