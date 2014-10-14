// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.max.MaxCore$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using org.junit.@internal.runners;
using org.junit.runner;
using org.junit.runners.model;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental.max
{
  [InnerClass]
  [EnclosingMethod("org.junit.experimental.max.MaxCore", "constructLeafRequest", "(Ljava.util.List;)Lorg.junit.runner.Request;")]
  [SourceFile("MaxCore.java")]
  [Modifiers]
  internal sealed class MaxCore\u00241 : Request
  {
    [Modifiers]
    internal MaxCore this\u00240 = obj0;
    [Modifiers]
    internal List val\u0024runners = obj1;

    [LineNumberTable((ushort) 108)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal MaxCore\u00241([In] MaxCore obj0, [In] List obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 60, (byte) 127, (byte) 9, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Runner getRunner()
    {
      MaxCore\u00241\u00241 maxCore11;
      InitializationError initializationError;
      try
      {
        maxCore11 = new MaxCore\u00241\u00241(this, (Class) null, this.val\u0024runners);
      }
      catch (InitializationError ex)
      {
        int num = 1;
        initializationError = (InitializationError) ByteCodeHelper.MapException<InitializationError>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return (Runner) maxCore11;
label_3:
      return (Runner) new ErrorReportingRunner((Class) null, (Exception) initializationError);
    }
  }
}
