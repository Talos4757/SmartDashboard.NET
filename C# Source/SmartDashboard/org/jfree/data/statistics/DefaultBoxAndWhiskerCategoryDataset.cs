// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.DefaultBoxAndWhiskerCategoryDataset
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

namespace org.jfree.data.statistics
{
  [Implements(new string[] {"org.jfree.data.statistics.BoxAndWhiskerCategoryDataset", "org.jfree.data.RangeInfo", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class DefaultBoxAndWhiskerCategoryDataset : AbstractDataset, BoxAndWhiskerCategoryDataset, CategoryDataset, KeyedValues2D, Values2D, Dataset, RangeInfo, PublicCloneable, Cloneable.__Interface
  {
    protected internal KeyedObjects2D data;
    private double minimumRangeValue;
    private int minimumRangeValueRow;
    private int minimumRangeValueColumn;
    private double maximumRangeValue;
    private int maximumRangeValueRow;
    private int maximumRangeValueColumn;

    [LineNumberTable(new byte[] {(byte) 54, (byte) 104, (byte) 107, (byte) 112, (byte) 103, (byte) 103, (byte) 112, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultBoxAndWhiskerCategoryDataset()
    {
      DefaultBoxAndWhiskerCategoryDataset whiskerCategoryDataset = this;
      this.data = new KeyedObjects2D();
      this.minimumRangeValue = double.NaN;
      this.minimumRangeValueRow = -1;
      this.minimumRangeValueColumn = -1;
      this.maximumRangeValue = double.NaN;
      this.maximumRangeValueRow = -1;
      this.maximumRangeValueColumn = -1;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultBoxAndWhiskerCategoryDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultBoxAndWhiskerCategoryDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 174, (byte) 109, (byte) 109, (byte) 191, (byte) 5, (byte) 203, (byte) 106, (byte) 104, (byte) 141, (byte) 106, (byte) 104, (byte) 173, (byte) 109, (byte) 104, (byte) 103, (byte) 137, (byte) 105, (byte) 104, (byte) 103, (byte) 167, (byte) 109, (byte) 104, (byte) 103, (byte) 137, (byte) 105, (byte) 104, (byte) 103, (byte) 199, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(BoxAndWhiskerItem item, IComparable rowKey, IComparable columnKey)
    {
      this.data.addObject((object) item, rowKey, columnKey);
      int rowIndex = this.data.getRowIndex(rowKey);
      int columnIndex = this.data.getColumnIndex(columnKey);
      if (this.maximumRangeValueRow == rowIndex && this.maximumRangeValueColumn == columnIndex || this.minimumRangeValueRow == rowIndex && this.minimumRangeValueColumn == columnIndex)
      {
        this.updateBounds();
      }
      else
      {
        double num1 = double.NaN;
        if (item.getMinOutlier() != null)
          num1 = item.getMinOutlier().doubleValue();
        double num2 = double.NaN;
        if (item.getMaxOutlier() != null)
          num2 = item.getMaxOutlier().doubleValue();
        if (Double.isNaN(this.maximumRangeValue))
        {
          this.maximumRangeValue = num2;
          this.maximumRangeValueRow = rowIndex;
          this.maximumRangeValueColumn = columnIndex;
        }
        else if (num2 > this.maximumRangeValue)
        {
          this.maximumRangeValue = num2;
          this.maximumRangeValueRow = rowIndex;
          this.maximumRangeValueColumn = columnIndex;
        }
        if (Double.isNaN(this.minimumRangeValue))
        {
          this.minimumRangeValue = num1;
          this.minimumRangeValueRow = rowIndex;
          this.minimumRangeValueColumn = columnIndex;
        }
        else if (num1 < this.minimumRangeValue)
        {
          this.minimumRangeValue = num1;
          this.minimumRangeValueRow = rowIndex;
          this.minimumRangeValueColumn = columnIndex;
        }
      }
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 216, (byte) 112, (byte) 103, (byte) 103, (byte) 112, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 105, (byte) 105, (byte) 106, (byte) 103, (byte) 105, (byte) 100, (byte) 106, (byte) 105, (byte) 151, (byte) 105, (byte) 103, (byte) 199, (byte) 105, (byte) 100, (byte) 106, (byte) 105, (byte) 151, (byte) 105, (byte) 103, (byte) 231, (byte) 41, (byte) 41, (byte) 233, (byte) 95})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void updateBounds()
    {
      this.minimumRangeValue = double.NaN;
      this.minimumRangeValueRow = -1;
      this.minimumRangeValueColumn = -1;
      this.maximumRangeValue = double.NaN;
      this.maximumRangeValueRow = -1;
      this.maximumRangeValueColumn = -1;
      int rowCount = this.getRowCount();
      int columnCount = this.getColumnCount();
      for (int row = 0; row < rowCount; ++row)
      {
        for (int column = 0; column < columnCount; ++column)
        {
          BoxAndWhiskerItem boxAndWhiskerItem = this.getItem(row, column);
          if (boxAndWhiskerItem != null)
          {
            Number minOutlier = boxAndWhiskerItem.getMinOutlier();
            if (minOutlier != null)
            {
              double num = minOutlier.doubleValue();
              if (!Double.isNaN(num) && (num < this.minimumRangeValue || Double.isNaN(this.minimumRangeValue)))
              {
                this.minimumRangeValue = num;
                this.minimumRangeValueRow = row;
                this.minimumRangeValueColumn = column;
              }
            }
            Number maxOutlier = boxAndWhiskerItem.getMaxOutlier();
            if (maxOutlier != null)
            {
              double num = maxOutlier.doubleValue();
              if (!Double.isNaN(num) && (num > this.maximumRangeValue || Double.isNaN(this.maximumRangeValue)))
              {
                this.maximumRangeValue = num;
                this.maximumRangeValueRow = row;
                this.maximumRangeValueColumn = column;
              }
            }
          }
        }
      }
    }

    [LineNumberTable((ushort) 548)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowIndex(IComparable key)
    {
      return this.data.getRowIndex(key);
    }

    [LineNumberTable((ushort) 510)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnIndex(IComparable key)
    {
      return this.data.getColumnIndex(key);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 21, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMedianValue(int row, int column)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(row, column);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMedian();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 41, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMedianValue(IComparable rowKey, IComparable columnKey)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(rowKey, columnKey);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMedian();
      return number;
    }

    [LineNumberTable((ushort) 583)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowCount()
    {
      return this.data.getRowCount();
    }

    [LineNumberTable((ushort) 594)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnCount()
    {
      return this.data.getColumnCount();
    }

    [LineNumberTable((ushort) 305)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual BoxAndWhiskerItem getItem(int row, int column)
    {
      return (BoxAndWhiskerItem) this.data.getObject(row, column);
    }

    [LineNumberTable(new byte[] {(byte) 76, (byte) 135, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(List list, IComparable rowKey, IComparable columnKey)
    {
      this.add(BoxAndWhiskerCalculator.calculateBoxAndWhiskerStatistics(list), rowKey, columnKey);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 91, (byte) 104, (byte) 104, (byte) 205, (byte) 191, (byte) 5, (byte) 166, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove(IComparable rowKey, IComparable columnKey)
    {
      int rowIndex = this.getRowIndex(rowKey);
      int columnIndex = this.getColumnIndex(columnKey);
      this.data.removeObject(rowKey, columnKey);
      if (this.maximumRangeValueRow == rowIndex && this.maximumRangeValueColumn == columnIndex || this.minimumRangeValueRow == rowIndex && this.minimumRangeValueColumn == columnIndex)
        this.updateBounds();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 117, (byte) 108, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeRow(int rowIndex)
    {
      this.data.removeRow(rowIndex);
      this.updateBounds();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 133, (byte) 108, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeRow(IComparable rowKey)
    {
      this.data.removeRow(rowKey);
      this.updateBounds();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 149, (byte) 108, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeColumn(int columnIndex)
    {
      this.data.removeColumn(columnIndex);
      this.updateBounds();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 165, (byte) 108, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeColumn(IComparable columnKey)
    {
      this.data.removeColumn(columnKey);
      this.updateBounds();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 177, (byte) 107, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.data.clear();
      this.updateBounds();
      this.fireDatasetChanged();
    }

    [LineNumberTable((ushort) 320)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(int row, int column)
    {
      return this.getMedianValue(row, column);
    }

    [LineNumberTable((ushort) 335)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(IComparable rowKey, IComparable columnKey)
    {
      return this.getMedianValue(rowKey, columnKey);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 236, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMeanValue(int row, int column)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(row, column);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMean();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 1, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMeanValue(IComparable rowKey, IComparable columnKey)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(rowKey, columnKey);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMean();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 61, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getQ1Value(int row, int column)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(row, column);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getQ1();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 81, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getQ1Value(IComparable rowKey, IComparable columnKey)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(rowKey, columnKey);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getQ1();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 101, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getQ3Value(int row, int column)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(row, column);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getQ3();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 121, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getQ3Value(IComparable rowKey, IComparable columnKey)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(rowKey, columnKey);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getQ3();
      return number;
    }

    [LineNumberTable((ushort) 523)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getColumnKey(int column)
    {
      return this.data.getColumnKey(column);
    }

    [LineNumberTable((ushort) 534)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getColumnKeys()
    {
      return this.data.getColumnKeys();
    }

    [LineNumberTable((ushort) 561)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getRowKey(int row)
    {
      return this.data.getRowKey(row);
    }

    [LineNumberTable((ushort) 572)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getRowKeys()
    {
      return this.data.getRowKeys();
    }

    public virtual double getRangeLowerBound(bool includeInterval)
    {
      return this.minimumRangeValue;
    }

    public virtual double getRangeUpperBound(bool includeInterval)
    {
      return this.maximumRangeValue;
    }

    [LineNumberTable((ushort) 634)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getRangeBounds(bool includeInterval)
    {
      return new Range(this.minimumRangeValue, this.maximumRangeValue);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 22, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMinRegularValue(int row, int column)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(row, column);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMinRegularValue();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 42, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMinRegularValue(IComparable rowKey, IComparable columnKey)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(rowKey, columnKey);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMinRegularValue();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 62, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMaxRegularValue(int row, int column)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(row, column);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMaxRegularValue();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 82, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMaxRegularValue(IComparable rowKey, IComparable columnKey)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(rowKey, columnKey);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMaxRegularValue();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 102, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMinOutlier(int row, int column)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(row, column);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMinOutlier();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 122, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMinOutlier(IComparable rowKey, IComparable columnKey)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(rowKey, columnKey);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMinOutlier();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 142, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMaxOutlier(int row, int column)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(row, column);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMaxOutlier();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 162, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMaxOutlier(IComparable rowKey, IComparable columnKey)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(rowKey, columnKey);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMaxOutlier();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 182, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getOutliers(int row, int column)
    {
      List list = (List) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(row, column);
      if (boxAndWhiskerItem != null)
        list = boxAndWhiskerItem.getOutliers();
      return list;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 202, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getOutliers(IComparable rowKey, IComparable columnKey)
    {
      List list = (List) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.data.getObject(rowKey, columnKey);
      if (boxAndWhiskerItem != null)
        list = boxAndWhiskerItem.getOutliers();
      return list;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 9, (byte) 100, (byte) 130, (byte) 104, (byte) 135, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DefaultBoxAndWhiskerCategoryDataset))
        return false;
      return (ObjectUtilities.equal((object) this.data, (object) ((DefaultBoxAndWhiskerCategoryDataset) obj).data) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 28, (byte) 140, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      DefaultBoxAndWhiskerCategoryDataset whiskerCategoryDataset = (DefaultBoxAndWhiskerCategoryDataset) base.clone();
      whiskerCategoryDataset.data = (KeyedObjects2D) this.data.clone();
      return (object) whiskerCategoryDataset;
    }
  }
}
