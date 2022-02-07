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
        private bool isPlaying = true;
        private Puzzle puzzle = new Puzzle();
        private TerminalService terminalService = new TerminalService();

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
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Function Doc String
        /// </summary>
        private void GetInputs()
        {

        }

        /// <summary>
        /// Function Doc String
        /// </summary>
        private void DoUpdates()
        {

        }

        /// <summary>
        /// Provides a hint for the seeker to use.
        /// </summary>
        private void DoOutputs()
        {
            
        }
    }
}