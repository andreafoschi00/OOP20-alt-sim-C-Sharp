using Animation.Model.Plane;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animation.Model.Game
{
    public interface Game
    {
        /// <returns> list of planes in game GETTER. </returns>
        public List<PlaneImpl> GetPlanes();

        /// <returns> list of planesToRemove GETTER. </returns>
        public List<PlaneImpl> GetPlanesToRemove();

        /// <param name="plane"> inserted into the plane List. </param>
        public void AddPlane(PlaneImpl plane);

        /// <param name="planeToRemove"> inserted into the planeToRemove List. </param>
        public void AddPlaneToRemove(PlaneImpl planeToRemove);

        /// Clear both the plane List(planes && planeToRemove).
        void clearPlanes();

        /// Removing all the planesTo remove from planes List. 
        void updatePlanes();

        /// Removing all the planesTo remove from planes List and clear the planesToRemove List.
        void removePlanes();

        /// <param name="inGame"> setted for choose if the Game is started or not. </param>
        void setInGame(bool inGame);

        /// <returns> number of Plane to spawn. </returns>
        int getNumberPlanesToSpawnEachTime();

        /// <param name="numberPlanesToSpawnEachTime"> Define the number of Plane to spawn. </param>
        void setNumberPlanesToSpawnEachTime(int numberPlanesToSpawnEachTime);
    }
}
