using System.Windows.Controls;

namespace Animation.Model.Animation
{
    class LandingAnimation : Animation
    {
        private System.Timers.Timer timerAnimation;

        public LandingAnimation(Image spriteToApplyAnimation) : base(spriteToApplyAnimation)
        {

        }

        /// <inheritdoc/> 
        public void Start()
        {
            SettingDefaultAnimationOptions();
            GetLandingAnimation().Start();
        }
    }
}
