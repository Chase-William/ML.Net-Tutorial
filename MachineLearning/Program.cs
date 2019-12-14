using System;
using MachineLearningML.Model;

namespace MachineLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput()
            {
                SentimentText = "That is Rude."
            };

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}");
            Console.ReadLine();
        }
    }
}
