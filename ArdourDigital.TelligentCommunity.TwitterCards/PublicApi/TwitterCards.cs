using ArdourDigital.TelligentCommunity.TwitterCards.PrivateApi;
using System;
using Telligent.Evolution.Extensibility.Api.Version1;
using TelligentPublicApi = Telligent.Evolution.Extensibility.Api.Version1.PublicApi;

namespace ArdourDigital.TelligentCommunity.TwitterCards.PublicApi
{
    public class TwitterCards
    {
        public string SiteUsername
        {
            get
            {
                return TwitterCardConfiguration.SiteTwitterHandle;
            }
        }

        public string AuthorUsername(Guid contentId, Guid contentTypeId)
        {
            var content = TelligentPublicApi.Content.Get(contentId, contentTypeId);

            if (content == null)
            {
                return null;
            }

            if (!content.CreatedByUserId.HasValue)
            {
                return null;
            }

            var user = TelligentPublicApi.Users.Get(new UsersGetOptions { Id = content.CreatedByUserId.Value });

            if (user == null || !user.Id.HasValue)
            {
                return null;
            }

            var userTwitterField = user.ProfileFields["Twitter"];

            if (userTwitterField == null)
            {
                return null;
            }

            var userTwitter = userTwitterField.Value;

            if (string.IsNullOrWhiteSpace(userTwitter))
            {
                return null;
            }

            if (userTwitter.Contains("twitter.com"))
            {
                userTwitter = userTwitter
                    .Replace("www.", string.Empty)
                    .Replace("twitter.com", string.Empty)
                    .Replace("http://", string.Empty)
                    .Replace("https://", string.Empty)
                    .Trim(new[] { '/' });
            }

            if (!userTwitter.StartsWith("@"))
            {
                userTwitter = string.Format("@{0}", userTwitter);
            }

            return userTwitter;
        }

        public bool HasOpenGraphImage(Guid contentId, Guid contentTypeId)
        {
            if (contentTypeId == TelligentPublicApi.BlogPosts.ContentTypeId)
            {
                var post = TelligentPublicApi.BlogPosts.Get(contentId);
                return post != null && ((post.OpenGraphImage != null && !string.IsNullOrWhiteSpace(post.OpenGraphImage.FileUrl)) || !string.IsNullOrWhiteSpace(post.PostImageUrl));
            }
            else if (contentTypeId == TelligentPublicApi.Media.ContentTypeId)
            {
                var media = TelligentPublicApi.Media.Get(contentId);
                return media != null && media.OpenGraphImage != null && !string.IsNullOrWhiteSpace(media.OpenGraphImage.FileUrl);
            }

            return false;
        }

        public bool IsImageContentType(string contentType)
        {
            if (string.IsNullOrWhiteSpace(contentType))
            {
                return false;
            }

            return contentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase);
        }
    }
}
