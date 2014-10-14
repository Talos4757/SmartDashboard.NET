// Decompiled with JetBrains decompiler
// Type: org.hamcrest.core.IsEqual
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using org.hamcrest;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.hamcrest.core
{
  [Signature("<T:Ljava/lang/Object;>Lorg/hamcrest/BaseMatcher<TT;>;")]
  public class IsEqual : BaseMatcher
  {
    [Modifiers]
    private object @object;

    [Signature("(TT;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 162, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IsEqual(object equalArg)
    {
      IsEqual isEqual = this;
      this.@object = equalArg;
    }

    [Signature("<T:Ljava/lang/Object;>(TT;)Lorg/hamcrest/Matcher<TT;>;")]
    [LineNumberTable((ushort) 68)]
    [Factory(new object[] {(byte) 64, "Lorg/hamcrest/Factory;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Matcher equalTo(object operand)
    {
      return (Matcher) new IsEqual(operand);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 102, (byte) 107, (byte) 104, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool areEqual([In] object obj0, [In] object obj1)
    {
      if (obj0 == null || obj1 == null)
        return obj0 == null && obj1 == null;
      else if (IsEqual.isArray(obj0))
        return IsEqual.isArray(obj1) && IsEqual.areArraysEqual(obj0, obj1);
      else
        return (Object.instancehelper_equals(obj0, obj1) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 59)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool isArray([In] object obj0)
    {
      return (Object.instancehelper_getClass(obj0).isArray() ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 43)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool areArraysEqual([In] object obj0, [In] object obj1)
    {
      return IsEqual.areArrayLengthsEqual(obj0, obj1) && IsEqual.areArrayElementsEqual(obj0, obj1);
    }

    [LineNumberTable((ushort) 48)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool areArrayLengthsEqual([In] object obj0, [In] object obj1)
    {
      return Array.getLength(obj0) == Array.getLength(obj1);
    }

    [LineNumberTable(new byte[] {(byte) 2, (byte) 107, (byte) 55, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool areArrayElementsEqual([In] object obj0, [In] object obj1)
    {
      for (int index = 0; index < Array.getLength(obj0); ++index)
      {
        if (!IsEqual.areEqual(Array.get(obj0, index), Array.get(obj1, index)))
          return false;
      }
      return true;
    }

    [LineNumberTable((ushort) 25)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool matches(object arg)
    {
      return (IsEqual.areEqual(this.@object, arg) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 171, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void describeTo(Description description)
    {
      description.appendValue(this.@object);
    }
  }
}
