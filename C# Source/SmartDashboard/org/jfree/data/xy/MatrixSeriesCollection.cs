// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.MatrixSeriesCollection
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
  [Implements(new string[] {"org.jfree.data.xy.XYZDataset", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class MatrixSeriesCollection : AbstractXYZDataset, XYZDataset, XYDataset, SeriesDataset, Dataset, PublicCloneable, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -3197705779242543945L;
    private List seriesList;

    [LineNumberTable(new byte[] {(byte) 32, (byte) 104, (byte) 139, (byte) 99, (byte) 109, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MatrixSeriesCollection(MatrixSeries series)
    {
      MatrixSeriesCollection seriesCollection = this;
      this.seriesList = (List) new ArrayList();
      if (series == null)
        return;
      this.seriesList.add((object) series);
      series.addChangeListener((SeriesChangeListener) this);
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MatrixSeriesCollection()
      : this((MatrixSeries) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected MatrixSeriesCollection([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] MatrixSeriesCollection obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] MatrixSeriesCollection obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 63, (byte) 109, (byte) 176, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual MatrixSeries getSeries(int seriesIndex)
    {
      if (seriesIndex >= 0 && seriesIndex <= this.getSeriesCount())
        return (MatrixSeries) this.seriesList.get(seriesIndex);
      string str = "Index outside valid range.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable((ushort) 129)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.seriesList.size();
    }

    [LineNumberTable((ushort) 99)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int seriesIndex)
    {
      return this.getSeries(seriesIndex).getItemCount();
    }

    [LineNumberTable((ushort) 141)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int seriesIndex)
    {
      return this.getSeries(seriesIndex).getKey();
    }

    [LineNumberTable(new byte[] {(byte) 107, (byte) 114, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int seriesIndex, int itemIndex)
    {
      return (Number) new Integer(((MatrixSeries) this.seriesList.get(seriesIndex)).getItemColumn(itemIndex));
    }

    [LineNumberTable(new byte[] {(byte) 126, (byte) 114, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int seriesIndex, int itemIndex)
    {
      return (Number) new Integer(((MatrixSeries) this.seriesList.get(seriesIndex)).getItemRow(itemIndex));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 81, (byte) 114, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getZ(int seriesIndex, int itemIndex)
    {
      return ((MatrixSeries) this.seriesList.get(seriesIndex)).getItem(itemIndex);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 99, (byte) 99, (byte) 240, (byte) 69, (byte) 109, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSeries(MatrixSeries series)
    {
      if (series == null)
      {
        string str = "Cannot add null series.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.seriesList.add((object) series);
        series.addChangeListener((SeriesChangeListener) this);
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 119, (byte) 99, (byte) 162, (byte) 100, (byte) 162, (byte) 104, (byte) 135, (byte) 180})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == null)
        return false;
      if (obj == this)
        return true;
      if (!(obj is MatrixSeriesCollection))
        return false;
      return (ObjectUtilities.equal((object) this.seriesList, (object) ((MatrixSeriesCollection) obj).seriesList) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 256)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      if (this.seriesList != null)
        return Object.instancehelper_hashCode((object) this.seriesList);
      else
        return 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 153, (byte) 108, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      MatrixSeriesCollection seriesCollection = (MatrixSeriesCollection) base.clone();
      seriesCollection.seriesList = (List) ObjectUtilities.deepClone((Collection) this.seriesList);
      return (object) seriesCollection;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 167, (byte) 112, (byte) 114, (byte) 7, (byte) 230, (byte) 70, (byte) 107, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeAllSeries()
    {
      for (int index = 0; index < this.seriesList.size(); ++index)
        ((Series) this.seriesList.get(index)).removeChangeListener((SeriesChangeListener) this);
      this.seriesList.clear();
      this.fireDatasetChanged();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 190, (byte) 99, (byte) 208, (byte) 110, (byte) 103, (byte) 109, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeSeries(MatrixSeries series)
    {
      if (series == null)
      {
        string str = "Cannot remove null series.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (!this.seriesList.contains((object) series))
          return;
        series.removeChangeListener((SeriesChangeListener) this);
        this.seriesList.remove((object) series);
        this.fireDatasetChanged();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 214, (byte) 109, (byte) 208, (byte) 114, (byte) 103, (byte) 109, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeSeries(int seriesIndex)
    {
      if (seriesIndex < 0 || seriesIndex > this.getSeriesCount())
      {
        string str = "Index outside valid range.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        ((Series) this.seriesList.get(seriesIndex)).removeChangeListener((SeriesChangeListener) this);
        this.seriesList.remove(seriesIndex);
        this.fireDatasetChanged();
      }
    }
  }
}
