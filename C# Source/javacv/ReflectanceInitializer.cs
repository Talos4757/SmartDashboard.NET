// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ReflectanceInitializer
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System.Runtime.CompilerServices;

namespace com.googlecode.javacv
{
  public class ReflectanceInitializer : Object
  {
    [Modifiers]
    internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<ReflectanceInitializer>.Value).desiredAssertionStatus();
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal mat3x1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal mat3x3;
    private GNImageAligner.Settings alignerSettings;
    private int smoothingSize;
    private double reflectanceMin;
    private CameraDevice cameraDevice;
    private ProjectorDevice projectorDevice;
    private object projectorImages;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 245, (byte) 95})]
    static ReflectanceInitializer()
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 183, (byte) 104, (byte) 104, (byte) 104, (byte) 106, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReflectanceInitializer(CameraDevice cameraDevice, ProjectorDevice projectorDevice, int channels, GNImageAligner.Settings alignerSettings, int smoothingSize, double reflectanceMin)
    {
      base.\u002Ector();
      ReflectanceInitializer reflectanceInitializer1 = this;
      this.alignerSettings = alignerSettings;
      this.smoothingSize = smoothingSize;
      this.reflectanceMin = reflectanceMin;
      this.cameraDevice = cameraDevice;
      this.projectorDevice = projectorDevice;
      ReflectanceInitializer reflectanceInitializer2 = this;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 180, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReflectanceInitializer(CameraDevice cameraDevice, ProjectorDevice projectorDevice, int channels, GNImageAligner.Settings alignerSettings)
      : this(cameraDevice, projectorDevice, channels, alignerSettings, 51, 0.01)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual object getProjectorImages()
    {
      return this.projectorImages;
    }

    [LineNumberTable((ushort) 80)]
    public virtual object initializeReflectance(object cameraImages, double[] roiPts, double[] ambientLight)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(cameraImages, __typeref (ReflectanceInitializer), "[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 104, (byte) 127, (byte) 3, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object initializePlaneParameters(object cameraImages, object reflectance, double[] roiPts, double[] ambientLight)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(cameraImages, __typeref (ReflectanceInitializer), "[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(reflectance, __typeref (ReflectanceInitializer), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      ProCamTransformer.__\u003Cclinit\u003E();
      ProCamTransformer proCamTransformer = new ProCamTransformer(roiPts, this.cameraDevice, this.projectorDevice, (object) null);
      object obj = this.projectorImages;
      throw new NoClassDefFoundError("[Lcom.googlecode.javacv.cpp.opencv_core$IplImage;");
    }
  }
}
