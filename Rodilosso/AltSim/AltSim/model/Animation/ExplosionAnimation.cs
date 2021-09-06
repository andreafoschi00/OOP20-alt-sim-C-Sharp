using AltSim;
using System;
using System.Threading;
using System.Timers;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Animation.Model.Animation
{
    class ExplosionAnimation : Animation
    {
        private static readonly int DURATION_KEYFRAME = 100;
        private static readonly int CYCLES = 50;

        private Image imgExplosion;
        private System.Timers.Timer timerAnimation;
        private int contImage = 1;

        public ExplosionAnimation()
        {
            imgExplosion = new Image();
            imgExplosion.Source = new BitmapImage(new Uri(MainWindow.GetUserHomeDirectory() + "/src/animation/explosion_" + contImage + ".png"));

            SettingDefaultAnimationOptions();
        }

        private void SettingDefaultAnimationOptions()
        {
            /// Create a timer with a two second interval.
            timerAnimation = new System.Timers.Timer(ExplosionAnimation.DURATION_KEYFRAME);
            /// Hook up the Elapsed event for the timer. 
            timerAnimation.Elapsed += OnTimedEvent;
            /// Indicate if Timer must generate Elapsed event once (false) or more times (true).
            timerAnimation.AutoReset = true;
            /// Indicate if Timer must generate Elapsed event.
            timerAnimation.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            /// Reduce the image opacity to simulate the Fade transition.
            imgExplosion.Dispatcher.Invoke(() =>
            {
                if (contImage < CYCLES)
                {
                    imgExplosion.Source = new BitmapImage(new Uri(MainWindow.GetUserHomeDirectory() + "/src/animation/explosion_" + contImage + ".png"));
                    contImage++;
                }
                else
                {
                    timerAnimation.Stop();
                }
            });
        }

        public void Start()
        {            
            /// Start the Animation
            timerAnimation.Start();
        }

        public Image GetImgExplosion()
        {
            return imgExplosion;
        }
    }
}
