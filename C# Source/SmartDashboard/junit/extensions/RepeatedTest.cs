// Decompiled with JetBrains decompiler
// Type: junit.extensions.RepeatedTest
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using junit.framework;
using System.Runtime.CompilerServices;

namespace junit.extensions
{
  public class RepeatedTest : TestDecorator
  {
    private int fTimesRepeat;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 156, (byte) 105, (byte) 100, (byte) 112, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RepeatedTest(Test test, int repeat)
      : base(test)
    {
      RepeatedTest repeatedTest = this;
      if (repeat < 0)
      {
        string str = "Repetition count must be >= 0";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.fTimesRepeat = repeat;
    }

    [LineNumberTable((ushort) 22)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int countTestCases()
    {
      return base.countTestCases() * this.fTimesRepeat;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 169, (byte) 107, (byte) 104, (byte) 98, (byte) 231, (byte) 61, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void run(TestResult result)
    {
      for (int index = 0; index < this.fTimesRepeat && !result.shouldStop(); ++index)
        base.run(result);
    }

    [LineNumberTable((ushort) 36)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string toString()
    {
      return new StringBuilder().append(base.toString()).append("(repeated)").toString();
    }
  }
}
