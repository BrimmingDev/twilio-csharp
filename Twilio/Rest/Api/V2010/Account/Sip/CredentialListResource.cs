using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account.Sip 
{

    public class CredentialListResource : Resource 
    {
        /// <summary>
        /// Retrieve a list of Credentials belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <returns> CredentialListReader capable of executing the read </returns> 
        public static CredentialListReader Reader(string accountSid=null)
        {
            return new CredentialListReader(accountSid:accountSid);
        }
    
        /// <summary>
        /// Add a Credential to the list
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <returns> CredentialListCreator capable of executing the create </returns> 
        public static CredentialListCreator Creator(string friendlyName, string accountSid=null)
        {
            return new CredentialListCreator(friendlyName, accountSid:accountSid);
        }
    
        /// <summary>
        /// Retrieve a specific Credential in a list
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique credential Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <returns> CredentialListFetcher capable of executing the fetch </returns> 
        public static CredentialListFetcher Fetcher(string sid, string accountSid=null)
        {
            return new CredentialListFetcher(sid, accountSid:accountSid);
        }
    
        /// <summary>
        /// Change the password of a Credential record
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <returns> CredentialListUpdater capable of executing the update </returns> 
        public static CredentialListUpdater Updater(string sid, string friendlyName, string accountSid=null)
        {
            return new CredentialListUpdater(sid, friendlyName, accountSid:accountSid);
        }
    
        /// <summary>
        /// Remove a credential from a CredentialList
        /// </summary>
        ///
        /// <param name="sid"> Delete by unique credential Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <returns> CredentialListDeleter capable of executing the delete </returns> 
        public static CredentialListDeleter Deleter(string sid, string accountSid=null)
        {
            return new CredentialListDeleter(sid, accountSid:accountSid);
        }
    
        /// <summary>
        /// Converts a JSON string into a CredentialListResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CredentialListResource object represented by the provided JSON </returns> 
        public static CredentialListResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<CredentialListResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        [JsonProperty("account_sid")]
        public string accountSid { get; }
        [JsonProperty("date_created")]
        public DateTime? dateCreated { get; }
        [JsonProperty("date_updated")]
        public DateTime? dateUpdated { get; }
        [JsonProperty("friendly_name")]
        public string friendlyName { get; }
        [JsonProperty("sid")]
        public string sid { get; }
        [JsonProperty("subresource_uris")]
        public Dictionary<string, string> subresourceUris { get; }
        [JsonProperty("uri")]
        public string uri { get; }
    
        public CredentialListResource()
        {
        
        }
    
        private CredentialListResource([JsonProperty("account_sid")]
                                       string accountSid, 
                                       [JsonProperty("date_created")]
                                       string dateCreated, 
                                       [JsonProperty("date_updated")]
                                       string dateUpdated, 
                                       [JsonProperty("friendly_name")]
                                       string friendlyName, 
                                       [JsonProperty("sid")]
                                       string sid, 
                                       [JsonProperty("subresource_uris")]
                                       Dictionary<string, string> subresourceUris, 
                                       [JsonProperty("uri")]
                                       string uri)
                                       {
            this.accountSid = accountSid;
            this.dateCreated = MarshalConverter.DateTimeFromString(dateCreated);
            this.dateUpdated = MarshalConverter.DateTimeFromString(dateUpdated);
            this.friendlyName = friendlyName;
            this.sid = sid;
            this.subresourceUris = subresourceUris;
            this.uri = uri;
        }
    }
}