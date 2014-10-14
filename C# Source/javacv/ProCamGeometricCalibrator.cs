// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ProCamGeometricCalibrator
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

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
using System.Threading;

namespace com.googlecode.javacv
{
  public class ProCamGeometricCalibrator : Object
  {
    [Modifiers]
    internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<ProCamGeometricCalibrator>.Value).desiredAssertionStatus();
    [Modifiers]
    private int MSB_IMAGE_SHIFT;
    [Modifiers]
    private int LSB_IMAGE_SHIFT;
    private ProCamGeometricCalibrator.Settings settings;
    private MarkerDetector.Settings detectorSettings;
    private GeometricCalibrator[] cameraCalibrators;
    private MarkerDetector[] markerDetectors;
    [Signature("[Ljava/util/LinkedList<[Lcom/googlecode/javacv/Marker;>;")]
    internal LinkedList[] allImagedBoardMarkers;
    private object grayscaleImage;
    private object tempImage1;
    private object tempImage2;
    private Marker[][] lastDetectedMarkers1;
    private Marker[][] lastDetectedMarkers2;
    private double[] rmseBoardWarp;
    private double[] rmseProjWarp;
    private object boardWarp;
    private object projWarp;
    private object prevBoardWarp;
    private object lastBoardWarp;
    private object tempPts1;
    private object tempPts2;
    private bool updatePrewarp;
    [Modifiers]
    private MarkedPlane boardPlane;
    [Modifiers]
    private MarkedPlane projectorPlane;
    [Modifiers]
    private GeometricCalibrator projectorCalibrator;
    [Modifiers]
    private object boardWarpSrcPts;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal tempWarp3x3;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 245, (byte) 161, (byte) 19})]
    static ProCamGeometricCalibrator()
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 188, (byte) 232, (byte) 123, (byte) 238, (byte) 112, (byte) 231, (byte) 159, (byte) 150, (byte) 103, (byte) 103, (byte) 103, (byte) 136, (byte) 104, (byte) 100, (byte) 140, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProCamGeometricCalibrator(ProCamGeometricCalibrator.Settings settings, MarkerDetector.Settings detectorSettings, MarkedPlane boardPlane, MarkedPlane projectorPlane, GeometricCalibrator[] cameraCalibrators, GeometricCalibrator projectorCalibrator)
    {
      base.\u002Ector();
      ProCamGeometricCalibrator geometricCalibrator1 = this;
      this.MSB_IMAGE_SHIFT = 8;
      this.LSB_IMAGE_SHIFT = 7;
      this.updatePrewarp = false;
      this.settings = settings;
      this.detectorSettings = detectorSettings;
      this.boardPlane = boardPlane;
      this.projectorPlane = projectorPlane;
      this.cameraCalibrators = cameraCalibrators;
      int length = cameraCalibrators.Length;
      this.markerDetectors = new MarkerDetector[length];
      this.allImagedBoardMarkers = new LinkedList[length];
      ProCamGeometricCalibrator geometricCalibrator2 = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 180, (byte) 223, (byte) 12})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProCamGeometricCalibrator(ProCamGeometricCalibrator.Settings settings, MarkerDetector.Settings detectorSettings, MarkedPlane boardPlane, MarkedPlane projectorPlane, ProjectiveDevice camera, ProjectiveDevice projector)
    {
      ProCamGeometricCalibrator.Settings settings1 = settings;
      MarkerDetector.Settings detectorSettings1 = detectorSettings;
      MarkedPlane boardPlane1 = boardPlane;
      MarkedPlane projectorPlane1 = projectorPlane;
      GeometricCalibrator[] cameraCalibrators = new GeometricCalibrator[1];
      int index = 0;
      GeometricCalibrator geometricCalibrator = new GeometricCalibrator((GeometricCalibrator.Settings) settings, detectorSettings, boardPlane, camera);
      cameraCalibrators[index] = geometricCalibrator;
      GeometricCalibrator projectorCalibrator = new GeometricCalibrator((GeometricCalibrator.Settings) settings, detectorSettings, projectorPlane, projector);
      // ISSUE: explicit constructor call
      this.\u002Ector(settings1, detectorSettings1, boardPlane1, projectorPlane1, cameraCalibrators, projectorCalibrator);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    [LineNumberTable((ushort) 34)]
    internal static object access\u0024000([In] ProCamGeometricCalibrator obj0)
    {
      return obj0.grayscaleImage;
    }

    [Modifiers]
    [LineNumberTable((ushort) 34)]
    internal static object access\u0024100([In] ProCamGeometricCalibrator obj0)
    {
      return obj0.tempImage1;
    }

    [Modifiers]
    [LineNumberTable((ushort) 34)]
    internal static Marker[][] access\u0024200([In] ProCamGeometricCalibrator obj0)
    {
      return obj0.lastDetectedMarkers1;
    }

    [Modifiers]
    [LineNumberTable((ushort) 34)]
    internal static GeometricCalibrator[] access\u0024300([In] ProCamGeometricCalibrator obj0)
    {
      return obj0.cameraCalibrators;
    }

    [Modifiers]
    [LineNumberTable((ushort) 34)]
    internal static object access\u0024400([In] ProCamGeometricCalibrator obj0)
    {
      return obj0.tempImage2;
    }

    [Modifiers]
    [LineNumberTable((ushort) 34)]
    internal static Marker[][] access\u0024500([In] ProCamGeometricCalibrator obj0)
    {
      return obj0.lastDetectedMarkers2;
    }

    [Modifiers]
    [LineNumberTable((ushort) 34)]
    internal static MarkerDetector[] access\u0024600([In] ProCamGeometricCalibrator obj0)
    {
      return obj0.markerDetectors;
    }

    [LineNumberTable((ushort) 182)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Marker[][] processCameraImage(object cameraImage, int cameraNumber)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(cameraImage, __typeref (ProCamGeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      this.cameraCalibrators[cameraNumber].getProjectiveDevice();
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable((ushort) 253)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool processMarkers(int cameraNumber)
    {
      return (this.processMarkers(this.lastDetectedMarkers1[cameraNumber], this.lastDetectedMarkers2[cameraNumber], cameraNumber) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 82, (byte) 177, (byte) 157, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawMarkers(object image, int cameraNumber)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (ProCamGeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      this.cameraCalibrators[cameraNumber].markerDetector.draw(image, this.lastDetectedMarkers1[cameraNumber]);
      this.projectorCalibrator.markerDetector.draw(image, this.lastDetectedMarkers2[cameraNumber]);
    }

    [LineNumberTable((ushort) 261)]
    public virtual bool processMarkers(Marker[] imagedBoardMarkers, Marker[] imagedProjectorMarkers, int cameraNumber)
    {
      double[] numArray = this.rmseBoardWarp;
      MarkedPlane markedPlane = this.boardPlane;
      object obj = this.boardWarp;
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$CvMat;");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 189, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addMarkers(int cameraNumber)
    {
      this.addMarkers(this.lastDetectedMarkers1[cameraNumber], this.lastDetectedMarkers2[cameraNumber], cameraNumber);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 198, (byte) 154, (byte) 109, (byte) 153, (byte) 177, (byte) 104, (byte) 103, (byte) 43, (byte) 166, (byte) 242, (byte) 93, (byte) 114, (byte) 103, (byte) 53, (byte) 198, (byte) 113, (byte) 141, (byte) 159, (byte) 0, (byte) 115, (byte) 147, (byte) 109, (byte) 107, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addMarkers(Marker[] imagedBoardMarkers, Marker[] imagedProjectorMarkers, int cameraNumber)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(ProCamGeometricCalibrator.tempWarp3x3.get(), __typeref (ProCamGeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      if (!this.settings.addIntersectionOnly)
      {
        this.cameraCalibrators[cameraNumber].addMarkers(this.boardPlane.getMarkers(), imagedBoardMarkers);
        this.allImagedBoardMarkers[cameraNumber].add((object) imagedBoardMarkers);
        Marker[] markerArray = new Marker[this.projectorPlane.getMarkers().Length];
        for (int index = 0; index < markerArray.Length; ++index)
          markerArray[index] = this.projectorPlane.getMarkers()[index].clone();
        Marker.applyWarp(markerArray, this.projectorPlane.getPrewarp());
        GeometricCalibrator geometricCalibrator;
        Monitor.Enter((object) (geometricCalibrator = this.projectorCalibrator));
        while (true)
        {
          // ISSUE: fault handler
          try
          {
            int imageCount = this.projectorCalibrator.getImageCount();
            int length = this.cameraCalibrators.Length;
            int num = -1;
            if ((length != num ? imageCount % length : 0) < cameraNumber)
            {
              try
              {
                Object.instancehelper_wait((object) this.projectorCalibrator);
              }
              catch (InterruptedException ex)
              {
              }
            }
            else
              break;
          }
          __fault
          {
            Monitor.Exit((object) geometricCalibrator);
          }
        }
        try
        {
          this.projectorCalibrator.addMarkers(imagedProjectorMarkers, markerArray);
          Object.instancehelper_notify((object) this.projectorCalibrator);
        }
        finally
        {
          Monitor.Exit((object) geometricCalibrator);
        }
        object obj = this.boardWarp;
        throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$CvMat;");
      }
      else
      {
        Marker[] markerArray = new Marker[imagedBoardMarkers.Length];
        for (int index = 0; index < markerArray.Length; ++index)
          markerArray[index] = imagedBoardMarkers[index].clone();
        object obj = this.projWarp;
        throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$CvMat;");
      }
    }

    [LineNumberTable((ushort) 398)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double[] calibrate(bool useCenters, bool calibrateCameras)
    {
      return this.calibrate(useCenters, calibrateCameras);
    }

    public virtual MarkedPlane getBoardPlane()
    {
      return this.boardPlane;
    }

    public virtual MarkedPlane getProjectorPlane()
    {
      return this.projectorPlane;
    }

    public virtual GeometricCalibrator[] getCameraCalibrators()
    {
      return this.cameraCalibrators;
    }

    public virtual GeometricCalibrator getProjectorCalibrator()
    {
      return this.projectorCalibrator;
    }

    [LineNumberTable(new byte[] {(byte) 121, (byte) 124, (byte) 117, (byte) 60, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getImageCount()
    {
      int imageCount = this.projectorCalibrator.getImageCount();
      int length1 = this.cameraCalibrators.Length;
      int num1 = -1;
      int num2 = length1 != num1 ? imageCount / length1 : -imageCount;
      GeometricCalibrator[] geometricCalibratorArray = this.cameraCalibrators;
      int length2 = geometricCalibratorArray.Length;
      for (int index = 0; index < length2; ++index)
      {
        GeometricCalibrator geometricCalibrator = geometricCalibratorArray[index];
        if (!ProCamGeometricCalibrator.\u0024assertionsDisabled && geometricCalibrator.getImageCount() != num2)
        {
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new AssertionError();
        }
      }
      return num2;
    }

    [LineNumberTable((ushort) 179)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Marker[][] processCameraImage(object cameraImage)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(cameraImage, __typeref (ProCamGeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      return this.processCameraImage(cameraImage, 0);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 82, (byte) 81, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawMarkers(object image)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (ProCamGeometricCalibrator), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      this.drawMarkers(image, 0);
    }

    [LineNumberTable((ushort) 250)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool processMarkers()
    {
      return (this.processMarkers(0) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 257)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool processMarkers(Marker[] imagedBoardMarkers, Marker[] imagedProjectorMarkers)
    {
      return (this.processMarkers(imagedBoardMarkers, imagedProjectorMarkers, 0) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 186, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addMarkers()
    {
      this.addMarkers(0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 192, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addMarkers(Marker[] imagedBoardMarkers, Marker[] imagedProjectorMarkers)
    {
      this.addMarkers(imagedBoardMarkers, imagedProjectorMarkers, 0);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 5, (byte) 139, (byte) 106, (byte) 98, (byte) 108, (byte) 115, (byte) 100, (byte) 98, (byte) 226, (byte) 60, (byte) 230, (byte) 73, (byte) 108, (byte) 242, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getProjectorImage()
    {
      if (this.updatePrewarp)
      {
        double num1 = double.MaxValue;
        int num2 = 0;
        for (int index = 0; index < this.cameraCalibrators.Length; ++index)
        {
          double num3 = this.rmseBoardWarp[index] + this.rmseProjWarp[index];
          if (num3 < num1)
          {
            num1 = num3;
            num2 = index;
          }
        }
        this.projectorPlane.getPrewarp();
        object obj = this.projWarp;
        throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$CvMat;");
      }
      else
        return this.projectorPlane.getImage();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 42, (byte) 132, (byte) 169, (byte) 99, (byte) 108, (byte) 111, (byte) 107, (byte) 240, (byte) 61, (byte) 230, (byte) 77, (byte) 109, (byte) 103, (byte) 103, (byte) 103, (byte) 137, (byte) 110, (byte) 110, (byte) 51, (byte) 232, (byte) 70, (byte) 108, (byte) 113, (byte) 223, (byte) 33, (byte) 113, (byte) 110, (byte) 106, (byte) 170, (byte) 106, (byte) 127, (byte) 0, (byte) 31, (byte) 2, (byte) 200, (byte) 106, (byte) 127, (byte) 0, (byte) 31, (byte) 2, (byte) 232, (byte) 71, (byte) 255, (byte) 1, (byte) 83, (byte) 109, (byte) 238, (byte) 70, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 207, (byte) 109, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double[] calibrate(bool useCenters, bool calibrateCameras, int cameraAtOrigin)
    {
      int num1 = calibrateCameras ? 1 : 0;
      int num2 = useCenters ? 1 : 0;
      GeometricCalibrator geometricCalibrator = this.cameraCalibrators[cameraAtOrigin];
      if (num1 != 0)
      {
        for (int index = 0; index < this.cameraCalibrators.Length; ++index)
        {
          this.cameraCalibrators[index].calibrate(num2 != 0);
          if (this.cameraCalibrators[index] != geometricCalibrator)
            geometricCalibrator.calibrateStereo(num2 != 0, this.cameraCalibrators[index]);
        }
      }
      LinkedList allObjectMarkers1 = this.projectorCalibrator.getAllObjectMarkers();
      LinkedList allImageMarkers1 = new LinkedList();
      LinkedList allObjectMarkers2 = new LinkedList();
      LinkedList allObjectMarkers3 = new LinkedList();
      Iterator iterator = ((AbstractSequentialList) allObjectMarkers1).iterator();
      Iterator[] iteratorArray = new Iterator[this.cameraCalibrators.Length];
      for (int index = 0; index < this.cameraCalibrators.Length; ++index)
        iteratorArray[index] = ((AbstractSequentialList) this.allImagedBoardMarkers[index]).iterator();
      while (iterator.hasNext())
      {
        int index1 = 0;
        if (index1 < this.cameraCalibrators.Length)
        {
          double num3 = this.settings.prewarpUpdateErrorMax * (double) (this.cameraCalibrators[index1].getProjectiveDevice().imageWidth + this.cameraCalibrators[index1].getProjectiveDevice().imageHeight) / 2.0;
          Marker[] markerArray1 = (Marker[]) iteratorArray[index1].next();
          Marker[] markerArray2 = (Marker[]) iterator.next();
          Marker[] markerArray3 = new Marker[markerArray1.Length];
          Marker[] markerArray4 = new Marker[markerArray2.Length];
          for (int index2 = 0; index2 < markerArray1.Length; ++index2)
          {
            Marker[] markerArray5 = markerArray3;
            int num4 = index2;
            Marker marker1 = markerArray1[index2].clone();
            int index3 = num4;
            Marker[] markerArray6 = markerArray5;
            Marker marker2 = marker1;
            markerArray6[index3] = marker1;
            Marker marker3 = marker2;
            marker3.corners = this.cameraCalibrators[index1].getProjectiveDevice().undistort(marker3.corners);
          }
          for (int index2 = 0; index2 < markerArray2.Length; ++index2)
          {
            Marker[] markerArray5 = markerArray4;
            int num4 = index2;
            Marker marker1 = markerArray2[index2].clone();
            int index3 = num4;
            Marker[] markerArray6 = markerArray5;
            Marker marker2 = marker1;
            markerArray6[index3] = marker1;
            Marker marker3 = marker2;
            marker3.corners = this.cameraCalibrators[index1].getProjectiveDevice().undistort(marker3.corners);
          }
          MarkedPlane markedPlane = this.boardPlane;
          object obj = this.boardWarp;
          throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$CvMat;");
        }
      }
      this.projectorCalibrator.setAllObjectMarkers(allObjectMarkers2);
      double[] numArray1 = this.projectorCalibrator.calibrate(num2 != 0);
      LinkedList allObjectMarkers4 = geometricCalibrator.getAllObjectMarkers();
      LinkedList allImageMarkers2 = geometricCalibrator.getAllImageMarkers();
      geometricCalibrator.setAllObjectMarkers(allObjectMarkers3);
      geometricCalibrator.setAllImageMarkers(allImageMarkers1);
      double[] numArray2 = geometricCalibrator.calibrateStereo(num2 != 0, this.projectorCalibrator);
      this.projectorCalibrator.setAllObjectMarkers(allObjectMarkers1);
      geometricCalibrator.setAllObjectMarkers(allObjectMarkers4);
      geometricCalibrator.setAllImageMarkers(allImageMarkers2);
      double[] numArray3 = new double[4];
      int index4 = 0;
      double num5 = numArray1[0];
      numArray3[index4] = num5;
      int index5 = 1;
      double num6 = numArray1[1];
      numArray3[index5] = num6;
      int index6 = 2;
      double num7 = numArray2[0];
      numArray3[index6] = num7;
      int index7 = 3;
      double num8 = numArray2[1];
      numArray3[index7] = num8;
      return numArray3;
    }

    [InnerClass]
    [SourceFile("ProCamGeometricCalibrator.java")]
    [Serializable]
    public class Settings : GeometricCalibrator.Settings
    {
      internal double detectedProjectorMin;
      internal bool addIntersectionOnly;
      internal double prewarpUpdateErrorMax;

      [LineNumberTable(new byte[] {(byte) 59, (byte) 104, (byte) 112, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings()
      {
        ProCamGeometricCalibrator.Settings settings = this;
        this.detectedProjectorMin = 0.5;
        this.addIntersectionOnly = true;
        this.prewarpUpdateErrorMax = 0.01;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected Settings([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      public virtual double getDetectedProjectorMin()
      {
        return this.detectedProjectorMin;
      }

      public virtual void setDetectedProjectorMin(double detectedProjectorMin)
      {
        this.detectedProjectorMin = detectedProjectorMin;
      }

      public virtual bool isAddIntersectionOnly()
      {
        return this.addIntersectionOnly;
      }

      public virtual void setAddIntersectionOnly(bool addIntersectionOnly)
      {
        this.addIntersectionOnly = addIntersectionOnly;
      }

      public virtual double getPrewarpUpdateErrorMax()
      {
        return this.prewarpUpdateErrorMax;
      }

      public virtual void setPrewarpUpdateErrorMax(double prewarpUpdateErrorMax)
      {
        this.prewarpUpdateErrorMax = prewarpUpdateErrorMax;
      }
    }
  }
}
