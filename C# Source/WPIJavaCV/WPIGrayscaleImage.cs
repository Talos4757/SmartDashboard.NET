// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPIGrayscaleImage
// Assembly: WPIJavaCV, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE37E7D8-DD76-443D-A359-485FED648657
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\WPIJavaCV.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpijavacv
{
  public class WPIGrayscaleImage : WPIImage
  {
    [LineNumberTable(new byte[] {(byte) 159, (byte) 138, (byte) 145, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal WPIGrayscaleImage([In] object obj0)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj0, __typeref (WPIGrayscaleImage), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: explicit constructor call
      base.\u002Ector(obj0);
      GC.KeepAlive((object) this);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 171, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual WPIBinaryImage getThreshold(int threshold)
    {
      this.validateDisposed();
      object obj = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 189, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual WPIBinaryImage getThresholdInverted(int threshold)
    {
      this.validateDisposed();
      object obj = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }
  }
}
