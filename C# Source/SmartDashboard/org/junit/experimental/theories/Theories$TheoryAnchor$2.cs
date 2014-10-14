// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.Theories$TheoryAnchor$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.junit.experimental.theories.@internal;
using org.junit.runners.model;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental.theories
{
  [InnerClass]
  [EnclosingMethod("org.junit.experimental.theories.Theories$TheoryAnchor", "methodCompletesWithParameters", "(Lorg.junit.runners.model.FrameworkMethod;Lorg.junit.experimental.theories.internal.Assignments;Ljava.lang.Object;)Lorg.junit.runners.model.Statement;")]
  [SourceFile("Theories.java")]
  [Modifiers]
  internal sealed class Theories\u0024TheoryAnchor\u00242 : Statement
  {
    [Modifiers]
    internal Theories.TheoryAnchor this\u00240 = obj0;
    [Modifiers]
    internal Assignments val\u0024complete = obj1;
    [Modifiers]
    internal FrameworkMethod val\u0024method = obj2;
    [Modifiers]
    internal object val\u0024freshInstance = obj3;

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable((ushort) 163)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Theories\u0024TheoryAnchor\u00242([In] Theories.TheoryAnchor obj0, [In] Assignments obj1, [In] FrameworkMethod obj2, [In] object obj3)
    {
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable(new byte[] {(byte) 115, (byte) 151, (byte) 190, (byte) 2, (byte) 161})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void evaluate()
    {
      try
      {
        this.val\u0024method.invokeExplosively(this.val\u0024freshInstance, this.val\u0024complete.getMethodArguments(Theories.TheoryAnchor.access\u0024000(this.this\u00240)));
      }
      catch (PotentialAssignment.CouldNotGenerateValueException ex)
      {
      }
    }
  }
}
