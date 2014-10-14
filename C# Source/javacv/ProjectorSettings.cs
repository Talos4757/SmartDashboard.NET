// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.ProjectorSettings
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
  public class ProjectorSettings : BaseSettings
  {
    internal bool calibrated;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 134, (byte) 130, (byte) 200, (byte) 231, (byte) 61, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectorSettings(bool calibrated)
    {
      int num = calibrated ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      ProjectorSettings projectorSettings = this;
      this.calibrated = false;
      this.calibrated = num != 0;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectorSettings()
      : this(false)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ProjectorSettings([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable((ushort) 65)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ProjectorDevice.Settings[] toArray()
    {
      return (ProjectorDevice.Settings[]) base.toArray((object[]) new ProjectorDevice.Settings[this.size()]);
    }

    [LineNumberTable((ushort) 41)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getQuantity()
    {
      return this.size();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 186, (byte) 103, (byte) 99, (byte) 100, (byte) 108, (byte) 134, (byte) 103, (byte) 149, (byte) 127, (byte) 46, (byte) 127, (byte) 25, (byte) 104, (byte) 127, (byte) 3, (byte) 45, (byte) 168, (byte) 100, (byte) 101, (byte) 117})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setQuantity(int quantity)
    {
      ProjectorDevice.Settings[] settingsArray = this.toArray();
      int length1 = settingsArray.Length;
      while (length1 > quantity)
      {
        this.remove((object) settingsArray[length1 - 1]);
        length1 += -1;
      }
      for (; length1 < quantity; ++length1)
      {
        ProjectiveDevice.Settings settings1 = !this.calibrated ? (ProjectiveDevice.Settings) new ProjectorDevice.CalibrationSettings() : (ProjectiveDevice.Settings) new ProjectorDevice.CalibratedSettings();
        ProjectiveDevice.Settings settings2 = settings1;
        StringBuilder stringBuilder = new StringBuilder().append("Projector ");
        string str1 = "%2d";
        object[] objArray = new object[1];
        int index1 = 0;
        Integer integer = Integer.valueOf(length1);
        objArray[index1] = (object) integer;
        string str2 = String.format(str1, objArray);
        string str3 = stringBuilder.append(str2).toString();
        ProjectorDevice.Settings settings3;
        if (settings2 != null)
        {
          ProjectorDevice.Settings settings4 = settings2 as ProjectorDevice.Settings;
          if (settings4 == null)
            throw new IncompatibleClassChangeError();
          settings3 = settings4;
        }
        else
          settings3 = (ProjectorDevice.Settings) null;
        string str4 = str3;
        settings3.setName(str4);
        ProjectiveDevice.Settings settings5 = settings1;
        ProjectiveDevice.Settings settings6 = settings1;
        ProjectorDevice.Settings settings7;
        if (settings6 != null)
        {
          ProjectorDevice.Settings settings4 = settings6 as ProjectorDevice.Settings;
          if (settings4 == null)
            throw new IncompatibleClassChangeError();
          settings7 = settings4;
        }
        else
          settings7 = (ProjectorDevice.Settings) null;
        int num = settings7.getScreenNumber() + length1;
        ProjectorDevice.Settings settings8;
        if (settings5 != null)
        {
          ProjectorDevice.Settings settings4 = settings5 as ProjectorDevice.Settings;
          if (settings4 == null)
            throw new IncompatibleClassChangeError();
          settings8 = settings4;
        }
        else
          settings8 = (ProjectorDevice.Settings) null;
        int i = num;
        settings8.setScreenNumber(i);
        this.add((object) settings1);
        PropertyChangeListener[] propertyChangeListeners = ((PropertyChangeSupport) ((BeanContextChildSupport) this).pcSupport).getPropertyChangeListeners();
        int length2 = propertyChangeListeners.Length;
        for (int index2 = 0; index2 < length2; ++index2)
        {
          PropertyChangeListener listener = propertyChangeListeners[index2];
          settings1.addPropertyChangeListener(listener);
        }
      }
      ((PropertyChangeSupport) ((BeanContextChildSupport) this).pcSupport).firePropertyChange("quantity", settingsArray.Length, quantity);
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
