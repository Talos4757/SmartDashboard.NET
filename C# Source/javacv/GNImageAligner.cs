// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.GNImageAligner
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacv
{
  [Implements(new string[] {"com.googlecode.javacv.ImageAligner"})]
  public class GNImageAligner : Object, ImageAligner
  {
    private GNImageAligner.Settings settings;
    private object template;
    private object target;
    private object transformed;
    private object residual;
    private object roiMask;
    private object srcRoiPts;
    private object dstRoiPts;
    private object dstRoiPtsArray;
    private object roi;
    private object subroi;
    private ImageTransformer transformer;
    private ImageTransformer.Data[][] hessianGradientTransformerData;
    private ImageTransformer.Data[][] residualTransformerData;
    private ImageTransformer.Parameters parameters;
    private ImageTransformer.Parameters[] parametersArray;
    private ImageTransformer.Parameters[] tempParameters;
    private ImageTransformer.Parameters priorParameters;
    private object hessian;
    private object regularizedHessian;
    private object gradient;
    private object update;
    private object prior;
    private double[] constraintGrad;
    private double[] subspaceResidual;
    private double[][] subspaceJacobian;
    private double[] updateScale;
    private bool[] subspaceCorrelated;
    private int pyramidLevel;
    private double RMSE;
    private bool residualUpdateNeeded;
    private int lastLinePosition;
    private int trials;
    public double[] subspaceParameters;
    public double[][] tempSubspaceParameters;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 132, (byte) 127, (byte) 4, (byte) 232, (byte) 160, (byte) 175, (byte) 103, (byte) 103, (byte) 231, (byte) 159, (byte) 80, (byte) 136, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public GNImageAligner(ImageTransformer transformer, ImageTransformer.Parameters initialParameters, object template0, double[] roiPts, object target0, GNImageAligner.Settings settings)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(template0, __typeref (GNImageAligner), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(target0, __typeref (GNImageAligner), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      base.\u002Ector();
      GNImageAligner gnImageAligner1 = this;
      this.residualUpdateNeeded = true;
      this.lastLinePosition = 0;
      this.trials = 0;
      this.setSettings((ImageAligner.Settings) settings);
      initialParameters.size();
      GNImageAligner gnImageAligner2 = this;
      int num = settings.pyramidLevels;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 133, (byte) 159, (byte) 4, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public GNImageAligner(ImageTransformer transformer, ImageTransformer.Parameters initialParameters, object template0, double[] roiPts, object target0)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(template0, __typeref (GNImageAligner), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(target0, __typeref (GNImageAligner), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      ImageTransformer transformer1 = transformer;
      ImageTransformer.Parameters initialParameters1 = initialParameters;
      object template0_1 = template0;
      double[] numArray = roiPts;
      object obj1 = target0;
      GNImageAligner.Settings settings1 = new GNImageAligner.Settings();
      object obj2 = obj1;
      double[] roiPts1 = numArray;
      object target0_1 = obj2;
      GNImageAligner.Settings settings2 = settings1;
      // ISSUE: explicit constructor call
      this.\u002Ector(transformer1, initialParameters1, template0_1, roiPts1, target0_1, settings2);
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static ImageTransformer.Parameters[] access\u0024100([In] GNImageAligner obj0)
    {
      return obj0.tempParameters;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static ImageTransformer.Parameters access\u0024000([In] GNImageAligner obj0)
    {
      return obj0.parameters;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static double[] access\u0024200([In] GNImageAligner obj0)
    {
      return obj0.constraintGrad;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static ImageTransformer.Data[][] access\u0024300([In] GNImageAligner obj0)
    {
      return obj0.hessianGradientTransformerData;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u0024400([In] GNImageAligner obj0)
    {
      return obj0.template;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static int access\u0024500([In] GNImageAligner obj0)
    {
      return obj0.pyramidLevel;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u0024600([In] GNImageAligner obj0)
    {
      return obj0.transformed;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u0024700([In] GNImageAligner obj0)
    {
      return obj0.residual;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u0024800([In] GNImageAligner obj0)
    {
      return obj0.roiMask;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static GNImageAligner.Settings access\u0024900([In] GNImageAligner obj0)
    {
      return obj0.settings;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u00241000([In] GNImageAligner obj0)
    {
      return obj0.roi;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u00241100([In] GNImageAligner obj0)
    {
      return obj0.subroi;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static ImageTransformer access\u00241200([In] GNImageAligner obj0)
    {
      return obj0.transformer;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static double[][] access\u00241300([In] GNImageAligner obj0)
    {
      return obj0.subspaceJacobian;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static bool[] access\u00241400([In] GNImageAligner obj0)
    {
      return obj0.subspaceCorrelated;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u00241500([In] GNImageAligner obj0)
    {
      return obj0.hessian;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static double[] access\u00241600([In] GNImageAligner obj0)
    {
      return obj0.subspaceResidual;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u00241700([In] GNImageAligner obj0)
    {
      return obj0.gradient;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static ImageTransformer.Data[][] access\u00241800([In] GNImageAligner obj0)
    {
      return obj0.residualTransformerData;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u00241900([In] GNImageAligner obj0)
    {
      return obj0.target;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static ImageTransformer.Parameters[] access\u00242000([In] GNImageAligner obj0)
    {
      return obj0.parametersArray;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 87, (byte) 108})]
    public virtual void setSettings(ImageAligner.Settings settings)
    {
      this.settings = (GNImageAligner.Settings) settings;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 67, (byte) 130, (byte) 159, (byte) 15, (byte) 129, (byte) 108, (byte) 108, (byte) 106, (byte) 122, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setConstrained(bool constrained)
    {
      int num1 = constrained ? 1 : 0;
      if ((this.settings.constrained ? 1 : 0) == num1 && this.hessian != null && (this.regularizedHessian != null && this.gradient != null) && this.update != null)
        return;
      this.settings.constrained = num1 != 0;
      int num2 = this.parameters.size();
      int num3 = num1 == 0 ? num2 : num2 + 1;
      if (this.subspaceParameters != null && this.settings.subspaceAlpha != 0.0)
        num3 += this.subspaceParameters.Length;
      GNImageAligner gnImageAligner = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 86, (byte) 177, (byte) 99, (byte) 191, (byte) 11})]
    public virtual void setTemplateImage(object template0, double[] roiPts)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(template0, __typeref (GNImageAligner), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      if (roiPts == null)
      {
        object obj = this.srcRoiPts;
        double[] numArray = new double[8];
        int index1 = 0;
        double num1 = 0.0;
        numArray[index1] = num1;
        int index2 = 1;
        double num2 = 0.0;
        numArray[index2] = num2;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }
      else
      {
        object obj = this.srcRoiPts;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
    }

    [LineNumberTable((ushort) 250)]
    public virtual void setTargetImage(object target0)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(target0, __typeref (GNImageAligner), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    public virtual void setPyramidLevel(int pyramidLevel)
    {
      this.pyramidLevel = pyramidLevel;
      this.residualUpdateNeeded = true;
      this.trials = 0;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 50, (byte) 127, (byte) 5, (byte) 116, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void doRoi([In] double obj0)
    {
      ImageTransformer mageTransformer = this.transformer;
      object cm1 = this.srcRoiPts;
      object obj1 = this.dstRoiPts;
      ImageTransformer.Parameters parameters1 = this.parameters;
      bool flag = false;
      ImageTransformer.Parameters parameters2 = parameters1;
      object cm2 = obj1;
      ImageTransformer.Parameters itp = parameters2;
      int num = flag ? 1 : 0;
      mageTransformer.transform(cm1, cm2, itp, num != 0);
      object obj2 = this.dstRoiPts;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 47, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void doRoi()
    {
      this.doRoi(0.0);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 87, (byte) 172, (byte) 254, (byte) 88, (byte) 108, (byte) 120, (byte) 111, (byte) 14, (byte) 200, (byte) 111, (byte) 146, (byte) 239, (byte) 70, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void doResidual()
    {
      this.parameters.getConstraintError();
      Parallel.loop(0, this.residualTransformerData.Length, this.settings.numThreads, (Parallel.Looper) new GNImageAligner\u00245(this));
      double num1 = 0.0;
      double num2 = 0.0;
      ImageTransformer.Data[][] dataArray1 = this.residualTransformerData;
      int length = dataArray1.Length;
      for (int index = 0; index < length; ++index)
      {
        ImageTransformer.Data[] dataArray2 = dataArray1[index];
        num1 += dataArray2[0].dstDstDot[0];
        num2 += (double) dataArray2[0].dstCount;
      }
      this.RMSE = num2 >= (double) this.parameters.size() ? Math.sqrt(num1 / num2) : double.NaN;
      this.residualUpdateNeeded = false;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 255, (byte) 104, (byte) 102, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getRMSE()
    {
      if (this.residualUpdateNeeded)
      {
        this.doRoi();
        this.doResidual();
      }
      return this.RMSE;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 215, (byte) 108, (byte) 108, (byte) 122, (byte) 108, (byte) 56, (byte) 198, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setParameters(ImageTransformer.Parameters parameters)
    {
      this.parameters.set(parameters);
      this.subspaceParameters = parameters.getSubspace();
      if (this.subspaceParameters != null && this.settings.subspaceAlpha != 0.0)
      {
        for (int index = 0; index < this.tempSubspaceParameters.Length; ++index)
          this.tempSubspaceParameters[index] = (double[]) this.subspaceParameters.Clone();
      }
      this.residualUpdateNeeded = true;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 129, (byte) 108, (byte) 109, (byte) 140, (byte) 107, (byte) 139, (byte) 251, (byte) 75, (byte) 255, (byte) 0, (byte) 89, (byte) 102, (byte) 103, (byte) 103, (byte) 127, (byte) 1, (byte) 110, (byte) 112, (byte) 112, (byte) 104, (byte) 102, (byte) 251, (byte) 58, (byte) 235, (byte) 81, (byte) 159, (byte) 25, (byte) 104, (byte) 159, (byte) 15, (byte) 191, (byte) 0, (byte) 104, (byte) 251, (byte) 69, (byte) 176, (byte) 103, (byte) 125, (byte) 40, (byte) 168, (byte) 137, (byte) 104, (byte) 112, (byte) 182, (byte) 184, (byte) 159, (byte) 14, (byte) 201, (byte) 108, (byte) 115, (byte) 115, (byte) 255, (byte) 1, (byte) 85, (byte) 131, (byte) 104, (byte) 191, (byte) 8, (byte) 107, (byte) 230, (byte) 59, (byte) 232, (byte) 74, (byte) 191, (byte) 13, (byte) 255, (byte) 3, (byte) 96})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void doHessianGradient([In] double[] obj0)
    {
      int to = this.parameters.size();
      double constraintError = this.parameters.getConstraintError();
      double num1 = this.settings.stepScale;
      opencv_core.cvSetZero(this.gradient);
      opencv_core.cvSetZero(this.hessian);
      Parallel.loop(0, to, this.settings.numThreads, (Parallel.Looper) new GNImageAligner\u00241(this, num1, obj0, constraintError));
      Parallel.loop(0, this.hessianGradientTransformerData.Length, this.settings.numThreads, (Parallel.Looper) new GNImageAligner\u00242(this, to));
      double num2 = 0.0;
      double num3 = 0.0;
      double num4 = 0.0;
      ImageTransformer.Data[][] dataArray1 = this.hessianGradientTransformerData;
      int length1 = dataArray1.Length;
      for (int index1 = 0; index1 < length1; ++index1)
      {
        ImageTransformer.Data[] dataArray2 = dataArray1[index1];
        num2 += (double) dataArray2[0].dstCount;
        num3 += (double) dataArray2[0].dstCountZero;
        num4 += (double) dataArray2[0].dstCountOutlier;
        int index2 = 0;
        if (index2 < to)
        {
          ImageTransformer.Data data = dataArray2[index2];
          object obj1 = this.gradient;
          object obj2 = this.gradient;
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
        }
      }
      if ((this.settings.gammaTgamma != null || this.settings.tikhonovAlpha != 0.0) && (this.prior != null && this.priorParameters != null))
      {
        int i = 0;
        if (i < to)
        {
          object obj = this.prior;
          double num5 = this.parameters.get(i) - this.priorParameters.get(i);
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
        }
        else
        {
          object src1 = this.hessian;
          object obj1 = this.prior;
          object obj2 = this.prior;
          object src2 = obj1;
          object dst = obj2;
          opencv_core.cvMatMul(src1, src2, dst);
          if (0 < to)
          {
            object obj3 = this.gradient;
            object obj4 = this.gradient;
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          }
        }
      }
      if (this.settings.constrained)
      {
        double num5 = 0.0;
        double[] numArray = this.constraintGrad;
        int length2 = numArray.Length;
        for (int index = 0; index < length2; ++index)
        {
          double num6 = numArray[index];
          num5 += num6;
        }
        obj0[to] = (double) to * num5;
        int index1 = 0;
        if (index1 < to)
        {
          double num6 = this.constraintGrad[index1] * obj0[to];
          object obj = this.hessian;
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
        }
        else
        {
          object obj = this.gradient;
          double num6 = -constraintError * obj0[to];
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
        }
      }
      else
      {
        if (this.subspaceParameters == null || this.subspaceParameters.Length <= 0 || this.settings.subspaceAlpha == 0.0)
          return;
        int length2 = this.subspaceParameters.Length;
        Arrays.fill(this.subspaceCorrelated, false);
        this.tempParameters[0].set(this.parameters);
        this.tempParameters[0].setSubspace(this.subspaceParameters);
        Parallel.loop(0, to + length2, this.settings.numThreads, (Parallel.Looper) new GNImageAligner\u00243(this, to, obj0, length2, num1));
        int num5 = 0;
        for (int i = 0; i < to; ++i)
        {
          this.subspaceResidual[i] = this.parameters.get(i) - this.tempParameters[0].get(i);
          if (this.subspaceCorrelated[i])
            ++num5;
        }
        double num6 = this.settings.subspaceAlpha * this.settings.subspaceAlpha * this.RMSE * this.RMSE / (double) num5;
        Parallel.loop(0, to + length2, this.settings.numThreads, (Parallel.Looper) new GNImageAligner\u00244(this, to, length2, num6));
      }
    }

    public virtual GNImageAligner.Settings getSettings()
    {
      return this.settings;
    }

    [LineNumberTable((ushort) 224)]
    public virtual object getTemplateImage()
    {
      object obj = this.template;
      int num = this.pyramidLevel;
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
    }

    [LineNumberTable((ushort) 247)]
    public virtual object getTargetImage()
    {
      object obj = this.target;
      int num = this.pyramidLevel;
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
    }

    public virtual int getPyramidLevel()
    {
      return this.pyramidLevel;
    }

    [LineNumberTable((ushort) 299)]
    public virtual bool isConstrained()
    {
      return this.settings.constrained;
    }

    public virtual ImageTransformer.Parameters getParameters()
    {
      return this.parameters;
    }

    public virtual ImageTransformer.Parameters getPriorParameters()
    {
      return this.priorParameters;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 229, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPriorParameters(ImageTransformer.Parameters priorParameters)
    {
      this.priorParameters.set(priorParameters);
    }

    [LineNumberTable((ushort) 347)]
    public virtual double[] getTransformedRoiPts()
    {
      object obj = this.dstRoiPts;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 237, (byte) 104, (byte) 102, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getTransformedImage()
    {
      if (this.residualUpdateNeeded)
      {
        this.doRoi();
        this.doResidual();
      }
      object obj = this.transformed;
      int num = this.pyramidLevel;
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 244, (byte) 104, (byte) 102, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getResidualImage()
    {
      if (this.residualUpdateNeeded)
      {
        this.doRoi();
        this.doResidual();
      }
      object obj = this.residual;
      int num = this.pyramidLevel;
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
    }

    [LineNumberTable((ushort) 365)]
    public virtual object getRoiMaskImage()
    {
      object obj = this.roiMask;
      int num = this.pyramidLevel;
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 7, (byte) 98, (byte) 117, (byte) 44, (byte) 166})]
    public virtual int getPixelCount()
    {
      int num = 0;
      ImageTransformer.Data[][] dataArray1 = this.residualTransformerData;
      int length = dataArray1.Length;
      for (int index = 0; index < length; ++index)
      {
        ImageTransformer.Data[] dataArray2 = dataArray1[index];
        num += dataArray2[0].dstCount;
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 15, (byte) 104, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getRoi()
    {
      if (this.residualUpdateNeeded)
        this.doRoi();
      return this.roi;
    }

    public virtual int getLastLinePosition()
    {
      return this.lastLinePosition;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 25, (byte) 98, (byte) 108, (byte) 104, (byte) 108, (byte) 156, (byte) 117, (byte) 108, (byte) 134, (byte) 108, (byte) 156, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool iterate(double[] delta)
    {
      this.parameters.size();
      this.getRMSE();
      this.parameters.get();
      double[] numArray1 = this.subspaceParameters != null ? (double[]) this.subspaceParameters.Clone() : (double[]) null;
      if (this.trials == 0 && this.parameters.preoptimize())
      {
        this.setParameters(this.parameters);
        this.doResidual();
      }
      this.parameters.get();
      double[] numArray2 = this.subspaceParameters != null ? (double[]) this.subspaceParameters.Clone() : (double[]) null;
      this.doHessianGradient(this.updateScale);
      object obj = this.hessian;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 35)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ImageAligner.Settings \u003Cbridge\u003EgetSettings()
    {
      return (ImageAligner.Settings) this.getSettings();
    }

    [HideFromJava]
    ImageAligner.Settings ImageAligner.com\u002Egooglecode\u002Ejavacv\u002EImageAligner\u002F\u0028\u0029Lcom\u002Egooglecode\u002Ejavacv\u002EImageAligner\u0024Settings\u003BgetSettings()
    {
      return this.\u003Cbridge\u003EgetSettings();
    }

    [InnerClass]
    [Implements(new string[] {"java.lang.Cloneable"})]
    [SourceFile("GNImageAligner.java")]
    [Serializable]
    public class Settings : ImageAligner.Settings, Cloneable.__Interface
    {
      internal double stepScale;
      internal double[] lineSearch;
      internal double deltaMin;
      internal double deltaMax;
      internal double displacementMax;
      internal double subspaceAlpha;
      internal int numThreads;

      [LineNumberTable(new byte[] {(byte) 74, (byte) 233, (byte) 74, (byte) 112, (byte) 127, (byte) 1, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 235, (byte) 49, (byte) 109, (byte) 108, (byte) 109, (byte) 109, (byte) 109, (byte) 109, (byte) 108})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings(GNImageAligner.Settings s)
        : base((ImageAligner.Settings) s)
      {
        GNImageAligner.Settings settings = this;
        this.stepScale = 0.1;
        double[] numArray = new double[2];
        int index1 = 0;
        double num1 = 1.0;
        numArray[index1] = num1;
        int index2 = 1;
        double num2 = 0.25;
        numArray[index2] = num2;
        this.lineSearch = numArray;
        this.deltaMin = 10.0;
        this.deltaMax = 300.0;
        this.displacementMax = 0.15;
        this.subspaceAlpha = 0.1;
        this.numThreads = Parallel.__\u003C\u003EnumCores;
        this.stepScale = s.stepScale;
        this.lineSearch = s.lineSearch;
        this.deltaMin = s.deltaMin;
        this.deltaMax = s.deltaMax;
        this.displacementMax = s.displacementMax;
        this.subspaceAlpha = s.subspaceAlpha;
        this.numThreads = s.numThreads;
      }

      [LineNumberTable(new byte[] {(byte) 72, (byte) 232, (byte) 76, (byte) 112, (byte) 127, (byte) 1, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 235, (byte) 46})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings()
      {
        GNImageAligner.Settings settings = this;
        this.stepScale = 0.1;
        double[] numArray = new double[2];
        int index1 = 0;
        double num1 = 1.0;
        numArray[index1] = num1;
        int index2 = 1;
        double num2 = 0.25;
        numArray[index2] = num2;
        this.lineSearch = numArray;
        this.deltaMin = 10.0;
        this.deltaMax = 300.0;
        this.displacementMax = 0.15;
        this.subspaceAlpha = 0.1;
        this.numThreads = Parallel.__\u003C\u003EnumCores;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected Settings([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [HideFromJava]
      public static implicit operator Cloneable([In] GNImageAligner.Settings obj0)
      {
        Cloneable cloneable;
        cloneable.__\u003Cref\u003E = (__Null) obj0;
        return cloneable;
      }

      [LineNumberTable((ushort) 192)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual GNImageAligner.Settings clone()
      {
        return new GNImageAligner.Settings(this);
      }

      public virtual double getStepScale()
      {
        return this.stepScale;
      }

      public virtual void setStepScale(double stepScale)
      {
        this.stepScale = stepScale;
      }

      public virtual double[] getLineSearch()
      {
        return this.lineSearch;
      }

      public virtual void setLineSearch(double[] lineSearch)
      {
        this.lineSearch = lineSearch;
      }

      public virtual double getDeltaMin()
      {
        return this.deltaMin;
      }

      public virtual void setDeltaMin(double deltaMin)
      {
        this.deltaMin = deltaMin;
      }

      public virtual double getDeltaMax()
      {
        return this.deltaMax;
      }

      public virtual void setDeltaMax(double deltaMax)
      {
        this.deltaMax = deltaMax;
      }

      public virtual double getDisplacementMax()
      {
        return this.displacementMax;
      }

      public virtual void setDisplacementMax(double displacementMax)
      {
        this.displacementMax = displacementMax;
      }

      public virtual double getSubspaceAlpha()
      {
        return this.subspaceAlpha;
      }

      public virtual void setSubspaceAlpha(double subspaceAlpha)
      {
        this.subspaceAlpha = subspaceAlpha;
      }

      public virtual int getNumThreads()
      {
        return this.numThreads;
      }

      public virtual void setNumThreads(int numThreads)
      {
        this.numThreads = numThreads;
      }

      [Modifiers]
      [EditorBrowsable(EditorBrowsableState.Never)]
      [LineNumberTable((ushort) 121)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual ImageAligner.Settings \u003Cbridge\u003Eclone()
      {
        return (ImageAligner.Settings) this.clone();
      }

      [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
      [Modifiers]
      [EditorBrowsable(EditorBrowsableState.Never)]
      [LineNumberTable((ushort) 121)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override object \u003Cbridge\u003Eclone()
      {
        return (object) this.clone();
      }
    }
  }
}
