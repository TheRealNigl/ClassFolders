using Accord.MachineLearning.VectorMachines;


/// <summary>
/// Sources:
/// 
/// 1. https://stackoverflow.com/questions/3854404/applying-hidden-markov-model-to-multiple-simultaneous-bit-sequences
/// 
/// 
/// 2. https://www.codeproject.com/Articles/69647/Hidden-Markov-Models-in-Csharp.aspx
/// 
/// 
/// 3. http://alumni.media.mit.edu/~rahimi/rabiner/rabiner-errata/rabiner-errata.html
/// 
/// 
/// 4. Wolfram Alpha Api reference = https://products.wolframalpha.com/api/documentation/
/// 
/// </summary>
namespace MarkovModel.Models
{
    class MarkovModel
    {
        public static int input = 1;
        SupportVectorMachine machine = new SupportVectorMachine(input);



    }
}
