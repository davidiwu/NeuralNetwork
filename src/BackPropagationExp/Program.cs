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
            TrainNeuronNetworkAsXORFunction();

            //TrainNeuronNetworkAsXANDFunction();
        }

        private static void TrainNeuronNetworkAsXORFunction()
        {
            Network xorNetwork = new Network(2000, 2);
            var inputs = new double[,]
            {
                {0, 0},
                {0, 1},
                {1, 0},
                {1, 1}
            };

            // xor function: 0 xor 0 = 0;  0 xor 1 = 1; 1 xor 0 = 1; 1 xor 1 = 0;
            var resutls = new double[] { 0, 1, 1, 0 };
            xorNetwork.InitializeNetwork(inputs, resutls);

            xorNetwork.TrainNetwork();
        }

        private static void TrainNeuronNetworkAsXANDFunction()
        {
            Network xandNetwork = new Network(2000, 2);
            var inputs = new double[,]
            {
                {0, 0},
                {0, 1},
                {1, 0},
                {1, 1}
            };

            // xand function: 0 xor 0 = 1;  0 xor 1 = 1; 1 xor 0 = 1; 1 xor 1 = 0;
            var resutls = new double[] { 1, 1, 1, 0 };
            xandNetwork.InitializeNetwork(inputs, resutls);

            xandNetwork.TrainNetwork();
        }

    }
}
