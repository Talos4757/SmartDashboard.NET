// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.xy.CyclicXYItemRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart.axis;
using org.jfree.chart.labels;
using org.jfree.chart.plot;
using org.jfree.chart.urls;
using org.jfree.data;
using org.jfree.data.general;
using org.jfree.data.xy;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer.xy
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class CyclicXYItemRenderer : StandardXYItemRenderer, Serializable.__Interface
  {
    private const long serialVersionUID = 4035912243303764892L;

    [HideFromJava]
    static CyclicXYItemRenderer()
    {
      StandardXYItemRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 36, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CyclicXYItemRenderer()
    {
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CyclicXYItemRenderer(int type)
      : base(type)
    {
    }

    [LineNumberTable(new byte[] {(byte) 55, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CyclicXYItemRenderer(int type, XYToolTipGenerator labelGenerator)
      : base(type, labelGenerator)
    {
    }

    [LineNumberTable(new byte[] {(byte) 68, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CyclicXYItemRenderer(int type, XYToolTipGenerator labelGenerator, XYURLGenerator urlGenerator)
      : base(type, labelGenerator, urlGenerator)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CyclicXYItemRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CyclicXYItemRenderer obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 106, (byte) 159, (byte) 0, (byte) 157, (byte) 193, (byte) 111, (byte) 143, (byte) 104, (byte) 157, (byte) 129, (byte) 103, (byte) 103, (byte) 100, (byte) 164, (byte) 109, (byte) 141, (byte) 104, (byte) 129, (byte) 100, (byte) 164, (byte) 107, (byte) 107, (byte) 102, (byte) 134, (byte) 108, (byte) 105, (byte) 106, (byte) 201, (byte) 255, (byte) 14, (byte) 69, (byte) 104, (byte) 104, (byte) 124, (byte) 102, (byte) 159, (byte) 0, (byte) 198, (byte) 108, (byte) 105, (byte) 106, (byte) 169, (byte) 191, (byte) 14, (byte) 107, (byte) 107, (byte) 124, (byte) 102, (byte) 159, (byte) 0, (byte) 101, (byte) 142, (byte) 102, (byte) 101, (byte) 191, (byte) 22, (byte) 104, (byte) 104, (byte) 117, (byte) 117, (byte) 102, (byte) 159, (byte) 0, (byte) 230, (byte) 69, (byte) 101, (byte) 157, (byte) 161, (byte) 139, (byte) 100, (byte) 103, (byte) 145, (byte) 103, (byte) 177, (byte) 100, (byte) 103, (byte) 145, (byte) 103, (byte) 177, (byte) 250, (byte) 69, (byte) 100, (byte) 103, (byte) 145, (byte) 103, (byte) 177, (byte) 100, (byte) 103, (byte) 145, (byte) 103, (byte) 177, (byte) 186, (byte) 104, (byte) 100, (byte) 103, (byte) 145, (byte) 103, (byte) 177, (byte) 100, (byte) 103, (byte) 145, (byte) 103, (byte) 177, (byte) 218, (byte) 100, (byte) 137, (byte) 100, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void drawItem(Graphics2D g2, XYItemRendererState state, Rectangle2D dataArea, PlotRenderingInfo info, XYPlot plot, ValueAxis domainAxis, ValueAxis rangeAxis, XYDataset dataset, int series, int item, CrosshairState crosshairState, int pass)
    {
      if (!this.getPlotLines() || !(domainAxis is CyclicNumberAxis) && !(rangeAxis is CyclicNumberAxis) || item <= 0)
      {
        base.drawItem(g2, state, dataArea, info, plot, domainAxis, rangeAxis, dataset, series, item, crosshairState, pass);
      }
      else
      {
        double xvalue1 = dataset.getXValue(series, item - 1);
        double yvalue1 = dataset.getYValue(series, item - 1);
        if (Double.isNaN(yvalue1))
        {
          base.drawItem(g2, state, dataArea, info, plot, domainAxis, rangeAxis, dataset, series, item, crosshairState, pass);
        }
        else
        {
          double[] x = new double[2];
          double[] y = new double[2];
          x[0] = xvalue1;
          y[0] = yvalue1;
          double xvalue2 = dataset.getXValue(series, item);
          double yvalue2 = dataset.getYValue(series, item);
          if (Double.isNaN(yvalue2))
            return;
          x[1] = xvalue2;
          y[1] = yvalue2;
          double num1 = double.NaN;
          double num2 = double.NaN;
          int num3 = 0;
          int num4 = 0;
          CyclicNumberAxis cyclicNumberAxis1 = (CyclicNumberAxis) null;
          CyclicNumberAxis cyclicNumberAxis2 = (CyclicNumberAxis) null;
          if (domainAxis is CyclicNumberAxis)
          {
            cyclicNumberAxis1 = (CyclicNumberAxis) domainAxis;
            num1 = cyclicNumberAxis1.getCycleBound();
            num3 = cyclicNumberAxis1.isBoundMappedToLastCycle() ? 1 : 0;
            if (x[0] != x[1] && (num1 >= x[0] && num1 <= x[1] || num1 >= x[1] && num1 <= x[0]))
            {
              double[] numArray1 = new double[3];
              double[] numArray2 = new double[3];
              numArray1[0] = x[0];
              numArray1[2] = x[1];
              numArray2[0] = y[0];
              numArray2[2] = y[1];
              numArray1[1] = num1;
              numArray2[1] = (y[1] - y[0]) * (num1 - x[0]) / (x[1] - x[0]) + y[0];
              x = numArray1;
              y = numArray2;
            }
          }
          if (rangeAxis is CyclicNumberAxis)
          {
            cyclicNumberAxis2 = (CyclicNumberAxis) rangeAxis;
            num2 = cyclicNumberAxis2.getCycleBound();
            num4 = cyclicNumberAxis2.isBoundMappedToLastCycle() ? 1 : 0;
            if (y[0] != y[1] && (num2 >= y[0] && num2 <= y[1] || num2 >= y[1] && num2 <= y[0]))
            {
              double[] numArray1 = new double[x.Length + 1];
              double[] numArray2 = new double[y.Length + 1];
              numArray1[0] = x[0];
              numArray1[2] = x[1];
              numArray2[0] = y[0];
              numArray2[2] = y[1];
              numArray2[1] = num2;
              numArray1[1] = (x[1] - x[0]) * (num2 - y[0]) / (y[1] - y[0]) + x[0];
              if (x.Length == 3)
              {
                numArray1[3] = x[2];
                numArray2[3] = y[2];
              }
              x = numArray1;
              y = numArray2;
            }
            else if (x.Length == 3 && y[1] != y[2] && (num2 >= y[1] && num2 <= y[2] || num2 >= y[2] && num2 <= y[1]))
            {
              double[] numArray1 = new double[4];
              double[] numArray2 = new double[4];
              numArray1[0] = x[0];
              numArray1[1] = x[1];
              numArray1[3] = x[2];
              numArray2[0] = y[0];
              numArray2[1] = y[1];
              numArray2[3] = y[2];
              numArray2[2] = num2;
              numArray1[2] = (x[2] - x[1]) * (num2 - y[1]) / (y[2] - y[1]) + x[1];
              x = numArray1;
              y = numArray2;
            }
          }
          if (x.Length == 2)
          {
            base.drawItem(g2, state, dataArea, info, plot, domainAxis, rangeAxis, dataset, series, item, crosshairState, pass);
          }
          else
          {
            CyclicXYItemRenderer.OverwriteDataSet overwriteDataSet = new CyclicXYItemRenderer.OverwriteDataSet(x, y, dataset);
            if (cyclicNumberAxis1 != null)
            {
              if (num1 == x[0])
                cyclicNumberAxis1.setBoundMappedToLastCycle(x[1] <= num1);
              if (num1 == x[1])
                cyclicNumberAxis1.setBoundMappedToLastCycle(x[0] <= num1);
            }
            if (cyclicNumberAxis2 != null)
            {
              if (num2 == y[0])
                cyclicNumberAxis2.setBoundMappedToLastCycle(y[1] <= num2);
              if (num2 == y[1])
                cyclicNumberAxis2.setBoundMappedToLastCycle(y[0] <= num2);
            }
            base.drawItem(g2, state, dataArea, info, plot, domainAxis, rangeAxis, (XYDataset) overwriteDataSet, series, 1, crosshairState, pass);
            if (cyclicNumberAxis1 != null)
            {
              if (num1 == x[1])
                cyclicNumberAxis1.setBoundMappedToLastCycle(x[2] <= num1);
              if (num1 == x[2])
                cyclicNumberAxis1.setBoundMappedToLastCycle(x[1] <= num1);
            }
            if (cyclicNumberAxis2 != null)
            {
              if (num2 == y[1])
                cyclicNumberAxis2.setBoundMappedToLastCycle(y[2] <= num2);
              if (num2 == y[2])
                cyclicNumberAxis2.setBoundMappedToLastCycle(y[1] <= num2);
            }
            base.drawItem(g2, state, dataArea, info, plot, domainAxis, rangeAxis, (XYDataset) overwriteDataSet, series, 2, crosshairState, pass);
            if (x.Length == 4)
            {
              if (cyclicNumberAxis1 != null)
              {
                if (num1 == x[2])
                  cyclicNumberAxis1.setBoundMappedToLastCycle(x[3] <= num1);
                if (num1 == x[3])
                  cyclicNumberAxis1.setBoundMappedToLastCycle(x[2] <= num1);
              }
              if (cyclicNumberAxis2 != null)
              {
                if (num2 == y[2])
                  cyclicNumberAxis2.setBoundMappedToLastCycle(y[3] <= num2);
                if (num2 == y[3])
                  cyclicNumberAxis2.setBoundMappedToLastCycle(y[2] <= num2);
              }
              base.drawItem(g2, state, dataArea, info, plot, domainAxis, rangeAxis, (XYDataset) overwriteDataSet, series, 3, crosshairState, pass);
            }
            if (cyclicNumberAxis1 != null)
              cyclicNumberAxis1.setBoundMappedToLastCycle(num3 != 0);
            if (cyclicNumberAxis2 == null)
              return;
            cyclicNumberAxis2.setBoundMappedToLastCycle(num4 != 0);
          }
        }
      }
    }

    [InnerClass]
    [Implements(new string[] {"org.jfree.data.xy.XYDataset"})]
    [SourceFile("CyclicXYItemRenderer.java")]
    public class OverwriteDataSet : Object, XYDataset, SeriesDataset, Dataset
    {
      protected internal XYDataset delegateSet;
      internal Double[] x;
      internal Double[] y;

      [LineNumberTable(new byte[] {(byte) 160, (byte) 232, (byte) 104, (byte) 103, (byte) 122, (byte) 103, (byte) 117, (byte) 21, (byte) 198})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public OverwriteDataSet(double[] x, double[] y, XYDataset delegateSet)
      {
        base.\u002Ector();
        CyclicXYItemRenderer.OverwriteDataSet overwriteDataSet = this;
        this.delegateSet = delegateSet;
        this.x = new Double[x.Length];
        this.y = new Double[y.Length];
        for (int index1 = 0; index1 < x.Length; ++index1)
        {
          Double[] doubleArray1 = this.x;
          int index2 = index1;
          Double.__\u003Cclinit\u003E();
          Double double1 = new Double(x[index1]);
          doubleArray1[index2] = double1;
          Double[] doubleArray2 = this.y;
          int index3 = index1;
          Double.__\u003Cclinit\u003E();
          Double double2 = new Double(y[index1]);
          doubleArray2[index3] = double2;
        }
      }

      [LineNumberTable((ushort) 384)]
      public virtual Number getX(int series, int item)
      {
        return (Number) this.x[item];
      }

      [LineNumberTable((ushort) 414)]
      public virtual Number getY(int series, int item)
      {
        return (Number) this.y[item];
      }

      [LineNumberTable((ushort) 361)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual DomainOrder getDomainOrder()
      {
        return DomainOrder.__\u003C\u003ENONE;
      }

      [LineNumberTable((ushort) 372)]
      public virtual int getItemCount(int series)
      {
        return this.x.Length;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 27, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual double getXValue(int series, int item)
      {
        double num = double.NaN;
        Number x = this.getX(series, item);
        if (x != null)
          num = x.doubleValue();
        return num;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 57, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual double getYValue(int series, int item)
      {
        double num = double.NaN;
        Number y = this.getY(series, item);
        if (y != null)
          num = y.doubleValue();
        return num;
      }

      [LineNumberTable((ushort) 441)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getSeriesCount()
      {
        return this.delegateSet.getSeriesCount();
      }

      [LineNumberTable((ushort) 452)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual IComparable getSeriesKey(int series)
      {
        return this.delegateSet.getSeriesKey(series);
      }

      [LineNumberTable((ushort) 463)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int indexOf(IComparable seriesName)
      {
        return this.delegateSet.indexOf(seriesName);
      }

      public virtual void addChangeListener(DatasetChangeListener listener)
      {
      }

      public virtual void removeChangeListener(DatasetChangeListener listener)
      {
      }

      [LineNumberTable((ushort) 491)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual DatasetGroup getGroup()
      {
        return this.delegateSet.getGroup();
      }

      public virtual void setGroup(DatasetGroup group)
      {
      }
    }
  }
}
