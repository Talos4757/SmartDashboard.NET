// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.GNImageAligner$1
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
  internal sealed class GNImageAligner\u00241 : Object, Parallel.Looper
  {
    [Modifiers]
    internal double val\u0024stepScale;
    [Modifiers]
    internal double[] val\u0024scale;
    [Modifiers]
    internal double val\u0024constraintError;
    [Modifiers]
    internal GNImageAligner this\u00240;

    [LineNumberTable((ushort) 506)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal GNImageAligner\u00241([In] GNImageAligner obj0, [In] double obj1, [In] double[] obj2, [In] double obj3)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 139, (byte) 105, (byte) 125, (byte) 127, (byte) 14, (byte) 127, (byte) 15, (byte) 255, (byte) 8, (byte) 60, (byte) 233, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void loop([In] int obj0, [In] int obj1, [In] int obj2)
    {
      for (int i = obj0; i < obj1; ++i)
      {
        GNImageAligner.access\u0024100(this.this\u00240)[i].set(GNImageAligner.access\u0024000(this.this\u00240));
        GNImageAligner.access\u0024100(this.this\u00240)[i].set(i, GNImageAligner.access\u0024100(this.this\u00240)[i].get(i) + this.val\u0024stepScale);
        this.val\u0024scale[i] = GNImageAligner.access\u0024100(this.this\u00240)[i].get(i) - GNImageAligner.access\u0024000(this.this\u00240).get(i);
        GNImageAligner.access\u0024200(this.this\u00240)[i] = GNImageAligner.access\u0024100(this.this\u00240)[i].getConstraintError() - this.val\u0024constraintError;
      }
    }
  }
}
