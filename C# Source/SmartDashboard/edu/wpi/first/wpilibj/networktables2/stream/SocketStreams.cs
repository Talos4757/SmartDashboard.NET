// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.stream.SocketStreams
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpilibj.networktables2.stream
{
  [SourceFile(null)]
  public sealed class SocketStreams : Object
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    private SocketStreams()
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IOStreamProvider newStreamProvider(int i)
    {
      return (IOStreamProvider) new SocketServerStreamProvider(i);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IOStreamFactory newStreamFactory(string str, int i)
    {
      return (IOStreamFactory) new SocketStreamFactory(str, i);
    }
  }
}
