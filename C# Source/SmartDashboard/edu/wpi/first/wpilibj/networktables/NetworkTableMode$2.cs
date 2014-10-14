// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables.NetworkTableMode$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2;
using edu.wpi.first.wpilibj.networktables2.client;
using edu.wpi.first.wpilibj.networktables2.stream;
using edu.wpi.first.wpilibj.networktables2.thread;
using edu.wpi.first.wpilibj.networktables2.type;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpilibj.networktables
{
  [InnerClass]
  [EnclosingMethod("edu.wpi.first.wpilibj.networktables.NetworkTableMode", null, null)]
  [SourceFile(null)]
  internal sealed class NetworkTableMode\u00242 : NetworkTableMode
  {
    [HideFromJava]
    static NetworkTableMode\u00242()
    {
      NetworkTableMode.__\u003Cclinit\u003E();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal NetworkTableMode\u00242([In] string obj0)
      : base(obj0, (NetworkTableMode\u00241) null)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override NetworkTableNode createNode([In] string obj0, [In] int obj1, [In] NTThreadManager obj2)
    {
      if (obj0 == null)
      {
        string str = "IP address cannot be null when in client mode";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        NetworkTableClient networkTableClient = new NetworkTableClient(SocketStreams.newStreamFactory(obj0, obj1), new NetworkTableEntryTypeManager(), obj2);
        networkTableClient.reconnect();
        return (NetworkTableNode) networkTableClient;
      }
    }
  }
}
