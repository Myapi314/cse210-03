using System;
using System.Collections.Generic;


namespace Unit03.Game 
{
    /// <summary>
    /// <para> </para>
    /// <para>
    /// The responsibility of Jumper is to keep track of its 
    /// lives and the parts of the key word guessed correctly.
    /// </para>
    /// </summary>
    public class Jumper
    {
       

        /// <summary>
        /// Constructs a new instance of Jumper. 
        /// </summary>
        public Jumper()
        {
        }

        /// <summary>
        /// Function Doc String
        /// </summary>
        
        ///dispaly board
        public List<string> BuildParachute(int lives){
            string top = "    ___\n";
            string tside ="  /___\\\n";
            string btside ="  \\   /\n";
            string bbside ="   \\ /\n";
            string head ="    O \n";
            string torso ="   /|\\\n";
            string legs ="   / \\\n"; 
            string air = " \n";
            string ground = "^^^^^^^^^^^";

            List<string> parachute = new List<string>{top, tside, btside, bbside, head, torso, legs, air, ground};
            return parachute;

        }




    }
}