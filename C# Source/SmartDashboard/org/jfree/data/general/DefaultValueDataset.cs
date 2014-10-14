// Decompiled with JetBrains decompiler
// Type: org.jfree.data.general.DefaultValueDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using org.jfree.data;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.general
{
  [Implements(new string[] {"org.jfree.data.general.ValueDataset", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class DefaultValueDataset : AbstractDataset, ValueDataset, Value, Dataset, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 8137521217249294891L;
    private Number value;

    [LineNumberTable(new byte[] {(byte) 38, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultValueDataset(Number value)
    {
      DefaultValueDataset defaultValueDataset = this;
      this.value = value;
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultValueDataset()
      : this((Number) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultValueDataset(double value)
      : this((Number) new Double(value))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultValueDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultValueDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DefaultValueDataset obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual Number getValue()
    {
      return this.value;
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(Number value)
    {
      this.value = value;
      this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
    }

    [LineNumberTable(new byte[] {(byte) 70, (byte) 100, (byte) 130, (byte) 104, (byte) 103, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ValueDataset))
        return false;
      return (ObjectUtilities.equal((object) this.value, (object) ((Value) obj).getValue()) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 136)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      if (this.value != null)
        return Object.instancehelper_hashCode((object) this.value);
      else
        return 0;
    }
  }
}
