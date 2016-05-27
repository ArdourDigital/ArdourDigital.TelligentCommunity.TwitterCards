using Telligent.Evolution.Extensibility.UI.Version1;
using Telligent.Evolution.Extensibility.Version1;

namespace ArdourDigital.TelligentCommunity.TwitterCards.VelocityExtensions
{
    public class TwitterCardsExtension : IScriptedContentFragmentExtension, IPlugin
    {
        public string Description
        {
            get
            {
                return "Twitter cards velocity extensions (ardour_v1_twitterCards)";
            }
        }

        public object Extension
        {
            get
            {
                return new PublicApi.TwitterCards();
            }
        }

        public string ExtensionName
        {
            get
            {
                return "ardour_v1_twitterCards";
            }
        }

        public string Name
        {
            get
            {
                return "Twitter Card Velocity Extensions";
            }
        }

        public void Initialize()
        {
        }
    }
}
