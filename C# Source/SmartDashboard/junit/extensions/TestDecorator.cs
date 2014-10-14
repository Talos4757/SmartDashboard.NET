// Decompiled with JetBrains decompiler
// Type: junit.extensions.TestDecorator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using junit.framework;
using System.Runtime.CompilerServices;

namespace junit.extensions
{
  [Implements(new string[] {"junit.framework.Test"})]
  public class TestDecorator : Assert, Test
  {
    protected internal Test fTest;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 158, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestDecorator(Test test)
    {
      TestDecorator testDecorator = this;
      this.fTest = test;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 166, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void basicRun(TestResult result)
    {
      this.fTest.run(result);
    }

    [LineNumberTable((ushort) 28)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int countTestCases()
    {
      return this.fTest.countTestCases();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run(TestResult result)
    {
      this.basicRun(result);
    }

    [LineNumberTable((ushort) 37)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return Object.instancehelper_toString((object) this.fTest);
    }

    public virtual Test getTest()
    {
      return this.fTest;
    }
  }
}
