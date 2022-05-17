using System;
using System.Collections.Generic;

namespace Unit02.Game
{
    public class Die {

        public int points = 0;
        public int value = 0;
        public Die() {
        }

        public void Roll() {
            Random random_roll = new Random();
            value = random_roll.Next(1, 7);
            
             if (value == 5){
                points = 50;
            } else if (value == 1) {
                points = 100;
            } else if (value == 6){
                points = 120;
            } else {
                points = 0;
            }
        }
    }
}
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.

        /// <summary>
        /// A small cube with a different number of spots on each of its six sides.
        /// 
        /// The responsibility of Die is to keep track of its currently rolled value and the points its
        /// worth. (This is the overall responsibility of the class)
        /// </summary> 


    // 2) Create the class constructor. Use the following method comment.

        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>

    
    // 3) Create the Roll() method. Use the following method comment.
        
        /// <summary>
        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
        /// </summary>
        
