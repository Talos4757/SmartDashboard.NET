// Decompiled with JetBrains decompiler
// Type: org.junit.rules.ExternalResource$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.junit.runners.model;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.rules
{
  [InnerClass]
  [EnclosingMethod("org.junit.rules.ExternalResource", "apply", "(Lorg.junit.runners.model.Statement;Lorg.junit.runners.model.FrameworkMethod;Ljava.lang.Object;)Lorg.junit.runners.model.Statement;")]
  [SourceFile("ExternalResource.java")]
  [Modifiers]
  internal sealed class ExternalResource\u00241 : Statement
  {
    [Modifiers]
    internal ExternalResource this\u00240 = obj0;
    [Modifiers]
    internal Statement val\u0024base = obj1;

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable((ushort) 40)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ExternalResource\u00241([In] ExternalResource obj0, [In] Statement obj1)
    {
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 183, (byte) 139, (byte) 143, (byte) 78, (byte) 98, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void evaluate()
    {
      this.this\u00240.before();
      try
      {
        this.val\u0024base.evaluate();
      }
      finally
      {
        this.this\u00240.after();
      }
    }
  }
}
