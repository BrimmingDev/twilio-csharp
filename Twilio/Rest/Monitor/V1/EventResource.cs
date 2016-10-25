using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Monitor.V1 
{

    public class EventResource : Resource 
    {
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <returns> EventFetcher capable of executing the fetch </returns> 
        public static EventFetcher Fetcher(string sid)
        {
            return new EventFetcher(sid);
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="actorSid"> The actor_sid </param>
        /// <param name="eventType"> The event_type </param>
        /// <param name="resourceSid"> The resource_sid </param>
        /// <param name="sourceIpAddress"> The source_ip_address </param>
        /// <param name="startDate"> The start_date </param>
        /// <param name="endDate"> The end_date </param>
        /// <returns> EventReader capable of executing the read </returns> 
        public static EventReader Reader(string actorSid=null, string eventType=null, string resourceSid=null, string sourceIpAddress=null, DateTime? startDate=null, DateTime? endDate=null)
        {
            return new EventReader(actorSid:actorSid, eventType:eventType, resourceSid:resourceSid, sourceIpAddress:sourceIpAddress, startDate:startDate, endDate:endDate);
        }
    
        /// <summary>
        /// Converts a JSON string into a EventResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> EventResource object represented by the provided JSON </returns> 
        public static EventResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<EventResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("account_sid")]
        public string accountSid { get; }
        [JsonProperty("actor_sid")]
        public string actorSid { get; }
        [JsonProperty("actor_type")]
        public string actorType { get; }
        [JsonProperty("description")]
        public string description { get; }
        [JsonProperty("event_data")]
        public Object eventData { get; }
        [JsonProperty("event_date")]
        public DateTime? eventDate { get; }
        [JsonProperty("event_type")]
        public string eventType { get; }
        [JsonProperty("resource_sid")]
        public string resourceSid { get; }
        [JsonProperty("resource_type")]
        public string resourceType { get; }
        [JsonProperty("sid")]
        public string sid { get; }
        [JsonProperty("source")]
        public string source { get; }
        [JsonProperty("source_ip_address")]
        public string sourceIpAddress { get; }
        [JsonProperty("url")]
        public Uri url { get; }
        [JsonProperty("links")]
        public Dictionary<string, string> links { get; }
    
        public EventResource()
        {
        
        }
    
        private EventResource([JsonProperty("account_sid")]
                              string accountSid, 
                              [JsonProperty("actor_sid")]
                              string actorSid, 
                              [JsonProperty("actor_type")]
                              string actorType, 
                              [JsonProperty("description")]
                              string description, 
                              [JsonProperty("event_data")]
                              Object eventData, 
                              [JsonProperty("event_date")]
                              string eventDate, 
                              [JsonProperty("event_type")]
                              string eventType, 
                              [JsonProperty("resource_sid")]
                              string resourceSid, 
                              [JsonProperty("resource_type")]
                              string resourceType, 
                              [JsonProperty("sid")]
                              string sid, 
                              [JsonProperty("source")]
                              string source, 
                              [JsonProperty("source_ip_address")]
                              string sourceIpAddress, 
                              [JsonProperty("url")]
                              Uri url, 
                              [JsonProperty("links")]
                              Dictionary<string, string> links)
                              {
            this.accountSid = accountSid;
            this.actorSid = actorSid;
            this.actorType = actorType;
            this.description = description;
            this.eventData = eventData;
            this.eventDate = MarshalConverter.DateTimeFromString(eventDate);
            this.eventType = eventType;
            this.resourceSid = resourceSid;
            this.resourceType = resourceType;
            this.sid = sid;
            this.source = source;
            this.sourceIpAddress = sourceIpAddress;
            this.url = url;
            this.links = links;
        }
    }
}