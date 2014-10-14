// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.GNImageAligner$4
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
  internal sealed class GNImageAligner\u00244 : Object, Parallel.Looper
  {
    [Modifiers]
    internal int val\u0024n;
    [Modifiers]
    internal int val\u0024m;
    [Modifiers]
    internal double val\u0024K;
    [Modifiers]
    internal GNImageAligner this\u00240;

    [LineNumberTable((ushort) 638)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal GNImageAligner\u00244([In] GNImageAligner obj0, [In] int obj1, [In] int obj2, [In] double obj3)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 16, (byte) 105, (byte) 120, (byte) 165, (byte) 117, (byte) 120, (byte) 133, (byte) 102, (byte) 107, (byte) 63, (byte) 4, (byte) 198, (byte) 248, (byte) 55, (byte) 233, (byte) 78, (byte) 103, (byte) 109, (byte) 63, (byte) 6, (byte) 200, (byte) 247, (byte) 40, (byte) 233, (byte) 90})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void loop([In] int obj0, [In] int obj1, [In] int obj2)
    {
      for (int index1 = obj0; index1 < obj1; ++index1)
      {
        if (index1 >= this.val\u0024n || GNImageAligner.access\u00241400(this.this\u00240)[index1])
        {
          for (int index2 = index1; index2 < this.val\u0024n + this.val\u0024m; ++index2)
          {
            if (index2 >= this.val\u0024n || GNImageAligner.access\u00241400(this.this\u00240)[index2])
            {
              double num = 0.0;
              for (int index3 = 0; index3 < this.val\u0024n; ++index3)
                num += GNImageAligner.access\u00241300(this.this\u00240)[index1][index3] * GNImageAligner.access\u00241300(this.this\u00240)[index2][index3];
              GNImageAligner.access\u00241500(this.this\u00240);
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            }
          }
          double num1 = 0.0;
          for (int index2 = 0; index2 < this.val\u0024n; ++index2)
            num1 -= GNImageAligner.access\u00241300(this.this\u00240)[index1][index2] * GNImageAligner.access\u00241600(this.this\u00240)[index2];
          GNImageAligner.access\u00241700(this.this\u00240);
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
        }
      }
    }
  }
}
