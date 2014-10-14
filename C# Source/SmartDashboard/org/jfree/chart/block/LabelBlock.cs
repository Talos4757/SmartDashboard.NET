// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.LabelBlock
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart.entity;
using org.jfree.io;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.block
{
  [Implements(new string[] {"org.jfree.chart.block.Block", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class LabelBlock : AbstractBlock, Block, Drawable, PublicCloneable, Cloneable.__Interface
  {
    internal static Paint __\u003C\u003EDEFAULT_PAINT = (Paint) Color.black;
    internal const long serialVersionUID = 249626098864178017L;
    private string text;
    private TextBlock label;
    private Font font;
    private string toolTipText;
    private string urlText;
    [NonSerialized]
    private Paint paint;
    private TextBlockAnchor contentAlignmentPoint;
    private RectangleAnchor textAnchor;

    [Modifiers]
    public static Paint DEFAULT_PAINT
    {
      [HideFromJava] get
      {
        return LabelBlock.__\u003C\u003EDEFAULT_PAINT;
      }
    }

    [LineNumberTable((ushort) 104)]
    static LabelBlock()
    {
    }

    [LineNumberTable(new byte[] {(byte) 99, (byte) 104, (byte) 103, (byte) 103, (byte) 115, (byte) 103, (byte) 103, (byte) 103, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LabelBlock(string text, Font font, Paint paint)
    {
      LabelBlock labelBlock = this;
      this.text = text;
      this.paint = paint;
      this.label = TextUtilities.createTextBlock(text, font, this.paint);
      this.font = font;
      this.toolTipText = (string) null;
      this.urlText = (string) null;
      this.contentAlignmentPoint = TextBlockAnchor.__\u003C\u003ECENTER;
      this.textAnchor = RectangleAnchor.__\u003C\u003ECENTER;
    }

    [LineNumberTable(new byte[] {(byte) 79, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LabelBlock(string label)
      : this(label, new Font("SansSerif", 0, 10), LabelBlock.__\u003C\u003EDEFAULT_PAINT)
    {
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LabelBlock(string text, Font font)
      : this(text, font, LabelBlock.__\u003C\u003EDEFAULT_PAINT)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LabelBlock([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] LabelBlock obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 99, (byte) 144, (byte) 103, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.font = font;
        this.label = TextUtilities.createTextBlock(this.text, font, this.paint);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 91, (byte) 99, (byte) 144, (byte) 103, (byte) 157})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.paint = paint;
        this.label = TextUtilities.createTextBlock(this.text, this.font, this.paint);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 227, (byte) 105, (byte) 104, (byte) 105, (byte) 169, (byte) 98, (byte) 98, (byte) 98, (byte) 104, (byte) 103, (byte) 104, (byte) 102, (byte) 172, (byte) 108, (byte) 108, (byte) 109, (byte) 159, (byte) 1, (byte) 99, (byte) 102, (byte) 112, (byte) 148, (byte) 104, (byte) 103, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object draw(Graphics2D g2, Rectangle2D area, object @params)
    {
      area = this.trimMargin(area);
      this.drawBorder(g2, area);
      area = this.trimBorder(area);
      area = this.trimPadding(area);
      EntityBlockParams entityBlockParams = (EntityBlockParams) null;
      StandardEntityCollection entityCollection = (StandardEntityCollection) null;
      Shape area1 = (Shape) null;
      if (@params is EntityBlockParams)
      {
        entityBlockParams = (EntityBlockParams) @params;
        if (entityBlockParams.getGenerateEntities())
        {
          entityCollection = new StandardEntityCollection();
          area1 = (Shape) ((RectangularShape) area).clone();
        }
      }
      g2.setPaint(this.paint);
      ((Graphics) g2).setFont(this.font);
      Point2D point2D = RectangleAnchor.coordinates(area, this.textAnchor);
      this.label.draw(g2, (float) point2D.getX(), (float) point2D.getY(), this.contentAlignmentPoint);
      BlockResult blockResult = (BlockResult) null;
      if (entityBlockParams != null && entityCollection != null && (this.toolTipText != null || this.urlText != null))
      {
        ChartEntity entity = new ChartEntity(area1, this.toolTipText, this.urlText);
        entityCollection.add(entity);
        blockResult = new BlockResult();
        blockResult.setEntityCollection((EntityCollection) entityCollection);
      }
      return (object) blockResult;
    }

    public virtual Font getFont()
    {
      return this.font;
    }

    public virtual Paint getPaint()
    {
      return this.paint;
    }

    public virtual string getToolTipText()
    {
      return this.toolTipText;
    }

    public virtual void setToolTipText(string text)
    {
      this.toolTipText = text;
    }

    public virtual string getURLText()
    {
      return this.urlText;
    }

    public virtual void setURLText(string text)
    {
      this.urlText = text;
    }

    public virtual TextBlockAnchor getContentAlignmentPoint()
    {
      return this.contentAlignmentPoint;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 163, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setContentAlignmentPoint(TextBlockAnchor anchor)
    {
      if (anchor == null)
      {
        string str = "Null 'anchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.contentAlignmentPoint = anchor;
    }

    public virtual RectangleAnchor getTextAnchor()
    {
      return this.textAnchor;
    }

    public virtual void setTextAnchor(RectangleAnchor anchor)
    {
      this.textAnchor = anchor;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 201, (byte) 108, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Size2D arrange(Graphics2D g2, RectangleConstraint constraint)
    {
      ((Graphics) g2).setFont(this.font);
      Size2D size2D = this.label.calculateDimensions(g2);
      return new Size2D(this.calculateTotalWidth(size2D.getWidth()), this.calculateTotalHeight(size2D.getHeight()));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 214, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, Rectangle2D area)
    {
      this.draw(g2, area, (object) null);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 14, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (!(obj is LabelBlock))
        return false;
      LabelBlock labelBlock = (LabelBlock) obj;
      if (!String.instancehelper_equals(this.text, (object) labelBlock.text) || !this.font.equals((object) labelBlock.font) || (!PaintUtilities.equal(this.paint, labelBlock.paint) || !ObjectUtilities.equal((object) this.toolTipText, (object) labelBlock.toolTipText)) || (!ObjectUtilities.equal((object) this.urlText, (object) labelBlock.urlText) || !this.contentAlignmentPoint.equals((object) labelBlock.contentAlignmentPoint) || !this.textAnchor.equals((object) labelBlock.textAnchor)))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 420)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 61, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.paint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 75, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.paint = SerialUtilities.readPaint(obj0);
    }
  }
}
