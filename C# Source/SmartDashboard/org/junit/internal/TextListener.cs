// Decompiled with JetBrains decompiler
// Type: org.junit.internal.TextListener
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using java.util;
using org.junit.@internal;
using org.junit.runner;
using org.junit.runner.notification;
using System.Runtime.CompilerServices;

namespace org.junit.@internal
{
  public class TextListener : RunListener
  {
    [Modifiers]
    private PrintStream fWriter;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 162, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextListener(PrintStream writer)
    {
      TextListener textListener = this;
      this.fWriter = writer;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 159, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextListener(JUnitSystem system)
      : this(system.@out())
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 168, (byte) 108, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void testRunFinished(Result result)
    {
      this.printHeader(result.getRunTime());
      this.printFailures(result);
      this.printFooter(result);
    }

    [LineNumberTable(new byte[] {(byte) 5, (byte) 107, (byte) 127, (byte) 14})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void printHeader(long runTime)
    {
      this.getWriter().println();
      this.getWriter().println(new StringBuilder().append("Time: ").append(this.elapsedTimeAsString(runTime)).toString());
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 103, (byte) 104, (byte) 97, (byte) 105, (byte) 159, (byte) 23, (byte) 127, (byte) 21, (byte) 98, (byte) 123, (byte) 127, (byte) 8})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void printFailures(Result result)
    {
      List failures = result.getFailures();
      if (failures.size() == 0)
        return;
      if (failures.size() == 1)
        this.getWriter().println(new StringBuilder().append("There was ").append(failures.size()).append(" failure:").toString());
      else
        this.getWriter().println(new StringBuilder().append("There were ").append(failures.size()).append(" failures:").toString());
      int num1 = 1;
      Iterator iterator = failures.iterator();
      while (iterator.hasNext())
      {
        Failure each = (Failure) iterator.next();
        StringBuilder stringBuilder = new StringBuilder().append("");
        int num2 = num1;
        ++num1;
        string prefix = stringBuilder.append(num2).toString();
        this.printFailure(each, prefix);
      }
    }

    [LineNumberTable(new byte[] {(byte) 28, (byte) 107, (byte) 107, (byte) 112, (byte) 191, (byte) 59, (byte) 107, (byte) 112, (byte) 159, (byte) 32, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void printFooter(Result result)
    {
      if (result.wasSuccessful())
      {
        this.getWriter().println();
        this.getWriter().print("OK");
        this.getWriter().println(new StringBuilder().append(" (").append(result.getRunCount()).append(" test").append(result.getRunCount() != 1 ? "s" : "").append(")").toString());
      }
      else
      {
        this.getWriter().println();
        this.getWriter().println("FAILURES!!!");
        this.getWriter().println(new StringBuilder().append("Tests run: ").append(result.getRunCount()).append(",  Failures: ").append(result.getFailureCount()).toString());
      }
      this.getWriter().println();
    }

    private PrintStream getWriter()
    {
      return this.fWriter;
    }

    [LineNumberTable((ushort) 96)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string elapsedTimeAsString(long runTime)
    {
      return NumberFormat.getInstance().format((double) runTime / 1000.0);
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 127, (byte) 17, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void printFailure(Failure each, string prefix)
    {
      this.getWriter().println(new StringBuilder().append(prefix).append(") ").append(each.getTestHeader()).toString());
      this.getWriter().print(each.getTrace());
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void testStarted(Description description)
    {
      this.fWriter.append('.');
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 180, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void testFailure(Failure failure)
    {
      this.fWriter.append('E');
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 185, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void testIgnored(Description description)
    {
      this.fWriter.append('I');
    }
  }
}
