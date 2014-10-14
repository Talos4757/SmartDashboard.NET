// Decompiled with JetBrains decompiler
// Type: org.jfree.data.general.DefaultKeyedValueDataset
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
  [Implements(new string[] {"org.jfree.data.general.KeyedValueDataset", "java.io.Serializable"})]
  [Serializable]
  public class DefaultKeyedValueDataset : AbstractDataset, KeyedValueDataset, KeyedValue, Value, Dataset, Serializable.__Interface
  {
    private const long serialVersionUID = -8149484339560406750L;
    private KeyedValue data;

    [LineNumberTable(new byte[] {(byte) 35, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultKeyedValueDataset(KeyedValue data)
    {
      DefaultKeyedValueDataset keyedValueDataset = this;
      this.data = data;
    }

    [LineNumberTable(new byte[] {(byte) 16, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultKeyedValueDataset()
      : this((KeyedValue) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 26, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultKeyedValueDataset(IComparable key, Number value)
      : this((KeyedValue) new DefaultKeyedValue(key, value))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultKeyedValueDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DefaultKeyedValueDataset obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 86, (byte) 109, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(IComparable key, Number value)
    {
      this.data = (KeyedValue) new DefaultKeyedValue(key, value);
      this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 98, (byte) 104, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getKey()
    {
      IComparable comparable = (IComparable) null;
      if (this.data != null)
        comparable = this.data.getKey();
      return comparable;
    }

    [LineNumberTable(new byte[] {(byte) 59, (byte) 98, (byte) 104, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue()
    {
      Number number = (Number) null;
      if (this.data != null)
        number = this.data.getValue();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 72, (byte) 104, (byte) 144, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void updateValue(Number value)
    {
      if (this.data == null)
      {
        string str = "updateValue: can't update null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
      else
        this.setValue(this.data.getKey(), value);
    }

    [LineNumberTable(new byte[] {(byte) 98, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 104, (byte) 112, (byte) 130, (byte) 130, (byte) 120, (byte) 130, (byte) 120, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is KeyedValueDataset))
        return false;
      KeyedValueDataset keyedValueDataset = (KeyedValueDataset) obj;
      if (this.data == null)
        return keyedValueDataset.getKey() == null && keyedValueDataset.getValue() == null;
      else
        return ObjectUtilities.equal((object) this.data.getKey(), (object) keyedValueDataset.getKey()) && ObjectUtilities.equal((object) this.data.getValue(), (object) keyedValueDataset.getValue());
    }

    [LineNumberTable((ushort) 176)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      if (this.data != null)
        return Object.instancehelper_hashCode((object) this.data);
      else
        return 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 74, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return (object) (DefaultKeyedValueDataset) base.clone();
    }
  }
}
