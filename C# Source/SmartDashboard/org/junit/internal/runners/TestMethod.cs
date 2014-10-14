// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.TestMethod
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using java.util;
using org.junit;
using org.junit.@internal.runners;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal.runners
{
  [Obsolete]
  [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
  public class TestMethod : Object
  {
    [Modifiers]
    private Method fMethod;
    private TestClass fTestClass;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 166, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestMethod(Method method, TestClass testClass)
    {
      base.\u002Ector();
      TestMethod testMethod = this;
      this.fMethod = method;
      this.fTestClass = testClass;
    }

    [LineNumberTable((ushort) 30)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isIgnored()
    {
      return this.fMethod.getAnnotation((Class) ClassLiteral<Ignore>.Value) != null;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 118, (byte) 99, (byte) 99, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual long getTimeout()
    {
      Test test = (Test) this.fMethod.getAnnotation((Class) ClassLiteral<Test>.Value);
      if (test == null)
        return 0L;
      else
        return test.timeout();
    }

    [Throws(new string[] {"java.lang.IllegalArgumentException", "java.lang.IllegalAccessException", "java.lang.reflect.InvocationTargetException"})]
    [LineNumberTable(new byte[] {(byte) 16, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void invoke(object test)
    {
      this.fMethod.invoke(test, new object[0], TestMethod.__\u003CGetCallerID\u003E());
    }

    [LineNumberTable((ushort) 54)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual bool expectsException()
    {
      return this.getExpectedException() != null;
    }

    [Signature("()Ljava/lang/Class<+Ljava/lang/Throwable;>;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 184, (byte) 118, (byte) 112, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Class getExpectedException()
    {
      Test test = (Test) this.fMethod.getAnnotation((Class) ClassLiteral<Test>.Value);
      if (test == null || test.expected() == ClassLiteral<Test.None>.Value)
        return (Class) null;
      return test.expected();
    }

    [LineNumberTable((ushort) 50)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual bool isUnexpected([In] Exception obj0)
    {
      return !this.getExpectedException().isAssignableFrom(Object.instancehelper_getClass((object) obj0));
    }

    [Signature("()Ljava/util/List<Ljava/lang/reflect/Method;>;")]
    [LineNumberTable((ushort) 58)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual List getBefores()
    {
      return this.fTestClass.getAnnotatedMethods((Class) ClassLiteral<Before>.Value);
    }

    [Signature("()Ljava/util/List<Ljava/lang/reflect/Method;>;")]
    [LineNumberTable((ushort) 62)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual List getAfters()
    {
      return this.fTestClass.getAnnotatedMethods((Class) ClassLiteral<After>.Value);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (TestMethod.__\u003CcallerID\u003E == null)
        TestMethod.__\u003CcallerID\u003E = (CallerID) new TestMethod.__\u003CCallerID\u003E();
      return TestMethod.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
