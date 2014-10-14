// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.robot.Robot$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2.stream;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.robot
{
  [InnerClass]
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.stream.IOStreamFactory"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.robot.Robot", null, null)]
  [SourceFile("Robot.java")]
  internal sealed class Robot\u00241 : Object, IOStreamFactory
  {
    [LineNumberTable((ushort) 24)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Robot\u00241()
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 169, (byte) 103, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IOStream createStream()
    {
      if (Robot.access\u0024000() == null)
        return (IOStream) null;
      return (IOStream) new SocketStream(Robot.access\u0024000(), Robot.access\u0024100());
    }
  }
}
