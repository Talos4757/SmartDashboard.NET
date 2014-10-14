// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.stream.SocketStreamFactory
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.stream
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.stream.IOStreamFactory"})]
  [SourceFile(null)]
  public class SocketStreamFactory : Object, IOStreamFactory
  {
    [Modifiers]
    private string host;
    [Modifiers]
    private int port;

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SocketStreamFactory(string str, int i)
    {
      base.\u002Ector();
      SocketStreamFactory socketStreamFactory = this;
      this.host = str;
      this.port = i;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IOStream createStream()
    {
      return (IOStream) new SocketStream(this.host, this.port);
    }
  }
}
