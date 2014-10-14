// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.GNImageAligner$3
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacv
{
  [InnerClass]
  [Implements(new string[] {"com.googlecode.javacv.Parallel$Looper"})]
  [EnclosingMethod("com.googlecode.javacv.GNImageAligner", "doHessianGradient", "([D)V")]
  [SourceFile("GNImageAligner.java")]
  [Modifiers]
  internal sealed class GNImageAligner\u00243 : Object, Parallel.Looper
  {
    [Modifiers]
    internal int val\u0024n;
    [Modifiers]
    internal double[] val\u0024scale;
    [Modifiers]
    internal int val\u0024m;
    [Modifiers]
    internal double val\u0024stepScale;
    [Modifiers]
    internal GNImageAligner this\u00240;

    [LineNumberTable((ushort) 602)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal GNImageAligner\u00243([In] GNImageAligner obj0, [In] int obj1, [In] double[] obj2, [In] int obj3, [In] double obj4)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 236, (byte) 105, (byte) 105, (byte) 119, (byte) 156, (byte) 127, (byte) 6, (byte) 127, (byte) 6, (byte) 127, (byte) 7, (byte) 127, (byte) 9, (byte) 127, (byte) 21, (byte) 110, (byte) 127, (byte) 33, (byte) 31, (byte) 18, (byte) 233, (byte) 54, (byte) 233, (byte) 79})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void loop([In] int obj0, [In] int obj1, [In] int obj2)
    {
      for (int index1 = obj0; index1 < obj1; ++index1)
      {
        if (index1 < this.val\u0024n)
        {
          Arrays.fill(GNImageAligner.access\u00241300(this.this\u00240)[index1], 0.0);
          GNImageAligner.access\u00241300(this.this\u00240)[index1][index1] = this.val\u0024scale[index1];
        }
        else
        {
          ByteCodeHelper.arraycopy_primitive_8((System.Array) this.this\u00240.subspaceParameters, 0, (System.Array) this.this\u00240.tempSubspaceParameters[obj2], 0, this.val\u0024m);
          double[] numArray1 = this.this\u00240.tempSubspaceParameters[obj2];
          int index2 = index1 - this.val\u0024n;
          double[] numArray2 = numArray1;
          numArray2[index2] = numArray2[index2] + this.val\u0024stepScale;
          GNImageAligner.access\u0024100(this.this\u00240)[index1 - this.val\u0024n + 1].set(GNImageAligner.access\u0024000(this.this\u00240));
          GNImageAligner.access\u0024100(this.this\u00240)[index1 - this.val\u0024n + 1].setSubspace(this.this\u00240.tempSubspaceParameters[obj2]);
          this.val\u0024scale[index1] = this.this\u00240.tempSubspaceParameters[obj2][index1 - this.val\u0024n] - this.this\u00240.subspaceParameters[index1 - this.val\u0024n];
          for (int i = 0; i < this.val\u0024n; ++i)
          {
            GNImageAligner.access\u00241300(this.this\u00240)[index1][i] = GNImageAligner.access\u0024100(this.this\u00240)[0].get(i) - GNImageAligner.access\u0024100(this.this\u00240)[index1 - this.val\u0024n + 1].get(i);
            bool[] flagArray1 = GNImageAligner.access\u00241400(this.this\u00240);
            int index3 = i;
            bool[] flagArray2 = flagArray1;
            flagArray2[index3] = flagArray2[index3] | GNImageAligner.access\u00241300(this.this\u00240)[index1][i] != 0.0;
          }
        }
      }
    }
  }
}
