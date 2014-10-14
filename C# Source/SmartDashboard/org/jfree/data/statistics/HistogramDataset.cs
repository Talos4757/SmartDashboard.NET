// Decompiled with JetBrains decompiler
// Type: org.jfree.data.statistics.HistogramDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
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
  public class HistogramDataset : AbstractIntervalXYDataset, IntervalXYDataset, XYDataset, SeriesDataset, Dataset, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -6341668077370231153L;
    private List list;
    private HistogramType type;

    [LineNumberTable(new byte[] {(byte) 45, (byte) 104, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public HistogramDataset()
    {
      HistogramDataset histogramDataset = this;
      this.list = (List) new ArrayList();
      this.type = HistogramType.__\u003C\u003EFREQUENCY;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected HistogramDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] HistogramDataset obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] HistogramDataset obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 108, (byte) 104, (byte) 176, (byte) 106, (byte) 103, (byte) 102, (byte) 4, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double getMinimum([In] double[] obj0)
    {
      if (obj0 == null || obj0.Length < 1)
      {
        string str = "Null or zero length 'values' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num = double.MaxValue;
        for (int index = 0; index < obj0.Length; ++index)
        {
          if (obj0[index] < num)
            num = obj0[index];
        }
        return num;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 130, (byte) 104, (byte) 176, (byte) 106, (byte) 103, (byte) 102, (byte) 4, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double getMaximum([In] double[] obj0)
    {
      if (obj0 == null || obj0.Length < 1)
      {
        string str = "Null or zero length 'values' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num = double.MinValue;
        for (int index = 0; index < obj0.Length; ++index)
        {
          if (obj0[index] > num)
            num = obj0[index];
        }
        return num;
      }
    }

    [LineNumberTable(new byte[] {(byte) 105, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 100, (byte) 176, (byte) 140, (byte) 132, (byte) 103, (byte) 230, (byte) 69, (byte) 102, (byte) 173, (byte) 109, (byte) 106, (byte) 131, (byte) 233, (byte) 51, (byte) 230, (byte) 80, (byte) 106, (byte) 101, (byte) 104, (byte) 114, (byte) 105, (byte) 135, (byte) 204, (byte) 101, (byte) 165, (byte) 111, (byte) 231, (byte) 48, (byte) 233, (byte) 83, (byte) 103, (byte) 110, (byte) 110, (byte) 121, (byte) 115, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSeries(IComparable key, double[] values, int bins, double minimum, double maximum)
    {
      if (key == null)
      {
        string str = "Null 'key' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (values == null)
      {
        string str = "Null 'values' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (bins < 1)
      {
        string str = "The 'bins' value must be at least 1.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num1 = (maximum - minimum) / (double) bins;
        double startBoundary = minimum;
        ArrayList arrayList = new ArrayList(bins);
        for (int index = 0; index < bins; ++index)
        {
          HistogramBin histogramBin;
          if (index == bins - 1)
          {
            histogramBin = new HistogramBin(startBoundary, maximum);
          }
          else
          {
            double endBoundary = minimum + (double) (index + 1) * num1;
            histogramBin = new HistogramBin(startBoundary, endBoundary);
            startBoundary = endBoundary;
          }
          ((List) arrayList).add((object) histogramBin);
        }
        for (int index = 0; index < values.Length; ++index)
        {
          int num2 = bins - 1;
          if (values[index] < maximum)
          {
            double num3 = (values[index] - minimum) / (maximum - minimum);
            if (num3 < 0.0)
              num3 = 0.0;
            num2 = ByteCodeHelper.d2i(num3 * (double) bins);
            if (num2 >= bins)
              num2 = bins - 1;
          }
          ((HistogramBin) ((List) arrayList).get(num2)).incrementCount();
        }
        HashMap hashMap1 = new HashMap();
        ((Map) hashMap1).put((object) "key", (object) key);
        ((Map) hashMap1).put((object) "bins", (object) arrayList);
        HashMap hashMap2 = hashMap1;
        string str = "values.length";
        Integer.__\u003Cclinit\u003E();
        Integer integer = new Integer(values.Length);
        ((Map) hashMap2).put((object) str, (object) integer);
        ((Map) hashMap1).put((object) "bin width", (object) new Double(num1));
        this.list.add((object) hashMap1);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 155, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal virtual List getBins([In] int obj0)
    {
      return (List) ((Map) this.list.get(obj0)).get((object) "bins");
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 167, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private int getTotal([In] int obj0)
    {
      return ((Integer) ((Map) this.list.get(obj0)).get((object) "values.length")).intValue();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 179, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private double getBinWidth([In] int obj0)
    {
      return ((Double) ((Map) this.list.get(obj0)).get((object) "bin width")).doubleValue();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 3, (byte) 104, (byte) 109, (byte) 105, (byte) 137, (byte) 109, (byte) 148, (byte) 109, (byte) 150, (byte) 109, (byte) 184})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getY(int series, int item)
    {
      HistogramBin histogramBin = (HistogramBin) this.getBins(series).get(item);
      double num = (double) this.getTotal(series);
      double binWidth = this.getBinWidth(series);
      if (this.type == HistogramType.__\u003C\u003EFREQUENCY)
      {
        Double.__\u003Cclinit\u003E();
        return (Number) new Double((double) histogramBin.getCount());
      }
      else if (this.type == HistogramType.__\u003C\u003ERELATIVE_FREQUENCY)
      {
        Double.__\u003Cclinit\u003E();
        return (Number) new Double((double) histogramBin.getCount() / num);
      }
      else if (this.type == HistogramType.__\u003C\u003ESCALE_AREA_TO_1)
      {
        Double.__\u003Cclinit\u003E();
        return (Number) new Double((double) histogramBin.getCount() / (binWidth * num));
      }
      else
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalStateException();
      }
    }

    [LineNumberTable((ushort) 303)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getSeriesCount()
    {
      return this.list.size();
    }

    public virtual HistogramType getType()
    {
      return this.type;
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 99, (byte) 144, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setType(HistogramType type)
    {
      if (type == null)
      {
        string str = "Null 'type' argument";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.type = type;
        this.notifyListeners(new DatasetChangeEvent((object) this, (Dataset) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 82, (byte) 105, (byte) 105, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSeries(IComparable key, double[] values, int bins)
    {
      double minimum = this.getMinimum(values);
      double maximum = this.getMaximum(values);
      this.addSeries(key, values, bins, minimum, maximum);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 204, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IComparable getSeriesKey(int series)
    {
      return (IComparable) ((Map) this.list.get(series)).get((object) "key");
    }

    [LineNumberTable((ushort) 334)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int getItemCount(int series)
    {
      return this.getBins(series).size();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 239, (byte) 104, (byte) 109, (byte) 121})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getX(int series, int item)
    {
      HistogramBin histogramBin = (HistogramBin) this.getBins(series).get(item);
      return (Number) new Double((histogramBin.getStartBoundary() + histogramBin.getEndBoundary()) / 2.0);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 35, (byte) 104, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartX(int series, int item)
    {
      HistogramBin histogramBin = (HistogramBin) this.getBins(series).get(item);
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(histogramBin.getStartBoundary());
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 53, (byte) 104, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndX(int series, int item)
    {
      HistogramBin histogramBin = (HistogramBin) this.getBins(series).get(item);
      Double.__\u003Cclinit\u003E();
      return (Number) new Double(histogramBin.getEndBoundary());
    }

    [LineNumberTable((ushort) 443)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getStartY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable((ushort) 461)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Number getEndY(int series, int item)
    {
      return this.getY(series, item);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 102, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is HistogramDataset))
        return false;
      HistogramDataset histogramDataset = (HistogramDataset) obj;
      return ObjectUtilities.equal((object) this.type, (object) histogramDataset.type) && ObjectUtilities.equal((object) this.list, (object) histogramDataset.list);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 126, (byte) 108, (byte) 103, (byte) 108, (byte) 102, (byte) 63, (byte) 3, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      HistogramDataset histogramDataset = (HistogramDataset) base.clone();
      int seriesCount = this.getSeriesCount();
      histogramDataset.list = (List) new ArrayList(seriesCount);
      for (int index = 0; index < seriesCount; ++index)
        histogramDataset.list.add((object) new HashMap((Map) this.list.get(index)));
      return (object) histogramDataset;
    }
  }
}
