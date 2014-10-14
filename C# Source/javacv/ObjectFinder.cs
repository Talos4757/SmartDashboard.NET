// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ObjectFinder
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.nio;
using java.util;
using java.util.logging;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacv
{
  public class ObjectFinder : Object
  {
    [Modifiers]
    internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<ObjectFinder>.Value).desiredAssertionStatus();
    [Modifiers]
    private static Logger logger = Logger.getLogger(((Class) ClassLiteral<ObjectFinder>.Value).getName());
    private ObjectFinder.Settings settings;
    private object storage;
    private object tempStorage;
    private object objectKeypoints;
    private FloatBuffer[] objectDescriptors;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private ThreadLocal localpt1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private ThreadLocal localpt2;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private ThreadLocal localmask;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal H3x3;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 185, (byte) 245, (byte) 160, (byte) 109, (byte) 244, (byte) 160, (byte) 87})]
    static ObjectFinder()
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 131, (byte) 127, (byte) 3, (byte) 232, (byte) 160, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectFinder(object objectImage, object parameters, double distanceThreshold, int matchesMin)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(objectImage, __typeref (ObjectFinder), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(parameters, __typeref (ObjectFinder), "com.googlecode.javacv.cpp.opencv_features2d$CvSURFParams");
      base.\u002Ector();
      ObjectFinder objectFinder1 = this;
      ObjectFinder objectFinder2 = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMemStorage");
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 129, (byte) 113, (byte) 232, (byte) 160, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectFinder(object objectImage)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(objectImage, __typeref (ObjectFinder), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      base.\u002Ector();
      ObjectFinder objectFinder1 = this;
      ObjectFinder objectFinder2 = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMemStorage");
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 8, (byte) 232, (byte) 160, (byte) 96})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectFinder(ObjectFinder.Settings settings)
    {
      base.\u002Ector();
      ObjectFinder objectFinder1 = this;
      ObjectFinder objectFinder2 = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMemStorage");
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 82, (byte) 135})]
    public virtual void setSettings(ObjectFinder.Settings settings)
    {
      this.settings = settings;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeq");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 82, (byte) 159, (byte) 3, (byte) 114, (byte) 106, (byte) 127, (byte) 6, (byte) 111, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double[] locatePlanarObject([In] object obj0, [In] FloatBuffer[] obj1, [In] object obj2, [In] FloatBuffer[] obj3, [In] double[] obj4)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj0, __typeref (ObjectFinder), "[Lcom.googlecode.javacv.cpp.opencv_features2d$CvSURFPoint;");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj2, __typeref (ObjectFinder), "[Lcom.googlecode.javacv.cpp.opencv_features2d$CvSURFPoint;");
      object obj5 = obj0;
      FloatBuffer[] floatBufferArray1 = obj1;
      object obj6 = obj2;
      FloatBuffer[] floatBufferArray2 = obj3;
      object obj7 = obj6;
      FloatBuffer[] floatBufferArray3 = floatBufferArray1;
      object obj8 = obj7;
      FloatBuffer[] floatBufferArray4 = floatBufferArray2;
      int num = this.findPairs(obj5, floatBufferArray3, obj8, floatBufferArray4).size() / 2;
      ObjectFinder.logger.info(new StringBuilder().append(num).append(" matching pairs found").toString());
      if (num < this.settings.matchesMin)
        return (double[]) null;
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(this.localpt1.get(), __typeref (ObjectFinder), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 70, (byte) 102, (byte) 127, (byte) 20, (byte) 110, (byte) 114, (byte) 118, (byte) 119, (byte) 119, (byte) 119, (byte) 101, (byte) 226, (byte) 57, (byte) 233, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double compareSURFDescriptors([In] FloatBuffer obj0, [In] FloatBuffer obj1, [In] double obj2)
    {
      double num1 = 0.0;
      if (!ObjectFinder.\u0024assertionsDisabled)
      {
        if (((Buffer) obj0).capacity() == ((Buffer) obj1).capacity())
        {
          int num2 = ((Buffer) obj0).capacity();
          int num3 = 4;
          int num4 = -1;
          if ((num3 != num4 ? num2 % num3 : 0) == 0)
            goto label_4;
        }
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new AssertionError();
      }
label_4:
      int num5 = 0;
      while (num5 < ((Buffer) obj0).capacity())
      {
        double num2 = (double) (obj0.get(num5) - obj1.get(num5));
        double num3 = (double) (obj0.get(num5 + 1) - obj1.get(num5 + 1));
        double num4 = (double) (obj0.get(num5 + 2) - obj1.get(num5 + 2));
        double num6 = (double) (obj0.get(num5 + 3) - obj1.get(num5 + 3));
        num1 += num2 * num2 + num3 * num3 + num4 * num4 + num6 * num6;
        if (num1 <= obj2)
          num5 += 4;
        else
          break;
      }
      return num1;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 92, (byte) 81, (byte) 98, (byte) 148, (byte) 104, (byte) 237, (byte) 77, (byte) 112, (byte) 98})]
    private int naiveNearestNeighbor([In] FloatBuffer obj0, [In] int obj1, [In] object obj2, [In] FloatBuffer[] obj3)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj2, __typeref (ObjectFinder), "[Lcom.googlecode.javacv.cpp.opencv_features2d$CvSURFPoint;");
      int num1 = -1;
      double num2 = 1000000.0;
      double num3 = 1000000.0;
      if (0 < obj3.Length)
        throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_features2d$CvSURFPoint;");
      else if (num2 < this.settings.distanceThreshold * num3)
        return num1;
      else
        return -1;
    }

    [Signature("([Lcom/googlecode/javacv/cpp/opencv_features2d$CvSURFPoint;[Ljava/nio/FloatBuffer;[Lcom/googlecode/javacv/cpp/opencv_features2d$CvSURFPoint;[Ljava/nio/FloatBuffer;)Ljava/util/ArrayList<Ljava/lang/Integer;>;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 86, (byte) 95, (byte) 3, (byte) 106, (byte) 103, (byte) 237, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private ArrayList findPairs([In] object obj0, [In] FloatBuffer[] obj1, [In] object obj2, [In] FloatBuffer[] obj3)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj0, __typeref (ObjectFinder), "[Lcom.googlecode.javacv.cpp.opencv_features2d$CvSURFPoint;");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(obj2, __typeref (ObjectFinder), "[Lcom.googlecode.javacv.cpp.opencv_features2d$CvSURFPoint;");
      ArrayList arrayList = new ArrayList(2 * obj1.Length);
      if (0 >= obj1.Length)
        return arrayList;
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_features2d$CvSURFPoint;");
    }

    public virtual ObjectFinder.Settings getSettings()
    {
      return this.settings;
    }

    [LineNumberTable((ushort) 161)]
    public virtual double[] find(object image)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(image, __typeref (ObjectFinder), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSeq");
    }

    [InnerClass]
    [SourceFile("ObjectFinder.java")]
    [Serializable]
    public class Settings : BaseChildSettings
    {
      internal object objectImage;
      internal object parameters;
      internal double distanceThreshold;
      internal int matchesMin;
      internal double ransacReprojThreshold;

      [LineNumberTable(new byte[] {(byte) 13, (byte) 104, (byte) 103, (byte) 117, (byte) 112, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings()
      {
        ObjectFinder.Settings settings = this;
        this.objectImage = (object) null;
        this.parameters = opencv_features2d.cvSURFParams(500.0, 1);
        this.distanceThreshold = 0.6;
        this.matchesMin = 4;
        this.ransacReprojThreshold = 1.0;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected Settings([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      public virtual object getObjectImage()
      {
        return this.objectImage;
      }

      public virtual void setObjectImage(object objectImage)
      {
        // ISSUE: type reference
        ByteCodeHelper.DynamicCast(objectImage, __typeref (ObjectFinder.Settings), "com.googlecode.javacv.cpp.opencv_core$IplImage");
        this.objectImage = objectImage;
      }

      [LineNumberTable((ushort) 78)]
      public virtual bool isExtended()
      {
        object obj = this.parameters;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_features2d$CvSURFParams");
      }

      [LineNumberTable((ushort) 81)]
      public virtual void setExtended(bool extended)
      {
        int num1 = extended ? 1 : 0;
        object obj = this.parameters;
        int num2 = num1 == 0 ? 0 : 1;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_features2d$CvSURFParams");
      }

      [LineNumberTable((ushort) 85)]
      public virtual double getHessianThreshold()
      {
        object obj = this.parameters;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_features2d$CvSURFParams");
      }

      [LineNumberTable((ushort) 88)]
      public virtual void setHessianThreshold(double hessianThreshold)
      {
        object obj = this.parameters;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_features2d$CvSURFParams");
      }

      [LineNumberTable((ushort) 92)]
      public virtual int getnOctaves()
      {
        object obj = this.parameters;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_features2d$CvSURFParams");
      }

      [LineNumberTable((ushort) 95)]
      public virtual void setnOctaves(int nOctaves)
      {
        object obj = this.parameters;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_features2d$CvSURFParams");
      }

      [LineNumberTable((ushort) 99)]
      public virtual int getnOctaveLayers()
      {
        object obj = this.parameters;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_features2d$CvSURFParams");
      }

      [LineNumberTable((ushort) 102)]
      public virtual void setnOctaveLayers(int nOctaveLayers)
      {
        object obj = this.parameters;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_features2d$CvSURFParams");
      }

      public virtual double getDistanceThreshold()
      {
        return this.distanceThreshold;
      }

      public virtual void setDistanceThreshold(double distanceThreshold)
      {
        this.distanceThreshold = distanceThreshold;
      }

      public virtual int getMatchesMin()
      {
        return this.matchesMin;
      }

      public virtual void setMatchesMin(int matchesMin)
      {
        this.matchesMin = matchesMin;
      }

      public virtual double getRansacReprojThreshold()
      {
        return this.ransacReprojThreshold;
      }

      public virtual void setRansacReprojThreshold(double ransacReprojThreshold)
      {
        this.ransacReprojThreshold = ransacReprojThreshold;
      }
    }
  }
}
