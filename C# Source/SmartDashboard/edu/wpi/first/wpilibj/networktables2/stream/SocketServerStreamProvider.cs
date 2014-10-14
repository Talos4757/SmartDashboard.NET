// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.stream.SocketServerStreamProvider
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.net;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.stream
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.stream.IOStreamProvider"})]
  [SourceFile(null)]
  public class SocketServerStreamProvider : Object, IOStreamProvider
  {
    private ServerSocket server;

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SocketServerStreamProvider(int i)
    {
      base.\u002Ector();
      SocketServerStreamProvider serverStreamProvider = this;
      this.server = (ServerSocket) null;
      this.server = new ServerSocket(i);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IOStream accept()
    {
      return (IOStream) new SocketStream(this.server.accept());
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void close()
    {
      if (this.server == null)
        return;
      this.server.close();
    }
  }
}
