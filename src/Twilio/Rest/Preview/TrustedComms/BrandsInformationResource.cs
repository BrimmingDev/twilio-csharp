/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// BrandsInformationResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.TrustedComms
{

    public class BrandsInformationResource : Resource
    {
        private static Request BuildFetchRequest(FetchBrandsInformationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/TrustedComms/BrandsInformation",
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve the newest available BrandInformation
        /// </summary>
        /// <param name="options"> Fetch BrandsInformation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandsInformation </returns>
        public static BrandsInformationResource Fetch(FetchBrandsInformationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Retrieve the newest available BrandInformation
        /// </summary>
        /// <param name="options"> Fetch BrandsInformation parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandsInformation </returns>
        public static async System.Threading.Tasks.Task<BrandsInformationResource> FetchAsync(FetchBrandsInformationOptions options,
                                                                                              ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Retrieve the newest available BrandInformation
        /// </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of BrandsInformation </returns>
        public static BrandsInformationResource Fetch(ITwilioRestClient client = null)
        {
            var options = new FetchBrandsInformationOptions();
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve the newest available BrandInformation
        /// </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of BrandsInformation </returns>
        public static async System.Threading.Tasks.Task<BrandsInformationResource> FetchAsync(ITwilioRestClient client = null)
        {
            var options = new FetchBrandsInformationOptions();
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a BrandsInformationResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> BrandsInformationResource object represented by the provided JSON </returns>
        public static BrandsInformationResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<BrandsInformationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// Creation time of the information retrieved
        /// </summary>
        [JsonProperty("update_time")]
        public DateTime? UpdateTime { get; private set; }
        /// <summary>
        /// The URL to the brands information
        /// </summary>
        [JsonProperty("file_link")]
        public Uri FileLink { get; private set; }
        /// <summary>
        /// How long will be the `file_link` valid
        /// </summary>
        [JsonProperty("file_link_ttl_in_seconds")]
        public string FileLinkTtlInSeconds { get; private set; }
        /// <summary>
        /// The URL of this resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private BrandsInformationResource()
        {

        }
    }

}