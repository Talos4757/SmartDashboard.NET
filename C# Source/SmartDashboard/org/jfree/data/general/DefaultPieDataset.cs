// Decompiled with JetBrains decompiler
// Type: org.jfree.data.general.DefaultPieDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.data;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.general
{
  [Implements(new string[] {"org.jfree.data.general.PieDataset", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class DefaultPieDataset : AbstractDataset, PieDataset, KeyedValues, Values, Dataset, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 2904745139106540618L;
    private DefaultKeyedValues data;

    [LineNumberTable(new byte[] {(byte) 34, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultPieDataset()
    {
      DefaultPieDataset defaultPieDataset = this;
      this.data = new DefaultKeyedValues();
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 104, (byte) 99, (byte) 144, (byte) 107, (byte) 107, (byte) 57, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultPieDataset(KeyedValues data)
    {
      DefaultPieDataset defaultPieDataset = this;
      if (data == null)
      {
        string str = "Null 'data' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.data = new DefaultKeyedValues();
        for (int i = 0; i < data.getItemCount(); ++i)
          this.data.addValue(data.getKey(i), data.getValue(i));
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultPieDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultPieDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DefaultPieDataset obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 82, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(IComparable key, Number value)
    {
      this.data.setValue(key, value);
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 97, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(IComparable key, double value)
    {
      this.setValue(key, (Number) new Double(value));
    }

    [LineNumberTable((ushort) 110)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getItemCount()
    {
      return this.data.getItemCount();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 131, (byte) 110, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void insertValue(int position, IComparable key, Number value)
    {
      this.data.insertValue(position, key, value);
      this.fireDatasetChanged();
    }

    [LineNumberTable((ushort) 135)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getKey(int item)
    {
      return this.data.getKey(item);
    }

    [LineNumberTable(new byte[] {(byte) 111, (byte) 98, (byte) 105, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(int item)
    {
      Number number = (Number) null;
      if (this.getItemCount() > item)
        number = this.data.getValue(item);
      return number;
    }

    [LineNumberTable((ushort) 120)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getKeys()
    {
      return Collections.unmodifiableList(this.data.getKeys());
    }

    [LineNumberTable((ushort) 149)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getIndex(IComparable key)
    {
      return this.data.getIndex(key);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(IComparable key)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return this.data.getValue(key);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 114, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void insertValue(int position, IComparable key, double value)
    {
      this.insertValue(position, key, (Number) new Double(value));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 145, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove(IComparable key)
    {
      this.data.removeValue(key);
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 156, (byte) 105, (byte) 107, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      if (this.getItemCount() <= 0)
        return;
      this.data.clear();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 171, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sortByKeys(SortOrder order)
    {
      this.data.sortByKeys(order);
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 184, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void sortByValues(SortOrder order)
    {
      this.data.sortByValues(order);
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 196, (byte) 100, (byte) 162, (byte) 104, (byte) 130, (byte) 103, (byte) 103, (byte) 105, (byte) 162, (byte) 105, (byte) 104, (byte) 105, (byte) 106, (byte) 162, (byte) 105, (byte) 105, (byte) 100, (byte) 100, (byte) 194, (byte) 107, (byte) 226, (byte) 48, (byte) 233, (byte) 84})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is PieDataset))
        return false;
      PieDataset pieDataset = (PieDataset) obj;
      int itemCount = this.getItemCount();
      if (pieDataset.getItemCount() != itemCount)
        return false;
      for (int i = 0; i < itemCount; ++i)
      {
        if (!Object.instancehelper_equals((object) this.getKey(i), (object) pieDataset.getKey(i)))
          return false;
        Number number1 = this.getValue(i);
        Number number2 = pieDataset.getValue(i);
        if (number1 == null)
        {
          if (number2 != null)
            return false;
        }
        else if (!Object.instancehelper_equals((object) number1, (object) number2))
          return false;
      }
      return true;
    }

    [LineNumberTable((ushort) 353)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return this.data.hashCode();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 251, (byte) 108, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      DefaultPieDataset defaultPieDataset = (DefaultPieDataset) base.clone();
      defaultPieDataset.data = (DefaultKeyedValues) this.data.clone();
      return (object) defaultPieDataset;
    }
  }
}
