using Animation.Model.Plane;
using System.Collections.Generic;

namespace Animation.Model.Game
{
    class GameImpl
    {

        /// Section Spawn Plane
        private static readonly int MAX_PLANE_TO_SPAWN = 10;
        private static readonly int SPAWN_DELAY = 10;
        private static readonly int GAME_SCORE_LANDING = 100;
        private static readonly int COORDINATES_LIMIT = 200;
        private static readonly int MIN_COORDINATES_LENGTH = 5;
        private static readonly int MAX_DISTANCE_DRAW_PATH_VALUE = 150;

        private int numberPlanesToSpawnEachTime;
        private List<PlaneImpl> planes;
        private List<PlaneImpl> planesToRemove;
        private bool inGame;

        public GameImpl()
        {
            this.inGame = false;
            this.planes = new List<PlaneImpl>();
            this.planesToRemove = new List<PlaneImpl>();
            this.numberPlanesToSpawnEachTime = 1;
        }

        /// Section PLANES
        ///------------------------------------------------------------------------

        /// <inheritdoc />
        public List<PlaneImpl> GetPlanes()
        {
            return this.planes;
        }

        /// <inheritdoc />
        public List<PlaneImpl> GetPlanesToRemove()
        {
            return this.planesToRemove;
        }

        /// <inheritdoc />
        public void AddPlane(PlaneImpl plane)
        {
            this.planes.Add(plane);
        }

        /// <inheritdoc />
        public void AddPlaneToRemove(PlaneImpl planeToRemove)
        {
            this.planesToRemove.Add(planeToRemove);
        }

        /// <inheritdoc />
        public void ClearPlanes()
        {
            this.planes.Clear();
            this.planesToRemove.Clear();
        }

        /// <inheritdoc />
        public void UpdatePlanes()
        {
            planesToRemove.ForEach(elem =>
            {
                if (planes.Contains(elem))
                {
                    planes.Remove(elem);
                }
            });
        }

        /// <inheritdoc />
        public void RemovePlanes()
        {
            planesToRemove.ForEach(elem =>
            {
                if (planes.Contains(elem))
                {
                    planes.Remove(elem);
                }
            });

            planesToRemove.Clear();
        }

        /// <inheritdoc />
        public void SetInGame(bool inGame)
        {
            this.inGame = inGame;
        }

        /// <summary> value of state of Game. </summary> 
        /// <returns> user name </returns>
        public bool IsInGame()
        {
            return this.inGame;
        }

        /// <inheritdoc />
        public int GetNumberPlanesToSpawnEachTime()
        {
            return numberPlanesToSpawnEachTime;
        }

        /// <inheritdoc />
        public void SetNumberPlanesToSpawnEachTime(int numberPlanesToSpawnEachTime)
        {
            this.numberPlanesToSpawnEachTime = numberPlanesToSpawnEachTime;
        }

        /// <returns> MAX number of Plane to spawn in Game. </returns>
        public static int GetMaxPlaneToSpawn()
        {
            return MAX_PLANE_TO_SPAWN;
        }

        /// <returns> the creation of Plane delay. </returns>
        public static int GetSpawnDelay()
        {
            return SPAWN_DELAY;
        }

        /// <returns> the game score to update when a Plane is land. </returns>
        public static int GetGameScoreLanding()
        {
            return GAME_SCORE_LANDING;
        }

        public static int GetMinCoordinatesLength()
        {
            return MIN_COORDINATES_LENGTH;
        }

        public static int GetMaxDistanceDrawPathValue()
        {
            return MAX_DISTANCE_DRAW_PATH_VALUE;
        }

        public static int GetCoordinatesLimit()
        {
            return COORDINATES_LIMIT;
        }
    }
}
