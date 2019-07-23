#if WINDOWS_UWP
namespace MySDK.Devices
{
    using Windows.System.Profile;

    /// <summary>
    /// Defines an implementation of <see cref="IDevice"/> for Windows.
    /// </summary>
    public class Device : IDevice
    {
        /// <summary>
        /// Gets the name of the device.
        /// </summary>
        public string Name => "Windows";

        /// <summary>
        /// Get the form factor of the device.
        /// </summary>
        public FormFactor FormFactor => FormFactor.Desktop;

        /// <summary>
        /// Gets the version number of the current OS.
        /// </summary>
        /// <returns>The version number as a <see cref="string"/>.</returns>
        public string GetOSVersion()
        {
            return AnalyticsInfo.VersionInfo.DeviceFamilyVersion;
        }
    }
}
#endif