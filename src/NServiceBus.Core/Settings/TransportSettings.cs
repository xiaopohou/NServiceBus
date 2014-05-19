namespace NServiceBus.Settings
{
    /// <summary>
    /// Placeholder for the various extensions. Transports will add extension methods to this class.
    /// </summary>
    public class TransportSettings
    {
        readonly Configure config;

        public TransportSettings(Configure config)
        {
            this.config = config;
        }
    }
}