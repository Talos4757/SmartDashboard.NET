// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.SimpleHistogramDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
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
  [Implements(new string[] {"org.jfree.data.xy.IntervalXYDataset", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class SimpleHistogramDataset : AbstractIntervalXYDataset, IntervalXYDataset, XYDataset, SeriesDataset, Dataset, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 7997996479768018443L;
    private IComparable key;
    private List bins;
    private bool adjustForBinSize;

    [LineNumberTable(new byte[] {(byte) 38, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 107, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimpleHistogramDataset(IComparable key)
    {
      SimpleHistogramDataset histogramDataset = this;
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.key = key;
        this.bins = (List) new ArrayList();
        this.adjustForBinSize = true;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SimpleHistogramDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] SimpleHistogramDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] SimpleHistogramDataset obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 91, (byte) 162, (byte) 98, (byte) 108, (byte) 107, (byte) 108, (byte) 106, (byte) 110, (byte) 130, (byte) 98, (byte) 99, (byte) 144, (byte) 99, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addObservation(double value, bool notify)
    {
      int num1 = notify ? 1 : 0;
      int num2 = 0;
      Iterator iterator = this.bins.iterator();
      while (iterator.hasNext() && num2 == 0)
      {
        SimpleHistogramBin simpleHistogramBin = (SimpleHistogramBin) iterator.next();
        if (simpleHistogramBin.accepts(value))
        {
          simpleHistogramBin.setItemCount(simpleHistogramBin.getItemCount() + 1);
          num2 = 1;
        }
      }
      if (num2 == 0)
      {
        string str = "No bin.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
      else
      {
        if (num1 == 0)
          return;
        this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 179, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getXValue(int series, int item)
    {
      SimpleHistogramBin simpleHistogramBin = (SimpleHistogramBin) this.bins.get(item);
      return (simpleHistogramBin.getLowerBound() + simpleHistogramBin.getUpperBound()) / 2.0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 206, (byte) 114, (byte) 104, (byte) 214})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getYValue(int series, int item)
    {
      SimpleHistogramBin simpleHistogramBin = (SimpleHistogramBin) this.bins.get(item);
      if (this.adjustForBinSize)
        return (double) simpleHistogramBin.getItemCount() / (simpleHistogramBin.getUpperBound() - simpleHistogramBin.getLowerBound());
      else
        return (double) simpleHistogramBin.getItemCount();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 238, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getStartXValue(int series, int item)
    {
      return ((SimpleHistogramBin) this.bins.get(item)).getLowerBound();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 8, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getEndXValue(int series, int item)
    {
      return ((SimpleHistogramBin) this.bins.get(item)).getUpperBound();
    }

    [LineNumberTable((ushort) 306)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getYValue(series, item));
    }

    public virtual bool getAdjustForBinSize()
    {
      return this.adjustForBinSize;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 113, (byte) 162, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAdjustForBinSize(bool adjust)
    {
      this.adjustForBinSize = adjust;
      this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
    }

    public override int getSeriesCount()
    {
      return 1;
    }

    public override IComparable getSeriesKey(int series)
    {
      return this.key;
    }

    [LineNumberTable((ushort) 150)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DomainOrder getDomainOrder()
    {
      return DomainOrder.__\u003C\u003EASCENDING;
    }

    [LineNumberTable((ushort) 162)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      return this.bins.size();
    }

    [LineNumberTable(new byte[] {(byte) 125, (byte) 108, (byte) 104, (byte) 140, (byte) 105, (byte) 144, (byte) 98, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addBin(SimpleHistogramBin bin)
    {
      Iterator iterator = this.bins.iterator();
      while (iterator.hasNext())
      {
        SimpleHistogramBin bin1 = (SimpleHistogramBin) iterator.next();
        if (bin.overlapsWith(bin1))
        {
          string str = "Overlapping bin";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
      }
      this.bins.add((object) bin);
      Collections.sort(this.bins);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 81, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addObservation(double value)
    {
      this.addObservation(value, true);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 119, (byte) 103, (byte) 42, (byte) 166, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addObservations(double[] values)
    {
      for (int index = 0; index < values.Length; ++index)
        this.addObservation(values[index], false);
      this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 135, (byte) 108, (byte) 104, (byte) 108, (byte) 103, (byte) 98, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearObservations()
    {
      Iterator iterator = this.bins.iterator();
      while (iterator.hasNext())
        ((SimpleHistogramBin) iterator.next()).setItemCount(0);
      this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 152, (byte) 107, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeAllBins()
    {
      this.bins = (List) new ArrayList();
      this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
    }

    [LineNumberTable((ushort) 281)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getXValue(series, item));
    }

    [LineNumberTable((ushort) 339)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartX(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getStartXValue(series, item));
    }

    [LineNumberTable((ushort) 365)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndX(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getEndXValue(series, item));
    }

    [LineNumberTable((ushort) 391)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable((ushort) 404)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getStartYValue(int series, int item)
    {
      return this.getYValue(series, item);
    }

    [LineNumberTable((ushort) 416)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable((ushort) 429)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getEndYValue(int series, int item)
    {
      return this.getYValue(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 70, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is SimpleHistogramDataset))
        return false;
      SimpleHistogramDataset histogramDataset = (SimpleHistogramDataset) obj;
      return Object.instancehelper_equals((object) this.key, (object) histogramDataset.key) && this.adjustForBinSize == histogramDataset.adjustForBinSize && Object.instancehelper_equals((object) this.bins, (object) histogramDataset.bins);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 98, (byte) 108, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      SimpleHistogramDataset histogramDataset = (SimpleHistogramDataset) base.clone();
      histogramDataset.bins = (List) ObjectUtilities.deepClone((Collection) this.bins);
      return (object) histogramDataset;
    }
  }
}
