// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.WaferMapRenderer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.chart.plot;
using org.jfree.data.general;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.renderer
{
  [Serializable]
  public class WaferMapRenderer : AbstractRenderer
  {
    private Map paintIndex;
    private WaferMapPlot plot;
    private int paintLimit;
    private const int DEFAULT_PAINT_LIMIT = 35;
    public const int POSITION_INDEX = 0;
    public const int VALUE_INDEX = 1;
    private int paintIndexMethod;

    [HideFromJava]
    static WaferMapRenderer()
    {
      AbstractRenderer.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WaferMapRenderer()
      : this((Integer) null, (Integer) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 104, (byte) 139, (byte) 99, (byte) 170, (byte) 172, (byte) 103, (byte) 99, (byte) 110, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WaferMapRenderer(Integer paintLimit, Integer paintIndexMethod)
    {
      WaferMapRenderer waferMapRenderer = this;
      this.paintIndex = (Map) new HashMap();
      this.paintLimit = paintLimit != null ? paintLimit.intValue() : 35;
      this.paintIndexMethod = 1;
      if (paintIndexMethod == null || !this.isMethodValid(paintIndexMethod.intValue()))
        return;
      this.paintIndexMethod = paintIndexMethod.intValue();
    }

    [LineNumberTable(new byte[] {(byte) 54, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WaferMapRenderer(int paintLimit, int paintIndexMethod)
      : this(new Integer(paintLimit), new Integer(paintIndexMethod))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected WaferMapRenderer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 127, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPlot(WaferMapPlot plot)
    {
      this.plot = plot;
      this.makePaintIndex();
    }

    [LineNumberTable((ushort) 189)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getChipColor(Number value)
    {
      return this.getSeriesPaint(this.getPaintIndex(value));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 179, (byte) 102, (byte) 124, (byte) 118, (byte) 113, (byte) 139, (byte) 108, (byte) 108, (byte) 99, (byte) 123, (byte) 152, (byte) 103, (byte) 135, (byte) 184, (byte) 202, (byte) 103, (byte) 114, (byte) 108, (byte) 110, (byte) 115, (byte) 223, (byte) 47, (byte) 100, (byte) 123, (byte) 185, (byte) 103, (byte) 135, (byte) 217, (byte) 165})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual LegendItemCollection getLegendCollection()
    {
      LegendItemCollection legendItemCollection = new LegendItemCollection();
      if (this.paintIndex != null && this.paintIndex.size() > 0)
      {
        if (this.paintIndex.size() <= this.paintLimit)
        {
          Iterator iterator = this.paintIndex.entrySet().iterator();
          while (iterator.hasNext())
          {
            Map.Entry entry = (Map.Entry) iterator.next();
            string label = Object.instancehelper_toString(entry.getKey());
            string description = label;
            Rectangle2D.Double @double = new Rectangle2D.Double(1.0, 1.0, 1.0, 1.0);
            Paint fillPaint = this.lookupSeriesPaint(((Integer) entry.getValue()).intValue());
            Color color = (Color) Color.black;
            Stroke outlineStroke = AbstractRenderer.__\u003C\u003EDEFAULT_STROKE;
            legendItemCollection.add(new LegendItem(label, description, (string) null, (string) null, (Shape) @double, fillPaint, outlineStroke, (Paint) color));
          }
        }
        else
        {
          HashSet hashSet = new HashSet();
          Iterator iterator = this.paintIndex.entrySet().iterator();
          while (iterator.hasNext())
          {
            Map.Entry entry = (Map.Entry) iterator.next();
            if (((Set) hashSet).add(entry.getValue()))
            {
              string label = new StringBuffer().append(Object.instancehelper_toString((object) this.getMinPaintValue((Integer) entry.getValue()))).append(" - ").append(Object.instancehelper_toString((object) this.getMaxPaintValue((Integer) entry.getValue()))).toString();
              string description = label;
              Rectangle2D.Double @double = new Rectangle2D.Double(1.0, 1.0, 1.0, 1.0);
              Paint seriesPaint = this.getSeriesPaint(((Integer) entry.getValue()).intValue());
              Color color = (Color) Color.black;
              Stroke outlineStroke = AbstractRenderer.__\u003C\u003EDEFAULT_STROKE;
              legendItemCollection.add(new LegendItem(label, description, (string) null, (string) null, (Shape) @double, seriesPaint, outlineStroke, (Paint) color));
            }
          }
        }
      }
      return legendItemCollection;
    }

    private bool isMethodValid([In] int obj0)
    {
      int num1 = obj0;
      int num2 = 0;
      if (num1 == num2)
        return true;
      int num3 = 1;
      return num1 == num3;
    }

    public virtual WaferMapPlot getPlot()
    {
      return this.plot;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 94, (byte) 104, (byte) 129, (byte) 108, (byte) 103, (byte) 103, (byte) 103, (byte) 110, (byte) 99, (byte) 113, (byte) 159, (byte) 3, (byte) 194, (byte) 151, (byte) 103, (byte) 130, (byte) 105, (byte) 226, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void makePaintIndex()
    {
      if (this.plot == null)
        return;
      WaferMapDataset dataset = this.plot.getDataset();
      Number minValue = dataset.getMinValue();
      Number maxValue = dataset.getMaxValue();
      Set uniqueValues = dataset.getUniqueValues();
      if (uniqueValues.size() <= this.paintLimit)
      {
        int num1 = 0;
        Iterator iterator = uniqueValues.iterator();
        while (iterator.hasNext())
        {
          Map map = this.paintIndex;
          object obj = iterator.next();
          int num2 = num1;
          ++num1;
          Integer integer = new Integer(num2);
          map.put(obj, (object) integer);
        }
      }
      else
      {
        int num1 = this.paintIndexMethod;
        int num2 = 0;
        if (num1 == num2)
        {
          this.makePositionIndex(uniqueValues);
        }
        else
        {
          int num3 = 1;
          if (num1 != num3)
            return;
          this.makeValueIndex(maxValue, minValue, uniqueValues);
        }
      }
    }

    [LineNumberTable((ushort) 200)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private int getPaintIndex([In] Number obj0)
    {
      return ((Integer) this.paintIndex.get((object) obj0)).intValue();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 130, (byte) 186, (byte) 98, (byte) 98, (byte) 111, (byte) 120, (byte) 114, (byte) 132, (byte) 105, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void makePositionIndex([In] Set obj0)
    {
      int num1 = ByteCodeHelper.d2i(Math.ceil((double) obj0.size() / (double) this.paintLimit));
      int num2 = 0;
      int num3 = 0;
      Iterator iterator = obj0.iterator();
      while (iterator.hasNext())
      {
        this.paintIndex.put(iterator.next(), (object) new Integer(num3));
        ++num2;
        int num4 = num2;
        int num5 = num1;
        int num6 = -1;
        if ((num5 != num6 ? num4 % num5 : 0) == 0)
          ++num3;
        if (num3 > this.paintLimit)
          num3 = this.paintLimit;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 155, (byte) 111, (byte) 107, (byte) 98, (byte) 106, (byte) 113, (byte) 110, (byte) 106, (byte) 101, (byte) 100, (byte) 105, (byte) 169, (byte) 116, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void makeValueIndex([In] Number obj0, [In] Number obj1, [In] Set obj2)
    {
      double num1 = (obj0.doubleValue() - obj1.doubleValue()) / (double) this.paintLimit;
      int num2 = 0;
      double num3 = obj1.doubleValue() + num1;
      Iterator iterator = obj2.iterator();
      while (iterator.hasNext())
      {
        Number number = (Number) iterator.next();
        while (number.doubleValue() > num3)
        {
          num3 += num1;
          ++num2;
          if (num2 > this.paintLimit)
            num2 = this.paintLimit;
        }
        this.paintIndex.put((object) number, (object) new Integer(num2));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 237, (byte) 106, (byte) 121, (byte) 108, (byte) 115, (byte) 115, (byte) 178, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Number getMinPaintValue([In] Integer obj0)
    {
      double num = double.PositiveInfinity;
      Iterator iterator = this.paintIndex.entrySet().iterator();
      while (iterator.hasNext())
      {
        Map.Entry entry = (Map.Entry) iterator.next();
        if (((Integer) entry.getValue()).equals((object) obj0) && ((Number) entry.getKey()).doubleValue() < num)
          num = ((Number) entry.getKey()).doubleValue();
      }
      return (Number) new Double(num);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 2, (byte) 106, (byte) 121, (byte) 108, (byte) 115, (byte) 115, (byte) 178, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Number getMaxPaintValue([In] Integer obj0)
    {
      double num = double.NegativeInfinity;
      Iterator iterator = this.paintIndex.entrySet().iterator();
      while (iterator.hasNext())
      {
        Map.Entry entry = (Map.Entry) iterator.next();
        if (((Integer) entry.getValue()).equals((object) obj0) && ((Number) entry.getKey()).doubleValue() > num)
          num = ((Number) entry.getKey()).doubleValue();
      }
      return (Number) new Double(num);
    }

    [LineNumberTable(new byte[] {(byte) 104, (byte) 98, (byte) 103, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DrawingSupplier getDrawingSupplier()
    {
      DrawingSupplier drawingSupplier = (DrawingSupplier) null;
      WaferMapPlot plot = this.getPlot();
      if (plot != null)
        drawingSupplier = plot.getDrawingSupplier();
      return drawingSupplier;
    }
  }
}
