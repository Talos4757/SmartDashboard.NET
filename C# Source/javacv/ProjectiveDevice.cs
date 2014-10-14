// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ProjectiveDevice
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacv
{
  public class ProjectiveDevice : Object
  {
    [Modifiers]
    internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<ProjectiveDevice>.Value).desiredAssertionStatus();
    private ProjectiveDevice.Settings settings;
    public int imageWidth;
    public int imageHeight;
    public object cameraMatrix;
    public object distortionCoeffs;
    public object extrParams;
    public object reprojErrs;
    public double avgReprojErr;
    public double maxReprojErr;
    public object R;
    public object T;
    public object E;
    public object F;
    public double avgEpipolarErr;
    public double maxEpipolarErr;
    public string colorOrder;
    public object colorMixingMatrix;
    public object additiveLight;
    public double avgColorErr;
    public double colorR2;
    private object undistortMap1;
    private object undistortMap2;
    private object distortMap1;
    private object distortMap2;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal temp3x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal B4x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal a4x1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal t3x1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal relativeR3x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal relativeT3x1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal R13x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal P13x4;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal R23x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal P23x4;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 177, (byte) 245, (byte) 162, (byte) 25})]
    static ProjectiveDevice()
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 178, (byte) 232, (byte) 161, (byte) 6, (byte) 142, (byte) 252, (byte) 69, (byte) 188, (byte) 107, (byte) 110, (byte) 236, (byte) 160, (byte) 152, (byte) 238, (byte) 122, (byte) 238, (byte) 158, (byte) 29, (byte) 102, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectiveDevice(string name)
    {
      base.\u002Ector();
      ProjectiveDevice projectiveDevice = this;
      this.imageWidth = 0;
      this.imageHeight = 0;
      this.cameraMatrix = (object) null;
      this.distortionCoeffs = (object) null;
      this.extrParams = (object) null;
      this.reprojErrs = (object) null;
      this.R = (object) null;
      this.T = (object) null;
      this.E = (object) null;
      this.F = (object) null;
      this.colorOrder = "BGR";
      this.colorMixingMatrix = (object) null;
      this.additiveLight = (object) null;
      this.colorR2 = 1.0;
      this.undistortMap1 = (object) null;
      this.undistortMap2 = (object) null;
      this.distortMap1 = (object) null;
      this.distortMap2 = (object) null;
      this.setSettings(new ProjectiveDevice.Settings()
      {
        name = name
      });
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 184, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectiveDevice(string name, File file)
      : this(name)
    {
      ProjectiveDevice projectiveDevice = this;
      this.readParameters(file);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 188, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectiveDevice(string name, string filename)
      : this(name)
    {
      ProjectiveDevice projectiveDevice = this;
      this.readParameters(filename);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 130, (byte) 145, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectiveDevice(string name, object fs)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(fs, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
      // ISSUE: explicit constructor call
      this.\u002Ector(name);
      ProjectiveDevice projectiveDevice = this;
      this.readParameters(fs);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 3, (byte) 232, (byte) 160, (byte) 245, (byte) 142, (byte) 252, (byte) 69, (byte) 188, (byte) 107, (byte) 110, (byte) 236, (byte) 160, (byte) 152, (byte) 238, (byte) 122, (byte) 238, (byte) 158, (byte) 46, (byte) 103, (byte) 104, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectiveDevice(ProjectiveDevice.Settings settings)
    {
      base.\u002Ector();
      ProjectiveDevice projectiveDevice = this;
      this.imageWidth = 0;
      this.imageHeight = 0;
      this.cameraMatrix = (object) null;
      this.distortionCoeffs = (object) null;
      this.extrParams = (object) null;
      this.reprojErrs = (object) null;
      this.R = (object) null;
      this.T = (object) null;
      this.E = (object) null;
      this.F = (object) null;
      this.colorOrder = "BGR";
      this.colorMixingMatrix = (object) null;
      this.additiveLight = (object) null;
      this.colorR2 = 1.0;
      this.undistortMap1 = (object) null;
      this.undistortMap2 = (object) null;
      this.distortMap1 = (object) null;
      this.distortMap2 = (object) null;
      this.setSettings(settings);
      if (!(settings is ProjectiveDevice.CalibratedSettings))
        return;
      this.readParameters(((ProjectiveDevice.CalibratedSettings) settings).parametersFile);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual void setSettings(ProjectiveDevice.Settings settings)
    {
      this.settings = settings;
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 142, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void readParameters(File file)
    {
      this.readParameters(file.getAbsolutePath());
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable((ushort) 771)]
    public virtual void readParameters(string filename)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 158, (byte) 204, (byte) 81, (byte) 99, (byte) 191, (byte) 26, (byte) 134, (byte) 119, (byte) 99, (byte) 223, (byte) 26, (byte) 127, (byte) 1, (byte) 127, (byte) 1, (byte) 191, (byte) 11, (byte) 119, (byte) 120, (byte) 119, (byte) 120, (byte) 119, (byte) 120, (byte) 119, (byte) 120, (byte) 127, (byte) 2, (byte) 159, (byte) 2, (byte) 119, (byte) 120, (byte) 119, (byte) 120, (byte) 119, (byte) 120, (byte) 119, (byte) 120, (byte) 127, (byte) 2, (byte) 159, (byte) 2, (byte) 127, (byte) 1, (byte) 119, (byte) 120, (byte) 119, (byte) 120, (byte) 127, (byte) 2, (byte) 127, (byte) 2})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void readParameters(object fs)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(fs, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
      if (fs == null)
      {
        string str = new StringBuilder().append("Error: CvFileStorage is null, cannot read parameters for device ").append(this.getSettings().getName()).append(". Is the parametersFile correct?").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str);
      }
      else
      {
        object obj1 = opencv_core.cvAttrList();
        object cfs = fs;
        // ISSUE: variable of the null type
        __Null local = null;
        string name1 = this.getSettings().getName();
        object cfn = (object) local;
        string str1 = name1;
        object fileNodeByName = opencv_core.cvGetFileNodeByName(cfs, cfn, str1);
        if (fileNodeByName == null)
        {
          string str2 = new StringBuilder().append("Error: CvFileNode is null, cannot read parameters for device ").append(this.getSettings().getName()).append(". Is the name correct?").toString();
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new Exception(str2);
        }
        else
        {
          object fs1 = fs;
          object obj2 = fileNodeByName;
          string str2 = "imageWidth";
          int num1 = this.imageWidth;
          string str3 = str2;
          object map1 = obj2;
          string name2 = str3;
          int default_value1 = num1;
          this.imageWidth = opencv_core.cvReadIntByName(fs1, map1, name2, default_value1);
          object fs2 = fs;
          object obj3 = fileNodeByName;
          string str4 = "imageHeight";
          int num2 = this.imageHeight;
          string str5 = str4;
          object map2 = obj3;
          string name3 = str5;
          int default_value2 = num2;
          this.imageHeight = opencv_core.cvReadIntByName(fs2, map2, name3, default_value2);
          ProjectiveDevice.Settings settings = this.getSettings();
          object fs3 = fs;
          object obj4 = fileNodeByName;
          string str6 = "gamma";
          double responseGamma1 = this.getSettings().getResponseGamma();
          string str7 = str6;
          object map3 = obj4;
          string name4 = str7;
          double default_value3 = responseGamma1;
          double responseGamma2 = opencv_core.cvReadRealByName(fs3, map3, name4, default_value3);
          settings.setResponseGamma(responseGamma2);
          object fs4 = fs;
          object obj5 = fileNodeByName;
          string str8 = "cameraMatrix";
          object obj6 = obj1;
          string str9 = str8;
          object map4 = obj5;
          string name5 = str9;
          object attributes1 = obj6;
          if (opencv_core.cvReadByName(fs4, map4, name5, attributes1) != null)
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          this.cameraMatrix = (object) null;
          object fs5 = fs;
          object obj7 = fileNodeByName;
          string str10 = "distortionCoeffs";
          object obj8 = obj1;
          string str11 = str10;
          object map5 = obj7;
          string name6 = str11;
          object attributes2 = obj8;
          if (opencv_core.cvReadByName(fs5, map5, name6, attributes2) != null)
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          this.distortionCoeffs = (object) null;
          object fs6 = fs;
          object obj9 = fileNodeByName;
          string str12 = "extrParams";
          object obj10 = obj1;
          string str13 = str12;
          object map6 = obj9;
          string name7 = str13;
          object attributes3 = obj10;
          if (opencv_core.cvReadByName(fs6, map6, name7, attributes3) != null)
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          this.extrParams = (object) null;
          object fs7 = fs;
          object obj11 = fileNodeByName;
          string str14 = "reprojErrs";
          object obj12 = obj1;
          string str15 = str14;
          object map7 = obj11;
          string name8 = str15;
          object attributes4 = obj12;
          if (opencv_core.cvReadByName(fs7, map7, name8, attributes4) != null)
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          this.reprojErrs = (object) null;
          object fs8 = fs;
          object obj13 = fileNodeByName;
          string str16 = "avgReprojErr";
          double num3 = this.avgReprojErr;
          string str17 = str16;
          object map8 = obj13;
          string name9 = str17;
          double default_value4 = num3;
          this.avgReprojErr = opencv_core.cvReadRealByName(fs8, map8, name9, default_value4);
          object fs9 = fs;
          object obj14 = fileNodeByName;
          string str18 = "maxReprojErr";
          double num4 = this.maxReprojErr;
          string str19 = str18;
          object map9 = obj14;
          string name10 = str19;
          double default_value5 = num4;
          this.maxReprojErr = opencv_core.cvReadRealByName(fs9, map9, name10, default_value5);
          object fs10 = fs;
          object obj15 = fileNodeByName;
          string str20 = "R";
          object obj16 = obj1;
          string str21 = str20;
          object map10 = obj15;
          string name11 = str21;
          object attributes5 = obj16;
          if (opencv_core.cvReadByName(fs10, map10, name11, attributes5) != null)
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          this.R = (object) null;
          object fs11 = fs;
          object obj17 = fileNodeByName;
          string str22 = "T";
          object obj18 = obj1;
          string str23 = str22;
          object map11 = obj17;
          string name12 = str23;
          object attributes6 = obj18;
          if (opencv_core.cvReadByName(fs11, map11, name12, attributes6) != null)
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          this.T = (object) null;
          object fs12 = fs;
          object obj19 = fileNodeByName;
          string str24 = "E";
          object obj20 = obj1;
          string str25 = str24;
          object map12 = obj19;
          string name13 = str25;
          object attributes7 = obj20;
          if (opencv_core.cvReadByName(fs12, map12, name13, attributes7) != null)
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          this.E = (object) null;
          object fs13 = fs;
          object obj21 = fileNodeByName;
          string str26 = "F";
          object obj22 = obj1;
          string str27 = str26;
          object map13 = obj21;
          string name14 = str27;
          object attributes8 = obj22;
          if (opencv_core.cvReadByName(fs13, map13, name14, attributes8) != null)
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          this.F = (object) null;
          object fs14 = fs;
          object obj23 = fileNodeByName;
          string str28 = "avgEpipolarErr";
          double num5 = this.avgEpipolarErr;
          string str29 = str28;
          object map14 = obj23;
          string name15 = str29;
          double default_value6 = num5;
          this.avgEpipolarErr = opencv_core.cvReadRealByName(fs14, map14, name15, default_value6);
          object fs15 = fs;
          object obj24 = fileNodeByName;
          string str30 = "maxEpipolarErr";
          double num6 = this.maxEpipolarErr;
          string str31 = str30;
          object map15 = obj24;
          string name16 = str31;
          double default_value7 = num6;
          this.maxEpipolarErr = opencv_core.cvReadRealByName(fs15, map15, name16, default_value7);
          object fs16 = fs;
          object obj25 = fileNodeByName;
          string str32 = "colorOrder";
          string str33 = this.colorOrder;
          string str34 = str32;
          object map16 = obj25;
          string name17 = str34;
          string default_value8 = str33;
          this.colorOrder = opencv_core.cvReadStringByName(fs16, map16, name17, default_value8);
          object fs17 = fs;
          object obj26 = fileNodeByName;
          string str35 = "colorMixingMatrix";
          object obj27 = obj1;
          string str36 = str35;
          object map17 = obj26;
          string name18 = str36;
          object attributes9 = obj27;
          if (opencv_core.cvReadByName(fs17, map17, name18, attributes9) != null)
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          this.colorMixingMatrix = (object) null;
          object fs18 = fs;
          object obj28 = fileNodeByName;
          string str37 = "additiveLight";
          object obj29 = obj1;
          string str38 = str37;
          object map18 = obj28;
          string name19 = str38;
          object attributes10 = obj29;
          if (opencv_core.cvReadByName(fs18, map18, name19, attributes10) != null)
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          this.additiveLight = (object) null;
          object fs19 = fs;
          object obj30 = fileNodeByName;
          string str39 = "avgColorErr";
          double num7 = this.avgColorErr;
          string str40 = str39;
          object map19 = obj30;
          string name20 = str40;
          double default_value9 = num7;
          this.avgColorErr = opencv_core.cvReadRealByName(fs19, map19, name20, default_value9);
          object fs20 = fs;
          object obj31 = fileNodeByName;
          string str41 = "colorR2";
          double num8 = this.colorR2;
          string str42 = str41;
          object map20 = obj31;
          string name21 = str42;
          double default_value10 = num8;
          this.colorR2 = opencv_core.cvReadRealByName(fs20, map20, name21, default_value10);
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 34, (byte) 145, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double[] normalize(double[] xu, object K)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(K, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      double[] numArray = (double[]) xu.Clone();
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 255, (byte) 100, (byte) 100, (byte) 144, (byte) 112, (byte) 112, (byte) 112, (byte) 100, (byte) 133, (byte) 141, (byte) 110, (byte) 116, (byte) 114, (byte) 108, (byte) 110, (byte) 127, (byte) 1, (byte) 127, (byte) 11, (byte) 127, (byte) 11, (byte) 107, (byte) 235, (byte) 58, (byte) 235, (byte) 72, (byte) 244, (byte) 53, (byte) 235, (byte) 77})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double[] undistort(double[] xd, double[] k)
    {
      double num1 = k[0];
      double num2 = k[1];
      double num3 = k.Length <= 4 ? 0.0 : k[4];
      double num4 = k.Length <= 5 ? 0.0 : k[5];
      double num5 = k.Length <= 6 ? 0.0 : k[6];
      double num6 = k.Length <= 7 ? 0.0 : k[7];
      double num7 = k[2];
      double num8 = k[3];
      double[] numArray = (double[]) xd.Clone();
      for (int index1 = 0; index1 < xd.Length / 2; ++index1)
      {
        double num9 = numArray[index1 * 2];
        double num10 = numArray[index1 * 2 + 1];
        double num11 = xd[index1 * 2];
        double num12 = xd[index1 * 2 + 1];
        for (int index2 = 0; index2 < 20; ++index2)
        {
          double num13 = num9 * num9 + num10 * num10;
          double num14 = 1.0 + num1 * num13 + num2 * num13 * num13 + num3 * num13 * num13 * num13;
          double num15 = 2.0 * num7 * num9 * num10 + num8 * (num13 + 2.0 * num9 * num9);
          double num16 = num7 * (num13 + 2.0 * num10 * num10) + 2.0 * num8 * num9 * num10;
          num9 = (num11 - num15) / num14;
          num10 = (num12 - num16) / num14;
        }
        numArray[index1 * 2] = num9;
        numArray[index1 * 2 + 1] = num10;
      }
      return numArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 30, (byte) 81, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double[] unnormalize(double[] xn, object K)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(K, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      double[] numArray = (double[]) xn.Clone();
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 33, (byte) 100, (byte) 100, (byte) 144, (byte) 112, (byte) 112, (byte) 112, (byte) 100, (byte) 133, (byte) 141, (byte) 110, (byte) 104, (byte) 106, (byte) 110, (byte) 127, (byte) 1, (byte) 127, (byte) 11, (byte) 127, (byte) 11, (byte) 112, (byte) 242, (byte) 56, (byte) 235, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double[] distort(double[] xu, double[] k)
    {
      double num1 = k[0];
      double num2 = k[1];
      double num3 = k.Length <= 4 ? 0.0 : k[4];
      double num4 = k.Length <= 5 ? 0.0 : k[5];
      double num5 = k.Length <= 6 ? 0.0 : k[6];
      double num6 = k.Length <= 7 ? 0.0 : k[7];
      double num7 = k[2];
      double num8 = k[3];
      double[] numArray = (double[]) xu.Clone();
      for (int index = 0; index < xu.Length / 2; ++index)
      {
        double num9 = xu[index * 2];
        double num10 = xu[index * 2 + 1];
        double num11 = num9 * num9 + num10 * num10;
        double num12 = 1.0 + num1 * num11 + num2 * num11 * num11 + num3 * num11 * num11 * num11;
        double num13 = 2.0 * num7 * num9 * num10 + num8 * (num11 + 2.0 * num9 * num9);
        double num14 = num7 * (num11 + 2.0 * num10 * num10) + 2.0 * num8 * num9 * num10;
        numArray[index * 2] = num9 * num12 + num13;
        numArray[index * 2 + 1] = num10 * num12 + num14;
      }
      return numArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 26, (byte) 98, (byte) 112, (byte) 99, (byte) 190, (byte) 253, (byte) 94})]
    private void initUndistortMaps([In] bool obj0)
    {
      int num1 = obj0 ? 1 : 0;
      if (this.undistortMap1 != null && this.undistortMap2 != null)
        return;
      if (num1 != 0)
      {
        ProjectiveDevice projectiveDevice = this;
        int num2 = this.imageWidth;
        int num3 = this.imageHeight;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }
      else
      {
        ProjectiveDevice projectiveDevice = this;
        int num2 = this.imageWidth;
        int num3 = this.imageHeight;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 14, (byte) 127, (byte) 5, (byte) 102, (byte) 223, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void undistort(object src, object dst, bool useFixedPointMaps)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      int num = useFixedPointMaps ? 1 : 0;
      if (src == null || dst == null)
        return;
      this.getUndistortMap1(num != 0);
      this.getUndistortMap2(num != 0);
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvScalar");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 17, (byte) 130, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getUndistortMap1(bool useFixedPointMaps)
    {
      this.initUndistortMaps(useFixedPointMaps);
      return this.undistortMap1;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 16, (byte) 130, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getUndistortMap2(bool useFixedPointMaps)
    {
      this.initUndistortMaps(useFixedPointMaps);
      return this.undistortMap2;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 27, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double[] undistort(params double[] x)
    {
      ProjectiveDevice.normalize(x, this.cameraMatrix);
      object obj = this.distortionCoeffs;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 152, (byte) 112, (byte) 250, (byte) 88})]
    private void initDistortMaps([In] bool obj0)
    {
      if (this.distortMap1 != null && this.distortMap2 != null)
        return;
      int num1 = this.imageWidth;
      int num2 = this.imageHeight;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$IplImage");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 2, (byte) 95, (byte) 5, (byte) 102, (byte) 223, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void distort(object src, object dst, bool useFixedPointMaps)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      int num = useFixedPointMaps ? 1 : 0;
      if (src == null || dst == null)
        return;
      this.getDistortMap1(num != 0);
      this.getDistortMap2(num != 0);
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvScalar");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 5, (byte) 98, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getDistortMap1(bool useFixedPointMaps)
    {
      this.initDistortMaps(useFixedPointMaps);
      return this.distortMap1;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 4, (byte) 98, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getDistortMap2(bool useFixedPointMaps)
    {
      this.initDistortMaps(useFixedPointMaps);
      return this.distortMap2;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 255, (byte) 159, (byte) 3, (byte) 154})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getBackProjectionMatrix(object n, double d, object B)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(n, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(B, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(ProjectiveDevice.temp3x3.get(), __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable((ushort) 691)]
    public static void write(string filename, params ProjectiveDevice[] devices)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
    }

    public virtual ProjectiveDevice.Settings getSettings()
    {
      return this.settings;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 217, (byte) 113, (byte) 134, (byte) 158, (byte) 119, (byte) 119, (byte) 190, (byte) 104, (byte) 124, (byte) 104, (byte) 124, (byte) 104, (byte) 124, (byte) 104, (byte) 124, (byte) 121, (byte) 153, (byte) 104, (byte) 124, (byte) 104, (byte) 124, (byte) 104, (byte) 124, (byte) 104, (byte) 124, (byte) 121, (byte) 153, (byte) 122, (byte) 104, (byte) 124, (byte) 104, (byte) 124, (byte) 121, (byte) 153, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void writeParameters(object fs)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(fs, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
      object obj1 = opencv_core.cvAttrList();
      object cfs1 = fs;
      string name = this.getSettings().getName();
      int num1 = 6;
      // ISSUE: variable of the null type
      __Null local = null;
      object obj2 = obj1;
      string str1 = (string) local;
      int num2 = num1;
      string str1_1 = name;
      int i1 = num2;
      string str2_1 = str1;
      object cal1 = obj2;
      opencv_core.cvStartWriteStruct(cfs1, str1_1, i1, str2_1, cal1);
      object cfs2 = fs;
      string str2 = "imageWidth";
      int num3 = this.imageWidth;
      string str3 = str2;
      int i2 = num3;
      opencv_core.cvWriteInt(cfs2, str3, i2);
      object cfs3 = fs;
      string str4 = "imageHeight";
      int num4 = this.imageHeight;
      string str5 = str4;
      int i3 = num4;
      opencv_core.cvWriteInt(cfs3, str5, i3);
      object cfs4 = fs;
      string str6 = "responseGamma";
      double responseGamma = this.getSettings().getResponseGamma();
      string str7 = str6;
      double d1 = responseGamma;
      opencv_core.cvWriteReal(cfs4, str7, d1);
      if (this.cameraMatrix != null)
      {
        object cfs5 = fs;
        string str8 = "cameraMatrix";
        object obj3 = this.cameraMatrix;
        object obj4 = obj1;
        object obj5 = obj3;
        string str9 = str8;
        object p = obj5;
        object cal2 = obj4;
        opencv_core.cvWrite(cfs5, str9, p, cal2);
      }
      if (this.distortionCoeffs != null)
      {
        object cfs5 = fs;
        string str8 = "distortionCoeffs";
        object obj3 = this.distortionCoeffs;
        object obj4 = obj1;
        object obj5 = obj3;
        string str9 = str8;
        object p = obj5;
        object cal2 = obj4;
        opencv_core.cvWrite(cfs5, str9, p, cal2);
      }
      if (this.extrParams != null)
      {
        object cfs5 = fs;
        string str8 = "extrParams";
        object obj3 = this.extrParams;
        object obj4 = obj1;
        object obj5 = obj3;
        string str9 = str8;
        object p = obj5;
        object cal2 = obj4;
        opencv_core.cvWrite(cfs5, str9, p, cal2);
      }
      if (this.reprojErrs != null)
      {
        object cfs5 = fs;
        string str8 = "reprojErrs";
        object obj3 = this.reprojErrs;
        object obj4 = obj1;
        object obj5 = obj3;
        string str9 = str8;
        object p = obj5;
        object cal2 = obj4;
        opencv_core.cvWrite(cfs5, str9, p, cal2);
      }
      object cfs6 = fs;
      string str10 = "avgReprojErr";
      double num5 = this.avgReprojErr;
      string str11 = str10;
      double d2 = num5;
      opencv_core.cvWriteReal(cfs6, str11, d2);
      object cfs7 = fs;
      string str12 = "maxReprojErr";
      double num6 = this.maxReprojErr;
      string str13 = str12;
      double d3 = num6;
      opencv_core.cvWriteReal(cfs7, str13, d3);
      if (this.R != null)
      {
        object cfs5 = fs;
        string str8 = "R";
        object obj3 = this.R;
        object obj4 = obj1;
        object obj5 = obj3;
        string str9 = str8;
        object p = obj5;
        object cal2 = obj4;
        opencv_core.cvWrite(cfs5, str9, p, cal2);
      }
      if (this.T != null)
      {
        object cfs5 = fs;
        string str8 = "T";
        object obj3 = this.T;
        object obj4 = obj1;
        object obj5 = obj3;
        string str9 = str8;
        object p = obj5;
        object cal2 = obj4;
        opencv_core.cvWrite(cfs5, str9, p, cal2);
      }
      if (this.E != null)
      {
        object cfs5 = fs;
        string str8 = "E";
        object obj3 = this.E;
        object obj4 = obj1;
        object obj5 = obj3;
        string str9 = str8;
        object p = obj5;
        object cal2 = obj4;
        opencv_core.cvWrite(cfs5, str9, p, cal2);
      }
      if (this.F != null)
      {
        object cfs5 = fs;
        string str8 = "F";
        object obj3 = this.F;
        object obj4 = obj1;
        object obj5 = obj3;
        string str9 = str8;
        object p = obj5;
        object cal2 = obj4;
        opencv_core.cvWrite(cfs5, str9, p, cal2);
      }
      object cfs8 = fs;
      string str14 = "avgEpipolarErr";
      double num7 = this.avgEpipolarErr;
      string str15 = str14;
      double d4 = num7;
      opencv_core.cvWriteReal(cfs8, str15, d4);
      object cfs9 = fs;
      string str16 = "maxEpipolarErr";
      double num8 = this.maxEpipolarErr;
      string str17 = str16;
      double d5 = num8;
      opencv_core.cvWriteReal(cfs9, str17, d5);
      object cfs10 = fs;
      string str18 = "colorOrder";
      string str19 = this.colorOrder;
      int num9 = 0;
      string str20 = str19;
      string str1_2 = str18;
      string str2_2 = str20;
      int i4 = num9;
      opencv_core.cvWriteString(cfs10, str1_2, str2_2, i4);
      if (this.colorMixingMatrix != null)
      {
        object cfs5 = fs;
        string str8 = "colorMixingMatrix";
        object obj3 = this.colorMixingMatrix;
        object obj4 = obj1;
        object obj5 = obj3;
        string str9 = str8;
        object p = obj5;
        object cal2 = obj4;
        opencv_core.cvWrite(cfs5, str9, p, cal2);
      }
      if (this.additiveLight != null)
      {
        object cfs5 = fs;
        string str8 = "additiveLight";
        object obj3 = this.additiveLight;
        object obj4 = obj1;
        object obj5 = obj3;
        string str9 = str8;
        object p = obj5;
        object cal2 = obj4;
        opencv_core.cvWrite(cfs5, str9, p, cal2);
      }
      object cfs11 = fs;
      string str21 = "avgColorErr";
      double num10 = this.avgColorErr;
      string str22 = str21;
      double d6 = num10;
      opencv_core.cvWriteReal(cfs11, str22, d6);
      object cfs12 = fs;
      string str23 = "colorR2";
      double num11 = this.colorR2;
      string str24 = str23;
      double d7 = num11;
      opencv_core.cvWriteReal(cfs12, str24, d7);
      opencv_core.cvEndWriteStruct(fs);
    }

    [LineNumberTable((ushort) 720)]
    public virtual void writeParameters(string filename)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 199, (byte) 154, (byte) 108, (byte) 108, (byte) 250, (byte) 74})]
    public virtual void rescale(int imageWidth, int imageHeight)
    {
      if (imageWidth == this.imageWidth && imageHeight == this.imageHeight || this.cameraMatrix == null)
        return;
      double num1 = (double) imageWidth / (double) this.imageWidth;
      double num2 = (double) imageHeight / (double) this.imageHeight;
      object obj1 = this.cameraMatrix;
      object obj2 = this.cameraMatrix;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 216, (byte) 103, (byte) 105, (byte) 127, (byte) 13, (byte) 102, (byte) 102, (byte) 102, (byte) 242, (byte) 59, (byte) 233, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int[] getRGBColorOrder()
    {
      int[] numArray = new int[3];
      for (int index = 0; index < 3; ++index)
      {
        int num1 = (int) Character.toUpperCase(String.instancehelper_charAt(this.colorOrder, index));
        int num2 = 66;
        if (num1 == num2)
        {
          numArray[index] = 2;
        }
        else
        {
          int num3 = 71;
          if (num1 == num3)
          {
            numArray[index] = 1;
          }
          else
          {
            int num4 = 82;
            if (num1 == num4)
              numArray[index] = 0;
            else if (!ProjectiveDevice.\u0024assertionsDisabled)
            {
              Throwable.__\u003CsuppressFillInStackTrace\u003E();
              throw new AssertionError();
            }
          }
        }
      }
      return numArray;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 58, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double[] distort(params double[] x)
    {
      ProjectiveDevice.normalize(x, this.cameraMatrix);
      object obj = this.distortionCoeffs;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 15, (byte) 159, (byte) 3, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void undistort(object src, object dst)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      object src1 = src;
      object obj = dst;
      bool flag = true;
      object dst1 = obj;
      int num = flag ? 1 : 0;
      this.undistort(src1, dst1, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 3, (byte) 127, (byte) 3, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void distort(object src, object dst)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(src, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(dst, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$IplImage");
      object src1 = src;
      object obj = dst;
      bool flag = true;
      object dst1 = obj;
      int num = flag ? 1 : 0;
      this.distort(src1, dst1, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 248, (byte) 191, (byte) 3, (byte) 191, (byte) 47})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getFrontoParallelH(double[] pts, object n, object H)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(n, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(H, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(ProjectiveDevice.B4x3.get(), __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(ProjectiveDevice.a4x1.get(), __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(ProjectiveDevice.t3x1.get(), __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 238, (byte) 113, (byte) 127, (byte) 21, (byte) 127, (byte) 19, (byte) 159, (byte) 23, (byte) 127, (byte) 23, (byte) 127, (byte) 23, (byte) 159, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object getRectifyingHomography(ProjectiveDevice peer, object H)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(H, __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj1 = ByteCodeHelper.DynamicCast(ProjectiveDevice.relativeR3x3.get(), __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj2 = ByteCodeHelper.DynamicCast(ProjectiveDevice.relativeT3x1.get(), __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      object ca1_1 = this.R;
      object obj3 = peer.R;
      double num1 = 1.0;
      // ISSUE: variable of the null type
      __Null local = null;
      double num2 = 0.0;
      object obj4 = obj1;
      int num3 = 2;
      object obj5 = obj4;
      double num4 = num2;
      object obj6 = (object) local;
      double num5 = num1;
      object ca2_1 = obj3;
      double d1_1 = num5;
      object ca3_1 = obj6;
      double d2_1 = num4;
      object ca4_1 = obj5;
      int i1 = num3;
      opencv_core.cvGEMM(ca1_1, ca2_1, d1_1, ca3_1, d2_1, ca4_1, i1);
      object ca1_2 = obj1;
      object obj7 = peer.T;
      double num6 = -1.0;
      object obj8 = this.T;
      double num7 = 1.0;
      object obj9 = obj2;
      int num8 = 0;
      object obj10 = obj9;
      double num9 = num7;
      object obj11 = obj8;
      double num10 = num6;
      object ca2_2 = obj7;
      double d1_2 = num10;
      object ca3_2 = obj11;
      double d2_2 = num9;
      object ca4_2 = obj10;
      int i2 = num8;
      opencv_core.cvGEMM(ca1_2, ca2_2, d1_2, ca3_2, d2_2, ca4_2, i2);
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(ProjectiveDevice.R13x3.get(), __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(ProjectiveDevice.P13x4.get(), __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(ProjectiveDevice.R23x3.get(), __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(ProjectiveDevice.P23x4.get(), __typeref (ProjectiveDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      opencv_core.cvSize((peer.imageWidth + this.imageWidth) / 2, (peer.imageHeight + this.imageHeight) / 2);
      object obj12 = peer.cameraMatrix;
      object obj13 = this.cameraMatrix;
      object obj14 = peer.distortionCoeffs;
      object obj15 = this.distortionCoeffs;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvSize");
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable((ushort) 661)]
    public static ProjectiveDevice[] read(string filename)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 51, (byte) 98, (byte) 112, (byte) 38, (byte) 166, (byte) 104, (byte) 98, (byte) 120, (byte) 121, (byte) 42, (byte) 40, (byte) 232, (byte) 69, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void write(string filename, params ProjectiveDevice[][] devices)
    {
      int length1 = 0;
      ProjectiveDevice[][] projectiveDeviceArray1 = devices;
      int length2 = projectiveDeviceArray1.Length;
      for (int index = 0; index < length2; ++index)
      {
        ProjectiveDevice[] projectiveDeviceArray2 = projectiveDeviceArray1[index];
        length1 += projectiveDeviceArray2.Length;
      }
      ProjectiveDevice[] projectiveDeviceArray3 = new ProjectiveDevice[length1];
      int num = 0;
      ProjectiveDevice[][] projectiveDeviceArray4 = devices;
      int length3 = projectiveDeviceArray4.Length;
      for (int index1 = 0; index1 < length3; ++index1)
      {
        ProjectiveDevice[] projectiveDeviceArray2 = projectiveDeviceArray4[index1];
        int length4 = projectiveDeviceArray2.Length;
        for (int index2 = 0; index2 < length4; ++index2)
        {
          ProjectiveDevice projectiveDevice1 = projectiveDeviceArray2[index2];
          ProjectiveDevice[] projectiveDeviceArray5 = projectiveDeviceArray3;
          int index3 = num;
          ++num;
          ProjectiveDevice projectiveDevice2 = projectiveDevice1;
          projectiveDeviceArray5[index3] = projectiveDevice2;
        }
      }
      ProjectiveDevice.write(filename, projectiveDeviceArray3);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 91, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void writeParameters(File file)
    {
      this.writeParameters(file.getAbsolutePath());
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 199, (byte) 159, (byte) 48, (byte) 117, (byte) 59, (byte) 166, (byte) 255, (byte) 162, (byte) 8, (byte) 85})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      string str1 = new StringBuilder().append(this.getSettings().getName()).append(" (").append(this.imageWidth).append(" x ").append(this.imageHeight).append(")\n").toString();
      for (int index = 0; index < String.instancehelper_length(this.getSettings().getName()); ++index)
        str1 = new StringBuilder().append(str1).append("=").toString();
      StringBuilder stringBuilder1 = new StringBuilder().append(str1).append("\nIntrinsics\n----------\ncamera matrix = ");
      if (this.cameraMatrix == null)
      {
        string str2 = "null";
        StringBuilder stringBuilder2 = stringBuilder1.append(str2).append("\n").append("distortion coefficients = ");
        object obj1 = this.distortionCoeffs != null ? this.distortionCoeffs : (object) "null";
        object obj2;
        if (obj1 != null)
        {
          object obj3 = obj1 as object;
          if (obj3 == null)
            throw new IncompatibleClassChangeError();
          obj2 = obj3;
        }
        else
          obj2 = (object) null;
        object obj4 = obj2;
        StringBuilder stringBuilder3 = stringBuilder2.append(obj4).append("\n").append("reprojection RMS/max error (pixels) = ").append((float) this.avgReprojErr).append(" / ").append((float) this.maxReprojErr).append("\n\n").append("Extrinsics\n").append("----------\n").append("rotation = ");
        if (this.R == null)
        {
          string str3 = "null";
          StringBuilder stringBuilder4 = stringBuilder3.append(str3).append("\n").append("translation = ");
          if (this.T == null)
          {
            string str4 = "null";
            StringBuilder stringBuilder5 = stringBuilder4.append(str4).append("\n").append("epipolar RMS/max error (pixels) = ").append((float) this.avgEpipolarErr).append(" / ").append((float) this.maxEpipolarErr).append("\n\n").append("Color\n").append("-----\n").append("order = ").append(this.colorOrder).append("\n").append("mixing matrix = ");
            if (this.colorMixingMatrix == null)
            {
              string str5 = "null";
              StringBuilder stringBuilder6 = stringBuilder5.append(str5).append("\n").append("additive light = ");
              if (this.additiveLight == null)
              {
                string str6 = "null";
                return stringBuilder6.append(str6).append("\n").append("normalized RMSE (intensity) = ").append((float) this.avgColorErr).append("\n").append("R2 (intensity) = ").append((float) this.colorR2).toString();
              }
              else
              {
                object obj3 = this.additiveLight;
                throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
              }
            }
            else
            {
              object obj3 = this.colorMixingMatrix;
              throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
            }
          }
          else
          {
            object obj3 = this.T;
            throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
          }
        }
        else
        {
          object obj3 = this.R;
          throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
        }
      }
      else
      {
        object obj = this.cameraMatrix;
        throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
      }
    }

    [InnerClass]
    [SourceFile("ProjectiveDevice.java")]
    [Serializable]
    public class CalibratedSettings : ProjectiveDevice.Settings
    {
      internal File parametersFile;

      [LineNumberTable(new byte[] {(byte) 160, (byte) 154, (byte) 232, (byte) 69, (byte) 240, (byte) 59})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public CalibratedSettings()
      {
        ProjectiveDevice.CalibratedSettings calibratedSettings = this;
        this.parametersFile = new File("calibration.yaml");
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 156, (byte) 169, (byte) 16, (byte) 108})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public CalibratedSettings(ProjectiveDevice.CalibratedSettings settings)
        : base((ProjectiveDevice.Settings) settings)
      {
        ProjectiveDevice.CalibratedSettings calibratedSettings = this;
        this.parametersFile = new File("calibration.yaml");
        this.parametersFile = settings.parametersFile;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected CalibratedSettings([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      public virtual File getParametersFile()
      {
        return this.parametersFile;
      }

      public virtual void setParametersFile(File parametersFile)
      {
        this.parametersFile = parametersFile;
      }

      [LineNumberTable((ushort) 282)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getParametersFilename()
      {
        return this.parametersFile != null ? this.parametersFile.getPath() : "";
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 171, (byte) 154})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setParametersFilename(string parametersFilename)
      {
        this.parametersFile = parametersFilename == null || String.instancehelper_length(parametersFilename) == 0 ? (File) null : new File(parametersFilename);
      }
    }

    [InnerClass]
    [SourceFile("ProjectiveDevice.java")]
    [Serializable]
    public class CalibrationSettings : ProjectiveDevice.Settings
    {
      internal double initAspectRatio;
      internal int flags;

      [LineNumberTable(new byte[] {(byte) 44, (byte) 232, (byte) 71, (byte) 108, (byte) 235, (byte) 56})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public CalibrationSettings()
      {
        ProjectiveDevice.CalibrationSettings calibrationSettings = this;
        this.initAspectRatio = 1.0;
        this.flags = 14720;
      }

      [LineNumberTable(new byte[] {(byte) 46, (byte) 233, (byte) 69, (byte) 108, (byte) 235, (byte) 59, (byte) 109, (byte) 108})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public CalibrationSettings(ProjectiveDevice.CalibrationSettings settings)
        : base((ProjectiveDevice.Settings) settings)
      {
        ProjectiveDevice.CalibrationSettings calibrationSettings = this;
        this.initAspectRatio = 1.0;
        this.flags = 14720;
        this.initAspectRatio = settings.initAspectRatio;
        this.flags = settings.flags;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected CalibrationSettings([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      public virtual double getInitAspectRatio()
      {
        return this.initAspectRatio;
      }

      public virtual void setInitAspectRatio(double initAspectRatio)
      {
        this.initAspectRatio = initAspectRatio;
      }

      public virtual bool isUseIntrinsicGuess()
      {
        return (this.flags & 1) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 113, (byte) 66, (byte) 99, (byte) 144, (byte) 143})]
      public virtual void setUseIntrinsicGuess(bool useIntrinsicGuess)
      {
        if (useIntrinsicGuess)
          this.flags |= 1;
        else
          this.flags &= -2;
      }

      public virtual bool isFixAspectRatio()
      {
        return (this.flags & 2) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 111, (byte) 162, (byte) 99, (byte) 144, (byte) 143})]
      public virtual void setFixAspectRatio(bool fixAspectRatio)
      {
        if (fixAspectRatio)
          this.flags |= 2;
        else
          this.flags &= -3;
      }

      public virtual bool isFixPrincipalPoint()
      {
        return (this.flags & 4) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 108, (byte) 130, (byte) 99, (byte) 144, (byte) 143})]
      public virtual void setFixPrincipalPoint(bool fixPrincipalPoint)
      {
        if (fixPrincipalPoint)
          this.flags |= 4;
        else
          this.flags &= -5;
      }

      public virtual bool isZeroTangentDist()
      {
        return (this.flags & 8) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 105, (byte) 98, (byte) 99, (byte) 144, (byte) 143})]
      public virtual void setZeroTangentDist(bool zeroTangentDist)
      {
        if (zeroTangentDist)
          this.flags |= 8;
        else
          this.flags &= -9;
      }

      public virtual bool isFixLocalLength()
      {
        return (this.flags & 16) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 102, (byte) 66, (byte) 99, (byte) 145, (byte) 143})]
      public virtual void setFixLocalLength(bool fixLocalLength)
      {
        if (fixLocalLength)
          this.flags |= 16;
        else
          this.flags &= -17;
      }

      public virtual bool isFixK1()
      {
        return (this.flags & 32) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 100, (byte) 162, (byte) 99, (byte) 145, (byte) 143})]
      public virtual void setFixK1(bool fixK1)
      {
        if (fixK1)
          this.flags |= 32;
        else
          this.flags &= -33;
      }

      public virtual bool isFixK2()
      {
        return (this.flags & 64) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 97, (byte) 130, (byte) 99, (byte) 145, (byte) 143})]
      public virtual void setFixK2(bool fixK2)
      {
        if (fixK2)
          this.flags |= 64;
        else
          this.flags &= -65;
      }

      public virtual bool isFixK3()
      {
        return (this.flags & 128) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 94, (byte) 98, (byte) 99, (byte) 148, (byte) 146})]
      public virtual void setFixK3(bool fixK3)
      {
        if (fixK3)
          this.flags |= 128;
        else
          this.flags &= -129;
      }

      public virtual bool isFixK4()
      {
        return (this.flags & 2048) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 91, (byte) 66, (byte) 99, (byte) 148, (byte) 146})]
      public virtual void setFixK4(bool fixK4)
      {
        if (fixK4)
          this.flags |= 2048;
        else
          this.flags &= -2049;
      }

      public virtual bool isFixK5()
      {
        return (this.flags & 4096) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 89, (byte) 162, (byte) 99, (byte) 148, (byte) 146})]
      public virtual void setFixK5(bool fixK5)
      {
        if (fixK5)
          this.flags |= 4096;
        else
          this.flags &= -4097;
      }

      public virtual bool isFixK6()
      {
        return (this.flags & 8192) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 86, (byte) 130, (byte) 99, (byte) 148, (byte) 146})]
      public virtual void setFixK6(bool fixK6)
      {
        if (fixK6)
          this.flags |= 8192;
        else
          this.flags &= -8193;
      }

      public virtual bool isRationalModel()
      {
        return (this.flags & 16384) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 83, (byte) 98, (byte) 99, (byte) 148, (byte) 146})]
      public virtual void setRationalModel(bool rationalModel)
      {
        if (rationalModel)
          this.flags |= 16384;
        else
          this.flags &= -16385;
      }

      public virtual bool isStereoFixIntrinsic()
      {
        return (this.flags & 256) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 80, (byte) 66, (byte) 99, (byte) 148, (byte) 146})]
      public virtual void setStereoFixIntrinsic(bool stereoFixIntrinsic)
      {
        if (stereoFixIntrinsic)
          this.flags |= 256;
        else
          this.flags &= -257;
      }

      public virtual bool isStereoSameFocalLength()
      {
        return (this.flags & 512) != 0;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 78, (byte) 162, (byte) 99, (byte) 148, (byte) 146})]
      public virtual void setStereoSameFocalLength(bool stereoSameFocalLength)
      {
        if (stereoSameFocalLength)
          this.flags |= 512;
        else
          this.flags &= -513;
      }
    }

    [InnerClass]
    [SourceFile("ProjectiveDevice.java")]
    [Serializable]
    public class Settings : BaseChildSettings
    {
      internal string name;
      internal double responseGamma;

      [LineNumberTable(new byte[] {(byte) 11, (byte) 232, (byte) 70, (byte) 107, (byte) 236, (byte) 57})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings()
      {
        ProjectiveDevice.Settings settings = this;
        this.name = "";
        this.responseGamma = 0.0;
      }

      [LineNumberTable(new byte[] {(byte) 12, (byte) 232, (byte) 69, (byte) 107, (byte) 236, (byte) 59, (byte) 108, (byte) 141})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings(ProjectiveDevice.Settings settings)
      {
        ProjectiveDevice.Settings settings1 = this;
        this.name = "";
        this.responseGamma = 0.0;
        this.name = settings.name;
        this.responseGamma = settings.responseGamma;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected Settings([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      public override string getName()
      {
        return this.name;
      }

      [LineNumberTable(new byte[] {(byte) 25, (byte) 127, (byte) 0})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setName(string name)
      {
        string str1 = "name";
        string str2 = this.name;
        ProjectiveDevice.Settings settings = this;
        string str3 = name;
        string str4 = str3;
        this.name = str3;
        this.firePropertyChange(str1, (object) str2, (object) str4);
      }

      public virtual double getResponseGamma()
      {
        return this.responseGamma;
      }

      public virtual void setResponseGamma(double responseGamma)
      {
        this.responseGamma = responseGamma;
      }
    }
  }
}
