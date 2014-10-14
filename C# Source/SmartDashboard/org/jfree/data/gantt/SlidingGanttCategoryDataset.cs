// Decompiled with JetBrains decompiler
// Type: org.jfree.data.gantt.SlidingGanttCategoryDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.data;
using org.jfree.data.category;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.gantt
{
  [Implements(new string[] {"org.jfree.data.gantt.GanttCategoryDataset"})]
  [Serializable]
  public class SlidingGanttCategoryDataset : AbstractDataset, GanttCategoryDataset, IntervalCategoryDataset, CategoryDataset, KeyedValues2D, Values2D, Dataset
  {
    private GanttCategoryDataset underlying;
    private int firstCategoryIndex;
    private int maximumCategoryCount;

    [LineNumberTable(new byte[] {(byte) 31, (byte) 104, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SlidingGanttCategoryDataset(GanttCategoryDataset underlying, int firstColumn, int maxColumns)
    {
      SlidingGanttCategoryDataset ganttCategoryDataset = this;
      this.underlying = underlying;
      this.firstCategoryIndex = firstColumn;
      this.maximumCategoryCount = maxColumns;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SlidingGanttCategoryDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 107, (byte) 104, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private int lastCategoryIndex()
    {
      if (this.maximumCategoryCount == 0)
        return -1;
      else
        return Math.min(this.firstCategoryIndex + this.maximumCategoryCount, this.underlying.getColumnCount()) - 1;
    }

    [LineNumberTable((ushort) 216)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowIndex(IComparable key)
    {
      return this.underlying.getRowIndex(key);
    }

    [LineNumberTable(new byte[] {(byte) 122, (byte) 109, (byte) 114, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnIndex(IComparable key)
    {
      int columnIndex = this.underlying.getColumnIndex(key);
      if (columnIndex >= this.firstCategoryIndex && columnIndex <= this.lastCategoryIndex())
        return columnIndex - this.firstCategoryIndex;
      else
        return -1;
    }

    public virtual GanttCategoryDataset getUnderlyingDataset()
    {
      return this.underlying;
    }

    public virtual int getFirstCategoryIndex()
    {
      return this.firstCategoryIndex;
    }

    [LineNumberTable(new byte[] {(byte) 67, (byte) 114, (byte) 144, (byte) 103, (byte) 104})]
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

    [LineNumberTable(new byte[] {(byte) 94, (byte) 100, (byte) 144, (byte) 103, (byte) 104})]
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

    [LineNumberTable((ushort) 189)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getColumnKey(int column)
    {
      return this.underlying.getColumnKey(column + this.firstCategoryIndex);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 86, (byte) 102, (byte) 103, (byte) 107, (byte) 51, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getColumnKeys()
    {
      ArrayList arrayList = new ArrayList();
      int num = this.lastCategoryIndex();
      for (int i = this.firstCategoryIndex; i < num; ++i)
        ((List) arrayList).add((object) this.underlying.getColumnKey(i));
      return Collections.unmodifiableList((List) arrayList);
    }

    [LineNumberTable((ushort) 229)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getRowKey(int row)
    {
      return this.underlying.getRowKey(row);
    }

    [LineNumberTable((ushort) 238)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getRowKeys()
    {
      return this.underlying.getRowKeys();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 138, (byte) 104, (byte) 104, (byte) 100, (byte) 183})]
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 154, (byte) 103, (byte) 100, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnCount()
    {
      int num = this.lastCategoryIndex();
      if (num == -1)
        return 0;
      return Math.max(num - this.firstCategoryIndex + 1, 0);
    }

    [LineNumberTable((ushort) 283)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowCount()
    {
      return this.underlying.getRowCount();
    }

    [LineNumberTable((ushort) 295)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(int row, int column)
    {
      return this.underlying.getValue(row, column + this.firstCategoryIndex);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 193, (byte) 104, (byte) 104, (byte) 100, (byte) 215})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getPercentComplete(IComparable rowKey, IComparable columnKey)
    {
      int rowIndex = this.getRowIndex(rowKey);
      int columnIndex = this.getColumnIndex(columnKey);
      if (columnIndex != -1)
      {
        return this.underlying.getPercentComplete(rowIndex, columnIndex + this.firstCategoryIndex);
      }
      else
      {
        string message = new StringBuffer().append("Unknown columnKey: ").append((object) columnKey).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 217, (byte) 104, (byte) 104, (byte) 100, (byte) 216})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getPercentComplete(IComparable rowKey, IComparable columnKey, int subinterval)
    {
      int rowIndex = this.getRowIndex(rowKey);
      int columnIndex = this.getColumnIndex(columnKey);
      if (columnIndex != -1)
      {
        return this.underlying.getPercentComplete(rowIndex, columnIndex + this.firstCategoryIndex, subinterval);
      }
      else
      {
        string message = new StringBuffer().append("Unknown columnKey: ").append((object) columnKey).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 241, (byte) 104, (byte) 104, (byte) 100, (byte) 216})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getEndValue(IComparable rowKey, IComparable columnKey, int subinterval)
    {
      int rowIndex = this.getRowIndex(rowKey);
      int columnIndex = this.getColumnIndex(columnKey);
      if (columnIndex != -1)
      {
        return this.underlying.getEndValue(rowIndex, columnIndex + this.firstCategoryIndex, subinterval);
      }
      else
      {
        string message = new StringBuffer().append("Unknown columnKey: ").append((object) columnKey).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
    }

    [LineNumberTable((ushort) 378)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getEndValue(int row, int column, int subinterval)
    {
      return this.underlying.getEndValue(row, column + this.firstCategoryIndex, subinterval);
    }

    [LineNumberTable((ushort) 391)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getPercentComplete(int series, int category)
    {
      return this.underlying.getPercentComplete(series, category + this.firstCategoryIndex);
    }

    [LineNumberTable((ushort) 407)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getPercentComplete(int row, int column, int subinterval)
    {
      return this.underlying.getPercentComplete(row, column + this.firstCategoryIndex, subinterval);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 54, (byte) 104, (byte) 104, (byte) 100, (byte) 216})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getStartValue(IComparable rowKey, IComparable columnKey, int subinterval)
    {
      int rowIndex = this.getRowIndex(rowKey);
      int columnIndex = this.getColumnIndex(columnKey);
      if (columnIndex != -1)
      {
        return this.underlying.getStartValue(rowIndex, columnIndex + this.firstCategoryIndex, subinterval);
      }
      else
      {
        string message = new StringBuffer().append("Unknown columnKey: ").append((object) columnKey).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
    }

    [LineNumberTable((ushort) 447)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getStartValue(int row, int column, int subinterval)
    {
      return this.underlying.getStartValue(row, column + this.firstCategoryIndex, subinterval);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 92, (byte) 104, (byte) 104, (byte) 100, (byte) 215})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getSubIntervalCount(IComparable rowKey, IComparable columnKey)
    {
      int rowIndex = this.getRowIndex(rowKey);
      int columnIndex = this.getColumnIndex(columnKey);
      if (columnIndex != -1)
      {
        return this.underlying.getSubIntervalCount(rowIndex, columnIndex + this.firstCategoryIndex);
      }
      else
      {
        string message = new StringBuffer().append("Unknown columnKey: ").append((object) columnKey).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
    }

    [LineNumberTable((ushort) 484)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getSubIntervalCount(int row, int column)
    {
      return this.underlying.getSubIntervalCount(row, column + this.firstCategoryIndex);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 129, (byte) 104, (byte) 104, (byte) 100, (byte) 183})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getStartValue(IComparable rowKey, IComparable columnKey)
    {
      int rowIndex = this.getRowIndex(rowKey);
      int columnIndex = this.getColumnIndex(columnKey);
      if (columnIndex != -1)
      {
        return this.underlying.getStartValue(rowIndex, columnIndex + this.firstCategoryIndex);
      }
      else
      {
        string message = new StringBuffer().append("Unknown columnKey: ").append((object) columnKey).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
    }

    [LineNumberTable((ushort) 520)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getStartValue(int row, int column)
    {
      return this.underlying.getStartValue(row, column + this.firstCategoryIndex);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 165, (byte) 104, (byte) 104, (byte) 100, (byte) 183})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getEndValue(IComparable rowKey, IComparable columnKey)
    {
      int rowIndex = this.getRowIndex(rowKey);
      int columnIndex = this.getColumnIndex(columnKey);
      if (columnIndex != -1)
      {
        return this.underlying.getEndValue(rowIndex, columnIndex + this.firstCategoryIndex);
      }
      else
      {
        string message = new StringBuffer().append("Unknown columnKey: ").append((object) columnKey).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new UnknownKeyException(message);
      }
    }

    [LineNumberTable((ushort) 554)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getEndValue(int series, int category)
    {
      return this.underlying.getEndValue(series, category + this.firstCategoryIndex);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 197, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is SlidingGanttCategoryDataset))
        return false;
      SlidingGanttCategoryDataset ganttCategoryDataset = (SlidingGanttCategoryDataset) obj;
      return this.firstCategoryIndex == ganttCategoryDataset.firstCategoryIndex && this.maximumCategoryCount == ganttCategoryDataset.maximumCategoryCount && Object.instancehelper_equals((object) this.underlying, (object) ganttCategoryDataset.underlying);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 231, (byte) 140, (byte) 109, (byte) 108, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      SlidingGanttCategoryDataset ganttCategoryDataset = (SlidingGanttCategoryDataset) base.clone();
      if (this.underlying is PublicCloneable)
      {
        PublicCloneable publicCloneable = (PublicCloneable) this.underlying;
        ganttCategoryDataset.underlying = (GanttCategoryDataset) publicCloneable.clone();
      }
      return (object) ganttCategoryDataset;
    }
  }
}
