// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.DefaultTableXYDataset
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

namespace org.jfree.data.xy
{
  [Implements(new string[] {"org.jfree.data.xy.TableXYDataset", "org.jfree.data.xy.IntervalXYDataset", "org.jfree.data.DomainInfo", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class DefaultTableXYDataset : AbstractIntervalXYDataset, TableXYDataset, XYDataset, SeriesDataset, Dataset, IntervalXYDataset, DomainInfo, PublicCloneable, Cloneable.__Interface
  {
    private List data;
    private HashSet xPoints;
    private bool propagateEvents;
    private bool autoPrune;
    private IntervalXYDelegate intervalDelegate;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 113, (byte) 98, (byte) 232, (byte) 36, (byte) 167, (byte) 167, (byte) 167, (byte) 231, (byte) 84, (byte) 103, (byte) 107, (byte) 107, (byte) 109, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultTableXYDataset(bool autoPrune)
    {
      int num = autoPrune ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      DefaultTableXYDataset defaultTableXyDataset = this;
      this.data = (List) null;
      this.xPoints = (HashSet) null;
      this.propagateEvents = true;
      this.autoPrune = false;
      this.autoPrune = num != 0;
      this.data = (List) new ArrayList();
      this.xPoints = new HashSet();
      this.intervalDelegate = new IntervalXYDelegate((XYDataset) this, false);
      this.addChangeListener((DatasetChangeListener) this.intervalDelegate);
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultTableXYDataset()
      : this(false)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultTableXYDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] DefaultTableXYDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable(new byte[] {(byte) 115, (byte) 99, (byte) 144, (byte) 102, (byte) 103, (byte) 103, (byte) 110, (byte) 104, (byte) 104, (byte) 110, (byte) 109, (byte) 109, (byte) 105, (byte) 116, (byte) 106, (byte) 233, (byte) 61, (byte) 232, (byte) 58, (byte) 233, (byte) 78, (byte) 109, (byte) 105, (byte) 109, (byte) 105, (byte) 136, (byte) 98, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void updateXPoints([In] XYSeries obj0)
    {
      if (obj0 == null)
      {
        string str = "Null 'series' not permitted.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        HashSet hashSet = new HashSet();
        int num1 = this.propagateEvents ? 1 : 0;
        this.propagateEvents = false;
        for (int index1 = 0; index1 < obj0.getItemCount(); ++index1)
        {
          Number x = obj0.getX(index1);
          hashSet.add((object) x);
          if (!this.xPoints.contains((object) x))
          {
            this.xPoints.add((object) x);
            int num2 = this.data.size();
            for (int index2 = 0; index2 < num2; ++index2)
            {
              XYSeries xySeries = (XYSeries) this.data.get(index2);
              if (!xySeries.equals((object) obj0))
                xySeries.add(x, (Number) null);
            }
          }
        }
        Iterator iterator = this.xPoints.iterator();
        while (iterator.hasNext())
        {
          Number x = (Number) iterator.next();
          if (!hashSet.contains((object) x))
            obj0.add(x, (Number) null);
        }
        this.propagateEvents = num1 != 0;
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 90, (byte) 113, (byte) 103, (byte) 104, (byte) 108, (byte) 105, (byte) 135, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void prune()
    {
      Iterator iterator = ((HashSet) this.xPoints.clone()).iterator();
      while (iterator.hasNext())
      {
        Number x = (Number) iterator.next();
        if (this.canPrune(x))
          this.removeAllValuesForX(x);
      }
    }

    [LineNumberTable((ushort) 215)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.data.size();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 109, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYSeries getSeries(int series)
    {
      if (series >= 0 && series < this.getSeriesCount())
        return (XYSeries) this.data.get(series);
      string str = "Index outside valid range.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 204, (byte) 114, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int index)
    {
      return ((XYSeries) this.data.get(series)).getDataItem(index).getY();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 77, (byte) 112, (byte) 114, (byte) 111, (byte) 226, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual bool canPrune(Number x)
    {
      for (int index = 0; index < this.data.size(); ++index)
      {
        XYSeries xySeries = (XYSeries) this.data.get(index);
        if (xySeries.getY(xySeries.indexOf(x)) != null)
          return false;
      }
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 54, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 112, (byte) 114, (byte) 8, (byte) 198, (byte) 103, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeAllValuesForX(Number x)
    {
      if (x == null)
      {
        string str = "Null 'x' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int num = this.propagateEvents ? 1 : 0;
        this.propagateEvents = false;
        for (int index = 0; index < this.data.size(); ++index)
          ((XYSeries) this.data.get(index)).remove(x);
        this.propagateEvents = num != 0;
        this.xPoints.remove((object) x);
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 85, (byte) 103, (byte) 112, (byte) 55, (byte) 166, (byte) 104, (byte) 134, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void updateXPoints()
    {
      this.propagateEvents = false;
      for (int index = 0; index < this.data.size(); ++index)
        this.updateXPoints((XYSeries) this.data.get(index));
      if (this.autoPrune)
        this.prune();
      this.propagateEvents = true;
    }

    [LineNumberTable((ushort) 625)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getIntervalWidth()
    {
      return this.intervalDelegate.getIntervalWidth();
    }

    [LineNumberTable((ushort) 646)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isAutoWidth()
    {
      return (this.intervalDelegate.isAutoWidth() ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 603)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getIntervalPositionFactor()
    {
      return this.intervalDelegate.getIntervalPositionFactor();
    }

    public virtual bool isAutoPrune()
    {
      return this.autoPrune;
    }

    [LineNumberTable(new byte[] {(byte) 93, (byte) 99, (byte) 144, (byte) 104, (byte) 240, (byte) 69, (byte) 103, (byte) 109, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSeries(XYSeries series)
    {
      if (series == null)
      {
        string str = "Null 'series' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (series.getAllowDuplicateXValues())
      {
        string str = "Cannot accept XYSeries that allow duplicate values. Use XYSeries(seriesName, <sort>, false) constructor.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.updateXPoints(series);
        this.data.add((object) series);
        series.addChangeListener((SeriesChangeListener) this);
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 110, (byte) 104, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getItemCount()
    {
      if (this.xPoints == null)
        return 0;
      return this.xPoints.size();
    }

    [LineNumberTable((ushort) 255)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      return this.getSeries(series).getKey();
    }

    [LineNumberTable((ushort) 267)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      return this.getSeries(series).getItemCount();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 165, (byte) 114, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      return ((XYSeries) this.data.get(series)).getDataItem(item).getX();
    }

    [LineNumberTable((ushort) 293)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartX(int series, int item)
    {
      return this.intervalDelegate.getStartX(series, item);
    }

    [LineNumberTable((ushort) 305)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndX(int series, int item)
    {
      return this.intervalDelegate.getEndX(series, item);
    }

    [LineNumberTable((ushort) 332)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable((ushort) 344)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 241, (byte) 112, (byte) 114, (byte) 7, (byte) 230, (byte) 70, (byte) 107, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeAllSeries()
    {
      for (int index = 0; index < this.data.size(); ++index)
        ((Series) this.data.get(index)).removeChangeListener((SeriesChangeListener) this);
      this.data.clear();
      this.xPoints.clear();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 5, (byte) 99, (byte) 208, (byte) 110, (byte) 103, (byte) 109, (byte) 109, (byte) 139, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeSeries(XYSeries series)
    {
      if (series == null)
      {
        string str = "Null 'series' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (!this.data.contains((object) series))
          return;
        series.removeChangeListener((SeriesChangeListener) this);
        this.data.remove((object) series);
        if (this.data.size() == 0)
          this.xPoints.clear();
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 30, (byte) 109, (byte) 208, (byte) 114, (byte) 103, (byte) 109, (byte) 109, (byte) 141, (byte) 104, (byte) 134, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeSeries(int series)
    {
      if (series < 0 || series > this.getSeriesCount())
      {
        string str = "Index outside valid range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        ((Series) this.data.get(series)).removeChangeListener((SeriesChangeListener) this);
        this.data.remove(series);
        if (this.data.size() == 0)
          this.xPoints.clear();
        else if (this.autoPrune)
          this.prune();
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 108, (byte) 104, (byte) 102, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void seriesChanged(SeriesChangeEvent @event)
    {
      if (!this.propagateEvents)
        return;
      this.updateXPoints();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 122, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is DefaultTableXYDataset))
        return false;
      DefaultTableXYDataset defaultTableXyDataset = (DefaultTableXYDataset) obj;
      return this.autoPrune == defaultTableXyDataset.autoPrune && this.propagateEvents == defaultTableXyDataset.propagateEvents && (this.intervalDelegate.equals((object) defaultTableXyDataset.intervalDelegate) && ObjectUtilities.equal((object) this.data, (object) defaultTableXyDataset.data));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 151, (byte) 119, (byte) 156, (byte) 114, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 29 * (29 * (29 * (this.data == null ? 0 : Object.instancehelper_hashCode((object) this.data)) + (this.xPoints == null ? 0 : ((AbstractSet) this.xPoints).hashCode())) + (!this.propagateEvents ? 0 : 1)) + (!this.autoPrune ? 0 : 1);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 168, (byte) 108, (byte) 108, (byte) 108, (byte) 102, (byte) 114, (byte) 18, (byte) 230, (byte) 69, (byte) 140, (byte) 113, (byte) 113, (byte) 145, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      DefaultTableXYDataset defaultTableXyDataset = (DefaultTableXYDataset) base.clone();
      int num = this.data.size();
      defaultTableXyDataset.data = (List) new ArrayList(num);
      for (int index = 0; index < num; ++index)
      {
        XYSeries xySeries = (XYSeries) this.data.get(index);
        defaultTableXyDataset.data.add(xySeries.clone());
      }
      defaultTableXyDataset.intervalDelegate = new IntervalXYDelegate((XYDataset) defaultTableXyDataset);
      defaultTableXyDataset.intervalDelegate.setFixedIntervalWidth(this.getIntervalWidth());
      defaultTableXyDataset.intervalDelegate.setAutoWidth(this.isAutoWidth());
      defaultTableXyDataset.intervalDelegate.setIntervalPositionFactor(this.getIntervalPositionFactor());
      defaultTableXyDataset.updateXPoints();
      return (object) defaultTableXyDataset;
    }

    [LineNumberTable((ushort) 565)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getDomainLowerBound(bool includeInterval)
    {
      return this.intervalDelegate.getDomainLowerBound(includeInterval);
    }

    [LineNumberTable((ushort) 577)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getDomainUpperBound(bool includeInterval)
    {
      return this.intervalDelegate.getDomainUpperBound(includeInterval);
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 251, (byte) 98, (byte) 99, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getDomainBounds(bool includeInterval)
    {
      int num = includeInterval ? 1 : 0;
      if (num != 0)
        return this.intervalDelegate.getDomainBounds(num != 0);
      else
        return DatasetUtilities.iterateDomainBounds((XYDataset) this, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 245, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setIntervalPositionFactor(double d)
    {
      this.intervalDelegate.setIntervalPositionFactor(d);
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 9, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setIntervalWidth(double d)
    {
      this.intervalDelegate.setFixedIntervalWidth(d);
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 158, (byte) 234, (byte) 66, (byte) 108, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoWidth(bool b)
    {
      this.intervalDelegate.setAutoWidth(b);
      this.fireDatasetChanged();
    }
  }
}
