// Decompiled with JetBrains decompiler
// Type: org.junit.internal.ComparisonCriteria
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using org.junit;
using org.junit.@internal;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal
{
  public abstract class ComparisonCriteria : Object
  {
    [LineNumberTable((ushort) 11)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ComparisonCriteria()
    {
      base.\u002Ector();
    }

    [Throws(new string[] {"org.junit.internal.ArrayComparisonFailure"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 172, (byte) 100, (byte) 97, (byte) 159, (byte) 6, (byte) 170, (byte) 105, (byte) 104, (byte) 137, (byte) 147, (byte) 222, (byte) 226, (byte) 61, (byte) 98, (byte) 104, (byte) 200, (byte) 191, (byte) 3, (byte) 2, (byte) 98, (byte) 239, (byte) 49, (byte) 233, (byte) 82})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void arrayEquals(string message, object expecteds, object actuals)
    {
      if (expecteds == actuals)
        return;
      string str = message != null ? new StringBuilder().append(message).append(": ").toString() : "";
      int num1 = this.assertArraysAreSameLength(expecteds, actuals, str);
      for (int index1 = 0; index1 < num1; ++index1)
      {
        object expecteds1 = Array.get(expecteds, index1);
        object actuals1 = Array.get(actuals, index1);
        if (this.isArray(expecteds1))
        {
          if (this.isArray(actuals1))
          {
            ArrayComparisonFailure comparisonFailure1;
            try
            {
              this.arrayEquals(message, expecteds1, actuals1);
              continue;
            }
            catch (ArrayComparisonFailure ex)
            {
              int num2 = 1;
              comparisonFailure1 = (ArrayComparisonFailure) ByteCodeHelper.MapException<ArrayComparisonFailure>((Exception) ex, (ByteCodeHelper.MapFlags) num2);
            }
            ArrayComparisonFailure comparisonFailure2 = comparisonFailure1;
            comparisonFailure2.addDimension(index1);
            throw Throwable.__\u003Cunmap\u003E((Exception) comparisonFailure2);
          }
        }
        AssertionError assertionError1;
        try
        {
          this.assertElementsEqual(expecteds1, actuals1);
          continue;
        }
        catch (Exception ex)
        {
          int num2 = 0;
          M0 m0 = ByteCodeHelper.MapException<AssertionError>(ex, (ByteCodeHelper.MapFlags) num2);
          if (m0 == null)
            throw;
          else
            assertionError1 = (AssertionError) m0;
        }
        AssertionError assertionError2 = assertionError1;
        string message1 = str;
        AssertionError cause = assertionError2;
        int index2 = index1;
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new ArrayComparisonFailure(message1, cause, index2);
      }
    }

    [LineNumberTable(new byte[] {(byte) 13, (byte) 99, (byte) 127, (byte) 0, (byte) 99, (byte) 127, (byte) 0, (byte) 103, (byte) 103, (byte) 100, (byte) 159, (byte) 22})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private int assertArraysAreSameLength([In] object obj0, [In] object obj1, [In] string obj2)
    {
      if (obj0 == null)
        Assert.fail(new StringBuilder().append(obj2).append("expected array was null").toString());
      if (obj1 == null)
        Assert.fail(new StringBuilder().append(obj2).append("actual array was null").toString());
      int length1 = Array.getLength(obj1);
      int length2 = Array.getLength(obj0);
      if (length1 != length2)
        Assert.fail(new StringBuilder().append(obj2).append("array lengths differed, expected.length=").append(length2).append(" actual.length=").append(length1).toString());
      return length2;
    }

    [LineNumberTable((ushort) 58)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isArray([In] object obj0)
    {
      return obj0 != null && Object.instancehelper_getClass(obj0).isArray();
    }

    protected internal abstract void assertElementsEqual(object obj1, object obj2);
  }
}
