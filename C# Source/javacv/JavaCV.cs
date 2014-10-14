// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.JavaCV
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacv
{
  public class JavaCV : Object
  {
    [Modifiers]
    internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<JavaCV>.Value).desiredAssertionStatus();
    public const double SQRT2 = 1.4142135623731;
    public const double FLT_EPSILON = 1.19209289550781E-07;
    public const double DBL_EPSILON = 2.22044604925031E-16;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal A8x8;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal b8x1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal x8x1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal A3x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal b3x1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal n3x1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal H3x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal M3x2;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal S2x2;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal U3x2;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal V2x2;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal R13x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal R23x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal t13x1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal t23x1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal n13x1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal n23x1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal H13x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal H23x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal S3x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal U3x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal V3x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal values1x1;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 180, (byte) 245, (byte) 74})]
    static JavaCV()
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable((ushort) 38)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JavaCV()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 192, (byte) 114, (byte) 108, (byte) 103, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double[] unitize(double a, double b)
    {
      double num1 = Math.sqrt(a * a + b * b);
      if (num1 > 1.19209289550781E-07)
      {
        a /= num1;
        b /= num1;
      }
      double[] numArray = new double[2];
      int index1 = 0;
      double num2 = a;
      numArray[index1] = num2;
      int index2 = 1;
      double num3 = b;
      numArray[index2] = num3;
      return numArray;
    }

    [LineNumberTable((ushort) 694)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double norm(double[] v)
    {
      return JavaCV.norm(v, 2.0);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 36, (byte) 191, (byte) 3, (byte) 105, (byte) 105, (byte) 98, (byte) 117, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void hysteresisThreshold(object srcImage, object dstImage, double highThresh, double lowThresh, double maxValue)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(srcImage, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dstImage, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      int num1 = (int) Math.round(highThresh);
      int num2 = (int) Math.round(lowThresh);
      int num3 = (int) (sbyte) (int) Math.round(maxValue / 2.0);
      int num4 = (int) (sbyte) (int) Math.round(maxValue);
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable((ushort) 81)]
    public static void perspectiveTransform(double[] src, double[] dst, object map_matrix)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(map_matrix, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 117, (byte) 95, (byte) 57, (byte) 159, (byte) 21, (byte) 110, (byte) 104, (byte) 108, (byte) 136, (byte) 104, (byte) 242, (byte) 71, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object getPlaneParameters(double[] src, double[] dst, object invSrcK, object dstK, object R, object t, object n)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(invSrcK, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dstK, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(R, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(t, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(n, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj1 = ByteCodeHelper.DynamicCast(JavaCV.A3x3.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj2 = ByteCodeHelper.DynamicCast(JavaCV.b3x1.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      double[] dst1 = new double[6];
      double[] dst2 = new double[6];
      JavaCV.perspectiveTransform(src, dst1, invSrcK);
      opencv_core.cvInvert(dstK, obj1);
      JavaCV.perspectiveTransform(dst, dst2, obj1);
      if (0 < 3)
      {
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
      else
      {
        object ca1 = obj1;
        object obj3 = obj2;
        object obj4 = n;
        int num = 0;
        object obj5 = obj4;
        object ca2 = obj3;
        object ca3 = obj5;
        int i = num;
        opencv_core.cvSolve(ca1, ca2, ca3, i);
        return n;
      }
    }

    [LineNumberTable((ushort) 263)]
    public static double homogToRt(object S, object U, object V, object R1, object t1, object n1, object R2, object t2, object n2)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(S, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(U, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(V, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(R1, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(t1, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(n1, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(R2, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(t2, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(n2, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 71, (byte) 102, (byte) 105, (byte) 112, (byte) 43, (byte) 171, (byte) 109, (byte) 112, (byte) 41, (byte) 166, (byte) 109, (byte) 109, (byte) 112, (byte) 106, (byte) 101, (byte) 227, (byte) 61, (byte) 235, (byte) 70, (byte) 109, (byte) 106, (byte) 112, (byte) 106, (byte) 101, (byte) 227, (byte) 61, (byte) 232, (byte) 71, (byte) 112, (byte) 50, (byte) 166, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double norm(double[] v, double p)
    {
      double num1 = 0.0;
      if (p == 1.0)
      {
        double[] numArray = v;
        int length = numArray.Length;
        for (int index = 0; index < length; ++index)
        {
          double num2 = numArray[index];
          num1 += Math.abs(num2);
        }
      }
      else if (p == 2.0)
      {
        double[] numArray = v;
        int length = numArray.Length;
        for (int index = 0; index < length; ++index)
        {
          double num2 = numArray[index];
          num1 += num2 * num2;
        }
        num1 = Math.sqrt(num1);
      }
      else if (p == double.PositiveInfinity)
      {
        double[] numArray = v;
        int length = numArray.Length;
        for (int index = 0; index < length; ++index)
        {
          double num2 = Math.abs(numArray[index]);
          if (num2 > num1)
            num1 = num2;
        }
      }
      else if (p == double.NegativeInfinity)
      {
        num1 = double.MaxValue;
        double[] numArray = v;
        int length = numArray.Length;
        for (int index = 0; index < length; ++index)
        {
          double num2 = Math.abs(numArray[index]);
          if (num2 < num1)
            num1 = num2;
        }
      }
      else
      {
        double[] numArray = v;
        int length = numArray.Length;
        for (int index = 0; index < length; ++index)
        {
          double num2 = numArray[index];
          num1 += Math.pow(Math.abs(num2), p);
        }
        num1 = Math.pow(num1, 1.0 / p);
      }
      return num1;
    }

    [LineNumberTable((ushort) 736)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double norm(object A, double p)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(A, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      object A1 = A;
      double num = p;
      object obj = (object) null;
      double p1 = num;
      object W = obj;
      return JavaCV.norm(A1, p1, W);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 214, (byte) 191, (byte) 3, (byte) 138, (byte) 105, (byte) 249, (byte) 73, (byte) 249, (byte) 71, (byte) 236, (byte) 73, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double norm(object A, double p, object W)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(A, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(W, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      double num = -1.0;
      if (p == 1.0)
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      else if (p == 2.0)
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      else if (p == double.PositiveInfinity)
      {
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
      else
      {
        if (JavaCV.\u0024assertionsDisabled)
          return num;
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new AssertionError();
      }
    }

    [LineNumberTable((ushort) 776)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double cond(object A, double p)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(A, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      object A1 = A;
      double num = p;
      object obj = (object) null;
      double p1 = num;
      object W = obj;
      return JavaCV.cond(A1, p1, W);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 204, (byte) 191, (byte) 3, (byte) 138, (byte) 109, (byte) 236, (byte) 73})]
    public static double cond(object A, double p, object W)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(A, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(W, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      if (p == 2.0)
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      else
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 196, (byte) 95, (byte) 3, (byte) 122})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double randn(object state, object sigma)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(state, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvRNG");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(sigma, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvScalar");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(JavaCV.values1x1.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvScalar");
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 207, (byte) 104, (byte) 104, (byte) 129, (byte) 120, (byte) 111, (byte) 111, (byte) 145, (byte) 118, (byte) 153})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void fractalTriangleWave(double[] line, int i, int j, double a, int roughness)
    {
      int index = (j - i) / 2 + i;
      if (i == j || i == index)
        return;
      line[index] = (line[i] + line[j]) / 2.0 + a;
      if (roughness > 0 && line.Length > roughness * (j - i))
      {
        JavaCV.fractalTriangleWave(line, i, index, 0.0, roughness);
        JavaCV.fractalTriangleWave(line, index, j, 0.0, roughness);
      }
      else
      {
        JavaCV.fractalTriangleWave(line, i, index, a / 1.4142135623731, roughness);
        JavaCV.fractalTriangleWave(line, index, j, -a / 1.4142135623731, roughness);
      }
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 186, (byte) 191, (byte) 3, (byte) 115})]
    public static void fractalTriangleWave(object image, object H, int roughness)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(H, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      if (!JavaCV.\u0024assertionsDisabled)
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      else
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 129, (byte) 145, (byte) 122, (byte) 122, (byte) 154, (byte) 102, (byte) 246, (byte) 78, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object getPerspectiveTransform(double[] src, double[] dst, object map_matrix)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(map_matrix, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj1 = ByteCodeHelper.DynamicCast(JavaCV.A8x8.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj2 = ByteCodeHelper.DynamicCast(JavaCV.b8x1.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj3 = ByteCodeHelper.DynamicCast(JavaCV.x8x1.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      int num1 = 0;
      if (num1 < 4)
      {
        int num2 = num1 * 8 + 0;
        double num3 = src[num1 * 2];
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
      else
      {
        object ca1 = obj1;
        object obj4 = obj2;
        object obj5 = obj3;
        int num2 = 0;
        object obj6 = obj5;
        object ca2 = obj4;
        object ca3 = obj6;
        int i = num2;
        opencv_core.cvSolve(ca1, ca2, ca3, i);
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 111, (byte) 95, (byte) 57, (byte) 122, (byte) 185, (byte) 159, (byte) 16, (byte) 112, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object getPerspectiveTransform(double[] src, double[] dst, object invSrcK, object dstK, object R, object t, object H)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(invSrcK, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dstK, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(R, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(t, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(H, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj1 = ByteCodeHelper.DynamicCast(JavaCV.n3x1.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      double[] src1 = src;
      double[] dst1 = dst;
      object invSrcK1 = invSrcK;
      object obj2 = dstK;
      object obj3 = R;
      object obj4 = t;
      object obj5 = obj1;
      object obj6 = obj4;
      object obj7 = obj3;
      object dstK1 = obj2;
      object R1 = obj7;
      object t1 = obj6;
      object n = obj5;
      JavaCV.getPlaneParameters(src1, dst1, invSrcK1, dstK1, R1, t1, n);
      object ca1 = t;
      object obj8 = obj1;
      double num1 = -1.0;
      object obj9 = R;
      double num2 = 1.0;
      object obj10 = H;
      int num3 = 2;
      object obj11 = obj10;
      double num4 = num2;
      object obj12 = obj9;
      double num5 = num1;
      object ca2 = obj8;
      double d1 = num5;
      object ca3 = obj12;
      double d2 = num4;
      object ca4 = obj11;
      int i = num3;
      opencv_core.cvGEMM(ca1, ca2, d1, ca3, d2, ca4, i);
      object src1_1 = dstK;
      object obj13 = H;
      object obj14 = H;
      object src2_1 = obj13;
      object dst2 = obj14;
      opencv_core.cvMatMul(src1_1, src2_1, dst2);
      object src1_2 = H;
      object obj15 = invSrcK;
      object obj16 = H;
      object src2_2 = obj15;
      object dst3 = obj16;
      opencv_core.cvMatMul(src1_2, src2_2, dst3);
      return H;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 107, (byte) 95, (byte) 60, (byte) 186, (byte) 191, (byte) 16, (byte) 112, (byte) 112, (byte) 99, (byte) 140, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void perspectiveTransform(double[] src, double[] dst, object invSrcK, object dstK, object R, object t, object n, bool invert)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(invSrcK, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dstK, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(R, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(t, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(n, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      int num1 = invert ? 1 : 0;
      // ISSUE: type reference
      object obj1 = ByteCodeHelper.DynamicCast(JavaCV.H3x3.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      object ca1 = t;
      object obj2 = n;
      double num2 = -1.0;
      object obj3 = R;
      double num3 = 1.0;
      object obj4 = obj1;
      int num4 = 2;
      object obj5 = obj4;
      double num5 = num3;
      object obj6 = obj3;
      double num6 = num2;
      object ca2 = obj2;
      double d1 = num6;
      object ca3 = obj6;
      double d2 = num5;
      object ca4 = obj5;
      int i = num4;
      opencv_core.cvGEMM(ca1, ca2, d1, ca3, d2, ca4, i);
      object src1_1 = dstK;
      object obj7 = obj1;
      object obj8 = obj1;
      object src2_1 = obj7;
      object dst1 = obj8;
      opencv_core.cvMatMul(src1_1, src2_1, dst1);
      object src1_2 = obj1;
      object obj9 = invSrcK;
      object obj10 = obj1;
      object src2_2 = obj9;
      object dst2 = obj10;
      opencv_core.cvMatMul(src1_2, src2_2, dst2);
      if (num1 != 0)
        opencv_core.cvInvert(obj1, obj1);
      JavaCV.perspectiveTransform(src, dst, obj1);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 102, (byte) 95, (byte) 20, (byte) 127, (byte) 21, (byte) 127, (byte) 21})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void HtoRt(object H, object R, object t)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(H, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(R, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(t, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(JavaCV.M3x2.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(JavaCV.S2x2.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(JavaCV.U3x2.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(JavaCV.V2x2.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      double[] numArray = new double[6];
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 97, (byte) 159, (byte) 37, (byte) 127, (byte) 47, (byte) 152, (byte) 127, (byte) 23, (byte) 127, (byte) 23, (byte) 127, (byte) 23, (byte) 127, (byte) 21, (byte) 191, (byte) 23})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double HnToRt(object H, object n, object R, object t)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(H, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(n, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(R, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(t, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj1 = ByteCodeHelper.DynamicCast(JavaCV.S3x3.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj2 = ByteCodeHelper.DynamicCast(JavaCV.U3x3.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj3 = ByteCodeHelper.DynamicCast(JavaCV.V3x3.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      object ca1 = H;
      object obj4 = obj1;
      object obj5 = obj2;
      object obj6 = obj3;
      int num = 0;
      object obj7 = obj6;
      object obj8 = obj5;
      object ca2 = obj4;
      object ca3 = obj8;
      object ca4 = obj7;
      int i = num;
      opencv_core.cvSVD(ca1, ca2, ca3, ca4, i);
      // ISSUE: type reference
      object obj9 = ByteCodeHelper.DynamicCast(JavaCV.R13x3.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj10 = ByteCodeHelper.DynamicCast(JavaCV.R23x3.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj11 = ByteCodeHelper.DynamicCast(JavaCV.t13x1.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj12 = ByteCodeHelper.DynamicCast(JavaCV.t23x1.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj13 = ByteCodeHelper.DynamicCast(JavaCV.n13x1.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj14 = ByteCodeHelper.DynamicCast(JavaCV.n23x1.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(JavaCV.H13x3.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(JavaCV.H23x3.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      object S = obj1;
      object obj15 = obj2;
      object obj16 = obj3;
      object obj17 = obj9;
      object obj18 = obj11;
      object obj19 = obj13;
      object obj20 = obj10;
      object obj21 = obj12;
      object obj22 = obj14;
      object obj23 = obj21;
      object obj24 = obj20;
      object obj25 = obj19;
      object obj26 = obj18;
      object obj27 = obj17;
      object obj28 = obj16;
      object U = obj15;
      object V = obj28;
      object R1 = obj27;
      object t1 = obj26;
      object n1 = obj25;
      object R2 = obj24;
      object t2 = obj23;
      object n2 = obj22;
      JavaCV.homogToRt(S, U, V, R1, t1, n1, R2, t2, n2);
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 79, (byte) 191, (byte) 91, (byte) 127, (byte) 47, (byte) 120, (byte) 127, (byte) 21})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double homogToRt(object H, object R1, object t1, object n1, object R2, object t2, object n2)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(H, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(R1, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(t1, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(n1, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(R2, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(t2, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(n2, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj1 = ByteCodeHelper.DynamicCast(JavaCV.S3x3.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj2 = ByteCodeHelper.DynamicCast(JavaCV.U3x3.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj3 = ByteCodeHelper.DynamicCast(JavaCV.V3x3.get(), __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      object ca1 = H;
      object obj4 = obj1;
      object obj5 = obj2;
      object obj6 = obj3;
      int num = 0;
      object obj7 = obj6;
      object obj8 = obj5;
      object ca2 = obj4;
      object ca3 = obj8;
      object ca4 = obj7;
      int i = num;
      opencv_core.cvSVD(ca1, ca2, ca3, ca4, i);
      object S = obj1;
      object obj9 = obj2;
      object obj10 = obj3;
      object obj11 = R1;
      object obj12 = t1;
      object obj13 = n1;
      object obj14 = R2;
      object obj15 = t2;
      object obj16 = n2;
      object obj17 = obj15;
      object obj18 = obj14;
      object obj19 = obj13;
      object obj20 = obj12;
      object obj21 = obj11;
      object obj22 = obj10;
      object U = obj9;
      object V = obj22;
      object R1_1 = obj21;
      object t1_1 = obj20;
      object n1_1 = obj19;
      object R2_1 = obj18;
      object t2_1 = obj17;
      object n2_1 = obj16;
      return JavaCV.homogToRt(S, U, V, R1_1, t1_1, n1_1, R2_1, t2_1, n2_1);
    }

    [LineNumberTable((ushort) 317)]
    public static void adaptiveBinarization(object src, object sumimage, object sqsumimage, object dst, bool invert, int minwindow, int maxwindow, double varmultiplier, double k)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(sumimage, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(sqsumimage, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable((ushort) 637)]
    public static void minMaxS(object src, double min, double max, object dst)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable((ushort) 733)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double norm(object A)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(A, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      return JavaCV.norm(A, 2.0);
    }

    [LineNumberTable((ushort) 773)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double cond(object A)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(A, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      return JavaCV.cond(A, 2.0);
    }

    [LineNumberTable((ushort) 803)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double randn(object state, double sigma)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(state, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvRNG");
      return JavaCV.randn(state, opencv_core.cvRealScalar(sigma));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 189, (byte) 108, (byte) 102, (byte) 111, (byte) 154})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double median(double[] doubles)
    {
      double[] numArray = (double[]) doubles.Clone();
      Arrays.sort(numArray);
      int length = doubles.Length;
      int num1 = 2;
      int num2 = -1;
      if ((num1 != num2 ? length % num1 : 0) == 0)
        return (numArray[doubles.Length / 2 - 1] + numArray[doubles.Length / 2]) / 2.0;
      else
        return numArray[doubles.Length / 2];
    }

    [Signature("<T:Ljava/lang/Object;>([TT;)TT;")]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 198, (byte) 108, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static object median(object[] objects)
    {
      object[] objArray = (object[]) objects.Clone();
      Arrays.sort(objArray);
      return objArray[objArray.Length / 2];
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 204, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void fractalTriangleWave(double[] line, int i, int j, double a)
    {
      JavaCV.fractalTriangleWave(line, i, j, a, -1);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 186, (byte) 95, (byte) 3, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void fractalTriangleWave(object image, object H)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(H, __typeref (JavaCV), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      object image1 = image;
      object obj = H;
      int num = -1;
      object H1 = obj;
      int roughness = num;
      JavaCV.fractalTriangleWave(image1, H1, roughness);
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 15, (byte) 112, (byte) 99, (byte) 134, (byte) 255, (byte) 55, (byte) 71, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void main(string[] args)
    {
      System.get_out().println(new StringBuilder().append("JavaCV build timestamp ").append(((Class) ClassLiteral<JavaCV>.Value).getPackage().getImplementationVersion() ?? "unknown").append("\n").append("Copyright (C) 2009,2010,2011 Samuel Audet <samuel.audet@gmail.com>\n").append("Project site: http://code.google.com/p/javacv/\n\n").append("Licensed under the GNU General Public License version 2 (GPLv2) with Classpath exception.\n").append("Please refer to LICENSE.txt or http://www.gnu.org/licenses/ for details.").toString());
      System.exit(0);
    }
  }
}
