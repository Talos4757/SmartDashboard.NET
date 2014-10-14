// Decompiled with JetBrains decompiler
// Type: org.junit.runner.JUnitCore
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.annotation;
using java.util;
using junit.framework;
using org.junit.@internal;
using org.junit.@internal.runners;
using org.junit.runner.notification;
using System;
using System.Runtime.CompilerServices;

namespace org.junit.runner
{
  public class JUnitCore : Object
  {
    private RunNotifier fNotifier;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JUnitCore()
    {
      base.\u002Ector();
      JUnitCore junitCore = this;
      this.fNotifier = new RunNotifier();
    }

    [LineNumberTable((ushort) 183)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Computer defaultComputer()
    {
      return new Computer();
    }

    [LineNumberTable(new byte[] {(byte) 121, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addListener(RunListener listener)
    {
      this.fNotifier.addListener(listener);
    }

    [LineNumberTable(new byte[] {(byte) 102, (byte) 102, (byte) 103, (byte) 140, (byte) 113, (byte) 108, (byte) 144, (byte) 74, (byte) 98, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Result run(Runner runner)
    {
      Result result = new Result();
      RunListener listener = result.createListener();
      this.fNotifier.addFirstListener(listener);
      try
      {
        this.fNotifier.fireTestRunStarted(runner.getDescription());
        runner.run(this.fNotifier);
        this.fNotifier.fireTestRunFinished(result);
      }
      finally
      {
        this.removeListener(listener);
      }
      return result;
    }

    [Signature("([Ljava/lang/Class<*>;)Lorg/junit/runner/Result;")]
    [LineNumberTable((ushort) 76)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Result runClasses(params Class[] classes)
    {
      return new JUnitCore().run(JUnitCore.defaultComputer(), classes);
    }

    [LineNumberTable(new byte[] {(byte) 3, (byte) 109, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void runMainAndExit(JUnitSystem system, params string[] args)
    {
      Result result = new JUnitCore().runMain(system, args);
      system.exit(!result.wasSuccessful() ? 1 : 0);
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 127, (byte) 10, (byte) 102, (byte) 102, (byte) 150, (byte) 255, (byte) 8, (byte) 70, (byte) 226, (byte) 59, (byte) 98, (byte) 127, (byte) 7, (byte) 111, (byte) 107, (byte) 233, (byte) 57, (byte) 235, (byte) 73, (byte) 104, (byte) 104, (byte) 121, (byte) 127, (byte) 0, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Result runMain(JUnitSystem system, params string[] args)
    {
      system.@out().println(new StringBuilder().append("JUnit version ").append(junit.runner.Version.id()).toString());
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      string[] strArray = args;
      int length = strArray.Length;
      for (int index = 0; index < length; ++index)
      {
        string name = strArray[index];
        ClassNotFoundException notFoundException1;
        try
        {
          ((List) arrayList1).add((object) Class.forName(name, JUnitCore.__\u003CGetCallerID\u003E()));
          continue;
        }
        catch (ClassNotFoundException ex)
        {
          int num = 1;
          notFoundException1 = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
        ClassNotFoundException notFoundException2 = notFoundException1;
        system.@out().println(new StringBuilder().append("Could not find class: ").append(name).toString());
        Failure failure = new Failure(Description.createSuiteDescription(name, new Annotation[0]), (Exception) notFoundException2);
        ((List) arrayList2).add((object) failure);
      }
      this.addListener((RunListener) new TextListener(system));
      Result result = this.run((Class[]) ((List) arrayList1).toArray((object[]) new Class[0]));
      Iterator iterator = ((List) arrayList2).iterator();
      while (iterator.hasNext())
      {
        Failure failure = (Failure) iterator.next();
        result.getFailures().add((object) failure);
      }
      return result;
    }

    [Signature("(Lorg/junit/runner/Computer;[Ljava/lang/Class<*>;)Lorg/junit/runner/Result;")]
    [LineNumberTable((ushort) 127)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Result run(Computer computer, params Class[] classes)
    {
      return this.run(Request.classes(computer, classes));
    }

    [Signature("([Ljava/lang/Class<*>;)Lorg/junit/runner/Result;")]
    [LineNumberTable((ushort) 117)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Result run(params Class[] classes)
    {
      return this.run(Request.classes(JUnitCore.defaultComputer(), classes));
    }

    [LineNumberTable((ushort) 136)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Result run(Request request)
    {
      return this.run(request.getRunner());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeListener(RunListener listener)
    {
      this.fNotifier.removeListener(listener);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 187, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void main(params string[] args)
    {
      JUnitCore.runMainAndExit((JUnitSystem) new RealSystem(), args);
    }

    [Signature("(Lorg/junit/runner/Computer;[Ljava/lang/Class<*>;)Lorg/junit/runner/Result;")]
    [LineNumberTable((ushort) 66)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Result runClasses(Computer computer, params Class[] classes)
    {
      return new JUnitCore().run(computer, classes);
    }

    [LineNumberTable((ushort) 108)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getVersion()
    {
      return junit.runner.Version.id();
    }

    [LineNumberTable((ushort) 145)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Result run(Test test)
    {
      return this.run((Runner) new JUnit38ClassRunner(test));
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (JUnitCore.__\u003CcallerID\u003E == null)
        JUnitCore.__\u003CcallerID\u003E = (CallerID) new JUnitCore.__\u003CCallerID\u003E();
      return JUnitCore.__\u003CcallerID\u003E;
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
