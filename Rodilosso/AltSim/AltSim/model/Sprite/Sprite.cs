using System.Windows.Media.Imaging;
using Animation.Model.Animation;
using System;
using AltSim;

namespace Animation.Model.Sprite
{
    ///*
    /// Describes the Sprite entity, rather than the rappresentation of a dinamic object in game (Plane, Airstrip).
    ///
    /// it'll have:
    /// -   A background image,
    /// -   Coordinates x, y for the position in the Map,
    /// -   Width and height for the view rendering.
    ///
    public class Sprite
    {
        private System.Windows.Controls.Image sprite;

        /// <param name="urlSprite"> contains url of the image to load </param>
        public Sprite(string urlSprite)
        {
            try
            {
                System.Windows.Controls.Image bufferedSprite = new System.Windows.Controls.Image();

                bufferedSprite.Source = new BitmapImage(new Uri(SpriteType.AIRPLANE.Value));
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Wrong bufferedSprite or sprite initialization: " + e.Message);
            }

            ///resize calculation:
            ResizeSpriteToMap();
        }

        ///----------------------------------------------------------------

        /// Method to resize the image of the Sprite according to the size of the Main Screen.
        private void ResizeSpriteToMap()
        {
            int smallPlaneSizeHeight = 32;
            int smallPlaneSizeWidth = 32;

            if (MainWindow.GetWidth() >= 1280 && MainWindow.GetHeight() >= 920)
            if(true)
            {
                this.sprite.Width = smallPlaneSizeWidth * 2;
                this.sprite.Height = smallPlaneSizeHeight * 2;
            }
            else
            {
                this.sprite.Width = smallPlaneSizeWidth;
                this.sprite.Height = smallPlaneSizeHeight;
            }
        }

        /// <param name="newUrlImage"> the new Image to set into Sprite. </param>
        public void SetSpritePlane(string newUrlImage)
        {
            this.sprite.Source = (new BitmapImage(new Uri(SpriteType.AIRPLANE.Value)));
        }

        /// <returns> the ImageView of the Sprite. </returns>
        public System.Windows.Controls.Image GetSprite()
        {
            return this.sprite;
        } 
    }
}
