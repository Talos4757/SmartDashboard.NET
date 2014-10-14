// Decompiled with JetBrains decompiler
// Type: org.junit.internal.RealSystem
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using org.junit.@internal;
using System.Runtime.CompilerServices;

namespace org.junit.@internal
{
  [Implements(new string[] {"org.junit.internal.JUnitSystem"})]
  public class RealSystem : Object, JUnitSystem
  {
    [LineNumberTable((ushort) 5)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RealSystem()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 150, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void exit(int code)
    {
      System.exit(code);
    }

    [LineNumberTable((ushort) 12)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual PrintStream @out()
    {
      return System.get_out();
    }
  }
}
