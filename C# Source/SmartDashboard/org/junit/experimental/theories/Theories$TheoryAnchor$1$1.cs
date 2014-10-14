// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.Theories$TheoryAnchor$1$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using org.junit.@internal;
using org.junit.runners.model;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental.theories
{
  [InnerClass]
  [EnclosingMethod("org.junit.experimental.theories.Theories$TheoryAnchor$1", "methodBlock", "(Lorg.junit.runners.model.FrameworkMethod;)Lorg.junit.runners.model.Statement;")]
  [SourceFile("Theories.java")]
  [Modifiers]
  internal sealed class Theories\u0024TheoryAnchor\u00241\u00241 : Statement
  {
    [Modifiers]
    internal Theories\u0024TheoryAnchor\u00241 this\u00241 = obj0;
    [Modifiers]
    internal Statement val\u0024statement = obj1;

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable((ushort) 131)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Theories\u0024TheoryAnchor\u00241\u00241([In] Theories\u0024TheoryAnchor\u00241 obj0, [In] Statement obj1)
    {
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable(new byte[] {(byte) 83, (byte) 107, (byte) 255, (byte) 15, (byte) 70, (byte) 226, (byte) 59, (byte) 97, (byte) 209, (byte) 226, (byte) 61, (byte) 97, (byte) 191, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void evaluate()
    {
      AssumptionViolatedException e1;
      Exception e2;
      try
      {
        try
        {
          this.val\u0024statement.evaluate();
          this.this\u00241.this\u00240.handleDataPointSuccess();
          return;
        }
        catch (AssumptionViolatedException ex)
        {
          int num = 1;
          e1 = (AssumptionViolatedException) ByteCodeHelper.MapException<AssumptionViolatedException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
      }
      catch (Exception ex)
      {
        int num = 0;
        e2 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        goto label_4;
      }
      this.this\u00241.this\u00240.handleAssumptionViolation(e1);
      return;
label_4:
      this.this\u00241.this\u00240.reportParameterizedError(e2, this.this\u00241.val\u0024complete.getArgumentStrings(Theories.TheoryAnchor.access\u0024000(this.this\u00241.this\u00240)));
    }
  }
}
