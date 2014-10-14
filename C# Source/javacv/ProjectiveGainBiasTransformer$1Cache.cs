// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ProjectiveGainBiasTransformer$1Cache
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using java.lang;
using java.nio;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacv
{
  [InnerClass]
  [EnclosingMethod("com.googlecode.javacv.ProjectiveGainBiasTransformer", "transform", "([Lcom.googlecode.javacv.ImageTransformer$Data;Lcom.googlecode.javacv.cpp.opencv_core$CvRect;[Lcom.googlecode.javacv.ImageTransformer$Parameters;[Z)V")]
  [SourceFile("ProjectiveGainBiasTransformer.java")]
  [Modifiers]
  internal sealed class ProjectiveGainBiasTransformer\u00241Cache : Object
  {
    [Modifiers]
    internal int length;
    [Modifiers]
    internal object kernelData;
    [Modifiers]
    internal object H;
    [Modifiers]
    internal object X;
    [Modifiers]
    internal object dstDstDot;
    [Modifiers]
    internal DoubleBuffer[] dstDstDotBuf;
    [Modifiers]
    internal ProjectiveGainBiasTransformer this\u00240;

    [LineNumberTable(new byte[] {(byte) 89, (byte) 111, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ProjectiveGainBiasTransformer\u00241Cache([In] ProjectiveGainBiasTransformer obj0, [In] int obj1)
    {
      base.\u002Ector();
      ProjectiveGainBiasTransformer\u00241Cache transformer1Cache1 = this;
      this.length = obj1;
      ProjectiveGainBiasTransformer\u00241Cache transformer1Cache2 = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.cvkernels$KernelData");
    }
  }
}
