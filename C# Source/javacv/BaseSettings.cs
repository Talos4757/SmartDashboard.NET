// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.BaseSettings
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using java.beans;
using java.beans.beancontext;
using java.lang;
using java.util;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacv
{
  [Implements(new string[] {"java.lang.Comparable"})]
  [Signature("Ljava/beans/beancontext/BeanContextSupport;Ljava/lang/Comparable<Lcom/googlecode/javacv/BaseSettings;>;")]
  [Serializable]
  public class BaseSettings : BeanContextSupport, Comparable
  {
    [LineNumberTable((ushort) 31)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BaseSettings()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected BaseSettings([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [LineNumberTable(new byte[] {(byte) 13, (byte) 103, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object[] toArray()
    {
      object[] objArray = base.toArray();
      Arrays.sort(objArray);
      return objArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 108, (byte) 116, (byte) 104, (byte) 110, (byte) 104, (byte) 236, (byte) 60, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addPropertyChangeListener(PropertyChangeListener listener)
    {
      ((PropertyChangeSupport) ((BeanContextChildSupport) this).pcSupport).addPropertyChangeListener(listener);
      object[] objArray = this.toArray();
      int length = objArray.Length;
      for (int index = 0; index < length; ++index)
      {
        object obj = objArray[index];
        if (obj is BaseChildSettings)
          ((BaseChildSettings) obj).addPropertyChangeListener(listener);
        else if (obj is BaseSettings)
          ((BaseSettings) obj).addPropertyChangeListener(listener);
      }
    }

    protected internal virtual string getName()
    {
      return "";
    }

    [LineNumberTable((ushort) 55)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compareTo(BaseSettings o)
    {
      return String.instancehelper_compareTo(this.getName(), o.getName());
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 186, (byte) 108, (byte) 116, (byte) 104, (byte) 110, (byte) 104, (byte) 236, (byte) 60, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removePropertyChangeListener(PropertyChangeListener listener)
    {
      ((PropertyChangeSupport) ((BeanContextChildSupport) this).pcSupport).removePropertyChangeListener(listener);
      object[] objArray = this.toArray();
      int length = objArray.Length;
      for (int index = 0; index < length; ++index)
      {
        object obj = objArray[index];
        if (obj is BaseChildSettings)
          ((BaseChildSettings) obj).removePropertyChangeListener(listener);
        else if (obj is BaseSettings)
          ((BaseSettings) obj).addPropertyChangeListener(listener);
      }
    }

    [LineNumberTable(new byte[] {(byte) 18, (byte) 105, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object[] toArray(object[] a)
    {
      a = base.toArray(a);
      Arrays.sort(a);
      return a;
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 31)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compareTo(object x0)
    {
      return this.compareTo((BaseSettings) x0);
    }

    [HideFromJava]
    int IComparable.java\u002Elang\u002EComparable\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029IcompareTo([In] object obj0)
    {
      return this.compareTo(obj0);
    }
  }
}
