using System;


namespace Unit03.Game
{
    /// <summary>
    /// <para></para>
    /// <para>
    /// The responsibility of a Puzzle is to
    /// keep track of the key word and if the letters 
    /// being guessed are a part of the keyWord.
    /// </para>
    /// </summary>
    public class Puzzle
    {
        private List<string> wordList = new List<string>{"milk", "ice", "catastrophe", "orange", "fruit", "animal", "xylophone"};
        private string keyWord = "";
        private int iKeyWord = 0;
        private int lenKey = 0;
        private List<string> guessedLetters = new List<string>();
        private List<string> correctLetters = new List<string>();
        /// <summary>
        /// Constructs a new instance of Puzzle.
        /// </summary> 
        public Puzzle()
        {
            // Generate the key word here
            Random rand = new Random();
            iKeyWord = rand.Next(wordList.Count);
            keyWord = wordList[iKeyWord];
            lenKey = keyWord.Length;

            // Generate the guessLetters 
            guessedLetters = Enumerable.Repeat("_", lenKey).ToList();
            // Generate list of strings with correct letters.
            for (int i = 0; i < lenKey; i++)
            {
                string currLetter = keyWord[i].ToString();
                correctLetters.Add(currLetter);
            }
        }

        /// <summary>
        /// Description here.
        /// </summary>
        /// <returns>  .</returns>
        public bool CompareLetter(string letter)
        {
            bool isLetter = false;
            for (int i = 0; i < lenKey; i++)
            {
                if (letter == correctLetters[i])
                {
                    isLetter = true;
                    guessedLetters[i] = letter;
                }
                    }
            return isLetter;
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