// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.CombinedRangeXYPlot
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.chart.@event;
using org.jfree.chart.axis;
using org.jfree.chart.renderer.xy;
using org.jfree.data;
using org.jfree.data.xy;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.plot
{
  [Implements(new string[] {"org.jfree.chart.event.PlotChangeListener"})]
  [Serializable]
  public class CombinedRangeXYPlot : XYPlot, PlotChangeListener, EventListener
  {
    private const long serialVersionUID = -5177814085082031168L;
    private List subplots;
    private double gap;
    [NonSerialized]
    private Rectangle2D[] subplotAreas;

    [HideFromJava]
    static CombinedRangeXYPlot()
    {
      XYPlot.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 104, (byte) 236, (byte) 45, (byte) 240, (byte) 88, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CombinedRangeXYPlot(ValueAxis rangeAxis)
      : base((XYDataset) null, (ValueAxis) null, rangeAxis, (XYItemRenderer) null)
    {
      CombinedRangeXYPlot combinedRangeXyPlot = this;
      this.gap = 5.0;
      this.subplots = (List) new ArrayList();
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CombinedRangeXYPlot()
      : this((ValueAxis) new NumberAxis())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CombinedRangeXYPlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 153, (byte) 104, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getSubplots()
    {
      if (this.subplots == null)
        return (List) Collections.EMPTY_LIST;
      return Collections.unmodifiableList(this.subplots);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 102, (byte) 100, (byte) 102, (byte) 204, (byte) 103, (byte) 103, (byte) 127, (byte) 0, (byte) 103, (byte) 103, (byte) 109, (byte) 102, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(XYPlot subplot, int weight)
    {
      if (weight <= 0)
      {
        string str = "The 'weight' must be positive.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        subplot.setParent((Plot) this);
        subplot.setWeight(weight);
        subplot.setInsets(new RectangleInsets(0.0, 0.0, 0.0, 0.0));
        subplot.setRangeAxis((ValueAxis) null);
        subplot.addChangeListener((PlotChangeListener) this);
        this.subplots.add((object) subplot);
        this.configureRangeAxes();
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 172, (byte) 102, (byte) 167, (byte) 103, (byte) 99, (byte) 104, (byte) 108, (byte) 142, (byte) 104, (byte) 108, (byte) 206, (byte) 103, (byte) 174, (byte) 99, (byte) 237, (byte) 69, (byte) 138, (byte) 109, (byte) 99, (byte) 105, (byte) 116, (byte) 12, (byte) 232, (byte) 71, (byte) 109, (byte) 106, (byte) 106, (byte) 103, (byte) 104, (byte) 153, (byte) 104, (byte) 183, (byte) 108, (byte) 180, (byte) 104, (byte) 114, (byte) 155, (byte) 111, (byte) 98, (byte) 104, (byte) 114, (byte) 155, (byte) 175, (byte) 148, (byte) 232, (byte) 45, (byte) 235, (byte) 87})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override AxisSpace calculateAxisSpace(Graphics2D g2, Rectangle2D plotArea)
    {
      AxisSpace space1 = new AxisSpace();
      PlotOrientation orientation = this.getOrientation();
      AxisSpace fixedRangeAxisSpace = this.getFixedRangeAxisSpace();
      if (fixedRangeAxisSpace != null)
      {
        if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        {
          space1.setLeft(fixedRangeAxisSpace.getLeft());
          space1.setRight(fixedRangeAxisSpace.getRight());
        }
        else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          space1.setTop(fixedRangeAxisSpace.getTop());
          space1.setBottom(fixedRangeAxisSpace.getBottom());
        }
      }
      else
      {
        ValueAxis rangeAxis = this.getRangeAxis();
        RectangleEdge edge = Plot.resolveRangeAxisLocation(this.getRangeAxisLocation(), orientation);
        if (rangeAxis != null)
          space1 = rangeAxis.reserveSpace(g2, (Plot) this, plotArea, edge, space1);
      }
      Rectangle2D rectangle2D = space1.shrink(plotArea, (Rectangle2D) null);
      int length = this.subplots.size();
      int num1 = 0;
      for (int index = 0; index < length; ++index)
      {
        XYPlot xyPlot = (XYPlot) this.subplots.get(index);
        num1 += xyPlot.getWeight();
      }
      this.subplotAreas = new Rectangle2D[length];
      double num2 = ((RectangularShape) rectangle2D).getX();
      double num3 = ((RectangularShape) rectangle2D).getY();
      double num4 = 0.0;
      if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        num4 = ((RectangularShape) rectangle2D).getWidth() - this.gap * (double) (length - 1);
      else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        num4 = ((RectangularShape) rectangle2D).getHeight() - this.gap * (double) (length - 1);
      for (int index = 0; index < length; ++index)
      {
        XYPlot xyPlot = (XYPlot) this.subplots.get(index);
        if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        {
          double num5 = num4 * (double) xyPlot.getWeight() / (double) num1;
          this.subplotAreas[index] = (Rectangle2D) new Rectangle2D.Double(num2, num3, num5, ((RectangularShape) rectangle2D).getHeight());
          num2 = num2 + num5 + this.gap;
        }
        else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          double num5 = num4 * (double) xyPlot.getWeight() / (double) num1;
          this.subplotAreas[index] = (Rectangle2D) new Rectangle2D.Double(num2, num3, ((RectangularShape) rectangle2D).getWidth(), num5);
          num3 = num3 + num5 + this.gap;
        }
        AxisSpace space2 = xyPlot.calculateDomainAxisSpace(g2, this.subplotAreas[index], (AxisSpace) null);
        space1.ensureAtLeast(space2);
      }
      return space1;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 236, (byte) 108, (byte) 104, (byte) 108, (byte) 104, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void setFixedDomainAxisSpaceForSubplots(AxisSpace space)
    {
      Iterator iterator = this.subplots.iterator();
      while (iterator.hasNext())
        ((XYPlot) iterator.next()).setFixedDomainAxisSpace(space, false);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 25, (byte) 67, (byte) 105, (byte) 99, (byte) 237, (byte) 69, (byte) 108, (byte) 104, (byte) 108, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void zoomDomainAxes(double factor, PlotRenderingInfo info, Point2D source, bool useAnchor)
    {
      int num = useAnchor ? 1 : 0;
      XYPlot subplot = this.findSubplot(info, source);
      if (subplot != null)
      {
        subplot.zoomDomainAxes(factor, info, source, num != 0);
      }
      else
      {
        Iterator iterator = this.getSubplots().iterator();
        while (iterator.hasNext())
          ((XYPlot) iterator.next()).zoomDomainAxes(factor, info, source, num != 0);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 150, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 98, (byte) 104, (byte) 100, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual XYPlot findSubplot(PlotRenderingInfo info, Point2D source)
    {
      if (info == null)
      {
        string str = "Null 'info' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (source == null)
      {
        string str = "Null 'source' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        XYPlot xyPlot = (XYPlot) null;
        int subplotIndex = info.getSubplotIndex(source);
        if (subplotIndex >= 0)
          xyPlot = (XYPlot) this.subplots.get(subplotIndex);
        return xyPlot;
      }
    }

    [LineNumberTable((ushort) 169)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string getPlotType()
    {
      return XYPlot.localizationResources.getString("Combined_Range_XYPlot");
    }

    public virtual double getGap()
    {
      return this.gap;
    }

    public virtual void setGap(double gap)
    {
      this.gap = gap;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 85, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(XYPlot subplot)
    {
      this.add(subplot, 1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 125, (byte) 99, (byte) 144, (byte) 98, (byte) 108, (byte) 98, (byte) 104, (byte) 111, (byte) 130, (byte) 134, (byte) 100, (byte) 109, (byte) 103, (byte) 103, (byte) 102, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove(XYPlot subplot)
    {
      if (subplot == null)
      {
        string str = " Null 'subplot' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int num1 = -1;
        int num2 = this.subplots.size();
        for (int index = 0; num1 == -1 && index < num2; ++index)
        {
          if (this.subplots.get(index) == subplot)
            num1 = index;
        }
        if (num1 == -1)
          return;
        this.subplots.remove(num1);
        subplot.setParent((Plot) null);
        subplot.removeChangeListener((PlotChangeListener) this);
        this.configureRangeAxes();
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 9, (byte) 100, (byte) 200, (byte) 103, (byte) 135, (byte) 105, (byte) 201, (byte) 167, (byte) 103, (byte) 104, (byte) 107, (byte) 145, (byte) 100, (byte) 135, (byte) 176, (byte) 114, (byte) 116, (byte) 99, (byte) 100, (byte) 110, (byte) 137, (byte) 246, (byte) 57, (byte) 232, (byte) 75, (byte) 100, (byte) 170})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area, Point2D anchor, PlotState parentState, PlotRenderingInfo info)
    {
      if (info != null)
        info.setPlotArea(area);
      this.getInsets().trim(area);
      AxisSpace space = this.calculateAxisSpace(g2, area);
      Rectangle2D rectangle2D = space.shrink(area, (Rectangle2D) null);
      this.setFixedDomainAxisSpaceForSubplots(space);
      ValueAxis rangeAxis = this.getRangeAxis();
      RectangleEdge rangeAxisEdge = this.getRangeAxisEdge();
      double d = RectangleEdge.coordinate(rectangle2D, rangeAxisEdge);
      AxisState axisState = rangeAxis.draw(g2, d, area, rectangle2D, rangeAxisEdge, info);
      if (parentState == null)
        parentState = new PlotState();
      parentState.getSharedAxisStates().put((object) rangeAxis, (object) axisState);
      for (int index = 0; index < this.subplots.size(); ++index)
      {
        XYPlot xyPlot = (XYPlot) this.subplots.get(index);
        PlotRenderingInfo info1 = (PlotRenderingInfo) null;
        if (info != null)
        {
          info1 = new PlotRenderingInfo(info.getOwner());
          info.addSubplotInfo(info1);
        }
        xyPlot.draw(g2, this.subplotAreas[index], anchor, parentState, info1);
      }
      if (info == null)
        return;
      info.setDataArea(rectangle2D);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 59, (byte) 103, (byte) 99, (byte) 134, (byte) 104, (byte) 108, (byte) 104, (byte) 108, (byte) 103, (byte) 103, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override LegendItemCollection getLegendItems()
    {
      LegendItemCollection legendItemCollection = this.getFixedLegendItems();
      if (legendItemCollection == null)
      {
        legendItemCollection = new LegendItemCollection();
        if (this.subplots != null)
        {
          Iterator iterator = this.subplots.iterator();
          while (iterator.hasNext())
          {
            LegendItemCollection legendItems = ((XYPlot) iterator.next()).getLegendItems();
            legendItemCollection.addAll(legendItems);
          }
        }
      }
      return legendItemCollection;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 84, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void zoomDomainAxes(double factor, PlotRenderingInfo info, Point2D source)
    {
      this.zoomDomainAxes(factor, info, source, false);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 124, (byte) 106, (byte) 99, (byte) 239, (byte) 69, (byte) 108, (byte) 104, (byte) 108, (byte) 207})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void zoomDomainAxes(double lowerPercent, double upperPercent, PlotRenderingInfo info, Point2D source)
    {
      XYPlot subplot = this.findSubplot(info, source);
      if (subplot != null)
      {
        subplot.zoomDomainAxes(lowerPercent, upperPercent, info, source);
      }
      else
      {
        Iterator iterator = this.getSubplots().iterator();
        while (iterator.hasNext())
          ((XYPlot) iterator.next()).zoomDomainAxes(lowerPercent, upperPercent, info, source);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 175, (byte) 199, (byte) 108, (byte) 104, (byte) 108, (byte) 103, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setRenderer(XYItemRenderer renderer)
    {
      base.setRenderer(renderer);
      Iterator iterator = this.subplots.iterator();
      while (iterator.hasNext())
        ((XYPlot) iterator.next()).setRenderer(renderer);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 194, (byte) 135, (byte) 108, (byte) 104, (byte) 108, (byte) 103, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setOrientation(PlotOrientation orientation)
    {
      base.setOrientation(orientation);
      Iterator iterator = this.subplots.iterator();
      while (iterator.hasNext())
        ((XYPlot) iterator.next()).setOrientation(orientation);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 218, (byte) 98, (byte) 104, (byte) 108, (byte) 104, (byte) 108, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range getDataRange(ValueAxis axis)
    {
      Range range1 = (Range) null;
      if (this.subplots != null)
      {
        Iterator iterator = this.subplots.iterator();
        while (iterator.hasNext())
        {
          XYPlot xyPlot = (XYPlot) iterator.next();
          range1 = Range.combine(range1, xyPlot.getDataRange(axis));
        }
      }
      return range1;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 252, (byte) 103, (byte) 108, (byte) 112, (byte) 114, (byte) 104, (byte) 233, (byte) 61, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void handleClick(int x, int y, PlotRenderingInfo info)
    {
      if (!info.getDataArea().contains((double) x, (double) y))
        return;
      for (int index = 0; index < this.subplots.size(); ++index)
      {
        XYPlot xyPlot = (XYPlot) this.subplots.get(index);
        PlotRenderingInfo subplotInfo = info.getSubplotInfo(index);
        xyPlot.handleClick(x, y, subplotInfo);
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 14, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void plotChanged(PlotChangeEvent @event)
    {
      this.notifyListeners(@event);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 25, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CombinedRangeXYPlot))
        return false;
      CombinedRangeXYPlot combinedRangeXyPlot = (CombinedRangeXYPlot) obj;
      if (this.gap != combinedRangeXyPlot.gap || !ObjectUtilities.equal((object) this.subplots, (object) combinedRangeXyPlot.subplots))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 51, (byte) 108, (byte) 118, (byte) 116, (byte) 108, (byte) 103, (byte) 194, (byte) 103, (byte) 99, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      CombinedRangeXYPlot combinedRangeXyPlot = (CombinedRangeXYPlot) base.clone();
      combinedRangeXyPlot.subplots = (List) ObjectUtilities.deepClone((Collection) this.subplots);
      Iterator iterator = combinedRangeXyPlot.subplots.iterator();
      while (iterator.hasNext())
        ((Plot) iterator.next()).setParent((Plot) combinedRangeXyPlot);
      ValueAxis rangeAxis = combinedRangeXyPlot.getRangeAxis();
      if (rangeAxis != null)
        rangeAxis.configure();
      return (object) combinedRangeXyPlot;
    }
  }
}
