// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.GNImageAligner$2
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacv
{
  [InnerClass]
  [Implements(new string[] {"com.googlecode.javacv.Parallel$Looper"})]
  [EnclosingMethod("com.googlecode.javacv.GNImageAligner", "doHessianGradient", "([D)V")]
  [SourceFile("GNImageAligner.java")]
  [Modifiers]
  internal sealed class GNImageAligner\u00242 : Object, Parallel.Looper
  {
    [Modifiers]
    internal int val\u0024n;
    [Modifiers]
    internal GNImageAligner this\u00240;

    [LineNumberTable((ushort) 517)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal GNImageAligner\u00242([In] GNImageAligner obj0, [In] int obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 149, (byte) 107, (byte) 112, (byte) 255, (byte) 3, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void loop([In] int obj0, [In] int obj1, [In] int obj2)
    {
      int index = 0;
      if (index < this.val\u0024n)
      {
        ImageTransformer.Data data = GNImageAligner.access\u0024300(this.this\u00240)[obj2][index];
        GNImageAligner.access\u0024400(this.this\u00240);
        GNImageAligner.access\u0024500(this.this\u00240);
        throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
      }
      else
      {
        GNImageAligner.access\u00241000(this.this\u00240);
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvRect");
      }
    }
  }
}
