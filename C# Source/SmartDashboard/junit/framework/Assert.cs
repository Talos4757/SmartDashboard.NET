// Decompiled with JetBrains decompiler
// Type: junit.framework.Assert
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace junit.framework
{
  public class Assert : Object
  {
    [LineNumberTable(new byte[] {(byte) 159, (byte) 153, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Assert()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 47)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void fail(string message)
    {
      string message1 = message;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new AssertionFailedError(message1);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 138, (byte) 162, (byte) 99, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertTrue(string message, bool condition)
    {
      if (condition)
        return;
      Assert.fail(message);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 134, (byte) 130, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertFalse(string message, bool condition)
    {
      int num = condition ? 1 : 0;
      Assert.assertTrue(message, num == 0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 169, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void failNotEquals(string message, object expected, object actual)
    {
      Assert.fail(Assert.format(message, expected, actual));
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 102, (byte) 97, (byte) 108, (byte) 97, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(string message, object expected, object actual)
    {
      if (expected == null && actual == null || expected != null && Object.instancehelper_equals(expected, actual))
        return;
      Assert.failNotEquals(message, expected, actual);
    }

    [LineNumberTable(new byte[] {(byte) 27, (byte) 102, (byte) 97, (byte) 108, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(string message, string expected, string actual)
    {
      if (expected == null && actual == null || expected != null && String.instancehelper_equals(expected, (object) actual))
        return;
      string message1 = message;
      string expected1 = expected;
      string actual1 = actual;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new ComparisonFailure(message1, expected1, actual1);
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 107, (byte) 97, (byte) 110, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(string message, double expected, double actual, double delta)
    {
      if (Double.compare(expected, actual) == 0 || Math.abs(expected - actual) <= delta)
        return;
      Assert.failNotEquals(message, (object) new Double(expected), (object) new Double(actual));
    }

    [LineNumberTable(new byte[] {(byte) 63, (byte) 107, (byte) 97, (byte) 111, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(string message, float expected, float actual, float delta)
    {
      if (Float.compare(expected, actual) == 0 || (double) Math.abs(expected - actual) <= (double) delta)
        return;
      Assert.failNotEquals(message, (object) new Float(expected), (object) new Float(actual));
    }

    [LineNumberTable(new byte[] {(byte) 80, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(string message, long expected, long actual)
    {
      Assert.assertEquals(message, (object) new Long(expected), (object) new Long(actual));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 107, (byte) 164, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(string message, bool expected, bool actual)
    {
      int num1 = expected ? 1 : 0;
      int num2 = actual ? 1 : 0;
      Assert.assertEquals(message, (object) Boolean.valueOf(num1 != 0), (object) Boolean.valueOf(num2 != 0));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 103, (byte) 70, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(string message, byte expected, byte actual)
    {
      int num1 = (int) (sbyte) expected;
      int num2 = (int) (sbyte) actual;
      Assert.assertEquals(message, (object) new Byte((byte) num1), (object) new Byte((byte) num2));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 100, (byte) 100, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(string message, char expected, char actual)
    {
      int num1 = (int) expected;
      int num2 = (int) actual;
      Assert.assertEquals(message, (object) new Character((char) num1), (object) new Character((char) num2));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 97, (byte) 132, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(string message, short expected, short actual)
    {
      int num1 = (int) expected;
      int num2 = (int) actual;
      Assert.assertEquals(message, (object) new Short((short) num1), (object) new Short((short) num2));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 81, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(string message, int expected, int actual)
    {
      Assert.assertEquals(message, (object) new Integer(expected), (object) new Integer(actual));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 100, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertNotNull(string message, object @object)
    {
      Assert.assertTrue(message, @object != null);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 119, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertNull(string message, object @object)
    {
      Assert.assertTrue(message, @object == null);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 162, (byte) 102, (byte) 99, (byte) 123, (byte) 127, (byte) 34})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void failNotSame(string message, object expected, object actual)
    {
      string str = "";
      if (message != null)
        str = new StringBuilder().append(message).append(" ").toString();
      Assert.fail(new StringBuilder().append(str).append("expected same:<").append(expected).append("> was not:<").append(actual).append(">").toString());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 100, (byte) 97, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertSame(string message, object expected, object actual)
    {
      if (expected == actual)
        return;
      Assert.failNotSame(message, expected, actual);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 155, (byte) 102, (byte) 99, (byte) 123, (byte) 127, (byte) 2})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void failSame(string message)
    {
      string str = "";
      if (message != null)
        str = new StringBuilder().append(message).append(" ").toString();
      Assert.fail(new StringBuilder().append(str).append("expected not same").toString());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 143, (byte) 100, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertNotSame(string message, object expected, object actual)
    {
      if (expected != actual)
        return;
      Assert.failSame(message);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 173, (byte) 102, (byte) 99, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string format(string message, object expected, object actual)
    {
      string str = "";
      if (message != null)
        str = new StringBuilder().append(message).append(" ").toString();
      return new StringBuilder().append(str).append("expected:<").append(expected).append("> but was:<").append(actual).append(">").toString();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 136, (byte) 162, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertTrue(bool condition)
    {
      Assert.assertTrue((string) null, condition);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 132, (byte) 98, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertFalse(bool condition)
    {
      Assert.assertFalse((string) null, condition);
    }

    [LineNumberTable(new byte[] {(byte) 3, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void fail()
    {
      Assert.fail((string) null);
    }

    [LineNumberTable(new byte[] {(byte) 21, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(object expected, object actual)
    {
      Assert.assertEquals((string) null, expected, actual);
    }

    [LineNumberTable(new byte[] {(byte) 37, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(string expected, string actual)
    {
      Assert.assertEquals((string) null, expected, actual);
    }

    [LineNumberTable(new byte[] {(byte) 55, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(double expected, double actual, double delta)
    {
      Assert.assertEquals((string) null, expected, actual, delta);
    }

    [LineNumberTable(new byte[] {(byte) 73, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(float expected, float actual, float delta)
    {
      Assert.assertEquals((string) null, expected, actual, delta);
    }

    [LineNumberTable(new byte[] {(byte) 86, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(long expected, long actual)
    {
      Assert.assertEquals((string) null, expected, actual);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 105, (byte) 100, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(bool expected, bool actual)
    {
      Assert.assertEquals((string) null, expected, actual);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 102, (byte) 134, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(byte expected, byte actual)
    {
      Assert.assertEquals((string) null, expected, actual);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 99, (byte) 164, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(char expected, char actual)
    {
      Assert.assertEquals((string) null, expected, actual);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 95, (byte) 68, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(short expected, short actual)
    {
      Assert.assertEquals((string) null, expected, actual);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 87, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertEquals(int expected, int actual)
    {
      Assert.assertEquals((string) null, expected, actual);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 93, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertNotNull(object @object)
    {
      Assert.assertNotNull((string) null, @object);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 111, (byte) 127, (byte) 1, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertNull(object @object)
    {
      Assert.assertNull(new StringBuilder().append("Expected: <null> but was: ").append(String.valueOf(@object)).toString(), @object);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 135, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertSame(object expected, object actual)
    {
      Assert.assertSame((string) null, expected, actual);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 151, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void assertNotSame(object expected, object actual)
    {
      Assert.assertNotSame((string) null, expected, actual);
    }
  }
}
