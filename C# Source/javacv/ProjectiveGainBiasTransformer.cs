// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ProjectiveGainBiasTransformer
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace com.googlecode.javacv
{
  public class ProjectiveGainBiasTransformer : ProjectiveTransformer
  {
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal X24x4;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal temp3x1;
    private object X;
    private int numGains;
    private int numBiases;
    [Modifiers]
    internal new static bool \u0024assertionsDisabled;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 134, (byte) 133, (byte) 245, (byte) 77})]
    static ProjectiveGainBiasTransformer()
    {
      ProjectiveTransformer.__\u003Cclinit\u003E();
      ProjectiveGainBiasTransformer.\u0024assertionsDisabled = !((Class) ClassLiteral<ProjectiveGainBiasTransformer>.Value).desiredAssertionStatus();
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 133, (byte) 159, (byte) 74, (byte) 255, (byte) 5, (byte) 76, (byte) 103, (byte) 238, (byte) 53, (byte) 154, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectiveGainBiasTransformer(object K1, object K2, object R, object t, object n, double[] referencePoints1, double[] referencePoints2, object X, int numGains, int numBiases)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(K1, __typeref (ProjectiveGainBiasTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(K2, __typeref (ProjectiveGainBiasTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(R, __typeref (ProjectiveGainBiasTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(t, __typeref (ProjectiveGainBiasTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(n, __typeref (ProjectiveGainBiasTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(X, __typeref (ProjectiveGainBiasTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      object K1_1 = K1;
      object obj1 = K2;
      object obj2 = R;
      object obj3 = t;
      object obj4 = n;
      double[] numArray1 = referencePoints1;
      double[] numArray2 = referencePoints2;
      double[] numArray3 = numArray1;
      object obj5 = obj4;
      object obj6 = obj3;
      object obj7 = obj2;
      object K2_1 = obj1;
      object R1 = obj7;
      object t1 = obj6;
      object n1 = obj5;
      double[] referencePoints1_1 = numArray3;
      double[] referencePoints2_1 = numArray2;
      // ISSUE: explicit constructor call
      base.\u002Ector(K1_1, K2_1, R1, t1, n1, referencePoints1_1, referencePoints2_1);
      ProjectiveGainBiasTransformer gainBiasTransformer = this;
      this.X = (object) null;
      this.numGains = 0;
      this.numBiases = 0;
      if (X == null)
      {
        this.X = (object) null;
        this.numGains = numGains;
        this.numBiases = numBiases;
      }
      else
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    public virtual int getNumGains()
    {
      return this.numGains;
    }

    public virtual int getNumBiases()
    {
      return this.numBiases;
    }

    [LineNumberTable((ushort) 207)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ProjectiveGainBiasTransformer.Parameters createParameters()
    {
      return new ProjectiveGainBiasTransformer.Parameters(this);
    }

    [Modifiers]
    [LineNumberTable((ushort) 34)]
    internal static int access\u0024000([In] ProjectiveGainBiasTransformer obj0)
    {
      return obj0.numGains;
    }

    [Modifiers]
    [LineNumberTable((ushort) 34)]
    internal static int access\u0024100([In] ProjectiveGainBiasTransformer obj0)
    {
      return obj0.numBiases;
    }

    [Modifiers]
    [LineNumberTable((ushort) 34)]
    internal static object access\u0024200([In] ProjectiveGainBiasTransformer obj0)
    {
      return obj0.X;
    }

    [Modifiers]
    internal static ThreadLocal access\u0024300()
    {
      return ProjectiveGainBiasTransformer.temp3x1;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 119, (byte) 81, (byte) 142, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void prepareTransform(object X2, int pyramidLevel, ProjectiveGainBiasTransformer.Parameters p, bool inverse)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(X2, __typeref (ProjectiveGainBiasTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      p.getA();
      p.getB();
      opencv_core.cvSetIdentity(X2);
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 126, (byte) 127, (byte) 23, (byte) 136, (byte) 159, (byte) 28, (byte) 100, (byte) 139, (byte) 161, (byte) 122, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void transformGainBias(object srcImage, object dstImage, object roi, int pyramidLevel, ImageTransformer.Parameters parameters, bool inverse)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(srcImage, __typeref (ProjectiveGainBiasTransformer), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dstImage, __typeref (ProjectiveGainBiasTransformer), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(roi, __typeref (ProjectiveGainBiasTransformer), "com.googlecode.javacv.cpp.opencv_core$CvRect");
      int num1 = inverse ? 1 : 0;
      ProjectiveGainBiasTransformer.Parameters parameters1 = (ProjectiveGainBiasTransformer.Parameters) parameters;
      if (Arrays.equals(parameters1.getGainBiasParameters(), parameters1.getIdentityGainBiasParameters()) && (this.X == null || parameters1.fakeIdentity) || this.X == null && this.numGains == 0 && this.numBiases == 0)
      {
        if (srcImage == dstImage)
          return;
        opencv_core.cvCopy(srcImage, dstImage);
      }
      else
      {
        // ISSUE: type reference
        object X2 = ByteCodeHelper.DynamicCast(ProjectiveGainBiasTransformer.X24x4.get(), __typeref (ProjectiveGainBiasTransformer), "com.googlecode.javacv.cpp.opencv_core$CvMat");
        int num2 = pyramidLevel;
        ProjectiveGainBiasTransformer.Parameters parameters2 = parameters1;
        bool flag = num1 != 0;
        ProjectiveGainBiasTransformer.Parameters parameters3 = parameters2;
        int pyramidLevel1 = num2;
        ProjectiveGainBiasTransformer.Parameters p = parameters3;
        int num3 = flag ? 1 : 0;
        this.prepareTransform(X2, pyramidLevel1, p, num3 != 0);
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
    }

    public virtual object getX()
    {
      return this.X;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 112, (byte) 113, (byte) 120, (byte) 98, (byte) 106, (byte) 100, (byte) 107, (byte) 159, (byte) 21, (byte) 119, (byte) 109, (byte) 127, (byte) 14, (byte) 127, (byte) 9, (byte) 98, (byte) 226, (byte) 54, (byte) 233, (byte) 78, (byte) 230, (byte) 80, (byte) 127, (byte) 2, (byte) 111, (byte) 179, (byte) 105, (byte) 244, (byte) 94, (byte) 243, (byte) 79})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void transform(ImageTransformer.Data[] data, object roi, ImageTransformer.Parameters[] parameters, bool[] inverses)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(roi, __typeref (ProjectiveGainBiasTransformer), "com.googlecode.javacv.cpp.opencv_core$CvRect");
      if (!ProjectiveGainBiasTransformer.\u0024assertionsDisabled && data.Length != parameters.Length)
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
              object obj1 = data1.transImg != null ? data1.transImg : data1.dstImg;
              int num2 = inverses != null ? (inverses[index] ? 1 : 0) : 0;
              object srcImage1 = data1.srcImg;
              object obj2 = obj1;
              object obj3 = roi;
              int num3 = data1.pyramidLevel;
              ImageTransformer.Parameters parameters1 = parameters[index];
              bool flag1 = num2 != 0;
              ImageTransformer.Parameters parameters2 = parameters1;
              int num4 = num3;
              object obj4 = obj3;
              object dstImage1 = obj2;
              object roi1 = obj4;
              int pyramidLevel1 = num4;
              ImageTransformer.Parameters parameters3 = parameters2;
              int num5 = flag1 ? 1 : 0;
              this.transform(srcImage1, dstImage1, roi1, pyramidLevel1, parameters3, num5 != 0);
              object srcImage2 = obj1;
              object obj5 = obj1;
              object obj6 = roi;
              int num6 = data1.pyramidLevel;
              ImageTransformer.Parameters parameters4 = parameters[index];
              bool flag2 = num2 != 0;
              ImageTransformer.Parameters parameters5 = parameters4;
              int num7 = num6;
              object obj7 = obj6;
              object dstImage2 = obj5;
              object roi2 = obj7;
              int pyramidLevel2 = num7;
              ImageTransformer.Parameters parameters6 = parameters5;
              int num8 = flag2 ? 1 : 0;
              this.transformGainBias(srcImage2, dstImage2, roi2, pyramidLevel2, parameters6, num8 != 0);
            }
            else
              num1 = 0;
          }
        }
        if (num1 != 0)
          return;
        ProjectiveGainBiasTransformer\u00241Cache transformer1Cache = !(data[0].cache is ProjectiveGainBiasTransformer\u00241Cache) ? (ProjectiveGainBiasTransformer\u00241Cache) null : (ProjectiveGainBiasTransformer\u00241Cache) data[0].cache;
        if (transformer1Cache == null || transformer1Cache.length != data.Length)
          data[0].cache = (object) (transformer1Cache = new ProjectiveGainBiasTransformer\u00241Cache(this, data.Length));
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
    [LineNumberTable((ushort) 34)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ProjectiveTransformer.Parameters \u003Cbridge\u003EcreateParameters()
    {
      return (ProjectiveTransformer.Parameters) this.createParameters();
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 34)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override ImageTransformer.Parameters \u003Cbridge\u003EcreateParameters()
    {
      return (ImageTransformer.Parameters) this.createParameters();
    }

    [InnerClass]
    [SourceFile("ProjectiveGainBiasTransformer.java")]
    public class Parameters : ProjectiveTransformer.Parameters
    {
      [Modifiers]
      internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<ProjectiveGainBiasTransformer>.Value).desiredAssertionStatus();
      [Modifiers]
      internal ProjectiveGainBiasTransformer this\u00240 = pgbt;
      protected internal double[] gainBiasParameters;
      protected internal double[] identityGainBiasParameters;
      private object A;
      private object b;

      [LineNumberTable((ushort) 210)]
      static Parameters()
      {
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 97, (byte) 240, (byte) 96, (byte) 110, (byte) 238, (byte) 32, (byte) 120, (byte) 105, (byte) 174, (byte) 105, (byte) 206, (byte) 127, (byte) 22, (byte) 122, (byte) 153, (byte) 185, (byte) 123, (byte) 146, (byte) 125, (byte) 122, (byte) 158, (byte) 127, (byte) 0, (byte) 178, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal Parameters(ProjectiveGainBiasTransformer pgbt)
        : base((ProjectiveTransformer) pgbt)
      {
        ProjectiveGainBiasTransformer.Parameters parameters1 = this;
        this.gainBiasParameters = (double[]) null;
        this.identityGainBiasParameters = (double[]) null;
        this.A = (object) null;
        this.b = (object) null;
        this.identityGainBiasParameters = new double[ProjectiveGainBiasTransformer.access\u0024000(pgbt) + ProjectiveGainBiasTransformer.access\u0024100(pgbt)];
        if (ProjectiveGainBiasTransformer.access\u0024000(pgbt) > 0)
        {
          ProjectiveGainBiasTransformer.Parameters parameters2 = this;
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
        }
        else if (ProjectiveGainBiasTransformer.access\u0024100(pgbt) > 0)
        {
          ProjectiveGainBiasTransformer.Parameters parameters2 = this;
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
        }
        else
        {
          switch (ProjectiveGainBiasTransformer.access\u0024000(pgbt))
          {
            case 0:
              if (!ProjectiveGainBiasTransformer.Parameters.\u0024assertionsDisabled && this.A != null)
              {
                Throwable.__\u003CsuppressFillInStackTrace\u003E();
                throw new AssertionError();
              }
              else
                break;
            case 1:
              double[] numArray1 = this.identityGainBiasParameters;
              object obj1 = this.A;
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            case 3:
              double[] numArray2 = this.identityGainBiasParameters;
              object obj2 = this.A;
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            case 9:
              object obj3 = this.A;
              double[] numArray3 = this.identityGainBiasParameters;
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            default:
              if (!ProjectiveGainBiasTransformer.Parameters.\u0024assertionsDisabled)
              {
                Throwable.__\u003CsuppressFillInStackTrace\u003E();
                throw new AssertionError();
              }
              else
                break;
          }
          switch (ProjectiveGainBiasTransformer.access\u0024100(pgbt))
          {
            case 0:
              if (!ProjectiveGainBiasTransformer.Parameters.\u0024assertionsDisabled && this.b != null)
              {
                Throwable.__\u003CsuppressFillInStackTrace\u003E();
                throw new AssertionError();
              }
              else
                break;
            case 1:
              double[] numArray4 = this.identityGainBiasParameters;
              ProjectiveGainBiasTransformer.access\u0024000(pgbt);
              object obj4 = this.b;
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            case 3:
              object obj5 = this.b;
              double[] numArray5 = this.identityGainBiasParameters;
              ProjectiveGainBiasTransformer.access\u0024000(pgbt);
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            default:
              if (!ProjectiveGainBiasTransformer.Parameters.\u0024assertionsDisabled)
              {
                Throwable.__\u003CsuppressFillInStackTrace\u003E();
                throw new AssertionError();
              }
              else
                break;
          }
          this.reset(false);
        }
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable((ushort) 254)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override int size()
      {
        return base.size() + ProjectiveGainBiasTransformer.access\u0024000(this.this\u00240) + ProjectiveGainBiasTransformer.access\u0024100(this.this\u00240);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 143, (byte) 103, (byte) 100, (byte) 138})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override double get(int i)
      {
        int num = base.size();
        if (i >= num)
          return this.gainBiasParameters[i - num];
        return base.get(i);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 151, (byte) 103, (byte) 100, (byte) 139, (byte) 110, (byte) 108, (byte) 169})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void set(int i, double p)
      {
        int num = base.size();
        if (i < num)
        {
          base.set(i, p);
        }
        else
        {
          if (this.gainBiasParameters[i - num] == p)
            return;
          this.gainBiasParameters[i - num] = p;
          this.setUpdateNeeded(true);
        }
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 72, (byte) 66, (byte) 104, (byte) 156, (byte) 103, (byte) 118, (byte) 169})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void resetGainBias(bool asIdentity)
      {
        int num = asIdentity ? 1 : 0;
        if (this.identityGainBiasParameters == null || Arrays.equals(this.gainBiasParameters, this.identityGainBiasParameters) && (this.fakeIdentity ? 1 : 0) == num)
          return;
        this.fakeIdentity = num != 0;
        this.gainBiasParameters = (double[]) this.identityGainBiasParameters.Clone();
        this.setUpdateNeeded(true);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 4, (byte) 104, (byte) 161, (byte) 127, (byte) 27, (byte) 122, (byte) 186, (byte) 186, (byte) 123, (byte) 146, (byte) 127, (byte) 3, (byte) 122, (byte) 191, (byte) 5, (byte) 127, (byte) 5, (byte) 178, (byte) 102, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal override void update()
      {
        if (!this.isUpdateNeeded())
          return;
        switch (ProjectiveGainBiasTransformer.access\u0024000(this.this\u00240))
        {
          case 0:
            if (!ProjectiveGainBiasTransformer.Parameters.\u0024assertionsDisabled && this.A != null)
            {
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new AssertionError();
            }
            else
              break;
          case 1:
            object obj1 = this.A;
            double num1 = this.gainBiasParameters[0];
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          case 3:
            object obj2 = this.A;
            double num2 = this.gainBiasParameters[0];
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          case 9:
            object obj3 = this.A;
            double[] numArray1 = this.gainBiasParameters;
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          default:
            if (!ProjectiveGainBiasTransformer.Parameters.\u0024assertionsDisabled)
            {
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new AssertionError();
            }
            else
              break;
        }
        switch (ProjectiveGainBiasTransformer.access\u0024100(this.this\u00240))
        {
          case 0:
            if (!ProjectiveGainBiasTransformer.Parameters.\u0024assertionsDisabled && this.b != null)
            {
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new AssertionError();
            }
            else
              break;
          case 1:
            object obj4 = this.b;
            double num3 = this.gainBiasParameters[ProjectiveGainBiasTransformer.access\u0024000(this.this\u00240)];
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          case 3:
            object obj5 = this.b;
            double[] numArray2 = this.gainBiasParameters;
            ProjectiveGainBiasTransformer.access\u0024000(this.this\u00240);
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          default:
            if (!ProjectiveGainBiasTransformer.Parameters.\u0024assertionsDisabled)
            {
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new AssertionError();
            }
            else
              break;
        }
        base.update();
        this.setUpdateNeeded(false);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 33, (byte) 108, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual ProjectiveGainBiasTransformer.Parameters clone()
      {
        ProjectiveGainBiasTransformer.Parameters parameters = new ProjectiveGainBiasTransformer.Parameters(this.this\u00240);
        parameters.set((ImageTransformer.Parameters) this);
        return parameters;
      }

      public virtual double[] getGainBiasParameters()
      {
        return this.gainBiasParameters;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 73, (byte) 66, (byte) 103, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void reset(bool asIdentity)
      {
        int num = asIdentity ? 1 : 0;
        base.reset(num != 0);
        this.resetGainBias(num != 0);
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 65, (byte) 165, (byte) 152, (byte) 110, (byte) 112, (byte) 144, (byte) 107, (byte) 117, (byte) 123, (byte) 124, (byte) 164, (byte) 104, (byte) 118, (byte) 100, (byte) 118, (byte) 100, (byte) 153, (byte) 223, (byte) 21, (byte) 104, (byte) 100, (byte) 115, (byte) 100, (byte) 147, (byte) 215, (byte) 127, (byte) 27, (byte) 122, (byte) 153, (byte) 185, (byte) 123, (byte) 146, (byte) 127, (byte) 3, (byte) 122, (byte) 159, (byte) 4, (byte) 127, (byte) 5, (byte) 146})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void composeGainBias(ImageTransformer.Parameters p1, bool inverse1, ImageTransformer.Parameters p2, bool inverse2)
      {
        int num1 = inverse1 ? 1 : 0;
        int num2 = inverse2 ? 1 : 0;
        if (!ProjectiveGainBiasTransformer.Parameters.\u0024assertionsDisabled && (num1 != 0 || num2 != 0))
        {
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new AssertionError();
        }
        else
        {
          ProjectiveGainBiasTransformer.Parameters parameters1 = (ProjectiveGainBiasTransformer.Parameters) p1;
          ProjectiveGainBiasTransformer.Parameters parameters2 = (ProjectiveGainBiasTransformer.Parameters) p2;
          object a1 = parameters1.getA();
          object src = parameters1.getB();
          object a2 = parameters2.getA();
          object b = parameters2.getB();
          if (this.b != null)
          {
            if (parameters1.fakeIdentity && ProjectiveGainBiasTransformer.access\u0024200(this.this\u00240) != null)
            {
              // ISSUE: type reference
              object obj1 = ByteCodeHelper.DynamicCast(ProjectiveGainBiasTransformer.access\u0024300().get(), __typeref (ProjectiveGainBiasTransformer.Parameters), "com.googlecode.javacv.cpp.opencv_core$CvMat");
              object src1 = ProjectiveGainBiasTransformer.access\u0024200(this.this\u00240);
              object obj2 = src;
              object obj3 = obj1;
              object src2 = obj2;
              object dst = obj3;
              opencv_core.cvMatMul(src1, src2, dst);
              src = obj1;
            }
            if (a2 == null && b == null)
              opencv_core.cvCopy(src, this.b);
            else if (src == null)
              opencv_core.cvCopy(b, this.b);
            else if (b == null)
            {
              object src1 = a2;
              object obj1 = src;
              object obj2 = this.b;
              object src2 = obj1;
              object dst = obj2;
              opencv_core.cvMatMul(src1, src2, dst);
            }
            else
            {
              object ca1 = a2;
              object obj1 = src;
              double num3 = 1.0;
              object obj2 = b;
              double num4 = 1.0;
              object obj3 = this.b;
              int num5 = 0;
              object obj4 = obj3;
              double num6 = num4;
              object obj5 = obj2;
              double num7 = num3;
              object ca2 = obj1;
              double d1 = num7;
              object ca3 = obj5;
              double d2 = num6;
              object ca4 = obj4;
              int i = num5;
              opencv_core.cvGEMM(ca1, ca2, d1, ca3, d2, ca4, i);
            }
          }
          if (this.A != null)
          {
            if (a1 == null)
              opencv_core.cvCopy(a2, this.A);
            else if (a2 == null)
            {
              opencv_core.cvCopy(a1, this.A);
            }
            else
            {
              object src1 = a2;
              object obj1 = a1;
              object obj2 = this.A;
              object src2 = obj1;
              object dst = obj2;
              opencv_core.cvMatMul(src1, src2, dst);
            }
          }
          switch (ProjectiveGainBiasTransformer.access\u0024000(this.this\u00240))
          {
            case 0:
              if (!ProjectiveGainBiasTransformer.Parameters.\u0024assertionsDisabled && this.A != null)
              {
                Throwable.__\u003CsuppressFillInStackTrace\u003E();
                throw new AssertionError();
              }
              else
                break;
            case 1:
              double[] numArray1 = this.gainBiasParameters;
              object obj6 = this.A;
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            case 3:
              double[] numArray2 = this.gainBiasParameters;
              object obj7 = this.A;
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            case 9:
              object obj8 = this.A;
              double[] numArray3 = this.gainBiasParameters;
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            default:
              if (!ProjectiveGainBiasTransformer.Parameters.\u0024assertionsDisabled)
              {
                Throwable.__\u003CsuppressFillInStackTrace\u003E();
                throw new AssertionError();
              }
              else
                break;
          }
          switch (ProjectiveGainBiasTransformer.access\u0024100(this.this\u00240))
          {
            case 0:
              if (ProjectiveGainBiasTransformer.Parameters.\u0024assertionsDisabled || this.b == null)
                break;
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new AssertionError();
            case 1:
              double[] numArray4 = this.gainBiasParameters;
              ProjectiveGainBiasTransformer.access\u0024000(this.this\u00240);
              object obj9 = this.b;
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            case 3:
              object obj10 = this.b;
              double[] numArray5 = this.gainBiasParameters;
              ProjectiveGainBiasTransformer.access\u0024000(this.this\u00240);
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            default:
              if (ProjectiveGainBiasTransformer.Parameters.\u0024assertionsDisabled)
                break;
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new AssertionError();
          }
        }
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 251, (byte) 102})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object getA()
      {
        this.update();
        return this.A;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 255, (byte) 102})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object getB()
      {
        this.update();
        return this.b;
      }

      public virtual double[] getIdentityGainBiasParameters()
      {
        return this.identityGainBiasParameters;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 66, (byte) 133, (byte) 106, (byte) 108})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void compose(ImageTransformer.Parameters p1, bool inverse1, ImageTransformer.Parameters p2, bool inverse2)
      {
        int num1 = inverse1 ? 1 : 0;
        int num2 = inverse2 ? 1 : 0;
        base.compose(p1, num1 != 0, p2, num2 != 0);
        this.composeGainBias(p1, num1 != 0, p2, num2 != 0);
      }

      [Modifiers]
      [EditorBrowsable(EditorBrowsableState.Never)]
      [LineNumberTable((ushort) 210)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual ProjectiveTransformer.Parameters \u003Cbridge\u003Eclone()
      {
        return (ProjectiveTransformer.Parameters) this.clone();
      }

      [Modifiers]
      [EditorBrowsable(EditorBrowsableState.Never)]
      [LineNumberTable((ushort) 210)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override ImageTransformer.Parameters \u003Cbridge\u003Eclone()
      {
        return (ImageTransformer.Parameters) this.clone();
      }

      [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
      [Modifiers]
      [EditorBrowsable(EditorBrowsableState.Never)]
      [LineNumberTable((ushort) 210)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override object \u003Cbridge\u003Eclone()
      {
        return (object) this.clone();
      }
    }
  }
}
