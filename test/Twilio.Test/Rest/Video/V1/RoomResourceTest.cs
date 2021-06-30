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
using Twilio.Rest.Video.V1;

namespace Twilio.Tests.Rest.Video.V1
{

    [TestFixture]
    public class RoomTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Video,
                "/v1/Rooms/RMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                RoomResource.Fetch("RMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"status\": \"in-progress\",\"type\": \"peer-to-peer\",\"sid\": \"RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"enable_turn\": true,\"unique_name\": \"unique_name\",\"max_participants\": 10,\"max_concurrent_published_tracks\": 0,\"duration\": 0,\"status_callback_method\": \"POST\",\"status_callback\": null,\"record_participants_on_connect\": false,\"video_codecs\": [\"VP8\"],\"media_region\": \"us1\",\"end_time\": \"2015-07-30T20:00:00Z\",\"url\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"participants\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants\",\"recordings\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Recordings\",\"recording_rules\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/RecordingRules\"}}"
                                     ));

            var response = RoomResource.Fetch("RMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Video,
                "/v1/Rooms",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                RoomResource.Create(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"status\": \"in-progress\",\"type\": \"peer-to-peer\",\"sid\": \"RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"enable_turn\": true,\"unique_name\": \"RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"max_concurrent_published_tracks\": 0,\"max_participants\": 10,\"duration\": 0,\"status_callback_method\": \"POST\",\"status_callback\": null,\"record_participants_on_connect\": false,\"video_codecs\": [\"VP8\"],\"media_region\": \"us1\",\"end_time\": \"2015-07-30T20:00:00Z\",\"url\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"participants\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants\",\"recordings\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Recordings\",\"recording_rules\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/RecordingRules\"}}"
                                     ));

            var response = RoomResource.Create(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateWebrtcGoResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"status\": \"in-progress\",\"type\": \"go\",\"sid\": \"RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"enable_turn\": true,\"unique_name\": \"room1\",\"max_participants\": 10,\"max_concurrent_published_tracks\": 0,\"duration\": 0,\"status_callback_method\": \"POST\",\"status_callback\": null,\"record_participants_on_connect\": false,\"video_codecs\": [\"VP8\"],\"media_region\": \"us1\",\"end_time\": \"2015-07-30T20:00:00Z\",\"url\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"participants\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants\",\"recordings\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Recordings\",\"recording_rules\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/RecordingRules\"}}"
                                     ));

            var response = RoomResource.Create(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateGroupRoomsResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"status\": \"in-progress\",\"type\": \"group\",\"sid\": \"RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"enable_turn\": true,\"unique_name\": \"grouproom\",\"max_participants\": 50,\"max_concurrent_published_tracks\": 170,\"duration\": 0,\"status_callback_method\": \"POST\",\"status_callback\": null,\"record_participants_on_connect\": false,\"video_codecs\": [\"VP8\"],\"media_region\": \"us1\",\"end_time\": \"2015-07-30T20:00:00Z\",\"url\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"participants\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants\",\"recordings\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Recordings\",\"recording_rules\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/RecordingRules\"}}"
                                     ));

            var response = RoomResource.Create(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateSmallGroupRoomsResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"status\": \"in-progress\",\"type\": \"group-small\",\"sid\": \"RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"enable_turn\": true,\"unique_name\": \"SmallDailyStandup\",\"max_participants\": 4,\"max_concurrent_published_tracks\": 170,\"duration\": 0,\"status_callback_method\": \"POST\",\"status_callback\": null,\"record_participants_on_connect\": false,\"video_codecs\": [\"VP8\"],\"media_region\": \"us1\",\"end_time\": \"2015-07-30T20:00:00Z\",\"url\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"participants\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants\",\"recordings\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Recordings\",\"recording_rules\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/RecordingRules\"}}"
                                     ));

            var response = RoomResource.Create(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateLargeGroupRoomsResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"status\": \"in-progress\",\"type\": \"group\",\"sid\": \"RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"enable_turn\": true,\"unique_name\": \"MyWebinar\",\"max_participants\": 50,\"max_concurrent_published_tracks\": 16,\"duration\": 0,\"status_callback_method\": \"POST\",\"status_callback\": null,\"record_participants_on_connect\": false,\"video_codecs\": [\"VP8\"],\"media_region\": \"us1\",\"end_time\": \"2015-07-30T20:00:00Z\",\"url\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"participants\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants\",\"recordings\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Recordings\",\"recording_rules\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/RecordingRules\"}}"
                                     ));

            var response = RoomResource.Create(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Video,
                "/v1/Rooms",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                RoomResource.Read(client: twilioRestClient);
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
                                         "{\"rooms\": [],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://video.twilio.com/v1/Rooms?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://video.twilio.com/v1/Rooms?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"rooms\"}}"
                                     ));

            var response = RoomResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadWithStatusResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"rooms\": [{\"sid\": \"RM4070b618362c1682b2385b1f9982833c\",\"status\": \"completed\",\"date_created\": \"2017-04-03T22:21:49Z\",\"date_updated\": \"2017-04-03T22:21:51Z\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"type\": \"peer-to-peer\",\"enable_turn\": true,\"unique_name\": \"RM4070b618362c1682b2385b1f9982833c\",\"status_callback\": null,\"status_callback_method\": \"POST\",\"end_time\": \"2017-04-03T22:21:51Z\",\"duration\": 2,\"max_participants\": 10,\"max_concurrent_published_tracks\": 10,\"record_participants_on_connect\": false,\"video_codecs\": [\"VP8\"],\"media_region\": \"us1\",\"url\": \"https://video.twilio.com/v1/Rooms/RM4070b618362c1682b2385b1f9982833c\",\"links\": {\"participants\": \"https://video.twilio.com/v1/Rooms/RM4070b618362c1682b2385b1f9982833c/Participants\",\"recordings\": \"https://video.twilio.com/v1/Rooms/RM4070b618362c1682b2385b1f9982833c/Recordings\",\"recording_rules\": \"https://video.twilio.com/v1/Rooms/RM4070b618362c1682b2385b1f9982833c/RecordingRules\"}}],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://video.twilio.com/v1/Rooms?Status=completed&PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://video.twilio.com/v1/Rooms?Status=completed&PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"rooms\"}}"
                                     ));

            var response = RoomResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Video,
                "/v1/Rooms/RMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            request.AddPostParam("Status", Serialize(RoomResource.RoomStatusEnum.InProgress));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                RoomResource.Update("RMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", RoomResource.RoomStatusEnum.InProgress, client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\",\"status\": \"completed\",\"type\": \"peer-to-peer\",\"sid\": \"RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"enable_turn\": true,\"unique_name\": \"unique_name\",\"max_participants\": 10,\"max_concurrent_published_tracks\": 10,\"status_callback_method\": \"POST\",\"status_callback\": null,\"record_participants_on_connect\": false,\"video_codecs\": [\"VP8\"],\"media_region\": \"us1\",\"end_time\": \"2015-07-30T20:00:00Z\",\"duration\": 10,\"url\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"links\": {\"participants\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Participants\",\"recordings\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Recordings\",\"recording_rules\": \"https://video.twilio.com/v1/Rooms/RMaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/RecordingRules\"}}"
                                     ));

            var response = RoomResource.Update("RMXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", RoomResource.RoomStatusEnum.InProgress, client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}