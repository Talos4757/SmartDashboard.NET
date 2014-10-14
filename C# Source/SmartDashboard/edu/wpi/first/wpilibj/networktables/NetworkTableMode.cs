// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables.NetworkTableMode
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2;
using edu.wpi.first.wpilibj.networktables2.thread;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpilibj.networktables
{
  [SourceFile(null)]
  public abstract class NetworkTableMode : Object
  {
    internal static NetworkTableMode __\u003C\u003EServer = (NetworkTableMode) new NetworkTableMode\u00241("Server");
    internal static NetworkTableMode __\u003C\u003EClient = (NetworkTableMode) new NetworkTableMode\u00242("Client");
    private string name;

    [Modifiers]
    public static NetworkTableMode Server
    {
      [HideFromJava] get
      {
        return NetworkTableMode.__\u003C\u003EServer;
      }
    }

    [Modifiers]
    public static NetworkTableMode Client
    {
      [HideFromJava] get
      {
        return NetworkTableMode.__\u003C\u003EClient;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private NetworkTableMode([In] string obj0)
    {
      base.\u002Ector();
      NetworkTableMode networkTableMode = this;
      this.name = obj0;
    }

    [Modifiers]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal NetworkTableMode([In] string obj0, [In] NetworkTableMode\u00241 obj1)
      : this(obj0)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Throws(new string[] {"java.io.IOException"})]
    [Modifiers]
    internal virtual NetworkTableNode createNode([In] string obj0, [In] int obj1, [In] NTThreadManager obj2)
    {
      throw new AbstractMethodError("edu.wpi.first.wpilibj.networktables.NetworkTableMode.createNode(Ljava.lang.String;ILedu.wpi.first.wpilibj.networktables2.thread.NTThreadManager;)Ledu.wpi.first.wpilibj.networktables2.NetworkTableNode;");
    }

    public virtual string toString()
    {
      return this.name;
    }
  }
}
