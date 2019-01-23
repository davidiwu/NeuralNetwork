using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPropagationExp
{
    public class Layer
    {
        private readonly int _neuronCount;
        private readonly int _inputCount;
        public Dictionary<int, Neuron> Neurons { get; set; }

        public Layer(int neuronCount, int inputCount)
        {
            _neuronCount = neuronCount;
            _inputCount = inputCount;
            InitializeLayer();
        }

        private void InitializeLayer()
        {
            Neurons = new Dictionary<int, Neuron>();
            for (int i = 0; i < _neuronCount; i++)
            {
                var neuron = new Neuron(_inputCount);
                Neurons.Add(i, neuron);
            }
        }

        public void SetInputs(double[] inputs)
        {
            foreach (var neuron in Neurons.Values)
            {
                neuron.Inputs = inputs;
            }
        }

        public double[] GetOutputs()
        {
            double[] outputs = new double[_neuronCount];
            for(int i = 0; i<_neuronCount;i++)
            {
                outputs[i] = Neurons[i].Output();
            }
            return outputs;
        }

        public void SetError(double[] errors)
        {
            for (int i = 0; i < _neuronCount; i++)
            {
                Neurons[i].Error = errors[i];
            }
        }

        public void AdjustNeuronWeights()
        {
            foreach (var neuron in Neurons.Values)
            {
                neuron.AdjustWeights();
            }
        }

        public void AdjustErrors(Neuron outputNeuron)
        {
            for (int i = 0; i < _neuronCount; i++)
            {
                Neurons[i].Error = Sigmoid.Derivative(Neurons[i].Output())*outputNeuron.Error*outputNeuron.Weights[i];
            }
        }

        public void AdjustErrorsBasedOnExpectResult(double[] result)
        {
            for (int i = 0; i < _neuronCount; i++)
            {
                var output = Neurons[i].Output();

                var globalError = Sigmoid.Derivative(output) * (output - result[i]);
                Neurons[i].Error = globalError;
            }
        }
    }
}
