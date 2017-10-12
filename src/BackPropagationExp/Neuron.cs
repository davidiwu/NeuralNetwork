using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPropagationExp
{
    public class Neuron
    {
        private readonly int _inputCount;
        private double _biasWeight;

        public double[] Inputs { get; set; }
        public double[] Weights { get; set; }
        public double Error { get; set; }

        public Neuron(int count)
        {
            _inputCount = count;
            InitializeNeuron();
        }

        private void InitializeNeuron()
        {
            Inputs = new double[_inputCount];
            Weights = new double[_inputCount];
            RandomizeWeights();
        }

        private void RandomizeWeights()
        {
            Random r = new Random(Environment.TickCount);
            for (int i = 0; i < _inputCount; i++)
            {
                Weights[i] = r.NextDouble();
            }
            _biasWeight = r.NextDouble();
        }

        public void AdjustWeights()
        {
            _biasWeight += Error;
            for (int i = 0; i < _inputCount; i++)
            {
                Weights[i] += Error*Inputs[i];
            }
        }

        public double Output()
        {
            double wi = _biasWeight;
            for (int i = 0; i < _inputCount; i++)
            {
                wi += Weights[i]*Inputs[i];
            }

            return Sigmoid.Output(wi);
        }
    }
}
