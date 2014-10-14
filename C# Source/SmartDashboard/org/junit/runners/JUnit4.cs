// Decompiled with JetBrains decompiler
// Type: org.junit.runners.JUnit4
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.junit.runners
{
  public sealed class JUnit4 : BlockJUnit4ClassRunner
  {
    [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 162, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JUnit4(Class klass)
      : base(klass)
    {
    }
  }
}
