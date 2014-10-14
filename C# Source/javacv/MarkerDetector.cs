// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.MarkerDetector
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacv
{
  public class MarkerDetector : Object
  {
    private MarkerDetector.Settings settings;
    private object tracker;
    private int width;
    private int height;
    private int depth;
    private int channels;
    private object tempsrc;
    private object tempsrc2;
    private object sumimage;
    private object sqsumimage;
    private object binarized;
    private object points;
    private object corners;
    private object memory;
    private object subPixelSize;
    private object subPixelZeroZone;
    private object subPixelTermCriteria;
    private object pts;
    private object pt1;
    private object pt2;
    private object font;
    private object text_size;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 232, (byte) 160, (byte) 73, (byte) 103, (byte) 156})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarkerDetector(MarkerDetector.Settings settings)
    {
      base.\u002Ector();
      MarkerDetector markerDetector1 = this;
      this.tracker = (object) null;
      this.width = 0;
      this.height = 0;
      this.depth = 0;
      this.channels = 0;
      MarkerDetector markerDetector2 = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 181, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarkerDetector()
      : this(new MarkerDetector.Settings())
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 97, (byte) 83, (byte) 135, (byte) 114, (byte) 188, (byte) 105, (byte) 156, (byte) 105, (byte) 113, (byte) 168, (byte) 255, (byte) 80, (byte) 71, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Marker[] detect(object image, bool whiteMarkers)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (MarkerDetector), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      int num1 = whiteMarkers ? 1 : 0;
      this.init(image);
      if (this.depth != 8 && this.channels > 1)
      {
        object obj = this.tempsrc2;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }
      else if (this.depth != 8)
      {
        object obj = this.tempsrc;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }
      else
      {
        if (this.channels > 1)
        {
          object ca1 = image;
          object obj = this.tempsrc;
          int num2 = 6;
          object ca2 = obj;
          int i = num2;
          opencv_imgproc.cvCvtColor(ca1, ca2, i);
          image = this.tempsrc;
        }
        object src = image;
        object obj1 = this.sumimage;
        object obj2 = this.sqsumimage;
        object obj3 = this.binarized;
        int num3 = num1;
        int num4 = this.settings.binarizationWindowMin;
        int num5 = this.settings.binarizationWindowMax;
        double num6 = this.settings.binarizationVarianceMultiplier;
        double num7 = num1 == 0 ? this.settings.binarizationKBlackMarkers : this.settings.binarizationKWhiteMarkers;
        double num8 = num6;
        int num9 = num5;
        int num10 = num4;
        bool flag = num3 != 0;
        object obj4 = obj3;
        object obj5 = obj2;
        object sumimage = obj1;
        object sqsumimage = obj5;
        object dst = obj4;
        int num11 = flag ? 1 : 0;
        int minwindow = num10;
        int maxwindow = num9;
        double varmultiplier = num8;
        double k = num7;
        JavaCV.adaptiveBinarization(src, sumimage, sqsumimage, dst, num11 != 0, minwindow, maxwindow, varmultiplier, k);
        int[] numArray = new int[1];
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.ARToolKitPlus$ARMarkerInfo");
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 72, (byte) 113, (byte) 114, (byte) 102, (byte) 104, (byte) 124, (byte) 126, (byte) 243, (byte) 79, (byte) 101, (byte) 133, (byte) 255, (byte) 10, (byte) 80})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(object image, Marker[] markers)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (MarkerDetector), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      Marker[] markerArray = markers;
      int length = markerArray.Length;
      int index = 0;
      if (index >= length)
        return;
      Marker marker = markerArray[index];
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      if (num3 < 4)
      {
        int num4 = (int) Math.round(marker.corners[num3 * 2] * 65536.0);
        int num5 = (int) Math.round(marker.corners[num3 * 2 + 1] * 65536.0);
        object obj = this.pts;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvPoint");
      }
      else
      {
        int num4 = num1 / 4;
        int num5 = num2 / 4;
        object obj = this.pts;
        new int[1][0] = 4;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }
    }

    [LineNumberTable(new byte[] {(byte) 52, (byte) 103, (byte) 123, (byte) 109, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSettings(MarkerDetector.Settings settings)
    {
      this.settings = settings;
      this.subPixelSize = opencv_core.cvSize(settings.subPixelWindow / 2, settings.subPixelWindow / 2);
      this.subPixelZeroZone = opencv_core.cvSize(-1, -1);
      this.subPixelTermCriteria = opencv_core.cvTermCriteria(2, 100, 0.001);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 112, (byte) 145, (byte) 244, (byte) 69})]
    private void init([In] object obj0)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj0, __typeref (MarkerDetector), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      if (this.tracker != null)
      {
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }
      else
      {
        MarkerDetector markerDetector = this;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }
    }

    public virtual MarkerDetector.Settings getSettings()
    {
      return this.settings;
    }

    public virtual object getBinarized()
    {
      return this.binarized;
    }

    [InnerClass]
    [SourceFile("MarkerDetector.java")]
    [Serializable]
    public class Settings : BaseChildSettings
    {
      internal int binarizationWindowMin;
      internal int binarizationWindowMax;
      internal double binarizationVarianceMultiplier;
      internal double binarizationKBlackMarkers;
      internal double binarizationKWhiteMarkers;
      internal int subPixelWindow;

      [LineNumberTable(new byte[] {(byte) 159, (byte) 188, (byte) 104, (byte) 103, (byte) 104, (byte) 108, (byte) 112, (byte) 108})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings()
      {
        MarkerDetector.Settings settings = this;
        this.binarizationWindowMin = 5;
        this.binarizationWindowMax = 63;
        this.binarizationVarianceMultiplier = 1.0;
        this.binarizationKBlackMarkers = 0.6;
        this.binarizationKWhiteMarkers = 1.0;
        this.subPixelWindow = 11;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected Settings([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      public virtual int getBinarizationWindowMin()
      {
        return this.binarizationWindowMin;
      }

      public virtual void setBinarizationWindowMin(int binarizationWindowMin)
      {
        this.binarizationWindowMin = binarizationWindowMin;
      }

      public virtual int getBinarizationWindowMax()
      {
        return this.binarizationWindowMax;
      }

      public virtual void setBinarizationWindowMax(int binarizationWindowMax)
      {
        this.binarizationWindowMax = binarizationWindowMax;
      }

      public virtual double getBinarizationVarianceMultiplier()
      {
        return this.binarizationVarianceMultiplier;
      }

      public virtual void setBinarizationVarianceMultiplier(double binarizationVarianceMultiplier)
      {
        this.binarizationVarianceMultiplier = binarizationVarianceMultiplier;
      }

      public virtual double getBinarizationKBlackMarkers()
      {
        return this.binarizationKBlackMarkers;
      }

      public virtual void setBinarizationKBlackMarkers(double binarizationKBlackMarkers)
      {
        this.binarizationKBlackMarkers = binarizationKBlackMarkers;
      }

      public virtual double getBinarizationKWhiteMarkers()
      {
        return this.binarizationKWhiteMarkers;
      }

      public virtual void setBinarizationKWhiteMarkers(double binarizationKWhiteMarkers)
      {
        this.binarizationKWhiteMarkers = binarizationKWhiteMarkers;
      }

      public virtual int getSubPixelWindow()
      {
        return this.subPixelWindow;
      }

      public virtual void setSubPixelWindow(int subPixelWindow)
      {
        this.subPixelWindow = subPixelWindow;
      }
    }
  }
}
