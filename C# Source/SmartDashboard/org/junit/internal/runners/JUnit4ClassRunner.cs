// Decompiled with JetBrains decompiler
// Type: org.junit.internal.runners.JUnit4ClassRunner
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.annotation;
using java.lang.reflect;
using java.util;
using org.junit.@internal.runners;
using org.junit.runner;
using org.junit.runner.manipulation;
using org.junit.runner.notification;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.@internal.runners
{
  [Implements(new string[] {"org.junit.runner.manipulation.Filterable", "org.junit.runner.manipulation.Sortable"})]
  [Obsolete]
  [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
  public class JUnit4ClassRunner : Runner, Filterable, Sortable
  {
    [Modifiers]
    [Signature("Ljava/util/List<Ljava/lang/reflect/Method;>;")]
    private List fTestMethods;
    private TestClass fTestClass;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Throws(new string[] {"org.junit.internal.runners.InitializationError"})]
    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 104, (byte) 108, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JUnit4ClassRunner(Class klass)
    {
      JUnit4ClassRunner junit4ClassRunner = this;
      this.fTestClass = new TestClass(klass);
      this.fTestMethods = this.getTestMethods();
      this.validate();
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 127, (byte) 1, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void runMethods(RunNotifier notifier)
    {
      Iterator iterator = this.fTestMethods.iterator();
      while (iterator.hasNext())
        this.invokeTestMethod((Method) iterator.next(), notifier);
    }

    [LineNumberTable((ushort) 117)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Description methodDescription(Method method)
    {
      return Description.createTestDescription(this.getTestClass().getJavaClass(), this.testName(method), this.testAnnotations(method));
    }

    [Signature("()Ljava/util/List<Ljava/lang/reflect/Method;>;")]
    [LineNumberTable((ushort) 41)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual List getTestMethods()
    {
      return this.fTestClass.getTestMethods();
    }

    [Throws(new string[] {"org.junit.internal.runners.InitializationError"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 187, (byte) 108, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void validate()
    {
      MethodValidator methodValidator = new MethodValidator(this.fTestClass);
      methodValidator.validateMethodsForDefaultRunner();
      methodValidator.assertValid();
    }

    [LineNumberTable(new byte[] {(byte) 16, (byte) 114, (byte) 103, (byte) 123, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Description getDescription()
    {
      Description suiteDescription = Description.createSuiteDescription(this.getName(), this.classAnnotations());
      Iterator iterator = this.fTestMethods.iterator();
      while (iterator.hasNext())
      {
        Method method = (Method) iterator.next();
        suiteDescription.addChild(this.methodDescription(method));
      }
      return suiteDescription;
    }

    [LineNumberTable(new byte[] {(byte) 36, (byte) 168, (byte) 255, (byte) 11, (byte) 71, (byte) 226, (byte) 58, (byte) 98, (byte) 111, (byte) 97, (byte) 98, (byte) 106, (byte) 129, (byte) 105, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void invokeTestMethod(Method method, RunNotifier notifier)
    {
      Description description = this.methodDescription(method);
      object test;
      InvocationTargetException invocationTargetException1;
      Exception exception1;
      try
      {
        try
        {
          test = this.createTest();
          goto label_8;
        }
        catch (InvocationTargetException ex)
        {
          int num = 1;
          invocationTargetException1 = (InvocationTargetException) ByteCodeHelper.MapException<InvocationTargetException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
        {
          throw;
        }
        else
        {
          exception1 = (Exception) m0;
          goto label_7;
        }
      }
      InvocationTargetException invocationTargetException2 = invocationTargetException1;
      this.testAborted(notifier, description, invocationTargetException2.getCause());
      return;
label_7:
      Exception exception2 = exception1;
      this.testAborted(notifier, description, (Exception) exception2);
      return;
label_8:
      TestMethod method1 = this.wrapMethod(method);
      new MethodRoadie(test, method1, notifier, description).run();
    }

    [LineNumberTable((ushort) 78)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string getName()
    {
      return this.getTestClass().getName();
    }

    [LineNumberTable((ushort) 74)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Annotation[] classAnnotations()
    {
      return this.fTestClass.getJavaClass().getAnnotations();
    }

    protected internal virtual TestClass getTestClass()
    {
      return this.fTestClass;
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable((ushort) 82)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual object createTest()
    {
      return this.getTestClass().getConstructor().newInstance(new object[0], JUnit4ClassRunner.__\u003CGetCallerID\u003E());
    }

    [LineNumberTable(new byte[] {(byte) 53, (byte) 103, (byte) 109, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void testAborted([In] RunNotifier obj0, [In] Description obj1, [In] Exception obj2)
    {
      obj0.fireTestStarted(obj1);
      obj0.fireTestFailure(new Failure(obj1, obj2));
      obj0.fireTestFinished(obj1);
    }

    [LineNumberTable((ushort) 109)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual TestMethod wrapMethod(Method method)
    {
      return new TestMethod(method, this.fTestClass);
    }

    [LineNumberTable((ushort) 113)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string testName(Method method)
    {
      return method.getName();
    }

    [LineNumberTable((ushort) 121)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Annotation[] testAnnotations(Method method)
    {
      return ((AccessibleObject) method).getAnnotations();
    }

    [LineNumberTable(new byte[] {(byte) 2, (byte) 255, (byte) 1, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void run(RunNotifier notifier)
    {
      new ClassRoadie(notifier, this.fTestClass, this.getDescription(), (Runnable) new JUnit4ClassRunner\u00241(this, notifier)).runProtected();
    }

    [Throws(new string[] {"org.junit.runner.manipulation.NoTestsRemainException"})]
    [LineNumberTable(new byte[] {(byte) 75, (byte) 116, (byte) 108, (byte) 111, (byte) 102, (byte) 98, (byte) 109, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void filter(org.junit.runner.manipulation.Filter filter)
    {
      Iterator iterator = this.fTestMethods.iterator();
      while (iterator.hasNext())
      {
        Method method = (Method) iterator.next();
        if (!filter.shouldRun(this.methodDescription(method)))
          iterator.remove();
      }
      if (!this.fTestMethods.isEmpty())
        return;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoTestsRemainException();
    }

    [LineNumberTable(new byte[] {(byte) 85, (byte) 244, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sort(Sorter sorter)
    {
      Collections.sort(this.fTestMethods, (Comparator) new JUnit4ClassRunner\u00242(this, sorter));
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (JUnit4ClassRunner.__\u003CcallerID\u003E == null)
        JUnit4ClassRunner.__\u003CcallerID\u003E = (CallerID) new JUnit4ClassRunner.__\u003CCallerID\u003E();
      return JUnit4ClassRunner.__\u003CcallerID\u003E;
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
