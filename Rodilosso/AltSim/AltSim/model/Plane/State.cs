using System;
using System.Collections.Generic;
using System.Text;

namespace Animation.Model.Plane
{
    /// Enum describing the states a Plane can have during the game.
    enum State
    {
        /// (0) Plane is Spawned.
        SPAWNING,

        /// (1) Plane waiting to Move.
        WAITING,

        /// (2) Plane is moving in random Path.
        RANDOM_MOVEMENT,

        /// (3) Plane is moving following User Path.
        USER_MOVEMENT,

        ///(4) Plane is landing in AirStrip.
        LANDED,

        /// (5) Plane is stopped when game is over.
        TERMINATED
    }
}
