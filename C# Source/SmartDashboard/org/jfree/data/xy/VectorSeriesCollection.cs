// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.VectorSeriesCollection
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
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
  [Implements(new string[] {"org.jfree.data.xy.VectorXYDataset", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class VectorSeriesCollection : AbstractXYDataset, VectorXYDataset, XYDataset, SeriesDataset, Dataset, PublicCloneable, Cloneable.__Interface, Serializable.__Interface
  {
    private List data;

    [LineNumberTable(new byte[] {(byte) 18, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public VectorSeriesCollection()
    {
      VectorSeriesCollection seriesCollection = this;
      this.data = (List) new ArrayList();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected VectorSeriesCollection([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] VectorSeriesCollection obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] VectorSeriesCollection obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 133)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.data.size();
    }

    [LineNumberTable(new byte[] {(byte) 97, (byte) 109, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual VectorSeries getSeries(int series)
    {
      if (series >= 0 && series < this.getSeriesCount())
        return (VectorSeries) this.data.get(series);
      string str = "Series index out of bounds";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 94, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getXValue(int series, int item)
    {
      return ((VectorDataItem) ((VectorSeries) this.data.get(series)).getDataItem(item)).getXValue();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 122, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double getYValue(int series, int item)
    {
      return ((VectorDataItem) ((VectorSeries) this.data.get(series)).getDataItem(item)).getYValue();
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 99, (byte) 144, (byte) 109, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSeries(VectorSeries series)
    {
      if (series == null)
      {
        string str = "Null 'series' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.data.add((object) series);
        series.addChangeListener((SeriesChangeListener) this);
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 99, (byte) 144, (byte) 109, (byte) 99, (byte) 103, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool removeSeries(VectorSeries series)
    {
      if (series == null)
      {
        string str = "Null 'series' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int num = this.data.remove((object) series) ? 1 : 0;
        if (num != 0)
        {
          series.removeChangeListener((SeriesChangeListener) this);
          this.fireDatasetChanged();
        }
        return num != 0;
      }
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 112, (byte) 114, (byte) 7, (byte) 230, (byte) 70, (byte) 107, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeAllSeries()
    {
      for (int index = 0; index < this.data.size(); ++index)
        ((Series) this.data.get(index)).removeChangeListener((SeriesChangeListener) this);
      this.data.clear();
      this.fireDatasetChanged();
    }

    [LineNumberTable((ushort) 166)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      return this.getSeries(series).getKey();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 64, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int indexOf(VectorSeries series)
    {
      if (series == null)
      {
        string str = "Null 'series' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return this.data.indexOf((object) series);
    }

    [LineNumberTable((ushort) 196)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      return this.getSeries(series).getItemCount();
    }

    [LineNumberTable((ushort) 224)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getXValue(series, item));
    }

    [LineNumberTable((ushort) 252)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(this.getYValue(series, item));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 150, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Vector getVector(int series, int item)
    {
      return ((VectorDataItem) ((VectorSeries) this.data.get(series)).getDataItem(item)).getVector();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 164, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getVectorXValue(int series, int item)
    {
      return ((VectorDataItem) ((VectorSeries) this.data.get(series)).getDataItem(item)).getVectorX();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 178, (byte) 114, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getVectorYValue(int series, int item)
    {
      return ((VectorDataItem) ((VectorSeries) this.data.get(series)).getDataItem(item)).getVectorY();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 191, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is VectorSeriesCollection))
        return false;
      return (ObjectUtilities.equal((object) this.data, (object) ((VectorSeriesCollection) obj).data) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 209, (byte) 140, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      VectorSeriesCollection seriesCollection = (VectorSeriesCollection) base.clone();
      seriesCollection.data = (List) ObjectUtilities.deepClone((Collection) this.data);
      return (object) seriesCollection;
    }
  }
}
