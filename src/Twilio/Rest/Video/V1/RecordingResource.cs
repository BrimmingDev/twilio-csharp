/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// RecordingResource
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

    public class RecordingResource : Resource
    {
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Processing = new StatusEnum("processing");
            public static readonly StatusEnum Completed = new StatusEnum("completed");
            public static readonly StatusEnum Deleted = new StatusEnum("deleted");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
        }

        public sealed class TypeEnum : StringEnum
        {
            private TypeEnum(string value) : base(value) {}
            public TypeEnum() {}
            public static implicit operator TypeEnum(string value)
            {
                return new TypeEnum(value);
            }

            public static readonly TypeEnum Audio = new TypeEnum("audio");
            public static readonly TypeEnum Video = new TypeEnum("video");
            public static readonly TypeEnum Data = new TypeEnum("data");
        }

        public sealed class FormatEnum : StringEnum
        {
            private FormatEnum(string value) : base(value) {}
            public FormatEnum() {}
            public static implicit operator FormatEnum(string value)
            {
                return new FormatEnum(value);
            }

            public static readonly FormatEnum Mka = new FormatEnum("mka");
            public static readonly FormatEnum Mkv = new FormatEnum("mkv");
        }

        public sealed class CodecEnum : StringEnum
        {
            private CodecEnum(string value) : base(value) {}
            public CodecEnum() {}
            public static implicit operator CodecEnum(string value)
            {
                return new CodecEnum(value);
            }

            public static readonly CodecEnum Vp8 = new CodecEnum("VP8");
            public static readonly CodecEnum H264 = new CodecEnum("H264");
            public static readonly CodecEnum Opus = new CodecEnum("OPUS");
            public static readonly CodecEnum Pcmu = new CodecEnum("PCMU");
        }

        private static Request BuildFetchRequest(FetchRecordingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                "/v1/Recordings/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Returns a single Recording resource identified by a Recording SID.
        /// </summary>
        /// <param name="options"> Fetch Recording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Recording </returns>
        public static RecordingResource Fetch(FetchRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Returns a single Recording resource identified by a Recording SID.
        /// </summary>
        /// <param name="options"> Fetch Recording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Recording </returns>
        public static async System.Threading.Tasks.Task<RecordingResource> FetchAsync(FetchRecordingOptions options,
                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Returns a single Recording resource identified by a Recording SID.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Recording </returns>
        public static RecordingResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchRecordingOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns a single Recording resource identified by a Recording SID.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Recording </returns>
        public static async System.Threading.Tasks.Task<RecordingResource> FetchAsync(string pathSid,
                                                                                      ITwilioRestClient client = null)
        {
            var options = new FetchRecordingOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadRecordingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Video,
                "/v1/Recordings",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// List of all Track recordings.
        /// </summary>
        /// <param name="options"> Read Recording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Recording </returns>
        public static ResourceSet<RecordingResource> Read(ReadRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<RecordingResource>.FromJson("recordings", response.Content);
            return new ResourceSet<RecordingResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// List of all Track recordings.
        /// </summary>
        /// <param name="options"> Read Recording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Recording </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<RecordingResource>> ReadAsync(ReadRecordingOptions options,
                                                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<RecordingResource>.FromJson("recordings", response.Content);
            return new ResourceSet<RecordingResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// List of all Track recordings.
        /// </summary>
        /// <param name="status"> Read only the recordings that have this status </param>
        /// <param name="sourceSid"> Read only the recordings that have this source_sid </param>
        /// <param name="groupingSid"> Read only recordings that have this grouping_sid </param>
        /// <param name="dateCreatedAfter"> Read only recordings that started on or after this [ISO
        ///                        8601](https://en.wikipedia.org/wiki/ISO_8601) date-time with time zone </param>
        /// <param name="dateCreatedBefore"> Read only recordings that started before this [ISO
        ///                         8601](https://en.wikipedia.org/wiki/ISO_8601) date-time with time zone </param>
        /// <param name="mediaType"> Read only recordings that have this media type </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Recording </returns>
        public static ResourceSet<RecordingResource> Read(RecordingResource.StatusEnum status = null,
                                                          string sourceSid = null,
                                                          List<string> groupingSid = null,
                                                          DateTime? dateCreatedAfter = null,
                                                          DateTime? dateCreatedBefore = null,
                                                          RecordingResource.TypeEnum mediaType = null,
                                                          int? pageSize = null,
                                                          long? limit = null,
                                                          ITwilioRestClient client = null)
        {
            var options = new ReadRecordingOptions(){Status = status, SourceSid = sourceSid, GroupingSid = groupingSid, DateCreatedAfter = dateCreatedAfter, DateCreatedBefore = dateCreatedBefore, MediaType = mediaType, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// List of all Track recordings.
        /// </summary>
        /// <param name="status"> Read only the recordings that have this status </param>
        /// <param name="sourceSid"> Read only the recordings that have this source_sid </param>
        /// <param name="groupingSid"> Read only recordings that have this grouping_sid </param>
        /// <param name="dateCreatedAfter"> Read only recordings that started on or after this [ISO
        ///                        8601](https://en.wikipedia.org/wiki/ISO_8601) date-time with time zone </param>
        /// <param name="dateCreatedBefore"> Read only recordings that started before this [ISO
        ///                         8601](https://en.wikipedia.org/wiki/ISO_8601) date-time with time zone </param>
        /// <param name="mediaType"> Read only recordings that have this media type </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Recording </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<RecordingResource>> ReadAsync(RecordingResource.StatusEnum status = null,
                                                                                                  string sourceSid = null,
                                                                                                  List<string> groupingSid = null,
                                                                                                  DateTime? dateCreatedAfter = null,
                                                                                                  DateTime? dateCreatedBefore = null,
                                                                                                  RecordingResource.TypeEnum mediaType = null,
                                                                                                  int? pageSize = null,
                                                                                                  long? limit = null,
                                                                                                  ITwilioRestClient client = null)
        {
            var options = new ReadRecordingOptions(){Status = status, SourceSid = sourceSid, GroupingSid = groupingSid, DateCreatedAfter = dateCreatedAfter, DateCreatedBefore = dateCreatedBefore, MediaType = mediaType, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<RecordingResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<RecordingResource>.FromJson("recordings", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<RecordingResource> NextPage(Page<RecordingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Video)
            );

            var response = client.Request(request);
            return Page<RecordingResource>.FromJson("recordings", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<RecordingResource> PreviousPage(Page<RecordingResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Video)
            );

            var response = client.Request(request);
            return Page<RecordingResource>.FromJson("recordings", response.Content);
        }

        private static Request BuildDeleteRequest(DeleteRecordingOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Video,
                "/v1/Recordings/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Delete a Recording resource identified by a Recording SID.
        /// </summary>
        /// <param name="options"> Delete Recording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Recording </returns>
        public static bool Delete(DeleteRecordingOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete a Recording resource identified by a Recording SID.
        /// </summary>
        /// <param name="options"> Delete Recording parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Recording </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteRecordingOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete a Recording resource identified by a Recording SID.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Recording </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteRecordingOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete a Recording resource identified by a Recording SID.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to delete </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Recording </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteRecordingOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a RecordingResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> RecordingResource object represented by the provided JSON </returns>
        public static RecordingResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<RecordingResource>(json);
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
        /// The status of the recording
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RecordingResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the recording source
        /// </summary>
        [JsonProperty("source_sid")]
        public string SourceSid { get; private set; }
        /// <summary>
        /// The size of the recorded track, in bytes
        /// </summary>
        [JsonProperty("size")]
        public long? Size { get; private set; }
        /// <summary>
        /// The absolute URL of the resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The recording's media type
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RecordingResource.TypeEnum Type { get; private set; }
        /// <summary>
        /// The duration of the recording in seconds
        /// </summary>
        [JsonProperty("duration")]
        public int? Duration { get; private set; }
        /// <summary>
        /// The file format for the recording
        /// </summary>
        [JsonProperty("container_format")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RecordingResource.FormatEnum ContainerFormat { get; private set; }
        /// <summary>
        /// The codec used to encode the track
        /// </summary>
        [JsonProperty("codec")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RecordingResource.CodecEnum Codec { get; private set; }
        /// <summary>
        /// A list of SIDs related to the recording
        /// </summary>
        [JsonProperty("grouping_sids")]
        public object GroupingSids { get; private set; }
        /// <summary>
        /// The name that was given to the source track of the recording
        /// </summary>
        [JsonProperty("track_name")]
        public string TrackName { get; private set; }
        /// <summary>
        /// The number of milliseconds between a point in time that is common to all rooms in a group and when the source room of the recording started
        /// </summary>
        [JsonProperty("offset")]
        public long? Offset { get; private set; }
        /// <summary>
        /// The URL of the media file associated with the recording when stored externally
        /// </summary>
        [JsonProperty("media_external_location")]
        public Uri MediaExternalLocation { get; private set; }
        /// <summary>
        /// The URLs of related resources
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private RecordingResource()
        {

        }
    }

}