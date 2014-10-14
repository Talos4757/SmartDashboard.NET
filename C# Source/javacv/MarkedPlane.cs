// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.MarkedPlane
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacv
{
  public class MarkedPlane : Object
  {
    private Marker[] markers;
    private object prewarp;
    private object planeImage;
    private object superPlaneImage;
    private object foregroundColor;
    private object backgroundColor;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private ThreadLocal localSrcPts;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private ThreadLocal localDstPts;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal tempWarp3x3;

    [LineNumberTable((ushort) 170)]
    static MarkedPlane()
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 133, (byte) 127, (byte) 8, (byte) 232, (byte) 124, (byte) 231, (byte) 69, (byte) 238, (byte) 0, (byte) 103, (byte) 104, (byte) 232, (byte) 69, (byte) 199, (byte) 99, (byte) 238, (byte) 96, (byte) 104, (byte) 240, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarkedPlane(int width, int height, Marker[] markers, bool initPrewarp, object foregroundColor, object backgroundColor, double superScale)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(foregroundColor, __typeref (MarkedPlane), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(backgroundColor, __typeref (MarkedPlane), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      int num1 = initPrewarp ? 1 : 0;
      base.\u002Ector();
      MarkedPlane markedPlane1 = this;
      this.markers = (Marker[]) null;
      this.planeImage = (object) null;
      this.superPlaneImage = (object) null;
      this.markers = markers;
      this.foregroundColor = foregroundColor;
      this.backgroundColor = backgroundColor;
      this.prewarp = (object) null;
      if (num1 != 0)
      {
        MarkedPlane markedPlane2 = this;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
      else if (width > 0 && height > 0)
      {
        MarkedPlane markedPlane2 = this;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }
      else
      {
        MarkedPlane markedPlane2 = this;
        int num2 = markers.Length * 4;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
    }

    [LineNumberTable((ushort) 34)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarkedPlane(int width, int height, Marker[] planeMarkers, double superScale)
    {
      MarkedPlane markedPlane = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvScalar");
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual object getImage()
    {
      return this.planeImage;
    }

    public virtual object getForegroundColor()
    {
      return this.foregroundColor;
    }

    public virtual object getBackgroundColor()
    {
      return this.backgroundColor;
    }

    public virtual Marker[] getMarkers()
    {
      return this.markers;
    }

    [LineNumberTable((ushort) 167)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getTotalWarp(Marker[] imagedMarkers, object totalWarp)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(totalWarp, __typeref (MarkedPlane), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      return this.getTotalWarp(imagedMarkers, totalWarp, false);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 108, (byte) 81, (byte) 103, (byte) 104, (byte) 149, (byte) 147, (byte) 111, (byte) 104, (byte) 159, (byte) 8, (byte) 255, (byte) 6, (byte) 60, (byte) 233, (byte) 72, (byte) 104, (byte) 186})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPrewarp(object prewarp)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(prewarp, __typeref (MarkedPlane), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      this.prewarp = prewarp;
      if (this.superPlaneImage == null)
        opencv_core.cvSet(this.planeImage, this.backgroundColor);
      else
        opencv_core.cvSet(this.superPlaneImage, this.backgroundColor);
      for (int index = 0; index < this.markers.Length; ++index)
      {
        if (this.superPlaneImage == null)
        {
          Marker marker = this.markers[index];
          object image = this.planeImage;
          object obj1 = this.foregroundColor;
          double num1 = 1.0;
          object obj2 = prewarp;
          double num2 = num1;
          object color = obj1;
          double scale = num2;
          object prewarp1 = obj2;
          marker.draw(image, color, scale, prewarp1);
        }
        else
        {
          Marker marker = this.markers[index];
          object obj1 = this.superPlaneImage;
          object obj2 = this.foregroundColor;
          object obj3 = this.superPlaneImage;
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
        }
      }
      if (this.superPlaneImage == null)
        return;
      object ca1 = this.superPlaneImage;
      object obj = this.planeImage;
      int num = 3;
      object ca2 = obj;
      int i = num;
      opencv_imgproc.cvResize(ca1, ca2, i);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 99, (byte) 83, (byte) 106, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getTotalWarp(Marker[] imagedMarkers, object totalWarp, bool useCenters)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(totalWarp, __typeref (MarkedPlane), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      int num1 = (useCenters ? 1 : 0) == 0 ? 4 : 1;
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(this.localSrcPts.get(), __typeref (MarkedPlane), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      int num2 = this.markers.Length * num1;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 115, (byte) 177, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setForegroundColor(object foregroundColor)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(foregroundColor, __typeref (MarkedPlane), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      this.foregroundColor = foregroundColor;
      this.setPrewarp(this.prewarp);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 113, (byte) 177, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackgroundColor(object backgroundColor)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(backgroundColor, __typeref (MarkedPlane), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      this.backgroundColor = backgroundColor;
      this.setPrewarp(this.prewarp);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 111, (byte) 191, (byte) 3, (byte) 103, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setColors(object foregroundColor, object backgroundColor)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(foregroundColor, __typeref (MarkedPlane), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(backgroundColor, __typeref (MarkedPlane), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      this.foregroundColor = foregroundColor;
      this.backgroundColor = backgroundColor;
      this.setPrewarp(this.prewarp);
    }

    public virtual object getPrewarp()
    {
      return this.prewarp;
    }

    [LineNumberTable((ushort) 160)]
    public virtual int getWidth()
    {
      object obj = this.planeImage;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable((ushort) 163)]
    public virtual int getHeight()
    {
      object obj = this.planeImage;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }
  }
}
