// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.HandMouse
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.nio;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacv
{
  public class HandMouse : Object
  {
    private HandMouse.Settings settings;
    private ImageAligner aligner;
    private object thresholdedImage;
    private object storage;
    private object roiPoints;
    private object contourPoints;
    private int roiPointsSize;
    private int contourPointsSize;
    private IntBuffer contourPointsBuffer;
    private object moments;
    private double tipX;
    private double tipY;
    private double prevTipX;
    private double prevTipY;
    private object pt1;
    private object pt2;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 181, (byte) 232, (byte) 160, (byte) 89, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public HandMouse(ImageAligner aligner, HandMouse.Settings settings)
    {
      base.\u002Ector();
      HandMouse handMouse1 = this;
      this.thresholdedImage = (object) null;
      HandMouse handMouse2 = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMemStorage");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 179, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public HandMouse(ImageAligner aligner)
      : this(aligner, new HandMouse.Settings())
    {
    }

    public virtual void setSettings(HandMouse.Settings settings)
    {
      this.settings = settings;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 107, (byte) 113, (byte) 120, (byte) 246, (byte) 70, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void update(object intermediate)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(intermediate, __typeref (HandMouse), "[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
      if (this.aligner.getPyramidLevel() != this.settings.pyramidLevel)
        this.aligner.setPyramidLevel(this.settings.pyramidLevel);
      this.aligner.getRoiMaskImage();
      this.aligner.getResidualImage();
      this.aligner.getTargetImage();
      this.aligner.getTransformedImage();
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 22, (byte) 127, (byte) 21, (byte) 130, (byte) 111, (byte) 111})]
    public virtual bool isClick()
    {
      if (this.tipX < 0.0 || this.tipY < 0.0 || (this.prevTipX < 0.0 || this.prevTipY < 0.0))
        return false;
      double num1 = this.tipX - this.prevTipX;
      double num2 = this.tipY - this.prevTipY;
      object obj = this.thresholdedImage;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    public virtual HandMouse.Settings getSettings()
    {
      return this.settings;
    }

    [LineNumberTable(new byte[] {(byte) 88, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void update()
    {
      this.update((object) null);
    }

    public virtual object getImage()
    {
      return this.thresholdedImage;
    }

    public virtual double getX()
    {
      return this.tipX;
    }

    public virtual double getY()
    {
      return this.tipY;
    }

    [InnerClass]
    [SourceFile("HandMouse.java")]
    [Serializable]
    public class Settings : BaseChildSettings
    {
      internal int mopIterations;
      internal double clickSteadyMax;
      internal double areaMin;
      internal double areaMax;
      internal int pyramidLevel;
      internal double thresholdHigh;
      internal double thresholdLow;
      internal double lightnessMin;

      [LineNumberTable(new byte[] {(byte) 159, (byte) 187, (byte) 232, (byte) 72, (byte) 103, (byte) 112, (byte) 112, (byte) 112, (byte) 103, (byte) 112, (byte) 112, (byte) 240, (byte) 49})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings()
      {
        HandMouse.Settings settings = this;
        this.mopIterations = 1;
        this.clickSteadyMax = 0.005;
        this.areaMin = 0.001;
        this.areaMax = 0.1;
        this.pyramidLevel = 2;
        this.thresholdHigh = 0.5;
        this.thresholdLow = 0.25;
        this.lightnessMin = 0.1;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 188, (byte) 232, (byte) 71, (byte) 103, (byte) 112, (byte) 112, (byte) 112, (byte) 103, (byte) 112, (byte) 112, (byte) 240, (byte) 51, (byte) 108, (byte) 109, (byte) 109, (byte) 109})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings(HandMouse.Settings s)
      {
        HandMouse.Settings settings = this;
        this.mopIterations = 1;
        this.clickSteadyMax = 0.005;
        this.areaMin = 0.001;
        this.areaMax = 0.1;
        this.pyramidLevel = 2;
        this.thresholdHigh = 0.5;
        this.thresholdLow = 0.25;
        this.lightnessMin = 0.1;
        s.mopIterations = this.mopIterations;
        s.clickSteadyMax = this.clickSteadyMax;
        s.areaMin = this.areaMin;
        s.areaMax = this.areaMax;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected Settings([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      public virtual int getMopIterations()
      {
        return this.mopIterations;
      }

      public virtual void setMopIterations(int mopIterations)
      {
        this.mopIterations = mopIterations;
      }

      public virtual double getClickSteadyMax()
      {
        return this.clickSteadyMax;
      }

      public virtual void setClickSteadyMax(double clickSteadyMax)
      {
        this.clickSteadyMax = clickSteadyMax;
      }

      public virtual double getAreaMin()
      {
        return this.areaMin;
      }

      public virtual void setAreaMin(double areaMin)
      {
        this.areaMin = areaMin;
      }

      public virtual double getAreaMax()
      {
        return this.areaMax;
      }

      public virtual void setAreaMax(double areaMax)
      {
        this.areaMax = areaMax;
      }

      public virtual int getPyramidLevel()
      {
        return this.pyramidLevel;
      }

      public virtual void setPyramidLevel(int pyramidLevel)
      {
        this.pyramidLevel = pyramidLevel;
      }

      public virtual double getThresholdHigh()
      {
        return this.thresholdHigh;
      }

      public virtual void setThresholdHigh(double thresholdHigh)
      {
        this.thresholdHigh = thresholdHigh;
      }

      public virtual double getThresholdLow()
      {
        return this.thresholdLow;
      }

      public virtual void setThresholdLow(double thresholdLow)
      {
        this.thresholdLow = thresholdLow;
      }

      public virtual double getLightnessMin()
      {
        return this.lightnessMin;
      }

      public virtual void setLightnessMin(double lightnessMin)
      {
        this.lightnessMin = lightnessMin;
      }
    }
  }
}
