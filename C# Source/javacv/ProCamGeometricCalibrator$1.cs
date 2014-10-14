// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ProCamGeometricCalibrator$1
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
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("com.googlecode.javacv.ProCamGeometricCalibrator", "processCameraImage", "(Lcom.googlecode.javacv.cpp.opencv_core$IplImage;I)[[Lcom.googlecode.javacv.Marker;")]
  [SourceFile("ProCamGeometricCalibrator.java")]
  [Modifiers]
  internal sealed class ProCamGeometricCalibrator\u00241 : Object, Runnable
  {
    [Modifiers]
    internal int val\u0024cameraNumber;
    [Modifiers]
    internal bool val\u0024boardWhiteMarkers;
    [Modifiers]
    internal ProCamGeometricCalibrator this\u00240;

    [LineNumberTable((ushort) 213)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ProCamGeometricCalibrator\u00241([In] ProCamGeometricCalibrator obj0, [In] int obj1, [In] bool obj2)
    {
      int num = obj2 ? 1 : 0;
      this.this\u00240 = obj0;
      this.val\u0024cameraNumber = obj1;
      this.val\u0024boardWhiteMarkers = num != 0;
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 214)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      ProCamGeometricCalibrator.access\u0024000(this.this\u00240);
      int num = this.val\u0024cameraNumber;
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
    }
  }
}
