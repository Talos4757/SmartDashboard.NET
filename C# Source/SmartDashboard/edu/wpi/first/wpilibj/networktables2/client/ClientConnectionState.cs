// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.client.ClientConnectionState
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.client
{
  [SourceFile(null)]
  public class ClientConnectionState : Object
  {
    internal static ClientConnectionState __\u003C\u003EDISCONNECTED_FROM_SERVER = new ClientConnectionState("DISCONNECTED_FROM_SERVER");
    internal static ClientConnectionState __\u003C\u003ECONNECTED_TO_SERVER = new ClientConnectionState("CONNECTED_TO_SERVER");
    internal static ClientConnectionState __\u003C\u003ESENT_HELLO_TO_SERVER = new ClientConnectionState("SENT_HELLO_TO_SERVER");
    internal static ClientConnectionState __\u003C\u003EIN_SYNC_WITH_SERVER = new ClientConnectionState("IN_SYNC_WITH_SERVER");
    private string name;

    [Modifiers]
    public static ClientConnectionState DISCONNECTED_FROM_SERVER
    {
      [HideFromJava] get
      {
        return ClientConnectionState.__\u003C\u003EDISCONNECTED_FROM_SERVER;
      }
    }

    [Modifiers]
    public static ClientConnectionState CONNECTED_TO_SERVER
    {
      [HideFromJava] get
      {
        return ClientConnectionState.__\u003C\u003ECONNECTED_TO_SERVER;
      }
    }

    [Modifiers]
    public static ClientConnectionState SENT_HELLO_TO_SERVER
    {
      [HideFromJava] get
      {
        return ClientConnectionState.__\u003C\u003ESENT_HELLO_TO_SERVER;
      }
    }

    [Modifiers]
    public static ClientConnectionState IN_SYNC_WITH_SERVER
    {
      [HideFromJava] get
      {
        return ClientConnectionState.__\u003C\u003EIN_SYNC_WITH_SERVER;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal ClientConnectionState(string str)
    {
      base.\u002Ector();
      ClientConnectionState clientConnectionState = this;
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
    public class Error : ClientConnectionState
    {
      [Modifiers]
      private Exception e;

      [HideFromJava]
      static Error()
      {
        ClientConnectionState.__\u003Cclinit\u003E();
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Error(Exception e)
        : base("CLIENT_ERROR")
      {
        ClientConnectionState.Error error = this;
        this.e = e;
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }

      public virtual Exception getException()
      {
        return this.e;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override string toString()
      {
        return new StringBuilder().append("CLIENT_ERROR: ").append((object) Object.instancehelper_getClass((object) this.e)).append(": ").append(Throwable.instancehelper_getMessage((Exception) this.e)).toString();
      }
    }

    [InnerClass]
    [SourceFile(null)]
    public class ProtocolUnsuppotedByServer : ClientConnectionState
    {
      [Modifiers]
      private char serverVersion;

      [HideFromJava]
      static ProtocolUnsuppotedByServer()
      {
        ClientConnectionState.__\u003Cclinit\u003E();
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ProtocolUnsuppotedByServer(char ch)
      {
        int num = (int) ch;
        // ISSUE: explicit constructor call
        base.\u002Ector("PROTOCOL_UNSUPPORTED_BY_SERVER");
        ClientConnectionState.ProtocolUnsuppotedByServer unsuppotedByServer = this;
        this.serverVersion = (char) num;
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }

      public virtual char getServerVersion()
      {
        return this.serverVersion;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override string toString()
      {
        return new StringBuilder().append("PROTOCOL_UNSUPPORTED_BY_SERVER: Server Version: 0x").append(Integer.toHexString((int) this.serverVersion)).toString();
      }
    }
  }
}
