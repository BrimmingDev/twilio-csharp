/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// CompositionResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Video.V1
{

    public class CompositionResource : Resource
    {
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Enqueued = new StatusEnum("enqueued");
            public static readonly StatusEnum Processing = new StatusEnum("processing");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum Deleted = new StatusEnum("deleted");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
        }

        public sealed class FormatEnum : StringEnum
        {
            private FormatEnum(string value) : base(value) {}
            public FormatEnum() {}
            public static implicit operator FormatEnum(string value)
            {
                return new FormatEnum(value);
            }

            public static readonly FormatEnum Mp4 = new FormatEnum("mp4");
            public static readonly FormatEnum Webm = new FormatEnum("webm");
        }

        private static Request BuildFetchRequest(FetchCompositionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                "/v1/Compositions/" + options.PathSid + "",
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Returns a single Composition resource identified by a Composition SID.
        /// </summary>
        /// <param name="options"> Fetch Composition parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Composition </returns>
        public static CompositionResource Fetch(FetchCompositionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Returns a single Composition resource identified by a Composition SID.
        /// </summary>
        /// <param name="options"> Fetch Composition parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Composition </returns>
        public static async System.Threading.Tasks.Task<CompositionResource> FetchAsync(FetchCompositionOptions options,
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Returns a single Composition resource identified by a Composition SID.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Composition </returns>
        public static CompositionResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchCompositionOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a single Composition resource identified by a Composition SID.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Composition </returns>
        public static async System.Threading.Tasks.Task<CompositionResource> FetchAsync(string pathSid,
                                                                                        ITwilioRestClient client = null)
        {
            var options = new FetchCompositionOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadCompositionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                "/v1/Compositions",
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// List of all Recording compositions.
        /// </summary>
        /// <param name="options"> Read Composition parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Composition </returns>
        public static ResourceSet<CompositionResource> Read(ReadCompositionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<CompositionResource>.FromJson("compositions", response.Content);
            return new ResourceSet<CompositionResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// List of all Recording compositions.
        /// </summary>
        /// <param name="options"> Read Composition parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Composition </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CompositionResource>> ReadAsync(ReadCompositionOptions options,
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<CompositionResource>.FromJson("compositions", response.Content);
            return new ResourceSet<CompositionResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// List of all Recording compositions.
        /// </summary>
        /// <param name="status"> Read only Composition resources with this status </param>
        /// <param name="dateCreatedAfter"> Read only Composition resources created on or after this [ISO
        ///                        8601](https://en.wikipedia.org/wiki/ISO_8601) date-time with time zone </param>
        /// <param name="dateCreatedBefore"> Read only Composition resources created before this ISO 8601 date-time with time
        ///                         zone </param>
        /// <param name="roomSid"> Read only Composition resources with this Room SID </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Composition </returns>
        public static ResourceSet<CompositionResource> Read(CompositionResource.StatusEnum status = null,
                                                            DateTime? dateCreatedAfter = null,
                                                            DateTime? dateCreatedBefore = null,
                                                            string roomSid = null,
                                                            int? pageSize = null,
                                                            long? limit = null,
                                                            ITwilioRestClient client = null)
        {
            var options = new ReadCompositionOptions(){Status = status, DateCreatedAfter = dateCreatedAfter, DateCreatedBefore = dateCreatedBefore, RoomSid = roomSid, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// List of all Recording compositions.
        /// </summary>
        /// <param name="status"> Read only Composition resources with this status </param>
        /// <param name="dateCreatedAfter"> Read only Composition resources created on or after this [ISO
        ///                        8601](https://en.wikipedia.org/wiki/ISO_8601) date-time with time zone </param>
        /// <param name="dateCreatedBefore"> Read only Composition resources created before this ISO 8601 date-time with time
        ///                         zone </param>
        /// <param name="roomSid"> Read only Composition resources with this Room SID </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Composition </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CompositionResource>> ReadAsync(CompositionResource.StatusEnum status = null,
                                                                                                    DateTime? dateCreatedAfter = null,
                                                                                                    DateTime? dateCreatedBefore = null,
                                                                                                    string roomSid = null,
                                                                                                    int? pageSize = null,
                                                                                                    long? limit = null,
                                                                                                    ITwilioRestClient client = null)
        {
            var options = new ReadCompositionOptions(){Status = status, DateCreatedAfter = dateCreatedAfter, DateCreatedBefore = dateCreatedBefore, RoomSid = roomSid, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<CompositionResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<CompositionResource>.FromJson("compositions", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<CompositionResource> NextPage(Page<CompositionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Video)
            );

            var response = client.Request(request);
            return Page<CompositionResource>.FromJson("compositions", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<CompositionResource> PreviousPage(Page<CompositionResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Video)
            );

            var response = client.Request(request);
            return Page<CompositionResource>.FromJson("compositions", response.Content);
        }

        private static Request BuildDeleteRequest(DeleteCompositionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Video,
                "/v1/Compositions/" + options.PathSid + "",
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Delete a Recording Composition resource identified by a Composition SID.
        /// </summary>
        /// <param name="options"> Delete Composition parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Composition </returns>
        public static bool Delete(DeleteCompositionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete a Recording Composition resource identified by a Composition SID.
        /// </summary>
        /// <param name="options"> Delete Composition parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Composition </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteCompositionOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete a Recording Composition resource identified by a Composition SID.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Composition </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteCompositionOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete a Recording Composition resource identified by a Composition SID.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Composition </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteCompositionOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateCompositionOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Video,
                "/v1/Compositions",
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Composition parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Composition </returns>
        public static CompositionResource Create(CreateCompositionOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Composition parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Composition </returns>
        public static async System.Threading.Tasks.Task<CompositionResource> CreateAsync(CreateCompositionOptions options,
                                                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="roomSid"> The SID of the Group Room with the media tracks to be used as composition sources </param>
        /// <param name="videoLayout"> An object that describes the video layout of the composition </param>
        /// <param name="audioSources"> An array of track names from the same group room to merge </param>
        /// <param name="audioSourcesExcluded"> An array of track names to exclude </param>
        /// <param name="resolution"> A string that describes the columns (width) and rows (height) of the generated composed
        ///                  video in pixels </param>
        /// <param name="format"> The container format of the composition's media files </param>
        /// <param name="statusCallback"> The URL we should call to send status information to your application </param>
        /// <param name="statusCallbackMethod"> The HTTP method we should use to call status_callback </param>
        /// <param name="trim"> Whether to clip the intervals where there is no active media in the composition </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Composition </returns>
        public static CompositionResource Create(string roomSid,
                                                 object videoLayout = null,
                                                 List<string> audioSources = null,
                                                 List<string> audioSourcesExcluded = null,
                                                 string resolution = null,
                                                 CompositionResource.FormatEnum format = null,
                                                 Uri statusCallback = null,
                                                 Twilio.Http.HttpMethod statusCallbackMethod = null,
                                                 bool? trim = null,
                                                 ITwilioRestClient client = null)
        {
            var options = new CreateCompositionOptions(roomSid){VideoLayout = videoLayout, AudioSources = audioSources, AudioSourcesExcluded = audioSourcesExcluded, Resolution = resolution, Format = format, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, Trim = trim};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="roomSid"> The SID of the Group Room with the media tracks to be used as composition sources </param>
        /// <param name="videoLayout"> An object that describes the video layout of the composition </param>
        /// <param name="audioSources"> An array of track names from the same group room to merge </param>
        /// <param name="audioSourcesExcluded"> An array of track names to exclude </param>
        /// <param name="resolution"> A string that describes the columns (width) and rows (height) of the generated composed
        ///                  video in pixels </param>
        /// <param name="format"> The container format of the composition's media files </param>
        /// <param name="statusCallback"> The URL we should call to send status information to your application </param>
        /// <param name="statusCallbackMethod"> The HTTP method we should use to call status_callback </param>
        /// <param name="trim"> Whether to clip the intervals where there is no active media in the composition </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Composition </returns>
        public static async System.Threading.Tasks.Task<CompositionResource> CreateAsync(string roomSid,
                                                                                         object videoLayout = null,
                                                                                         List<string> audioSources = null,
                                                                                         List<string> audioSourcesExcluded = null,
                                                                                         string resolution = null,
                                                                                         CompositionResource.FormatEnum format = null,
                                                                                         Uri statusCallback = null,
                                                                                         Twilio.Http.HttpMethod statusCallbackMethod = null,
                                                                                         bool? trim = null,
                                                                                         ITwilioRestClient client = null)
        {
            var options = new CreateCompositionOptions(roomSid){VideoLayout = videoLayout, AudioSources = audioSources, AudioSourcesExcluded = audioSourcesExcluded, Resolution = resolution, Format = format, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, Trim = trim};
            return await CreateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a CompositionResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CompositionResource object represented by the provided JSON </returns>
        public static CompositionResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<CompositionResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The status of the composition
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CompositionResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// Date when the media processing task finished
        /// </summary>
        [JsonProperty("date_completed")]
        public DateTime? DateCompleted { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the composition generated media was deleted
        /// </summary>
        [JsonProperty("date_deleted")]
        public DateTime? DateDeleted { get; private set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Group Room that generated the audio and video tracks used in the composition
        /// </summary>
        [JsonProperty("room_sid")]
        public string RoomSid { get; private set; }
        /// <summary>
        /// The array of track names to include in the composition
        /// </summary>
        [JsonProperty("audio_sources")]
        public List<string> AudioSources { get; private set; }
        /// <summary>
        /// The array of track names to exclude from the composition
        /// </summary>
        [JsonProperty("audio_sources_excluded")]
        public List<string> AudioSourcesExcluded { get; private set; }
        /// <summary>
        /// An object that describes the video layout of the composition
        /// </summary>
        [JsonProperty("video_layout")]
        public object VideoLayout { get; private set; }
        /// <summary>
        /// The dimensions of the video image in pixels expressed as columns (width) and rows (height)
        /// </summary>
        [JsonProperty("resolution")]
        public string Resolution { get; private set; }
        /// <summary>
        /// Whether to remove intervals with no media
        /// </summary>
        [JsonProperty("trim")]
        public bool? Trim { get; private set; }
        /// <summary>
        /// The container format of the composition's media files as specified in the POST request that created the Composition resource
        /// </summary>
        [JsonProperty("format")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CompositionResource.FormatEnum Format { get; private set; }
        /// <summary>
        /// The average bit rate of the composition's media
        /// </summary>
        [JsonProperty("bitrate")]
        public int? Bitrate { get; private set; }
        /// <summary>
        /// The size of the composed media file in bytes
        /// </summary>
        [JsonProperty("size")]
        public long? Size { get; private set; }
        /// <summary>
        /// The duration of the composition's media file in seconds
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; private set; }
        /// <summary>
        /// The absolute URL of the resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The URL of the media file associated with the composition
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private CompositionResource()
        {

        }
    }

}