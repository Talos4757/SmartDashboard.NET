// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.IntervalXYDelegate
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"org.jfree.data.general.DatasetChangeListener", "org.jfree.data.DomainInfo", "java.io.Serializable", "java.lang.Cloneable", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class IntervalXYDelegate : Object, DatasetChangeListener, EventListener, DomainInfo, Serializable.__Interface, Cloneable.__Interface, PublicCloneable, ISerializable
  {
    private const long serialVersionUID = -685166711639592857L;
    private XYDataset dataset;
    private bool autoWidth;
    private double intervalPositionFactor;
    private double fixedIntervalWidth;
    private double autoIntervalWidth;

    [LineNumberTable(new byte[] {(byte) 71, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntervalXYDelegate(XYDataset dataset)
      : this(dataset, true)
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 110, (byte) 162, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 112, (byte) 112, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntervalXYDelegate(XYDataset dataset, bool autoWidth)
    {
      int num = autoWidth ? 1 : 0;
      base.\u002Ector();
      IntervalXYDelegate intervalXyDelegate = this;
      if (dataset == null)
      {
        string str = "Null 'dataset' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.dataset = dataset;
        this.autoWidth = num != 0;
        this.intervalPositionFactor = 0.5;
        this.autoIntervalWidth = double.PositiveInfinity;
        this.fixedIntervalWidth = 1.0;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected IntervalXYDelegate([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] IntervalXYDelegate obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] IntervalXYDelegate obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 147, (byte) 98, (byte) 110, (byte) 99, (byte) 191, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getStartX(int series, int item)
    {
      Double @double = (Double) null;
      Number x = this.dataset.getX(series, item);
      if (x != null)
      {
        Double.__\u003Cclinit\u003E();
        @double = new Double(x.doubleValue() - this.getIntervalPositionFactor() * this.getIntervalWidth());
      }
      return (Number) @double;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 182, (byte) 98, (byte) 110, (byte) 99, (byte) 191, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Number getEndX(int series, int item)
    {
      Double @double = (Double) null;
      Number x = this.dataset.getX(series, item);
      if (x != null)
      {
        Double.__\u003Cclinit\u003E();
        @double = new Double(x.doubleValue() + (1.0 - this.getIntervalPositionFactor()) * this.getIntervalWidth());
      }
      return (Number) @double;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 60, (byte) 98, (byte) 106, (byte) 104, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getDomainLowerBound(bool includeInterval)
    {
      int num1 = includeInterval ? 1 : 0;
      double num2 = double.NaN;
      Range domainBounds = this.getDomainBounds(num1 != 0);
      if (domainBounds != null)
        num2 = domainBounds.getLowerBound();
      return num2;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 56, (byte) 130, (byte) 106, (byte) 104, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getDomainUpperBound(bool includeInterval)
    {
      int num1 = includeInterval ? 1 : 0;
      double num2 = double.NaN;
      Range domainBounds = this.getDomainBounds(num1 != 0);
      if (domainBounds != null)
        num2 = domainBounds.getUpperBound();
      return num2;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 51, (byte) 130, (byte) 109, (byte) 102, (byte) 111, (byte) 106, (byte) 182})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Range getDomainBounds(bool includeInterval)
    {
      int num1 = includeInterval ? 1 : 0;
      Range range = DatasetUtilities.findDomainBounds(this.dataset, false);
      if (num1 != 0 && range != null)
      {
        double num2 = this.getIntervalWidth() * this.getIntervalPositionFactor();
        double num3 = this.getIntervalWidth() - num2;
        range = new Range(range.getLowerBound() - num2, range.getUpperBound() + num3);
      }
      return range;
    }

    public virtual double getIntervalPositionFactor()
    {
      return this.intervalPositionFactor;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 82, (byte) 114, (byte) 176, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setIntervalPositionFactor(double d)
    {
      if (d < 0.0 || 1.0 < d)
      {
        string str = "Argument 'd' outside valid range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.intervalPositionFactor = d;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 125, (byte) 181, (byte) 199})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getIntervalWidth()
    {
      if (this.isAutoWidth() && !Double.isInfinite(this.autoIntervalWidth))
        return this.autoIntervalWidth;
      else
        return this.fixedIntervalWidth;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 110, (byte) 105, (byte) 144, (byte) 105, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFixedIntervalWidth(double w)
    {
      if (w < 0.0)
      {
        string str = "Negative 'w' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.fixedIntervalWidth = w;
        this.autoWidth = false;
      }
    }

    public virtual bool isAutoWidth()
    {
      return this.autoWidth;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 101, (byte) 66, (byte) 103, (byte) 99, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAutoWidth(bool b)
    {
      int num = b ? 1 : 0;
      this.autoWidth = num != 0;
      if (num == 0)
        return;
      this.autoIntervalWidth = this.recalculateInterval();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 70, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is IntervalXYDelegate))
        return false;
      IntervalXYDelegate intervalXyDelegate = (IntervalXYDelegate) obj;
      return this.autoWidth == intervalXyDelegate.autoWidth && this.intervalPositionFactor == intervalXyDelegate.intervalPositionFactor && this.fixedIntervalWidth == intervalXyDelegate.fixedIntervalWidth;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 29, (byte) 106, (byte) 108, (byte) 102, (byte) 47, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double recalculateInterval()
    {
      double num = double.PositiveInfinity;
      int seriesCount = this.dataset.getSeriesCount();
      for (int index = 0; index < seriesCount; ++index)
        num = Math.min(num, this.calculateIntervalForSeries(index));
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 45, (byte) 106, (byte) 109, (byte) 100, (byte) 111, (byte) 102, (byte) 112, (byte) 108, (byte) 227, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double calculateIntervalForSeries([In] int obj0)
    {
      double num1 = double.PositiveInfinity;
      int itemCount = this.dataset.getItemCount(obj0);
      if (itemCount > 1)
      {
        double num2 = this.dataset.getXValue(obj0, 0);
        for (int i2 = 1; i2 < itemCount; ++i2)
        {
          double xvalue = this.dataset.getXValue(obj0, i2);
          num1 = Math.min(num1, xvalue - num2);
          num2 = xvalue;
        }
      }
      return num1;
    }

    public virtual double getFixedIntervalWidth()
    {
      return this.fixedIntervalWidth;
    }

    [LineNumberTable((ushort) 281)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getStartXValue(int series, int item)
    {
      return this.dataset.getXValue(series, item) - this.getIntervalPositionFactor() * this.getIntervalWidth();
    }

    [LineNumberTable((ushort) 316)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getEndXValue(int series, int item)
    {
      return this.dataset.getXValue(series, item) + (1.0 - this.getIntervalPositionFactor()) * this.getIntervalWidth();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 18, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void datasetChanged(DatasetChangeEvent e)
    {
      if (!this.autoWidth)
        return;
      this.autoIntervalWidth = this.recalculateInterval();
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 465)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 104, (byte) 98, (byte) 109, (byte) 109, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return HashUtilities.hashCode(HashUtilities.hashCode(HashUtilities.hashCode(5, this.autoWidth), this.intervalPositionFactor), this.fixedIntervalWidth);
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
