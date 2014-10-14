// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPIImage
// Assembly: WPIJavaCV, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE37E7D8-DD76-443D-A359-485FED648657
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\WPIJavaCV.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt.image;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.wpijavacv
{
  public class WPIImage : WPIDisposable
  {
    protected internal object image;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 133, (byte) 113, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPIImage(object image)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (WPIImage), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: explicit constructor call
      base.\u002Ector();
      WPIImage wpiImage = this;
      this.image = image;
      GC.KeepAlive((object) this);
    }

    [LineNumberTable((ushort) 28)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPIImage(BufferedImage image)
    {
      WPIImage wpiImage = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 188, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getWidth()
    {
      this.validateDisposed();
      object obj = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 6, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getHeight()
    {
      this.validateDisposed();
      object obj = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual BufferedImage getBufferedImage()
    {
      this.validateDisposed();
      object obj = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable((ushort) 74)]
    protected internal override void disposed()
    {
      object obj = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }
  }
}
