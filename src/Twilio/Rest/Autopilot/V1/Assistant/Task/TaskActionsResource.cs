/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// TaskActionsResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Autopilot.V1.Assistant.Task
{

    public class TaskActionsResource : Resource
    {
        private static Request BuildFetchRequest(FetchTaskActionsOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathAssistantSid + "/Tasks/" + options.PathTaskSid + "/Actions",
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Returns JSON actions for the Task.
        /// </summary>
        /// <param name="options"> Fetch TaskActions parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskActions </returns>
        public static TaskActionsResource Fetch(FetchTaskActionsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Returns JSON actions for the Task.
        /// </summary>
        /// <param name="options"> Fetch TaskActions parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskActions </returns>
        public static async System.Threading.Tasks.Task<TaskActionsResource> FetchAsync(FetchTaskActionsOptions options,
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Returns JSON actions for the Task.
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task for which the task actions
        ///                        to fetch were defined </param>
        /// <param name="pathTaskSid"> The SID of the Task for which the task actions to fetch were defined </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskActions </returns>
        public static TaskActionsResource Fetch(string pathAssistantSid, string pathTaskSid, ITwilioRestClient client = null)
        {
            var options = new FetchTaskActionsOptions(pathAssistantSid, pathTaskSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Returns JSON actions for the Task.
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task for which the task actions
        ///                        to fetch were defined </param>
        /// <param name="pathTaskSid"> The SID of the Task for which the task actions to fetch were defined </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskActions </returns>
        public static async System.Threading.Tasks.Task<TaskActionsResource> FetchAsync(string pathAssistantSid,
                                                                                        string pathTaskSid,
                                                                                        ITwilioRestClient client = null)
        {
            var options = new FetchTaskActionsOptions(pathAssistantSid, pathTaskSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateTaskActionsOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathAssistantSid + "/Tasks/" + options.PathTaskSid + "/Actions",
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Updates the actions of an Task identified by {TaskSid} or {TaskUniqueName}.
        /// </summary>
        /// <param name="options"> Update TaskActions parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskActions </returns>
        public static TaskActionsResource Update(UpdateTaskActionsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Updates the actions of an Task identified by {TaskSid} or {TaskUniqueName}.
        /// </summary>
        /// <param name="options"> Update TaskActions parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskActions </returns>
        public static async System.Threading.Tasks.Task<TaskActionsResource> UpdateAsync(UpdateTaskActionsOptions options,
                                                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Updates the actions of an Task identified by {TaskSid} or {TaskUniqueName}.
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task for which the task actions
        ///                        to update were defined </param>
        /// <param name="pathTaskSid"> The SID of the Task for which the task actions to update were defined </param>
        /// <param name="actions"> The JSON string that specifies the actions that instruct the Assistant on how to perform the
        ///               task </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskActions </returns>
        public static TaskActionsResource Update(string pathAssistantSid,
                                                 string pathTaskSid,
                                                 object actions = null,
                                                 ITwilioRestClient client = null)
        {
            var options = new UpdateTaskActionsOptions(pathAssistantSid, pathTaskSid){Actions = actions};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// Updates the actions of an Task identified by {TaskSid} or {TaskUniqueName}.
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the Task for which the task actions
        ///                        to update were defined </param>
        /// <param name="pathTaskSid"> The SID of the Task for which the task actions to update were defined </param>
        /// <param name="actions"> The JSON string that specifies the actions that instruct the Assistant on how to perform the
        ///               task </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskActions </returns>
        public static async System.Threading.Tasks.Task<TaskActionsResource> UpdateAsync(string pathAssistantSid,
                                                                                         string pathTaskSid,
                                                                                         object actions = null,
                                                                                         ITwilioRestClient client = null)
        {
            var options = new UpdateTaskActionsOptions(pathAssistantSid, pathTaskSid){Actions = actions};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a TaskActionsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TaskActionsResource object represented by the provided JSON </returns>
        public static TaskActionsResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<TaskActionsResource>(json);
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
        /// The SID of the Assistant that is the parent of the Task associated with the resource
        /// </summary>
        [JsonProperty("assistant_sid")]
        public string AssistantSid { get; private set; }
        /// <summary>
        /// The SID of the Task associated with the resource
        /// </summary>
        [JsonProperty("task_sid")]
        public string TaskSid { get; private set; }
        /// <summary>
        /// The absolute URL of the TaskActions resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The JSON string that specifies the actions that instruct the Assistant on how to perform the task
        /// </summary>
        [JsonProperty("data")]
        public object Data { get; private set; }

        private TaskActionsResource()
        {

        }
    }

}