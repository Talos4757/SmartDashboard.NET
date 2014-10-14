// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables.NetworkTableMode$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2;
using edu.wpi.first.wpilibj.networktables2.server;
using edu.wpi.first.wpilibj.networktables2.stream;
using edu.wpi.first.wpilibj.networktables2.thread;
using edu.wpi.first.wpilibj.networktables2.type;
using IKVM.Attributes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpilibj.networktables
{
  [InnerClass]
  [EnclosingMethod("edu.wpi.first.wpilibj.networktables.NetworkTableMode", null, null)]
  [SourceFile(null)]
  internal sealed class NetworkTableMode\u00241 : NetworkTableMode
  {
    [HideFromJava]
    static NetworkTableMode\u00241()
    {
      NetworkTableMode.__\u003Cclinit\u003E();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal NetworkTableMode\u00241([In] string obj0)
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
      return (NetworkTableNode) new NetworkTableServer(SocketStreams.newStreamProvider(obj1), new NetworkTableEntryTypeManager(), obj2);
    }
  }
}
