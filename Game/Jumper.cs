using System;
using System.Collections.Generic;


namespace Unit03.Game 
{
    /// <summary>
    /// <para> </para>
    /// <para>
    /// The responsibility of Jumper is to keep track of
    /// the changes in the parachute.
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
         int lives = Director.lives;
        /// <summary>
        /// Creates the parachute.
        /// </summary>
        /// <param name="lives">The number of lives not exceeding 8.</param>
        /// <returns>List containing parts of parachute remaining.</returns>
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
            switch(lives){
                case 7: top = "";
                break;
                case 6: top = "";
                tside ="  ___\\\n";
                break;
                case 5: top = "";
                tside ="  ___";
                break;
                case 4: top = "";
                tside ="";
                break;
                case 3: top = "";
                tside ="";
                btside ="     /\n";
                break;
                case 2: top = "";
                tside ="";
                btside ="     ";
                break;
                case 1: top = "";
                tside ="";
                btside ="     ";
                bbside ="    /\n";
                break;
                case 0: top = "";
                tside ="";
                btside ="     ";
                bbside ="    ";
                head ="    X \n";
                break;
            }

            List<string> parachute = new List<string>{top, tside, btside, bbside, head, torso, legs, air, ground};
            return parachute;


        }
        




    }
}