// Decompiled with JetBrains decompiler
// Type: junit.framework.JUnit4TestAdapterCache$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.junit.runner;
using org.junit.runner.notification;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace junit.framework
{
  [InnerClass]
  [EnclosingMethod("junit.framework.JUnit4TestAdapterCache", "getNotifier", "(Ljunit.framework.TestResult;Ljunit.framework.JUnit4TestAdapter;)Lorg.junit.runner.notification.RunNotifier;")]
  [SourceFile("JUnit4TestAdapterCache.java")]
  [Modifiers]
  internal sealed class JUnit4TestAdapterCache\u00241 : RunListener
  {
    [Modifiers]
    internal JUnit4TestAdapterCache this\u00240 = obj0;
    [Modifiers]
    internal TestResult val\u0024result = obj1;

    [LineNumberTable((ushort) 61)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal JUnit4TestAdapterCache\u00241([In] JUnit4TestAdapterCache obj0, [In] TestResult obj1)
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 1, (byte) 127, (byte) 5})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void testFailure([In] Failure obj0)
    {
      this.val\u0024result.addError(this.this\u00240.asTest(obj0.getDescription()), obj0.getException());
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 7, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void testFinished([In] Description obj0)
    {
      this.val\u0024result.endTest(this.this\u00240.asTest(obj0));
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 13, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void testStarted([In] Description obj0)
    {
      this.val\u0024result.startTest(this.this\u00240.asTest(obj0));
    }
  }
}
