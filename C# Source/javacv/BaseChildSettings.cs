// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacv.BaseChildSettings
// Assembly: javacv, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A032DB82-75FF-461C-A79B-0648A9C9029B
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacv.dll

using IKVM.Attributes;
using java.beans;
using java.beans.beancontext;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.logging;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace com.googlecode.javacv
{
  [Implements(new string[] {"java.lang.Comparable"})]
  [Signature("Ljava/beans/beancontext/BeanContextChildSupport;Ljava/lang/Comparable<Lcom/googlecode/javacv/BaseChildSettings;>;")]
  [Serializable]
  public class BaseChildSettings : BeanContextChildSupport, Comparable
  {
    [LineNumberTable(new byte[] {(byte) 159, (byte) 178, (byte) 232, (byte) 81})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BaseChildSettings()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected BaseChildSettings([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    protected internal virtual string getName()
    {
      return "";
    }

    [LineNumberTable((ushort) 46)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compareTo(BaseChildSettings o)
    {
      return String.instancehelper_compareTo(this.getName(), o.getName());
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 181, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addPropertyChangeListener(PropertyChangeListener listener)
    {
      ((PropertyChangeSupport) this.pcSupport).addPropertyChangeListener(listener);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 184, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removePropertyChangeListener(PropertyChangeListener listener)
    {
      ((PropertyChangeSupport) this.pcSupport).removePropertyChangeListener(listener);
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 36)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int compareTo(object x0)
    {
      return this.compareTo((BaseChildSettings) x0);
    }

    [HideFromJava]
    int IComparable.java\u002Elang\u002EComparable\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029IcompareTo([In] object obj0)
    {
      return this.compareTo(obj0);
    }

    [InnerClass]
    [Implements(new string[] {"java.util.concurrent.Callable"})]
    [SourceFile("BaseChildSettings.java")]
    [Serializable]
    public class PropertyVetoExceptionThatNetBeansLikes : PropertyVetoException, Callable
    {
      [LineNumberTable(new byte[] {(byte) 5, (byte) 106})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public PropertyVetoExceptionThatNetBeansLikes(string mess, PropertyChangeEvent evt)
      {
        base.\u002Ector(mess, evt);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected PropertyVetoExceptionThatNetBeansLikes([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable(new byte[] {(byte) 8, (byte) 118, (byte) 236, (byte) 69})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object call()
      {
        LogRecord.__\u003Cclinit\u003E();
        LogRecord logRecord1 = new LogRecord((Level) Level.ALL, Throwable.instancehelper_getMessage((Exception) this));
        logRecord1.setResourceBundle((ResourceBundle) new BaseChildSettings\u0024PropertyVetoExceptionThatNetBeansLikes\u00241(this));
        LogRecord[] logRecordArray = new LogRecord[1];
        int index = 0;
        LogRecord logRecord2 = logRecord1;
        logRecordArray[index] = logRecord2;
        return (object) logRecordArray;
      }
    }
  }
}
