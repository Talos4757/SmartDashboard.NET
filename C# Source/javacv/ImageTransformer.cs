// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ImageTransformer
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacv
{
  public interface ImageTransformer
  {
    void transform(ImageTransformer.Data[] itdarr, object cr, ImageTransformer.Parameters[] itparr, bool[] barr);

    void transform(object cm1, object cm2, ImageTransformer.Parameters itp, bool b);

    ImageTransformer.Parameters createParameters();

    [InnerClass]
    [SourceFile("ImageTransformer.java")]
    class Data : Object
    {
      public object srcImg;
      public object subImg;
      public object srcDotImg;
      public object mask;
      public double zeroThreshold;
      public double outlierThreshold;
      public int pyramidLevel;
      public object transImg;
      public object dstImg;
      public int dstCount;
      public int dstCountZero;
      public int dstCountOutlier;
      public double srcDstDot;
      public double[] dstDstDot;
      protected internal object cache;

      [LineNumberTable(new byte[] {(byte) 159, (byte) 134, (byte) 127, (byte) 74, (byte) 232, (byte) 78, (byte) 124, (byte) 120, (byte) 167, (byte) 110, (byte) 117, (byte) 108, (byte) 167, (byte) 231, (byte) 40, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 106, (byte) 106, (byte) 104, (byte) 104, (byte) 104, (byte) 116})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Data(object srcImg, object subImg, object srcDotImg, object mask, double zeroThreshold, double outlierThreshold, int pyramidLevel, object transImg, object dstImg, int dstDstDotLength)
      {
        // ISSUE: type reference
        ByteCodeHelper.DynamicCast(srcImg, __typeref (ImageTransformer.Data), "com.googlecode.javacv.cpp.opencv_core$IplImage");
        // ISSUE: type reference
        ByteCodeHelper.DynamicCast(subImg, __typeref (ImageTransformer.Data), "com.googlecode.javacv.cpp.opencv_core$IplImage");
        // ISSUE: type reference
        ByteCodeHelper.DynamicCast(srcDotImg, __typeref (ImageTransformer.Data), "com.googlecode.javacv.cpp.opencv_core$IplImage");
        // ISSUE: type reference
        ByteCodeHelper.DynamicCast(mask, __typeref (ImageTransformer.Data), "com.googlecode.javacv.cpp.opencv_core$IplImage");
        // ISSUE: type reference
        ByteCodeHelper.DynamicCast(transImg, __typeref (ImageTransformer.Data), "com.googlecode.javacv.cpp.opencv_core$IplImage");
        // ISSUE: type reference
        ByteCodeHelper.DynamicCast(dstImg, __typeref (ImageTransformer.Data), "com.googlecode.javacv.cpp.opencv_core$IplImage");
        base.\u002Ector();
        ImageTransformer.Data data = this;
        this.srcImg = (object) null;
        this.subImg = (object) null;
        this.srcDotImg = (object) null;
        this.mask = (object) null;
        this.zeroThreshold = 0.0;
        this.outlierThreshold = 0.0;
        this.pyramidLevel = 0;
        this.transImg = (object) null;
        this.dstImg = (object) null;
        this.dstCount = 0;
        this.dstCountZero = 0;
        this.dstCountOutlier = 0;
        this.srcDstDot = 0.0;
        this.dstDstDot = (double[]) null;
        this.cache = (object) null;
        this.srcImg = srcImg;
        this.subImg = subImg;
        this.srcDotImg = srcDotImg;
        this.mask = mask;
        this.zeroThreshold = zeroThreshold;
        this.outlierThreshold = outlierThreshold;
        this.pyramidLevel = pyramidLevel;
        this.transImg = transImg;
        this.dstImg = dstImg;
        this.dstDstDot = dstDstDotLength != 0 ? new double[dstDstDotLength] : (double[]) null;
      }
    }

    [InnerClass]
    [Implements(new string[] {"java.lang.Cloneable"})]
    [SourceFile("ImageTransformer.java")]
    interface Parameters : Cloneable.__Interface
    {
      void set(ImageTransformer.Parameters itp);

      double get(int i);

      void set(int i, double d);

      double getConstraintError();

      void setSubspace(params double[] darr);

      int size();

      ImageTransformer.Parameters clone();

      double[] getSubspace();

      double[] get();

      bool preoptimize();

      void set(params double[] darr);

      void reset(bool b);

      void compose(ImageTransformer.Parameters itp1, bool b1, ImageTransformer.Parameters itp2, bool b2);
    }
  }
}
