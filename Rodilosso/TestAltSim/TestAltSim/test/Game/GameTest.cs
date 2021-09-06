using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAltSim.Game;
using System.Collections.Generic;
using System;

namespace TestAltSim
{
    [TestClass]
    public class GameTest
    {
        // Section Spawn Plane
        private static readonly int MAX_PLANE_TO_SPAWN = 10;
       
        private int numberPlanesToSpawnEachTime;
        private List<PlaneImplTest> planes;
        private List<PlaneImplTest> planesToRemove;
        private bool inGame;

        [TestMethod]
        public void AddPlaneTest()
        {
            planes = new List<PlaneImplTest>();

            PlaneImplTest p1 = new PlaneImplTest();
            PlaneImplTest p2 = new PlaneImplTest();
            PlaneImplTest p3 = new PlaneImplTest();

            AddPlane(p1);
            AddPlane(p1);
            AddPlane(p3);

            Assert.IsFalse(SearchDuplicate(planes));
        }

        private void AddPlane(PlaneImplTest plane)
        {
            planes = new List<PlaneImplTest>();

            if (planes.Contains(plane) == false && planes.Count < MAX_PLANE_TO_SPAWN)
            {
                planes.Add(plane);
            }
        }

        private void AddPlaneToRemove(PlaneImplTest plane)
        {
            planesToRemove = new List<PlaneImplTest>();

            if (planesToRemove.Contains(plane) == false && planesToRemove.Count < MAX_PLANE_TO_SPAWN)
            {
                planesToRemove.Add(plane);
            }
        }

        [TestMethod]
        public void ClearPlanesTest()
        {
            planes = new List<PlaneImplTest>();
            planesToRemove = new List<PlaneImplTest>();

            PlaneImplTest p1 = new PlaneImplTest();
            PlaneImplTest p2 = new PlaneImplTest();
            PlaneImplTest p3 = new PlaneImplTest();

            AddPlane(p1);
            AddPlane(p1);
            AddPlane(p3);

            AddPlaneToRemove(p1);
            AddPlaneToRemove(p1);
            AddPlaneToRemove(p2);

            planes.Clear();
            planesToRemove.Clear();

            Assert.AreEqual(0, planes.Count);
            Assert.AreEqual(0, planesToRemove.Count);
        }

        private bool SearchDuplicate(List<PlaneImplTest> listDuplicate)
        {

            foreach (var planeMonitored in listDuplicate)
            {
                int nDuplicate = 0;

                foreach (var plane in listDuplicate)
                {
                    if (planeMonitored.GetHashCode() == plane.GetHashCode())
                    {
                        nDuplicate++;
                    }
                }

                if (nDuplicate >= 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
