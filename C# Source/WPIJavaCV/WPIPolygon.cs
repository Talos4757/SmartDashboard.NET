// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPIPolygon
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
  public class WPIPolygon : WPIDisposable
  {
    internal object polygon;
    internal object boundingRect;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 137, (byte) 81, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal WPIPolygon([In] object obj0)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj0, __typeref (WPIPolygon), "com.googlecode.javacv.cpp.opencv_core$CvSeq");
      // ISSUE: explicit constructor call
      base.\u002Ector();
      WPIPolygon wpiPolygon = this;
      this.polygon = obj0;
      GC.KeepAlive((object) this);
    }

    internal virtual object getCVSeq()
    {
      return this.polygon;
    }

    [LineNumberTable((ushort) 95)]
    public virtual int getNumVertices()
    {
      object obj = this.polygon;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeq");
    }

    [LineNumberTable((ushort) 33)]
    public virtual WPIPoint[] getPoints()
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 191, (byte) 104, (byte) 147})]
    public virtual int getWidth()
    {
      if (this.boundingRect == null)
      {
        WPIPolygon wpiPolygon = this;
        object obj = this.polygon;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc");
      }
      else
      {
        object obj = this.boundingRect;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvRect");
      }
    }

    [LineNumberTable(new byte[] {(byte) 10, (byte) 104, (byte) 147})]
    public virtual int getHeight()
    {
      if (this.boundingRect == null)
      {
        WPIPolygon wpiPolygon = this;
        object obj = this.polygon;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc");
      }
      else
      {
        object obj = this.boundingRect;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvRect");
      }
    }

    [LineNumberTable(new byte[] {(byte) 22, (byte) 104, (byte) 147})]
    public virtual int getX()
    {
      if (this.boundingRect == null)
      {
        WPIPolygon wpiPolygon = this;
        object obj = this.polygon;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc");
      }
      else
      {
        object obj = this.boundingRect;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvRect");
      }
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 104, (byte) 147})]
    public virtual int getY()
    {
      if (this.boundingRect == null)
      {
        WPIPolygon wpiPolygon = this;
        object obj = this.polygon;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc");
      }
      else
      {
        object obj = this.boundingRect;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvRect");
      }
    }

    [LineNumberTable((ushort) 104)]
    public virtual bool isConvex()
    {
      object obj = this.polygon;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_imgproc");
    }

    [LineNumberTable((ushort) 112)]
    public virtual int getArea()
    {
      object obj = this.polygon;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core");
    }

    [LineNumberTable((ushort) 120)]
    public virtual int getPerimeter()
    {
      object obj = this.polygon;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core");
    }

    [LineNumberTable((ushort) 124)]
    public override void disposed()
    {
      object obj = this.polygon;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeq");
    }
  }
}
