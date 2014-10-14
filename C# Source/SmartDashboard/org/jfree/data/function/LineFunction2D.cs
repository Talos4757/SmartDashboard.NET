// Decompiled with JetBrains decompiler
// Type: org.jfree.data.function.LineFunction2D
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.data.function
{
  [Implements(new string[] {"org.jfree.data.function.Function2D"})]
  public class LineFunction2D : Object, Function2D
  {
    private double a;
    private double b;

    [LineNumberTable(new byte[] {(byte) 10, (byte) 104, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LineFunction2D(double a, double b)
    {
      base.\u002Ector();
      LineFunction2D lineFunction2D = this;
      this.a = a;
      this.b = b;
    }

    public virtual double getValue(double x)
    {
      return this.a + this.b * x;
    }
  }
}
