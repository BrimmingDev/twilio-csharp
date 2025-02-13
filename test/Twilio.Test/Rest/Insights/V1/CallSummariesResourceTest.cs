/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Insights.V1;

namespace Twilio.Tests.Rest.Insights.V1
{

    [TestFixture]
    public class CallSummariesTest : TwilioTest
    {
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Insights,
                "/v1/Voice/Summaries",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                CallSummariesResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 25,\"first_page_url\": \"https://insights.twilio.com/v1/Voice/Summaries?PageSize=25&Page=0\",\"previous_page_url\": null,\"next_page_url\": null,\"key\": \"call_summaries\",\"url\": \"https://insights.twilio.com/v1/Voice/Summaries?PageSize=25&Page=0\"},\"call_summaries\": []}"
                                     ));

            var response = CallSummariesResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadWithCarrierResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 25,\"first_page_url\": \"https://insights.twilio.com/v1/Voice/Summaries?ToCarrier=AT%26T+Wireless&StartTime=4h&PageSize=25&Page=0\",\"previous_page_url\": null,\"next_page_url\": null,\"key\": \"call_summaries\",\"url\": \"https://insights.twilio.com/v1/Voice/Summaries?ToCarrier=AT%26T+Wireless&StartTime=4h&PageSize=25&Page=0\"},\"call_summaries\": [{\"call_sid\": \"CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"created_time\": \"2021-08-25T03:40:25Z\",\"start_time\": \"2021-08-25T03:40:25Z\",\"end_time\": \"2021-08-25T03:40:45Z\",\"duration\": 20,\"connect_duration\": 20,\"call_type\": \"carrier\",\"call_state\": \"completed\",\"from\": {\"caller\": \"+15555555555\",\"carrier\": \"T-Mobile USA, Inc.\",\"connection\": \"mobile\",\"number_prefix\": \"1555\",\"location\": {\"lat\": 40.83885,\"lon\": -74.04568},\"country_code\": \"US\"},\"to\": {\"callee\": \"+15555555556\",\"carrier\": \"AT&T Wireless\",\"connection\": \"mobile\",\"number_prefix\": \"1555\",\"location\": {\"lat\": 33.42767,\"lon\": -86.886475},\"country_code\": \"US\"},\"processing_state\": \"complete\",\"sdk_edge\": null,\"sip_edge\": null,\"client_edge\": null,\"carrier_edge\": {\"properties\": {\"media_region\": \"us1\",\"signaling_region\": \"us1\",\"edge_location\": \"xxxxx\",\"direction\": \"inbound\"},\"metrics\": {\"inbound\": {\"codec\": 0,\"codec_name\": \"pcmu\",\"packets_received\": 202,\"packets_lost\": 0,\"packets_loss_percentage\": 0.0,\"jitter\": {\"max\": 1.48209,\"avg\": 0.483035}},\"outbound\": {\"codec\": 0,\"codec_name\": \"pcmu\",\"packets_sent\": 218,\"packets_lost\": 0,\"packets_loss_percentage\": 0.0,\"jitter\": {\"max\": 0.51868,\"avg\": 0.364434}}}},\"tags\": [\"high_packet_loss\",\"high_jitter\"],\"attributes\": {\"conference_participant\": false},\"properties\": {\"last_sip_response_num\": 200,\"pdd_ms\": 121,\"disconnected_by\": \"callee\",\"direction\": \"inbound\"},\"trust\": {\"verified_caller\": {\"verified\": true}},\"url\": \"https://insights.twilio.com/v1/Voice/Summaries\"},{\"call_sid\": \"CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"created_time\": \"2021-08-25T02:20:25Z\",\"start_time\": \"2021-08-25T02:20:25Z\",\"end_time\": \"2021-08-25T02:40:45Z\",\"duration\": 18,\"connect_duration\": 18,\"call_type\": \"carrier\",\"call_state\": \"completed\",\"from\": {\"caller\": \"+15555555555\",\"carrier\": \"T-Mobile USA, Inc.\",\"connection\": \"mobile\",\"number_prefix\": \"1555\",\"location\": {\"lat\": 40.83885,\"lon\": -74.04568},\"country_code\": \"US\"},\"to\": {\"callee\": \"+15555555556\",\"carrier\": \"AT&T Wireless\",\"connection\": \"mobile\",\"number_prefix\": \"1555\",\"location\": {\"lat\": 33.42767,\"lon\": -86.886475},\"country_code\": \"US\"},\"processing_state\": \"complete\",\"sdk_edge\": null,\"sip_edge\": null,\"client_edge\": null,\"carrier_edge\": {\"properties\": {\"media_region\": \"us1\",\"signaling_region\": \"us1\",\"edge_location\": \"xxxxx\",\"direction\": \"inbound\"},\"metrics\": {\"inbound\": {\"codec\": 0,\"codec_name\": \"pcmu\",\"packets_received\": 100,\"packets_lost\": 0,\"packets_loss_percentage\": 0.0,\"jitter\": {\"max\": 1.48209,\"avg\": 0.483035}},\"outbound\": {\"codec\": 0,\"codec_name\": \"pcmu\",\"packets_sent\": 102,\"packets_lost\": 0,\"packets_loss_percentage\": 0.0,\"jitter\": {\"max\": 0.51868,\"avg\": 0.364434}}}},\"tags\": null,\"attributes\": {\"conference_participant\": false},\"properties\": {\"last_sip_response_num\": 200,\"pdd_ms\": 121,\"disconnected_by\": \"callee\",\"direction\": \"inbound\"},\"trust\": {\"verified_caller\": {\"verified\": true}},\"url\": \"https://insights.twilio.com/v1/Voice/Summaries\"}]}"
                                     ));

            var response = CallSummariesResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadWithSubaccountResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 25,\"first_page_url\": \"https://insights.twilio.com/v1/Voice/Summaries?CallType=client&StartTime=7d&HasTag=True&Subaccount=ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab&PageSize=25&Page=0\",\"previous_page_url\": null,\"next_page_url\": null,\"key\": \"call_summaries\",\"url\": \"https://insights.twilio.com/v1/Voice/Summaries?CallType=client&StartTime=7d&HasTag=True&Subaccount=ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab&PageSize=25&Page=0\"},\"call_summaries\": [{\"call_sid\": \"CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"created_time\": \"2021-08-25T04:16:35Z\",\"start_time\": \"2021-08-25T04:16:36Z\",\"end_time\": \"2021-08-25T04:16:42Z\",\"duration\": 7,\"connect_duration\": 6,\"call_type\": \"client\",\"call_state\": \"completed\",\"from\": {\"caller\": \"client:+15555555555\",\"connection\": \"twilio_sdk\"},\"to\": {\"callee\": \"client:TBBXXXXXXXXXXXX\",\"connection\": \"twilio_sdk\"},\"processing_state\": \"complete\",\"sdk_edge\": null,\"sip_edge\": null,\"client_edge\": {\"properties\": {\"media_region\": \"us1\",\"signaling_region\": \"us1\",\"twilio_media_ip\": \"54.xxx.xx.xxx\",\"external_media_ip\": \"54.xxx.xx.xxx\",\"edge_location\": \"xxxxxx\",\"direction\": \"inbound\"},\"metrics\": {\"inbound\": {\"codec\": 0,\"codec_name\": \"pcmu\",\"packets_received\": 252,\"packets_lost\": 0,\"packets_loss_percentage\": 0.0,\"jitter\": {\"max\": 5.60994,\"avg\": 0.933334}},\"outbound\": {\"codec\": 0,\"codec_name\": \"pcmu\",\"packets_sent\": 229,\"packets_lost\": 0,\"packets_loss_percentage\": 0.0,\"jitter\": {\"max\": 0.960786,\"avg\": 0.399859}}}},\"carrier_edge\": null,\"tags\": [\"high_pdd\"],\"attributes\": {\"conference_participant\": false},\"properties\": {\"last_sip_response_num\": 200,\"pdd_ms\": 58,\"disconnected_by\": \"callee\",\"direction\": \"inbound\"},\"trust\": null,\"url\": \"https://insights.twilio.com/v1/Voice/Summaries\"},{\"call_sid\": \"CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"created_time\": \"2021-08-25T04:16:35Z\",\"start_time\": \"2021-08-25T04:16:37Z\",\"end_time\": \"2021-08-25T04:16:40Z\",\"duration\": 5,\"connect_duration\": 3,\"call_type\": \"client\",\"call_state\": \"completed\",\"from\": {\"caller\": \"+15555555555\",\"carrier\": \"Verizon\",\"connection\": \"landline\",\"number_prefix\": \"1555\",\"location\": {\"lat\": 40.83885,\"lon\": -74.04568},\"country_code\": \"US\"},\"to\": {\"callee\": \"client:TBBTXXXXXX\",\"connection\": \"twilio_sdk\"},\"processing_state\": \"complete\",\"sdk_edge\": null,\"sip_edge\": null,\"client_edge\": {\"properties\": {\"media_region\": \"us1\",\"signaling_region\": \"us1\",\"twilio_media_ip\": \"54.xxx.xx.xxx\",\"external_media_ip\": \"54.xxx.xx.xxx\",\"edge_location\": \"xxxxx\",\"direction\": \"outbound\"},\"metrics\": {\"inbound\": {\"codec\": 0,\"codec_name\": \"pcmu\",\"packets_received\": 110,\"packets_lost\": 0,\"packets_loss_percentage\": 0.0,\"jitter\": {\"max\": 1.05918,\"avg\": 0.461966}},\"outbound\": {\"codec\": 0,\"codec_name\": \"pcmu\",\"packets_sent\": 147,\"packets_lost\": 0,\"packets_loss_percentage\": 0.0,\"jitter\": {\"max\": 0.869174,\"avg\": 0.319674}}}},\"carrier_edge\": null,\"tags\": null,\"attributes\": {\"conference_participant\": false},\"properties\": {\"last_sip_response_num\": 200,\"pdd_ms\": 35,\"disconnected_by\": \"callee\",\"direction\": \"outbound_api\"},\"trust\": null,\"url\": \"https://insights.twilio.com/v1/Voice/Summaries\"}]}"
                                     ));

            var response = CallSummariesResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadWithTrustResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 25,\"first_page_url\": \"https://insights.twilio.com/v1/Voice/Summaries?Direction=outbound_api%2Coutbound_dial%2Ctrunking_terminating&StartTime=1d&VerifiedCaller=True&PageSize=25&Page=0\",\"previous_page_url\": null,\"next_page_url\": null,\"key\": \"call_summaries\",\"url\": \"https://insights.twilio.com/v1/Voice/Summaries?Direction=outbound_api%2Coutbound_dial%2Ctrunking_terminating&StartTime=1d&VerifiedCaller=True&PageSize=25&Page=0\"},\"call_summaries\": [{\"call_sid\": \"CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"created_time\": \"2021-08-25T14:31:18Z\",\"start_time\": \"2021-08-25T14:31:22Z\",\"end_time\": \"2021-08-25T14:32:02Z\",\"duration\": 44,\"connect_duration\": 41,\"call_type\": \"trunking\",\"call_state\": \"completed\",\"from\": {\"caller\": \"+15555555555\",\"carrier\": \"ACS\",\"connection\": \"landline\",\"number_prefix\": \"1555\",\"location\": {\"lat\": 60.268353,\"lon\": -141.13632},\"country_code\": \"US\"},\"to\": {\"callee\": \"+15555555556\",\"carrier\": \"Hawaiian Telcom, Inc. - HI\",\"connection\": \"landline\",\"number_prefix\": \"1555\",\"location\": {\"lat\": 20.956036,\"lon\": -157.23793},\"country_code\": \"US\"},\"processing_state\": \"complete\",\"sdk_edge\": null,\"sip_edge\": {\"properties\": {\"media_region\": \"us1\",\"signaling_region\": \"us1\",\"twilio_media_ip\": \"54.xxx.xx.xx\",\"twilio_signaling_ip\": \"54.xxx.xx.xx\",\"external_signaling_ip\": \"54.xxx.xx.xx\",\"sip_call_id\": \"xxxxx@0.0.0.0\",\"user_agent\": \"xxxx\",\"edge_location\": \"xxxxx\",\"trunk_sid\": \"xxxxxxx\",\"direction\": \"inbound\"},\"metrics\": {\"outbound\": {\"codec\": 0,\"codec_name\": \"pcmu\",\"packets_sent\": 1953,\"packets_lost\": 0,\"packets_loss_percentage\": 0.0,\"jitter\": {\"max\": 1.76407,\"avg\": 0.23138},\"latency\": {\"max\": 0.386,\"avg\": 0.3765}}}},\"client_edge\": null,\"carrier_edge\": {\"properties\": {\"media_region\": \"us1\",\"signaling_region\": \"us1\",\"edge_location\": \"xxxx\",\"direction\": \"outbound\"}},\"tags\": [\"silence\"],\"attributes\": {\"conference_participant\": false},\"properties\": {\"last_sip_response_num\": 200,\"pdd_ms\": 1990,\"disconnected_by\": \"caller\",\"direction\": \"trunking_terminating\"},\"trust\": {\"verified_caller\": {\"verified\": true}},\"url\": \"https://insights.twilio.com/v1/Voice/Summaries\"},{\"call_sid\": \"CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"created_time\": \"2021-08-25T14:03:31Z\",\"start_time\": \"2021-08-25T14:03:32Z\",\"end_time\": \"2021-08-25T14:03:38Z\",\"duration\": 7,\"connect_duration\": 6,\"call_type\": \"carrier\",\"call_state\": \"completed\",\"from\": {\"caller\": \"+15555555555\",\"carrier\": \"T-Mobile USA, Inc.\",\"connection\": \"mobile\",\"number_prefix\": \"1555\",\"location\": {\"lat\": 40.83885,\"lon\": -74.04568},\"country_code\": \"US\"},\"to\": {\"callee\": \"+15555555556\",\"carrier\": \"T-Mobile USA, Inc.\",\"connection\": \"mobile\",\"number_prefix\": \"1555\",\"location\": {\"lat\": 34.186115,\"lon\": -118.43555},\"country_code\": \"US\"},\"processing_state\": \"complete\",\"sdk_edge\": null,\"sip_edge\": null,\"client_edge\": null,\"carrier_edge\": {\"properties\": {\"media_region\": \"us1\",\"signaling_region\": \"us1\",\"edge_location\": \"xxxx\",\"direction\": \"outbound\"},\"metrics\": {\"inbound\": {\"codec\": 0,\"codec_name\": \"pcmu\",\"packets_received\": 229,\"packets_lost\": 0,\"packets_loss_percentage\": 0.0,\"jitter\": {\"max\": 1.10303,\"avg\": 0.449886}},\"outbound\": {\"codec\": 0,\"codec_name\": \"pcmu\",\"packets_sent\": 273,\"packets_lost\": 0,\"packets_loss_percentage\": 0.0,\"jitter\": {\"max\": 0.410031,\"avg\": 0.295951}}}},\"tags\": null,\"attributes\": {\"conference_participant\": false},\"properties\": {\"last_sip_response_num\": 200,\"pdd_ms\": 315,\"disconnected_by\": \"callee\",\"direction\": \"outbound_api\"},\"trust\": {\"verified_caller\": {\"verified\": true}},\"url\": \"https://insights.twilio.com/v1/Voice/Summaries\"},{\"call_sid\": \"CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"created_time\": \"2021-08-24T22:28:17Z\",\"start_time\": \"2021-08-24T22:28:20Z\",\"end_time\": \"2021-08-24T22:28:23Z\",\"duration\": 4,\"connect_duration\": 3,\"call_type\": \"carrier\",\"call_state\": \"completed\",\"from\": {\"caller\": \"+15555555555\",\"carrier\": \"Hawaiian Telcom, Inc. - HI\",\"connection\": \"landline\",\"number_prefix\": \"1555\",\"location\": {\"lat\": 20.956036,\"lon\": -157.23793},\"country_code\": \"US\"},\"to\": {\"callee\": \"+15555555556\",\"connection\": \"pstn\"},\"processing_state\": \"complete\",\"sdk_edge\": null,\"sip_edge\": null,\"client_edge\": null,\"carrier_edge\": {\"properties\": {\"media_region\": \"us1\",\"signaling_region\": \"us1\",\"edge_location\": \"xxxx\",\"direction\": \"outbound\"},\"metrics\": {\"outbound\": {\"codec\": 0,\"codec_name\": \"pcmu\",\"packets_sent\": 103,\"packets_lost\": 0,\"packets_loss_percentage\": 0.0,\"jitter\": {\"max\": 0.596712,\"avg\": 0.251725}}}},\"tags\": [\"silence\"],\"attributes\": null,\"properties\": {\"last_sip_response_num\": 200,\"pdd_ms\": 105,\"disconnected_by\": \"caller\",\"direction\": \"outbound_dial\"},\"trust\": null,\"url\": \"https://insights.twilio.com/v1/Voice/Summaries\"}]}"
                                     ));

            var response = CallSummariesResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadWithAbnormalSessionResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 25,\"first_page_url\": \"https://insights.twilio.com/v1/Voice/Summaries?CallType=sip%2Ctrunking&CallState=completed&StartTime=15d&AbnormalSession=True&PageSize=25&Page=0\",\"previous_page_url\": null,\"next_page_url\": null,\"key\": \"call_summaries\",\"url\": \"https://insights.twilio.com/v1/Voice/Summaries?CallType=sip%2Ctrunking&CallState=completed&StartTime=15d&AbnormalSession=True&PageSize=25&Page=0\"},\"call_summaries\": [{\"call_sid\": \"CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"created_time\": \"2021-08-25T14:46:40Z\",\"start_time\": \"2021-08-25T14:46:40Z\",\"end_time\": \"2021-08-25T14:46:52Z\",\"duration\": 12,\"connect_duration\": 12,\"call_type\": \"sip\",\"call_state\": \"completed\",\"from\": {\"caller\": \"+15555555555\",\"carrier\": \"XO Communications, Inc.\",\"connection\": \"landline\",\"number_prefix\": \"1555\",\"location\": {\"lat\": 40.83885,\"lon\": -74.04568},\"country_code\": \"US\"},\"to\": {\"callee\": \"sip:xxxx@xx.xxx.xx.xxx\",\"connection\": \"sip_interface\"},\"processing_state\": \"complete\",\"sdk_edge\": null,\"sip_edge\": {\"properties\": {\"media_region\": \"us1\",\"signaling_region\": \"us1\",\"twilio_media_ip\": \"xx.xxx.xx.xxx\",\"twilio_signaling_ip\": \"xx.xx.xx.xx\",\"external_media_ip\": \"xx.xxx.xx.xxx\",\"external_signaling_ip\": \"xx.xxx.xx.xxx\",\"sip_call_id\": \"xxxxxxxx@0.0.0.0\",\"edge_location\": \"xxxxx\",\"direction\": \"outbound\"},\"metrics\": {\"inbound\": {\"codec\": 0,\"codec_name\": \"pcmu\",\"packets_received\": 525,\"packets_lost\": 0,\"packets_loss_percentage\": 0.0,\"jitter\": {\"max\": 0.554729,\"avg\": 0.229541}},\"outbound\": {\"codec\": 0,\"codec_name\": \"pcmu\",\"packets_sent\": 245,\"packets_lost\": 0,\"packets_loss_percentage\": 0.0,\"jitter\": {\"max\": 1.03548,\"avg\": 0.344092}}}},\"client_edge\": null,\"carrier_edge\": null,\"tags\": null,\"attributes\": {\"conference_participant\": false},\"properties\": {\"last_sip_response_num\": 200,\"pdd_ms\": 255,\"disconnected_by\": \"callee\",\"direction\": \"outbound_dial\"},\"trust\": null,\"url\": \"https://insights.twilio.com/v1/Voice/Summaries\"},{\"call_sid\": \"CAaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"created_time\": \"2021-08-25T14:31:18Z\",\"start_time\": \"2021-08-25T14:31:22Z\",\"end_time\": \"2021-08-25T14:32:02Z\",\"duration\": 44,\"connect_duration\": 41,\"call_type\": \"trunking\",\"call_state\": \"completed\",\"from\": {\"caller\": \"+15555555555\",\"carrier\": \"ACS\",\"connection\": \"landline\",\"number_prefix\": \"1555\",\"location\": {\"lat\": 60.268353,\"lon\": -141.13632},\"country_code\": \"US\"},\"to\": {\"callee\": \"+15555555556\",\"carrier\": \"Hawaiian Telcom, Inc. - HI\",\"connection\": \"landline\",\"number_prefix\": \"1555\",\"location\": {\"lat\": 20.956036,\"lon\": -157.23793},\"country_code\": \"US\"},\"processing_state\": \"complete\",\"sdk_edge\": null,\"sip_edge\": {\"properties\": {\"media_region\": \"us1\",\"signaling_region\": \"us1\",\"twilio_media_ip\": \"54.xxx.xx.xx\",\"twilio_signaling_ip\": \"54.xxx.xx.xx\",\"external_signaling_ip\": \"54.xxx.xx.xx\",\"sip_call_id\": \"xxxxx@0.0.0.0\",\"user_agent\": \"xxxx\",\"edge_location\": \"xxxxx\",\"trunk_sid\": \"xxxxxxx\",\"direction\": \"inbound\"},\"metrics\": {\"outbound\": {\"codec\": 0,\"codec_name\": \"pcmu\",\"packets_sent\": 1953,\"packets_lost\": 0,\"packets_loss_percentage\": 0.0,\"jitter\": {\"max\": 1.76407,\"avg\": 0.23138},\"latency\": {\"max\": 0.386,\"avg\": 0.3765}}}},\"client_edge\": null,\"carrier_edge\": {\"properties\": {\"media_region\": \"us1\",\"signaling_region\": \"us1\",\"edge_location\": \"xxxx\",\"direction\": \"outbound\"}},\"tags\": [\"silence\"],\"attributes\": {\"conference_participant\": false},\"properties\": {\"last_sip_response_num\": 200,\"pdd_ms\": 1990,\"disconnected_by\": \"caller\",\"direction\": \"trunking_terminating\"},\"trust\": {\"verified_caller\": {\"verified\": true}},\"url\": \"https://insights.twilio.com/v1/Voice/Summaries\"}]}"
                                     ));

            var response = CallSummariesResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}