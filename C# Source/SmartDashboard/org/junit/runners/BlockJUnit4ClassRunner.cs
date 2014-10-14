// Decompiled with JetBrains decompiler
// Type: org.junit.runners.BlockJUnit4ClassRunner
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util;
using org.junit;
using org.junit.@internal;
using org.junit.@internal.runners.model;
using org.junit.@internal.runners.statements;
using org.junit.rules;
using org.junit.runner;
using org.junit.runner.notification;
using org.junit.runners.model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runners
{
  [Signature("Lorg/junit/runners/ParentRunner<Lorg/junit/runners/model/FrameworkMethod;>;")]
  public class BlockJUnit4ClassRunner : ParentRunner
  {
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 8, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BlockJUnit4ClassRunner(Class klass)
      : base(klass)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 246, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private EachTestNotifier makeNotifier([In] FrameworkMethod obj0, [In] RunNotifier obj1)
    {
      Description description = this.describeChild(obj0);
      return new EachTestNotifier(obj1, description);
    }

    [LineNumberTable(new byte[] {(byte) 40, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void runIgnored([In] EachTestNotifier obj0)
    {
      obj0.fireTestIgnored();
    }

    [LineNumberTable(new byte[] {(byte) 27, (byte) 134, (byte) 255, (byte) 3, (byte) 70, (byte) 79, (byte) 102, (byte) 228, (byte) 58, (byte) 97, (byte) 203, (byte) 73, (byte) 102, (byte) 230, (byte) 60, (byte) 98, (byte) 140, (byte) 73, (byte) 98, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void runNotIgnored([In] FrameworkMethod obj0, [In] EachTestNotifier obj1)
    {
      obj1.fireTestStarted();
      AssumptionViolatedException violatedException1;
      Exception exception1;
      // ISSUE: fault handler
      try
      {
        try
        {
          this.methodBlock(obj0).evaluate();
          goto label_7;
        }
        catch (AssumptionViolatedException ex)
        {
          int num = 1;
          violatedException1 = (AssumptionViolatedException) ByteCodeHelper.MapException<AssumptionViolatedException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
      }
      catch (Exception ex)
      {
        int num = 0;
        exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        goto label_6;
      }
      __fault
      {
        obj1.fireTestFinished();
      }
      AssumptionViolatedException violatedException2 = violatedException1;
      // ISSUE: fault handler
      try
      {
        AssumptionViolatedException e = violatedException2;
        obj1.addFailedAssumption(e);
      }
      __fault
      {
        obj1.fireTestFinished();
      }
      obj1.fireTestFinished();
      return;
label_6:
      Exception exception2 = exception1;
      try
      {
        Exception targetException = exception2;
        obj1.addFailure(targetException);
        return;
      }
      finally
      {
        obj1.fireTestFinished();
      }
label_7:
      obj1.fireTestFinished();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 141, (byte) 254, (byte) 72, (byte) 2, (byte) 97, (byte) 167, (byte) 105, (byte) 106, (byte) 106, (byte) 106, (byte) 106, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Statement methodBlock(FrameworkMethod method)
    {
      object obj;
      Exception e;
      try
      {
        obj = new BlockJUnit4ClassRunner\u00241(this).run();
        goto label_3;
      }
      catch (Exception ex)
      {
        int num = 0;
        e = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
      }
      return (Statement) new Fail(e);
label_3:
      Statement next1 = this.methodInvoker(method, obj);
      Statement next2 = this.possiblyExpectingExceptions(method, obj, next1);
      Statement statement1 = this.withPotentialTimeout(method, obj, next2);
      Statement statement2 = this.withBefores(method, obj, statement1);
      Statement statement3 = this.withAfters(method, obj, statement2);
      return this.withRules(method, obj, statement3);
    }

    [LineNumberTable((ushort) 217)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string testName(FrameworkMethod method)
    {
      return method.getName();
    }

    [Signature("()Ljava/util/List<Lorg/junit/runners/model/FrameworkMethod;>;")]
    [LineNumberTable((ushort) 114)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual List computeTestMethods()
    {
      return this.getTestClass().getAnnotatedMethods((Class) ClassLiteral<Test>.Value);
    }

    [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 82, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void validateConstructor(List errors)
    {
      this.validateOnlyOneConstructor(errors);
      this.validateZeroArgConstructor(errors);
    }

    [Obsolete]
    [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 122, (byte) 109, (byte) 109, (byte) 135, (byte) 109, (byte) 113})]
    [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void validateInstanceMethods(List errors)
    {
      this.validatePublicVoidNoArgMethods((Class) ClassLiteral<After>.Value, false, errors);
      this.validatePublicVoidNoArgMethods((Class) ClassLiteral<Before>.Value, false, errors);
      this.validateTestMethods(errors);
      if (this.computeTestMethods().size() != 0)
        return;
      errors.add((object) new Exception("No runnable methods"));
    }

    [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 68, (byte) 127, (byte) 11, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void validateFields([In] List obj0)
    {
      Iterator iterator = this.getTestClass().getAnnotatedFields((Class) ClassLiteral<Rule>.Value).iterator();
      while (iterator.hasNext())
        this.validateRuleField(((FrameworkField) iterator.next()).getField(), obj0);
    }

    [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 91, (byte) 104, (byte) 102, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void validateOnlyOneConstructor(List errors)
    {
      if (this.hasOneConstructor())
        return;
      string str = "Test class should have exactly one public constructor";
      errors.add((object) new Exception(str));
    }

    [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 102, (byte) 155, (byte) 102, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void validateZeroArgConstructor(List errors)
    {
      if (!this.hasOneConstructor() || this.getTestClass().getOnlyConstructor().getParameterTypes().Length == 0)
        return;
      string str = "Test class should have exactly one public zero-argument constructor";
      errors.add((object) new Exception(str));
    }

    [LineNumberTable((ushort) 160)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool hasOneConstructor()
    {
      return this.getTestClass().getJavaClass().getConstructors(BlockJUnit4ClassRunner.__\u003CGetCallerID\u003E()).Length == 1;
    }

    [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 86, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void validateTestMethods(List errors)
    {
      this.validatePublicVoidNoArgMethods((Class) ClassLiteral<Test>.Value, false, errors);
    }

    [Signature("(Ljava/lang/reflect/Field;Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 73, (byte) 114, (byte) 159, (byte) 22, (byte) 109, (byte) 159, (byte) 22})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void validateRuleField([In] Field obj0, [In] List obj1)
    {
      if (!((Class) ClassLiteral<MethodRule>.Value).isAssignableFrom(obj0.getType()))
        obj1.add((object) new Exception(new StringBuilder().append("Field ").append(obj0.getName()).append(" must implement MethodRule").toString()));
      if (Modifier.isPublic(obj0.getModifiers()))
        return;
      obj1.add((object) new Exception(new StringBuilder().append("Field ").append(obj0.getName()).append(" must be public").toString()));
    }

    [LineNumberTable((ushort) 282)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Statement methodInvoker(FrameworkMethod method, object test)
    {
      return (Statement) new InvokeMethod(method, test);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 182, (byte) 113})]
    [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Statement possiblyExpectingExceptions(FrameworkMethod method, object test, Statement next)
    {
      Test test1 = (Test) method.getAnnotation((Class) ClassLiteral<Test>.Value);
      if (this.expectsException(test1))
        return (Statement) new ExpectException(next, this.getExpectedException(test1));
      else
        return next;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 197, (byte) 119})]
    [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Statement withPotentialTimeout(FrameworkMethod method, object test, Statement next)
    {
      long timeout = this.getTimeout((Test) method.getAnnotation((Class) ClassLiteral<Test>.Value));
      if (timeout > 0L)
        return (Statement) new FailOnTimeout(next, timeout);
      else
        return next;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 211, (byte) 145})]
    [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Statement withBefores(FrameworkMethod method, object target, Statement statement)
    {
      List annotatedMethods = this.getTestClass().getAnnotatedMethods((Class) ClassLiteral<Before>.Value);
      return !annotatedMethods.isEmpty() ? (Statement) new RunBefores(statement, annotatedMethods, target) : statement;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 229, (byte) 145})]
    [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Statement withAfters(FrameworkMethod method, object target, Statement statement)
    {
      List annotatedMethods = this.getTestClass().getAnnotatedMethods((Class) ClassLiteral<After>.Value);
      return !annotatedMethods.isEmpty() ? (Statement) new RunAfters(statement, annotatedMethods, target) : statement;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 237, (byte) 98, (byte) 159, (byte) 17, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Statement withRules([In] FrameworkMethod obj0, [In] object obj1, [In] Statement obj2)
    {
      Statement s = obj2;
      Iterator iterator = this.getTestClass().getAnnotatedFieldValues(obj1, (Class) ClassLiteral<Rule>.Value, (Class) ClassLiteral<MethodRule>.Value).iterator();
      while (iterator.hasNext())
        s = ((MethodRule) iterator.next()).apply(s, obj0, obj1);
      return s;
    }

    [LineNumberTable((ushort) 372)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool expectsException([In] Test obj0)
    {
      return this.getExpectedException(obj0) != null;
    }

    [Signature("(Lorg/junit/Test;)Ljava/lang/Class<+Ljava/lang/Throwable;>;")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 251, (byte) 112, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Class getExpectedException([In] Test obj0)
    {
      if (obj0 == null || obj0.expected() == ClassLiteral<Test.None>.Value)
        return (Class) null;
      return obj0.expected();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 6, (byte) 99, (byte) 99})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private long getTimeout([In] Test obj0)
    {
      if (obj0 == null)
        return 0L;
      return obj0.timeout();
    }

    [LineNumberTable((ushort) 95)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Description describeChild(FrameworkMethod method)
    {
      return Description.createTestDescription(this.getTestClass().getJavaClass(), this.testName(method), method.getAnnotations());
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 105, (byte) 109, (byte) 137, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void runChild(FrameworkMethod method, RunNotifier notifier)
    {
      EachTestNotifier eachTestNotifier = this.makeNotifier(method, notifier);
      if (method.getAnnotation((Class) ClassLiteral<Ignore>.Value) != null)
        this.runIgnored(eachTestNotifier);
      else
        this.runNotIgnored(method, eachTestNotifier);
    }

    [Signature("()Ljava/util/List<Lorg/junit/runners/model/FrameworkMethod;>;")]
    [LineNumberTable((ushort) 101)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override List getChildren()
    {
      return this.computeTestMethods();
    }

    [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 69, (byte) 135, (byte) 103, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void collectInitializationErrors(List errors)
    {
      base.collectInitializationErrors(errors);
      this.validateConstructor(errors);
      this.validateInstanceMethods(errors);
      this.validateFields(errors);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable((ushort) 209)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual object createTest()
    {
      return this.getTestClass().getOnlyConstructor().newInstance(new object[0], BlockJUnit4ClassRunner.__\u003CGetCallerID\u003E());
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 49)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void runChild(object x0, RunNotifier x1)
    {
      this.runChild((FrameworkMethod) x0, x1);
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 49)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override Description describeChild(object x0)
    {
      return this.describeChild((FrameworkMethod) x0);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (BlockJUnit4ClassRunner.__\u003CcallerID\u003E == null)
        BlockJUnit4ClassRunner.__\u003CcallerID\u003E = (CallerID) new BlockJUnit4ClassRunner.__\u003CCallerID\u003E();
      return BlockJUnit4ClassRunner.__\u003CcallerID\u003E;
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
