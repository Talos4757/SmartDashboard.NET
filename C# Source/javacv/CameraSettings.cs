// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.CameraSettings
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using java.beans;
using java.beans.beancontext;
using java.lang;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacv
{
  [Serializable]
  public class CameraSettings : BaseSettings
  {
    internal bool calibrated;
    internal double monitorWindowsScale;
    [Signature("Ljava/lang/Class<+Lcom/googlecode/javacv/FrameGrabber;>;")]
    internal Class frameGrabber;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 134, (byte) 130, (byte) 200, (byte) 103, (byte) 108, (byte) 231, (byte) 59, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraSettings(bool calibrated)
    {
      int num = calibrated ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      CameraSettings cameraSettings = this;
      this.calibrated = false;
      this.monitorWindowsScale = 1.0;
      this.frameGrabber = (Class) null;
      this.calibrated = num != 0;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraSettings()
      : this(false)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CameraSettings([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 80)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CameraDevice.Settings[] toArray()
    {
      return (CameraDevice.Settings[]) base.toArray((object[]) new CameraDevice.Settings[this.size()]);
    }

    [LineNumberTable((ushort) 43)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getQuantity()
    {
      return this.size();
    }

    [Throws(new string[] {"java.beans.PropertyVetoException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 188, (byte) 105, (byte) 103, (byte) 99, (byte) 100, (byte) 108, (byte) 134, (byte) 103, (byte) 149, (byte) 127, (byte) 46, (byte) 127, (byte) 4, (byte) 127, (byte) 4, (byte) 104, (byte) 100, (byte) 101, (byte) 117})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setQuantity(int quantity)
    {
      quantity = Math.max(1, quantity);
      CameraDevice.Settings[] settingsArray = this.toArray();
      int length = settingsArray.Length;
      while (length > quantity)
      {
        this.remove((object) settingsArray[length - 1]);
        length += -1;
      }
      for (; length < quantity; ++length)
      {
        ProjectiveDevice.Settings settings1 = !this.calibrated ? (ProjectiveDevice.Settings) new CameraDevice.CalibrationSettings() : (ProjectiveDevice.Settings) new CameraDevice.CalibratedSettings();
        ProjectiveDevice.Settings settings2 = settings1;
        StringBuilder stringBuilder = new StringBuilder().append("Camera ");
        string str1 = "%2d";
        object[] objArray = new object[1];
        int index = 0;
        Integer integer1 = Integer.valueOf(length);
        objArray[index] = (object) integer1;
        string str2 = String.format(str1, objArray);
        string str3 = stringBuilder.append(str2).toString();
        CameraDevice.Settings settings3;
        if (settings2 != null)
        {
          CameraDevice.Settings settings4 = settings2 as CameraDevice.Settings;
          if (settings4 == null)
            throw new IncompatibleClassChangeError();
          settings3 = settings4;
        }
        else
          settings3 = (CameraDevice.Settings) null;
        string str4 = str3;
        settings3.setName(str4);
        ProjectiveDevice.Settings settings5 = settings1;
        Integer integer2 = Integer.valueOf(length);
        CameraDevice.Settings settings6;
        if (settings5 != null)
        {
          CameraDevice.Settings settings4 = settings5 as CameraDevice.Settings;
          if (settings4 == null)
            throw new IncompatibleClassChangeError();
          settings6 = settings4;
        }
        else
          settings6 = (CameraDevice.Settings) null;
        Integer i = integer2;
        settings6.setDeviceNumber(i);
        ProjectiveDevice.Settings settings7 = settings1;
        Class @class = this.frameGrabber;
        CameraDevice.Settings settings8;
        if (settings7 != null)
        {
          CameraDevice.Settings settings4 = settings7 as CameraDevice.Settings;
          if (settings4 == null)
            throw new IncompatibleClassChangeError();
          settings8 = settings4;
        }
        else
          settings8 = (CameraDevice.Settings) null;
        Class c = @class;
        settings8.setFrameGrabber(c);
        this.add((object) settings1);
      }
      ((PropertyChangeSupport) ((BeanContextChildSupport) this).pcSupport).firePropertyChange("quantity", settingsArray.Length, quantity);
    }

    public virtual double getMonitorWindowsScale()
    {
      return this.monitorWindowsScale;
    }

    public virtual void setMonitorWindowsScale(double monitorWindowsScale)
    {
      this.monitorWindowsScale = monitorWindowsScale;
    }

    [Signature("()Ljava/lang/Class<+Lcom/googlecode/javacv/FrameGrabber;>;")]
    public virtual Class getFrameGrabber()
    {
      return this.frameGrabber;
    }

    [Signature("(Ljava/lang/Class<+Lcom/googlecode/javacv/FrameGrabber;>;)V")]
    [LineNumberTable(new byte[] {(byte) 26, (byte) 127, (byte) 5})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFrameGrabber(Class frameGrabber)
    {
      // ISSUE: variable of the null type
      __Null local = ((BeanContextChildSupport) this).pcSupport;
      string str = "frameGrabber";
      Class class1 = this.frameGrabber;
      CameraSettings cameraSettings = this;
      Class class2 = frameGrabber;
      Class class3 = class2;
      this.frameGrabber = class2;
      ((PropertyChangeSupport) local).firePropertyChange(str, (object) class1, (object) class3);
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 29)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object[] \u003Cbridge\u003EtoArray()
    {
      return (object[]) this.toArray();
    }
  }
}
