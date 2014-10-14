// Decompiled with JetBrains decompiler
// Type: junit.framework.TestCase
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using System;
using System.Runtime.CompilerServices;

namespace junit.framework
{
  [Implements(new string[] {"junit.framework.Test"})]
  public abstract class TestCase : Assert, Test
  {
    private string fName;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 36, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestCase()
    {
      TestCase testCase = this;
      this.fName = (string) null;
    }

    [LineNumberTable(new byte[] {(byte) 42, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestCase(string name)
    {
      TestCase testCase = this;
      this.fName = name;
    }

    public virtual void setName(string name)
    {
      this.fName = name;
    }

    [LineNumberTable((ushort) 107)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual TestResult createResult()
    {
      return new TestResult();
    }

    [LineNumberTable(new byte[] {(byte) 74, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run(TestResult result)
    {
      result.run(this);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    protected internal virtual void setUp()
    {
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable(new byte[] {(byte) 102, (byte) 112, (byte) 226, (byte) 70, (byte) 191, (byte) 9, (byte) 2, (byte) 97, (byte) 159, (byte) 15, (byte) 109, (byte) 223, (byte) 15, (byte) 255, (byte) 18, (byte) 73, (byte) 226, (byte) 57, (byte) 97, (byte) 103, (byte) 140, (byte) 98, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void runTest()
    {
      Assert.assertNotNull("TestCase.fName cannot be null", (object) this.fName);
      Method method = (Method) null;
      try
      {
        method = Object.instancehelper_getClass((object) this).getMethod(this.fName, (Class[]) null, TestCase.__\u003CGetCallerID\u003E());
        goto label_4;
      }
      catch (NoSuchMethodException ex)
      {
      }
      Assert.fail(new StringBuilder().append("Method \"").append(this.fName).append("\" not found").toString());
label_4:
      if (!Modifier.isPublic(method.getModifiers()))
        Assert.fail(new StringBuilder().append("Method \"").append(this.fName).append("\" should be public").toString());
      InvocationTargetException invocationTargetException1;
      IllegalAccessException illegalAccessException1;
      try
      {
        try
        {
          method.invoke((object) this, new object[0], TestCase.__\u003CGetCallerID\u003E());
          return;
        }
        catch (InvocationTargetException ex)
        {
          int num = 1;
          invocationTargetException1 = (InvocationTargetException) ByteCodeHelper.MapException<InvocationTargetException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
      }
      catch (IllegalAccessException ex)
      {
        int num = 1;
        illegalAccessException1 = (IllegalAccessException) ByteCodeHelper.MapException<IllegalAccessException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_10;
      }
      InvocationTargetException invocationTargetException2 = invocationTargetException1;
      Throwable.instancehelper_fillInStackTrace((Exception) invocationTargetException2);
      throw Throwable.__\u003Cunmap\u003E(invocationTargetException2.getTargetException());
label_10:
      IllegalAccessException illegalAccessException2 = illegalAccessException1;
      Throwable.instancehelper_fillInStackTrace((Exception) illegalAccessException2);
      throw Throwable.__\u003Cunmap\u003E((Exception) illegalAccessException2);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    protected internal virtual void tearDown()
    {
    }

    public virtual string getName()
    {
      return this.fName;
    }

    public virtual int countTestCases()
    {
      return 1;
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TestResult run()
    {
      TestResult result = this.createResult();
      this.run(result);
      return result;
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable(new byte[] {(byte) 81, (byte) 98, (byte) 134, (byte) 243, (byte) 70, (byte) 184, (byte) 2, (byte) 97, (byte) 101, (byte) 230, (byte) 61, (byte) 186, (byte) 2, (byte) 98, (byte) 134, (byte) 226, (byte) 55, (byte) 98, (byte) 195, (byte) 186, (byte) 2, (byte) 98, (byte) 134, (byte) 98, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void runBare()
    {
      Exception exception1 = (Exception) null;
      this.setUp();
      Exception exception2;
      // ISSUE: fault handler
      try
      {
        this.runTest();
        goto label_9;
      }
      catch (Exception ex)
      {
        int num = 0;
        exception2 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
      }
      __fault
      {
        try
        {
          this.tearDown();
          goto label_7;
        }
        catch (Exception exception_3)
        {
          int temp_23 = 0;
          Exception local_2 = (Exception) ByteCodeHelper.MapException<Exception>(exception_3, (ByteCodeHelper.MapFlags) temp_23);
        }
        if (exception1 == null)
          ;
label_7:;
      }
      exception1 = exception2;
      Exception exception3;
      try
      {
        this.tearDown();
        goto label_18;
      }
      catch (Exception ex)
      {
        int num = 0;
        exception3 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
      }
      Exception exception4 = exception3;
      if (exception1 == null)
      {
        exception1 = exception4;
        goto label_18;
      }
      else
        goto label_18;
label_9:
      Exception exception5;
      try
      {
        this.tearDown();
        goto label_18;
      }
      catch (Exception ex)
      {
        int num = 0;
        exception5 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
      }
      Exception exception6 = exception5;
      if (null == null)
        exception1 = exception6;
label_18:
      if (exception1 != null)
        throw Throwable.__\u003Cunmap\u003E(exception1);
    }

    [LineNumberTable((ushort) 196)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuilder().append(this.getName()).append("(").append(Object.instancehelper_getClass((object) this).getName()).append(")").toString();
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (TestCase.__\u003CcallerID\u003E == null)
        TestCase.__\u003CcallerID\u003E = (CallerID) new TestCase.__\u003CCallerID\u003E();
      return TestCase.__\u003CcallerID\u003E;
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
