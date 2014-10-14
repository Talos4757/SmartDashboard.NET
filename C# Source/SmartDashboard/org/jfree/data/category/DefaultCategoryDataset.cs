// Decompiled with JetBrains decompiler
// Type: org.jfree.data.category.DefaultCategoryDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.category
{
  [Implements(new string[] {"org.jfree.data.category.CategoryDataset", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class DefaultCategoryDataset : AbstractDataset, CategoryDataset, KeyedValues2D, Values2D, Dataset, PublicCloneable, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -8168173757291644622L;
    private DefaultKeyedValues2D data;

    [LineNumberTable(new byte[] {(byte) 25, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultCategoryDataset()
    {
      DefaultCategoryDataset defaultCategoryDataset = this;
      this.data = new DefaultKeyedValues2D();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultCategoryDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultCategoryDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] DefaultCategoryDataset obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 123, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addValue(double value, IComparable rowKey, IComparable columnKey)
    {
      this.addValue((Number) new Double(value), rowKey, columnKey);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 108, (byte) 110, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addValue(Number value, IComparable rowKey, IComparable columnKey)
    {
      this.data.addValue(value, rowKey, columnKey);
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 138, (byte) 110, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(Number value, IComparable rowKey, IComparable columnKey)
    {
      this.data.setValue(value, rowKey, columnKey);
      this.fireDatasetChanged();
    }

    [LineNumberTable((ushort) 207)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(IComparable rowKey, IComparable columnKey)
    {
      return this.data.getValue(rowKey, columnKey);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 154, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(double value, IComparable rowKey, IComparable columnKey)
    {
      this.setValue((Number) new Double(value), rowKey, columnKey);
    }

    [LineNumberTable((ushort) 153)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getRowKeys()
    {
      return this.data.getRowKeys();
    }

    [LineNumberTable((ushort) 191)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getColumnKeys()
    {
      return this.data.getColumnKeys();
    }

    [LineNumberTable((ushort) 87)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowCount()
    {
      return this.data.getRowCount();
    }

    [LineNumberTable((ushort) 98)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnCount()
    {
      return this.data.getColumnCount();
    }

    [LineNumberTable((ushort) 113)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(int row, int column)
    {
      return this.data.getValue(row, column);
    }

    [LineNumberTable((ushort) 128)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getRowKey(int row)
    {
      return this.data.getRowKey(row);
    }

    [LineNumberTable((ushort) 142)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowIndex(IComparable key)
    {
      return this.data.getRowIndex(key);
    }

    [LineNumberTable((ushort) 166)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getColumnKey(int column)
    {
      return this.data.getColumnKey(column);
    }

    [LineNumberTable((ushort) 180)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnIndex(IComparable key)
    {
      return this.data.getColumnIndex(key);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 170, (byte) 102, (byte) 105, (byte) 99, (byte) 136, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void incrementValue(double value, IComparable rowKey, IComparable columnKey)
    {
      double num = 0.0;
      Number number = this.getValue(rowKey, columnKey);
      if (number != null)
        num = number.doubleValue();
      this.setValue(num + value, rowKey, columnKey);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 188, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeValue(IComparable rowKey, IComparable columnKey)
    {
      this.data.removeValue(rowKey, columnKey);
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 201, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeRow(int rowIndex)
    {
      this.data.removeRow(rowIndex);
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 214, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeRow(IComparable rowKey)
    {
      this.data.removeRow(rowKey);
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 227, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeColumn(int columnIndex)
    {
      this.data.removeColumn(columnIndex);
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 243, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeColumn(IComparable columnKey)
    {
      this.data.removeColumn(columnKey);
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 252, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.data.clear();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 8, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 103, (byte) 103, (byte) 105, (byte) 104, (byte) 107, (byte) 107, (byte) 100, (byte) 100, (byte) 162, (byte) 107, (byte) 226, (byte) 55, (byte) 40, (byte) 233, (byte) 78})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CategoryDataset))
        return false;
      CategoryDataset categoryDataset = (CategoryDataset) obj;
      if (!Object.instancehelper_equals((object) this.getRowKeys(), (object) categoryDataset.getRowKeys()) || !Object.instancehelper_equals((object) this.getColumnKeys(), (object) categoryDataset.getColumnKeys()))
        return false;
      int rowCount = this.getRowCount();
      int columnCount = this.getColumnCount();
      for (int index1 = 0; index1 < rowCount; ++index1)
      {
        for (int index2 = 0; index2 < columnCount; ++index2)
        {
          Number number1 = this.getValue(index1, index2);
          Number number2 = categoryDataset.getValue(index1, index2);
          if (number1 == null)
          {
            if (number2 != null)
              return false;
          }
          else if (!Object.instancehelper_equals((object) number1, (object) number2))
            return false;
        }
      }
      return true;
    }

    [LineNumberTable((ushort) 416)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return this.data.hashCode();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 58, (byte) 108, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      DefaultCategoryDataset defaultCategoryDataset = (DefaultCategoryDataset) base.clone();
      defaultCategoryDataset.data = (DefaultKeyedValues2D) this.data.clone();
      return (object) defaultCategoryDataset;
    }
  }
}
