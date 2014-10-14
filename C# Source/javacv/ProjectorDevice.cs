// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ProjectorDevice
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.beans;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacv
{
  public class ProjectorDevice : ProjectiveDevice
  {
    private ProjectorDevice.Settings settings;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal B4x3;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal x23x1;
    [Signature("Ljava/lang/ThreadLocal<Lcom/googlecode/javacv/cpp/opencv_core$CvMat;>;")]
    private static ThreadLocal x34x1;

    [LineNumberTable((ushort) 295)]
    static ProjectorDevice()
    {
      ProjectiveDevice.__\u003Cclinit\u003E();
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 131, (byte) 81, (byte) 106, (byte) 113, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectorDevice(string name, object fs)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(fs, __typeref (ProjectorDevice), "com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
      // ISSUE: explicit constructor call
      base.\u002Ector(name, fs);
      ProjectorDevice projectorDevice = this;
      this.settings.setImageWidth(this.imageWidth);
      this.settings.setImageHeight(this.imageHeight);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 178, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectorDevice(string name)
      : base(name)
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 181, (byte) 106, (byte) 113, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectorDevice(string name, string filename)
      : base(name, filename)
    {
      ProjectorDevice projectorDevice = this;
      this.settings.setImageWidth(this.imageWidth);
      this.settings.setImageHeight(this.imageHeight);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 191, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectorDevice(ProjectorDevice.Settings settings)
      : base((ProjectiveDevice.Settings) settings)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 59, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ProjectorDevice[] read(object fs)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(fs, __typeref (ProjectorDevice), "com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
      object cfs = fs;
      // ISSUE: variable of the null type
      __Null local = null;
      string str1 = "Projectors";
      object cfn = (object) local;
      string str2 = str1;
      opencv_core.cvGetFileNodeByName(cfs, cfn, str2);
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvFileNode");
    }

    [LineNumberTable((ushort) 258)]
    public override ProjectiveDevice.Settings getSettings()
    {
      return (ProjectiveDevice.Settings) this.settings;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 150, (byte) 103, (byte) 104, (byte) 115, (byte) 104, (byte) 147, (byte) 140, (byte) 127, (byte) 0, (byte) 159, (byte) 42})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setSettings(ProjectiveDevice.Settings settings)
    {
      base.setSettings(settings);
      this.settings = !(settings is ProjectiveDevice.CalibrationSettings) ? (!(settings is ProjectiveDevice.CalibratedSettings) ? (ProjectorDevice.Settings) new ProjectorDevice.SettingsImplementation(settings) : (ProjectorDevice.Settings) new ProjectorDevice.CalibratedSettings((ProjectiveDevice.CalibratedSettings) settings)) : (ProjectorDevice.Settings) new ProjectorDevice.CalibrationSettings((ProjectiveDevice.CalibrationSettings) settings);
      if (this.settings.getName() != null && String.instancehelper_length(this.settings.getName()) != 0)
        return;
      ProjectorDevice.Settings settings1 = this.settings;
      StringBuilder stringBuilder = new StringBuilder().append("Projector ");
      string str1 = "%2d";
      object[] objArray = new object[1];
      int index = 0;
      Integer integer = Integer.valueOf(this.settings.getScreenNumber());
      objArray[index] = (object) integer;
      string str2 = String.format(str1, objArray);
      string str3 = stringBuilder.append(str2).toString();
      settings1.setName(str3);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 147, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSettings(ProjectorDevice.Settings settings)
    {
      this.setSettings((ProjectiveDevice.Settings) settings);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 164, (byte) 110, (byte) 130, (byte) 159, (byte) 19, (byte) 127, (byte) 14, (byte) 145, (byte) 103, (byte) 124, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CanvasFrame createCanvasFrame()
    {
      if (this.settings.getScreenNumber() < 0)
        return (CanvasFrame) null;
      DisplayMode displayMode = new DisplayMode(this.settings.getImageWidth(), this.settings.getImageHeight(), this.settings.getBitDepth(), this.settings.getRefreshRate());
      CanvasFrame.__\u003Cclinit\u003E();
      CanvasFrame canvasFrame = new CanvasFrame(this.settings.getName(), this.settings.getScreenNumber(), displayMode, this.settings.getResponseGamma());
      canvasFrame.setLatency(this.settings.getLatency());
      Dimension canvasSize = canvasFrame.getCanvasSize();
      if (canvasSize.width != this.imageWidth || canvasSize.height != this.imageHeight)
        this.rescale((int) canvasSize.width, (int) canvasSize.height);
      return canvasFrame;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 68, (byte) 177, (byte) 122, (byte) 122, (byte) 154, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getAttenuation(double x, double y, object n, double d)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(n, __typeref (ProjectorDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      object obj1 = ByteCodeHelper.DynamicCast(ProjectorDevice.B4x3.get(), __typeref (ProjectorDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(ProjectorDevice.x23x1.get(), __typeref (ProjectorDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(ProjectorDevice.x34x1.get(), __typeref (ProjectorDevice), "com.googlecode.javacv.cpp.opencv_core$CvMat");
      object n1 = n;
      double num1 = d;
      object obj2 = obj1;
      double d1 = num1;
      object B = obj2;
      this.getBackProjectionMatrix(n1, d1, B);
      double[] numArray = new double[3];
      int index1 = 0;
      double num2 = x;
      numArray[index1] = num2;
      int index2 = 1;
      double num3 = y;
      numArray[index2] = num3;
      int index3 = 2;
      double num4 = 1.0;
      numArray[index3] = num4;
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvMat");
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable((ushort) 327)]
    public static ProjectorDevice[] read(string filename)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
    }

    [InnerClass]
    [Implements(new string[] {"com.googlecode.javacv.ProjectorDevice$Settings"})]
    [SourceFile("ProjectorDevice.java")]
    [Serializable]
    public class CalibratedSettings : ProjectiveDevice.CalibratedSettings, ProjectorDevice.Settings
    {
      internal ProjectorDevice.SettingsImplementation si;

      [LineNumberTable(new byte[] {(byte) 160, (byte) 106, (byte) 232, (byte) 71, (byte) 236, (byte) 57})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public CalibratedSettings()
      {
        ProjectorDevice.CalibratedSettings calibratedSettings = this;
        this.si = (ProjectorDevice.SettingsImplementation) new ProjectorDevice\u0024CalibratedSettings\u00241(this);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 108, (byte) 233, (byte) 69, (byte) 236, (byte) 60, (byte) 104, (byte) 150})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public CalibratedSettings(ProjectiveDevice.CalibratedSettings settings)
        : base(settings)
      {
        ProjectorDevice.CalibratedSettings calibratedSettings = this;
        this.si = (ProjectorDevice.SettingsImplementation) new ProjectorDevice\u0024CalibratedSettings\u00241(this);
        if (!(settings is ProjectorDevice.CalibratedSettings))
          return;
        this.si = new ProjectorDevice.SettingsImplementation((ProjectiveDevice.Settings) ((ProjectorDevice.CalibratedSettings) settings).si);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected CalibratedSettings([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [LineNumberTable((ushort) 233)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override string getName()
      {
        return this.si.getName();
      }

      [LineNumberTable((ushort) 234)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void setName(string name)
      {
        this.si.setName(name);
      }

      [LineNumberTable((ushort) 235)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override double getResponseGamma()
      {
        return this.si.getResponseGamma();
      }

      [LineNumberTable((ushort) 236)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void setResponseGamma(double responseGamma)
      {
        this.si.setResponseGamma(responseGamma);
      }

      [LineNumberTable((ushort) 240)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getScreenNumber()
      {
        return this.si.getScreenNumber();
      }

      [LineNumberTable((ushort) 241)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setScreenNumber(int screenNumber)
      {
        this.si.setScreenNumber(screenNumber);
      }

      [LineNumberTable((ushort) 242)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual long getLatency()
      {
        return this.si.getLatency();
      }

      [LineNumberTable((ushort) 243)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setLatency(long latency)
      {
        this.si.setLatency(latency);
      }

      [LineNumberTable((ushort) 244)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getDescription()
      {
        return this.si.getDescription();
      }

      [LineNumberTable((ushort) 246)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getImageWidth()
      {
        return this.si.getImageWidth();
      }

      [LineNumberTable((ushort) 247)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setImageWidth(int imageWidth)
      {
        this.si.setImageWidth(imageWidth);
      }

      [LineNumberTable((ushort) 248)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getImageHeight()
      {
        return this.si.getImageHeight();
      }

      [LineNumberTable((ushort) 249)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setImageHeight(int imageHeight)
      {
        this.si.setImageHeight(imageHeight);
      }

      [LineNumberTable((ushort) 250)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getBitDepth()
      {
        return this.si.getBitDepth();
      }

      [LineNumberTable((ushort) 251)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBitDepth(int bitDepth)
      {
        this.si.setBitDepth(bitDepth);
      }

      [LineNumberTable((ushort) 252)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getRefreshRate()
      {
        return this.si.getRefreshRate();
      }

      [LineNumberTable((ushort) 253)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setRefreshRate(int refreshRate)
      {
        this.si.setRefreshRate(refreshRate);
      }
    }

    [InnerClass]
    [Implements(new string[] {"com.googlecode.javacv.ProjectorDevice$Settings"})]
    [SourceFile("ProjectorDevice.java")]
    [Serializable]
    public class CalibrationSettings : ProjectiveDevice.CalibrationSettings, ProjectorDevice.Settings
    {
      internal ProjectorDevice.SettingsImplementation si;
      internal double brightnessBackground;
      internal double brightnessForeground;

      [LineNumberTable(new byte[] {(byte) 114, (byte) 233, (byte) 72, (byte) 236, (byte) 92, (byte) 248, (byte) 29, (byte) 104, (byte) 103, (byte) 113, (byte) 109, (byte) 141})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public CalibrationSettings(ProjectiveDevice.CalibrationSettings settings)
        : base(settings)
      {
        ProjectorDevice.CalibrationSettings calibrationSettings1 = this;
        this.si = (ProjectorDevice.SettingsImplementation) new ProjectorDevice\u0024CalibrationSettings\u00241(this);
        this.brightnessBackground = 0.0;
        this.brightnessForeground = 1.0;
        if (!(settings is ProjectorDevice.CalibrationSettings))
          return;
        ProjectorDevice.CalibrationSettings calibrationSettings2 = (ProjectorDevice.CalibrationSettings) settings;
        this.si = new ProjectorDevice.SettingsImplementation((ProjectiveDevice.Settings) calibrationSettings2.si);
        this.brightnessBackground = calibrationSettings2.brightnessBackground;
        this.brightnessForeground = calibrationSettings2.brightnessForeground;
      }

      [LineNumberTable(new byte[] {(byte) 112, (byte) 232, (byte) 74, (byte) 236, (byte) 92, (byte) 248, (byte) 26})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public CalibrationSettings()
      {
        ProjectorDevice.CalibrationSettings calibrationSettings = this;
        this.si = (ProjectorDevice.SettingsImplementation) new ProjectorDevice\u0024CalibrationSettings\u00241(this);
        this.brightnessBackground = 0.0;
        this.brightnessForeground = 1.0;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected CalibrationSettings([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [LineNumberTable((ushort) 178)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override string getName()
      {
        return this.si.getName();
      }

      [LineNumberTable((ushort) 179)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void setName(string name)
      {
        this.si.setName(name);
      }

      [LineNumberTable((ushort) 180)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override double getResponseGamma()
      {
        return this.si.getResponseGamma();
      }

      [LineNumberTable((ushort) 181)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void setResponseGamma(double responseGamma)
      {
        this.si.setResponseGamma(responseGamma);
      }

      [LineNumberTable((ushort) 185)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getScreenNumber()
      {
        return this.si.getScreenNumber();
      }

      [LineNumberTable((ushort) 186)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setScreenNumber(int screenNumber)
      {
        this.si.setScreenNumber(screenNumber);
      }

      [LineNumberTable((ushort) 187)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual long getLatency()
      {
        return this.si.getLatency();
      }

      [LineNumberTable((ushort) 188)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setLatency(long latency)
      {
        this.si.setLatency(latency);
      }

      [LineNumberTable((ushort) 189)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getDescription()
      {
        return this.si.getDescription();
      }

      [LineNumberTable((ushort) 191)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getImageWidth()
      {
        return this.si.getImageWidth();
      }

      [LineNumberTable((ushort) 192)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setImageWidth(int imageWidth)
      {
        this.si.setImageWidth(imageWidth);
      }

      [LineNumberTable((ushort) 193)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getImageHeight()
      {
        return this.si.getImageHeight();
      }

      [LineNumberTable((ushort) 194)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setImageHeight(int imageHeight)
      {
        this.si.setImageHeight(imageHeight);
      }

      [LineNumberTable((ushort) 195)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getBitDepth()
      {
        return this.si.getBitDepth();
      }

      [LineNumberTable((ushort) 196)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBitDepth(int bitDepth)
      {
        this.si.setBitDepth(bitDepth);
      }

      [LineNumberTable((ushort) 197)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getRefreshRate()
      {
        return this.si.getRefreshRate();
      }

      [LineNumberTable((ushort) 198)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setRefreshRate(int refreshRate)
      {
        this.si.setRefreshRate(refreshRate);
      }

      public virtual double getBrightnessBackground()
      {
        return this.brightnessBackground;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 92, (byte) 159, (byte) 12})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBrightnessBackground(double brightnessBackground)
      {
        string str = "brightnessBackground";
        Double double1 = Double.valueOf(this.brightnessBackground);
        ProjectorDevice.CalibrationSettings calibrationSettings = this;
        double num1 = brightnessBackground;
        double num2 = num1;
        this.brightnessBackground = num1;
        Double double2 = Double.valueOf(num2);
        this.firePropertyChange(str, (object) double1, (object) double2);
      }

      public virtual double getBrightnessForeground()
      {
        return this.brightnessForeground;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 100, (byte) 159, (byte) 12})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBrightnessForeground(double brightnessForeground)
      {
        string str = "brightnessForeground";
        Double double1 = Double.valueOf(this.brightnessForeground);
        ProjectorDevice.CalibrationSettings calibrationSettings = this;
        double num1 = brightnessForeground;
        double num2 = num1;
        this.brightnessForeground = num1;
        Double double2 = Double.valueOf(num2);
        this.firePropertyChange(str, (object) double1, (object) double2);
      }
    }

    [InnerClass]
    [SourceFile("ProjectorDevice.java")]
    public interface Settings
    {
      string getName();

      void setName(string str);

      double getResponseGamma();

      void setResponseGamma(double d);

      int getScreenNumber();

      void setScreenNumber(int i);

      long getLatency();

      void setLatency(long l);

      string getDescription();

      int getImageWidth();

      void setImageWidth(int i);

      int getImageHeight();

      void setImageHeight(int i);

      int getBitDepth();

      void setBitDepth(int i);

      int getRefreshRate();

      void setRefreshRate(int i);

      void addPropertyChangeListener(PropertyChangeListener pcl);

      void removePropertyChangeListener(PropertyChangeListener pcl);
    }

    [InnerClass]
    [Implements(new string[] {"com.googlecode.javacv.ProjectorDevice$Settings"})]
    [SourceFile("ProjectorDevice.java")]
    [Serializable]
    public class SettingsImplementation : ProjectiveDevice.Settings, ProjectorDevice.Settings
    {
      internal int screenNumber;
      internal long latency;
      internal int imageWidth;
      internal int imageHeight;
      internal int bitDepth;
      internal int refreshRate;

      [LineNumberTable(new byte[] {(byte) 28, (byte) 232, (byte) 78, (byte) 111, (byte) 233, (byte) 99, (byte) 252, (byte) 14})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public SettingsImplementation()
      {
        ProjectorDevice.SettingsImplementation settingsImplementation = this;
        this.screenNumber = CanvasFrame.getScreenDevices().Length > 1 ? 1 : 0;
        this.latency = 120L;
        this.imageWidth = 0;
        this.imageHeight = 0;
        this.bitDepth = 0;
        this.refreshRate = 0;
        this.name = "Projector  0";
        this.setScreenNumber(this.screenNumber);
      }

      [LineNumberTable(new byte[] {(byte) 30, (byte) 233, (byte) 76, (byte) 111, (byte) 233, (byte) 99, (byte) 252, (byte) 17, (byte) 104, (byte) 103, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 140})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public SettingsImplementation(ProjectiveDevice.Settings settings)
        : base(settings)
      {
        ProjectorDevice.SettingsImplementation settingsImplementation1 = this;
        this.screenNumber = CanvasFrame.getScreenDevices().Length > 1 ? 1 : 0;
        this.latency = 120L;
        this.imageWidth = 0;
        this.imageHeight = 0;
        this.bitDepth = 0;
        this.refreshRate = 0;
        if (!(settings is ProjectorDevice.SettingsImplementation))
          return;
        ProjectorDevice.SettingsImplementation settingsImplementation2 = (ProjectorDevice.SettingsImplementation) settings;
        this.screenNumber = settingsImplementation2.screenNumber;
        this.latency = settingsImplementation2.latency;
        this.imageWidth = settingsImplementation2.imageWidth;
        this.imageHeight = settingsImplementation2.imageHeight;
        this.bitDepth = settingsImplementation2.bitDepth;
        this.refreshRate = settingsImplementation2.refreshRate;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected SettingsImplementation([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [LineNumberTable(new byte[] {(byte) 49, (byte) 103, (byte) 103, (byte) 127, (byte) 8, (byte) 114, (byte) 127, (byte) 19, (byte) 127, (byte) 19, (byte) 127, (byte) 19, (byte) 127, (byte) 19, (byte) 127, (byte) 16})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setScreenNumber(int screenNumber)
      {
        DisplayMode displayMode = CanvasFrame.getDisplayMode(screenNumber);
        string description = this.getDescription();
        string str1 = "screenNumber";
        Integer integer1 = Integer.valueOf(this.screenNumber);
        ProjectorDevice.SettingsImplementation settingsImplementation1 = this;
        int num1 = screenNumber;
        int num2 = num1;
        this.screenNumber = num1;
        Integer integer2 = Integer.valueOf(num2);
        this.firePropertyChange(str1, (object) integer1, (object) integer2);
        this.firePropertyChange("description", (object) description, (object) this.getDescription());
        string str2 = "imageWidth";
        Integer integer3 = Integer.valueOf(this.imageWidth);
        ProjectorDevice.SettingsImplementation settingsImplementation2 = this;
        int num3 = displayMode != null ? displayMode.getWidth() : 0;
        int num4 = num3;
        this.imageWidth = num3;
        Integer integer4 = Integer.valueOf(num4);
        this.firePropertyChange(str2, (object) integer3, (object) integer4);
        string str3 = "imageHeight";
        Integer integer5 = Integer.valueOf(this.imageHeight);
        ProjectorDevice.SettingsImplementation settingsImplementation3 = this;
        int num5 = displayMode != null ? displayMode.getHeight() : 0;
        int num6 = num5;
        this.imageHeight = num5;
        Integer integer6 = Integer.valueOf(num6);
        this.firePropertyChange(str3, (object) integer5, (object) integer6);
        string str4 = "bitDepth";
        Integer integer7 = Integer.valueOf(this.bitDepth);
        ProjectorDevice.SettingsImplementation settingsImplementation4 = this;
        int num7 = displayMode != null ? displayMode.getBitDepth() : 0;
        int num8 = num7;
        this.bitDepth = num7;
        Integer integer8 = Integer.valueOf(num8);
        this.firePropertyChange(str4, (object) integer7, (object) integer8);
        string str5 = "refreshRate";
        Integer integer9 = Integer.valueOf(this.refreshRate);
        ProjectorDevice.SettingsImplementation settingsImplementation5 = this;
        int num9 = displayMode != null ? displayMode.getRefreshRate() : 0;
        int num10 = num9;
        this.refreshRate = num9;
        Integer integer10 = Integer.valueOf(num10);
        this.firePropertyChange(str5, (object) integer9, (object) integer10);
        string str6 = "responseGamma";
        Double double1 = Double.valueOf(this.responseGamma);
        ProjectorDevice.SettingsImplementation settingsImplementation6 = this;
        double gamma = CanvasFrame.getGamma(screenNumber);
        double num11 = gamma;
        this.responseGamma = gamma;
        Double double2 = Double.valueOf(num11);
        this.firePropertyChange(str6, (object) double1, (object) double2);
      }

      [LineNumberTable(new byte[] {(byte) 68, (byte) 98, (byte) 134, (byte) 118, (byte) 137})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getDescription()
      {
        string[] screenDescriptions = CanvasFrame.getScreenDescriptions();
        if (screenDescriptions != null && this.screenNumber >= 0 && this.screenNumber < screenDescriptions.Length)
          return screenDescriptions[this.screenNumber];
        else
          return "";
      }

      public virtual int getScreenNumber()
      {
        return this.screenNumber;
      }

      public virtual long getLatency()
      {
        return this.latency;
      }

      public virtual void setLatency(long latency)
      {
        this.latency = latency;
      }

      public virtual int getImageWidth()
      {
        return this.imageWidth;
      }

      [LineNumberTable(new byte[] {(byte) 84, (byte) 127, (byte) 10})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setImageWidth(int imageWidth)
      {
        string str = "imageWidth";
        Integer integer1 = Integer.valueOf(this.imageWidth);
        ProjectorDevice.SettingsImplementation settingsImplementation = this;
        int num1 = imageWidth;
        int num2 = num1;
        this.imageWidth = num1;
        Integer integer2 = Integer.valueOf(num2);
        this.firePropertyChange(str, (object) integer1, (object) integer2);
      }

      public virtual int getImageHeight()
      {
        return this.imageHeight;
      }

      [LineNumberTable(new byte[] {(byte) 91, (byte) 127, (byte) 10})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setImageHeight(int imageHeight)
      {
        string str = "imageHeight";
        Integer integer1 = Integer.valueOf(this.imageHeight);
        ProjectorDevice.SettingsImplementation settingsImplementation = this;
        int num1 = imageHeight;
        int num2 = num1;
        this.imageHeight = num1;
        Integer integer2 = Integer.valueOf(num2);
        this.firePropertyChange(str, (object) integer1, (object) integer2);
      }

      public virtual int getBitDepth()
      {
        return this.bitDepth;
      }

      public virtual void setBitDepth(int bitDepth)
      {
        this.bitDepth = bitDepth;
      }

      public virtual int getRefreshRate()
      {
        return this.refreshRate;
      }

      public virtual void setRefreshRate(int refreshRate)
      {
        this.refreshRate = refreshRate;
      }
    }
  }
}
