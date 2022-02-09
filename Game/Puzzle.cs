using System;


namespace Unit03.Game
{
    /// <summary>
    /// <para></para>
    /// <para>
    /// The responsibility of a Puzzle is to
    /// keep track of the key word and the letters 
    /// being guessed.
    /// </para>
    /// </summary>
    public class Puzzle
    {
        private string[] wordList = {"milk", "ice", "catastrophe", "orange", "fruit", "animal", "xylophone"};
        private string keyWord = "";
        private int iKeyWord = 0;
        private int lenKey = 0;
        private List<string> guessedLetters = new List<string>();
        /// <summary>
        /// Constructs a new instance of Puzzle.
        /// </summary> 
        public Puzzle()
        {
            // Generate the key word here
            Random rand = new Random();
            iKeyWord = random.Next(wordList.Count);
            keyWord = wordList[index];
            lenKey = keyWord.Length;
            guessedLetters = Enumerable.Repeat("_", len).ToList();
        }

        /// <summary>
        /// Description here.
        /// </summary>
        /// <returns>  .</returns>
        public void CompareLetter(string letter)
        {
            int len = keyWord.Length;
            for (int i = 0; i < len; i++)
            {
                string currLetter = keyWord[i].ToString();
                if (letter == currLetter)
                {
                    guessedLetters[i] = letter;
                }
                    }
            }

        /// <summary>
        /// Returns the list of guessedLetters.
        /// </summary>
        public List<string> GetGuessedLetters()
        {
            return guessedLetters;
        }
    }
}