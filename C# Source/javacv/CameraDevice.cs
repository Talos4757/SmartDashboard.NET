// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.CameraDevice
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using com.googlecode.javacv.cpp;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.beans;
using java.io;
using java.lang;
using java.lang.reflect;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacv
{
  public class CameraDevice : ProjectiveDevice
  {
    private CameraDevice.Settings settings;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [HideFromJava]
    static CameraDevice()
    {
      ProjectiveDevice.__\u003Cclinit\u003E();
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 131, (byte) 177, (byte) 106, (byte) 113, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraDevice(string name, object fs)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(fs, __typeref (CameraDevice), "com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
      // ISSUE: explicit constructor call
      base.\u002Ector(name, fs);
      CameraDevice cameraDevice = this;
      this.settings.setImageWidth(this.imageWidth);
      this.settings.setImageHeight(this.imageHeight);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 181, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraDevice(string name)
      : base(name)
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 184, (byte) 106, (byte) 113, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraDevice(string name, string filename)
      : base(name, filename)
    {
      CameraDevice cameraDevice = this;
      this.settings.setImageWidth(this.imageWidth);
      this.settings.setImageHeight(this.imageHeight);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 2, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraDevice(CameraDevice.Settings settings)
      : base((ProjectiveDevice.Settings) settings)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 9, (byte) 177, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraDevice[] read(object fs)
    {
      // ISSUE: type reference
      ByteCodeHelper.DynamicCast(fs, __typeref (CameraDevice), "com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
      object cfs = fs;
      // ISSUE: variable of the null type
      __Null local = null;
      string str1 = "Cameras";
      object cfn = (object) local;
      string str2 = str1;
      opencv_core.cvGetFileNodeByName(cfs, cfn, str2);
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvFileNode");
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 106, (byte) 103, (byte) 104, (byte) 115, (byte) 104, (byte) 147, (byte) 140, (byte) 127, (byte) 0, (byte) 159, (byte) 37})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setSettings(ProjectiveDevice.Settings settings)
    {
      base.setSettings(settings);
      this.settings = !(settings is ProjectiveDevice.CalibrationSettings) ? (!(settings is ProjectiveDevice.CalibratedSettings) ? (CameraDevice.Settings) new CameraDevice.SettingsImplementation(settings) : (CameraDevice.Settings) new CameraDevice.CalibratedSettings((ProjectiveDevice.CalibratedSettings) settings)) : (CameraDevice.Settings) new CameraDevice.CalibrationSettings((ProjectiveDevice.CalibrationSettings) settings);
      if (this.settings.getName() != null && String.instancehelper_length(this.settings.getName()) != 0)
        return;
      CameraDevice.Settings settings1 = this.settings;
      StringBuilder stringBuilder = new StringBuilder().append("Camera ");
      string str1 = "%2d";
      object[] objArray = new object[1];
      int index = 0;
      Integer deviceNumber = this.settings.getDeviceNumber();
      objArray[index] = (object) deviceNumber;
      string str2 = String.format(str1, objArray);
      string str3 = stringBuilder.append(str2).toString();
      settings1.setName(str3);
    }

    [LineNumberTable((ushort) 470)]
    public override ProjectiveDevice.Settings getSettings()
    {
      return (ProjectiveDevice.Settings) this.settings;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSettings(CameraDevice.Settings settings)
    {
      this.setSettings((ProjectiveDevice.Settings) settings);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 121, (byte) 159, (byte) 19, (byte) 109, (byte) 127, (byte) 45, (byte) 127, (byte) 1, (byte) 159, (byte) 45, (byte) 159, (byte) 2, (byte) 191, (byte) 43, (byte) 29, (byte) 97, (byte) 191, (byte) 58, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 124, (byte) 98, (byte) 105, (byte) 105, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual FrameGrabber createFrameGrabber()
    {
      FrameGrabber frameGrabber1;
      int num1;
      InvocationTargetException invocationTargetException1;
      try
      {
        this.settings.getFrameGrabber().getMethod("tryLoad", new Class[0], CameraDevice.__\u003CGetCallerID\u003E()).invoke((object) null, new object[0], CameraDevice.__\u003CGetCallerID\u003E());
        if (this.settings.getDeviceFile() != null)
        {
          Class frameGrabber2 = this.settings.getFrameGrabber();
          Class[] classArray = new Class[1];
          int index1 = 0;
          // ISSUE: variable of the null type
          __Null local = ClassLiteral<File>.Value;
          classArray[index1] = (Class) local;
          CallerID callerId1 = CameraDevice.__\u003CGetCallerID\u003E();
          Constructor constructor = frameGrabber2.getConstructor(classArray, callerId1);
          object[] objArray = new object[1];
          int index2 = 0;
          File deviceFile = this.settings.getDeviceFile();
          objArray[index2] = (object) deviceFile;
          CallerID callerId2 = CameraDevice.__\u003CGetCallerID\u003E();
          frameGrabber1 = (FrameGrabber) constructor.newInstance(objArray, callerId2);
          goto label_13;
        }
        else if (this.settings.getDevicePath() != null && String.instancehelper_length(this.settings.getDevicePath()) > 0)
        {
          Class frameGrabber2 = this.settings.getFrameGrabber();
          Class[] classArray = new Class[1];
          int index1 = 0;
          // ISSUE: variable of the null type
          __Null local = ClassLiteral<String>.Value;
          classArray[index1] = (Class) local;
          CallerID callerId1 = CameraDevice.__\u003CGetCallerID\u003E();
          Constructor constructor = frameGrabber2.getConstructor(classArray, callerId1);
          object[] objArray = new object[1];
          int index2 = 0;
          string devicePath = this.settings.getDevicePath();
          objArray[index2] = (object) devicePath;
          CallerID callerId2 = CameraDevice.__\u003CGetCallerID\u003E();
          frameGrabber1 = (FrameGrabber) constructor.newInstance(objArray, callerId2);
          goto label_13;
        }
        else
        {
          num1 = this.settings.getDeviceNumber() != null ? this.settings.getDeviceNumber().intValue() : 0;
          try
          {
            Class frameGrabber2 = this.settings.getFrameGrabber();
            Class[] classArray = new Class[1];
            int index1 = 0;
            // ISSUE: variable of the null type
            __Null local = Integer.TYPE;
            classArray[index1] = (Class) local;
            CallerID callerId1 = CameraDevice.__\u003CGetCallerID\u003E();
            Constructor constructor = frameGrabber2.getConstructor(classArray, callerId1);
            object[] objArray = new object[1];
            int index2 = 0;
            Integer integer = Integer.valueOf(num1);
            objArray[index2] = (object) integer;
            CallerID callerId2 = CameraDevice.__\u003CGetCallerID\u003E();
            frameGrabber1 = (FrameGrabber) constructor.newInstance(objArray, callerId2);
            goto label_13;
          }
          catch (NoSuchMethodException ex)
          {
          }
        }
      }
      catch (InvocationTargetException ex)
      {
        int num2 = 1;
        invocationTargetException1 = (InvocationTargetException) ByteCodeHelper.MapException<InvocationTargetException>((Exception) ex, (ByteCodeHelper.MapFlags) num2);
        goto label_9;
      }
      InvocationTargetException invocationTargetException2;
      try
      {
        Class frameGrabber2 = this.settings.getFrameGrabber();
        Class[] classArray = new Class[1];
        int index1 = 0;
        // ISSUE: variable of the null type
        __Null local = ClassLiteral<Integer>.Value;
        classArray[index1] = (Class) local;
        CallerID callerId1 = CameraDevice.__\u003CGetCallerID\u003E();
        Constructor constructor = frameGrabber2.getConstructor(classArray, callerId1);
        object[] objArray = new object[1];
        int index2 = 0;
        Integer integer = Integer.valueOf(num1);
        objArray[index2] = (object) integer;
        CallerID callerId2 = CameraDevice.__\u003CGetCallerID\u003E();
        frameGrabber1 = (FrameGrabber) constructor.newInstance(objArray, callerId2);
        goto label_13;
      }
      catch (InvocationTargetException ex)
      {
        int num2 = 1;
        invocationTargetException2 = (InvocationTargetException) ByteCodeHelper.MapException<InvocationTargetException>((Exception) ex, (ByteCodeHelper.MapFlags) num2);
      }
      InvocationTargetException invocationTargetException3 = invocationTargetException2;
      goto label_17;
label_9:
      invocationTargetException3 = invocationTargetException1;
      goto label_17;
label_13:
      FrameGrabber frameGrabber3;
      InvocationTargetException invocationTargetException4;
      try
      {
        frameGrabber1.setFormat(this.settings.getFormat());
        frameGrabber1.setImageWidth(this.settings.getImageWidth());
        frameGrabber1.setImageHeight(this.settings.getImageHeight());
        frameGrabber1.setFrameRate(this.settings.getFrameRate());
        frameGrabber1.setTriggerMode(this.settings.isTriggerMode());
        frameGrabber1.setTriggerFlushSize(this.settings.getTriggerFlushSize());
        frameGrabber1.setBitsPerPixel(this.settings.getBitsPerPixel());
        frameGrabber1.setColorMode(this.settings.getColorMode());
        frameGrabber1.setTimeout(this.settings.getTimeout());
        frameGrabber1.setNumBuffers(this.settings.getNumBuffers());
        frameGrabber1.setGamma(this.settings.getResponseGamma());
        frameGrabber1.setDeinterlace(this.settings.isDeinterlace());
        frameGrabber3 = frameGrabber1;
      }
      catch (InvocationTargetException ex)
      {
        int num2 = 1;
        invocationTargetException4 = (InvocationTargetException) ByteCodeHelper.MapException<InvocationTargetException>((Exception) ex, (ByteCodeHelper.MapFlags) num2);
        goto label_16;
      }
      return frameGrabber3;
label_16:
      invocationTargetException3 = invocationTargetException4;
label_17:
      Exception targetException = invocationTargetException3.getTargetException();
      if (targetException is Exception)
        throw Throwable.__\u003Cunmap\u003E(targetException);
      Exception exception = targetException;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new Exception(exception);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable((ushort) 529)]
    public static CameraDevice[] read(string filename)
    {
      throw new NoClassDefFoundError("com.googlecode.javacv.cpp.opencv_core$CvFileStorage");
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (CameraDevice.__\u003CcallerID\u003E == null)
        CameraDevice.__\u003CcallerID\u003E = (CallerID) new CameraDevice.__\u003CCallerID\u003E();
      return CameraDevice.__\u003CcallerID\u003E;
    }

    [InnerClass]
    [Implements(new string[] {"com.googlecode.javacv.CameraDevice$Settings"})]
    [SourceFile("CameraDevice.java")]
    [Serializable]
    public class CalibratedSettings : ProjectiveDevice.CalibratedSettings, CameraDevice.Settings
    {
      internal CameraDevice.SettingsImplementation si;

      [LineNumberTable(new byte[] {(byte) 161, (byte) 42, (byte) 232, (byte) 71, (byte) 236, (byte) 57})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public CalibratedSettings()
      {
        CameraDevice.CalibratedSettings calibratedSettings = this;
        this.si = (CameraDevice.SettingsImplementation) new CameraDevice\u0024CalibratedSettings\u00241(this);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 44, (byte) 233, (byte) 69, (byte) 236, (byte) 60, (byte) 104, (byte) 150})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public CalibratedSettings(ProjectiveDevice.CalibratedSettings settings)
        : base(settings)
      {
        CameraDevice.CalibratedSettings calibratedSettings = this;
        this.si = (CameraDevice.SettingsImplementation) new CameraDevice\u0024CalibratedSettings\u00241(this);
        if (!(settings is CameraDevice.CalibratedSettings))
          return;
        this.si = new CameraDevice.SettingsImplementation((ProjectiveDevice.Settings) ((CameraDevice.CalibratedSettings) settings).si);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected CalibratedSettings([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [LineNumberTable((ushort) 425)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override string getName()
      {
        return this.si.getName();
      }

      [LineNumberTable((ushort) 426)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void setName(string name)
      {
        this.si.setName(name);
      }

      [LineNumberTable((ushort) 427)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override double getResponseGamma()
      {
        return this.si.getResponseGamma();
      }

      [LineNumberTable((ushort) 428)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void setResponseGamma(double responseGamma)
      {
        this.si.setResponseGamma(responseGamma);
      }

      [LineNumberTable((ushort) 432)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual Integer getDeviceNumber()
      {
        return this.si.getDeviceNumber();
      }

      [Throws(new string[] {"java.beans.PropertyVetoException"})]
      [LineNumberTable((ushort) 433)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setDeviceNumber(Integer deviceNumber)
      {
        this.si.setDeviceNumber(deviceNumber);
      }

      [LineNumberTable((ushort) 434)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual File getDeviceFile()
      {
        return this.si.getDeviceFile();
      }

      [Throws(new string[] {"java.beans.PropertyVetoException"})]
      [LineNumberTable((ushort) 435)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setDeviceFile(File deviceFile)
      {
        this.si.setDeviceFile(deviceFile);
      }

      [LineNumberTable((ushort) 436)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getDeviceFilename()
      {
        return this.si.getDeviceFilename();
      }

      [Throws(new string[] {"java.beans.PropertyVetoException"})]
      [LineNumberTable((ushort) 437)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setDeviceFilename(string deviceFilename)
      {
        this.si.setDeviceFilename(deviceFilename);
      }

      [LineNumberTable((ushort) 438)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getDevicePath()
      {
        return this.si.getDevicePath();
      }

      [Throws(new string[] {"java.beans.PropertyVetoException"})]
      [LineNumberTable((ushort) 439)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setDevicePath(string devicePath)
      {
        this.si.setDevicePath(devicePath);
      }

      [Signature("()Ljava/lang/Class<+Lcom/googlecode/javacv/FrameGrabber;>;")]
      [LineNumberTable((ushort) 440)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual Class getFrameGrabber()
      {
        return this.si.getFrameGrabber();
      }

      [Signature("(Ljava/lang/Class<+Lcom/googlecode/javacv/FrameGrabber;>;)V")]
      [LineNumberTable((ushort) 441)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setFrameGrabber(Class frameGrabber)
      {
        this.si.setFrameGrabber(frameGrabber);
      }

      [LineNumberTable((ushort) 442)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getDescription()
      {
        return this.si.getDescription();
      }

      [LineNumberTable((ushort) 444)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getFormat()
      {
        return this.si.getFormat();
      }

      [LineNumberTable((ushort) 445)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setFormat(string format)
      {
        this.si.setFormat(format);
      }

      [LineNumberTable((ushort) 446)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getImageWidth()
      {
        return this.si.getImageWidth();
      }

      [LineNumberTable((ushort) 447)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setImageWidth(int imageWidth)
      {
        this.si.setImageWidth(imageWidth);
      }

      [LineNumberTable((ushort) 448)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getImageHeight()
      {
        return this.si.getImageHeight();
      }

      [LineNumberTable((ushort) 449)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setImageHeight(int imageHeight)
      {
        this.si.setImageHeight(imageHeight);
      }

      [LineNumberTable((ushort) 450)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual double getFrameRate()
      {
        return this.si.getFrameRate();
      }

      [LineNumberTable((ushort) 451)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setFrameRate(double frameRate)
      {
        this.si.setFrameRate(frameRate);
      }

      [LineNumberTable((ushort) 452)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool isTriggerMode()
      {
        return (this.si.isTriggerMode() ? 1 : 0) != 0;
      }

      [LineNumberTable((ushort) 453)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setTriggerMode(bool triggerMode)
      {
        this.si.setTriggerMode(triggerMode);
      }

      [LineNumberTable((ushort) 454)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getTriggerFlushSize()
      {
        return this.si.getTriggerFlushSize();
      }

      [LineNumberTable((ushort) 455)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setTriggerFlushSize(int triggerFlushSize)
      {
        this.si.setTriggerFlushSize(triggerFlushSize);
      }

      [LineNumberTable((ushort) 456)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getBitsPerPixel()
      {
        return this.si.getBitsPerPixel();
      }

      [LineNumberTable((ushort) 457)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBitsPerPixel(int bitsPerPixel)
      {
        this.si.setBitsPerPixel(bitsPerPixel);
      }

      [LineNumberTable((ushort) 458)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual FrameGrabber.ColorMode getColorMode()
      {
        return this.si.getColorMode();
      }

      [LineNumberTable((ushort) 459)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setColorMode(FrameGrabber.ColorMode colorMode)
      {
        this.si.setColorMode(colorMode);
      }

      [LineNumberTable((ushort) 460)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getTimeout()
      {
        return this.si.getTimeout();
      }

      [LineNumberTable((ushort) 461)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setTimeout(int timeout)
      {
        this.si.setTimeout(timeout);
      }

      [LineNumberTable((ushort) 462)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getNumBuffers()
      {
        return this.si.getNumBuffers();
      }

      [LineNumberTable((ushort) 463)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setNumBuffers(int numBuffers)
      {
        this.si.setNumBuffers(numBuffers);
      }

      [LineNumberTable((ushort) 464)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool isDeinterlace()
      {
        return (this.si.isDeinterlace() ? 1 : 0) != 0;
      }

      [LineNumberTable((ushort) 465)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setDeinterlace(bool deinterlace)
      {
        this.si.setDeinterlace(deinterlace);
      }
    }

    [InnerClass]
    [Implements(new string[] {"com.googlecode.javacv.CameraDevice$Settings"})]
    [SourceFile("CameraDevice.java")]
    [Serializable]
    public class CalibrationSettings : ProjectiveDevice.CalibrationSettings, CameraDevice.Settings
    {
      internal CameraDevice.SettingsImplementation si;

      [LineNumberTable(new byte[] {(byte) 160, (byte) 243, (byte) 233, (byte) 69, (byte) 236, (byte) 60, (byte) 104, (byte) 150})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public CalibrationSettings(ProjectiveDevice.CalibrationSettings settings)
        : base(settings)
      {
        CameraDevice.CalibrationSettings calibrationSettings = this;
        this.si = (CameraDevice.SettingsImplementation) new CameraDevice\u0024CalibrationSettings\u00241(this);
        if (!(settings is CameraDevice.CalibrationSettings))
          return;
        this.si = new CameraDevice.SettingsImplementation((ProjectiveDevice.Settings) ((CameraDevice.CalibrationSettings) settings).si);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 241, (byte) 232, (byte) 71, (byte) 236, (byte) 57})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public CalibrationSettings()
      {
        CameraDevice.CalibrationSettings calibrationSettings = this;
        this.si = (CameraDevice.SettingsImplementation) new CameraDevice\u0024CalibrationSettings\u00241(this);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected CalibrationSettings([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [LineNumberTable((ushort) 368)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override string getName()
      {
        return this.si.getName();
      }

      [LineNumberTable((ushort) 369)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void setName(string name)
      {
        this.si.setName(name);
      }

      [LineNumberTable((ushort) 370)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override double getResponseGamma()
      {
        return this.si.getResponseGamma();
      }

      [LineNumberTable((ushort) 371)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void setResponseGamma(double responseGamma)
      {
        this.si.setResponseGamma(responseGamma);
      }

      [LineNumberTable((ushort) 375)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual Integer getDeviceNumber()
      {
        return this.si.getDeviceNumber();
      }

      [Throws(new string[] {"java.beans.PropertyVetoException"})]
      [LineNumberTable((ushort) 376)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setDeviceNumber(Integer deviceNumber)
      {
        this.si.setDeviceNumber(deviceNumber);
      }

      [LineNumberTable((ushort) 377)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual File getDeviceFile()
      {
        return this.si.getDeviceFile();
      }

      [Throws(new string[] {"java.beans.PropertyVetoException"})]
      [LineNumberTable((ushort) 378)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setDeviceFile(File deviceFile)
      {
        this.si.setDeviceFile(deviceFile);
      }

      [LineNumberTable((ushort) 379)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getDeviceFilename()
      {
        return this.si.getDeviceFilename();
      }

      [Throws(new string[] {"java.beans.PropertyVetoException"})]
      [LineNumberTable((ushort) 380)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setDeviceFilename(string deviceFilename)
      {
        this.si.setDeviceFilename(deviceFilename);
      }

      [LineNumberTable((ushort) 381)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getDevicePath()
      {
        return this.si.getDevicePath();
      }

      [Throws(new string[] {"java.beans.PropertyVetoException"})]
      [LineNumberTable((ushort) 382)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setDevicePath(string devicePath)
      {
        this.si.setDevicePath(devicePath);
      }

      [Signature("()Ljava/lang/Class<+Lcom/googlecode/javacv/FrameGrabber;>;")]
      [LineNumberTable((ushort) 383)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual Class getFrameGrabber()
      {
        return this.si.getFrameGrabber();
      }

      [Signature("(Ljava/lang/Class<+Lcom/googlecode/javacv/FrameGrabber;>;)V")]
      [LineNumberTable((ushort) 384)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setFrameGrabber(Class frameGrabber)
      {
        this.si.setFrameGrabber(frameGrabber);
      }

      [LineNumberTable((ushort) 385)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getDescription()
      {
        return this.si.getDescription();
      }

      [LineNumberTable((ushort) 387)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getFormat()
      {
        return this.si.getFormat();
      }

      [LineNumberTable((ushort) 388)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setFormat(string format)
      {
        this.si.setFormat(format);
      }

      [LineNumberTable((ushort) 389)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getImageWidth()
      {
        return this.si.getImageWidth();
      }

      [LineNumberTable((ushort) 390)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setImageWidth(int imageWidth)
      {
        this.si.setImageWidth(imageWidth);
      }

      [LineNumberTable((ushort) 391)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getImageHeight()
      {
        return this.si.getImageHeight();
      }

      [LineNumberTable((ushort) 392)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setImageHeight(int imageHeight)
      {
        this.si.setImageHeight(imageHeight);
      }

      [LineNumberTable((ushort) 393)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual double getFrameRate()
      {
        return this.si.getFrameRate();
      }

      [LineNumberTable((ushort) 394)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setFrameRate(double frameRate)
      {
        this.si.setFrameRate(frameRate);
      }

      [LineNumberTable((ushort) 395)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool isTriggerMode()
      {
        return (this.si.isTriggerMode() ? 1 : 0) != 0;
      }

      [LineNumberTable((ushort) 396)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setTriggerMode(bool triggerMode)
      {
        this.si.setTriggerMode(triggerMode);
      }

      [LineNumberTable((ushort) 397)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getTriggerFlushSize()
      {
        return this.si.getTriggerFlushSize();
      }

      [LineNumberTable((ushort) 398)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setTriggerFlushSize(int triggerFlushSize)
      {
        this.si.setTriggerFlushSize(triggerFlushSize);
      }

      [LineNumberTable((ushort) 399)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getBitsPerPixel()
      {
        return this.si.getBitsPerPixel();
      }

      [LineNumberTable((ushort) 400)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBitsPerPixel(int bitsPerPixel)
      {
        this.si.setBitsPerPixel(bitsPerPixel);
      }

      [LineNumberTable((ushort) 401)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual FrameGrabber.ColorMode getColorMode()
      {
        return this.si.getColorMode();
      }

      [LineNumberTable((ushort) 402)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setColorMode(FrameGrabber.ColorMode colorMode)
      {
        this.si.setColorMode(colorMode);
      }

      [LineNumberTable((ushort) 403)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getTimeout()
      {
        return this.si.getTimeout();
      }

      [LineNumberTable((ushort) 404)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setTimeout(int timeout)
      {
        this.si.setTimeout(timeout);
      }

      [LineNumberTable((ushort) 405)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getNumBuffers()
      {
        return this.si.getNumBuffers();
      }

      [LineNumberTable((ushort) 406)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setNumBuffers(int numBuffers)
      {
        this.si.setNumBuffers(numBuffers);
      }

      [LineNumberTable((ushort) 407)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool isDeinterlace()
      {
        return (this.si.isDeinterlace() ? 1 : 0) != 0;
      }

      [LineNumberTable((ushort) 408)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setDeinterlace(bool deinterlace)
      {
        this.si.setDeinterlace(deinterlace);
      }
    }

    [InnerClass]
    [SourceFile("CameraDevice.java")]
    public interface Settings
    {
      string getName();

      void setName(string str);

      double getResponseGamma();

      void setResponseGamma(double d);

      Integer getDeviceNumber();

      [Throws(new string[] {"java.beans.PropertyVetoException"})]
      void setDeviceNumber(Integer i);

      File getDeviceFile();

      [Throws(new string[] {"java.beans.PropertyVetoException"})]
      void setDeviceFile(File f);

      string getDeviceFilename();

      [Throws(new string[] {"java.beans.PropertyVetoException"})]
      void setDeviceFilename(string str);

      string getDevicePath();

      [Throws(new string[] {"java.beans.PropertyVetoException"})]
      void setDevicePath(string str);

      [Signature("()Ljava/lang/Class<+Lcom/googlecode/javacv/FrameGrabber;>;")]
      Class getFrameGrabber();

      [Signature("(Ljava/lang/Class<+Lcom/googlecode/javacv/FrameGrabber;>;)V")]
      void setFrameGrabber(Class c);

      string getDescription();

      string getFormat();

      void setFormat(string str);

      int getImageWidth();

      void setImageWidth(int i);

      int getImageHeight();

      void setImageHeight(int i);

      double getFrameRate();

      void setFrameRate(double d);

      bool isTriggerMode();

      void setTriggerMode(bool b);

      int getTriggerFlushSize();

      void setTriggerFlushSize(int i);

      int getBitsPerPixel();

      void setBitsPerPixel(int i);

      FrameGrabber.ColorMode getColorMode();

      void setColorMode(FrameGrabber.ColorMode fgcm);

      int getTimeout();

      void setTimeout(int i);

      int getNumBuffers();

      void setNumBuffers(int i);

      bool isDeinterlace();

      void setDeinterlace(bool b);

      void addPropertyChangeListener(PropertyChangeListener pcl);

      void removePropertyChangeListener(PropertyChangeListener pcl);
    }

    [InnerClass]
    [Implements(new string[] {"com.googlecode.javacv.CameraDevice$Settings"})]
    [SourceFile("CameraDevice.java")]
    [Serializable]
    public class SettingsImplementation : ProjectiveDevice.Settings, CameraDevice.Settings
    {
      internal Integer deviceNumber;
      internal File deviceFile;
      internal string devicePath;
      [Signature("Ljava/lang/Class<+Lcom/googlecode/javacv/FrameGrabber;>;")]
      internal Class frameGrabber;
      internal string format;
      internal int imageWidth;
      internal int imageHeight;
      internal double frameRate;
      internal bool triggerMode;
      internal int triggerFlushSize;
      internal int bpp;
      internal FrameGrabber.ColorMode colorMode;
      internal int timeout;
      internal int numBuffers;
      internal bool deinterlace;
      [SpecialName]
      private static CallerID __\u003CcallerID\u003E;

      [LineNumberTable(new byte[] {(byte) 51, (byte) 232, (byte) 87, (byte) 103, (byte) 103, (byte) 103, (byte) 231, (byte) 160, (byte) 137, (byte) 107, (byte) 110, (byte) 108, (byte) 103, (byte) 103, (byte) 103, (byte) 107, (byte) 107, (byte) 103, (byte) 231, (byte) 159, (byte) 84})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public SettingsImplementation()
      {
        CameraDevice.SettingsImplementation settingsImplementation = this;
        this.deviceNumber = (Integer) null;
        this.deviceFile = (File) null;
        this.devicePath = (string) null;
        this.frameGrabber = (Class) null;
        this.format = "";
        this.imageWidth = 0;
        this.imageHeight = 0;
        this.frameRate = 0.0;
        this.triggerMode = false;
        this.triggerFlushSize = 5;
        this.bpp = 0;
        this.colorMode = FrameGrabber.ColorMode.__\u003C\u003ERAW;
        this.timeout = 10000;
        this.numBuffers = 4;
        this.deinterlace = false;
        this.name = "Camera  0";
      }

      [LineNumberTable(new byte[] {(byte) 53, (byte) 233, (byte) 85, (byte) 103, (byte) 103, (byte) 103, (byte) 231, (byte) 160, (byte) 137, (byte) 107, (byte) 110, (byte) 108, (byte) 103, (byte) 103, (byte) 103, (byte) 107, (byte) 107, (byte) 103, (byte) 231, (byte) 159, (byte) 87, (byte) 107, (byte) 103, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 109, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 140})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public SettingsImplementation(ProjectiveDevice.Settings settings)
        : base(settings)
      {
        CameraDevice.SettingsImplementation settingsImplementation1 = this;
        this.deviceNumber = (Integer) null;
        this.deviceFile = (File) null;
        this.devicePath = (string) null;
        this.frameGrabber = (Class) null;
        this.format = "";
        this.imageWidth = 0;
        this.imageHeight = 0;
        this.frameRate = 0.0;
        this.triggerMode = false;
        this.triggerFlushSize = 5;
        this.bpp = 0;
        this.colorMode = FrameGrabber.ColorMode.__\u003C\u003ERAW;
        this.timeout = 10000;
        this.numBuffers = 4;
        this.deinterlace = false;
        if (!(settings is CameraDevice.SettingsImplementation))
          return;
        CameraDevice.SettingsImplementation settingsImplementation2 = (CameraDevice.SettingsImplementation) settings;
        this.deviceNumber = settingsImplementation2.deviceNumber;
        this.deviceFile = settingsImplementation2.deviceFile;
        this.devicePath = settingsImplementation2.devicePath;
        this.frameGrabber = settingsImplementation2.frameGrabber;
        this.format = settingsImplementation2.format;
        this.imageWidth = settingsImplementation2.imageWidth;
        this.imageHeight = settingsImplementation2.imageHeight;
        this.frameRate = settingsImplementation2.frameRate;
        this.triggerMode = settingsImplementation2.triggerMode;
        this.triggerFlushSize = settingsImplementation2.triggerFlushSize;
        this.bpp = settingsImplementation2.bpp;
        this.colorMode = settingsImplementation2.colorMode;
        this.timeout = settingsImplementation2.timeout;
        this.numBuffers = settingsImplementation2.numBuffers;
        this.deinterlace = settingsImplementation2.deinterlace;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected SettingsImplementation([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [Throws(new string[] {"java.beans.PropertyVetoException"})]
      [LineNumberTable(new byte[] {(byte) 160, (byte) 73, (byte) 134, (byte) 104, (byte) 159, (byte) 0, (byte) 103, (byte) 242, (byte) 69, (byte) 226, (byte) 60, (byte) 97, (byte) 102, (byte) 223, (byte) 45, (byte) 103, (byte) 125, (byte) 114})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setDevicePath(string devicePath)
      {
        if (devicePath != null)
        {
          try
          {
            if (this.frameGrabber != null)
            {
              Class @class = this.frameGrabber;
              Class[] classArray = new Class[1];
              int index = 0;
              // ISSUE: variable of the null type
              __Null local = ClassLiteral<String>.Value;
              classArray[index] = (Class) local;
              CallerID callerId = CameraDevice.SettingsImplementation.__\u003CGetCallerID\u003E();
              @class.getConstructor(classArray, callerId);
            }
            this.setDeviceNumber((Integer) null);
            this.setDeviceFile((File) null);
            goto label_6;
          }
          catch (NoSuchMethodException ex)
          {
          }
          string mess = new StringBuilder().append(this.frameGrabber.getSimpleName()).append(" does not accept a devicePath.").toString();
          string str1 = "devicePath";
          string str2 = this.devicePath;
          CameraDevice.SettingsImplementation settingsImplementation = this;
          // ISSUE: variable of the null type
          __Null local1 = null;
          this.devicePath = (string) null;
          PropertyChangeEvent evt = new PropertyChangeEvent((object) this, str1, (object) str2, (object) local1);
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new BaseChildSettings.PropertyVetoExceptionThatNetBeansLikes(mess, evt);
        }
label_6:
        string description = this.getDescription();
        string str3 = "devicePath";
        string str4 = this.devicePath;
        CameraDevice.SettingsImplementation settingsImplementation1 = this;
        string str5 = devicePath;
        string str6 = str5;
        this.devicePath = str5;
        this.firePropertyChange(str3, (object) str4, (object) str6);
        this.firePropertyChange("description", (object) description, (object) this.getDescription());
      }

      [Throws(new string[] {"java.beans.PropertyVetoException"})]
      [LineNumberTable(new byte[] {(byte) 108, (byte) 134, (byte) 104, (byte) 159, (byte) 0, (byte) 103, (byte) 242, (byte) 69, (byte) 226, (byte) 60, (byte) 97, (byte) 98, (byte) 223, (byte) 45, (byte) 103, (byte) 125, (byte) 114})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setDeviceFile(File deviceFile)
      {
        if (deviceFile != null)
        {
          try
          {
            if (this.frameGrabber != null)
            {
              Class @class = this.frameGrabber;
              Class[] classArray = new Class[1];
              int index = 0;
              // ISSUE: variable of the null type
              __Null local = ClassLiteral<File>.Value;
              classArray[index] = (Class) local;
              CallerID callerId = CameraDevice.SettingsImplementation.__\u003CGetCallerID\u003E();
              @class.getConstructor(classArray, callerId);
            }
            this.setDeviceNumber((Integer) null);
            this.setDevicePath((string) null);
            goto label_6;
          }
          catch (NoSuchMethodException ex)
          {
          }
          string mess = new StringBuilder().append(this.frameGrabber.getSimpleName()).append(" does not accept a deviceFile.").toString();
          string str = "deviceFile";
          File file = this.deviceFile;
          CameraDevice.SettingsImplementation settingsImplementation = this;
          // ISSUE: variable of the null type
          __Null local1 = null;
          this.deviceFile = (File) null;
          PropertyChangeEvent evt = new PropertyChangeEvent((object) this, str, (object) file, (object) local1);
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new BaseChildSettings.PropertyVetoExceptionThatNetBeansLikes(mess, evt);
        }
label_6:
        string description = this.getDescription();
        string str1 = "deviceFile";
        File file1 = this.deviceFile;
        CameraDevice.SettingsImplementation settingsImplementation1 = this;
        File file2 = deviceFile;
        File file3 = file2;
        this.deviceFile = file2;
        this.firePropertyChange(str1, (object) file1, (object) file3);
        this.firePropertyChange("description", (object) description, (object) this.getDescription());
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 130, (byte) 124, (byte) 127, (byte) 19, (byte) 131, (byte) 122, (byte) 142})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getDescription()
      {
        string[] strArray = (string[]) null;
        try
        {
          strArray = (string[]) this.frameGrabber.getMethod("getDeviceDescriptions", new Class[0], CameraDevice.SettingsImplementation.__\u003CGetCallerID\u003E()).invoke((object) null, new object[0], CameraDevice.SettingsImplementation.__\u003CGetCallerID\u003E());
          goto label_5;
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
        }
label_5:
        if (strArray != null && this.deviceNumber != null && this.deviceNumber.intValue() < strArray.Length)
          return strArray[this.deviceNumber.intValue()];
        else
          return "";
      }

      [Throws(new string[] {"java.beans.PropertyVetoException"})]
      [LineNumberTable(new byte[] {(byte) 83, (byte) 134, (byte) 136, (byte) 191, (byte) 8, (byte) 16, (byte) 97, (byte) 191, (byte) 11, (byte) 103, (byte) 210, (byte) 226, (byte) 61, (byte) 97, (byte) 223, (byte) 45, (byte) 103, (byte) 125, (byte) 114})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setDeviceNumber(Integer deviceNumber)
      {
        if (deviceNumber != null)
        {
          try
          {
            if (this.frameGrabber != null)
            {
              try
              {
                Class @class = this.frameGrabber;
                Class[] classArray = new Class[1];
                int index = 0;
                // ISSUE: variable of the null type
                __Null local = Integer.TYPE;
                classArray[index] = (Class) local;
                CallerID callerId = CameraDevice.SettingsImplementation.__\u003CGetCallerID\u003E();
                @class.getConstructor(classArray, callerId);
                goto label_10;
              }
              catch (NoSuchMethodException ex)
              {
              }
            }
            else
              goto label_10;
          }
          catch (NoSuchMethodException ex)
          {
            goto label_6;
          }
          try
          {
            Class @class = this.frameGrabber;
            Class[] classArray = new Class[1];
            int index = 0;
            // ISSUE: variable of the null type
            __Null local = ClassLiteral<Integer>.Value;
            classArray[index] = (Class) local;
            CallerID callerId = CameraDevice.SettingsImplementation.__\u003CGetCallerID\u003E();
            @class.getConstructor(classArray, callerId);
            goto label_10;
          }
          catch (NoSuchMethodException ex)
          {
          }
          // ISSUE: variable of the null type
          __Null local1 = null;
          goto label_13;
label_6:
          local1 = null;
          goto label_13;
label_10:
          try
          {
            this.setDevicePath((string) null);
            this.setDeviceFile((File) null);
            goto label_14;
          }
          catch (NoSuchMethodException ex)
          {
          }
          local1 = null;
label_13:
          string mess = new StringBuilder().append(this.frameGrabber.getSimpleName()).append(" does not accept a deviceNumber.").toString();
          string str = "deviceNumber";
          Integer integer = this.deviceNumber;
          CameraDevice.SettingsImplementation settingsImplementation = this;
          // ISSUE: variable of the null type
          __Null local2 = null;
          this.deviceNumber = (Integer) null;
          PropertyChangeEvent evt = new PropertyChangeEvent((object) this, str, (object) integer, (object) local2);
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new BaseChildSettings.PropertyVetoExceptionThatNetBeansLikes(mess, evt);
        }
label_14:
        string description = this.getDescription();
        string str1 = "deviceNumber";
        Integer integer1 = this.deviceNumber;
        CameraDevice.SettingsImplementation settingsImplementation1 = this;
        Integer integer2 = deviceNumber;
        Integer integer3 = integer2;
        this.deviceNumber = integer2;
        this.firePropertyChange(str1, (object) integer1, (object) integer3);
        this.firePropertyChange("description", (object) description, (object) this.getDescription());
      }

      public virtual File getDeviceFile()
      {
        return this.deviceFile;
      }

      public virtual Integer getDeviceNumber()
      {
        return this.deviceNumber;
      }

      [LineNumberTable((ushort) 176)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getDeviceFilename()
      {
        return this.getDeviceFile() != null ? this.getDeviceFile().getPath() : "";
      }

      [Throws(new string[] {"java.beans.PropertyVetoException"})]
      [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 156})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setDeviceFilename(string deviceFilename)
      {
        this.setDeviceFile(deviceFilename == null || String.instancehelper_length(deviceFilename) == 0 ? (File) null : new File(deviceFilename));
      }

      public virtual string getDevicePath()
      {
        return this.devicePath;
      }

      [Signature("()Ljava/lang/Class<+Lcom/googlecode/javacv/FrameGrabber;>;")]
      public virtual Class getFrameGrabber()
      {
        return this.frameGrabber;
      }

      [Signature("(Ljava/lang/Class<+Lcom/googlecode/javacv/FrameGrabber;>;)V")]
      [LineNumberTable(new byte[] {(byte) 160, (byte) 95, (byte) 103, (byte) 125, (byte) 146, (byte) 99, (byte) 125, (byte) 125, (byte) 125, (byte) 161, (byte) 130, (byte) 122, (byte) 237, (byte) 72, (byte) 226, (byte) 57, (byte) 129, (byte) 122, (byte) 173, (byte) 2, (byte) 97, (byte) 221, (byte) 191, (byte) 6, (byte) 2, (byte) 97, (byte) 189, (byte) 191, (byte) 6, (byte) 2, (byte) 97, (byte) 189, (byte) 155, (byte) 127, (byte) 2, (byte) 131})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setFrameGrabber(Class frameGrabber)
      {
        string description = this.getDescription();
        string str1 = "frameGrabber";
        Class class1 = this.frameGrabber;
        CameraDevice.SettingsImplementation settingsImplementation1 = this;
        Class class2 = frameGrabber;
        Class class3 = class2;
        this.frameGrabber = class2;
        this.firePropertyChange(str1, (object) class1, (object) class3);
        this.firePropertyChange("description", (object) description, (object) this.getDescription());
        if (frameGrabber == null)
        {
          string str2 = "deviceNumber";
          Integer integer = this.deviceNumber;
          CameraDevice.SettingsImplementation settingsImplementation2 = this;
          // ISSUE: variable of the null type
          __Null local1 = null;
          this.deviceNumber = (Integer) null;
          this.firePropertyChange(str2, (object) integer, (object) local1);
          string str3 = "deviceFile";
          File file = this.deviceFile;
          CameraDevice.SettingsImplementation settingsImplementation3 = this;
          // ISSUE: variable of the null type
          __Null local2 = null;
          this.deviceFile = (File) null;
          this.firePropertyChange(str3, (object) file, (object) local2);
          string str4 = "devicePath";
          string str5 = this.devicePath;
          CameraDevice.SettingsImplementation settingsImplementation4 = this;
          // ISSUE: variable of the null type
          __Null local3 = null;
          this.devicePath = (string) null;
          this.firePropertyChange(str4, (object) str5, (object) local3);
        }
        else
        {
          int num1 = 0;
          try
          {
            Class class4 = frameGrabber;
            Class[] classArray = new Class[1];
            int index = 0;
            // ISSUE: variable of the null type
            __Null local = Integer.TYPE;
            classArray[index] = (Class) local;
            CallerID callerId = CameraDevice.SettingsImplementation.__\u003CGetCallerID\u003E();
            class4.getConstructor(classArray, callerId);
            num1 = 1;
            goto label_9;
          }
          catch (NoSuchMethodException ex)
          {
          }
          try
          {
            Class class4 = frameGrabber;
            Class[] classArray = new Class[1];
            int index = 0;
            // ISSUE: variable of the null type
            __Null local = ClassLiteral<Integer>.Value;
            classArray[index] = (Class) local;
            CallerID callerId = CameraDevice.SettingsImplementation.__\u003CGetCallerID\u003E();
            class4.getConstructor(classArray, callerId);
            num1 = 1;
            goto label_9;
          }
          catch (NoSuchMethodException ex)
          {
          }
          string str2 = "deviceNumber";
          Integer integer = this.deviceNumber;
          CameraDevice.SettingsImplementation settingsImplementation2 = this;
          // ISSUE: variable of the null type
          __Null local1 = null;
          this.deviceNumber = (Integer) null;
          this.firePropertyChange(str2, (object) integer, (object) local1);
label_9:
          try
          {
            Class class4 = frameGrabber;
            Class[] classArray = new Class[1];
            int index = 0;
            // ISSUE: variable of the null type
            __Null local2 = ClassLiteral<File>.Value;
            classArray[index] = (Class) local2;
            CallerID callerId = CameraDevice.SettingsImplementation.__\u003CGetCallerID\u003E();
            class4.getConstructor(classArray, callerId);
            goto label_12;
          }
          catch (NoSuchMethodException ex)
          {
          }
          string str3 = "deviceFile";
          File file = this.deviceFile;
          CameraDevice.SettingsImplementation settingsImplementation3 = this;
          // ISSUE: variable of the null type
          __Null local3 = null;
          this.deviceFile = (File) null;
          this.firePropertyChange(str3, (object) file, (object) local3);
label_12:
          try
          {
            Class class4 = frameGrabber;
            Class[] classArray = new Class[1];
            int index = 0;
            // ISSUE: variable of the null type
            __Null local2 = ClassLiteral<String>.Value;
            classArray[index] = (Class) local2;
            CallerID callerId = CameraDevice.SettingsImplementation.__\u003CGetCallerID\u003E();
            class4.getConstructor(classArray, callerId);
            goto label_15;
          }
          catch (NoSuchMethodException ex)
          {
          }
          string str4 = "devicePath";
          string str5 = this.devicePath;
          CameraDevice.SettingsImplementation settingsImplementation4 = this;
          // ISSUE: variable of the null type
          __Null local4 = null;
          this.devicePath = (string) null;
          this.firePropertyChange(str4, (object) str5, (object) local4);
label_15:
          if (num1 == 0 || this.deviceNumber != null || this.deviceFile != null)
            return;
          if (this.devicePath != null)
            return;
          try
          {
            this.setDeviceNumber(Integer.valueOf(0));
          }
          catch (Exception ex)
          {
            int num2 = 2;
            if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2) == null)
              throw;
          }
        }
      }

      public virtual string getFormat()
      {
        return this.format;
      }

      public virtual void setFormat(string format)
      {
        this.format = format;
      }

      public virtual int getImageWidth()
      {
        return this.imageWidth;
      }

      public virtual void setImageWidth(int imageWidth)
      {
        this.imageWidth = imageWidth;
      }

      public virtual int getImageHeight()
      {
        return this.imageHeight;
      }

      public virtual void setImageHeight(int imageHeight)
      {
        this.imageHeight = imageHeight;
      }

      public virtual double getFrameRate()
      {
        return this.frameRate;
      }

      public virtual void setFrameRate(double frameRate)
      {
        this.frameRate = frameRate;
      }

      public virtual bool isTriggerMode()
      {
        return this.triggerMode;
      }

      public virtual void setTriggerMode(bool triggerMode)
      {
        this.triggerMode = triggerMode;
      }

      public virtual int getTriggerFlushSize()
      {
        return this.triggerFlushSize;
      }

      public virtual void setTriggerFlushSize(int triggerFlushSize)
      {
        this.triggerFlushSize = triggerFlushSize;
      }

      public virtual int getBitsPerPixel()
      {
        return this.bpp;
      }

      public virtual void setBitsPerPixel(int bitsPerPixel)
      {
        this.bpp = bitsPerPixel;
      }

      public virtual FrameGrabber.ColorMode getColorMode()
      {
        return this.colorMode;
      }

      public virtual void setColorMode(FrameGrabber.ColorMode colorMode)
      {
        this.colorMode = colorMode;
      }

      public virtual int getTimeout()
      {
        return this.timeout;
      }

      public virtual void setTimeout(int timeout)
      {
        this.timeout = timeout;
      }

      public virtual int getNumBuffers()
      {
        return this.numBuffers;
      }

      public virtual void setNumBuffers(int numBuffers)
      {
        this.numBuffers = numBuffers;
      }

      public virtual bool isDeinterlace()
      {
        return this.deinterlace;
      }

      public virtual void setDeinterlace(bool deinterlace)
      {
        this.deinterlace = deinterlace;
      }

      [SpecialName]
      private static CallerID __\u003CGetCallerID\u003E()
      {
        if (CameraDevice.SettingsImplementation.__\u003CcallerID\u003E == null)
          CameraDevice.SettingsImplementation.__\u003CcallerID\u003E = (CallerID) new CameraDevice.SettingsImplementation.__\u003CCallerID\u003E();
        return CameraDevice.SettingsImplementation.__\u003CcallerID\u003E;
      }

      private sealed class __\u003CCallerID\u003E : CallerID
      {
        internal __\u003CCallerID\u003E()
        {
          base.\u002Ector();
        }
      }
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
