namespace Foschi.airstrip
{
    public enum AirStripStatus
    {
        /// <summary>
        /// The airstrip is free and ready for landing planes.
        /// </summary>
        Free,
        /// <summary>
        /// The airstrip is busy because a plane is landing right now.
        /// </summary>
        Busy,
        /// <summary>
        /// The airstrip is currently unavailable.
        /// </summary>
        Disabled
    }
}