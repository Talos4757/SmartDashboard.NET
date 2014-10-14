// Decompiled with JetBrains decompiler
// Type: junit.extensions.TestSetup
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using junit.framework;
using System.Runtime.CompilerServices;

namespace junit.extensions
{
  public class TestSetup : TestDecorator
  {
    [LineNumberTable(new byte[] {(byte) 159, (byte) 157, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestSetup(Test test)
      : base(test)
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    protected internal virtual void setUp()
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    protected internal virtual void tearDown()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 162, (byte) 232, (byte) 71, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void run(TestResult result)
    {
      TestSetup\u00241 testSetup1 = new TestSetup\u00241(this, result);
      result.runProtected((Test) this, (Protectable) testSetup1);
    }
  }
}
