// Decompiled with JetBrains decompiler
// Type: junit.framework.JUnit4TestCaseFacade
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.junit.runner;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace junit.framework
{
  [Implements(new string[] {"junit.framework.Test", "org.junit.runner.Describable"})]
  public class JUnit4TestCaseFacade : Object, Test, Describable
  {
    [Modifiers]
    private Description fDescription;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 154, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal JUnit4TestCaseFacade([In] Description obj0)
    {
      base.\u002Ector();
      JUnit4TestCaseFacade junit4TestCaseFacade = this;
      this.fDescription = obj0;
    }

    public virtual Description getDescription()
    {
      return this.fDescription;
    }

    [LineNumberTable((ushort) 18)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return this.getDescription().toString();
    }

    public virtual int countTestCases()
    {
      return 1;
    }

    [LineNumberTable((ushort) 26)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run(TestResult result)
    {
      string str = "This test stub created only for informational purposes.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new RuntimeException(str);
    }
  }
}
