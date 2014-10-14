// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ImageAligner
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacv
{
  public interface ImageAligner
  {
    ImageAligner.Settings getSettings();

    void setSettings(ImageAligner.Settings ias);

    object getTemplateImage();

    void setTemplateImage(object ii, double[] darr);

    object getTargetImage();

    void setTargetImage(object ii);

    int getPyramidLevel();

    void setPyramidLevel(int i);

    ImageTransformer.Parameters getParameters();

    void setParameters(ImageTransformer.Parameters itp);

    double[] getTransformedRoiPts();

    object getTransformedImage();

    object getResidualImage();

    object getRoiMaskImage();

    double getRMSE();

    object getRoi();

    bool iterate(double[] darr);

    [InnerClass]
    [Implements(new string[] {"java.lang.Cloneable"})]
    [SourceFile("ImageAligner.java")]
    [Serializable]
    class Settings : BaseChildSettings, Cloneable.__Interface
    {
      internal int pyramidLevels;
      internal object gammaTgamma;
      internal double tikhonovAlpha;
      internal bool constrained;
      internal double[] zeroThresholds;
      internal double[] outlierThresholds;

      [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 232, (byte) 73, (byte) 103, (byte) 103, (byte) 108, (byte) 103, (byte) 127, (byte) 37, (byte) 248, (byte) 51, (byte) 108, (byte) 108, (byte) 109, (byte) 108, (byte) 108, (byte) 108})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings(ImageAligner.Settings s)
      {
        ImageAligner.Settings settings = this;
        this.pyramidLevels = 5;
        this.gammaTgamma = (object) null;
        this.tikhonovAlpha = 0.0;
        this.constrained = false;
        double[] numArray1 = new double[5];
        int index1 = 0;
        double num1 = 0.04;
        numArray1[index1] = num1;
        int index2 = 1;
        double num2 = 0.03;
        numArray1[index2] = num2;
        int index3 = 2;
        double num3 = 0.02;
        numArray1[index3] = num3;
        int index4 = 3;
        double num4 = 0.01;
        numArray1[index4] = num4;
        int index5 = 4;
        double num5 = 0.0;
        numArray1[index5] = num5;
        this.zeroThresholds = numArray1;
        double[] numArray2 = new double[1];
        int index6 = 0;
        double num6 = 0.1;
        numArray2[index6] = num6;
        this.outlierThresholds = numArray2;
        this.pyramidLevels = s.pyramidLevels;
        this.gammaTgamma = s.gammaTgamma;
        this.tikhonovAlpha = s.tikhonovAlpha;
        this.constrained = s.constrained;
        this.zeroThresholds = s.zeroThresholds;
        this.outlierThresholds = s.outlierThresholds;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 232, (byte) 74, (byte) 103, (byte) 103, (byte) 108, (byte) 103, (byte) 127, (byte) 37, (byte) 248, (byte) 49})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings()
      {
        ImageAligner.Settings settings = this;
        this.pyramidLevels = 5;
        this.gammaTgamma = (object) null;
        this.tikhonovAlpha = 0.0;
        this.constrained = false;
        double[] numArray1 = new double[5];
        int index1 = 0;
        double num1 = 0.04;
        numArray1[index1] = num1;
        int index2 = 1;
        double num2 = 0.03;
        numArray1[index2] = num2;
        int index3 = 2;
        double num3 = 0.02;
        numArray1[index3] = num3;
        int index4 = 3;
        double num4 = 0.01;
        numArray1[index4] = num4;
        int index5 = 4;
        double num5 = 0.0;
        numArray1[index5] = num5;
        this.zeroThresholds = numArray1;
        double[] numArray2 = new double[1];
        int index6 = 0;
        double num6 = 0.1;
        numArray2[index6] = num6;
        this.outlierThresholds = numArray2;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected Settings([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [HideFromJava]
      public static implicit operator Cloneable([In] ImageAligner.Settings obj0)
      {
        Cloneable cloneable;
        cloneable.__\u003Cref\u003E = (__Null) obj0;
        return cloneable;
      }

      [LineNumberTable((ushort) 94)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual ImageAligner.Settings clone()
      {
        return new ImageAligner.Settings(this);
      }

      public virtual int getPyramidLevels()
      {
        return this.pyramidLevels;
      }

      public virtual void setPyramidLevels(int pyramidLevels)
      {
        this.pyramidLevels = pyramidLevels;
      }

      public virtual object getGammaTgamma()
      {
        return this.gammaTgamma;
      }

      public virtual void setGammaTgamma(object gammaTgamma)
      {
        // ISSUE: type reference
        ByteCodeHelper.DynamicCast(gammaTgamma, __typeref (ImageAligner.Settings), "com.googlecode.javacv.cpp.opencv_core$CvMat");
        this.gammaTgamma = gammaTgamma;
      }

      public virtual double getTikhonovAlpha()
      {
        return this.tikhonovAlpha;
      }

      public virtual void setTikhonovAlpha(double tikhonovAlpha)
      {
        this.tikhonovAlpha = tikhonovAlpha;
      }

      public virtual double[] getZeroThresholds()
      {
        return this.zeroThresholds;
      }

      public virtual void setZeroThresholds(double[] zeroThresholds)
      {
        this.zeroThresholds = zeroThresholds;
      }

      public virtual double[] getOutlierThresholds()
      {
        return this.outlierThresholds;
      }

      public virtual void setOutlierThresholds(double[] outlierThresholds)
      {
        this.outlierThresholds = outlierThresholds;
      }

      [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
      [Modifiers]
      [EditorBrowsable(EditorBrowsableState.Never)]
      [LineNumberTable((ushort) 33)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object \u003Cbridge\u003Eclone()
      {
        return (object) this.clone();
      }
    }
  }
}
