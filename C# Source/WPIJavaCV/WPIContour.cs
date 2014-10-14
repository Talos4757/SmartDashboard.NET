// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPIContour
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
  public class WPIContour : WPIDisposable
  {
    internal object contours;
    internal object rect;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 137, (byte) 81, (byte) 104, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal WPIContour([In] object obj0)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj0, __typeref (WPIContour), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      // ISSUE: explicit constructor call
      base.\u002Ector();
      WPIContour wpiContour = this;
      this.contours = obj0;
      GC.KeepAlive((object) this);
    }

    internal virtual object getCVSeq()
    {
      return this.contours;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 121})]
    public virtual int getHeight()
    {
      if (this.rect != null)
      {
        object obj = this.rect;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvRect");
      }
      else
      {
        WPIContour wpiContour = this;
        object obj = this.contours;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc");
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 188, (byte) 121})]
    public virtual int getWidth()
    {
      if (this.rect != null)
      {
        object obj = this.rect;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvRect");
      }
      else
      {
        WPIContour wpiContour = this;
        object obj = this.contours;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc");
      }
    }

    [LineNumberTable(new byte[] {(byte) 7, (byte) 121})]
    public virtual int getX()
    {
      if (this.rect != null)
      {
        object obj = this.rect;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvRect");
      }
      else
      {
        WPIContour wpiContour = this;
        object obj = this.contours;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc");
      }
    }

    [LineNumberTable(new byte[] {(byte) 18, (byte) 121})]
    public virtual int getY()
    {
      if (this.rect != null)
      {
        object obj = this.rect;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvRect");
      }
      else
      {
        WPIContour wpiContour = this;
        object obj = this.contours;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc");
      }
    }

    [LineNumberTable((ushort) 82)]
    [MethodImpl(MethodImplOptions.Synchronized)]
    public virtual WPIPolygon approxPolygon(double percentAccuracy)
    {
      object obj1 = this.contours;
      object obj2 = this.contours;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeq");
    }

    [LineNumberTable((ushort) 94)]
    public virtual int getlength()
    {
      object obj = this.contours;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc");
    }

    [LineNumberTable((ushort) 98)]
    public override void disposed()
    {
      object obj = this.contours;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeq");
    }
  }
}
