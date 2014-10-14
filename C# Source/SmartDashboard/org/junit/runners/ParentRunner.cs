// Decompiled with JetBrains decompiler
// Type: org.junit.runners.ParentRunner
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using org.junit;
using org.junit.@internal;
using org.junit.@internal.runners.model;
using org.junit.@internal.runners.statements;
using org.junit.runner;
using org.junit.runner.manipulation;
using org.junit.runner.notification;
using org.junit.runners.model;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runners
{
  [Implements(new string[] {"org.junit.runner.manipulation.Filterable", "org.junit.runner.manipulation.Sortable"})]
  [Signature("<T:Ljava/lang/Object;>Lorg/junit/runner/Runner;Lorg/junit/runner/manipulation/Filterable;Lorg/junit/runner/manipulation/Sortable;")]
  public abstract class ParentRunner : Runner, Filterable, Sortable
  {
    [Modifiers]
    private TestClass fTestClass;
    private org.junit.runner.manipulation.Filter fFilter;
    private Sorter fSorter;
    private RunnerScheduler fScheduler;

    [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 14, (byte) 232, (byte) 46, (byte) 135, (byte) 139, (byte) 236, (byte) 79, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal ParentRunner(Class testClass)
    {
      ParentRunner parentRunner = this;
      this.fFilter = (org.junit.runner.manipulation.Filter) null;
      this.fSorter = Sorter.NULL;
      this.fScheduler = (RunnerScheduler) new ParentRunner\u00241(this);
      this.fTestClass = new TestClass(testClass);
      this.validate();
    }

    public virtual void setScheduler(RunnerScheduler scheduler)
    {
      this.fScheduler = scheduler;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 76, (byte) 123, (byte) 245, (byte) 69, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void runChildren([In] RunNotifier obj0)
    {
      Iterator iterator = this.getFilteredChildren().iterator();
      while (iterator.hasNext())
        this.fScheduler.schedule((Runnable) new ParentRunner\u00243(this, iterator.next(), obj0));
      this.fScheduler.finished();
    }

    [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 154, (byte) 102, (byte) 103, (byte) 104, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void validate()
    {
      ArrayList arrayList1 = new ArrayList();
      this.collectInitializationErrors((List) arrayList1);
      if (((List) arrayList1).isEmpty())
        return;
      ArrayList arrayList2 = arrayList1;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new InitializationError((List) arrayList2);
    }

    [Signature("(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;ZLjava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 113, (byte) 162, (byte) 141, (byte) 123, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void validatePublicVoidNoArgMethods(Class annotation, bool isStatic, List errors)
    {
      int num = isStatic ? 1 : 0;
      Iterator iterator = this.getTestClass().getAnnotatedMethods(annotation).iterator();
      while (iterator.hasNext())
        ((FrameworkMethod) iterator.next()).validatePublicVoidNoArg(num != 0, errors);
    }

    public TestClass getTestClass()
    {
      return this.fTestClass;
    }

    [LineNumberTable((ushort) 181)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Statement childrenInvoker(RunNotifier notifier)
    {
      return (Statement) new ParentRunner\u00242(this, notifier);
    }

    [LineNumberTable(new byte[] {(byte) 105, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Statement withBeforeClasses(Statement statement)
    {
      List annotatedMethods = this.fTestClass.getAnnotatedMethods((Class) ClassLiteral<BeforeClass>.Value);
      return !annotatedMethods.isEmpty() ? (Statement) new RunBefores(statement, annotatedMethods, (object) null) : statement;
    }

    [LineNumberTable(new byte[] {(byte) 119, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Statement withAfterClasses(Statement statement)
    {
      List annotatedMethods = this.fTestClass.getAnnotatedMethods((Class) ClassLiteral<AfterClass>.Value);
      return !annotatedMethods.isEmpty() ? (Statement) new RunAfters(statement, annotatedMethods, (object) null) : statement;
    }

    [Signature("()Ljava/util/List<TT;>;")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 161, (byte) 102, (byte) 123, (byte) 137, (byte) 103, (byte) 103, (byte) 179, (byte) 2, (byte) 129, (byte) 98, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private List getFilteredChildren()
    {
      ArrayList arrayList = new ArrayList();
      Iterator iterator = this.getChildren().iterator();
      while (iterator.hasNext())
      {
        object obj = iterator.next();
        if (this.shouldRun(obj))
        {
          try
          {
            this.filterChild(obj);
            this.sortChild(obj);
            arrayList.add(obj);
          }
          catch (NoTestsRemainException ex)
          {
          }
        }
      }
      Collections.sort((List) arrayList, this.comparator());
      return (List) arrayList;
    }

    [LineNumberTable((ushort) 203)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string getName()
    {
      return this.fTestClass.getName();
    }

    [Signature("(TT;)Lorg/junit/runner/Description;")]
    protected internal abstract Description describeChild(object obj);

    [LineNumberTable(new byte[] {(byte) 160, (byte) 109, (byte) 151, (byte) 123, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Description getDescription()
    {
      Description suiteDescription = Description.createSuiteDescription(this.getName(), this.fTestClass.getAnnotations());
      Iterator iterator = this.getFilteredChildren().iterator();
      while (iterator.hasNext())
      {
        object obj = iterator.next();
        suiteDescription.addChild(this.describeChild(obj));
      }
      return suiteDescription;
    }

    [LineNumberTable(new byte[] {(byte) 93, (byte) 104, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Statement classBlock(RunNotifier notifier)
    {
      return this.withAfterClasses(this.withBeforeClasses(this.childrenInvoker(notifier)));
    }

    [Signature("()Ljava/util/List<TT;>;")]
    protected internal abstract List getChildren();

    [Signature("(TT;)Z")]
    [LineNumberTable((ushort) 299)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool shouldRun([In] object obj0)
    {
      return this.fFilter == null || this.fFilter.shouldRun(this.describeChild(obj0));
    }

    [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 53, (byte) 109, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void collectInitializationErrors(List errors)
    {
      this.validatePublicVoidNoArgMethods((Class) ClassLiteral<BeforeClass>.Value, true, errors);
      this.validatePublicVoidNoArgMethods((Class) ClassLiteral<AfterClass>.Value, true, errors);
    }

    [Throws(new string[] {"org.junit.runner.manipulation.NoTestsRemainException"})]
    [Signature("(TT;)V")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 180, (byte) 104, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void filterChild([In] object obj0)
    {
      if (this.fFilter == null)
        return;
      this.fFilter.apply(obj0);
    }

    [Signature("(TT;)V")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 176, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void sortChild([In] object obj0)
    {
      this.fSorter.apply(obj0);
    }

    [Signature("()Ljava/util/Comparator<-TT;>;")]
    [LineNumberTable((ushort) 303)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Comparator comparator()
    {
      return (Comparator) new ParentRunner\u00244(this);
    }

    [Signature("(TT;Lorg/junit/runner/notification/RunNotifier;)V")]
    protected internal abstract void runChild(object obj, RunNotifier rn);

    [LineNumberTable(new byte[] {(byte) 160, (byte) 118, (byte) 173, (byte) 104, (byte) 255, (byte) 10, (byte) 71, (byte) 226, (byte) 58, (byte) 97, (byte) 230, (byte) 69, (byte) 226, (byte) 60, (byte) 98, (byte) 104, (byte) 98, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void run(RunNotifier notifier)
    {
      EachTestNotifier eachTestNotifier = new EachTestNotifier(notifier, this.getDescription());
      StoppedByUserException stoppedByUserException;
      Exception exception;
      try
      {
        try
        {
          try
          {
            this.classBlock(notifier).evaluate();
            return;
          }
          catch (AssumptionViolatedException ex)
          {
          }
        }
        catch (StoppedByUserException ex)
        {
          int num = 1;
          stoppedByUserException = (StoppedByUserException) ByteCodeHelper.MapException<StoppedByUserException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
          goto label_6;
        }
      }
      catch (Exception ex)
      {
        int num = 0;
        exception = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        goto label_7;
      }
      eachTestNotifier.fireTestIgnored();
      return;
label_6:
      throw Throwable.__\u003Cunmap\u003E((Exception) stoppedByUserException);
label_7:
      Exception targetException = exception;
      eachTestNotifier.addFailure(targetException);
    }

    [Throws(new string[] {"org.junit.runner.manipulation.NoTestsRemainException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 135, (byte) 123, (byte) 105, (byte) 99})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void filter(org.junit.runner.manipulation.Filter filter)
    {
      this.fFilter = filter;
      Iterator iterator = this.getChildren().iterator();
      while (iterator.hasNext())
      {
        if (this.shouldRun(iterator.next()))
          return;
      }
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoTestsRemainException();
    }

    public virtual void sort(Sorter sorter)
    {
      this.fSorter = sorter;
    }

    [Modifiers]
    [LineNumberTable((ushort) 42)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void access\u0024000([In] ParentRunner obj0, [In] RunNotifier obj1)
    {
      obj0.runChildren(obj1);
    }

    [Modifiers]
    [LineNumberTable((ushort) 42)]
    internal static Sorter access\u0024100([In] ParentRunner obj0)
    {
      return obj0.fSorter;
    }
  }
}
