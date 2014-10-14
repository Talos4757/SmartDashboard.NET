// Decompiled with JetBrains decompiler
// Type: org.jfree.data.general.AbstractDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using javax.swing.@event;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.data.general
{
  [Implements(new string[] {"org.jfree.data.general.Dataset", "java.lang.Cloneable", "java.io.Serializable", "java.io.ObjectInputValidation"})]
  [Serializable]
  public abstract class AbstractDataset : Object, Dataset, Cloneable.__Interface, Serializable.__Interface, ObjectInputValidation, ISerializable
  {
    private const long serialVersionUID = 1918768939869230744L;
    private DatasetGroup group;
    [NonSerialized]
    private EventListenerList listenerList;
    internal static Class class\u0024org\u0024jfree\u0024data\u0024general\u0024DatasetChangeListener;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 42, (byte) 104, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractDataset()
    {
      base.\u002Ector();
      AbstractDataset abstractDataset = this;
      this.group = new DatasetGroup();
      this.listenerList = new EventListenerList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] AbstractDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] AbstractDataset obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 130)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, AbstractDataset.__\u003CGetCallerID\u003E());
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 68, (byte) 108, (byte) 105, (byte) 127, (byte) 4, (byte) 16, (byte) 231, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void notifyListeners(DatasetChangeEvent @event)
    {
      object[] listenerList = this.listenerList.getListenerList();
      int index = listenerList.Length - 2;
      while (index >= 0)
      {
        if (listenerList[index] == (AbstractDataset.class\u0024org\u0024jfree\u0024data\u0024general\u0024DatasetChangeListener != null ? AbstractDataset.class\u0024org\u0024jfree\u0024data\u0024general\u0024DatasetChangeListener : (AbstractDataset.class\u0024org\u0024jfree\u0024data\u0024general\u0024DatasetChangeListener = AbstractDataset.class\u0024("org.jfree.data.general.DatasetChangeListener"))))
          ((DatasetChangeListener) listenerList[index + 1]).datasetChanged(@event);
        index += -2;
      }
    }

    [LineNumberTable(new byte[] {(byte) 118, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void fireDatasetChanged()
    {
      this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
    }

    public virtual DatasetGroup getGroup()
    {
      return this.group;
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGroup(DatasetGroup group)
    {
      if (group == null)
      {
        string str = "Null 'group' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.group = group;
    }

    [LineNumberTable(new byte[] {(byte) 80, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addChangeListener(DatasetChangeListener listener)
    {
      this.listenerList.add(AbstractDataset.class\u0024org\u0024jfree\u0024data\u0024general\u0024DatasetChangeListener != null ? AbstractDataset.class\u0024org\u0024jfree\u0024data\u0024general\u0024DatasetChangeListener : (AbstractDataset.class\u0024org\u0024jfree\u0024data\u0024general\u0024DatasetChangeListener = AbstractDataset.class\u0024("org.jfree.data.general.DatasetChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 127, (byte) 13})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeChangeListener(DatasetChangeListener listener)
    {
      this.listenerList.remove(AbstractDataset.class\u0024org\u0024jfree\u0024data\u0024general\u0024DatasetChangeListener != null ? AbstractDataset.class\u0024org\u0024jfree\u0024data\u0024general\u0024DatasetChangeListener : (AbstractDataset.class\u0024org\u0024jfree\u0024data\u0024general\u0024DatasetChangeListener = AbstractDataset.class\u0024("org.jfree.data.general.DatasetChangeListener")), (EventListener) listener);
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool hasListener(EventListener listener)
    {
      return (Arrays.asList(this.listenerList.getListenerList()).contains((object) listener) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 89, (byte) 108, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      AbstractDataset abstractDataset = (AbstractDataset) base.clone();
      abstractDataset.listenerList = new EventListenerList();
      return (object) abstractDataset;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 115, (byte) 102, (byte) 107, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.listenerList = new EventListenerList();
      obj0.registerValidation((ObjectInputValidation) this, 10);
    }

    [Throws(new string[] {"java.io.InvalidObjectException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 139, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void validateObject()
    {
      this.fireDatasetChanged();
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (AbstractDataset.__\u003CcallerID\u003E == null)
        AbstractDataset.__\u003CcallerID\u003E = (CallerID) new AbstractDataset.__\u003CCallerID\u003E();
      return AbstractDataset.__\u003CcallerID\u003E;
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
