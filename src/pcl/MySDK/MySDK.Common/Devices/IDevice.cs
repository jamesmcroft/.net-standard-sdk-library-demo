namespace MySDK.Devices
{
    /// <summary>
    /// Defines an interface for a device.
    /// </summary>
    public interface IDevice
    {
        /// <summary>
        /// Gets the name of the device.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Get the form factor of the device.
        /// </summary>
        FormFactor FormFactor { get; }

        /// <summary>
        /// Gets the version number of the current OS.
        /// </summary>
        /// <returns>The version number as a <see cref="string"/>.</returns>
        string GetOSVersion();
    }
}