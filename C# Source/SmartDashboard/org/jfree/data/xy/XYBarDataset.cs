// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.XYBarDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"org.jfree.data.xy.IntervalXYDataset", "org.jfree.data.general.DatasetChangeListener", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class XYBarDataset : AbstractIntervalXYDataset, IntervalXYDataset, XYDataset, SeriesDataset, Dataset, DatasetChangeListener, EventListener, PublicCloneable, Cloneable.__Interface
  {
    private XYDataset underlying;
    private double barWidth;

    [LineNumberTable(new byte[] {(byte) 26, (byte) 104, (byte) 103, (byte) 108, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public XYBarDataset(XYDataset underlying, double barWidth)
    {
      XYBarDataset xyBarDataset = this;
      this.underlying = underlying;
      this.underlying.addChangeListener((DatasetChangeListener) this);
      this.barWidth = barWidth;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected XYBarDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] XYBarDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable((ushort) 176)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getXValue(int series, int item)
    {
      return this.underlying.getXValue(series, item);
    }

    [LineNumberTable((ushort) 204)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getYValue(int series, int item)
    {
      return this.underlying.getYValue(series, item);
    }

    public virtual XYDataset getUnderlyingDataset()
    {
      return this.underlying;
    }

    public virtual double getBarWidth()
    {
      return this.barWidth;
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 105, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBarWidth(double barWidth)
    {
      this.barWidth = barWidth;
      this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
    }

    [LineNumberTable((ushort) 125)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.underlying.getSeriesCount();
    }

    [LineNumberTable((ushort) 137)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      return this.underlying.getSeriesKey(series);
    }

    [LineNumberTable((ushort) 148)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      return this.underlying.getItemCount(series);
    }

    [LineNumberTable((ushort) 162)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      return this.underlying.getX(series, item);
    }

    [LineNumberTable((ushort) 190)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      return this.underlying.getY(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 102, (byte) 98, (byte) 110, (byte) 99, (byte) 159, (byte) 3})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartX(int series, int item)
    {
      Double @double = (Double) null;
      Number x = this.underlying.getX(series, item);
      if (x != null)
      {
        Double.__\u003Cclinit\u003E();
        @double = new Double(x.doubleValue() - this.barWidth / 2.0);
      }
      return (Number) @double;
    }

    [LineNumberTable((ushort) 236)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getStartXValue(int series, int item)
    {
      return this.getXValue(series, item) - this.barWidth / 2.0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 134, (byte) 98, (byte) 110, (byte) 99, (byte) 159, (byte) 3})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndX(int series, int item)
    {
      Double @double = (Double) null;
      Number x = this.underlying.getX(series, item);
      if (x != null)
      {
        Double.__\u003Cclinit\u003E();
        @double = new Double(x.doubleValue() + this.barWidth / 2.0);
      }
      return (Number) @double;
    }

    [LineNumberTable((ushort) 268)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getEndXValue(int series, int item)
    {
      return this.getXValue(series, item) + this.barWidth / 2.0;
    }

    [LineNumberTable((ushort) 280)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartY(int series, int item)
    {
      return this.underlying.getY(series, item);
    }

    [LineNumberTable((ushort) 295)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getStartYValue(int series, int item)
    {
      return this.getYValue(series, item);
    }

    [LineNumberTable((ushort) 307)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndY(int series, int item)
    {
      return this.underlying.getY(series, item);
    }

    [LineNumberTable((ushort) 322)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getEndYValue(int series, int item)
    {
      return this.getYValue(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 217, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void datasetChanged(DatasetChangeEvent @event)
    {
      this.notifyListeners(@event);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 228, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is XYBarDataset))
        return false;
      XYBarDataset xyBarDataset = (XYBarDataset) obj;
      return Object.instancehelper_equals((object) this.underlying, (object) xyBarDataset.underlying) && this.barWidth == xyBarDataset.barWidth;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 3, (byte) 108, (byte) 109, (byte) 108, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      XYBarDataset xyBarDataset = (XYBarDataset) base.clone();
      if (this.underlying is PublicCloneable)
      {
        PublicCloneable publicCloneable = (PublicCloneable) this.underlying;
        xyBarDataset.underlying = (XYDataset) publicCloneable.clone();
      }
      return (object) xyBarDataset;
    }
  }
}
