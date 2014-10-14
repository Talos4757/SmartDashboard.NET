// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.DefaultBoxAndWhiskerXYDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.data.xy;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.statistics
{
  [Implements(new string[] {"org.jfree.data.statistics.BoxAndWhiskerXYDataset", "org.jfree.data.RangeInfo"})]
  [Serializable]
  public class DefaultBoxAndWhiskerXYDataset : AbstractXYDataset, BoxAndWhiskerXYDataset, XYDataset, SeriesDataset, Dataset, RangeInfo
  {
    private IComparable seriesKey;
    private List dates;
    private List items;
    private Number minimumRangeValue;
    private Number maximumRangeValue;
    private Range rangeBounds;
    private double outlierCoefficient;
    private double faroutCoefficient;

    [LineNumberTable(new byte[] {(byte) 72, (byte) 232, (byte) 46, (byte) 240, (byte) 72, (byte) 240, (byte) 75, (byte) 103, (byte) 107, (byte) 107, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultBoxAndWhiskerXYDataset(IComparable seriesKey)
    {
      DefaultBoxAndWhiskerXYDataset whiskerXyDataset = this;
      this.outlierCoefficient = 1.5;
      this.faroutCoefficient = 2.0;
      this.seriesKey = seriesKey;
      this.dates = (List) new ArrayList();
      this.items = (List) new ArrayList();
      this.minimumRangeValue = (Number) null;
      this.maximumRangeValue = (Number) null;
      this.rangeBounds = (Range) null;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultBoxAndWhiskerXYDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    public virtual double getOutlierCoefficient()
    {
      return this.outlierCoefficient;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 211, (byte) 98, (byte) 114, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMeanValue(int series, int item)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.items.get(item);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMean();
      return number;
    }

    public virtual void setOutlierCoefficient(double outlierCoefficient)
    {
      this.outlierCoefficient = outlierCoefficient;
    }

    public virtual double getFaroutCoefficient()
    {
      return this.faroutCoefficient;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 69, (byte) 106, (byte) 171, (byte) 223, (byte) 21})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFaroutCoefficient(double faroutCoefficient)
    {
      if (faroutCoefficient > this.getOutlierCoefficient())
      {
        this.faroutCoefficient = faroutCoefficient;
      }
      else
      {
        string str = new StringBuffer().append("Farout value must be greater than the outlier value, which is currently set at: (").append(this.getOutlierCoefficient()).append(")").toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
    }

    public override int getSeriesCount()
    {
      return 1;
    }

    [LineNumberTable((ushort) 212)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      return this.dates.size();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 109, (byte) 109, (byte) 109, (byte) 104, (byte) 174, (byte) 152, (byte) 172, (byte) 104, (byte) 174, (byte) 152, (byte) 172, (byte) 159, (byte) 2, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(Date date, BoxAndWhiskerItem item)
    {
      this.dates.add((object) date);
      this.items.add((object) item);
      if (this.minimumRangeValue == null)
        this.minimumRangeValue = item.getMinRegularValue();
      else if (item.getMinRegularValue().doubleValue() < this.minimumRangeValue.doubleValue())
        this.minimumRangeValue = item.getMinRegularValue();
      if (this.maximumRangeValue == null)
        this.maximumRangeValue = item.getMaxRegularValue();
      else if (item.getMaxRegularValue().doubleValue() > this.maximumRangeValue.doubleValue())
        this.maximumRangeValue = item.getMaxRegularValue();
      this.rangeBounds = new Range(this.minimumRangeValue.doubleValue(), this.maximumRangeValue.doubleValue());
      this.fireDatasetChanged();
    }

    public override IComparable getSeriesKey(int i)
    {
      return this.seriesKey;
    }

    [LineNumberTable((ushort) 269)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual BoxAndWhiskerItem getItem(int series, int item)
    {
      return (BoxAndWhiskerItem) this.items.get(item);
    }

    [LineNumberTable((ushort) 284)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      Long.__\u003Cclinit\u003E();
      return (Number) new Long(((Date) this.dates.get(item)).getTime());
    }

    [LineNumberTable((ushort) 298)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Date getXDate(int series, int item)
    {
      return (Date) this.dates.get(item);
    }

    [LineNumberTable((ushort) 313)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      return this.getMeanValue(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 228, (byte) 98, (byte) 114, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMedianValue(int series, int item)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.items.get(item);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMedian();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 245, (byte) 98, (byte) 114, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getQ1Value(int series, int item)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.items.get(item);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getQ1();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 6, (byte) 98, (byte) 114, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getQ3Value(int series, int item)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.items.get(item);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getQ3();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 23, (byte) 98, (byte) 114, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMinRegularValue(int series, int item)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.items.get(item);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMinRegularValue();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 40, (byte) 98, (byte) 114, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMaxRegularValue(int series, int item)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.items.get(item);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMaxRegularValue();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 56, (byte) 98, (byte) 114, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMinOutlier(int series, int item)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.items.get(item);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMinOutlier();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 74, (byte) 98, (byte) 114, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getMaxOutlier(int series, int item)
    {
      Number number = (Number) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.items.get(item);
      if (boxAndWhiskerItem != null)
        number = boxAndWhiskerItem.getMaxOutlier();
      return number;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 91, (byte) 98, (byte) 114, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getOutliers(int series, int item)
    {
      List list = (List) null;
      BoxAndWhiskerItem boxAndWhiskerItem = (BoxAndWhiskerItem) this.items.get(item);
      if (boxAndWhiskerItem != null)
        list = boxAndWhiskerItem.getOutliers();
      return list;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 108, (byte) 106, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getRangeLowerBound(bool includeInterval)
    {
      double num = double.NaN;
      if (this.minimumRangeValue != null)
        num = this.minimumRangeValue.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 124, (byte) 106, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getRangeUpperBound(bool includeInterval)
    {
      double num = double.NaN;
      if (this.maximumRangeValue != null)
        num = this.maximumRangeValue.doubleValue();
      return num;
    }

    public virtual Range getRangeBounds(bool includeInterval)
    {
      return this.rangeBounds;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 151, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 135, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DefaultBoxAndWhiskerXYDataset))
        return false;
      DefaultBoxAndWhiskerXYDataset whiskerXyDataset = (DefaultBoxAndWhiskerXYDataset) obj;
      return ObjectUtilities.equal((object) this.seriesKey, (object) whiskerXyDataset.seriesKey) && Object.instancehelper_equals((object) this.dates, (object) whiskerXyDataset.dates) && Object.instancehelper_equals((object) this.items, (object) whiskerXyDataset.items);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 179, (byte) 140, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      DefaultBoxAndWhiskerXYDataset whiskerXyDataset = (DefaultBoxAndWhiskerXYDataset) base.clone();
      whiskerXyDataset.dates = (List) new ArrayList((Collection) this.dates);
      whiskerXyDataset.items = (List) new ArrayList((Collection) this.items);
      return (object) whiskerXyDataset;
    }
  }
}
