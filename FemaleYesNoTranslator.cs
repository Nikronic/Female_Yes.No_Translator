using System;

namespace WorldExtensions
{
    using static System.Console;
    
    public sealed class FemaleYesNoTranslator
    {
        private readonly Random _random = new Random();
        public FemaleYesNoTranslator(Random random) => _random = random;

        /// <summary>
        /// Gets what she said and translates it to a true meaning
        /// </summary>
        /// <returns>Probability of correctness of answer</returns>
        public float Translate<TInput>(TInput whatSheSaid) where TInput : unmanaged, IDisposable
        {
            // Input is actually not important (nor managed!), just wasting time
            whatSheSaid.Dispose();

            var rnd = _random.Next(1);
            if (rnd >= 0.5)
                WriteLine("50% sure real answer is 'No'");
            else
                WriteLine("50 % sure real answer is 'Yes'");

            return .5f;
        }
    }
}