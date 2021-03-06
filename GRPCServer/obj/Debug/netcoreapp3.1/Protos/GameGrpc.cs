// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/game.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GRPCServer {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Game
  {
    static readonly string __ServiceName = "game.Game";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::GRPCServer.GameRequest> __Marshaller_game_GameRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GRPCServer.GameRequest.Parser));
    static readonly grpc::Marshaller<global::GRPCServer.EvaluateGame> __Marshaller_game_EvaluateGame = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GRPCServer.EvaluateGame.Parser));

    static readonly grpc::Method<global::GRPCServer.GameRequest, global::GRPCServer.EvaluateGame> __Method_PlayGame = new grpc::Method<global::GRPCServer.GameRequest, global::GRPCServer.EvaluateGame>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PlayGame",
        __Marshaller_game_GameRequest,
        __Marshaller_game_EvaluateGame);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GRPCServer.GameReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Game</summary>
    [grpc::BindServiceMethod(typeof(Game), "BindService")]
    public abstract partial class GameBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::GRPCServer.EvaluateGame> PlayGame(global::GRPCServer.GameRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GameBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_PlayGame, serviceImpl.PlayGame).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GameBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_PlayGame, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GRPCServer.GameRequest, global::GRPCServer.EvaluateGame>(serviceImpl.PlayGame));
    }

  }
}
#endregion
