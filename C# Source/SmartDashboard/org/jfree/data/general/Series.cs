// Decompiled with JetBrains decompiler
// Type: org.jfree.data.general.Series
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.beans;
using java.io;
using java.lang;
using java.util;
using javax.swing.@event;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.data.general
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public abstract class Series : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -6906561437538683581L;
    private IComparable key;
    private string description;
    private EventListenerList listeners;
    private PropertyChangeSupport propertyChangeSupport;
    private bool notify;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024general\u0024SeriesChangeListener;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 60, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 107, (byte) 108, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Series(IComparable key, string description)
    {
      base.\u002Ector();
      Series series = this;
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.key = key;
        this.description = description;
        this.listeners = new EventListenerList();
        this.propertyChangeSupport = new PropertyChangeSupport((object) this);
        this.notify = true;
      }
    }

    [LineNumberTable(new byte[] {(byte) 51, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Series(IComparable key)
      : this(key, (string) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Series([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] Series obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Series obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public abstract int getItemCount();

    [LineNumberTable(new byte[] {(byte) 160, (byte) 198, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void fireSeriesChanged()
    {
      if (!this.notify)
        return;
      this.notifyListeners(new SeriesChangeEvent((object) this));
    }

    public virtual IComparable getKey()
    {
      return this.key;
    }

    public virtual string getDescription()
    {
      return this.description;
    }

    [LineNumberTable((ushort) 294)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, Series.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        int num = 1;
        notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return @class;
label_3:
      string message = Throwable.instancehelper_getMessage((Exception) notFoundException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoClassDefFoundError(message);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 211, (byte) 108, (byte) 105, (byte) 127, (byte) 4, (byte) 16, (byte) 231, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void notifyListeners(SeriesChangeEvent @event)
    {
      object[] listenerList = this.listeners.getListenerList();
      int index = listenerList.Length - 2;
      while (index >= 0)
      {
        if (listenerList[index] == (Series.class\u0024org\u0024jfree\u0024data\u0024general\u0024SeriesChangeListener != null ? Series.class\u0024org\u0024jfree\u0024data\u0024general\u0024SeriesChangeListener : (Series.class\u0024org\u0024jfree\u0024data\u0024general\u0024SeriesChangeListener = Series.class\u0024("org.jfree.data.general.SeriesChangeListener"))))
          ((SeriesChangeListener) listenerList[index + 1]).seriesChanged(@event);
        index += -2;
      }
    }

    [LineNumberTable(new byte[] {(byte) 91, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setKey(IComparable key)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        IComparable comparable = this.key;
        this.key = key;
        this.propertyChangeSupport.firePropertyChange("Key", (object) comparable, (object) key);
      }
    }

    [LineNumberTable(new byte[] {(byte) 119, (byte) 103, (byte) 103, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setDescription(string description)
    {
      string str = this.description;
      this.description = description;
      this.propertyChangeSupport.firePropertyChange("Description", (object) str, (object) description);
    }

    public virtual bool getNotify()
    {
      return this.notify;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 93, (byte) 66, (byte) 105, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setNotify(bool notify)
    {
      int num = notify ? 1 : 0;
      if ((this.notify ? 1 : 0) == num)
        return;
      this.notify = num != 0;
      this.fireSeriesChanged();
    }

    [LineNumberTable((ushort) 211)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isEmpty()
    {
      return this.getItemCount() == 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 108, (byte) 107, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      Series series = (Series) base.clone();
      series.listeners = new EventListenerList();
      series.propertyChangeSupport = new PropertyChangeSupport((object) series);
      return (object) series;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 141, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is Series))
        return false;
      Series series = (Series) obj;
      return Object.instancehelper_equals((object) this.getKey(), (object) series.getKey()) && ObjectUtilities.equal((object) this.getDescription(), (object) series.getDescription());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 164, (byte) 108, (byte) 156})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 29 * Object.instancehelper_hashCode((object) this.key) + (this.description == null ? 0 : String.instancehelper_hashCode(this.description));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 180, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addChangeListener(SeriesChangeListener listener)
    {
      this.listeners.add(Series.class\u0024org\u0024jfree\u0024data\u0024general\u0024SeriesChangeListener != null ? Series.class\u0024org\u0024jfree\u0024data\u0024general\u0024SeriesChangeListener : (Series.class\u0024org\u0024jfree\u0024data\u0024general\u0024SeriesChangeListener = Series.class\u0024("org.jfree.data.general.SeriesChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 190, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeChangeListener(SeriesChangeListener listener)
    {
      this.listeners.remove(Series.class\u0024org\u0024jfree\u0024data\u0024general\u0024SeriesChangeListener != null ? Series.class\u0024org\u0024jfree\u0024data\u0024general\u0024SeriesChangeListener : (Series.class\u0024org\u0024jfree\u0024data\u0024general\u0024SeriesChangeListener = Series.class\u0024("org.jfree.data.general.SeriesChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 227, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addPropertyChangeListener(PropertyChangeListener listener)
    {
      this.propertyChangeSupport.addPropertyChangeListener(listener);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 236, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removePropertyChangeListener(PropertyChangeListener listener)
    {
      this.propertyChangeSupport.removePropertyChangeListener(listener);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 248, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void firePropertyChange(string property, object oldValue, object newValue)
    {
      this.propertyChangeSupport.firePropertyChange(property, oldValue, newValue);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (Series.__\u003CcallerID\u003E == null)
        Series.__\u003CcallerID\u003E = (CallerID) new Series.__\u003CCallerID\u003E();
      return Series.__\u003CcallerID\u003E;
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
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
