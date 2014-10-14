// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPIBinaryImage
// Assembly: WPIJavaCV, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE37E7D8-DD76-443D-A359-485FED648657
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\WPIJavaCV.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpijavacv
{
  public class WPIBinaryImage : WPIImage
  {
    [LineNumberTable(new byte[] {(byte) 159, (byte) 136, (byte) 113, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal WPIBinaryImage(object image)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (WPIBinaryImage), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: explicit constructor call
      base.\u002Ector(image);
      GC.KeepAlive((object) this);
    }

    [LineNumberTable(new byte[] {(byte) 1, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual WPIBinaryImage getAnd(WPIBinaryImage image2)
    {
      this.validateDisposed();
      object obj = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void and(WPIBinaryImage image2)
    {
      this.validateDisposed();
      object obj1 = this.image;
      object obj2 = image2.image;
      object obj3 = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core");
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual WPIBinaryImage getOr(WPIBinaryImage image2)
    {
      this.validateDisposed();
      object obj = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 93, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void or(WPIBinaryImage image2)
    {
      this.validateDisposed();
      object obj1 = this.image;
      object obj2 = image2.image;
      object obj3 = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core");
    }

    [LineNumberTable(new byte[] {(byte) 105, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void invert()
    {
      this.validateDisposed();
      object obj1 = this.image;
      object obj2 = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core");
    }

    [LineNumberTable(new byte[] {(byte) 116, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual WPIBinaryImage getInverse()
    {
      this.validateDisposed();
      object obj = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 71, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void dilate(int iterations)
    {
      this.validateDisposed();
      object obj1 = this.image;
      object obj2 = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 86, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual WPIBinaryImage getDilated(int iterations)
    {
      this.validateDisposed();
      object obj = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 105, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void erode(int iterations)
    {
      this.validateDisposed();
      object obj1 = this.image;
      object obj2 = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 121, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual WPIBinaryImage getEroded(int iterations)
    {
      this.validateDisposed();
      object obj = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 133, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual WPIContour[] findContours()
    {
      this.validateDisposed();
      object obj = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }
  }
}
