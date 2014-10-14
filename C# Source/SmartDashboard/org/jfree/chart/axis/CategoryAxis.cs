// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.CategoryAxis
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart.@event;
using org.jfree.chart.entity;
using org.jfree.chart.plot;
using org.jfree.data.category;
using org.jfree.io;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class CategoryAxis : Axis, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = 5886554608114265863L;
    public const double DEFAULT_AXIS_MARGIN = 0.05;
    public const double DEFAULT_CATEGORY_MARGIN = 0.2;
    private double lowerMargin;
    private double upperMargin;
    private double categoryMargin;
    private int maximumCategoryLabelLines;
    private float maximumCategoryLabelWidthRatio;
    private int categoryLabelPositionOffset;
    private CategoryLabelPositions categoryLabelPositions;
    private Map tickLabelFontMap;
    [NonSerialized]
    private Map tickLabelPaintMap;
    private Map categoryLabelToolTips;

    [HideFromJava]
    static CategoryAxis()
    {
      Axis.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 92, (byte) 137, (byte) 112, (byte) 112, (byte) 112, (byte) 103, (byte) 139, (byte) 103, (byte) 107, (byte) 107, (byte) 107, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryAxis(string label)
      : base(label)
    {
      CategoryAxis categoryAxis = this;
      this.lowerMargin = 0.05;
      this.upperMargin = 0.05;
      this.categoryMargin = 0.2;
      this.maximumCategoryLabelLines = 1;
      this.maximumCategoryLabelWidthRatio = 0.0f;
      this.categoryLabelPositionOffset = 4;
      this.categoryLabelPositions = CategoryLabelPositions.__\u003C\u003ESTANDARD;
      this.tickLabelFontMap = (Map) new HashMap();
      this.tickLabelPaintMap = (Map) new HashMap();
      this.categoryLabelToolTips = (Map) new HashMap();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 82, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryAxis()
      : this((string) null)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CategoryAxis([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CategoryAxis obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CategoryAxis obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 182, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCategoryMargin(double margin)
    {
      this.categoryMargin = margin;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 198, (byte) 102, (byte) 104, (byte) 144, (byte) 104, (byte) 144, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getCategoryJava2DCoordinate(CategoryAnchor anchor, int category, int categoryCount, Rectangle2D area, RectangleEdge edge)
    {
      double num = 0.0;
      if (anchor == CategoryAnchor.__\u003C\u003ESTART)
        num = this.getCategoryStart(category, categoryCount, area, edge);
      else if (anchor == CategoryAnchor.__\u003C\u003EMIDDLE)
        num = this.getCategoryMiddle(category, categoryCount, area, edge);
      else if (anchor == CategoryAnchor.__\u003C\u003EEND)
        num = this.getCategoryEnd(category, categoryCount, area, edge);
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 7, (byte) 104, (byte) 191, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getCategoryMiddle(int category, int categoryCount, Rectangle2D area, RectangleEdge edge)
    {
      if (category >= 0 && category < categoryCount)
        return this.getCategoryStart(category, categoryCount, area, edge) + this.calculateCategorySize(categoryCount, area, edge) / 2.0;
      string str = new StringBuffer().append("Invalid category index: ").append(category).toString();
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 229, (byte) 102, (byte) 114, (byte) 152, (byte) 146, (byte) 182, (byte) 108, (byte) 172, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getCategoryStart(int category, int categoryCount, Rectangle2D area, RectangleEdge edge)
    {
      double num1 = 0.0;
      if (edge == RectangleEdge.__\u003C\u003ETOP || edge == RectangleEdge.__\u003C\u003EBOTTOM)
        num1 = ((RectangularShape) area).getX() + ((RectangularShape) area).getWidth() * this.getLowerMargin();
      else if (edge == RectangleEdge.__\u003C\u003ELEFT || edge == RectangleEdge.__\u003C\u003ERIGHT)
        num1 = ((RectangularShape) area).getMinY() + ((RectangularShape) area).getHeight() * this.getLowerMargin();
      double num2 = this.calculateCategorySize(categoryCount, area, edge);
      double num3 = this.calculateCategoryGapSize(categoryCount, area, edge);
      return num1 + (double) category * (num2 + num3);
    }

    [LineNumberTable((ushort) 658)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getCategoryEnd(int category, int categoryCount, Rectangle2D area, RectangleEdge edge)
    {
      return this.getCategoryStart(category, categoryCount, area, edge) + this.calculateCategorySize(categoryCount, area, edge);
    }

    public virtual double getLowerMargin()
    {
      return this.lowerMargin;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 148, (byte) 102, (byte) 134, (byte) 112, (byte) 138, (byte) 144, (byte) 136, (byte) 100, (byte) 158, (byte) 168, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double calculateCategorySize(int categoryCount, Rectangle2D area, RectangleEdge edge)
    {
      double num = 0.0;
      if (edge == RectangleEdge.__\u003C\u003ETOP || edge == RectangleEdge.__\u003C\u003EBOTTOM)
        num = ((RectangularShape) area).getWidth();
      else if (edge == RectangleEdge.__\u003C\u003ELEFT || edge == RectangleEdge.__\u003C\u003ERIGHT)
        num = ((RectangularShape) area).getHeight();
      return categoryCount <= 1 ? num * (1.0 - this.getLowerMargin() - this.getUpperMargin()) : num * (1.0 - this.getLowerMargin() - this.getUpperMargin() - this.getCategoryMargin()) / (double) categoryCount;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 184, (byte) 102, (byte) 134, (byte) 112, (byte) 138, (byte) 144, (byte) 168, (byte) 100, (byte) 175})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double calculateCategoryGapSize(int categoryCount, Rectangle2D area, RectangleEdge edge)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      if (edge == RectangleEdge.__\u003C\u003ETOP || edge == RectangleEdge.__\u003C\u003EBOTTOM)
        num2 = ((RectangularShape) area).getWidth();
      else if (edge == RectangleEdge.__\u003C\u003ELEFT || edge == RectangleEdge.__\u003C\u003ERIGHT)
        num2 = ((RectangularShape) area).getHeight();
      if (categoryCount > 1)
        num1 = num2 * this.getCategoryMargin() / (double) (categoryCount - 1);
      return num1;
    }

    public virtual double getUpperMargin()
    {
      return this.upperMargin;
    }

    public virtual double getCategoryMargin()
    {
      return this.categoryMargin;
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 225, (byte) 166, (byte) 122, (byte) 162, (byte) 108, (byte) 104, (byte) 134, (byte) 102, (byte) 143, (byte) 104, (byte) 106, (byte) 169, (byte) 102, (byte) 110, (byte) 212, (byte) 105, (byte) 171, (byte) 169, (byte) 99, (byte) 104, (byte) 108, (byte) 110, (byte) 110, (byte) 115, (byte) 114, (byte) 181, (byte) 146, (byte) 179, (byte) 191, (byte) 1, (byte) 105, (byte) 102, (byte) 133, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override List refreshTicks(Graphics2D g2, AxisState state, Rectangle2D dataArea, RectangleEdge edge)
    {
      ArrayList arrayList = new ArrayList();
      if (((RectangularShape) dataArea).getHeight() <= 0.0 || ((RectangularShape) dataArea).getWidth() < 0.0)
        return (List) arrayList;
      List categoriesForAxis = ((CategoryPlot) this.getPlot()).getCategoriesForAxis(this);
      double max = 0.0;
      if (categoriesForAxis != null)
      {
        CategoryLabelPosition labelPosition = this.categoryLabelPositions.getLabelPosition(edge);
        float num1 = this.maximumCategoryLabelWidthRatio;
        if ((double) num1 <= 0.0)
          num1 = labelPosition.getWidthRatio();
        float num2 = labelPosition.getWidthType() != CategoryLabelWidthType.__\u003C\u003ECATEGORY ? (!RectangleEdge.isLeftOrRight(edge) ? (float) ((RectangularShape) dataArea).getHeight() : (float) ((RectangularShape) dataArea).getWidth()) : (float) this.calculateCategorySize(categoriesForAxis.size(), dataArea, edge);
        int num3 = 0;
        Iterator iterator = categoriesForAxis.iterator();
        while (iterator.hasNext())
        {
          IComparable category = (IComparable) iterator.next();
          ((Graphics) g2).setFont(this.getTickLabelFont(category));
          TextBlock label = this.createLabel(category, num2 * num1, edge, g2);
          if (edge == RectangleEdge.__\u003C\u003ETOP || edge == RectangleEdge.__\u003C\u003EBOTTOM)
            max = Math.max(max, this.calculateTextBlockHeight(label, labelPosition, g2));
          else if (edge == RectangleEdge.__\u003C\u003ELEFT || edge == RectangleEdge.__\u003C\u003ERIGHT)
            max = Math.max(max, this.calculateTextBlockWidth(label, labelPosition, g2));
          CategoryTick categoryTick = new CategoryTick(category, label, labelPosition.getLabelAnchor(), labelPosition.getRotationAnchor(), labelPosition.getAngle());
          ((List) arrayList).add((object) categoryTick);
          ++num3;
        }
      }
      state.setMax(max);
      return (List) arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 36, (byte) 103, (byte) 99, (byte) 129, (byte) 103, (byte) 104, (byte) 104, (byte) 103, (byte) 105, (byte) 108, (byte) 108, (byte) 113, (byte) 105, (byte) 105, (byte) 110, (byte) 112, (byte) 113, (byte) 104, (byte) 113, (byte) 104, (byte) 98, (byte) 104, (byte) 101, (byte) 113, (byte) 105, (byte) 105, (byte) 110, (byte) 112, (byte) 113, (byte) 104, (byte) 113, (byte) 104, (byte) 98, (byte) 104, (byte) 101, (byte) 113, (byte) 105, (byte) 105, (byte) 110, (byte) 112, (byte) 113, (byte) 104, (byte) 113, (byte) 104, (byte) 98, (byte) 104, (byte) 101, (byte) 113, (byte) 105, (byte) 105, (byte) 110, (byte) 112, (byte) 113, (byte) 104, (byte) 113, (byte) 104, (byte) 98, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void drawTickMarks(Graphics2D g2, double cursor, Rectangle2D dataArea, RectangleEdge edge, AxisState state)
    {
      Plot plot = this.getPlot();
      if (plot == null)
        return;
      CategoryPlot categoryPlot = (CategoryPlot) plot;
      double num = (double) this.getTickMarkInsideLength();
      double units = (double) this.getTickMarkOutsideLength();
      Line2D.Double @double = new Line2D.Double();
      List categoriesForAxis = categoryPlot.getCategoriesForAxis(this);
      g2.setPaint(this.getTickMarkPaint());
      g2.setStroke(this.getTickMarkStroke());
      if (edge.equals((object) RectangleEdge.__\u003C\u003ETOP))
      {
        Iterator iterator = categoriesForAxis.iterator();
        while (iterator.hasNext())
        {
          double categoryMiddle = this.getCategoryMiddle((IComparable) iterator.next(), categoriesForAxis, dataArea, edge);
          ((Line2D) @double).setLine(categoryMiddle, cursor, categoryMiddle, cursor + num);
          g2.draw((Shape) @double);
          ((Line2D) @double).setLine(categoryMiddle, cursor, categoryMiddle, cursor - units);
          g2.draw((Shape) @double);
        }
        state.cursorUp(units);
      }
      else if (edge.equals((object) RectangleEdge.__\u003C\u003EBOTTOM))
      {
        Iterator iterator = categoriesForAxis.iterator();
        while (iterator.hasNext())
        {
          double categoryMiddle = this.getCategoryMiddle((IComparable) iterator.next(), categoriesForAxis, dataArea, edge);
          ((Line2D) @double).setLine(categoryMiddle, cursor, categoryMiddle, cursor - num);
          g2.draw((Shape) @double);
          ((Line2D) @double).setLine(categoryMiddle, cursor, categoryMiddle, cursor + units);
          g2.draw((Shape) @double);
        }
        state.cursorDown(units);
      }
      else if (edge.equals((object) RectangleEdge.__\u003C\u003ELEFT))
      {
        Iterator iterator = categoriesForAxis.iterator();
        while (iterator.hasNext())
        {
          double categoryMiddle = this.getCategoryMiddle((IComparable) iterator.next(), categoriesForAxis, dataArea, edge);
          ((Line2D) @double).setLine(cursor, categoryMiddle, cursor + num, categoryMiddle);
          g2.draw((Shape) @double);
          ((Line2D) @double).setLine(cursor, categoryMiddle, cursor - units, categoryMiddle);
          g2.draw((Shape) @double);
        }
        state.cursorLeft(units);
      }
      else
      {
        if (!edge.equals((object) RectangleEdge.__\u003C\u003ERIGHT))
          return;
        Iterator iterator = categoriesForAxis.iterator();
        while (iterator.hasNext())
        {
          double categoryMiddle = this.getCategoryMiddle((IComparable) iterator.next(), categoriesForAxis, dataArea, edge);
          ((Line2D) @double).setLine(cursor, categoryMiddle, cursor - num, categoryMiddle);
          g2.draw((Shape) @double);
          ((Line2D) @double).setLine(cursor, categoryMiddle, cursor + units, categoryMiddle);
          g2.draw((Shape) @double);
        }
        state.cursorRight(units);
      }
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 110, (byte) 100, (byte) 176, (byte) 107, (byte) 109, (byte) 136, (byte) 98, (byte) 103, (byte) 139, (byte) 108, (byte) 114, (byte) 146, (byte) 143, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 105, (byte) 147, (byte) 147, (byte) 114, (byte) 146, (byte) 105, (byte) 147, (byte) 147, (byte) 114, (byte) 146, (byte) 105, (byte) 147, (byte) 147, (byte) 114, (byte) 143, (byte) 105, (byte) 147, (byte) 147, (byte) 114, (byte) 141, (byte) 149, (byte) 144, (byte) 104, (byte) 223, (byte) 23, (byte) 223, (byte) 25, (byte) 109, (byte) 142, (byte) 100, (byte) 142, (byte) 215, (byte) 100, (byte) 133, (byte) 110, (byte) 114, (byte) 105, (byte) 101, (byte) 110, (byte) 114, (byte) 105, (byte) 98, (byte) 105, (byte) 114, (byte) 105, (byte) 98, (byte) 105, (byte) 114, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual AxisState drawCategoryLabels(Graphics2D g2, Rectangle2D plotArea, Rectangle2D dataArea, RectangleEdge edge, AxisState state, PlotRenderingInfo plotState)
    {
      if (state == null)
      {
        string str = "Null 'state' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (this.isTickLabelsVisible())
        {
          List ticks = this.refreshTicks(g2, state, plotArea, edge);
          state.setTicks(ticks);
          int category = 0;
          Iterator iterator = ticks.iterator();
          while (iterator.hasNext())
          {
            CategoryTick categoryTick = (CategoryTick) iterator.next();
            ((Graphics) g2).setFont(this.getTickLabelFont(categoryTick.getCategory()));
            g2.setPaint(this.getTickLabelPaint(categoryTick.getCategory()));
            CategoryLabelPosition labelPosition = this.categoryLabelPositions.getLabelPosition(edge);
            double num1 = 0.0;
            double num2 = 0.0;
            double num3 = 0.0;
            double num4 = 0.0;
            if (edge == RectangleEdge.__\u003C\u003ETOP)
            {
              num1 = this.getCategoryStart(category, ticks.size(), dataArea, edge);
              num2 = this.getCategoryEnd(category, ticks.size(), dataArea, edge);
              num4 = state.getCursor() - (double) this.categoryLabelPositionOffset;
              num3 = num4 - state.getMax();
            }
            else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
            {
              num1 = this.getCategoryStart(category, ticks.size(), dataArea, edge);
              num2 = this.getCategoryEnd(category, ticks.size(), dataArea, edge);
              num3 = state.getCursor() + (double) this.categoryLabelPositionOffset;
              num4 = num3 + state.getMax();
            }
            else if (edge == RectangleEdge.__\u003C\u003ELEFT)
            {
              num3 = this.getCategoryStart(category, ticks.size(), dataArea, edge);
              num4 = this.getCategoryEnd(category, ticks.size(), dataArea, edge);
              num2 = state.getCursor() - (double) this.categoryLabelPositionOffset;
              num1 = num2 - state.getMax();
            }
            else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
            {
              num3 = this.getCategoryStart(category, ticks.size(), dataArea, edge);
              num4 = this.getCategoryEnd(category, ticks.size(), dataArea, edge);
              num1 = state.getCursor() + (double) this.categoryLabelPositionOffset;
              num2 = num1 - state.getMax();
            }
            Point2D point2D = RectangleAnchor.coordinates((Rectangle2D) new Rectangle2D.Double(num1, num3, num2 - num1, num4 - num3), labelPosition.getCategoryAnchor());
            TextBlock label = categoryTick.getLabel();
            label.draw(g2, (float) point2D.getX(), (float) point2D.getY(), labelPosition.getLabelAnchor(), (float) point2D.getX(), (float) point2D.getY(), labelPosition.getAngle());
            Shape area = label.calculateBounds(g2, (float) point2D.getX(), (float) point2D.getY(), labelPosition.getLabelAnchor(), (float) point2D.getX(), (float) point2D.getY(), labelPosition.getAngle());
            if (plotState != null && plotState.getOwner() != null)
            {
              EntityCollection entityCollection = plotState.getOwner().getEntityCollection();
              if (entityCollection != null)
              {
                string categoryLabelToolTip = this.getCategoryLabelToolTip(categoryTick.getCategory());
                entityCollection.add((ChartEntity) new CategoryLabelEntity(categoryTick.getCategory(), area, categoryLabelToolTip, (string) null));
              }
            }
            ++category;
          }
          if (edge.equals((object) RectangleEdge.__\u003C\u003ETOP))
          {
            double units = state.getMax() + (double) this.categoryLabelPositionOffset;
            state.cursorUp(units);
          }
          else if (edge.equals((object) RectangleEdge.__\u003C\u003EBOTTOM))
          {
            double units = state.getMax() + (double) this.categoryLabelPositionOffset;
            state.cursorDown(units);
          }
          else if (edge == RectangleEdge.__\u003C\u003ELEFT)
          {
            double units = state.getMax() + (double) this.categoryLabelPositionOffset;
            state.cursorLeft(units);
          }
          else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
          {
            double units = state.getMax() + (double) this.categoryLabelPositionOffset;
            state.cursorRight(units);
          }
        }
        return state;
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 41, (byte) 99, (byte) 144, (byte) 146, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Font getTickLabelFont(IComparable category)
    {
      if (category != null)
        return (Font) this.tickLabelFontMap.get((object) category) ?? base.getTickLabelFont();
      string str = "Null 'category' argument.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 84, (byte) 99, (byte) 144, (byte) 146, (byte) 99, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getTickLabelPaint(IComparable category)
    {
      if (category != null)
        return (Paint) this.tickLabelPaintMap.get((object) category) ?? base.getTickLabelPaint();
      string str = "Null 'category' argument.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 146, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getCategoryLabelToolTip(IComparable category)
    {
      if (category != null)
        return (string) this.categoryLabelToolTips.get((object) category);
      string str = "Null 'category' argument.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 109, (byte) 191, (byte) 10})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual TextBlock createLabel(IComparable category, float width, RectangleEdge edge, Graphics2D g2)
    {
      return TextUtilities.createTextBlock(Object.instancehelper_toString((object) category), this.getTickLabelFont(category), this.getTickLabelPaint(category), width, this.maximumCategoryLabelLines, (TextMeasurer) new G2TextMeasurer(g2));
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 152, (byte) 103, (byte) 104, (byte) 156, (byte) 151, (byte) 156})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double calculateTextBlockHeight(TextBlock block, CategoryLabelPosition position, Graphics2D g2)
    {
      RectangleInsets tickLabelInsets = this.getTickLabelInsets();
      Size2D size2D = block.calculateDimensions(g2);
      return ((RectangularShape) ShapeUtilities.rotateShape((Shape) new Rectangle2D.Double(0.0, 0.0, size2D.getWidth(), size2D.getHeight()), position.getAngle(), 0.0f, 0.0f).getBounds2D()).getHeight() + tickLabelInsets.getTop() + tickLabelInsets.getBottom();
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 127, (byte) 103, (byte) 104, (byte) 156, (byte) 151, (byte) 156})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double calculateTextBlockWidth(TextBlock block, CategoryLabelPosition position, Graphics2D g2)
    {
      RectangleInsets tickLabelInsets = this.getTickLabelInsets();
      Size2D size2D = block.calculateDimensions(g2);
      return ((RectangularShape) ShapeUtilities.rotateShape((Shape) new Rectangle2D.Double(0.0, 0.0, size2D.getWidth(), size2D.getHeight()), position.getAngle(), 0.0f, 0.0f).getBounds2D()).getWidth() + tickLabelInsets.getLeft() + tickLabelInsets.getRight();
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 56, (byte) 99, (byte) 144, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getCategoryMiddle(IComparable category, List categories, Rectangle2D area, RectangleEdge edge)
    {
      if (categories == null)
      {
        string str = "Null 'categories' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return this.getCategoryMiddle(categories.indexOf((object) category), categories.size(), area, edge);
    }

    [LineNumberTable(new byte[] {(byte) 165, (byte) 86, (byte) 110, (byte) 130, (byte) 103, (byte) 103, (byte) 104, (byte) 108, (byte) 108, (byte) 115, (byte) 106, (byte) 130, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool equalPaintMaps([In] Map obj0, [In] Map obj1)
    {
      if (obj0.size() != obj1.size())
        return false;
      Iterator iterator = obj0.entrySet().iterator();
      while (iterator.hasNext())
      {
        Map.Entry entry = (Map.Entry) iterator.next();
        if (!PaintUtilities.equal((Paint) entry.getValue(), (Paint) obj1.get(entry.getKey())))
          return false;
      }
      return true;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 165, (byte) 59, (byte) 99, (byte) 169, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 104, (byte) 108, (byte) 103, (byte) 114, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writePaintMap([In] Map obj0, [In] ObjectOutputStream obj1)
    {
      if (obj0 == null)
      {
        obj1.writeBoolean(true);
      }
      else
      {
        obj1.writeBoolean(false);
        Set set = obj0.keySet();
        int num = set.size();
        obj1.writeInt(num);
        Iterator iterator = set.iterator();
        while (iterator.hasNext())
        {
          IComparable comparable = (IComparable) iterator.next();
          obj1.writeObject((object) comparable);
          SerialUtilities.writePaint((Paint) obj0.get((object) comparable), obj1);
        }
      }
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 165, (byte) 32, (byte) 103, (byte) 99, (byte) 130, (byte) 102, (byte) 103, (byte) 102, (byte) 109, (byte) 104, (byte) 235, (byte) 61, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Map readPaintMap([In] ObjectInputStream obj0)
    {
      if (obj0.readBoolean())
        return (Map) null;
      HashMap hashMap = new HashMap();
      int num = obj0.readInt();
      for (int index = 0; index < num; ++index)
      {
        IComparable comparable = (IComparable) obj0.readObject();
        Paint paint = SerialUtilities.readPaint(obj0);
        ((Map) hashMap).put((object) comparable, (object) paint);
      }
      return (Map) hashMap;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 130, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLowerMargin(double margin)
    {
      this.lowerMargin = margin;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 156, (byte) 105, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setUpperMargin(double margin)
    {
      this.upperMargin = margin;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    public virtual int getMaximumCategoryLabelLines()
    {
      return this.maximumCategoryLabelLines;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 206, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaximumCategoryLabelLines(int lines)
    {
      this.maximumCategoryLabelLines = lines;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    public virtual float getMaximumCategoryLabelWidthRatio()
    {
      return this.maximumCategoryLabelWidthRatio;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 230, (byte) 104, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaximumCategoryLabelWidthRatio(float ratio)
    {
      this.maximumCategoryLabelWidthRatio = ratio;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    public virtual int getCategoryLabelPositionOffset()
    {
      return this.categoryLabelPositionOffset;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 255, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCategoryLabelPositionOffset(int offset)
    {
      this.categoryLabelPositionOffset = offset;
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    public virtual CategoryLabelPositions getCategoryLabelPositions()
    {
      return this.categoryLabelPositions;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 24, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setCategoryLabelPositions(CategoryLabelPositions positions)
    {
      if (positions == null)
      {
        string str = "Null 'positions' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.categoryLabelPositions = positions;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 62, (byte) 99, (byte) 144, (byte) 99, (byte) 175, (byte) 142, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLabelFont(IComparable category, Font font)
    {
      if (category == null)
      {
        string str = "Null 'category' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (font == null)
          this.tickLabelFontMap.remove((object) category);
        else
          this.tickLabelFontMap.put((object) category, (object) font);
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 105, (byte) 99, (byte) 144, (byte) 99, (byte) 175, (byte) 142, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTickLabelPaint(IComparable category, Paint paint)
    {
      if (category == null)
      {
        string str = "Null 'category' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (paint == null)
          this.tickLabelPaintMap.remove((object) category);
        else
          this.tickLabelPaintMap.put((object) category, (object) paint);
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 127, (byte) 99, (byte) 144, (byte) 110, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addCategoryLabelToolTip(IComparable category, string tooltip)
    {
      if (category == null)
      {
        string str = "Null 'category' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.categoryLabelToolTips.put((object) category, (object) tooltip);
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 162, (byte) 99, (byte) 144, (byte) 109, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeCategoryLabelToolTip(IComparable category)
    {
      if (category == null)
      {
        string str = "Null 'category' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.categoryLabelToolTips.remove((object) category);
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 177, (byte) 107, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clearCategoryLabelToolTips()
    {
      this.categoryLabelToolTips.clear();
      this.notifyListeners(new AxisChangeEvent((Axis) this));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 83, (byte) 104, (byte) 103, (byte) 104, (byte) 103, (byte) 143, (byte) 111, (byte) 104, (byte) 100, (byte) 176, (byte) 110, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getCategorySeriesMiddle(IComparable category, IComparable seriesKey, CategoryDataset dataset, double itemMargin, Rectangle2D area, RectangleEdge edge)
    {
      int columnIndex = dataset.getColumnIndex(category);
      int columnCount = dataset.getColumnCount();
      int rowIndex = dataset.getRowIndex(seriesKey);
      int rowCount = dataset.getRowCount();
      double categoryStart = this.getCategoryStart(columnIndex, columnCount, area, edge);
      double num1 = this.getCategoryEnd(columnIndex, columnCount, area, edge) - categoryStart;
      if (rowCount == 1)
        return categoryStart + num1 / 2.0;
      double num2 = num1 * itemMargin / (double) (rowCount - 1);
      double num3 = num1 * (1.0 - itemMargin) / (double) rowCount;
      return categoryStart + (double) rowIndex * (num3 + num2) + num3 / 2.0;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 121, (byte) 142, (byte) 110, (byte) 101, (byte) 101, (byte) 174, (byte) 109, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getCategorySeriesMiddle(int categoryIndex, int categoryCount, int seriesIndex, int seriesCount, double itemMargin, Rectangle2D area, RectangleEdge edge)
    {
      double categoryStart = this.getCategoryStart(categoryIndex, categoryCount, area, edge);
      double num1 = this.getCategoryEnd(categoryIndex, categoryCount, area, edge) - categoryStart;
      if (seriesCount == 1)
        return categoryStart + num1 / 2.0;
      double num2 = num1 * itemMargin / (double) (seriesCount - 1);
      double num3 = num1 * (1.0 - itemMargin) / (double) seriesCount;
      return categoryStart + (double) seriesIndex * (num3 + num2) + num3 / 2.0;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 219, (byte) 100, (byte) 199, (byte) 104, (byte) 195, (byte) 102, (byte) 102, (byte) 107, (byte) 108, (byte) 134, (byte) 108, (byte) 105, (byte) 138, (byte) 105, (byte) 138, (byte) 105, (byte) 138, (byte) 105, (byte) 232, (byte) 69, (byte) 106, (byte) 102, (byte) 102, (byte) 105, (byte) 105, (byte) 183, (byte) 105, (byte) 105, (byte) 181})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override AxisSpace reserveSpace(Graphics2D g2, Plot plot, Rectangle2D plotArea, RectangleEdge edge, AxisSpace space)
    {
      if (space == null)
        space = new AxisSpace();
      if (!this.isVisible())
        return space;
      double num1 = 0.0;
      double num2 = 0.0;
      if (this.isTickLabelsVisible())
      {
        ((Graphics) g2).setFont(base.getTickLabelFont());
        AxisState state = new AxisState();
        this.refreshTicks(g2, state, plotArea, edge);
        if (edge == RectangleEdge.__\u003C\u003ETOP)
          num1 = state.getMax();
        else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
          num1 = state.getMax();
        else if (edge == RectangleEdge.__\u003C\u003ELEFT)
          num2 = state.getMax();
        else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
          num2 = state.getMax();
      }
      Rectangle2D labelEnclosure = this.getLabelEnclosure(g2, edge);
      if (RectangleEdge.isTopOrBottom(edge))
      {
        double height = ((RectangularShape) labelEnclosure).getHeight();
        space.add(height + num1 + (double) this.categoryLabelPositionOffset, edge);
      }
      else if (RectangleEdge.isLeftOrRight(edge))
      {
        double width = ((RectangularShape) labelEnclosure).getWidth();
        space.add(width + num2 + (double) this.categoryLabelPositionOffset, edge);
      }
      return space;
    }

    public override void configure()
    {
    }

    [LineNumberTable(new byte[] {(byte) 163, (byte) 40, (byte) 104, (byte) 170, (byte) 104, (byte) 141, (byte) 104, (byte) 104, (byte) 206, (byte) 144, (byte) 116, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override AxisState draw(Graphics2D g2, double cursor, Rectangle2D plotArea, Rectangle2D dataArea, RectangleEdge edge, PlotRenderingInfo plotState)
    {
      if (!this.isVisible())
      {
        return new AxisState(cursor);
      }
      else
      {
        if (this.isAxisLineVisible())
          this.drawAxisLine(g2, cursor, dataArea, edge);
        AxisState state1 = new AxisState(cursor);
        if (this.isTickMarksVisible())
          this.drawTickMarks(g2, cursor, dataArea, edge, state1);
        AxisState state2 = this.drawCategoryLabels(g2, plotArea, dataArea, edge, state1, plotState);
        AxisState state3 = this.drawLabel(this.getLabel(), g2, plotArea, dataArea, edge, state2);
        this.createAndAddEntity(cursor, state3, dataArea, edge, plotState);
        return state3;
      }
    }

    [Obsolete]
    [LineNumberTable((ushort) 967)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual AxisState drawCategoryLabels(Graphics2D g2, Rectangle2D dataArea, RectangleEdge edge, AxisState state, PlotRenderingInfo plotState)
    {
      return this.drawCategoryLabels(g2, dataArea, dataArea, edge, state, plotState);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 173, (byte) 108, (byte) 113, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      CategoryAxis categoryAxis = (CategoryAxis) base.clone();
      categoryAxis.tickLabelFontMap = (Map) new HashMap(this.tickLabelFontMap);
      categoryAxis.tickLabelPaintMap = (Map) new HashMap(this.tickLabelPaintMap);
      categoryAxis.categoryLabelToolTips = (Map) new HashMap(this.categoryLabelToolTips);
      return (object) categoryAxis;
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 188, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 142, (byte) 130, (byte) 142, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 147, (byte) 130, (byte) 116, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CategoryAxis) || !base.equals(obj))
        return false;
      CategoryAxis categoryAxis = (CategoryAxis) obj;
      return categoryAxis.lowerMargin == this.lowerMargin && categoryAxis.upperMargin == this.upperMargin && (categoryAxis.categoryMargin == this.categoryMargin && (double) categoryAxis.maximumCategoryLabelWidthRatio == (double) this.maximumCategoryLabelWidthRatio) && (categoryAxis.categoryLabelPositionOffset == this.categoryLabelPositionOffset && ObjectUtilities.equal((object) categoryAxis.categoryLabelPositions, (object) this.categoryLabelPositions) && (ObjectUtilities.equal((object) categoryAxis.categoryLabelToolTips, (object) this.categoryLabelToolTips) && ObjectUtilities.equal((object) this.tickLabelFontMap, (object) categoryAxis.tickLabelFontMap))) && this.equalPaintMaps(this.tickLabelPaintMap, categoryAxis.tickLabelPaintMap);
    }

    [LineNumberTable(new byte[] {(byte) 164, (byte) 239, (byte) 104, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      if (this.getLabel() == null)
        return 0;
      return String.instancehelper_hashCode(this.getLabel());
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 164, (byte) 255, (byte) 102, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      this.writePaintMap(this.tickLabelPaintMap, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 165, (byte) 13, (byte) 102, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.tickLabelPaintMap = this.readPaintMap(obj0);
    }
  }
}
