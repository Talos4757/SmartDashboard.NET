// Decompiled with JetBrains decompiler
// Type: org.junit.internal.ExactComparisonCriteria
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.junit;
using org.junit.@internal;
using System.Runtime.CompilerServices;

namespace org.junit.@internal
{
  public class ExactComparisonCriteria : ComparisonCriteria
  {
    [LineNumberTable((ushort) 5)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExactComparisonCriteria()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 150, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void assertElementsEqual(object expected, object actual)
    {
      Assert.assertEquals(expected, actual);
    }
  }
}
