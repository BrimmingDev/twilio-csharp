using System;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;

#if NET40
using System.Threading.Tasks;
#endif

namespace Twilio.Rest.Preview.Wireless 
{

    public class DeviceCreator : Creator<DeviceResource> 
    {
        public string ratePlan { get; }
        public string alias { get; set; }
        public string callbackMethod { get; set; }
        public Uri callbackUrl { get; set; }
        public string friendlyName { get; set; }
        public string simIdentifier { get; set; }
        public string status { get; set; }
        public string commandsCallbackMethod { get; set; }
        public Uri commandsCallbackUrl { get; set; }
    
        /// <summary>
        /// Construct a new DeviceCreator
        /// </summary>
        ///
        /// <param name="ratePlan"> The rate_plan </param>
        /// <param name="alias"> The alias </param>
        /// <param name="callbackMethod"> The callback_method </param>
        /// <param name="callbackUrl"> The callback_url </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="simIdentifier"> The sim_identifier </param>
        /// <param name="status"> The status </param>
        /// <param name="commandsCallbackMethod"> The commands_callback_method </param>
        /// <param name="commandsCallbackUrl"> The commands_callback_url </param>
        public DeviceCreator(string ratePlan, string alias=null, string callbackMethod=null, Uri callbackUrl=null, string friendlyName=null, string simIdentifier=null, string status=null, string commandsCallbackMethod=null, Uri commandsCallbackUrl=null)
        {
            this.simIdentifier = simIdentifier;
            this.callbackMethod = callbackMethod;
            this.ratePlan = ratePlan;
            this.callbackUrl = callbackUrl;
            this.commandsCallbackMethod = commandsCallbackMethod;
            this.status = status;
            this.commandsCallbackUrl = commandsCallbackUrl;
            this.friendlyName = friendlyName;
            this.alias = alias;
        }
    
        #if NET40
        /// <summary>
        /// Make the request to the Twilio API to perform the create
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Created DeviceResource </returns> 
        public override async Task<DeviceResource> CreateAsync(ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.POST,
                Domains.PREVIEW,
                "/wireless/Devices"
            );
            
            AddPostParams(request);
            var response = await client.RequestAsync(request);
            if (response == null)
            {
                throw new ApiConnectionException("DeviceResource creation failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to create record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return DeviceResource.FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Make the request to the Twilio API to perform the create
        /// </summary>
        ///
        /// <param name="client"> ITwilioRestClient with which to make the request </param>
        /// <returns> Created DeviceResource </returns> 
        public override DeviceResource Create(ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.POST,
                Domains.PREVIEW,
                "/wireless/Devices"
            );
            
            AddPostParams(request);
            var response = client.Request(request);
            if (response == null)
            {
                throw new ApiConnectionException("DeviceResource creation failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to create record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return DeviceResource.FromJson(response.Content);
        }
    
        /// <summary>
        /// Add the requested post parameters to the Request
        /// </summary>
        ///
        /// <param name="request"> Request to add post params to </param>
        private void AddPostParams(Request request)
        {
            if (ratePlan != null)
            {
                request.AddPostParam("RatePlan", ratePlan);
            }
            
            if (alias != null)
            {
                request.AddPostParam("Alias", alias);
            }
            
            if (callbackMethod != null)
            {
                request.AddPostParam("CallbackMethod", callbackMethod);
            }
            
            if (callbackUrl != null)
            {
                request.AddPostParam("CallbackUrl", callbackUrl.ToString());
            }
            
            if (friendlyName != null)
            {
                request.AddPostParam("FriendlyName", friendlyName);
            }
            
            if (simIdentifier != null)
            {
                request.AddPostParam("SimIdentifier", simIdentifier);
            }
            
            if (status != null)
            {
                request.AddPostParam("Status", status);
            }
            
            if (commandsCallbackMethod != null)
            {
                request.AddPostParam("CommandsCallbackMethod", commandsCallbackMethod);
            }
            
            if (commandsCallbackUrl != null)
            {
                request.AddPostParam("CommandsCallbackUrl", commandsCallbackUrl.ToString());
            }
        }
    }
}