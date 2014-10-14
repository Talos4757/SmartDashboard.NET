// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.results.PrintableResult
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.junit.@internal;
using org.junit.runner;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental.results
{
  public class PrintableResult : Object
  {
    private Result result;

    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 185, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private PrintableResult([In] Class obj0)
    {
      Class[] classArray = new Class[1];
      int index = 0;
      Class @class = obj0;
      classArray[index] = @class;
      // ISSUE: explicit constructor call
      this.\u002Ector(JUnitCore.runClasses(classArray));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 180, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private PrintableResult([In] Result obj0)
    {
      base.\u002Ector();
      PrintableResult printableResult = this;
      this.result = obj0;
    }

    [Signature("(Ljava/util/List<Lorg/junit/runner/notification/Failure;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PrintableResult(List failures)
      : this(new FailureList(failures).result())
    {
    }

    [Signature("(Ljava/lang/Class<*>;)Lorg/junit/experimental/results/PrintableResult;")]
    [LineNumberTable((ushort) 26)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PrintableResult testResult(Class type)
    {
      return new PrintableResult(type);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 190, (byte) 102, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      ByteArrayOutputStream arrayOutputStream = new ByteArrayOutputStream();
      new TextListener(new PrintStream((OutputStream) arrayOutputStream)).testRunFinished(this.result);
      return arrayOutputStream.toString();
    }

    [LineNumberTable((ushort) 57)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int failureCount()
    {
      return this.result.getFailures().size();
    }
  }
}
