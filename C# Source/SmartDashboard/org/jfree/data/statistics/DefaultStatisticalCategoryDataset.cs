// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.DefaultStatisticalCategoryDataset
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
  [Implements(new string[] {"org.jfree.data.statistics.StatisticalCategoryDataset", "org.jfree.data.RangeInfo", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class DefaultStatisticalCategoryDataset : AbstractDataset, StatisticalCategoryDataset, CategoryDataset, KeyedValues2D, Values2D, Dataset, RangeInfo, PublicCloneable, Cloneable.__Interface
  {
    private KeyedObjects2D data;
    private double minimumRangeValue;
    private int minimumRangeValueRow;
    private int minimumRangeValueColumn;
    private double minimumRangeValueIncStdDev;
    private int minimumRangeValueIncStdDevRow;
    private int minimumRangeValueIncStdDevColumn;
    private double maximumRangeValue;
    private int maximumRangeValueRow;
    private int maximumRangeValueColumn;
    private double maximumRangeValueIncStdDev;
    private int maximumRangeValueIncStdDevRow;
    private int maximumRangeValueIncStdDevColumn;

    [LineNumberTable(new byte[] {(byte) 78, (byte) 104, (byte) 107, (byte) 112, (byte) 103, (byte) 103, (byte) 112, (byte) 103, (byte) 103, (byte) 112, (byte) 103, (byte) 103, (byte) 112, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultStatisticalCategoryDataset()
    {
      DefaultStatisticalCategoryDataset statisticalCategoryDataset = this;
      this.data = new KeyedObjects2D();
      this.minimumRangeValue = double.NaN;
      this.minimumRangeValueRow = -1;
      this.minimumRangeValueColumn = -1;
      this.maximumRangeValue = double.NaN;
      this.maximumRangeValueRow = -1;
      this.maximumRangeValueColumn = -1;
      this.minimumRangeValueIncStdDev = double.NaN;
      this.minimumRangeValueIncStdDevRow = -1;
      this.minimumRangeValueIncStdDevColumn = -1;
      this.maximumRangeValueIncStdDev = double.NaN;
      this.maximumRangeValueIncStdDevRow = -1;
      this.maximumRangeValueIncStdDevColumn = -1;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultStatisticalCategoryDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultStatisticalCategoryDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable(new byte[] {(byte) 103, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMeanValue(int row, int column)
    {
      Number number = (Number) null;
      MeanAndStandardDeviation standardDeviation = (MeanAndStandardDeviation) this.data.getObject(row, column);
      if (standardDeviation != null)
        number = standardDeviation.getMean();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 83, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMeanValue(IComparable rowKey, IComparable columnKey)
    {
      Number number = (Number) null;
      MeanAndStandardDeviation standardDeviation = (MeanAndStandardDeviation) this.data.getObject(rowKey, columnKey);
      if (standardDeviation != null)
        number = standardDeviation.getMean();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 237, (byte) 136, (byte) 143, (byte) 106, (byte) 106, (byte) 99, (byte) 136, (byte) 99, (byte) 200, (byte) 110, (byte) 110, (byte) 255, (byte) 45, (byte) 74, (byte) 171, (byte) 104, (byte) 150, (byte) 104, (byte) 103, (byte) 200, (byte) 106, (byte) 152, (byte) 106, (byte) 103, (byte) 200, (byte) 104, (byte) 150, (byte) 104, (byte) 103, (byte) 200, (byte) 106, (byte) 152, (byte) 106, (byte) 103, (byte) 200, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(Number mean, Number standardDeviation, IComparable rowKey, IComparable columnKey)
    {
      this.data.addObject((object) new MeanAndStandardDeviation(mean, standardDeviation), rowKey, columnKey);
      double num1 = double.NaN;
      double num2 = double.NaN;
      if (mean != null)
        num1 = mean.doubleValue();
      if (standardDeviation != null)
        num2 = standardDeviation.doubleValue();
      int columnIndex = this.data.getColumnIndex(columnKey);
      int rowIndex = this.data.getRowIndex(rowKey);
      if (columnIndex == this.maximumRangeValueRow && rowIndex == this.maximumRangeValueColumn || columnIndex == this.maximumRangeValueIncStdDevRow && rowIndex == this.maximumRangeValueIncStdDevColumn || (columnIndex == this.minimumRangeValueRow && rowIndex == this.minimumRangeValueColumn || columnIndex == this.minimumRangeValueIncStdDevRow && rowIndex == this.minimumRangeValueIncStdDevColumn))
      {
        this.updateBounds();
      }
      else
      {
        if (!Double.isNaN(num1) && (Double.isNaN(this.maximumRangeValue) || num1 > this.maximumRangeValue))
        {
          this.maximumRangeValue = num1;
          this.maximumRangeValueRow = columnIndex;
          this.maximumRangeValueColumn = rowIndex;
        }
        if (!Double.isNaN(num1 + num2) && (Double.isNaN(this.maximumRangeValueIncStdDev) || num1 + num2 > this.maximumRangeValueIncStdDev))
        {
          this.maximumRangeValueIncStdDev = num1 + num2;
          this.maximumRangeValueIncStdDevRow = columnIndex;
          this.maximumRangeValueIncStdDevColumn = rowIndex;
        }
        if (!Double.isNaN(num1) && (Double.isNaN(this.minimumRangeValue) || num1 < this.minimumRangeValue))
        {
          this.minimumRangeValue = num1;
          this.minimumRangeValueRow = columnIndex;
          this.minimumRangeValueColumn = rowIndex;
        }
        if (!Double.isNaN(num1 - num2) && (Double.isNaN(this.minimumRangeValueIncStdDev) || num1 - num2 < this.minimumRangeValueIncStdDev))
        {
          this.minimumRangeValueIncStdDev = num1 - num2;
          this.minimumRangeValueIncStdDevRow = columnIndex;
          this.minimumRangeValueIncStdDevColumn = rowIndex;
        }
      }
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 165, (byte) 112, (byte) 103, (byte) 103, (byte) 112, (byte) 103, (byte) 103, (byte) 112, (byte) 103, (byte) 103, (byte) 112, (byte) 103, (byte) 135, (byte) 108, (byte) 108, (byte) 105, (byte) 105, (byte) 106, (byte) 106, (byte) 148, (byte) 100, (byte) 133, (byte) 106, (byte) 138, (byte) 172, (byte) 109, (byte) 105, (byte) 103, (byte) 169, (byte) 106, (byte) 105, (byte) 103, (byte) 231, (byte) 69, (byte) 109, (byte) 105, (byte) 103, (byte) 169, (byte) 106, (byte) 105, (byte) 103, (byte) 199, (byte) 140, (byte) 109, (byte) 108, (byte) 103, (byte) 169, (byte) 109, (byte) 108, (byte) 103, (byte) 231, (byte) 69, (byte) 109, (byte) 108, (byte) 103, (byte) 169, (byte) 109, (byte) 108, (byte) 103, (byte) 231, (byte) 159, (byte) 190, (byte) 41, (byte) 233, (byte) 160, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void updateBounds()
    {
      this.maximumRangeValue = double.NaN;
      this.maximumRangeValueRow = -1;
      this.maximumRangeValueColumn = -1;
      this.minimumRangeValue = double.NaN;
      this.minimumRangeValueRow = -1;
      this.minimumRangeValueColumn = -1;
      this.maximumRangeValueIncStdDev = double.NaN;
      this.maximumRangeValueIncStdDevRow = -1;
      this.maximumRangeValueIncStdDevColumn = -1;
      this.minimumRangeValueIncStdDev = double.NaN;
      this.minimumRangeValueIncStdDevRow = -1;
      this.minimumRangeValueIncStdDevColumn = -1;
      int rowCount = this.data.getRowCount();
      int columnCount = this.data.getColumnCount();
      for (int row = 0; row < rowCount; ++row)
      {
        for (int column = 0; column < columnCount; ++column)
        {
          MeanAndStandardDeviation standardDeviation = (MeanAndStandardDeviation) this.data.getObject(row, column);
          if (standardDeviation != null)
          {
            double meanValue = standardDeviation.getMeanValue();
            double standardDeviationValue = standardDeviation.getStandardDeviationValue();
            if (!Double.isNaN(meanValue))
            {
              if (Double.isNaN(this.maximumRangeValue))
              {
                this.maximumRangeValue = meanValue;
                this.maximumRangeValueRow = row;
                this.maximumRangeValueColumn = column;
              }
              else if (meanValue > this.maximumRangeValue)
              {
                this.maximumRangeValue = meanValue;
                this.maximumRangeValueRow = row;
                this.maximumRangeValueColumn = column;
              }
              if (Double.isNaN(this.minimumRangeValue))
              {
                this.minimumRangeValue = meanValue;
                this.minimumRangeValueRow = row;
                this.minimumRangeValueColumn = column;
              }
              else if (meanValue < this.minimumRangeValue)
              {
                this.minimumRangeValue = meanValue;
                this.minimumRangeValueRow = row;
                this.minimumRangeValueColumn = column;
              }
              if (!Double.isNaN(standardDeviationValue))
              {
                if (Double.isNaN(this.maximumRangeValueIncStdDev))
                {
                  this.maximumRangeValueIncStdDev = meanValue + standardDeviationValue;
                  this.maximumRangeValueIncStdDevRow = row;
                  this.maximumRangeValueIncStdDevColumn = column;
                }
                else if (meanValue + standardDeviationValue > this.maximumRangeValueIncStdDev)
                {
                  this.maximumRangeValueIncStdDev = meanValue + standardDeviationValue;
                  this.maximumRangeValueIncStdDevRow = row;
                  this.maximumRangeValueIncStdDevColumn = column;
                }
                if (Double.isNaN(this.minimumRangeValueIncStdDev))
                {
                  this.minimumRangeValueIncStdDev = meanValue - standardDeviationValue;
                  this.minimumRangeValueIncStdDevRow = row;
                  this.minimumRangeValueIncStdDevColumn = column;
                }
                else if (meanValue - standardDeviationValue < this.minimumRangeValueIncStdDev)
                {
                  this.minimumRangeValueIncStdDev = meanValue - standardDeviationValue;
                  this.minimumRangeValueIncStdDevRow = row;
                  this.minimumRangeValueIncStdDevColumn = column;
                }
              }
            }
          }
        }
      }
    }

    [LineNumberTable((ushort) 283)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowIndex(IComparable key)
    {
      return this.data.getRowIndex(key);
    }

    [LineNumberTable((ushort) 251)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnIndex(IComparable key)
    {
      return this.data.getColumnIndex(key);
    }

    [LineNumberTable((ushort) 172)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(int row, int column)
    {
      return this.getMeanValue(row, column);
    }

    [LineNumberTable((ushort) 185)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getValue(IComparable rowKey, IComparable columnKey)
    {
      return this.getMeanValue(rowKey, columnKey);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 101, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getStdDevValue(int row, int column)
    {
      Number number = (Number) null;
      MeanAndStandardDeviation standardDeviation = (MeanAndStandardDeviation) this.data.getObject(row, column);
      if (standardDeviation != null)
        number = standardDeviation.getStandardDeviation();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 119, (byte) 98, (byte) 147, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getStdDevValue(IComparable rowKey, IComparable columnKey)
    {
      Number number = (Number) null;
      MeanAndStandardDeviation standardDeviation = (MeanAndStandardDeviation) this.data.getObject(rowKey, columnKey);
      if (standardDeviation != null)
        number = standardDeviation.getStandardDeviation();
      return number;
    }

    [LineNumberTable((ushort) 262)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getColumnKey(int column)
    {
      return this.data.getColumnKey(column);
    }

    [LineNumberTable((ushort) 271)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getColumnKeys()
    {
      return this.data.getColumnKeys();
    }

    [LineNumberTable((ushort) 294)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IComparable getRowKey(int row)
    {
      return this.data.getRowKey(row);
    }

    [LineNumberTable((ushort) 303)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getRowKeys()
    {
      return this.data.getRowKeys();
    }

    [LineNumberTable((ushort) 314)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getRowCount()
    {
      return this.data.getRowCount();
    }

    [LineNumberTable((ushort) 325)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getColumnCount()
    {
      return this.data.getColumnCount();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 224, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(double mean, double standardDeviation, IComparable rowKey, IComparable columnKey)
    {
      this.add((Number) new Double(mean), (Number) new Double(standardDeviation), rowKey, columnKey);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 62, (byte) 104, (byte) 104, (byte) 205, (byte) 255, (byte) 41, (byte) 74, (byte) 166, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove(IComparable rowKey, IComparable columnKey)
    {
      int rowIndex = this.getRowIndex(rowKey);
      int columnIndex = this.getColumnIndex(columnKey);
      this.data.removeObject(rowKey, columnKey);
      if (rowIndex == this.maximumRangeValueRow && columnIndex == this.maximumRangeValueColumn || rowIndex == this.maximumRangeValueIncStdDevRow && columnIndex == this.maximumRangeValueIncStdDevColumn || (rowIndex == this.minimumRangeValueRow && columnIndex == this.minimumRangeValueColumn || rowIndex == this.minimumRangeValueIncStdDevRow && columnIndex == this.minimumRangeValueIncStdDevColumn))
        this.updateBounds();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 96, (byte) 108, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeRow(int rowIndex)
    {
      this.data.removeRow(rowIndex);
      this.updateBounds();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 112, (byte) 108, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeRow(IComparable rowKey)
    {
      this.data.removeRow(rowKey);
      this.updateBounds();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 128, (byte) 108, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeColumn(int columnIndex)
    {
      this.data.removeColumn(columnIndex);
      this.updateBounds();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 144, (byte) 108, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeColumn(IComparable columnKey)
    {
      this.data.removeColumn(columnKey);
      this.updateBounds();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 156, (byte) 107, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.data.clear();
      this.updateBounds();
      this.fireDatasetChanged();
    }

    public virtual double getRangeLowerBound(bool includeInterval)
    {
      if (includeInterval)
        return this.minimumRangeValueIncStdDev;
      else
        return this.minimumRangeValue;
    }

    public virtual double getRangeUpperBound(bool includeInterval)
    {
      if (includeInterval)
        return this.maximumRangeValueIncStdDev;
      else
        return this.maximumRangeValue;
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 230, (byte) 98, (byte) 98, (byte) 99, (byte) 154, (byte) 244, (byte) 69, (byte) 154, (byte) 210})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getRangeBounds(bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      Range range = (Range) null;
      if (num != 0)
      {
        if (!Double.isNaN(this.minimumRangeValueIncStdDev) && !Double.isNaN(this.maximumRangeValueIncStdDev))
          range = new Range(this.minimumRangeValueIncStdDev, this.maximumRangeValueIncStdDev);
      }
      else if (!Double.isNaN(this.minimumRangeValue) && !Double.isNaN(this.maximumRangeValue))
        range = new Range(this.minimumRangeValue, this.maximumRangeValue);
      return range;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 73, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 135, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      return obj == this || obj is DefaultStatisticalCategoryDataset && this.data.equals((object) ((DefaultStatisticalCategoryDataset) obj).data);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 95, (byte) 140, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      DefaultStatisticalCategoryDataset statisticalCategoryDataset = (DefaultStatisticalCategoryDataset) base.clone();
      statisticalCategoryDataset.data = (KeyedObjects2D) this.data.clone();
      return (object) statisticalCategoryDataset;
    }
  }
}
