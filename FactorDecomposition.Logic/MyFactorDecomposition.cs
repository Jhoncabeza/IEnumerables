namespace FactorDecomposition.Logic
{
    public class MyFactorDecomposition
    {
        public int Number { get; set; }
        public List<int> ListNumber { get; set; }
        public MyFactorDecomposition(int number)
        {
            Number = number;
            ListNumber = GetPrimeFactors(number);
        }
        public override string ToString()
        {
            var output = string.Empty;

            for (int i = 0; i < ListNumber.Count; i++)
            {
                output += $"{ListNumber[i]}";

                if (i + 1 < ListNumber.Count)
                {
                    output += $" x ";
                }

            }
            return $"{Number} = {output}";
        }
        public static List<int> GetPrimeFactors(int number)
        {
            List<int> factors = new();
            // Check divisibility by 2
            while (number % 2 == 0)
            {
                factors.Add(2);
                number /= 2;
            }

            // Check divisibility by odd numbers
            for (int i = 3; i <= Math.Sqrt(number); i += 2)
            {
                while (number % i == 0)
                {
                    factors.Add(i);
                    number /= i;
                }
            }

            // If the number is prime and greater than 2
            if (number > 2)
            {
                factors.Add(number);
            }
            return factors;
        }


    }
}