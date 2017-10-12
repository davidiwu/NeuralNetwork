using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPropagationExp
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingMyNeuronNetwork();
        }

        private static void UsingMyNeuronNetwork()
        {
            Network nw = new Network(2000, 2);
            var inputs = new double[,]
            {
                {0, 0},
                {0, 1},
                {1, 0},
                {1, 1}
            };

            var resutls = new double[] { 1, 1, 1, 0 };
            nw.InitializeNetwork(inputs, resutls);

            nw.TrainNetwork();
        }

    }
}
