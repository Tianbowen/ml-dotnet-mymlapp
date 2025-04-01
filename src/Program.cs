using Mymlapp;

namespace mymlapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var sampleData = new SentimentModel.ModelInput()
            {
                Col0 = "This restaurant was wonderful."
            };

            // Load model and predict output of sample data
            var result = SentimentModel.Predict(sampleData);

            // if Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative";
            var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
            Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");

        }
    }
}
