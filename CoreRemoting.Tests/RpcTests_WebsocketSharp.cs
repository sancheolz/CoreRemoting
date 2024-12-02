using CoreRemoting.Channels;
using CoreRemoting.Channels.WebsocketSharp;
using Xunit;
using Xunit.Abstractions;

namespace CoreRemoting.Tests
{
    public class RpcTests_WebsocketSharp : RpcTests
    {
        protected override IServerChannel ServerChannel => new WebsocketSharpServerChannel();

        protected override IClientChannel ClientChannel => new WebsocketSharpClientChannel();

        public RpcTests_WebsocketSharp(ServerFixture fixture, ITestOutputHelper helper) : base(fixture, helper)
        {
        }
    }
}