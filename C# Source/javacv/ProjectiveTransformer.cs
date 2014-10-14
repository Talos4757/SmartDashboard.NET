// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ProjectiveTransformer
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
  public class ProjectiveTransformer : Object, ImageTransformer
  {
    [Modifiers]
    internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<ProjectiveTransformer>.Value).desiredAssertionStatus();
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal H3x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal pts4x1;
    private object K1;
    private object K2;
    private object invK1;
    private object invK2;
    private object R;
    private object t;
    private object n;
    private double[] referencePoints1;
    private double[] referencePoints2;
    private object fillColor;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 245, (byte) 97})]
    static ProjectiveTransformer()
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 133, (byte) 127, (byte) 56, (byte) 232, (byte) 98, (byte) 127, (byte) 18, (byte) 110, (byte) 255, (byte) 0, (byte) 29, (byte) 120, (byte) 120, (byte) 120, (byte) 120, (byte) 99, (byte) 143, (byte) 99, (byte) 143, (byte) 120, (byte) 122, (byte) 154, (byte) 121, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectiveTransformer(object K1, object K2, object R, object t, object n, double[] referencePoints1, double[] referencePoints2)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(K1, __typeref (ProjectiveTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(K2, __typeref (ProjectiveTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(R, __typeref (ProjectiveTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(t, __typeref (ProjectiveTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(n, __typeref (ProjectiveTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      base.\u002Ector();
      ProjectiveTransformer projectiveTransformer = this;
      this.K1 = (object) null;
      this.K2 = (object) null;
      this.invK1 = (object) null;
      this.invK2 = (object) null;
      this.R = (object) null;
      this.t = (object) null;
      this.n = (object) null;
      this.referencePoints1 = (double[]) null;
      this.referencePoints2 = (double[]) null;
      this.fillColor = opencv_core.cvScalar(0.0, 0.0, 0.0, 1.0);
      if (K1 == null)
      {
        this.K1 = (object) null;
        if (K2 == null)
        {
          this.K2 = (object) null;
          if (K1 == null)
          {
            this.invK1 = (object) null;
            if (K2 == null)
            {
              this.invK2 = (object) null;
              if (K1 != null)
                opencv_core.cvInvert(K1, this.invK1);
              if (K2 != null)
                opencv_core.cvInvert(K2, this.invK2);
              if (R == null)
              {
                this.R = (object) null;
                if (t == null)
                {
                  this.t = (object) null;
                  if (n == null)
                  {
                    this.n = (object) null;
                    this.referencePoints1 = referencePoints1 != null ? (double[]) referencePoints1.Clone() : (double[]) null;
                    this.referencePoints2 = referencePoints2 != null ? (double[]) referencePoints2.Clone() : (double[]) null;
                  }
                  else
                    throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
                }
                else
                  throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
              }
              else
                throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            }
            else
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          }
          else
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
        }
        else
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
      else
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 128, (byte) 145, (byte) 127, (byte) 22})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectiveTransformer(ProjectiveDevice d1, ProjectiveDevice d2, object n, double[] referencePoints1, double[] referencePoints2)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(n, __typeref (ProjectiveTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      object K1 = d1.cameraMatrix;
      object obj1 = d2.cameraMatrix;
      object obj2 = d2.R;
      object obj3 = d2.T;
      object obj4 = n;
      double[] numArray1 = referencePoints1;
      double[] numArray2 = referencePoints2;
      double[] numArray3 = numArray1;
      object obj5 = obj4;
      object obj6 = obj3;
      object obj7 = obj2;
      object K2 = obj1;
      object R = obj7;
      object t = obj6;
      object n1 = obj5;
      double[] referencePoints1_1 = numArray3;
      double[] referencePoints2_1 = numArray2;
      // ISSUE: explicit constructor call
      this.\u002Ector(K1, K2, R, t, n1, referencePoints1_1, referencePoints2_1);
    }

    [LineNumberTable(new byte[] {(byte) 11, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectiveTransformer()
      : this((object) null, (object) null, (object) null, (object) null, (object) null, new double[0], (double[]) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 14, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectiveTransformer(double[] referencePoints)
      : this((object) null, (object) null, (object) null, (object) null, (object) null, referencePoints, (double[]) null)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual object getK2()
    {
      return this.K2;
    }

    public virtual object getInvK1()
    {
      return this.invK1;
    }

    public virtual double[] getReferencePoints2()
    {
      return this.referencePoints2;
    }

    public virtual object getR()
    {
      return this.R;
    }

    public virtual object getT()
    {
      return this.t;
    }

    public virtual double[] getReferencePoints1()
    {
      return this.referencePoints1;
    }

    public virtual object getK1()
    {
      return this.K1;
    }

    public virtual object getInvK2()
    {
      return this.invK2;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 108, (byte) 95, (byte) 20, (byte) 104, (byte) 191, (byte) 9, (byte) 100, (byte) 139, (byte) 161, (byte) 122, (byte) 245, (byte) 69, (byte) 239, (byte) 80})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void transform(object srcImage, object dstImage, object roi, int pyramidLevel, ImageTransformer.Parameters parameters, bool inverse)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(srcImage, __typeref (ProjectiveTransformer), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dstImage, __typeref (ProjectiveTransformer), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(roi, __typeref (ProjectiveTransformer), "com.googlecode.javacv.cpp.opencv_core$CvRect");
      ProjectiveTransformer.Parameters parameters1 = (ProjectiveTransformer.Parameters) parameters;
      if (this.K2 != null && this.invK1 != null && (this.R != null && this.t != null) && parameters1.fakeIdentity)
      {
        if (srcImage == dstImage)
          return;
        opencv_core.cvCopy(srcImage, dstImage);
      }
      else
      {
        // ISSUE: type reference
        object H = ByteCodeHelper.DynamicCast(ProjectiveTransformer.H3x3.get(), __typeref (ProjectiveTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
        int num1 = pyramidLevel;
        ProjectiveTransformer.Parameters parameters2 = parameters1;
        bool flag = true;
        ProjectiveTransformer.Parameters parameters3 = parameters2;
        int pyramidLevel1 = num1;
        ProjectiveTransformer.Parameters p = parameters3;
        int num2 = flag ? 1 : 0;
        this.prepareHomography(H, pyramidLevel1, p, num2 != 0);
        if (roi != null)
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvRect");
        else
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 97, (byte) 127, (byte) 6, (byte) 135, (byte) 99, (byte) 122, (byte) 145, (byte) 135, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void transform(object srcPts, object dstPts, ImageTransformer.Parameters parameters, bool inverse)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(srcPts, __typeref (ProjectiveTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dstPts, __typeref (ProjectiveTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      int num = inverse ? 1 : 0;
      ProjectiveTransformer.Parameters parameters1 = (ProjectiveTransformer.Parameters) parameters;
      object dst;
      if (num != 0)
      {
        // ISSUE: type reference
        dst = ByteCodeHelper.DynamicCast(ProjectiveTransformer.H3x3.get(), __typeref (ProjectiveTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
        opencv_core.cvInvert(parameters1.getH(), dst);
      }
      else
        dst = parameters1.getH();
      object ca1 = srcPts;
      object obj1 = dstPts;
      object obj2 = dst;
      object ca2 = obj1;
      object cm = obj2;
      opencv_core.cvPerspectiveTransform(ca1, ca2, cm);
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static double[] access\u0024000([In] ProjectiveTransformer obj0)
    {
      return obj0.referencePoints1;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u0024100([In] ProjectiveTransformer obj0)
    {
      return obj0.K2;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u0024200([In] ProjectiveTransformer obj0)
    {
      return obj0.invK1;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u0024300([In] ProjectiveTransformer obj0)
    {
      return obj0.R;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u0024400([In] ProjectiveTransformer obj0)
    {
      return obj0.t;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u0024500([In] ProjectiveTransformer obj0)
    {
      return obj0.n;
    }

    [Modifiers]
    internal static ThreadLocal access\u0024600()
    {
      return ProjectiveTransformer.pts4x1;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static double[] access\u0024700([In] ProjectiveTransformer obj0)
    {
      return obj0.referencePoints2;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u0024800([In] ProjectiveTransformer obj0)
    {
      return obj0.invK2;
    }

    [Modifiers]
    [LineNumberTable((ushort) 35)]
    internal static object access\u0024900([In] ProjectiveTransformer obj0)
    {
      return obj0.K1;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 115, (byte) 180, (byte) 191, (byte) 9, (byte) 104, (byte) 161, (byte) 99, (byte) 146, (byte) 207, (byte) 100, (byte) 103, (byte) 239, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void prepareHomography(object H, int pyramidLevel, ProjectiveTransformer.Parameters p, bool inverse)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(H, __typeref (ProjectiveTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      int num1 = inverse ? 1 : 0;
      if (this.K2 != null && this.invK1 != null && (this.R != null && this.t != null) && p.fakeIdentity)
        opencv_core.cvSetIdentity(H);
      else if (num1 != 0)
      {
        p.getH();
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
      else
      {
        opencv_core.cvInvert(p.getH(), H);
        if (pyramidLevel <= 0)
          return;
        int num2 = 1 << pyramidLevel;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
    }

    public virtual object getFillColor()
    {
      return this.fillColor;
    }

    [LineNumberTable((ushort) 274)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ProjectiveTransformer.Parameters createParameters()
    {
      return new ProjectiveTransformer.Parameters(this);
    }

    public virtual void setFillColor(object fillColor)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(fillColor, __typeref (ProjectiveTransformer), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      this.fillColor = fillColor;
    }

    public virtual object getN()
    {
      return this.n;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 94, (byte) 113, (byte) 120, (byte) 98, (byte) 106, (byte) 100, (byte) 107, (byte) 159, (byte) 21, (byte) 191, (byte) 44, (byte) 226, (byte) 56, (byte) 233, (byte) 76, (byte) 230, (byte) 79, (byte) 127, (byte) 2, (byte) 111, (byte) 179, (byte) 105, (byte) 244, (byte) 92, (byte) 243, (byte) 79})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void transform(ImageTransformer.Data[] data, object roi, ImageTransformer.Parameters[] parameters, bool[] inverses)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(roi, __typeref (ProjectiveTransformer), "com.googlecode.javacv.cpp.opencv_core$CvRect");
      if (!ProjectiveTransformer.\u0024assertionsDisabled && data.Length != parameters.Length)
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
          if (data1.srcImg != null)
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
        ProjectiveTransformer\u00241Cache transformer1Cache = !(data[0].cache is ProjectiveTransformer\u00241Cache) ? (ProjectiveTransformer\u00241Cache) null : (ProjectiveTransformer\u00241Cache) data[0].cache;
        if (transformer1Cache == null || transformer1Cache.length != data.Length)
          data[0].cache = (object) (transformer1Cache = new ProjectiveTransformer\u00241Cache(this, data.Length));
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
    [SourceFile("ProjectiveTransformer.java")]
    public class Parameters : Object, ImageTransformer.Parameters, Cloneable.__Interface
    {
      protected internal double[] projectiveParameters;
      private object H;
      private object n2;
      private object R2;
      private object t2;
      private double constraintError;
      private bool updateNeeded;
      protected internal bool fakeIdentity;
      [Modifiers]
      internal ProjectiveTransformer this\u00240;

      [LineNumberTable(new byte[] {(byte) 160, (byte) 164, (byte) 207, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal Parameters(ProjectiveTransformer pt)
      {
        base.\u002Ector();
        ProjectiveTransformer.Parameters parameters1 = this;
        this.projectiveParameters = (double[]) null;
        ProjectiveTransformer.Parameters parameters2 = this;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }

      [HideFromJava]
      public static implicit operator Cloneable([In] ProjectiveTransformer.Parameters obj0)
      {
        Cloneable cloneable;
        cloneable.__\u003Cref\u003E = (__Null) obj0;
        return cloneable;
      }

      [LineNumberTable((ushort) 296)]
      public virtual int size()
      {
        return this.projectiveParameters.Length;
      }

      [LineNumberTable((ushort) 306)]
      public virtual double get(int i)
      {
        return this.projectiveParameters[i];
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 200, (byte) 108, (byte) 106, (byte) 137})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void set(int i, double p)
      {
        if (this.projectiveParameters[i] == p)
          return;
        this.projectiveParameters[i] = p;
        this.setUpdateNeeded(true);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 206, (byte) 108, (byte) 113})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void set(ImageTransformer.Parameters p)
      {
        this.set(p.get());
        this.fakeIdentity = ((ProjectiveTransformer.Parameters) p).fakeIdentity;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 6, (byte) 102})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual double getConstraintError()
      {
        this.update();
        return this.constraintError;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 73, (byte) 104, (byte) 161, (byte) 127, (byte) 11, (byte) 142, (byte) 218, (byte) 255, (byte) 3, (byte) 84, (byte) 127, (byte) 1, (byte) 255, (byte) 1, (byte) 69, (byte) 108, (byte) 191, (byte) 57, (byte) 104, (byte) 142, (byte) 104, (byte) 142, (byte) 120, (byte) 127, (byte) 33, (byte) 255, (byte) 31, (byte) 71, (byte) 133, (byte) 109, (byte) 147, (byte) 104, (byte) 142, (byte) 218, (byte) 104, (byte) 142, (byte) 104, (byte) 142, (byte) 250, (byte) 76, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal virtual void update()
      {
        if (!this.isUpdateNeeded())
          return;
        if (ProjectiveTransformer.access\u0024000(this.this\u00240) != null && (ProjectiveTransformer.access\u0024000(this.this\u00240).Length == 0 || ProjectiveTransformer.access\u0024000(this.this\u00240).Length == 8))
        {
          if (ProjectiveTransformer.access\u0024000(this.this\u00240).Length == 0)
          {
            object obj = this.H;
            double[] numArray = this.projectiveParameters;
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          }
          else
            JavaCV.getPerspectiveTransform(ProjectiveTransformer.access\u0024000(this.this\u00240), this.projectiveParameters, this.H);
        }
        else if (ProjectiveTransformer.access\u0024100(this.this\u00240) != null && ProjectiveTransformer.access\u0024200(this.this\u00240) != null)
        {
          if (ProjectiveTransformer.access\u0024300(this.this\u00240) != null && ProjectiveTransformer.access\u0024400(this.this\u00240) != null)
          {
            double[] numArray1 = ProjectiveTransformer.access\u0024700(this.this\u00240);
            double[] numArray2 = new double[6];
            int index1 = 0;
            double num1 = this.projectiveParameters[0];
            numArray2[index1] = num1;
            int index2 = 1;
            double num2 = ProjectiveTransformer.access\u0024000(this.this\u00240)[1];
            numArray2[index2] = num2;
            int index3 = 2;
            double num3 = this.projectiveParameters[1];
            numArray2[index3] = num3;
            int index4 = 3;
            double num4 = ProjectiveTransformer.access\u0024000(this.this\u00240)[3];
            numArray2[index4] = num4;
            int index5 = 4;
            double num5 = this.projectiveParameters[2];
            numArray2[index5] = num5;
            int index6 = 5;
            double num6 = ProjectiveTransformer.access\u0024000(this.this\u00240)[5];
            numArray2[index6] = num6;
            double[] numArray3 = numArray2;
            if (this.R2 == null)
            {
              ProjectiveTransformer.Parameters parameters = this;
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            }
            else if (this.t2 == null)
            {
              ProjectiveTransformer.Parameters parameters = this;
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            }
            else
            {
              opencv_core.cvTranspose(ProjectiveTransformer.access\u0024300(this.this\u00240), this.R2);
              object ca1 = this.R2;
              object obj1 = ProjectiveTransformer.access\u0024400(this.this\u00240);
              double num7 = -1.0;
              // ISSUE: variable of the null type
              __Null local = null;
              double num8 = 0.0;
              object obj2 = this.t2;
              int num9 = 0;
              object obj3 = obj2;
              double num10 = num8;
              object obj4 = (object) local;
              double num11 = num7;
              object ca2 = obj1;
              double d1 = num11;
              object ca3 = obj4;
              double d2 = num10;
              object ca4 = obj3;
              int i = num9;
              opencv_core.cvGEMM(ca1, ca2, d1, ca3, d2, ca4, i);
              double[] src = numArray1;
              double[] dst = numArray3;
              object invSrcK = ProjectiveTransformer.access\u0024800(this.this\u00240);
              object obj5 = ProjectiveTransformer.access\u0024900(this.this\u00240);
              object obj6 = this.R2;
              object obj7 = this.t2;
              object obj8 = this.H;
              object obj9 = obj7;
              object obj10 = obj6;
              object dstK = obj5;
              object R = obj10;
              object t = obj9;
              object H = obj8;
              JavaCV.getPerspectiveTransform(src, dst, invSrcK, dstK, R, t, H);
            }
          }
          else if (ProjectiveTransformer.access\u0024500(this.this\u00240) != null)
          {
            this.n2 = ProjectiveTransformer.access\u0024500(this.this\u00240);
            if (this.R2 == null)
            {
              ProjectiveTransformer.Parameters parameters = this;
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            }
            else if (this.t2 == null)
            {
              ProjectiveTransformer.Parameters parameters = this;
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            }
            else
            {
              object obj = this.t2;
              double[] numArray = this.projectiveParameters;
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            }
          }
          else if (this.n2 == null)
          {
            ProjectiveTransformer.Parameters parameters = this;
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          }
          else
          {
            object obj = this.n2;
            double[] numArray = this.projectiveParameters;
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          }
        }
        this.setUpdateNeeded(false);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 56, (byte) 102})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object getH()
      {
        this.update();
        return this.H;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 185, (byte) 108, (byte) 103, (byte) 43, (byte) 166})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual double[] get()
      {
        double[] numArray = new double[this.size()];
        for (int i = 0; i < numArray.Length; ++i)
          numArray[i] = this.get(i);
        return numArray;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 193, (byte) 102, (byte) 103, (byte) 103, (byte) 122, (byte) 103, (byte) 251, (byte) 61, (byte) 230, (byte) 70, (byte) 123})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string toString()
      {
        string str = "[";
        double[] numArray = this.get();
        for (int index = 0; index < numArray.Length; ++index)
        {
          str = new StringBuilder().append(str).append((float) numArray[index]).toString();
          if (index < numArray.Length - 1)
            str = new StringBuilder().append(str).append(", ").toString();
        }
        return new StringBuilder().append(str).append("]").toString();
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 210, (byte) 103, (byte) 127, (byte) 17, (byte) 206, (byte) 255, (byte) 50, (byte) 70, (byte) 191, (byte) 1, (byte) 127, (byte) 1, (byte) 186, (byte) 159, (byte) 34, (byte) 109, (byte) 159, (byte) 31, (byte) 191, (byte) 54})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void reset(bool asIdentity)
      {
        this.setUpdateNeeded(true);
        if (ProjectiveTransformer.access\u0024000(this.this\u00240) != null && (ProjectiveTransformer.access\u0024000(this.this\u00240).Length == 0 || ProjectiveTransformer.access\u0024000(this.this\u00240).Length == 8))
        {
          if (ProjectiveTransformer.access\u0024000(this.this\u00240).Length == 0)
          {
            double[] numArray = new double[8];
            int index1 = 0;
            double num1 = 1.0;
            numArray[index1] = num1;
            int index2 = 1;
            double num2 = 0.0;
            numArray[index2] = num2;
            int index3 = 2;
            double num3 = 0.0;
            numArray[index3] = num3;
            int index4 = 3;
            double num4 = 0.0;
            numArray[index4] = num4;
            int index5 = 4;
            double num5 = 1.0;
            numArray[index5] = num5;
            int index6 = 5;
            double num6 = 0.0;
            numArray[index6] = num6;
            int index7 = 6;
            double num7 = 0.0;
            numArray[index7] = num7;
            int index8 = 7;
            double num8 = 0.0;
            numArray[index8] = num8;
            this.projectiveParameters = numArray;
          }
          else
            this.projectiveParameters = (double[]) ProjectiveTransformer.access\u0024000(this.this\u00240).Clone();
        }
        else
        {
          if (ProjectiveTransformer.access\u0024100(this.this\u00240) == null || ProjectiveTransformer.access\u0024200(this.this\u00240) == null)
            return;
          if (ProjectiveTransformer.access\u0024300(this.this\u00240) != null && ProjectiveTransformer.access\u0024400(this.this\u00240) != null)
          {
            double[] numArray = new double[3];
            int index1 = 0;
            double num1 = ProjectiveTransformer.access\u0024000(this.this\u00240)[0];
            numArray[index1] = num1;
            int index2 = 1;
            double num2 = ProjectiveTransformer.access\u0024000(this.this\u00240)[2];
            numArray[index2] = num2;
            int index3 = 2;
            double num3 = ProjectiveTransformer.access\u0024000(this.this\u00240)[4];
            numArray[index3] = num3;
            this.projectiveParameters = numArray;
          }
          else if (ProjectiveTransformer.access\u0024500(this.this\u00240) != null)
          {
            double[] numArray = new double[6];
            int index1 = 0;
            double num1 = 0.0;
            numArray[index1] = num1;
            int index2 = 1;
            double num2 = 0.0;
            numArray[index2] = num2;
            int index3 = 2;
            double num3 = 0.0;
            numArray[index3] = num3;
            int index4 = 3;
            double num4 = 0.0;
            numArray[index4] = num4;
            int index5 = 4;
            double num5 = 0.0;
            numArray[index5] = num5;
            int index6 = 5;
            double num6 = 0.0;
            numArray[index6] = num6;
            this.projectiveParameters = numArray;
          }
          else
          {
            double[] numArray = new double[9];
            int index1 = 0;
            double num1 = 0.0;
            numArray[index1] = num1;
            int index2 = 1;
            double num2 = 0.0;
            numArray[index2] = num2;
            int index3 = 2;
            double num3 = 0.0;
            numArray[index3] = num3;
            int index4 = 3;
            double num4 = 0.0;
            numArray[index4] = num4;
            int index5 = 4;
            double num5 = 0.0;
            numArray[index5] = num5;
            int index6 = 5;
            double num6 = 0.0;
            numArray[index6] = num6;
            int index7 = 6;
            double num7 = 0.0;
            numArray[index7] = num7;
            int index8 = 7;
            double num8 = 0.0;
            numArray[index8] = num8;
            int index9 = 8;
            double num9 = 0.0;
            numArray[index9] = num9;
            this.projectiveParameters = numArray;
          }
        }
      }

      public virtual void setUpdateNeeded(bool updateNeeded)
      {
        this.updateNeeded = updateNeeded;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 195, (byte) 103, (byte) 42, (byte) 166})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void set(params double[] p)
      {
        for (int i = 0; i < p.Length; ++i)
          this.set(i, p[i]);
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 44, (byte) 95, (byte) 8, (byte) 157, (byte) 102, (byte) 113, (byte) 121, (byte) 99, (byte) 111, (byte) 120, (byte) 99, (byte) 111, (byte) 152, (byte) 177, (byte) 142, (byte) 104, (byte) 221, (byte) 123, (byte) 216, (byte) 137, (byte) 144})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void compose(object H1, bool inverse1, object H2, bool inverse2)
      {
        // ISSUE: type reference
        ByteCodeHelper.DynamicCast(H1, __typeref (ProjectiveTransformer.Parameters), "com.googlecode.javacv.cpp.opencv_core$CvMat");
        // ISSUE: type reference
        ByteCodeHelper.DynamicCast(H2, __typeref (ProjectiveTransformer.Parameters), "com.googlecode.javacv.cpp.opencv_core$CvMat");
        int num1 = inverse1 ? 1 : 0;
        int num2 = inverse2 ? 1 : 0;
        if (this.projectiveParameters.Length == 8 && ProjectiveTransformer.access\u0024000(this.this\u00240) != null)
        {
          if (num1 != 0 && num2 != 0)
          {
            object src1 = H2;
            object obj1 = H1;
            object obj2 = this.H;
            object src2 = obj1;
            object dst = obj2;
            opencv_core.cvMatMul(src1, src2, dst);
            opencv_core.cvInvert(this.H, this.H);
          }
          else if (num1 != 0)
          {
            opencv_core.cvInvert(H1, this.H);
            object src1 = this.H;
            object obj1 = H2;
            object obj2 = this.H;
            object src2 = obj1;
            object dst = obj2;
            opencv_core.cvMatMul(src1, src2, dst);
          }
          else if (num2 != 0)
          {
            opencv_core.cvInvert(H2, this.H);
            object src1 = H1;
            object obj1 = this.H;
            object obj2 = this.H;
            object src2 = obj1;
            object dst = obj2;
            opencv_core.cvMatMul(src1, src2, dst);
          }
          else
          {
            object src1 = H1;
            object obj1 = H2;
            object obj2 = this.H;
            object src2 = obj1;
            object dst = obj2;
            opencv_core.cvMatMul(src1, src2, dst);
          }
          if (ProjectiveTransformer.access\u0024000(this.this\u00240).Length == 0)
          {
            if (0 < 8)
            {
              double[] numArray = this.projectiveParameters;
              object obj = this.H;
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            }
            else
              this.setUpdateNeeded(true);
          }
          else
          {
            // ISSUE: type reference
            ByteCodeHelper.DynamicCast(ProjectiveTransformer.access\u0024600().get(), __typeref (ProjectiveTransformer.Parameters), "com.googlecode.javacv.cpp.opencv_core$CvMat");
            ProjectiveTransformer.access\u0024000(this.this\u00240);
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          }
        }
        else
        {
          string str = "Compose operation not supported.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new UnsupportedOperationException(str);
        }
      }

      public virtual bool isUpdateNeeded()
      {
        return this.updateNeeded;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 187, (byte) 108, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual ProjectiveTransformer.Parameters clone()
      {
        ProjectiveTransformer.Parameters parameters = new ProjectiveTransformer.Parameters(this.this\u00240);
        parameters.set((ImageTransformer.Parameters) this);
        return parameters;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 47, (byte) 101, (byte) 110, (byte) 191, (byte) 29, (byte) 161, (byte) 127, (byte) 3})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void compose(ImageTransformer.Parameters p1, bool inverse1, ImageTransformer.Parameters p2, bool inverse2)
      {
        int num1 = inverse1 ? 1 : 0;
        int num2 = inverse2 ? 1 : 0;
        ProjectiveTransformer.Parameters parameters1 = (ProjectiveTransformer.Parameters) p1;
        ProjectiveTransformer.Parameters parameters2 = (ProjectiveTransformer.Parameters) p2;
        if (ProjectiveTransformer.access\u0024100(this.this\u00240) != null && ProjectiveTransformer.access\u0024200(this.this\u00240) != null && (ProjectiveTransformer.access\u0024300(this.this\u00240) != null && ProjectiveTransformer.access\u0024400(this.this\u00240) != null) && parameters1.fakeIdentity)
          return;
        object h1 = parameters1.getH();
        int num3 = num1;
        object h2 = parameters2.getH();
        bool flag = num2 != 0;
        object obj = h2;
        int num4 = num3 != 0 ? 1 : 0;
        object H2 = obj;
        int num5 = flag ? 1 : 0;
        this.compose(h1, num4 != 0, H2, num5 != 0);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 60, (byte) 102})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object getN()
      {
        this.update();
        return this.n2;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 64, (byte) 102})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object getR()
      {
        this.update();
        return this.R2;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 68, (byte) 102})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object getT()
      {
        this.update();
        return this.t2;
      }

      public virtual bool preoptimize()
      {
        return false;
      }

      public virtual double[] getSubspace()
      {
        return (double[]) null;
      }

      public virtual void setSubspace(params double[] p)
      {
      }

      [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
      [Modifiers]
      [EditorBrowsable(EditorBrowsableState.Never)]
      [LineNumberTable((ushort) 277)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object \u003Cbridge\u003Eclone()
      {
        return (object) this.clone();
      }

      [Modifiers]
      [EditorBrowsable(EditorBrowsableState.Never)]
      [LineNumberTable((ushort) 277)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual ImageTransformer.Parameters \u003Cbridge\u003Eclone()
      {
        return (ImageTransformer.Parameters) this.clone();
      }

      [HideFromJava]
      ImageTransformer.Parameters ImageTransformer.Parameters.com\u002Egooglecode\u002Ejavacv\u002EImageTransformer\u0024Parameters\u002F\u0028\u0029Lcom\u002Egooglecode\u002Ejavacv\u002EImageTransformer\u0024Parameters\u003Bclone()
      {
        return this.\u003Cbridge\u003Eclone();
      }
    }
  }
}
