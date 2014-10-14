// Decompiled with JetBrains decompiler
// Type: org.jfree.data.function.NormalDistributionFunction2D
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.data.function
{
  [Implements(new string[] {"org.jfree.data.function.Function2D"})]
  public class NormalDistributionFunction2D : Object, Function2D
  {
    private double mean;
    private double std;
    private double factor;
    private double denominator;

    [LineNumberTable(new byte[] {(byte) 20, (byte) 104, (byte) 105, (byte) 144, (byte) 105, (byte) 137, (byte) 126, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public NormalDistributionFunction2D(double mean, double std)
    {
      base.\u002Ector();
      NormalDistributionFunction2D distributionFunction2D = this;
      if (std <= 0.0)
      {
        string str = "Requires 'std' > 0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.mean = mean;
        this.std = std;
        this.factor = 1.0 / (std * Math.sqrt(2.0 * Math.PI));
        this.denominator = 2.0 * std * std;
      }
    }

    public virtual double getMean()
    {
      return this.mean;
    }

    public virtual double getStandardDeviation()
    {
      return this.std;
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getValue(double x)
    {
      double num = x - this.mean;
      return this.factor * Math.exp(-num * num / this.denominator);
    }
  }
}
