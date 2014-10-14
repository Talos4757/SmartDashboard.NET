// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.stream.SocketStream
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.net;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.stream
{
  [SourceFile(null)]
  public class SocketStream : SimpleIOStream
  {
    [Modifiers]
    private Socket socket;

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SocketStream(string str, int i)
      : this(new Socket(str, i))
    {
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SocketStream(Socket s)
      : base(s.getInputStream(), s.getOutputStream())
    {
      SocketStream socketStream = this;
      this.socket = s;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void close()
    {
      base.close();
      try
      {
        this.socket.close();
      }
      catch (IOException ex)
      {
      }
    }
  }
}
