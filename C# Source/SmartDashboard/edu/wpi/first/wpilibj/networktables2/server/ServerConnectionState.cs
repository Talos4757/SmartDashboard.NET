// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.server.ServerConnectionState
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.server
{
  [SourceFile(null)]
  public class ServerConnectionState : Object
  {
    internal static ServerConnectionState __\u003C\u003EGOT_CONNECTION_FROM_CLIENT = new ServerConnectionState("GOT_CONNECTION_FROM_CLIENT");
    internal static ServerConnectionState __\u003C\u003ECONNECTED_TO_CLIENT = new ServerConnectionState("CONNECTED_TO_CLIENT");
    internal static ServerConnectionState __\u003C\u003ECLIENT_DISCONNECTED = new ServerConnectionState("CLIENT_DISCONNECTED");
    private string name;

    [Modifiers]
    public static ServerConnectionState GOT_CONNECTION_FROM_CLIENT
    {
      [HideFromJava] get
      {
        return ServerConnectionState.__\u003C\u003EGOT_CONNECTION_FROM_CLIENT;
      }
    }

    [Modifiers]
    public static ServerConnectionState CONNECTED_TO_CLIENT
    {
      [HideFromJava] get
      {
        return ServerConnectionState.__\u003C\u003ECONNECTED_TO_CLIENT;
      }
    }

    [Modifiers]
    public static ServerConnectionState CLIENT_DISCONNECTED
    {
      [HideFromJava] get
      {
        return ServerConnectionState.__\u003C\u003ECLIENT_DISCONNECTED;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal ServerConnectionState(string str)
    {
      base.\u002Ector();
      ServerConnectionState serverConnectionState = this;
      this.name = str;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual string toString()
    {
      return this.name;
    }

    [InnerClass]
    [SourceFile(null)]
    public class Error : ServerConnectionState
    {
      [Modifiers]
      private Exception e;

      [HideFromJava]
      static Error()
      {
        ServerConnectionState.__\u003Cclinit\u003E();
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Error(Exception e)
        : base("SERVER_ERROR")
      {
        ServerConnectionState.Error error = this;
        this.e = e;
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override string toString()
      {
        return new StringBuilder().append("SERVER_ERROR: ").append((object) Object.instancehelper_getClass((object) this.e)).append(": ").append(Throwable.instancehelper_getMessage((Exception) this.e)).toString();
      }

      public virtual Exception getException()
      {
        return this.e;
      }
    }
  }
}
