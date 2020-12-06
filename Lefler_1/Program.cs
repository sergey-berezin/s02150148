using System;
using OnnxClassifier;

namespace Task_1
{

    class Program
    {
        static void RecognitionCompletedHandler(ResultClassification result)
        {
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            string directoryPath;

            if (args.Length == 0)
                directoryPath = "../../../../../Samples";
            else
                directoryPath = args[0];


            OnnxClassifier.OnnxClassifier onnxModel = new OnnxClassifier.OnnxClassifier();

            ThreadClassification task_1 = new ThreadClassification(directoryPath, onnxModel, RecognitionCompletedHandler);

            Console.WriteLine("Press key to stop me...");

            task_1.Run();

            Console.ReadKey(true);
            task_1.Stopper();


        }
    }
}
