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
                case 7: 
                top = "\n";
                break;
                
                case 6: 
                top = "\n";
                tside ="   ___\\\n";
                break;

                case 5: 
                top = "\n";
                tside ="   ___\n";
                break;

                case 4:
                top = "\n";
                tside ="\n";
                break;

                case 3: 
                top = "\n";
                tside ="\n";
                btside ="  \\\n";
                break;

                case 2: 
                top = "\n";
                tside ="\n";
                btside ="\n";
                break;

                case 1: 
                top = "\n";
                tside ="\n";
                btside ="\n";
                bbside ="     /\n";
                break; 

                case 0: 
                top = "\n";
                tside = "\n";
                btside = "\n";
                bbside = "\n";
                head ="    X \n";
                break;

                default:
                top = "    ___\n";
                tside ="  /___\\\n";
                btside ="  \\   /\n";
                bbside ="   \\ /\n";
                head ="    O \n";
                torso ="   /|\\\n";
                legs ="   / \\\n"; 
                air = " \n";
                ground = "^^^^^^^^^^^";
                break;
                }

            List<string> parachute = new List<string>{top, tside, btside, bbside, head, torso, legs, air, ground};
            return parachute;


        }
        




    }
}