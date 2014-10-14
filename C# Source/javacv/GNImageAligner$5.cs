// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.GNImageAligner$5
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
  [EnclosingMethod("com.googlecode.javacv.GNImageAligner", "doResidual", "()V")]
  [SourceFile("GNImageAligner.java")]
  [Modifiers]
  internal sealed class GNImageAligner\u00245 : Object, Parallel.Looper
  {
    [Modifiers]
    internal GNImageAligner this\u00240;

    [LineNumberTable((ushort) 716)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal GNImageAligner\u00245([In] GNImageAligner obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 92, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void loop([In] int obj0, [In] int obj1, [In] int obj2)
    {
      ImageTransformer.Data data = GNImageAligner.access\u00241800(this.this\u00240)[obj2][0];
      GNImageAligner.access\u0024400(this.this\u00240);
      GNImageAligner.access\u0024500(this.this\u00240);
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
    }
  }
}
