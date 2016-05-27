using ArdourDigital.TelligentCommunity.Core.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArdourDigital.TelligentCommunity.TwitterCards.ContentFragments
{
    public class TwitterCardDetails : IContentFragment
    {
        private readonly Guid _id = new Guid("5b56ce83-2526-4e21-87d2-419ca6a7f9ec");

        public string DefinitionFile
        {
            get
            {
                return "ArdourDigital.TelligentCommunity.TwitterCards.ContentFragments.Resources.TwitterCardDetails.TwitterCardDetails.xml";
            }
        }

        public Guid FragmentId
        {
            get
            {
                return _id;
            }
        }

        public IEnumerable<SupplementaryFile> SupplementaryFiles
        {
            get
            {
                return Enumerable.Empty<SupplementaryFile>();
            }
        }
    }
}
