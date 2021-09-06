using AltSim;
using System;
using System.Threading;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Animation.Model.Animation
{
    class Animation : AnimationPlane
    {
        private static readonly int DURATION_LANDING_ANIMATION = 1000;

        protected Image spriteAnimated;
        protected System.Timers.Timer scaleAnimation;

        public Animation(Image spriteAnimated)
        {
            this.spriteAnimated = spriteAnimated;
            SettingDefaultAnimationOptions();
        }

        public Animation()
        {
            spriteAnimated = new Image();
            spriteAnimated.Source = new BitmapImage(new Uri(MainWindow.GetUserHomeDirectory() + "/src/animation/explosion_1.png"));

            SettingDefaultAnimationOptions();
        }

        /// Set the TransitionAnimation with right defaults values.
        protected void SettingDefaultAnimationOptions()
        {
            /// Create a timer with a two second interval.
            scaleAnimation = new System.Timers.Timer(Animation.DURATION_LANDING_ANIMATION);
            /// Hook up the Elapsed event for the timer. 
            scaleAnimation.Elapsed += OnTimedEvent;
            /// Indicate if Timer must generate Elapsed event once (false) or more times (true).
            scaleAnimation.AutoReset = true;
            /// Indicate if Timer must generate Elapsed event.
            scaleAnimation.Enabled = true;
        }

        protected void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            /// Reduce the image opacity to simulate the Fade transition.
            spriteAnimated.Dispatcher.Invoke(() => {
                spriteAnimated.Opacity -= 0.1;

                if (spriteAnimated.ActualWidth - 15 >= 0 &&
                    spriteAnimated.ActualHeight - 15 >= 0)
                {
                    spriteAnimated.Width = spriteAnimated.ActualWidth - 15;
                    spriteAnimated.Height = spriteAnimated.ActualHeight - 15;
                } else
                {
                    spriteAnimated.Width = 0;
                    spriteAnimated.Height = 0;
                }
            });
        }

        /// <returns> LandingAnimation setted and ready to play. </returns>
        public System.Timers.Timer GetLandingAnimation()
        {
            return scaleAnimation;
        }

        /// <inheritdoc/>
        public void Start()
        {
            new Thread(SettingDefaultAnimationOptions).Start();
        }

        /// animation duration value GETTER.
        public static double GetDurationAnimation()
        {
            return DURATION_LANDING_ANIMATION;
        }
    }
}
