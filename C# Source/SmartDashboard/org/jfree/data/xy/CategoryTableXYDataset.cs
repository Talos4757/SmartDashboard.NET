// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.CategoryTableXYDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"org.jfree.data.xy.TableXYDataset", "org.jfree.data.xy.IntervalXYDataset", "org.jfree.data.DomainInfo", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class CategoryTableXYDataset : AbstractIntervalXYDataset, TableXYDataset, XYDataset, SeriesDataset, Dataset, IntervalXYDataset, DomainInfo, PublicCloneable, Cloneable.__Interface
  {
    private DefaultKeyedValues2D values;
    private IntervalXYDelegate intervalDelegate;

    [LineNumberTable(new byte[] {(byte) 36, (byte) 104, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryTableXYDataset()
    {
      CategoryTableXYDataset categoryTableXyDataset = this;
      this.values = new DefaultKeyedValues2D(true);
      this.intervalDelegate = new IntervalXYDelegate((XYDataset) this);
      this.addChangeListener((DatasetChangeListener) this.intervalDelegate);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CategoryTableXYDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CategoryTableXYDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 114, (byte) 131, (byte) 115, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(Number x, Number y, string seriesName, bool notify)
    {
      int num = notify ? 1 : 0;
      this.values.addValue(y, (IComparable) x, (IComparable) seriesName);
      if (num == 0)
        return;
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 108, (byte) 130, (byte) 114, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove(Number x, string seriesName, bool notify)
    {
      int num = notify ? 1 : 0;
      this.values.removeValue((IComparable) x, (IComparable) seriesName);
      if (num == 0)
        return;
      this.fireDatasetChanged();
    }

    [LineNumberTable((ushort) 171)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getItemCount()
    {
      return this.values.getRowCount();
    }

    [LineNumberTable((ushort) 232)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      return this.values.getValue(item, series);
    }

    [LineNumberTable((ushort) 328)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getIntervalWidth()
    {
      return this.intervalDelegate.getIntervalWidth();
    }

    [LineNumberTable((ushort) 348)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isAutoWidth()
    {
      return (this.intervalDelegate.isAutoWidth() ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 306)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getIntervalPositionFactor()
    {
      return this.intervalDelegate.getIntervalPositionFactor();
    }

    [LineNumberTable(new byte[] {(byte) 51, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(double x, double y, string seriesName)
    {
      this.add((Number) new Double(x), (Number) new Double(y), seriesName, true);
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove(double x, string seriesName)
    {
      this.remove((Number) new Double(x), seriesName, true);
    }

    [LineNumberTable((ushort) 151)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.values.getColumnCount();
    }

    [LineNumberTable((ushort) 162)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      return this.values.getColumnKey(series);
    }

    [LineNumberTable((ushort) 183)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      return this.getItemCount();
    }

    [LineNumberTable((ushort) 196)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      return (Number) this.values.getRowKey(item);
    }

    [LineNumberTable((ushort) 208)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartX(int series, int item)
    {
      return this.intervalDelegate.getStartX(series, item);
    }

    [LineNumberTable((ushort) 220)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndX(int series, int item)
    {
      return this.intervalDelegate.getEndX(series, item);
    }

    [LineNumberTable((ushort) 244)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable((ushort) 256)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable((ushort) 268)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getDomainLowerBound(bool includeInterval)
    {
      return this.intervalDelegate.getDomainLowerBound(includeInterval);
    }

    [LineNumberTable((ushort) 280)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getDomainUpperBound(bool includeInterval)
    {
      return this.intervalDelegate.getDomainUpperBound(includeInterval);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 69, (byte) 66, (byte) 99, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getDomainBounds(bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      if (num != 0)
        return this.intervalDelegate.getDomainBounds(num != 0);
      else
        return DatasetUtilities.iterateDomainBounds((XYDataset) this, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 204, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setIntervalPositionFactor(double d)
    {
      this.intervalDelegate.setIntervalPositionFactor(d);
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 224, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setIntervalWidth(double d)
    {
      this.intervalDelegate.setFixedIntervalWidth(d);
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 53, (byte) 130, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoWidth(bool b)
    {
      this.intervalDelegate.setAutoWidth(b);
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 0, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (!(obj is CategoryTableXYDataset))
        return false;
      CategoryTableXYDataset categoryTableXyDataset = (CategoryTableXYDataset) obj;
      return this.intervalDelegate.equals((object) categoryTableXyDataset.intervalDelegate) && this.values.equals((object) categoryTableXyDataset.values);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 22, (byte) 108, (byte) 118, (byte) 140, (byte) 113, (byte) 113, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      CategoryTableXYDataset categoryTableXyDataset = (CategoryTableXYDataset) base.clone();
      categoryTableXyDataset.values = (DefaultKeyedValues2D) this.values.clone();
      categoryTableXyDataset.intervalDelegate = new IntervalXYDelegate((XYDataset) categoryTableXyDataset);
      categoryTableXyDataset.intervalDelegate.setFixedIntervalWidth(this.getIntervalWidth());
      categoryTableXyDataset.intervalDelegate.setAutoWidth(this.isAutoWidth());
      categoryTableXyDataset.intervalDelegate.setIntervalPositionFactor(this.getIntervalPositionFactor());
      return (object) categoryTableXyDataset;
    }
  }
}
