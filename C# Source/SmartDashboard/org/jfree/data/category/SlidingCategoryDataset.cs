// Decompiled with JetBrains decompiler
// Type: org.jfree.data.category.SlidingCategoryDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
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
  [Implements(new string[] {"org.jfree.data.category.CategoryDataset"})]
  [Serializable]
  public class SlidingCategoryDataset : AbstractDataset, CategoryDataset, KeyedValues2D, Values2D, Dataset
  {
    private CategoryDataset underlying;
    private int firstCategoryIndex;
    private int maximumCategoryCount;

    [LineNumberTable(new byte[] {(byte) 32, (byte) 104, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SlidingCategoryDataset(CategoryDataset underlying, int firstColumn, int maxColumns)
    {
      SlidingCategoryDataset slidingCategoryDataset = this;
      this.underlying = underlying;
      this.firstCategoryIndex = firstColumn;
      this.maximumCategoryCount = maxColumns;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SlidingCategoryDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 104, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private int lastCategoryIndex()
    {
      if (this.maximumCategoryCount == 0)
        return -1;
      else
        return Math.min(this.firstCategoryIndex + this.maximumCategoryCount, this.underlying.getColumnCount()) - 1;
    }

    [LineNumberTable((ushort) 217)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowIndex(IComparable key)
    {
      return this.underlying.getRowIndex(key);
    }

    [LineNumberTable(new byte[] {(byte) 123, (byte) 109, (byte) 114, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnIndex(IComparable key)
    {
      int columnIndex = this.underlying.getColumnIndex(key);
      if (columnIndex >= this.firstCategoryIndex && columnIndex <= this.lastCategoryIndex())
        return columnIndex - this.firstCategoryIndex;
      else
        return -1;
    }

    public virtual CategoryDataset getUnderlyingDataset()
    {
      return this.underlying;
    }

    public virtual int getFirstCategoryIndex()
    {
      return this.firstCategoryIndex;
    }

    [LineNumberTable(new byte[] {(byte) 68, (byte) 114, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFirstCategoryIndex(int first)
    {
      if (first < 0 || first >= this.underlying.getColumnCount())
      {
        string str = "Invalid index.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.firstCategoryIndex = first;
        this.fireDatasetChanged();
      }
    }

    public virtual int getMaximumCategoryCount()
    {
      return this.maximumCategoryCount;
    }

    [LineNumberTable(new byte[] {(byte) 95, (byte) 100, (byte) 144, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaximumCategoryCount(int max)
    {
      if (max < 0)
      {
        string str = "Requires 'max' >= 0.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.maximumCategoryCount = max;
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable((ushort) 190)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getColumnKey(int column)
    {
      return this.underlying.getColumnKey(column + this.firstCategoryIndex);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 87, (byte) 102, (byte) 103, (byte) 107, (byte) 51, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getColumnKeys()
    {
      ArrayList arrayList = new ArrayList();
      int num = this.lastCategoryIndex();
      for (int i = this.firstCategoryIndex; i <= num; ++i)
        ((List) arrayList).add((object) this.underlying.getColumnKey(i));
      return Collections.unmodifiableList((List) arrayList);
    }

    [LineNumberTable((ushort) 230)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getRowKey(int row)
    {
      return this.underlying.getRowKey(row);
    }

    [LineNumberTable((ushort) 239)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getRowKeys()
    {
      return this.underlying.getRowKeys();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 139, (byte) 104, (byte) 104, (byte) 100, (byte) 183})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(IComparable rowKey, IComparable columnKey)
    {
      int rowIndex = this.getRowIndex(rowKey);
      int columnIndex = this.getColumnIndex(columnKey);
      if (columnIndex != -1)
      {
        return this.underlying.getValue(rowIndex, columnIndex + this.firstCategoryIndex);
      }
      else
      {
        string message = new StringBuffer().append("Unknown columnKey: ").append((object) columnKey).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 155, (byte) 103, (byte) 100, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnCount()
    {
      int num = this.lastCategoryIndex();
      if (num == -1)
        return 0;
      return Math.max(num - this.firstCategoryIndex + 1, 0);
    }

    [LineNumberTable((ushort) 284)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowCount()
    {
      return this.underlying.getRowCount();
    }

    [LineNumberTable((ushort) 296)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(int row, int column)
    {
      return this.underlying.getValue(row, column + this.firstCategoryIndex);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 194, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is SlidingCategoryDataset))
        return false;
      SlidingCategoryDataset slidingCategoryDataset = (SlidingCategoryDataset) obj;
      return this.firstCategoryIndex == slidingCategoryDataset.firstCategoryIndex && this.maximumCategoryCount == slidingCategoryDataset.maximumCategoryCount && Object.instancehelper_equals((object) this.underlying, (object) slidingCategoryDataset.underlying);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 228, (byte) 108, (byte) 109, (byte) 108, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      SlidingCategoryDataset slidingCategoryDataset = (SlidingCategoryDataset) base.clone();
      if (this.underlying is PublicCloneable)
      {
        PublicCloneable publicCloneable = (PublicCloneable) this.underlying;
        slidingCategoryDataset.underlying = (CategoryDataset) publicCloneable.clone();
      }
      return (object) slidingCategoryDataset;
    }
  }
}
