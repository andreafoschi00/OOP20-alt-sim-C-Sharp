using AltSim;

namespace Animation.Model.Animation
{
    class SpriteType
    {
        private SpriteType(string value) { Value = value; }

        public string Value { get; private set; }

        /// Plane image path.
        public static SpriteType AIRPLANE { get { return new SpriteType(MainWindow.GetUserHomeDirectory() + "/src/map_components/airplane.png"); } }
        /// Plane Selected image path.
        public static SpriteType AIRPLANE_SELECTED { get { return new SpriteType(MainWindow.GetUserHomeDirectory() + "/src/map_components/airplaneSelected.png"); } }
        /// Airstrip image path.
        public static SpriteType AIRSTRIP { get { return new SpriteType(MainWindow.GetUserHomeDirectory() + "/src/map_components/singleAirstrip.png"); } }
        /// Boat image path.
        public static SpriteType BOAT { get { return new SpriteType(MainWindow.GetUserHomeDirectory() +"/src/map_components/boat.png"); } }
        /// Helicopter image path.
        public static SpriteType HELICOPTER { get { return new SpriteType(MainWindow.GetUserHomeDirectory() + "/src/map_components/helicopter.png"); } }
        /// Helipad image path.
        public static SpriteType HELIPAD { get { return new SpriteType(MainWindow.GetUserHomeDirectory() + "/src/map_components/helipad.png"); } }
        /// Indicator image path.
        public static SpriteType INDICATOR { get { return new SpriteType(MainWindow.GetUserHomeDirectory() + "/src/map_components/indicator.png"); } }
    }
}
