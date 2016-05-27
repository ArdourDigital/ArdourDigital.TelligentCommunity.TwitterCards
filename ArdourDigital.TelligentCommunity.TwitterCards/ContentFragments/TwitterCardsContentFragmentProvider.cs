using ArdourDigital.TelligentCommunity.Core.UI;
using System;
using Telligent.Evolution.Extensibility.UI.Version1;
using Telligent.Evolution.Extensibility.Version1;

namespace ArdourDigital.TelligentCommunity.TwitterCards.ContentFragments
{
    public class TwitterCardsContentFragmentProvider : BaseContentFragmentProvider, IPlugin, IScriptedContentFragmentFactoryDefaultProvider, IInstallablePlugin
    {
        public override string Description
        {
            get
            {
                return "Factory default content fragment provider for Twitter Card related content fragments";
            }
        }

        public override string Name
        {
            get
            {
                return "Twitter Cards Content Fragments";
            }
        }

        public override Guid ScriptedContentFragmentFactoryDefaultIdentifier
        {
            get
            {
                return new Guid("553401ca-91b0-4374-835b-980999a4325d");
            }
        }
    }
}
