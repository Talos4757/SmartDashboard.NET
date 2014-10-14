// Decompiled with JetBrains decompiler
// Type: junit.textui.ResultPrinter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using java.util;
using junit.framework;
using junit.runner;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace junit.textui
{
  [Implements(new string[] {"junit.framework.TestListener"})]
  public class ResultPrinter : Object, TestListener
  {
    internal PrintStream fWriter;
    internal int fColumn;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 8, (byte) 167, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResultPrinter(PrintStream writer)
    {
      base.\u002Ector();
      ResultPrinter resultPrinter = this;
      this.fColumn = 0;
      this.fWriter = writer;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 184, (byte) 107, (byte) 127, (byte) 14})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void printHeader(long runTime)
    {
      this.getWriter().println();
      this.getWriter().println(new StringBuilder().append("Time: ").append(this.elapsedTimeAsString(runTime)).toString());
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 189, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void printErrors(TestResult result)
    {
      this.printDefects(result.errors(), result.errorCount(), "error");
    }

    [LineNumberTable(new byte[] {(byte) 1, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void printFailures(TestResult result)
    {
      this.printDefects(result.failures(), result.failureCount(), "failure");
    }

    [LineNumberTable(new byte[] {(byte) 31, (byte) 107, (byte) 107, (byte) 112, (byte) 191, (byte) 59, (byte) 107, (byte) 112, (byte) 223, (byte) 53, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void printFooter(TestResult result)
    {
      if (result.wasSuccessful())
      {
        this.getWriter().println();
        this.getWriter().print("OK");
        this.getWriter().println(new StringBuilder().append(" (").append(result.runCount()).append(" test").append(result.runCount() != 1 ? "s" : "").append(")").toString());
      }
      else
      {
        this.getWriter().println();
        this.getWriter().println("FAILURES!!!");
        this.getWriter().println(new StringBuilder().append("Tests run: ").append(result.runCount()).append(",  Failures: ").append(result.failureCount()).append(",  Errors: ").append(result.errorCount()).toString());
      }
      this.getWriter().println();
    }

    public virtual PrintStream getWriter()
    {
      return this.fWriter;
    }

    [LineNumberTable((ushort) 102)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string elapsedTimeAsString(long runTime)
    {
      return NumberFormat.getInstance().format((double) runTime / 1000.0);
    }

    [Signature("(Ljava/util/Enumeration<Ljunit/framework/TestFailure;>;ILjava/lang/String;)V")]
    [LineNumberTable(new byte[] {(byte) 5, (byte) 100, (byte) 100, (byte) 159, (byte) 34, (byte) 127, (byte) 32, (byte) 106, (byte) 50, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void printDefects(Enumeration booBoos, int count, string type)
    {
      if (count == 0)
        return;
      if (count == 1)
        this.getWriter().println(new StringBuilder().append("There was ").append(count).append(" ").append(type).append(":").toString());
      else
        this.getWriter().println(new StringBuilder().append("There were ").append(count).append(" ").append(type).append("s:").toString());
      int count1 = 1;
      while (booBoos.hasMoreElements())
      {
        this.printDefect((TestFailure) booBoos.nextElement(), count1);
        ++count1;
      }
    }

    [LineNumberTable(new byte[] {(byte) 16, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void printDefect(TestFailure booBoo, int count)
    {
      this.printDefectHeader(booBoo, count);
      this.printDefectTrace(booBoo);
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 127, (byte) 19})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void printDefectHeader(TestFailure booBoo, int count)
    {
      this.getWriter().print(new StringBuilder().append(count).append(") ").append((object) booBoo.failedTest()).toString());
    }

    [LineNumberTable(new byte[] {(byte) 27, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void printDefectTrace(TestFailure booBoo)
    {
      this.getWriter().print(BaseTestRunner.getFilteredTrace(booBoo.trace()));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 169, (byte) 103, (byte) 103, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    internal virtual void print([In] TestResult obj0, [In] long obj1)
    {
      this.printHeader(obj1);
      this.printErrors(obj0);
      this.printFailures(obj0);
      this.printFooter(obj0);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 107, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual void printWaitPrompt()
    {
      this.getWriter().println();
      this.getWriter().println("<RETURN> to continue");
    }

    [LineNumberTable(new byte[] {(byte) 62, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addError(Test test, Exception t)
    {
      this.getWriter().print("E");
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addFailure(Test test, AssertionFailedError t)
    {
      this.getWriter().print("F");
    }

    public virtual void endTest(Test test)
    {
    }

    [LineNumberTable(new byte[] {(byte) 82, (byte) 112, (byte) 119, (byte) 107, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void startTest(Test test)
    {
      this.getWriter().print(".");
      ResultPrinter resultPrinter1 = this;
      int num1 = resultPrinter1.fColumn;
      ResultPrinter resultPrinter2 = resultPrinter1;
      int num2 = num1;
      resultPrinter2.fColumn = num1 + 1;
      int num3 = 40;
      if (num2 < num3)
        return;
      this.getWriter().println();
      this.fColumn = 0;
    }
  }
}
