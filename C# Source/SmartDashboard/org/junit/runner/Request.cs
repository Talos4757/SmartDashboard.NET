// Decompiled with JetBrains decompiler
// Type: org.junit.runner.Request
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.junit.@internal.builders;
using org.junit.@internal.requests;
using org.junit.@internal.runners;
using org.junit.runners.model;
using System;
using System.Runtime.CompilerServices;

namespace org.junit.runner
{
  public abstract class Request : Object
  {
    [LineNumberTable((ushort) 25)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Request()
    {
      base.\u002Ector();
    }

    [Signature("(Ljava/lang/Class<*>;)Lorg/junit/runner/Request;")]
    [LineNumberTable((ushort) 56)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Request classWithoutSuiteMethod(Class clazz)
    {
      return (Request) new ClassRequest(clazz, false);
    }

    public abstract Runner getRunner();

    [Signature("(Ljava/lang/Class<*>;)Lorg/junit/runner/Request;")]
    [LineNumberTable((ushort) 46)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Request aClass(Class clazz)
    {
      return (Request) new ClassRequest(clazz);
    }

    [LineNumberTable((ushort) 132)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Request filterWith(Description desiredDescription)
    {
      return this.filterWith(org.junit.runner.manipulation.Filter.matchMethodDescription(desiredDescription));
    }

    [LineNumberTable((ushort) 101)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Request runner(Runner runner)
    {
      return (Request) new Request\u00241(runner);
    }

    [Signature("(Lorg/junit/runner/Computer;[Ljava/lang/Class<*>;)Lorg/junit/runner/Request;")]
    [LineNumberTable(new byte[] {(byte) 18, (byte) 103, (byte) 105, (byte) 117, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Request classes(Computer computer, params Class[] classes)
    {
      Request request;
      try
      {
        AllDefaultPossibilitiesBuilder possibilitiesBuilder = new AllDefaultPossibilitiesBuilder(true);
        request = Request.runner(computer.getSuite((RunnerBuilder) possibilitiesBuilder, classes));
      }
      catch (InitializationError ex)
      {
        goto label_3;
      }
      return request;
label_3:
      string str = "Bug in saff's brain: Suite constructor, called as above, should always complete";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new RuntimeException(str);
    }

    [LineNumberTable((ushort) 122)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Request filterWith(org.junit.runner.manipulation.Filter filter)
    {
      return (Request) new FilterRequest(this, filter);
    }

    [Signature("(Ljava/lang/Class<*>;Ljava/lang/String;)Lorg/junit/runner/Request;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Request method(Class clazz, string methodName)
    {
      Description testDescription = Description.createTestDescription(clazz, methodName);
      return Request.aClass(clazz).filterWith(testDescription);
    }

    [Signature("([Ljava/lang/Class<*>;)Lorg/junit/runner/Request;")]
    [LineNumberTable((ushort) 84)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Request classes(params Class[] classes)
    {
      return Request.classes(JUnitCore.defaultComputer(), classes);
    }

    [Obsolete]
    [Signature("(Ljava/lang/Class<*>;Ljava/lang/Throwable;)Lorg/junit/runner/Request;")]
    [LineNumberTable((ushort) 93)]
    [Deprecated(new object[] {(byte) 64, "Ljava/lang/Deprecated;"})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Request errorReport(Class klass, Exception cause)
    {
      return Request.runner((Runner) new ErrorReportingRunner(klass, cause));
    }

    [Signature("(Ljava/util/Comparator<Lorg/junit/runner/Description;>;)Lorg/junit/runner/Request;")]
    [LineNumberTable((ushort) 159)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Request sortWith(Comparator comparator)
    {
      return (Request) new SortingRequest(this, comparator);
    }
  }
}
