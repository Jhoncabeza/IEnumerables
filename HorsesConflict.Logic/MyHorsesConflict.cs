namespace HorsesConflict.Logic
{
    public class MyHorsesConflict
    {
        public string CoordinatesInput { get; set; }
        public string[] Response { get; set; }

        public MyHorsesConflict(string coordinatesInput)
        {
            CoordinatesInput = coordinatesInput;
            List<string> coordinates = GetCoordinates();
            Dictionary<string, List<string>> conflicts = GetConflicts(coordinates);
            Response = ShowResults(conflicts);
        }

        public override string ToString()
        {
            return string.Join("\n", Response);
        }

        public List<string> GetCoordinates()
        {
            return new List<string>(CoordinatesInput.Split(','));
        }

        public static Dictionary<string, List<string>> GetConflicts(List<string> coordinates)
        {
            Dictionary<string, List<string>> conflicts = new();
            Dictionary<char, HashSet<int>> board = new();

            // Build the board representation
            foreach (string coordinate in coordinates)
            {
                int row = int.Parse(coordinate.Substring(1));
                char column = coordinate[0];

                if (!board.ContainsKey(column))
                {
                    board[column] = new HashSet<int>();
                }

                board[column].Add(row);
            }

            // Check for conflicts between knights
            foreach (string coordinate in coordinates)
            {
                int row = int.Parse(coordinate[1..]);
                char column = coordinate[0];
                List<string> conflictingKnights = new();

                foreach (var kvp in board)
                {
                    char col = kvp.Key;
                    HashSet<int> rows = kvp.Value;

                    if (col != column)
                    {
                        foreach (int r in rows)
                        {
                            int colDiff = Math.Abs(col - column);
                            int rowDiff = Math.Abs(r - row);

                            if ((colDiff == 1 && rowDiff == 2) || (colDiff == 2 && rowDiff == 1))
                            {
                                conflictingKnights.Add($"{r}{col}");
                            }
                        }
                    }
                }

                conflicts[coordinate] = conflictingKnights;
            }

            return conflicts;
        }

        public static string[] ShowResults(Dictionary<string, List<string>> conflicts)
        {
            string[] response = new string[conflicts.Count];
            int i = 0;

            foreach (var kvp in conflicts)
            {
                string knight = kvp.Key;
                List<string> conflictsWith = kvp.Value;
                string conflictString = conflictsWith.Count > 0 ? string.Join(", ", conflictsWith) : string.Empty;
                response[i] = $"Analizando Caballo en {knight} => Conflicto con: {conflictString}";
                i++;
            }

            return response;
        }
    }
}