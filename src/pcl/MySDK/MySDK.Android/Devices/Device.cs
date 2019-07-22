namespace MySDK.Devices
{
    using Android.OS;

    /// <summary>
    /// Defines an implementation of <see cref="IDevice"/> for Android.
    /// </summary>
    public class Device : IDevice
    {
        /// <summary>
        /// Gets the name of the device.
        /// </summary>
        public string Name => "Android";

        /// <summary>
        /// Get the form factor of the device.
        /// </summary>
        public FormFactor FormFactor => FormFactor.Mobile;

        /// <summary>
        /// Gets the version number of the current OS.
        /// </summary>
        /// <returns>The version number as a <see cref="string"/>.</returns>
        public string GetOSVersion()
        {
            return ((int)Build.VERSION.SdkInt).ToString();
        }
    }
}