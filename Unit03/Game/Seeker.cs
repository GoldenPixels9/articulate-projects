using System;


namespace Unit03.Game
{
    
    class Seeker {
        Random random = new Random();
        int location;

        public Seeker() {
            this.location = random.Next(1, 1000);
        }

        public int GetLocation() {
            return this.location;
        }

        public void MoveLocation(int location){
            this.location = location;
        }
    }
}
    // TODO: Implement the Seeker class as follows...

    // 1) Add the class declaration. Use the following class comment. 

        /// <summary>
        /// <para>The person looking for the Hider.</para>
        /// <para>
        /// The responsibility of a Seeker is to keep track of its location.
        /// </para>
        /// </summary>


    // 2) Create the class constructor. Use the following method comment.
        
        /// <summary>
        /// Constructs a new instance of Seeker.
        /// </summary>
       

    // 3) Create the GetLocation() method. Use the following method comment.
        
        /// <summary>
        /// Gets the current location.
        /// </summary>
        /// <returns>The current location as an int.</returns>
        

    // 4) Create the MoveLocation(int location) method. Use the following method comment.
        
        /// <summary>
        /// Moves to the given location.
        /// </summary>
        /// <param name="location">The given location.</param>