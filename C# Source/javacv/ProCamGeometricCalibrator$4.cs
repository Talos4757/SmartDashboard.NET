// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ProCamGeometricCalibrator$4
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
  internal sealed class ProCamGeometricCalibrator\u00244 : Object, Runnable
  {
    [Modifiers]
    internal int val\u0024cameraNumber;
    [Modifiers]
    internal bool val\u0024projWhiteMarkers;
    [Modifiers]
    internal ProCamGeometricCalibrator this\u00240;

    [LineNumberTable((ushort) 228)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ProCamGeometricCalibrator\u00244([In] ProCamGeometricCalibrator obj0, [In] int obj1, [In] bool obj2)
    {
      int num = obj2 ? 1 : 0;
      this.this\u00240 = obj0;
      this.val\u0024cameraNumber = obj1;
      this.val\u0024projWhiteMarkers = num != 0;
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 229)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      ProCamGeometricCalibrator.access\u0024500(this.this\u00240);
      int num1 = this.val\u0024cameraNumber;
      MarkerDetector markerDetector = ProCamGeometricCalibrator.access\u0024600(this.this\u00240)[this.val\u0024cameraNumber];
      ProCamGeometricCalibrator.access\u0024000(this.this\u00240);
      int num2 = this.val\u0024cameraNumber;
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
    }
  }
}
