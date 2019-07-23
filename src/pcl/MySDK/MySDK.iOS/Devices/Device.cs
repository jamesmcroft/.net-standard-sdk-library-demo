namespace MySDK.Devices
{
    using UIKit;

    /// <summary>
    /// Defines an implementation of <see cref="IDevice"/> for iOS.
    /// </summary>
    public class Device : IDevice
    {
        /// <summary>
        /// Gets the name of the device.
        /// </summary>
        public string Name => "iPad";

        /// <summary>
        /// Get the form factor of the device.
        /// </summary>
        public FormFactor FormFactor => FormFactor.Tablet;

        /// <summary>
        /// Gets the version number of the current OS.
        /// </summary>
        /// <returns>The version number as a <see cref="string"/>.</returns>
        public string GetOSVersion()
        {
            return UIDevice.CurrentDevice.SystemVersion;
        }
    }
}