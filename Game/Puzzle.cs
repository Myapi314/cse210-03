using System;


namespace Unit03.Game
{
    /// <summary>
    /// <para>The person looking for the Hider.</para>
    /// <para>
    /// The responsibility of a Seeker is to keep track of its location.
    /// </para>
    /// </summary>
    public class Puzzle
    {
        private string[] wordList = {""};
        private string keyWord = "";
        private int iKey = 0;
        /// <summary>
        /// Constructs a new instance of Puzzle.
        /// </summary> 
        public Puzzle()
        {
            // Generate the key word here
            Random rand = new Random();
            iKey = random.Next(wordList.Count);
            keyWord = wordList[index];
        }

        /// <summary>
        /// Description here.
        /// </summary>
        /// <returns>  .</returns>


        /// <summary>
        /// Function Doc string
        /// </summary>

    }
}