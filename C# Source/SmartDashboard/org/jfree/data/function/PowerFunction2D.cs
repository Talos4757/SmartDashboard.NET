// Decompiled with JetBrains decompiler
// Type: org.jfree.data.function.PowerFunction2D
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.data.function
{
  [Implements(new string[] {"org.jfree.data.function.Function2D"})]
  public class PowerFunction2D : Object, Function2D
  {
    private double a;
    private double b;

    [LineNumberTable(new byte[] {(byte) 10, (byte) 104, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PowerFunction2D(double a, double b)
    {
      base.\u002Ector();
      PowerFunction2D powerFunction2D = this;
      this.a = a;
      this.b = b;
    }

    [LineNumberTable((ushort) 73)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getValue(double x)
    {
      return this.a * Math.pow(x, this.b);
    }
  }
}
