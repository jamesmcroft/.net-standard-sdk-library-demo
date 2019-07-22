namespace MySDK.Devices
{
    /// <summary>
    /// Defines values associated with a <see cref="IDevice"/> form factor.
    /// </summary>
    public enum FormFactor
    {
        /// <summary>
        /// The device form factor is not known.
        /// </summary>
        Unknown,

        /// <summary>
        /// The device form factor is a desktop, e.g. a PC.
        /// </summary>
        Desktop,

        /// <summary>
        /// The device form factor is a tablet, e.g. one with a detachable keyboard.
        /// </summary>
        Tablet,

        /// <summary>
        /// The device form factor is a mobile, e.g. a phone.
        /// </summary>
        Mobile
    }
}