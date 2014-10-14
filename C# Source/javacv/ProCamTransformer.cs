// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ProCamTransformer
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacv
{
  [Implements(new string[] {"com.googlecode.javacv.ImageTransformer"})]
  public class ProCamTransformer : Object, ImageTransformer
  {
    [Modifiers]
    internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<ProCamTransformer>.Value).desiredAssertionStatus();
    private CameraDevice camera;
    private ProjectorDevice projector;
    private ProjectiveGainBiasTransformer surfaceTransformer;
    private ProjectiveGainBiasTransformer projectorTransformer;
    private object projectorImage;
    private object surfaceImage;
    private object fillColor;
    private object roi;
    private object frontoParallelH;
    private object invFrontoParallelH;

    [LineNumberTable((ushort) 35)]
    static ProCamTransformer()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 132, (byte) 114, (byte) 232, (byte) 85, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 110, (byte) 127, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProCamTransformer(double[] referencePoints, CameraDevice camera, ProjectorDevice projector, object n)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(n, __typeref (ProCamTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      base.\u002Ector();
      ProCamTransformer proCamTransformer1 = this;
      this.camera = (CameraDevice) null;
      this.projector = (ProjectorDevice) null;
      this.surfaceTransformer = (ProjectiveGainBiasTransformer) null;
      this.projectorTransformer = (ProjectiveGainBiasTransformer) null;
      this.projectorImage = (object) null;
      this.surfaceImage = (object) null;
      this.fillColor = opencv_core.cvScalar(0.0, 0.0, 0.0, 1.0);
      ProCamTransformer proCamTransformer2 = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvRect");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 180, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProCamTransformer(double[] referencePoints, CameraDevice camera, ProjectorDevice projector)
      : this(referencePoints, camera, projector, (object) null)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static ProjectiveGainBiasTransformer access\u0024200([In] ProCamTransformer obj0)
    {
      return obj0.surfaceTransformer;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static ProjectiveGainBiasTransformer access\u0024300([In] ProCamTransformer obj0)
    {
      return obj0.projectorTransformer;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u0024400([In] ProCamTransformer obj0)
    {
      return obj0.invFrontoParallelH;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u0024500([In] ProCamTransformer obj0)
    {
      return obj0.frontoParallelH;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static CameraDevice access\u0024600([In] ProCamTransformer obj0)
    {
      return obj0.camera;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 119, (byte) 81, (byte) 123, (byte) 173})]
    public virtual void setProjectorImage(object projectorImage0, int pyramidLevels, bool convertToFloat)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(projectorImage0, __typeref (ProCamTransformer), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      if (this.projectorImage == null || ((System.Array) this.projectorImage).Length != pyramidLevels)
      {
        ProCamTransformer proCamTransformer = this;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }
      else
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 92, (byte) 95, (byte) 23, (byte) 99, (byte) 144, (byte) 104, (byte) 103, (byte) 135, (byte) 124, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void transform(object srcImage, object dstImage, object roi, int pyramidLevel, ImageTransformer.Parameters parameters, bool inverse)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(srcImage, __typeref (ProCamTransformer), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dstImage, __typeref (ProCamTransformer), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(roi, __typeref (ProCamTransformer), "com.googlecode.javacv.cpp.opencv_core$CvRect");
      if (inverse)
      {
        string str = "Inverse transform not supported.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnsupportedOperationException(str);
      }
      else
      {
        ProCamTransformer.Parameters parameters1 = (ProCamTransformer.Parameters) parameters;
        parameters1.getSurfaceParameters();
        parameters1.getProjectorParameters();
        if (ProCamTransformer.Parameters.access\u0024000(parameters1) == null || ((System.Array) ProCamTransformer.Parameters.access\u0024000(parameters1)).Length <= pyramidLevel)
        {
          int num = pyramidLevel + 1;
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
        }
        else
        {
          ProCamTransformer.Parameters.access\u0024000(parameters1);
          ProCamTransformer.Parameters.access\u0024000(parameters1);
          throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 100, (byte) 127, (byte) 20, (byte) 104, (byte) 136, (byte) 111, (byte) 175, (byte) 101, (byte) 104, (byte) 239, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void prepareHomographyTransform(object H1, object H2, object X, int pyramidLevel, ProCamTransformer.Parameters p)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(H1, __typeref (ProCamTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(H2, __typeref (ProCamTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(X, __typeref (ProCamTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      ProjectiveGainBiasTransformer.Parameters surfaceParameters = p.getSurfaceParameters();
      ProjectiveGainBiasTransformer.Parameters projectorParameters = p.getProjectorParameters();
      opencv_core.cvInvert(surfaceParameters.getH(), H1);
      opencv_core.cvInvert(projectorParameters.getH(), H2);
      if (pyramidLevel > 0)
      {
        int num = 1 << pyramidLevel;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
      else
      {
        object obj = this.projector.colorMixingMatrix;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
    }

    public virtual object getFillColor()
    {
      return this.fillColor;
    }

    [LineNumberTable((ushort) 325)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ProCamTransformer.Parameters createParameters()
    {
      return new ProCamTransformer.Parameters(this);
    }

    public virtual void setFillColor(object fillColor)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(fillColor, __typeref (ProCamTransformer), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      this.fillColor = fillColor;
    }

    public virtual ProjectiveGainBiasTransformer getSurfaceTransformer()
    {
      return this.surfaceTransformer;
    }

    public virtual ProjectiveGainBiasTransformer getProjectorTransformer()
    {
      return this.projectorTransformer;
    }

    [LineNumberTable((ushort) 86)]
    public virtual object getProjectorImage(int pyramidLevel)
    {
      object obj = this.projectorImage;
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 120, (byte) 113, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setProjectorImage(object projectorImage0, int pyramidLevels)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(projectorImage0, __typeref (ProCamTransformer), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      object projectorImage0_1 = projectorImage0;
      int num1 = pyramidLevels;
      bool flag = true;
      int pyramidLevels1 = num1;
      int num2 = flag ? 1 : 0;
      this.setProjectorImage(projectorImage0_1, pyramidLevels1, num2 != 0);
    }

    [LineNumberTable((ushort) 145)]
    public virtual object getSurfaceImage(int pyramidLevel)
    {
      object obj = this.surfaceImage;
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 105, (byte) 81, (byte) 123, (byte) 141})]
    public virtual void setSurfaceImage(object surfaceImage0, int pyramidLevels)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(surfaceImage0, __typeref (ProCamTransformer), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      if (this.surfaceImage == null || ((System.Array) this.surfaceImage).Length != pyramidLevels)
      {
        ProCamTransformer proCamTransformer = this;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }
      else
      {
        object obj = this.surfaceImage;
        throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 85, (byte) 159, (byte) 6, (byte) 127, (byte) 2})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void transform(object srcPts, object dstPts, ImageTransformer.Parameters parameters, bool inverse)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(srcPts, __typeref (ProCamTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dstPts, __typeref (ProCamTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      int num1 = inverse ? 1 : 0;
      ProjectiveGainBiasTransformer gainBiasTransformer = this.surfaceTransformer;
      object srcPts1 = srcPts;
      object obj = dstPts;
      ProjectiveGainBiasTransformer.Parameters parameters1 = ProCamTransformer.Parameters.access\u0024100((ProCamTransformer.Parameters) parameters);
      bool flag = num1 != 0;
      ImageTransformer.Parameters parameters2 = (ImageTransformer.Parameters) parameters1;
      object dstPts1 = obj;
      ImageTransformer.Parameters parameters3 = parameters2;
      int num2 = flag ? 1 : 0;
      gainBiasTransformer.transform(srcPts1, dstPts1, parameters3, num2 != 0);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 84, (byte) 145, (byte) 120, (byte) 98, (byte) 106, (byte) 100, (byte) 106, (byte) 144, (byte) 107, (byte) 159, (byte) 21, (byte) 191, (byte) 44, (byte) 226, (byte) 53, (byte) 233, (byte) 79, (byte) 230, (byte) 81, (byte) 127, (byte) 2, (byte) 111, (byte) 179, (byte) 105, (byte) 244, (byte) 93, (byte) 243, (byte) 83})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void transform(ImageTransformer.Data[] data, object roi, ImageTransformer.Parameters[] parameters, bool[] inverses)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(roi, __typeref (ProCamTransformer), "com.googlecode.javacv.cpp.opencv_core$CvRect");
      if (!ProCamTransformer.\u0024assertionsDisabled && data.Length != parameters.Length)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new AssertionError();
      }
      else
      {
        int num1 = 1;
        for (int index = 0; index < data.Length; ++index)
        {
          ImageTransformer.Data data1 = data[index];
          if (inverses != null && inverses[index])
          {
            string str = "Inverse transform not supported.";
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new UnsupportedOperationException(str);
          }
          else if (data1.srcImg != null)
          {
            if ((data1.transImg != null || data1.dstImg != null) && (data1.subImg == null && data1.srcDotImg == null) && data1.dstDstDot == null)
            {
              object srcImage = data1.srcImg;
              object obj1 = data1.transImg != null ? data1.transImg : data1.dstImg;
              object obj2 = roi;
              int num2 = data1.pyramidLevel;
              ImageTransformer.Parameters parameters1 = parameters[index];
              bool flag = inverses != null && inverses[index];
              ImageTransformer.Parameters parameters2 = parameters1;
              int num3 = num2;
              object obj3 = obj2;
              object dstImage = obj1;
              object roi1 = obj3;
              int pyramidLevel = num3;
              ImageTransformer.Parameters parameters3 = parameters2;
              int num4 = flag ? 1 : 0;
              this.transform(srcImage, dstImage, roi1, pyramidLevel, parameters3, num4 != 0);
            }
            else
              num1 = 0;
          }
        }
        if (num1 != 0)
          return;
        ProCamTransformer\u00241Cache transformer1Cache = !(data[0].cache is ProCamTransformer\u00241Cache) ? (ProCamTransformer\u00241Cache) null : (ProCamTransformer\u00241Cache) data[0].cache;
        if (transformer1Cache == null || transformer1Cache.length != data.Length)
          data[0].cache = (object) (transformer1Cache = new ProCamTransformer\u00241Cache(this, data.Length));
        if (0 < data.Length)
        {
          object obj = transformer1Cache.kernelData;
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.cvkernels$KernelData");
        }
        else
        {
          object obj = transformer1Cache.kernelData;
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.cvkernels$KernelData");
        }
      }
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 35)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ImageTransformer.Parameters \u003Cbridge\u003EcreateParameters()
    {
      return (ImageTransformer.Parameters) this.createParameters();
    }

    [HideFromJava]
    ImageTransformer.Parameters ImageTransformer.com\u002Egooglecode\u002Ejavacv\u002EImageTransformer\u002F\u0028\u0029Lcom\u002Egooglecode\u002Ejavacv\u002EImageTransformer\u0024Parameters\u003BcreateParameters()
    {
      return this.\u003Cbridge\u003EcreateParameters();
    }

    [InnerClass]
    [Implements(new string[] {"com.googlecode.javacv.ImageTransformer$Parameters"})]
    [SourceFile("ProCamTransformer.java")]
    public class Parameters : Object, ImageTransformer.Parameters, Cloneable.__Interface
    {
      private ProjectiveGainBiasTransformer.Parameters surfaceParameters;
      private ProjectiveGainBiasTransformer.Parameters projectorParameters;
      private object tempImage;
      private object H;
      private object R;
      private object n;
      private object t;
      [Modifiers]
      internal ProCamTransformer this\u00240;

      [LineNumberTable(new byte[] {(byte) 160, (byte) 215, (byte) 239, (byte) 72, (byte) 103, (byte) 103, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal Parameters(ProCamTransformer pct)
      {
        base.\u002Ector();
        ProCamTransformer.Parameters parameters1 = this;
        this.surfaceParameters = (ProjectiveGainBiasTransformer.Parameters) null;
        this.projectorParameters = (ProjectiveGainBiasTransformer.Parameters) null;
        this.tempImage = (object) null;
        ProCamTransformer.Parameters parameters2 = this;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 219, (byte) 207, (byte) 103, (byte) 103, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal Parameters(ProCamTransformer pct, ProjectiveGainBiasTransformer.Parameters surfaceParameters, ProjectiveGainBiasTransformer.Parameters projectorParameters)
      {
        base.\u002Ector();
        ProCamTransformer.Parameters parameters1 = this;
        this.surfaceParameters = (ProjectiveGainBiasTransformer.Parameters) null;
        this.projectorParameters = (ProjectiveGainBiasTransformer.Parameters) null;
        this.tempImage = (object) null;
        ProCamTransformer.Parameters parameters2 = this;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }

      [HideFromJava]
      public static implicit operator Cloneable([In] ProCamTransformer.Parameters obj0)
      {
        Cloneable cloneable;
        cloneable.__\u003Cref\u003E = (__Null) obj0;
        return cloneable;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 23, (byte) 106})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void reset(bool asIdentity)
      {
        this.reset((ProjectiveGainBiasTransformer.Parameters) null, (ProjectiveGainBiasTransformer.Parameters) null);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 27, (byte) 99, (byte) 146, (byte) 99, (byte) 146, (byte) 103, (byte) 135, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void reset(ProjectiveGainBiasTransformer.Parameters surfaceParameters, ProjectiveGainBiasTransformer.Parameters projectorParameters)
      {
        if (surfaceParameters == null)
          surfaceParameters = ProCamTransformer.access\u0024200(this.this\u00240).createParameters();
        if (projectorParameters == null)
          projectorParameters = ProCamTransformer.access\u0024300(this.this\u00240).createParameters();
        this.surfaceParameters = surfaceParameters;
        this.projectorParameters = projectorParameters;
        this.setSubspace(this.getSubspace());
      }

      [LineNumberTable((ushort) 351)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private int getSizeForSurface()
      {
        return this.surfaceParameters.size() - ProCamTransformer.access\u0024200(this.this\u00240).getNumGains() - ProCamTransformer.access\u0024200(this.this\u00240).getNumBiases();
      }

      [LineNumberTable((ushort) 354)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private int getSizeForProjector()
      {
        return this.projectorParameters.size();
      }

      [LineNumberTable((ushort) 357)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int size()
      {
        return this.getSizeForSurface() + this.getSizeForProjector();
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 253, (byte) 105, (byte) 143})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual double get(int i)
      {
        if (i < this.getSizeForSurface())
          return this.surfaceParameters.get(i);
        else
          return this.projectorParameters.get(i - this.getSizeForSurface());
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 9, (byte) 105, (byte) 144, (byte) 151})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void set(int i, double p)
      {
        if (i < this.getSizeForSurface())
          this.surfaceParameters.set(i, p);
        else
          this.projectorParameters.set(i - this.getSizeForSurface(), p);
      }

      public virtual ProjectiveGainBiasTransformer.Parameters getSurfaceParameters()
      {
        return this.surfaceParameters;
      }

      public virtual ProjectiveGainBiasTransformer.Parameters getProjectorParameters()
      {
        return this.projectorParameters;
      }

      [LineNumberTable((ushort) 452)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual double[] getSubspace()
      {
        return this.getSubspaceInternal();
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 76, (byte) 104, (byte) 99, (byte) 137})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setSubspace(params double[] p)
      {
        double[] numArray = this.setSubspaceInternal(p);
        if (numArray == null)
          return;
        this.set(numArray);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 124, (byte) 109, (byte) 130, (byte) 127, (byte) 11, (byte) 127, (byte) 1, (byte) 159, (byte) 6, (byte) 123, (byte) 119})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private double[] getSubspaceInternal()
      {
        if (ProCamTransformer.access\u0024500(this.this\u00240) == null)
          return (double[]) null;
        object k1 = ProCamTransformer.access\u0024200(this.this\u00240).getK1();
        object obj1 = ProCamTransformer.access\u0024500(this.this\u00240);
        object obj2 = this.H;
        object src2_1 = obj1;
        object dst1 = obj2;
        opencv_core.cvMatMul(k1, src2_1, dst1);
        object h = this.surfaceParameters.getH();
        object obj3 = this.H;
        object obj4 = this.H;
        object src2_2 = obj3;
        object dst2 = obj4;
        opencv_core.cvMatMul(h, src2_2, dst2);
        object invK2 = ProCamTransformer.access\u0024200(this.this\u00240).getInvK2();
        object obj5 = this.H;
        object obj6 = this.H;
        object src2_3 = obj5;
        object dst3 = obj6;
        opencv_core.cvMatMul(invK2, src2_3, dst3);
        object H = this.H;
        object obj7 = this.R;
        object obj8 = this.t;
        object R = obj7;
        object t = obj8;
        JavaCV.HtoRt(H, R, t);
        object cm1 = this.R;
        object obj9 = this.n;
        object obj10 = (object) null;
        object cm2 = obj9;
        object cm3 = obj10;
        opencv_calib3d.cvRodrigues2(cm1, cm2, cm3);
        double[] numArray = new double[6];
        object obj11 = this.n;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 86, (byte) 109, (byte) 130, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private double[] setSubspaceInternal(params double[] _param1)
      {
        if (ProCamTransformer.access\u0024400(this.this\u00240) == null)
          return (double[]) null;
        double[] numArray1 = new double[11];
        object obj = this.t;
        double[] numArray2 = new double[3];
        int index1 = 0;
        double num1 = param0[0];
        numArray2[index1] = num1;
        int index2 = 1;
        double num2 = param0[1];
        numArray2[index2] = num2;
        int index3 = 2;
        double num3 = param0[2];
        numArray2[index3] = num3;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 4, (byte) 103, (byte) 42, (byte) 166})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void set(params double[] p)
      {
        for (int i = 0; i < p.Length; ++i)
          this.set(i, p[i]);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 175, (byte) 108, (byte) 113, (byte) 113})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual ProCamTransformer.Parameters clone()
      {
        return new ProCamTransformer.Parameters(this.this\u00240)
        {
          surfaceParameters = this.surfaceParameters.clone(),
          projectorParameters = this.projectorParameters.clone()
        };
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 246, (byte) 108, (byte) 103, (byte) 43, (byte) 166})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual double[] get()
      {
        double[] numArray = new double[this.size()];
        for (int i = 0; i < numArray.Length; ++i)
          numArray[i] = this.get(i);
        return numArray;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 16, (byte) 103, (byte) 113, (byte) 145, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void set(ImageTransformer.Parameters p)
      {
        ProCamTransformer.Parameters parameters = (ProCamTransformer.Parameters) p;
        this.surfaceParameters.set((ImageTransformer.Parameters) parameters.getSurfaceParameters());
        this.projectorParameters.set((ImageTransformer.Parameters) parameters.getProjectorParameters());
        this.surfaceParameters.resetGainBias(false);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 56, (byte) 109, (byte) 107})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual double getConstraintError()
      {
        double constraintError = this.surfaceParameters.getConstraintError();
        this.projectorParameters.update();
        return constraintError;
      }

      [LineNumberTable((ushort) 432)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void compose(ImageTransformer.Parameters p1, bool inverse1, ImageTransformer.Parameters p2, bool inverse2)
      {
        string str = "Compose operation not supported.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnsupportedOperationException(str);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 66, (byte) 109, (byte) 99, (byte) 106, (byte) 108, (byte) 108, (byte) 130})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool preoptimize()
      {
        double[] numArray = this.setSubspaceInternal(this.getSubspaceInternal());
        if (numArray == null)
          return false;
        this.set(8, numArray[8]);
        this.set(9, numArray[9]);
        this.set(10, numArray[10]);
        return true;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 139, (byte) 113, (byte) 123, (byte) 112, (byte) 112, (byte) 240, (byte) 69, (byte) 125, (byte) 127, (byte) 38, (byte) 159, (byte) 41, (byte) 127, (byte) 7, (byte) 223, (byte) 27, (byte) 127, (byte) 11, (byte) 121, (byte) 127, (byte) 8, (byte) 125, (byte) 159, (byte) 8, (byte) 189, (byte) 127, (byte) 24})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object getSrcN()
      {
        double[] referencePoints2 = ProCamTransformer.access\u0024300(this.this\u00240).getReferencePoints2();
        double[] numArray = (double[]) ProCamTransformer.access\u0024300(this.this\u00240).getReferencePoints1().Clone();
        numArray[0] = this.projectorParameters.get(0);
        numArray[2] = this.projectorParameters.get(1);
        numArray[4] = this.projectorParameters.get(2);
        opencv_core.cvTranspose(ProCamTransformer.access\u0024300(this.this\u00240).getR(), this.R);
        object ca1_1 = this.R;
        object t1 = ProCamTransformer.access\u0024300(this.this\u00240).getT();
        double num1 = -1.0;
        // ISSUE: variable of the null type
        __Null local1 = null;
        double num2 = 0.0;
        object obj1 = this.t;
        int num3 = 0;
        object obj2 = obj1;
        double num4 = num2;
        object obj3 = (object) local1;
        double num5 = num1;
        object ca2_1 = t1;
        double d1_1 = num5;
        object ca3_1 = obj3;
        double d2_1 = num4;
        object ca4_1 = obj2;
        int i1 = num3;
        opencv_core.cvGEMM(ca1_1, ca2_1, d1_1, ca3_1, d2_1, ca4_1, i1);
        double[] src = referencePoints2;
        double[] dst1 = numArray;
        object invK2 = ProCamTransformer.access\u0024300(this.this\u00240).getInvK2();
        object k1 = ProCamTransformer.access\u0024300(this.this\u00240).getK1();
        object obj4 = this.R;
        object obj5 = this.t;
        object obj6 = this.n;
        object obj7 = obj5;
        object obj8 = obj4;
        object dstK = k1;
        object R1 = obj8;
        object t2 = obj7;
        object n = obj6;
        JavaCV.getPlaneParameters(src, dst1, invK2, dstK, R1, t2, n);
        double num6 = 1.0 + opencv_core.cvDotProduct(this.n, ProCamTransformer.access\u0024300(this.this\u00240).getT());
        object ca1_2 = this.R;
        object obj9 = this.n;
        double num7 = 1.0 / num6;
        // ISSUE: variable of the null type
        __Null local2 = null;
        double num8 = 0.0;
        object obj10 = this.n;
        int num9 = 0;
        object obj11 = obj10;
        double num10 = num8;
        object obj12 = (object) local2;
        double num11 = num7;
        object ca2_2 = obj9;
        double d1_2 = num11;
        object ca3_2 = obj12;
        double d2_2 = num10;
        object ca4_2 = obj11;
        int i2 = num9;
        opencv_core.cvGEMM(ca1_2, ca2_2, d1_2, ca3_2, d2_2, ca4_2, i2);
        ProCamTransformer.access\u0024600(this.this\u00240).getFrontoParallelH(this.surfaceParameters.get(), this.n, this.R);
        opencv_core.cvInvert(this.surfaceParameters.getH(), this.H);
        object src1_1 = this.H;
        object k2 = ProCamTransformer.access\u0024200(this.this\u00240).getK2();
        object obj13 = this.H;
        object src2_1 = k2;
        object dst2 = obj13;
        opencv_core.cvMatMul(src1_1, src2_1, dst2);
        object src1_2 = this.H;
        object obj14 = this.R;
        object obj15 = this.H;
        object src2_2 = obj14;
        object dst3 = obj15;
        opencv_core.cvMatMul(src1_2, src2_2, dst3);
        object invK1 = ProCamTransformer.access\u0024200(this.this\u00240).getInvK1();
        object obj16 = this.H;
        object obj17 = this.H;
        object src2_3 = obj16;
        object dst4 = obj17;
        opencv_core.cvMatMul(invK1, src2_3, dst4);
        object H = this.H;
        object obj18 = this.R;
        object obj19 = this.t;
        object R2 = obj18;
        object t3 = obj19;
        JavaCV.HtoRt(H, R2, t3);
        object ca1_3 = this.R;
        object obj20 = this.t;
        double num12 = 1.0;
        // ISSUE: variable of the null type
        __Null local3 = null;
        double num13 = 0.0;
        object obj21 = this.t;
        int num14 = 1;
        object obj22 = obj21;
        double num15 = num13;
        object obj23 = (object) local3;
        double num16 = num12;
        object ca2_3 = obj20;
        double d1_3 = num16;
        object ca3_3 = obj23;
        double d2_3 = num15;
        object ca4_3 = obj22;
        int i3 = num14;
        opencv_core.cvGEMM(ca1_3, ca2_3, d1_3, ca3_3, d2_3, ca4_3, i3);
        object obj24 = this.t;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }

      [LineNumberTable((ushort) 552)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string toString()
      {
        return new StringBuilder().append(this.surfaceParameters.toString()).append(this.projectorParameters.toString()).toString();
      }

      [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
      [Modifiers]
      [EditorBrowsable(EditorBrowsableState.Never)]
      [LineNumberTable((ushort) 328)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object \u003Cbridge\u003Eclone()
      {
        return (object) this.clone();
      }

      [Modifiers]
      [EditorBrowsable(EditorBrowsableState.Never)]
      [LineNumberTable((ushort) 328)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual ImageTransformer.Parameters \u003Cbridge\u003Eclone()
      {
        return (ImageTransformer.Parameters) this.clone();
      }

      [Modifiers]
      [LineNumberTable((ushort) 328)]
      internal static object access\u0024000([In] ProCamTransformer.Parameters obj0)
      {
        return obj0.tempImage;
      }

      [Modifiers]
      [LineNumberTable((ushort) 328)]
      internal static object access\u0024002([In] ProCamTransformer.Parameters obj0, [In] object obj1)
      {
        // ISSUE: type reference
        ByteCodeHelper.DynamicCast(obj1, __typeref (ProCamTransformer.Parameters), "[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
        ProCamTransformer.Parameters parameters1 = obj0;
        object obj2 = obj1;
        ProCamTransformer.Parameters parameters2 = parameters1;
        object obj3 = obj2;
        parameters2.tempImage = obj2;
        return obj3;
      }

      [Modifiers]
      [LineNumberTable((ushort) 328)]
      internal static ProjectiveGainBiasTransformer.Parameters access\u0024100([In] ProCamTransformer.Parameters obj0)
      {
        return obj0.surfaceParameters;
      }

      [HideFromJava]
      ImageTransformer.Parameters ImageTransformer.Parameters.com\u002Egooglecode\u002Ejavacv\u002EImageTransformer\u0024Parameters\u002F\u0028\u0029Lcom\u002Egooglecode\u002Ejavacv\u002EImageTransformer\u0024Parameters\u003Bclone()
      {
        return this.\u003Cbridge\u003Eclone();
      }
    }
  }
}
