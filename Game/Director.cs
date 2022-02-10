namespace Unit03.Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        private Jumper jumper = new Jumper();
        private bool wordFound = false;
        private Puzzle puzzle = new Puzzle();
        private TerminalService terminalService = new TerminalService();

        private string currLetter = "";
        private bool isLetter = false;
        private int lives = 8;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Function Doc String
        /// </summary>
        public void StartGame()
        {
            while (!wordFound && lives > 0)
            {
                DoOutputs();
                GetInputs();
                DoUpdates();
            }
            endOfGame();
        }

        /// <summary>
        /// Function Doc String
        /// </summary>
        private void GetInputs()
        {
            currLetter = terminalService.ReadText("Guess a leter [a-z]: ");
        }

        /// <summary>
        /// Function Doc String
        /// </summary>
        private void DoUpdates()
        {
            isLetter = puzzle.CompareLetter(currLetter);
            if (!isLetter)
            {
                lives -= 1;
            }
            wordFound = puzzle.CompareProgress();
        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {
            terminalService.WriteList(puzzle.GetGuessedLetters());
            Console.WriteLine(lives);
        }

        private void endOfGame()
        {
            terminalService.WriteList(puzzle.GetGuessedLetters());
        }
    }
}