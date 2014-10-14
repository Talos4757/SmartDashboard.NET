// Decompiled with JetBrains decompiler
// Type: org.junit.internal.InexactComparisonCriteria
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit;
using org.junit.@internal;
using System.Runtime.CompilerServices;

namespace org.junit.@internal
{
  public class InexactComparisonCriteria : ComparisonCriteria
  {
    public double fDelta;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 150, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public InexactComparisonCriteria(double delta)
    {
      InexactComparisonCriteria comparisonCriteria = this;
      this.fDelta = delta;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 156, (byte) 104, (byte) 159, (byte) 4, (byte) 127, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void assertElementsEqual(object expected, object actual)
    {
      if (expected is Double)
        Assert.assertEquals(((Double) expected).doubleValue(), ((Double) actual).doubleValue(), this.fDelta);
      else
        Assert.assertEquals((double) ((Float) expected).floatValue(), (double) ((Float) actual).floatValue(), this.fDelta);
    }
  }
}
