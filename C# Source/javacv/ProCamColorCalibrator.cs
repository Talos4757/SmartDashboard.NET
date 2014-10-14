// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ProCamColorCalibrator
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacv
{
  public class ProCamColorCalibrator : Object
  {
    [Modifiers]
    internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<ProCamColorCalibrator>.Value).desiredAssertionStatus();
    private ProCamColorCalibrator.Settings settings;
    private MarkerDetector markerDetector;
    private MarkedPlane boardPlane;
    private CameraDevice camera;
    private ProjectorDevice projector;
    private Color[] projectorColors;
    private Color[] cameraColors;
    private int counter;
    private object boardSrcPts;
    private object boardDstPts;
    private object projSrcPts;
    private object projDstPts;
    private object camKinv;
    private object mask;
    private object mask2;
    private object undistImage;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal H3x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal R3x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal t3x1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal n3x1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal z3x1;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 245, (byte) 160, (byte) 158})]
    static ProCamColorCalibrator()
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 232, (byte) 122, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 110, (byte) 231, (byte) 2, (byte) 103, (byte) 108, (byte) 103, (byte) 104, (byte) 136, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProCamColorCalibrator(ProCamColorCalibrator.Settings settings, MarkerDetector.Settings detectorSettings, MarkedPlane boardPlane, CameraDevice camera, ProjectorDevice projector)
    {
      base.\u002Ector();
      ProCamColorCalibrator camColorCalibrator1 = this;
      this.markerDetector = (MarkerDetector) null;
      this.boardPlane = (MarkedPlane) null;
      this.camera = (CameraDevice) null;
      this.projector = (ProjectorDevice) null;
      this.projectorColors = (Color[]) null;
      this.cameraColors = (Color[]) null;
      this.counter = 0;
      this.settings = settings;
      this.markerDetector = new MarkerDetector(detectorSettings);
      this.boardPlane = boardPlane;
      this.camera = camera;
      this.projector = projector;
      Marker[] markers = boardPlane.getMarkers();
      ProCamColorCalibrator camColorCalibrator2 = this;
      int num = 4 + markers.Length * 4;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 60, (byte) 120, (byte) 108, (byte) 107, (byte) 112, (byte) 112, (byte) 111, (byte) 108, (byte) 109, (byte) 123, (byte) 123, (byte) 124, (byte) 246, (byte) 58, (byte) 233, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Color[] getProjectorColors()
    {
      double num1 = 1.0 / this.projector.getSettings().getResponseGamma();
      int num2 = this.settings.samplesPerChannel;
      if (this.projectorColors == null)
      {
        this.projectorColors = new Color[num2 * num2 * num2];
        this.cameraColors = new Color[num2 * num2 * num2];
        for (int index = 0; index < this.projectorColors.Length; ++index)
        {
          int num3 = index;
          int num4 = num2;
          int num5 = -1;
          int num6 = num4 != num5 ? num3 / num4 : -num3;
          int num7 = num6;
          int num8 = num2;
          int num9 = -1;
          int num10 = num8 != num9 ? num7 / num8 : -num7;
          int num11 = index;
          int num12 = num2;
          int num13 = -1;
          double num14 = Math.pow((num12 != num13 ? (double) (num11 % num12) : 0.0) / (double) (num2 - 1), num1);
          int num15 = num6;
          int num16 = num2;
          int num17 = -1;
          double num18 = Math.pow((num16 != num17 ? (double) (num15 % num16) : 0.0) / (double) (num2 - 1), num1);
          int num19 = num10;
          int num20 = num2;
          int num21 = -1;
          double num22 = Math.pow((num20 != num21 ? (double) (num19 % num20) : 0.0) / (double) (num2 - 1), num1);
          this.projectorColors[index] = new Color((float) num14, (float) num18, (float) num22);
        }
      }
      return this.projectorColors;
    }

    public virtual Color[] getCameraColors()
    {
      return this.cameraColors;
    }

    public virtual int getColorCount()
    {
      return this.counter;
    }

    [LineNumberTable((ushort) 127)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Color getProjectorColor()
    {
      return this.getProjectorColors()[this.counter];
    }

    [LineNumberTable((ushort) 134)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Color getCameraColor()
    {
      return this.getCameraColors()[this.counter];
    }

    [LineNumberTable(new byte[] {(byte) 88, (byte) 110})]
    public virtual void addCameraColor()
    {
      ++this.counter;
    }

    [LineNumberTable(new byte[] {(byte) 91, (byte) 123})]
    public virtual void addCameraColor(Color color)
    {
      Color[] colorArray = this.cameraColors;
      ProCamColorCalibrator camColorCalibrator1 = this;
      int num = camColorCalibrator1.counter;
      ProCamColorCalibrator camColorCalibrator2 = camColorCalibrator1;
      int index = num;
      camColorCalibrator2.counter = num + 1;
      Color color1 = color;
      colorArray[index] = color1;
    }

    public virtual object getMaskImage()
    {
      return this.mask;
    }

    public virtual object getUndistortedCameraImage()
    {
      return this.undistImage;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 93, (byte) 81, (byte) 217})]
    public virtual bool processCameraImage(object cameraImage)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(cameraImage, __typeref (ProCamColorCalibrator), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      if (this.undistImage != null)
      {
        object obj = this.undistImage;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }
      else
      {
        ProCamColorCalibrator camColorCalibrator = this;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 204, (byte) 103, (byte) 103, (byte) 156, (byte) 113, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double calibrate()
    {
      Color[] cameraColors = this.getCameraColors();
      Color[] projectorColors = this.getProjectorColors();
      if (!ProCamColorCalibrator.\u0024assertionsDisabled && this.counter != projectorColors.Length)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new AssertionError();
      }
      else
      {
        ColorCalibrator.__\u003Cclinit\u003E();
        this.projector.avgColorErr = new ColorCalibrator((ProjectiveDevice) this.projector).calibrate(cameraColors, projectorColors);
        CameraDevice cameraDevice = this.camera;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
    }

    [InnerClass]
    [SourceFile("ProCamColorCalibrator.java")]
    [Serializable]
    public class Settings : BaseChildSettings
    {
      internal int samplesPerChannel;
      internal double trimmingFraction;
      internal double detectedBoardMin;

      [LineNumberTable(new byte[] {(byte) 14, (byte) 104, (byte) 103, (byte) 112})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings()
      {
        ProCamColorCalibrator.Settings settings = this;
        this.samplesPerChannel = 4;
        this.trimmingFraction = 0.01;
        this.detectedBoardMin = 0.5;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected Settings([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      public virtual int getSamplesPerChannel()
      {
        return this.samplesPerChannel;
      }

      public virtual void setSamplesPerChannel(int samplesPerChannel)
      {
        this.samplesPerChannel = samplesPerChannel;
      }

      public virtual double getDetectedBoardMin()
      {
        return this.detectedBoardMin;
      }

      public virtual void setDetectedBoardMin(double detectedBoardMin)
      {
        this.detectedBoardMin = detectedBoardMin;
      }
    }
  }
}
