// Decompiled with JetBrains decompiler
// Type: org.junit.Assert
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.hamcrest;
using org.junit.@internal;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit
{
  public class Assert : Object
  {
    [LineNumberTable(new byte[] {(byte) 159, (byte) 170, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Assert()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 91)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void fail(string message)
    {
      string str = message != null ? message : "";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new AssertionError((object) str);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 132, (byte) 130, (byte) 99, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertTrue(string message, bool condition)
    {
      if (condition)
        return;
      Assert.fail(message);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 125, (byte) 66, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertFalse(string message, bool condition)
    {
      int num = condition ? 1 : 0;
      Assert.assertTrue(message, num == 0);
    }

    [LineNumberTable((ushort) 130)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool isEquals([In] object obj0, [In] object obj1)
    {
      return (Object.instancehelper_equals(obj0, obj1) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 19, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void failNotEquals([In] string obj0, [In] object obj1, [In] object obj2)
    {
      Assert.fail(Assert.format(obj0, obj1, obj2));
    }

    [LineNumberTable(new byte[] {(byte) 67, (byte) 102, (byte) 97, (byte) 108, (byte) 97, (byte) 112, (byte) 108, (byte) 184, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(string message, object expected, object actual)
    {
      if (expected == null && actual == null || expected != null && Assert.isEquals(expected, actual))
        return;
      if (expected is string && actual is string)
      {
        string message1 = message != null ? message : "";
        string expected1 = (string) expected;
        string actual1 = (string) actual;
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new ComparisonFailure(message1, expected1, actual1);
      }
      else
        Assert.failNotEquals(message, expected, actual);
    }

    [Throws(new string[] {"org.junit.internal.ArrayComparisonFailure"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 44, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void internalArrayEquals([In] string obj0, [In] object obj1, [In] object obj2)
    {
      new ExactComparisonCriteria().arrayEquals(obj0, obj1, obj2);
    }

    [Throws(new string[] {"org.junit.internal.ArrayComparisonFailure"})]
    [LineNumberTable(new byte[] {(byte) 116, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertArrayEquals(string message, object[] expecteds, object[] actuals)
    {
      Assert.internalArrayEquals(message, (object) expecteds, (object) actuals);
    }

    [Throws(new string[] {"org.junit.internal.ArrayComparisonFailure"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 86, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertArrayEquals(string message, byte[] expecteds, byte[] actuals)
    {
      Assert.internalArrayEquals(message, (object) expecteds, (object) actuals);
    }

    [Throws(new string[] {"org.junit.internal.ArrayComparisonFailure"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 116, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertArrayEquals(string message, char[] expecteds, char[] actuals)
    {
      Assert.internalArrayEquals(message, (object) expecteds, (object) actuals);
    }

    [Throws(new string[] {"org.junit.internal.ArrayComparisonFailure"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 146, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertArrayEquals(string message, short[] expecteds, short[] actuals)
    {
      Assert.internalArrayEquals(message, (object) expecteds, (object) actuals);
    }

    [Throws(new string[] {"org.junit.internal.ArrayComparisonFailure"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 176, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertArrayEquals(string message, int[] expecteds, int[] actuals)
    {
      Assert.internalArrayEquals(message, (object) expecteds, (object) actuals);
    }

    [Throws(new string[] {"org.junit.internal.ArrayComparisonFailure"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 206, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertArrayEquals(string message, long[] expecteds, long[] actuals)
    {
      Assert.internalArrayEquals(message, (object) expecteds, (object) actuals);
    }

    [Throws(new string[] {"org.junit.internal.ArrayComparisonFailure"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 236, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertArrayEquals(string message, double[] expecteds, double[] actuals, double delta)
    {
      new InexactComparisonCriteria(delta).arrayEquals(message, (object) expecteds, (object) actuals);
    }

    [Throws(new string[] {"org.junit.internal.ArrayComparisonFailure"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 10, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertArrayEquals(string message, float[] expecteds, float[] actuals, float delta)
    {
      new InexactComparisonCriteria((double) delta).arrayEquals(message, (object) expecteds, (object) actuals);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 100, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(string message, long expected, long actual)
    {
      Assert.assertEquals(message, (object) Long.valueOf(expected), (object) Long.valueOf(actual));
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 121, (byte) 108})]
    [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(string message, double expected, double actual)
    {
      Assert.fail("Use assertEquals(expected, actual, delta) to compare floating-point numbers");
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 68, (byte) 107, (byte) 97, (byte) 110, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(string message, double expected, double actual, double delta)
    {
      if (Double.compare(expected, actual) == 0 || Math.abs(expected - actual) <= delta)
        return;
      Assert.failNotEquals(message, (object) new Double(expected), (object) new Double(actual));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 154, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertNotNull(string message, object @object)
    {
      Assert.assertTrue(message, @object != null);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 179, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertNull(string message, object @object)
    {
      Assert.assertTrue(message, @object == null);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 10, (byte) 102, (byte) 99, (byte) 123, (byte) 159, (byte) 34})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void failNotSame([In] string obj0, [In] object obj1, [In] object obj2)
    {
      string str = "";
      if (obj0 != null)
        str = new StringBuilder().append(obj0).append(" ").toString();
      Assert.fail(new StringBuilder().append(str).append("expected same:<").append(obj1).append("> was not:<").append(obj2).append(">").toString());
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 206, (byte) 100, (byte) 97, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertSame(string message, object expected, object actual)
    {
      if (expected == actual)
        return;
      Assert.failNotSame(message, expected, actual);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 2, (byte) 102, (byte) 99, (byte) 123, (byte) 127, (byte) 2})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void failSame([In] string obj0)
    {
      string str = "";
      if (obj0 != null)
        str = new StringBuilder().append(obj0).append(" ").toString();
      Assert.fail(new StringBuilder().append(str).append("expected not same").toString());
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 239, (byte) 100, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertNotSame(string message, object unexpected, object actual)
    {
      if (unexpected != actual)
        return;
      Assert.failSame(message);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 23, (byte) 102, (byte) 112, (byte) 123, (byte) 103, (byte) 103, (byte) 105, (byte) 223, (byte) 32})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static string format([In] string obj0, [In] object obj1, [In] object obj2)
    {
      string str1 = "";
      if (obj0 != null && !String.instancehelper_equals(obj0, (object) ""))
        str1 = new StringBuilder().append(obj0).append(" ").toString();
      string str2 = String.valueOf(obj1);
      string str3 = String.valueOf(obj2);
      if (String.instancehelper_equals(str2, (object) str3))
        return new StringBuilder().append(str1).append("expected: ").append(Assert.formatClassAndValue(obj1, str2)).append(" but was: ").append(Assert.formatClassAndValue(obj2, str3)).toString();
      else
        return new StringBuilder().append(str1).append("expected:<").append(str2).append("> but was:<").append(str3).append(">").toString();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 38, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string formatClassAndValue([In] object obj0, [In] string obj1)
    {
      return new StringBuilder().append(obj0 != null ? Object.instancehelper_getClass(obj0).getName() : "null").append("<").append(obj1).append(">").toString();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 69, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertArrayEquals(object[] expecteds, object[] actuals)
    {
      Assert.assertArrayEquals((string) null, expecteds, actuals);
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/String;TT;Lorg/hamcrest/Matcher<TT;>;)V")]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 144, (byte) 105, (byte) 102, (byte) 104, (byte) 108, (byte) 104, (byte) 108, (byte) 104, (byte) 108, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertThat(string reason, object actual, Matcher matcher)
    {
      if (matcher.matches(actual))
        return;
      StringDescription stringDescription = new StringDescription();
      stringDescription.appendText(reason);
      stringDescription.appendText("\nExpected: ");
      stringDescription.appendDescriptionOf((SelfDescribing) matcher);
      stringDescription.appendText("\n     got: ");
      stringDescription.appendValue(actual);
      stringDescription.appendText("\n");
      string str = Object.instancehelper_toString((object) stringDescription);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new AssertionError((object) str);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 129, (byte) 130, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertTrue(bool condition)
    {
      Assert.assertTrue((string) null, condition);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 123, (byte) 162, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertFalse(bool condition)
    {
      Assert.assertFalse((string) null, condition);
    }

    [LineNumberTable(new byte[] {(byte) 48, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void fail()
    {
      Assert.fail((string) null);
    }

    [LineNumberTable(new byte[] {(byte) 95, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(object expected, object actual)
    {
      Assert.assertEquals((string) null, expected, actual);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 99, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertArrayEquals(byte[] expecteds, byte[] actuals)
    {
      Assert.assertArrayEquals((string) null, expecteds, actuals);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 129, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertArrayEquals(char[] expecteds, char[] actuals)
    {
      Assert.assertArrayEquals((string) null, expecteds, actuals);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 159, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertArrayEquals(short[] expecteds, short[] actuals)
    {
      Assert.assertArrayEquals((string) null, expecteds, actuals);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 189, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertArrayEquals(int[] expecteds, int[] actuals)
    {
      Assert.assertArrayEquals((string) null, expecteds, actuals);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 219, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertArrayEquals(long[] expecteds, long[] actuals)
    {
      Assert.assertArrayEquals((string) null, expecteds, actuals);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 249, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertArrayEquals(double[] expecteds, double[] actuals, double delta)
    {
      Assert.assertArrayEquals((string) null, expecteds, actuals, delta);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 23, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertArrayEquals(float[] expecteds, float[] actuals, float delta)
    {
      Assert.assertArrayEquals((string) null, expecteds, actuals, delta);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 84, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(long expected, long actual)
    {
      Assert.assertEquals((string) null, expected, actual);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 110, (byte) 108})]
    [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(double expected, double actual)
    {
      Assert.assertEquals((string) null, expected, actual);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 140, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(double expected, double actual, double delta)
    {
      Assert.assertEquals((string) null, expected, actual, delta);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 165, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertNotNull(object @object)
    {
      Assert.assertNotNull((string) null, @object);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 190, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertNull(object @object)
    {
      Assert.assertNull((string) null, @object);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 221, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertSame(object expected, object actual)
    {
      Assert.assertSame((string) null, expected, actual);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 254, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertNotSame(object unexpected, object actual)
    {
      Assert.assertNotSame((string) null, unexpected, actual);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 62, (byte) 106})]
    [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(string message, object[] expecteds, object[] actuals)
    {
      Assert.assertArrayEquals(message, expecteds, actuals);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 81, (byte) 105})]
    [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(object[] expecteds, object[] actuals)
    {
      Assert.assertArrayEquals(expecteds, actuals);
    }

    [Signature("<T:Ljava/lang/Object;>(TT;Lorg/hamcrest/Matcher<TT;>;)V")]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 110, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertThat(object actual, Matcher matcher)
    {
      Assert.assertThat("", actual, matcher);
    }
  }
}
