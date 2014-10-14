// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpijavacv.WPIColorImage
// Assembly: WPIJavaCV, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE37E7D8-DD76-443D-A359-485FED648657
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\WPIJavaCV.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt.image;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpijavacv
{
  public class WPIColorImage : WPIImage
  {
    private WPIGrayscaleImage red;
    private WPIGrayscaleImage blue;
    private WPIGrayscaleImage green;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 135, (byte) 113, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal WPIColorImage([In] object obj0)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj0, __typeref (WPIColorImage), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: explicit constructor call
      base.\u002Ector(obj0);
      GC.KeepAlive((object) this);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 167, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WPIColorImage(BufferedImage imageSrc)
      : base(imageSrc)
    {
      GC.KeepAlive((object) this);
    }

    [LineNumberTable((ushort) 39)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawContour(WPIContour c, WPIColor color, int thickness)
    {
      object obj = this.image;
      c.getCVSeq();
      color.toCvScalar();
      color.toCvScalar();
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core");
    }

    [LineNumberTable((ushort) 82)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawPoint(WPIPoint p, WPIColor color, int thickness)
    {
      object obj = this.image;
      p.getCvPoint();
      color.toCvScalar();
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core");
    }

    [LineNumberTable((ushort) 72)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawPolygon(WPIPolygon p, WPIColor color, int thickness)
    {
      object obj = this.image;
      p.getCVSeq();
      color.toCvScalar();
      color.toCvScalar();
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core");
    }

    [LineNumberTable(new byte[] {(byte) 70, (byte) 104, (byte) 241, (byte) 72})]
    private void generateChannels()
    {
      if (this.red != null)
        return;
      object obj = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 191, (byte) 111, (byte) 41, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawContours(WPIContour[] c, WPIColor color, int thickness)
    {
      WPIContour[] wpiContourArray = c;
      int length = wpiContourArray.Length;
      for (int index = 0; index < length; ++index)
        this.drawContour(wpiContourArray[index], color, thickness);
    }

    [LineNumberTable((ushort) 62)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawLine(WPIPoint p1, WPIPoint p2, WPIColor color, int thickness)
    {
      object obj = this.image;
      p1.getCvPoint();
      p2.getCvPoint();
      color.toCvScalar();
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core");
    }

    [LineNumberTable(new byte[] {(byte) 41, (byte) 103, (byte) 43, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawPoints(WPIPoint[] p, WPIColor color, int thickness)
    {
      for (int index = 0; index < p.Length; ++index)
        this.drawPoint(p[index], color, thickness);
    }

    [LineNumberTable(new byte[] {(byte) 51, (byte) 111, (byte) 52, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawPolygons(WPIPolygon[] p, WPIColor color, int thickness)
    {
      WPIPolygon[] wpiPolygonArray = p;
      int length = wpiPolygonArray.Length;
      for (int index = 0; index < length; ++index)
      {
        WPIPolygon wpiPolygon = wpiPolygonArray[index];
        if (wpiPolygon != null)
        {
          wpiPolygon.getCVSeq();
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeq");
        }
      }
    }

    [LineNumberTable((ushort) 116)]
    public virtual void drawRect(int x, int y, int width, int height, WPIColor color, int thickness)
    {
      object obj = this.image;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core");
    }

    [LineNumberTable(new byte[] {(byte) 86, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual WPIGrayscaleImage getRedChannel()
    {
      this.generateChannels();
      return this.red;
    }

    [LineNumberTable(new byte[] {(byte) 95, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual WPIGrayscaleImage getBlueChannel()
    {
      this.generateChannels();
      return this.blue;
    }

    [LineNumberTable(new byte[] {(byte) 105, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual WPIGrayscaleImage getGreenChannel()
    {
      this.generateChannels();
      return this.green;
    }
  }
}
