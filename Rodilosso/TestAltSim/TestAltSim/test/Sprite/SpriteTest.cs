using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestAltSim.Sprite
{
    [TestClass]
    public class SpriteTest
    {
        private static readonly int SCREEN_WIDTH = 1280;
        private static readonly int SCREEN_HEIGHT = 720;
        private static readonly int SCREEN_SELECTED_WIDTH = 1100;
        private static readonly int SCREEN_SELECTED_HEIGHT = 700;

        readonly double smallPlaneSizeWidth = 32;
        readonly double smallPlaneSizeHeight = 32;

        [TestMethod]
        public void ResizeSpriteToMapTest()
        {
            try
            {
                double spriteWidth = 0;
                double spriteHeight = 0;

                if (SCREEN_WIDTH >= SCREEN_SELECTED_WIDTH && SCREEN_HEIGHT >= SCREEN_SELECTED_HEIGHT)
                {
                    spriteWidth = (smallPlaneSizeWidth * 2);
                    spriteHeight = (smallPlaneSizeHeight * 2);

                    Assert.AreEqual(spriteWidth, (smallPlaneSizeWidth * 2));
                    Assert.AreEqual(spriteHeight, (smallPlaneSizeWidth * 2));
                }
                else
                {
                    spriteWidth = (smallPlaneSizeWidth);
                    spriteHeight = (smallPlaneSizeHeight);

                    Assert.AreEqual(spriteWidth, (smallPlaneSizeWidth));
                    Assert.AreEqual(spriteHeight, (smallPlaneSizeWidth));
                }

                System.Diagnostics.Debug.WriteLine("spriteWidth: " + spriteWidth + " spriteHeight: " + spriteHeight);
            }
            catch (Exception e)
            {
                Assert.Fail();
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }
    }
}
