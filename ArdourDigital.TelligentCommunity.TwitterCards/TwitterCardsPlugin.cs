using System;
using System.Collections.Generic;
using ArdourDigital.TelligentCommunity.TwitterCards.PrivateApi;
using Telligent.DynamicConfiguration.Components;
using Telligent.Evolution.Extensibility.Version1;
using ArdourDigital.TelligentCommunity.TwitterCards.VelocityExtensions;
using ArdourDigital.TelligentCommunity.TwitterCards.ContentFragments;

namespace ArdourDigital.TelligentCommunity.TwitterCards
{
    public class TwitterCardsPlugin : IPlugin, IRequiredConfigurationPlugin, IPluginGroup
    {
        public PropertyGroup[] ConfigurationOptions
        {
            get
            {
                var group = new PropertyGroup("options", "Options", 0);

                var siteHandle = new Property("siteHandle", "Site Twitter Username", PropertyType.String, 0, string.Empty);
                siteHandle.DescriptionText = "The twitter username for the site (e.g. @telligent)";

                group.Properties.Add(siteHandle);

                return new[] { group };
            }
        }

        public string Description
        {
            get
            {
                return "Allows Twitter Card support for content";
            }
        }

        public bool IsConfigured
        {
            get
            {
                return TwitterCardConfiguration.IsConfigured;
            }
        }

        public string Name
        {
            get
            {
                return "Ardour Digital - Twitter Cards";
            }
        }

        public IEnumerable<Type> Plugins
        {
            get
            {
                yield return typeof(TwitterCardsExtension);
                yield return typeof(TwitterCardsContentFragmentProvider);
            }
        }

        public void Initialize()
        {
        }

        public void Update(IPluginConfiguration configuration)
        {
            TwitterCardConfiguration.SiteTwitterHandle = configuration.GetString("siteHandle");
        }
    }
}
