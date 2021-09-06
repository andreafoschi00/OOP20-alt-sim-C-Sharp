using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace TestAltSim.Animation
{
    [TestClass]
    public class ExplosionAnimationTest
    {
        private static readonly string workingDirectory = Environment.CurrentDirectory;
        private static readonly string UserHomeDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        private static readonly char UserSeparator = Path.DirectorySeparatorChar;
        private static readonly int N_SPRITES = 50;

        [Timeout(500)]
        [TestMethod]
        public void LoadImageTest()
        {
            try
            {
                string[] Documents = System.IO.Directory.GetFiles(UserHomeDirectory + UserSeparator + "src" + UserSeparator + "animation");
               
                int j = 0;

                for (int k = 1; k < N_SPRITES; k++, j++)
                {
                    String urlImage = UserHomeDirectory + UserSeparator + "src" + UserSeparator + "animation" + UserSeparator + "explosion_" + k + ".png";

                    char[] charsToTrim = { '\u005c' };
                    string[] split = Documents[j].Split('\u005c');

                    Assert.AreEqual(urlImage, (UserHomeDirectory + UserSeparator + "src" + UserSeparator + "animation" + UserSeparator + "explosion_" + k + ".png"));
                }
            }

            catch (Exception e)
            {
                Assert.Fail();
                System.Diagnostics.Debug.WriteLine(e.Message);
            }
        }
    }
}
