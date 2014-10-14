// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.plot.CombinedRangeCategoryPlot
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart;
using org.jfree.chart.@event;
using org.jfree.chart.axis;
using org.jfree.chart.renderer.category;
using org.jfree.data;
using org.jfree.data.category;
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
  public class CombinedRangeCategoryPlot : CategoryPlot, PlotChangeListener, EventListener
  {
    private const long serialVersionUID = 7260210007554504515L;
    private List subplots;
    private double gap;
    [NonSerialized]
    private Rectangle2D[] subplotArea;

    [HideFromJava]
    static CombinedRangeCategoryPlot()
    {
      CategoryPlot.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 108, (byte) 107, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CombinedRangeCategoryPlot(ValueAxis rangeAxis)
      : base((CategoryDataset) null, (CategoryAxis) null, rangeAxis, (CategoryItemRenderer) null)
    {
      CombinedRangeCategoryPlot rangeCategoryPlot = this;
      this.subplots = (List) new ArrayList();
      this.gap = 5.0;
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CombinedRangeCategoryPlot()
      : this((ValueAxis) new NumberAxis())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CombinedRangeCategoryPlot([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 117, (byte) 104, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getSubplots()
    {
      if (this.subplots == null)
        return (List) Collections.EMPTY_LIST;
      return Collections.unmodifiableList(this.subplots);
    }

    [LineNumberTable(new byte[] {(byte) 116, (byte) 99, (byte) 144, (byte) 100, (byte) 176, (byte) 103, (byte) 103, (byte) 127, (byte) 0, (byte) 103, (byte) 108, (byte) 103, (byte) 141, (byte) 103, (byte) 99, (byte) 134, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(CategoryPlot subplot, int weight)
    {
      if (subplot == null)
      {
        string str = "Null 'subplot' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (weight <= 0)
      {
        string str = "Require weight >= 1.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        subplot.setParent((Plot) this);
        subplot.setWeight(weight);
        subplot.setInsets(new RectangleInsets(0.0, 0.0, 0.0, 0.0));
        subplot.setRangeAxis((ValueAxis) null);
        subplot.setOrientation(this.getOrientation());
        subplot.addChangeListener((PlotChangeListener) this);
        this.subplots.add((object) subplot);
        ValueAxis rangeAxis = this.getRangeAxis();
        if (rangeAxis != null)
          rangeAxis.configure();
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 136, (byte) 102, (byte) 167, (byte) 103, (byte) 99, (byte) 104, (byte) 108, (byte) 142, (byte) 104, (byte) 108, (byte) 206, (byte) 103, (byte) 142, (byte) 99, (byte) 237, (byte) 69, (byte) 138, (byte) 109, (byte) 99, (byte) 105, (byte) 116, (byte) 12, (byte) 232, (byte) 70, (byte) 109, (byte) 106, (byte) 106, (byte) 103, (byte) 104, (byte) 153, (byte) 104, (byte) 183, (byte) 108, (byte) 180, (byte) 104, (byte) 114, (byte) 155, (byte) 111, (byte) 98, (byte) 104, (byte) 114, (byte) 155, (byte) 175, (byte) 148, (byte) 232, (byte) 45, (byte) 235, (byte) 87})]
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
        CategoryPlot categoryPlot = (CategoryPlot) this.subplots.get(index);
        num1 += categoryPlot.getWeight();
      }
      this.subplotArea = new Rectangle2D[length];
      double num2 = ((RectangularShape) rectangle2D).getX();
      double num3 = ((RectangularShape) rectangle2D).getY();
      double num4 = 0.0;
      if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        num4 = ((RectangularShape) rectangle2D).getWidth() - this.gap * (double) (length - 1);
      else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        num4 = ((RectangularShape) rectangle2D).getHeight() - this.gap * (double) (length - 1);
      for (int index = 0; index < length; ++index)
      {
        CategoryPlot categoryPlot = (CategoryPlot) this.subplots.get(index);
        if (orientation == PlotOrientation.__\u003C\u003EVERTICAL)
        {
          double num5 = num4 * (double) categoryPlot.getWeight() / (double) num1;
          this.subplotArea[index] = (Rectangle2D) new Rectangle2D.Double(num2, num3, num5, ((RectangularShape) rectangle2D).getHeight());
          num2 = num2 + num5 + this.gap;
        }
        else if (orientation == PlotOrientation.__\u003C\u003EHORIZONTAL)
        {
          double num5 = num4 * (double) categoryPlot.getWeight() / (double) num1;
          this.subplotArea[index] = (Rectangle2D) new Rectangle2D.Double(num2, num3, ((RectangularShape) rectangle2D).getWidth(), num5);
          num3 = num3 + num5 + this.gap;
        }
        AxisSpace space2 = categoryPlot.calculateDomainAxisSpace(g2, this.subplotArea[index], (AxisSpace) null);
        space1.ensureAtLeast(space2);
      }
      return space1;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 88, (byte) 108, (byte) 104, (byte) 108, (byte) 104, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void setFixedDomainAxisSpaceForSubplots(AxisSpace space)
    {
      Iterator iterator = this.subplots.iterator();
      while (iterator.hasNext())
        ((CategoryPlot) iterator.next()).setFixedDomainAxisSpace(space, false);
    }

    public virtual double getGap()
    {
      return this.gap;
    }

    [LineNumberTable(new byte[] {(byte) 87, (byte) 105, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setGap(double gap)
    {
      this.gap = gap;
      this.fireChangeEvent();
    }

    [LineNumberTable(new byte[] {(byte) 102, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(CategoryPlot subplot)
    {
      this.add(subplot, 1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 80, (byte) 99, (byte) 144, (byte) 98, (byte) 108, (byte) 98, (byte) 104, (byte) 111, (byte) 130, (byte) 134, (byte) 100, (byte) 109, (byte) 103, (byte) 135, (byte) 103, (byte) 99, (byte) 166, (byte) 105, (byte) 100, (byte) 135, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void remove(CategoryPlot subplot)
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
        ValueAxis rangeAxis1 = this.getRangeAxis();
        if (rangeAxis1 != null)
          rangeAxis1.configure();
        ValueAxis rangeAxis2 = this.getRangeAxis(1);
        if (rangeAxis2 != null)
          rangeAxis2.configure();
        this.fireChangeEvent();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 226, (byte) 100, (byte) 200, (byte) 103, (byte) 167, (byte) 105, (byte) 169, (byte) 167, (byte) 103, (byte) 104, (byte) 107, (byte) 145, (byte) 100, (byte) 135, (byte) 176, (byte) 117, (byte) 116, (byte) 99, (byte) 100, (byte) 110, (byte) 137, (byte) 99, (byte) 116, (byte) 131, (byte) 247, (byte) 53, (byte) 235, (byte) 79, (byte) 100, (byte) 170})]
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
        CategoryPlot categoryPlot = (CategoryPlot) this.subplots.get(index);
        PlotRenderingInfo plotRenderingInfo = (PlotRenderingInfo) null;
        if (info != null)
        {
          plotRenderingInfo = new PlotRenderingInfo(info.getOwner());
          info.addSubplotInfo(plotRenderingInfo);
        }
        Point2D anchor1 = (Point2D) null;
        if (anchor != null && ((RectangularShape) this.subplotArea[index]).contains(anchor))
          anchor1 = anchor;
        categoryPlot.draw(g2, this.subplotArea[index], anchor1, parentState, plotRenderingInfo);
      }
      if (info == null)
        return;
      info.setDataArea(rectangle2D);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 25, (byte) 135, (byte) 108, (byte) 104, (byte) 108, (byte) 103, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setOrientation(PlotOrientation orientation)
    {
      base.setOrientation(orientation);
      Iterator iterator = this.subplots.iterator();
      while (iterator.hasNext())
        ((CategoryPlot) iterator.next()).setOrientation(orientation);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 49, (byte) 98, (byte) 104, (byte) 108, (byte) 104, (byte) 108, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Range getDataRange(ValueAxis axis)
    {
      Range range1 = (Range) null;
      if (this.subplots != null)
      {
        Iterator iterator = this.subplots.iterator();
        while (iterator.hasNext())
        {
          CategoryPlot categoryPlot = (CategoryPlot) iterator.next();
          range1 = Range.combine(range1, categoryPlot.getDataRange(axis));
        }
      }
      return range1;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 66, (byte) 103, (byte) 99, (byte) 102, (byte) 104, (byte) 108, (byte) 104, (byte) 108, (byte) 103, (byte) 103, (byte) 162})]
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
            LegendItemCollection legendItems = ((CategoryPlot) iterator.next()).getLegendItems();
            legendItemCollection.addAll(legendItems);
          }
        }
      }
      return legendItemCollection;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 105, (byte) 103, (byte) 108, (byte) 112, (byte) 114, (byte) 104, (byte) 233, (byte) 61, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void handleClick(int x, int y, PlotRenderingInfo info)
    {
      if (!info.getDataArea().contains((double) x, (double) y))
        return;
      for (int index = 0; index < this.subplots.size(); ++index)
      {
        CategoryPlot categoryPlot = (CategoryPlot) this.subplots.get(index);
        PlotRenderingInfo subplotInfo = info.getSubplotInfo(index);
        categoryPlot.handleClick(x, y, subplotInfo);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 123, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void plotChanged(PlotChangeEvent @event)
    {
      this.notifyListeners(@event);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 134, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CombinedRangeCategoryPlot))
        return false;
      CombinedRangeCategoryPlot rangeCategoryPlot = (CombinedRangeCategoryPlot) obj;
      if (this.gap != rangeCategoryPlot.gap || !ObjectUtilities.equal((object) this.subplots, (object) rangeCategoryPlot.subplots))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 159, (byte) 140, (byte) 118, (byte) 116, (byte) 108, (byte) 103, (byte) 194, (byte) 103, (byte) 99, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      CombinedRangeCategoryPlot rangeCategoryPlot = (CombinedRangeCategoryPlot) base.clone();
      rangeCategoryPlot.subplots = (List) ObjectUtilities.deepClone((Collection) this.subplots);
      Iterator iterator = rangeCategoryPlot.subplots.iterator();
      while (iterator.hasNext())
        ((Plot) iterator.next()).setParent((Plot) rangeCategoryPlot);
      ValueAxis rangeAxis = rangeCategoryPlot.getRangeAxis();
      if (rangeAxis != null)
        rangeAxis.configure();
      return (object) rangeCategoryPlot;
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 188, (byte) 198, (byte) 103, (byte) 99, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      ValueAxis rangeAxis = this.getRangeAxis();
      if (rangeAxis == null)
        return;
      rangeAxis.configure();
    }
  }
}
