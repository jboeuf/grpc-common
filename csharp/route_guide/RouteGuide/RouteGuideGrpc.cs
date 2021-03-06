// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: route_guide.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace examples {
  public static class RouteGuide
  {
    static readonly string __ServiceName = "examples.RouteGuide";

    static readonly Marshaller<global::examples.Point> __Marshaller_Point = Marshallers.Create((arg) => arg.ToByteArray(), global::examples.Point.ParseFrom);
    static readonly Marshaller<global::examples.Feature> __Marshaller_Feature = Marshallers.Create((arg) => arg.ToByteArray(), global::examples.Feature.ParseFrom);
    static readonly Marshaller<global::examples.Rectangle> __Marshaller_Rectangle = Marshallers.Create((arg) => arg.ToByteArray(), global::examples.Rectangle.ParseFrom);
    static readonly Marshaller<global::examples.RouteSummary> __Marshaller_RouteSummary = Marshallers.Create((arg) => arg.ToByteArray(), global::examples.RouteSummary.ParseFrom);
    static readonly Marshaller<global::examples.RouteNote> __Marshaller_RouteNote = Marshallers.Create((arg) => arg.ToByteArray(), global::examples.RouteNote.ParseFrom);

    static readonly Method<global::examples.Point, global::examples.Feature> __Method_GetFeature = new Method<global::examples.Point, global::examples.Feature>(
        MethodType.Unary,
        "GetFeature",
        __Marshaller_Point,
        __Marshaller_Feature);

    static readonly Method<global::examples.Rectangle, global::examples.Feature> __Method_ListFeatures = new Method<global::examples.Rectangle, global::examples.Feature>(
        MethodType.ServerStreaming,
        "ListFeatures",
        __Marshaller_Rectangle,
        __Marshaller_Feature);

    static readonly Method<global::examples.Point, global::examples.RouteSummary> __Method_RecordRoute = new Method<global::examples.Point, global::examples.RouteSummary>(
        MethodType.ClientStreaming,
        "RecordRoute",
        __Marshaller_Point,
        __Marshaller_RouteSummary);

    static readonly Method<global::examples.RouteNote, global::examples.RouteNote> __Method_RouteChat = new Method<global::examples.RouteNote, global::examples.RouteNote>(
        MethodType.DuplexStreaming,
        "RouteChat",
        __Marshaller_RouteNote,
        __Marshaller_RouteNote);

    // client-side stub interface
    public interface IRouteGuideClient
    {
      global::examples.Feature GetFeature(global::examples.Point request, CancellationToken token = default(CancellationToken));
      Task<global::examples.Feature> GetFeatureAsync(global::examples.Point request, CancellationToken token = default(CancellationToken));
      AsyncServerStreamingCall<global::examples.Feature> ListFeatures(global::examples.Rectangle request, CancellationToken token = default(CancellationToken));
      AsyncClientStreamingCall<global::examples.Point, global::examples.RouteSummary> RecordRoute(CancellationToken token = default(CancellationToken));
      AsyncDuplexStreamingCall<global::examples.RouteNote, global::examples.RouteNote> RouteChat(CancellationToken token = default(CancellationToken));
    }

    // server-side interface
    public interface IRouteGuide
    {
      Task<global::examples.Feature> GetFeature(ServerCallContext context, global::examples.Point request);
      Task ListFeatures(ServerCallContext context, global::examples.Rectangle request, IServerStreamWriter<global::examples.Feature> responseStream);
      Task<global::examples.RouteSummary> RecordRoute(ServerCallContext context, IAsyncStreamReader<global::examples.Point> requestStream);
      Task RouteChat(ServerCallContext context, IAsyncStreamReader<global::examples.RouteNote> requestStream, IServerStreamWriter<global::examples.RouteNote> responseStream);
    }

    // client stub
    public class RouteGuideClient : AbstractStub<RouteGuideClient, StubConfiguration>, IRouteGuideClient
    {
      public RouteGuideClient(Channel channel) : this(channel, StubConfiguration.Default)
      {
      }
      public RouteGuideClient(Channel channel, StubConfiguration config) : base(channel, config)
      {
      }
      public global::examples.Feature GetFeature(global::examples.Point request, CancellationToken token = default(CancellationToken))
      {
        var call = CreateCall(__ServiceName, __Method_GetFeature);
        return Calls.BlockingUnaryCall(call, request, token);
      }
      public Task<global::examples.Feature> GetFeatureAsync(global::examples.Point request, CancellationToken token = default(CancellationToken))
      {
        var call = CreateCall(__ServiceName, __Method_GetFeature);
        return Calls.AsyncUnaryCall(call, request, token);
      }
      public AsyncServerStreamingCall<global::examples.Feature> ListFeatures(global::examples.Rectangle request, CancellationToken token = default(CancellationToken))
      {
        var call = CreateCall(__ServiceName, __Method_ListFeatures);
        return Calls.AsyncServerStreamingCall(call, request, token);
      }
      public AsyncClientStreamingCall<global::examples.Point, global::examples.RouteSummary> RecordRoute(CancellationToken token = default(CancellationToken))
      {
        var call = CreateCall(__ServiceName, __Method_RecordRoute);
        return Calls.AsyncClientStreamingCall(call, token);
      }
      public AsyncDuplexStreamingCall<global::examples.RouteNote, global::examples.RouteNote> RouteChat(CancellationToken token = default(CancellationToken))
      {
        var call = CreateCall(__ServiceName, __Method_RouteChat);
        return Calls.AsyncDuplexStreamingCall(call, token);
      }
    }

    // creates service definition that can be registered with a server
    public static ServerServiceDefinition BindService(IRouteGuide serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder(__ServiceName)
          .AddMethod(__Method_GetFeature, serviceImpl.GetFeature)
          .AddMethod(__Method_ListFeatures, serviceImpl.ListFeatures)
          .AddMethod(__Method_RecordRoute, serviceImpl.RecordRoute)
          .AddMethod(__Method_RouteChat, serviceImpl.RouteChat).Build();
    }

    // creates a new client stub
    public static IRouteGuideClient NewStub(Channel channel)
    {
      return new RouteGuideClient(channel);
    }

    // creates a new client stub
    public static IRouteGuideClient NewStub(Channel channel, StubConfiguration config)
    {
      return new RouteGuideClient(channel, config);
    }
  }
}
#endregion
