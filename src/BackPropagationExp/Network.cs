using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPropagationExp
{
    public class Network
    {
        private readonly int _epoch;
        private readonly int _hiddenLayerNeuronCount;

        private int _inputLength;
        private int _inputSets;

        public double[,] Inputs { get; set; }
        public double[] Resutls { get; set; }

        public Layer HiddenLayer { get; set; }

        public Layer OutputLayer { get; set; }


        public Network(int epochCount, int hiddenLayerNeuronCount)
        {
            _epoch = epochCount;
            _hiddenLayerNeuronCount = hiddenLayerNeuronCount;
        }

        public void InitializeNetwork(double[,] inputs, double[] expectResults)
        {
            Inputs = inputs;
            _inputSets = Inputs.GetLength(0);
            _inputLength = Inputs.GetLength(1);
            Resutls = expectResults;
            HiddenLayer = new Layer(_hiddenLayerNeuronCount, _inputLength);
            OutputLayer = new Layer(1, _hiddenLayerNeuronCount);
        }

        public void TrainNetwork()
        {
            for (int i = 0; i < _epoch; i++)
            {
                for (int j = 0; j < _inputSets; j++)
                {
                    double[] inputs = new double[_inputLength];
                    for (int k = 0; k < _inputLength; k++)
                    {
                        inputs[k] = Inputs[j, k];
                    }
                    HiddenLayer.SetInputs(inputs);

                    OutputLayer.SetInputs(HiddenLayer.GetOutputs());

                    PrintResult(inputs, OutputLayer.GetOutputs());

                    OutputLayer.AdjustErrorsBasedOnExpectResult(new double[] {Resutls[j]});
                    OutputLayer.AdjustNeuronWeights();

                    HiddenLayer.AdjustErrors(OutputLayer.Neurons[0]);
                    HiddenLayer.AdjustNeuronWeights();
                }
            }
        }

        private void PrintResult(double[] inputs, double[] outputs)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var input in inputs)
            {
                sb.Append(input);
                sb.Append(" ");
            }
            sb.Append(" = ");
            foreach (var output in outputs)
            {
                sb.Append(output);
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
