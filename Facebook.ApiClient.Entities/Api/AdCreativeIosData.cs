using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Facebook.ApiClient.Entities.Api
{
    /// <inheritdoc />
    /// <summary>
    /// The specification for iOS template spec.
    /// <para>https://developers.facebook.com/docs/marketing-api/reference/ad-creative-ios-data/</para>
    /// </summary>
    public class AdCreativeIosData : BaseEntity
    {
        /// <summary>
        /// The name of the iOS app, suitable for display, e.g. Electronic Example iOS
        /// </summary>
        [DeserializeAs(Name = "app_name")]
        [JsonProperty(PropertyName = "app_name", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AppName { get; set; }

        /// <summary>
        /// The app ID for the App Store, e.g. 1234
        /// </summary>
        [DeserializeAs(Name = "app_store_id")]
        [JsonProperty(PropertyName = "app_store_id", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string AppStoreId { get; set; }

        /// <summary>
        /// A custom scheme for the iOS app, e.g. example-ios://electronic/id={{product.retailor_id | urlencode}}
        /// </summary>
        [DeserializeAs(Name = "url")]
        [JsonProperty(PropertyName = "url", ReferenceLoopHandling = ReferenceLoopHandling.Serialize, DefaultValueHandling = DefaultValueHandling.Ignore, NullValueHandling = NullValueHandling.Ignore, ObjectCreationHandling = ObjectCreationHandling.Auto)]
        public string Url { get; set; }
    }
}
