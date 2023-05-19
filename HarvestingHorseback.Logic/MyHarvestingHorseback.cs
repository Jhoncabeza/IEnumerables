namespace HarvestingHorseback.Logic
{
    public class MyHarvestingHorseback
    {
        /// <summary>
        /// Gets or sets the initial positions of fruits.
        /// </summary>
        
        public string Fruits { get; set; }

        /// <summary>
        /// Gets or sets the current position of the horse.
        /// </summary>

        public string HorsePosition { get; set; }

        /// <summary>
        /// Gets or sets the sequence of movements for the horse.
        /// </summary>

        public string Movements { get; set; }

        /// <summary>
        /// Gets or sets the dictionary that stores the positions of fruits as keys and their corresponding values as integers.
        /// </summary>

        public Dictionary<string, int> Str { get; set; }

        /// <summary>
        /// Gets the collected fruits.
        /// </summary>

        public string FruitCollected { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyHarvestingHorseback"/> class.
        /// </summary>
        /// <param name="fruits">The initial positions of fruits.</param>
        /// <param name="horsePosition">The initial position of the horse.</param>
        /// <param name="horseMovements">The sequence of movements for the horse.</param>

        public MyHarvestingHorseback(string fruits, string horsePosition, string horseMovements)
        {
            Fruits = fruits;
            HorsePosition = horsePosition;
            Movements = horseMovements;
            Str = new Dictionary<string, int>();
            DescomposeString();
            FruitCollected = CollectedFruits();
        }

        /// <summary>
        /// Decomposes the Fruits string and populates the Str dictionary with fruit positions.
        /// </summary>

        public void DescomposeString()
        {
            var fruits = Fruits.Split(',');
            foreach (string stri in fruits)
            {
                string position = stri[..2];
                char fruit = stri[2];
                Str[position] = fruit;
            }
        }

        /// <summary>
        /// Simulates the horse's movements and collects the fruits.
        /// </summary>
        /// <returns>The collected fruits.</returns>
        
        public string CollectedFruits()
        {
            var collectedFruits = "";
            var movements = Movements.Split(",");

            foreach (var movement in movements)
            {
                HorsePosition = MoveHorse(HorsePosition, movement);

                if (Str.ContainsKey(HorsePosition))
                {
                    int numero = int.Parse(Str[HorsePosition].ToString());
                    char caracter = Convert.ToChar(numero);
                    collectedFruits += caracter + " ";
                    Str.Remove(HorsePosition);
                }
            }

            return $"Los frutos recogidos son: {collectedFruits}";
        }

        /// <summary>
        /// Calculates the new position of the horse based on the current position and movement.
        /// </summary>
        /// <param name="position">The current position of the horse.</param>
        /// <param name="movement">The movement direction.</param>
        /// <returns>The new position of the horse.</returns>
        
        public static string MoveHorse(string position, string movement)
        {
            int x = position[0] - 'A';
            int y = position[1] - '1';

            switch (movement)
            {
                case "UL":
                    x -= 1;
                    y += 2;
                    break;

                case "UR":
                    x += 1;
                    y += 2;
                    break;

                case "LU":
                    x -= 2;
                    y += 1;
                    break;

                case "LD":
                    x -= 2;
                    y -= 1;
                    break;

                case "RU":
                    x += 2;
                    y += 1;
                    break;

                case "RD":
                    x += 2;
                    y -= 1;
                    break;

                case "DL":
                    x -= 1;
                    y -= 2;
                    break;

                case "DR":
                    x += 1;
                    y -= 2;
                    break;
            }
            return "" + (char)('A' + x) + (char)('1' + y);
        }
    }
}