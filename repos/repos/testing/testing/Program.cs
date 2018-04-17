using System;
using Encog.Neural.Networks;
using Encog.Neural.Networks.Layers;
using Encog.Engine.Network.Activation;
using Encog.ML.Data;
using Encog.Neural.Networks.Training.Propagation.Resilient;
using Encog.ML.Train;
using Encog.ML.Data.Basic;
using Encog;

namespace testing
{
    internal class Program
    {
        // / <summary>
        // / In p u t f o r t h e XOR f u n c t i o n .
        // / </summary>
        public static double[][] XORInput =
        {
            new [] { 0.0 , 0.0 } ,
            new [] { 1.0 , 0.0 } ,
            new [] { 0.0 , 1.0 } ,
            new [] { 1.0 , 1.0 }
        };

        // / <summary>
        // / I d e a l o u t p u t f o r t h e XOR f u n c t i o n .
        // / </summary>
        public static double[][] XORIdeal =
        {
            new [] { 0.0 } ,
            new [] { 1.0 } ,
            new [] { 1.0 } ,
            new [] {0.0}
        };

        private static void Main(string[] args)
        {
            // c r e a t e a n e u r al ne twork , w i t h o u t u s i n g a f a c t o r y
            var network = new BasicNetwork();
            network.AddLayer(new BasicLayer(null, true, 2));
            network.AddLayer(new BasicLayer(new ActivationSigmoid(),true, 3));
            network.AddLayer(new BasicLayer(new ActivationSigmoid(),false, 1));
            network.Structure.FinalizeStructure();
            network.Reset();

            // c r e a t e t r a i n i n g d a t a
            IMLDataSet trainingSet = new BasicMLDataSet(XORInput, XORIdeal);

            // t r a i n t h e n e u r al ne twork
            IMLTrain train = new ResilientPropagation(network , trainingSet );

            int epoch = 1;
            do
            {
                train.Iteration();
                Console.WriteLine(@"Epoch #" + epoch + @" Error: " + train.Error);
                epoch++;
            } while (train.Error > 0.01 );

            train.FinishTraining();

            // t e s t t h e n e u r al ne twork
            Console.WriteLine(@" Nueral Network Results: ") ;
            foreach (IMLDataPair pair in trainingSet)
            {
                IMLData output = network.Compute(pair.Input);
                Console.WriteLine(pair.Input[0] + @" , " + pair.Input[1] + @", actual=" + output[0] + ", ideal = " + pair.Ideal[0]);



                EncogFramework.Instance.Shutdown();
            }
            Console.ReadLine();
        }
    }
}
