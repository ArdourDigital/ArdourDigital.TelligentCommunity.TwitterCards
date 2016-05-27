namespace ArdourDigital.TelligentCommunity.TwitterCards.PrivateApi
{
    internal static class TwitterCardConfiguration
    {
        private static string _siteTwitterHandle;

        internal static string SiteTwitterHandle
        {
            get { return _siteTwitterHandle; }
            set { _siteTwitterHandle = value; }
        }

        internal static bool IsConfigured
        {
            get
            {
                return !string.IsNullOrWhiteSpace(_siteTwitterHandle);
            }
        }
    }
}
