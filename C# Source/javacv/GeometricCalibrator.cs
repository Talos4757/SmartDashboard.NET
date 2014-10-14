// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.GeometricCalibrator
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacv
{
  public class GeometricCalibrator : Object
  {
    [Modifiers]
    internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<GeometricCalibrator>.Value).desiredAssertionStatus();
    private GeometricCalibrator.Settings settings;
    internal MarkerDetector markerDetector;
    private MarkedPlane markedPlane;
    private ProjectiveDevice projectiveDevice;
    [Signature("Ljava/util/LinkedList<[Lcom/googlecode/javacv/Marker;>;")]
    private LinkedList allObjectMarkers;
    [Signature("Ljava/util/LinkedList<[Lcom/googlecode/javacv/Marker;>;")]
    private LinkedList allImageMarkers;
    private object tempImage;
    private Marker[] lastDetectedMarkers;
    private object warp;
    private object prevWarp;
    private object lastWarp;
    private object warpSrcPts;
    private object warpDstPts;
    private object tempPts;

    [LineNumberTable((ushort) 38)]
    static GeometricCalibrator()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 182, (byte) 232, (byte) 112, (byte) 107, (byte) 107, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public GeometricCalibrator(GeometricCalibrator.Settings settings, MarkerDetector.Settings detectorSettings, MarkedPlane markedPlane, ProjectiveDevice projectiveDevice)
    {
      base.\u002Ector();
      GeometricCalibrator geometricCalibrator1 = this;
      this.allObjectMarkers = new LinkedList();
      this.allImageMarkers = new LinkedList();
      this.tempImage = (object) null;
      this.lastDetectedMarkers = (Marker[]) null;
      GeometricCalibrator geometricCalibrator2 = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 106, (byte) 103, (byte) 103, (byte) 98, (byte) 123, (byte) 120, (byte) 112, (byte) 101, (byte) 101, (byte) 100, (byte) 226, (byte) 59, (byte) 40, (byte) 235, (byte) 74, (byte) 100, (byte) 109, (byte) 141, (byte) 109, (byte) 173, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addMarkers(Marker[] objectMarkers, Marker[] imageMarkers)
    {
      int length1 = Math.min(objectMarkers.Length, imageMarkers.Length);
      Marker[] markerArray1 = new Marker[length1];
      Marker[] markerArray2 = new Marker[length1];
      int index1 = 0;
      Marker[] markerArray3 = objectMarkers;
      int length2 = markerArray3.Length;
      for (int index2 = 0; index2 < length2; ++index2)
      {
        Marker marker1 = markerArray3[index2];
        Marker[] markerArray4 = imageMarkers;
        int length3 = markerArray4.Length;
        for (int index3 = 0; index3 < length3; ++index3)
        {
          Marker marker2 = markerArray4[index3];
          if (marker1.id == marker2.id)
          {
            markerArray1[index1] = marker1;
            markerArray2[index1] = marker2;
            ++index1;
            break;
          }
        }
      }
      if (index1 < length1)
      {
        markerArray1 = (Marker[]) Arrays.copyOf((object[]) markerArray1, index1);
        markerArray2 = (Marker[]) Arrays.copyOf((object[]) markerArray2, index1);
      }
      this.allObjectMarkers.add((object) markerArray1);
      this.allImageMarkers.add((object) markerArray2);
      opencv_core.cvCopy(this.prevWarp, this.lastWarp);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 98, (byte) 127, (byte) 11, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object getPoints([In] bool obj0)
    {
      if (!GeometricCalibrator.\u0024assertionsDisabled && this.allObjectMarkers.size() != this.allImageMarkers.size())
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new AssertionError();
      }
      else
      {
        ((AbstractSequentialList) this.allObjectMarkers).iterator();
        ((AbstractSequentialList) this.allImageMarkers).iterator();
        this.allImageMarkers.size();
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
    }

    [LineNumberTable((ushort) 265)]
    public static double[] computeReprojectionError(object object_points, object image_points, object point_counts, object camera_matrix, object dist_coeffs, object rot_vects, object trans_vects, object per_view_errors)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(object_points, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image_points, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(point_counts, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(camera_matrix, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dist_coeffs, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(rot_vects, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(trans_vects, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(per_view_errors, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable((ushort) 378)]
    public static double[] computeStereoError(object imagePoints1, object imagePoints2, object M1, object D1, object M2, object D2, object F)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(imagePoints1, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(imagePoints2, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(M1, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(D1, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(M2, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(D2, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(F, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    public virtual MarkerDetector getMarkerDetector()
    {
      return this.markerDetector;
    }

    public virtual MarkedPlane getMarkedPlane()
    {
      return this.markedPlane;
    }

    public virtual ProjectiveDevice getProjectiveDevice()
    {
      return this.projectiveDevice;
    }

    [Signature("()Ljava/util/LinkedList<[Lcom/googlecode/javacv/Marker;>;")]
    public virtual LinkedList getAllObjectMarkers()
    {
      return this.allObjectMarkers;
    }

    [Signature("(Ljava/util/LinkedList<[Lcom/googlecode/javacv/Marker;>;)V")]
    public virtual void setAllObjectMarkers(LinkedList allObjectMarkers)
    {
      this.allObjectMarkers = allObjectMarkers;
    }

    [Signature("()Ljava/util/LinkedList<[Lcom/googlecode/javacv/Marker;>;")]
    public virtual LinkedList getAllImageMarkers()
    {
      return this.allImageMarkers;
    }

    [Signature("(Ljava/util/LinkedList<[Lcom/googlecode/javacv/Marker;>;)V")]
    public virtual void setAllImageMarkers(LinkedList allImageMarkers)
    {
      this.allImageMarkers = allImageMarkers;
    }

    [LineNumberTable((ushort) 124)]
    public virtual Marker[] processImage(object image)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      ProjectiveDevice projectiveDevice = this.projectiveDevice;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 100, (byte) 81, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawMarkers(object image)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (GeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      this.markerDetector.draw(image, this.lastDetectedMarkers);
    }

    [LineNumberTable(new byte[] {(byte) 122, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addMarkers()
    {
      this.addMarkers(this.markedPlane.getMarkers(), this.lastDetectedMarkers);
    }

    [LineNumberTable(new byte[] {(byte) 125, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addMarkers(Marker[] imageMarkers)
    {
      this.addMarkers(this.markedPlane.getMarkers(), imageMarkers);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 91, (byte) 127, (byte) 11})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getImageCount()
    {
      if (!GeometricCalibrator.\u0024assertionsDisabled && this.allObjectMarkers.size() != this.allImageMarkers.size())
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new AssertionError();
      }
      else
        return this.allObjectMarkers.size();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 206, (byte) 103, (byte) 140, (byte) 104, (byte) 238, (byte) 71, (byte) 109, (byte) 159, (byte) 1, (byte) 130, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double[] calibrate(bool useCenters)
    {
      ProjectiveDevice projectiveDevice = this.projectiveDevice;
      ProjectiveDevice.CalibrationSettings calibrationSettings = (ProjectiveDevice.CalibrationSettings) projectiveDevice.getSettings();
      if (projectiveDevice.cameraMatrix == null)
      {
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
      else
      {
        int num = !calibrationSettings.isFixK3() ? 5 : 4;
        if (calibrationSettings.isRationalModel() && !calibrationSettings.isFixK4() && (!calibrationSettings.isFixK4() && !calibrationSettings.isFixK5()))
          num = 8;
        if (projectiveDevice.distortionCoeffs != null)
        {
          object obj = projectiveDevice.distortionCoeffs;
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
        }
        else
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 41, (byte) 162, (byte) 103, (byte) 103, (byte) 108, (byte) 140, (byte) 104, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double[] calibrateStereo(bool useCenters, GeometricCalibrator peer)
    {
      int num = useCenters ? 1 : 0;
      ProjectiveDevice projectiveDevice1 = this.projectiveDevice;
      ProjectiveDevice projectiveDevice2 = peer.projectiveDevice;
      ProjectiveDevice.CalibrationSettings calibrationSettings1 = (ProjectiveDevice.CalibrationSettings) projectiveDevice1.getSettings();
      ProjectiveDevice.CalibrationSettings calibrationSettings2 = (ProjectiveDevice.CalibrationSettings) projectiveDevice2.getSettings();
      this.getPoints(num != 0);
      peer.getPoints(num != 0);
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$CvMat;");
    }

    [InnerClass]
    [SourceFile("GeometricCalibrator.java")]
    [Serializable]
    public class Settings : BaseChildSettings
    {
      internal double detectedBoardMin;
      internal double patternSteadyMax;
      internal double patternMovedMin;

      [LineNumberTable(new byte[] {(byte) 6, (byte) 104, (byte) 112, (byte) 112})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings()
      {
        GeometricCalibrator.Settings settings = this;
        this.detectedBoardMin = 0.5;
        this.patternSteadyMax = 0.005;
        this.patternMovedMin = 0.05;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected Settings([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      public virtual double getDetectedBoardMin()
      {
        return this.detectedBoardMin;
      }

      public virtual void setDetectedBoardMin(double detectedBoardMin)
      {
        this.detectedBoardMin = detectedBoardMin;
      }

      public virtual double getPatternSteadyMax()
      {
        return this.patternSteadyMax;
      }

      public virtual void setPatternSteadyMax(double patternSteadyMax)
      {
        this.patternSteadyMax = patternSteadyMax;
      }

      public virtual double getPatternMovedMin()
      {
        return this.patternMovedMin;
      }

      public virtual void setPatternMovedMin(double patternMovedMin)
      {
        this.patternMovedMin = patternMovedMin;
      }
    }
  }
}
