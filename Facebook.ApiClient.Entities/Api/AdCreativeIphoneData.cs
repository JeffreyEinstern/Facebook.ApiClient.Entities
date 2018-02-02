using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Facebook.ApiClient.Entities.Api
{
    /// <inheritdoc />
    /// <summary>
    /// The specification for iPhone template spec.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-iphone-data/</para>
    /// </summary>
    public class AdCreativeIphoneData : BaseEntity
    {
        /// <summary>
        /// The name of the app, suitable for display, e.g. Electronic Example iPhone
        /// </summary>
        [DeserializeAs(Name = "app_name")]
        [JsonProperty(PropertyName = "app_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AppName { get; set; }

        /// <summary>
        /// The app ID for the App Store, e.g. 5678
        /// </summary>
        [DeserializeAs(Name = "app_store_id")]
        [JsonProperty(PropertyName = "app_store_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AppStoreId { get; set; }

        /// <summary>
        /// A custom URL scheme for the iPhone app, e.g. example-iphone://electronic/?search={{product.name | urlencode}}
        /// </summary>
        [DeserializeAs(Name = "url")]
        [JsonProperty(PropertyName = "url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Url { get; set; }
    }
}
