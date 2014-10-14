// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.title.LegendTitle
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.@event;
using org.jfree.chart.block;
using org.jfree.chart.entity;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.title
{
  [Implements(new string[] {"java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class LegendTitle : Title, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 2644010518533854633L;
    internal static Font __\u003C\u003EDEFAULT_ITEM_FONT;
    internal static Paint __\u003C\u003EDEFAULT_ITEM_PAINT;
    private LegendItemSource[] sources;
    [NonSerialized]
    private Paint backgroundPaint;
    private RectangleEdge legendItemGraphicEdge;
    private RectangleAnchor legendItemGraphicAnchor;
    private RectangleAnchor legendItemGraphicLocation;
    private RectangleInsets legendItemGraphicPadding;
    private Font itemFont;
    [NonSerialized]
    private Paint itemPaint;
    private RectangleInsets itemLabelPadding;
    private BlockContainer items;
    private Arrangement hLayout;
    private Arrangement vLayout;
    private BlockContainer wrapper;

    [Modifiers]
    public static Font DEFAULT_ITEM_FONT
    {
      [HideFromJava] get
      {
        return LegendTitle.__\u003C\u003EDEFAULT_ITEM_FONT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_ITEM_PAINT
    {
      [HideFromJava] get
      {
        return LegendTitle.__\u003C\u003EDEFAULT_ITEM_PAINT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 114, (byte) 133, (byte) 210})]
    static LegendTitle()
    {
      Title.__\u003Cclinit\u003E();
      LegendTitle.__\u003C\u003EDEFAULT_ITEM_FONT = new Font("SansSerif", 0, 12);
      LegendTitle.__\u003C\u003EDEFAULT_ITEM_PAINT = (Paint) Color.black;
    }

    [LineNumberTable(new byte[] {(byte) 126, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendTitle(LegendItemSource source)
      : this(source, (Arrangement) new FlowArrangement(), (Arrangement) new ColumnArrangement())
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 75, (byte) 104, (byte) 112, (byte) 108, (byte) 103, (byte) 103, (byte) 103, (byte) 107, (byte) 107, (byte) 107, (byte) 127, (byte) 16, (byte) 107, (byte) 107, (byte) 127, (byte) 16})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LegendTitle(LegendItemSource source, Arrangement hLayout, Arrangement vLayout)
    {
      LegendTitle legendTitle = this;
      LegendItemSource[] legendItemSourceArray = new LegendItemSource[1];
      int index = 0;
      LegendItemSource legendItemSource = source;
      legendItemSourceArray[index] = legendItemSource;
      this.sources = legendItemSourceArray;
      this.items = new BlockContainer(hLayout);
      this.hLayout = hLayout;
      this.vLayout = vLayout;
      this.backgroundPaint = (Paint) null;
      this.legendItemGraphicEdge = RectangleEdge.__\u003C\u003ELEFT;
      this.legendItemGraphicAnchor = RectangleAnchor.__\u003C\u003ECENTER;
      this.legendItemGraphicLocation = RectangleAnchor.__\u003C\u003ECENTER;
      this.legendItemGraphicPadding = new RectangleInsets(2.0, 2.0, 2.0, 2.0);
      this.itemFont = LegendTitle.__\u003C\u003EDEFAULT_ITEM_FONT;
      this.itemPaint = LegendTitle.__\u003C\u003EDEFAULT_ITEM_PAINT;
      this.itemLabelPadding = new RectangleInsets(2.0, 2.0, 2.0, 2.0);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LegendTitle([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] LegendTitle obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] LegendTitle obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 129, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackgroundPaint(Paint paint)
    {
      this.backgroundPaint = paint;
      this.notifyListeners(new TitleChangeEvent((Title) this));
    }

    public virtual Paint getBackgroundPaint()
    {
      return this.backgroundPaint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 233, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.itemFont = font;
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 255, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.itemPaint = paint;
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    public virtual BlockContainer getWrapper()
    {
      return this.wrapper;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 60, (byte) 98, (byte) 146, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 140, (byte) 183, (byte) 108, (byte) 108, (byte) 109, (byte) 103, (byte) 99, (byte) 135, (byte) 103, (byte) 99, (byte) 135, (byte) 148, (byte) 109, (byte) 104, (byte) 108, (byte) 140, (byte) 108, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Block createLegendItemBlock(LegendItem item)
    {
      LegendGraphic legendGraphic = new LegendGraphic(item.getShape(), item.getFillPaint());
      legendGraphic.setFillPaintTransformer(item.getFillPaintTransformer());
      legendGraphic.setShapeFilled(item.isShapeFilled());
      legendGraphic.setLine(item.getLine());
      legendGraphic.setLineStroke(item.getLineStroke());
      legendGraphic.setLinePaint(item.getLinePaint());
      legendGraphic.setLineVisible(item.isLineVisible());
      legendGraphic.setShapeVisible(item.isShapeVisible());
      legendGraphic.setShapeOutlineVisible(item.isShapeOutlineVisible());
      legendGraphic.setOutlinePaint(item.getOutlinePaint());
      legendGraphic.setOutlineStroke(item.getOutlineStroke());
      legendGraphic.setPadding(this.legendItemGraphicPadding);
      LegendItemBlockContainer itemBlockContainer = new LegendItemBlockContainer((Arrangement) new BorderArrangement(), item.getDataset(), item.getSeriesKey());
      legendGraphic.setShapeAnchor(this.getLegendItemGraphicAnchor());
      legendGraphic.setShapeLocation(this.getLegendItemGraphicLocation());
      itemBlockContainer.add((Block) legendGraphic, (object) this.legendItemGraphicEdge);
      Font font = item.getLabelFont() ?? this.itemFont;
      Paint paint = item.getLabelPaint() ?? this.itemPaint;
      LabelBlock.__\u003Cclinit\u003E();
      LabelBlock labelBlock = new LabelBlock(item.getLabel(), font, paint);
      labelBlock.setPadding(this.itemLabelPadding);
      itemBlockContainer.add((Block) labelBlock);
      itemBlockContainer.setToolTipText(item.getToolTipText());
      itemBlockContainer.setURLText(item.getURLText());
      BlockContainer blockContainer = new BlockContainer((Arrangement) new CenterArrangement());
      blockContainer.add((Block) itemBlockContainer);
      return (Block) blockContainer;
    }

    public virtual RectangleAnchor getLegendItemGraphicAnchor()
    {
      return this.legendItemGraphicAnchor;
    }

    public virtual RectangleAnchor getLegendItemGraphicLocation()
    {
      return this.legendItemGraphicLocation;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 32, (byte) 107, (byte) 103, (byte) 104, (byte) 179, (byte) 145, (byte) 111, (byte) 110, (byte) 99, (byte) 107, (byte) 105, (byte) 106, (byte) 237, (byte) 61, (byte) 230, (byte) 61, (byte) 233, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void fetchLegendItems()
    {
      this.items.clear();
      if (RectangleEdge.isTopOrBottom(this.getPosition()))
        this.items.setArrangement(this.hLayout);
      else
        this.items.setArrangement(this.vLayout);
      for (int index1 = 0; index1 < this.sources.Length; ++index1)
      {
        LegendItemCollection legendItems = this.sources[index1].getLegendItems();
        if (legendItems != null)
        {
          for (int index2 = 0; index2 < legendItems.getItemCount(); ++index2)
            this.items.add(this.createLegendItemBlock(legendItems.get(index2)));
        }
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 159, (byte) 108, (byte) 108, (byte) 98, (byte) 149, (byte) 102, (byte) 141, (byte) 104, (byte) 104, (byte) 108, (byte) 135, (byte) 103, (byte) 104, (byte) 108, (byte) 104, (byte) 100, (byte) 136, (byte) 104, (byte) 108, (byte) 105, (byte) 110, (byte) 103, (byte) 104, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object draw(Graphics2D g2, Rectangle2D area, object @params)
    {
      Rectangle2D area1 = (Rectangle2D) ((RectangularShape) area).clone();
      Rectangle2D rectangle2D1 = (Rectangle2D) ((RectangularShape) area).clone();
      StandardEntityCollection entityCollection1 = (StandardEntityCollection) null;
      if (@params is EntityBlockParams && ((EntityBlockParams) @params).getGenerateEntities())
      {
        entityCollection1 = new StandardEntityCollection();
        entityCollection1.add((ChartEntity) new TitleEntity((Shape) rectangle2D1, (Title) this));
      }
      Rectangle2D rectangle2D2 = this.trimMargin(area1);
      if (this.backgroundPaint != null)
      {
        g2.setPaint(this.backgroundPaint);
        g2.fill((Shape) rectangle2D2);
      }
      BlockFrame frame = this.getFrame();
      frame.draw(g2, rectangle2D2);
      frame.getInsets().trim(rectangle2D2);
      BlockContainer blockContainer = this.wrapper ?? this.items;
      Rectangle2D area2 = this.trimPadding(rectangle2D2);
      object obj = blockContainer.draw(g2, area2, @params);
      if (obj is BlockResult)
      {
        EntityCollection entityCollection2 = ((BlockResult) obj).getEntityCollection();
        if (entityCollection2 != null && entityCollection1 != null)
        {
          entityCollection1.addAll(entityCollection2);
          ((BlockResult) obj).setEntityCollection((EntityCollection) entityCollection1);
        }
      }
      return obj;
    }

    public virtual LegendItemSource[] getSources()
    {
      return this.sources;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 106, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSources(LegendItemSource[] sources)
    {
      if (sources == null)
      {
        string str = "Null 'sources' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.sources = sources;
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    public virtual RectangleEdge getLegendItemGraphicEdge()
    {
      return this.legendItemGraphicEdge;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 148, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendItemGraphicEdge(RectangleEdge edge)
    {
      if (edge == null)
      {
        string str = "Null 'edge' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.legendItemGraphicEdge = edge;
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 170, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendItemGraphicAnchor(RectangleAnchor anchor)
    {
      if (anchor == null)
      {
        string str = "Null 'anchor' point.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.legendItemGraphicAnchor = anchor;
    }

    public virtual void setLegendItemGraphicLocation(RectangleAnchor anchor)
    {
      this.legendItemGraphicLocation = anchor;
    }

    public virtual RectangleInsets getLegendItemGraphicPadding()
    {
      return this.legendItemGraphicPadding;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 210, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLegendItemGraphicPadding(RectangleInsets padding)
    {
      if (padding == null)
      {
        string str = "Null 'padding' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.legendItemGraphicPadding = padding;
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    public virtual Font getItemFont()
    {
      return this.itemFont;
    }

    public virtual Paint getItemPaint()
    {
      return this.itemPaint;
    }

    public virtual RectangleInsets getItemLabelPadding()
    {
      return this.itemLabelPadding;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 21, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setItemLabelPadding(RectangleInsets padding)
    {
      if (padding == null)
      {
        string str = "Null 'padding' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.itemLabelPadding = padding;
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    public virtual BlockContainer getItemContainer()
    {
      return this.items;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 121, (byte) 102, (byte) 102, (byte) 109, (byte) 130, (byte) 103, (byte) 99, (byte) 135, (byte) 104, (byte) 105, (byte) 115, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Size2D arrange(Graphics2D g2, RectangleConstraint constraint)
    {
      Size2D size2D1 = new Size2D();
      this.fetchLegendItems();
      if (this.items.isEmpty())
        return size2D1;
      BlockContainer blockContainer = this.wrapper ?? this.items;
      RectangleConstraint constraint1 = this.toContentConstraint(constraint);
      Size2D size2D2 = blockContainer.arrange(g2, constraint1);
      size2D1.height = this.calculateTotalHeight(size2D2.height);
      size2D1.width = this.calculateTotalWidth(size2D2.width);
      return size2D1;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 145, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area)
    {
      this.draw(g2, area, (object) null);
    }

    public virtual void setWrapper(BlockContainer wrapper)
    {
      this.wrapper = wrapper;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 219, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is LegendTitle) || !base.equals(obj))
        return false;
      LegendTitle legendTitle = (LegendTitle) obj;
      return PaintUtilities.equal(this.backgroundPaint, legendTitle.backgroundPaint) && this.legendItemGraphicEdge == legendTitle.legendItemGraphicEdge && (this.legendItemGraphicAnchor == legendTitle.legendItemGraphicAnchor && this.legendItemGraphicLocation == legendTitle.legendItemGraphicLocation) && (this.itemFont.equals((object) legendTitle.itemFont) && Object.instancehelper_equals((object) this.itemPaint, (object) legendTitle.itemPaint) && (Object.instancehelper_equals((object) this.hLayout, (object) legendTitle.hLayout) && Object.instancehelper_equals((object) this.vLayout, (object) legendTitle.vLayout)));
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 8, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.backgroundPaint, obj0);
      SerialUtilities.writePaint(this.itemPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 23, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.backgroundPaint = SerialUtilities.readPaint(obj0);
      this.itemPaint = SerialUtilities.readPaint(obj0);
    }
  }
}
