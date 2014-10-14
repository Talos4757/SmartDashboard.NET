// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.title.TextTitle
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.chart.@event;
using org.jfree.chart.block;
using org.jfree.chart.entity;
using org.jfree.data;
using org.jfree.io;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.title
{
  [Implements(new string[] {"java.io.Serializable", "java.lang.Cloneable", "org.jfree.util.PublicCloneable"})]
  [Serializable]
  public class TextTitle : Title, Serializable.__Interface, Cloneable.__Interface, PublicCloneable
  {
    private const long serialVersionUID = 8372008692127477443L;
    internal static Font __\u003C\u003EDEFAULT_FONT;
    internal static Paint __\u003C\u003EDEFAULT_TEXT_PAINT;
    private string text;
    private Font font;
    private HorizontalAlignment textAlignment;
    [NonSerialized]
    private Paint paint;
    [NonSerialized]
    private Paint backgroundPaint;
    private string toolTipText;
    private string urlText;
    private TextBlock content;
    private bool expandToFitSpace;
    private int maximumLinesToDisplay;

    [Modifiers]
    public static Font DEFAULT_FONT
    {
      [HideFromJava] get
      {
        return TextTitle.__\u003C\u003EDEFAULT_FONT;
      }
    }

    [Modifiers]
    public static Paint DEFAULT_TEXT_PAINT
    {
      [HideFromJava] get
      {
        return TextTitle.__\u003C\u003EDEFAULT_TEXT_PAINT;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 109, (byte) 69, (byte) 210})]
    static TextTitle()
    {
      Title.__\u003Cclinit\u003E();
      TextTitle.__\u003C\u003EDEFAULT_FONT = new Font("SansSerif", 1, 12);
      TextTitle.__\u003C\u003EDEFAULT_TEXT_PAINT = (Paint) Color.black;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 86, (byte) 191, (byte) 4})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextTitle(string text, Font font)
      : this(text, font, TextTitle.__\u003C\u003EDEFAULT_TEXT_PAINT, Title.__\u003C\u003EDEFAULT_POSITION, Title.__\u003C\u003EDEFAULT_HORIZONTAL_ALIGNMENT, Title.__\u003C\u003EDEFAULT_VERTICAL_ALIGNMENT, Title.__\u003C\u003EDEFAULT_PADDING)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 74, (byte) 191, (byte) 8})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextTitle(string text)
      : this(text, TextTitle.__\u003C\u003EDEFAULT_FONT, TextTitle.__\u003C\u003EDEFAULT_TEXT_PAINT, Title.__\u003C\u003EDEFAULT_POSITION, Title.__\u003C\u003EDEFAULT_HORIZONTAL_ALIGNMENT, Title.__\u003C\u003EDEFAULT_VERTICAL_ALIGNMENT, Title.__\u003C\u003EDEFAULT_PADDING)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 65, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextTitle()
      : this("")
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 110, (byte) 240, (byte) 6, (byte) 231, (byte) 71, (byte) 235, (byte) 117, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 199, (byte) 104, (byte) 103, (byte) 103, (byte) 103, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextTitle(string text, Font font, Paint paint, RectangleEdge position, HorizontalAlignment horizontalAlignment, VerticalAlignment verticalAlignment, RectangleInsets padding)
      : base(position, horizontalAlignment, verticalAlignment, padding)
    {
      TextTitle textTitle = this;
      this.expandToFitSpace = false;
      this.maximumLinesToDisplay = int.MaxValue;
      if (text == null)
      {
        string str = "Null 'text' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        this.text = text;
        this.font = font;
        this.paint = paint;
        this.textAlignment = horizontalAlignment;
        this.backgroundPaint = (Paint) null;
        this.content = (TextBlock) null;
        this.toolTipText = (string) null;
        this.urlText = (string) null;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TextTitle([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TextTitle obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] TextTitle obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 153, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setText(string text)
    {
      if (text == null)
      {
        string str = "Null 'text' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (String.instancehelper_equals(this.text, (object) text))
          return;
        this.text = text;
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 892)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 208, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 142})]
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
        if (this.font.equals((object) font))
          return;
        this.font = font;
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 237, (byte) 99, (byte) 144, (byte) 110, (byte) 103, (byte) 142})]
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
        if (Object.instancehelper_equals((object) this.paint, (object) paint))
          return;
        this.paint = paint;
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    public virtual Font getFont()
    {
      return this.font;
    }

    public virtual string getText()
    {
      return this.text;
    }

    public virtual Paint getPaint()
    {
      return this.paint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 166, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeNN(Graphics2D g2)
    {
      Range range = new Range(0.0, 3.40282346638529E+38);
      return this.arrangeRR(g2, range, range);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 237, (byte) 104, (byte) 110, (byte) 130, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeRN(Graphics2D g2, Range widthRange)
    {
      Size2D size2D = this.arrangeNN(g2);
      if (widthRange.contains(size2D.getWidth()))
        return size2D;
      double w = widthRange.constrain(size2D.getWidth());
      return this.arrangeFN(g2, w);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 2, (byte) 103, (byte) 115, (byte) 104, (byte) 108, (byte) 191, (byte) 11, (byte) 113, (byte) 109, (byte) 104, (byte) 176, (byte) 162, (byte) 147, (byte) 104, (byte) 108, (byte) 191, (byte) 11, (byte) 113, (byte) 173, (byte) 104, (byte) 176, (byte) 212})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeRR(Graphics2D g2, Range widthRange, Range heightRange)
    {
      RectangleEdge position = this.getPosition();
      if (position == RectangleEdge.__\u003C\u003ETOP || position == RectangleEdge.__\u003C\u003EBOTTOM)
      {
        float maxWidth = (float) widthRange.getUpperBound();
        ((Graphics) g2).setFont(this.font);
        this.content = TextUtilities.createTextBlock(this.text, this.font, this.paint, maxWidth, this.maximumLinesToDisplay, (TextMeasurer) new G2TextMeasurer(g2));
        this.content.setLineAlignment(this.textAlignment);
        Size2D size2D = this.content.calculateDimensions(g2);
        if (!this.expandToFitSpace)
          return size2D;
        return new Size2D((double) maxWidth, size2D.getHeight());
      }
      else if (position == RectangleEdge.__\u003C\u003ELEFT || position == RectangleEdge.__\u003C\u003ERIGHT)
      {
        float maxWidth = (float) heightRange.getUpperBound();
        ((Graphics) g2).setFont(this.font);
        this.content = TextUtilities.createTextBlock(this.text, this.font, this.paint, maxWidth, this.maximumLinesToDisplay, (TextMeasurer) new G2TextMeasurer(g2));
        this.content.setLineAlignment(this.textAlignment);
        Size2D size2D = this.content.calculateDimensions(g2);
        if (this.expandToFitSpace)
          return new Size2D(size2D.getHeight(), (double) maxWidth);
        else
          return new Size2D(size2D.height, size2D.width);
      }
      else
      {
        string str = "Unrecognised exception.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 184, (byte) 103, (byte) 115, (byte) 100, (byte) 108, (byte) 191, (byte) 11, (byte) 113, (byte) 109, (byte) 104, (byte) 176, (byte) 162, (byte) 147, (byte) 102, (byte) 108, (byte) 191, (byte) 11, (byte) 113, (byte) 173, (byte) 104, (byte) 176, (byte) 212})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeFN(Graphics2D g2, double w)
    {
      RectangleEdge position = this.getPosition();
      if (position == RectangleEdge.__\u003C\u003ETOP || position == RectangleEdge.__\u003C\u003EBOTTOM)
      {
        float maxWidth = (float) w;
        ((Graphics) g2).setFont(this.font);
        this.content = TextUtilities.createTextBlock(this.text, this.font, this.paint, maxWidth, this.maximumLinesToDisplay, (TextMeasurer) new G2TextMeasurer(g2));
        this.content.setLineAlignment(this.textAlignment);
        Size2D size2D = this.content.calculateDimensions(g2);
        if (!this.expandToFitSpace)
          return size2D;
        return new Size2D((double) maxWidth, size2D.getHeight());
      }
      else if (position == RectangleEdge.__\u003C\u003ELEFT || position == RectangleEdge.__\u003C\u003ERIGHT)
      {
        float maxWidth = float.MaxValue;
        ((Graphics) g2).setFont(this.font);
        this.content = TextUtilities.createTextBlock(this.text, this.font, this.paint, maxWidth, this.maximumLinesToDisplay, (TextMeasurer) new G2TextMeasurer(g2));
        this.content.setLineAlignment(this.textAlignment);
        Size2D size2D = this.content.calculateDimensions(g2);
        if (this.expandToFitSpace)
          return new Size2D(size2D.getHeight(), (double) maxWidth);
        else
          return new Size2D(size2D.height, size2D.width);
      }
      else
      {
        string str = "Unrecognised exception.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 65, (byte) 104, (byte) 130, (byte) 105, (byte) 104, (byte) 114, (byte) 130, (byte) 98, (byte) 104, (byte) 103, (byte) 104, (byte) 212, (byte) 105, (byte) 104, (byte) 108, (byte) 135, (byte) 105, (byte) 103, (byte) 112, (byte) 138, (byte) 144, (byte) 136, (byte) 102, (byte) 99, (byte) 103, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object draw(Graphics2D g2, Rectangle2D area, object @params)
    {
      if (this.content == null)
        return (object) null;
      area = this.trimMargin(area);
      this.drawBorder(g2, area);
      if (String.instancehelper_equals(this.text, (object) ""))
        return (object) null;
      TitleEntity titleEntity = (TitleEntity) null;
      if (@params is EntityBlockParams && ((EntityBlockParams) @params).getGenerateEntities())
        titleEntity = new TitleEntity((Shape) area, (Title) this, this.toolTipText, this.urlText);
      area = this.trimBorder(area);
      if (this.backgroundPaint != null)
      {
        g2.setPaint(this.backgroundPaint);
        g2.fill((Shape) area);
      }
      area = this.trimPadding(area);
      RectangleEdge position = this.getPosition();
      if (position == RectangleEdge.__\u003C\u003ETOP || position == RectangleEdge.__\u003C\u003EBOTTOM)
        this.drawHorizontal(g2, area);
      else if (position == RectangleEdge.__\u003C\u003ELEFT || position == RectangleEdge.__\u003C\u003ERIGHT)
        this.drawVertical(g2, area);
      BlockResult blockResult = new BlockResult();
      if (titleEntity != null)
      {
        StandardEntityCollection entityCollection = new StandardEntityCollection();
        entityCollection.add((ChartEntity) titleEntity);
        blockResult.setEntityCollection((EntityCollection) entityCollection);
      }
      return (object) blockResult;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 113, (byte) 108, (byte) 108, (byte) 108, (byte) 98, (byte) 102, (byte) 103, (byte) 104, (byte) 104, (byte) 136, (byte) 104, (byte) 104, (byte) 136, (byte) 104, (byte) 104, (byte) 134, (byte) 103, (byte) 104, (byte) 105, (byte) 139, (byte) 105, (byte) 105, (byte) 104, (byte) 136, (byte) 104, (byte) 136, (byte) 104, (byte) 166, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawHorizontal(Graphics2D g2, Rectangle2D area)
    {
      Rectangle2D rectangle2D = (Rectangle2D) ((RectangularShape) area).clone();
      ((Graphics) g2).setFont(this.font);
      g2.setPaint(this.paint);
      TextBlockAnchor anchor = (TextBlockAnchor) null;
      float x = 0.0f;
      HorizontalAlignment horizontalAlignment = this.getHorizontalAlignment();
      if (horizontalAlignment == HorizontalAlignment.__\u003C\u003ELEFT)
      {
        x = (float) ((RectangularShape) rectangle2D).getX();
        anchor = TextBlockAnchor.__\u003C\u003ETOP_LEFT;
      }
      else if (horizontalAlignment == HorizontalAlignment.__\u003C\u003ERIGHT)
      {
        x = (float) ((RectangularShape) rectangle2D).getMaxX();
        anchor = TextBlockAnchor.__\u003C\u003ETOP_RIGHT;
      }
      else if (horizontalAlignment == HorizontalAlignment.__\u003C\u003ECENTER)
      {
        x = (float) ((RectangularShape) rectangle2D).getCenterX();
        anchor = TextBlockAnchor.__\u003C\u003ETOP_CENTER;
      }
      float y = 0.0f;
      RectangleEdge position = this.getPosition();
      if (position == RectangleEdge.__\u003C\u003ETOP)
        y = (float) ((RectangularShape) rectangle2D).getY();
      else if (position == RectangleEdge.__\u003C\u003EBOTTOM)
      {
        y = (float) ((RectangularShape) rectangle2D).getMaxY();
        if (horizontalAlignment == HorizontalAlignment.__\u003C\u003ELEFT)
          anchor = TextBlockAnchor.__\u003C\u003EBOTTOM_LEFT;
        else if (horizontalAlignment == HorizontalAlignment.__\u003C\u003ECENTER)
          anchor = TextBlockAnchor.__\u003C\u003EBOTTOM_CENTER;
        else if (horizontalAlignment == HorizontalAlignment.__\u003C\u003ERIGHT)
          anchor = TextBlockAnchor.__\u003C\u003EBOTTOM_RIGHT;
      }
      this.content.draw(g2, x, y, anchor);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 160, (byte) 108, (byte) 108, (byte) 108, (byte) 98, (byte) 102, (byte) 103, (byte) 104, (byte) 104, (byte) 136, (byte) 104, (byte) 104, (byte) 136, (byte) 104, (byte) 104, (byte) 134, (byte) 103, (byte) 104, (byte) 105, (byte) 139, (byte) 105, (byte) 105, (byte) 104, (byte) 136, (byte) 104, (byte) 136, (byte) 104, (byte) 166, (byte) 126})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawVertical(Graphics2D g2, Rectangle2D area)
    {
      Rectangle2D rectangle2D = (Rectangle2D) ((RectangularShape) area).clone();
      ((Graphics) g2).setFont(this.font);
      g2.setPaint(this.paint);
      TextBlockAnchor anchor = (TextBlockAnchor) null;
      float num1 = 0.0f;
      VerticalAlignment verticalAlignment = this.getVerticalAlignment();
      if (verticalAlignment == VerticalAlignment.__\u003C\u003ETOP)
      {
        num1 = (float) ((RectangularShape) rectangle2D).getY();
        anchor = TextBlockAnchor.__\u003C\u003ETOP_RIGHT;
      }
      else if (verticalAlignment == VerticalAlignment.__\u003C\u003EBOTTOM)
      {
        num1 = (float) ((RectangularShape) rectangle2D).getMaxY();
        anchor = TextBlockAnchor.__\u003C\u003ETOP_LEFT;
      }
      else if (verticalAlignment == VerticalAlignment.__\u003C\u003ECENTER)
      {
        num1 = (float) ((RectangularShape) rectangle2D).getCenterY();
        anchor = TextBlockAnchor.__\u003C\u003ETOP_CENTER;
      }
      float num2 = 0.0f;
      RectangleEdge position = this.getPosition();
      if (position == RectangleEdge.__\u003C\u003ELEFT)
        num2 = (float) ((RectangularShape) rectangle2D).getX();
      else if (position == RectangleEdge.__\u003C\u003ERIGHT)
      {
        num2 = (float) ((RectangularShape) rectangle2D).getMaxX();
        if (verticalAlignment == VerticalAlignment.__\u003C\u003ETOP)
          anchor = TextBlockAnchor.__\u003C\u003EBOTTOM_RIGHT;
        else if (verticalAlignment == VerticalAlignment.__\u003C\u003ECENTER)
          anchor = TextBlockAnchor.__\u003C\u003EBOTTOM_CENTER;
        else if (verticalAlignment == VerticalAlignment.__\u003C\u003EBOTTOM)
          anchor = TextBlockAnchor.__\u003C\u003EBOTTOM_LEFT;
      }
      this.content.draw(g2, num2, num1, anchor, num2, num1, -1.0 * Math.PI / 2.0);
    }

    public virtual HorizontalAlignment getTextAlignment()
    {
      return this.textAlignment;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 181, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTextAlignment(HorizontalAlignment alignment)
    {
      if (alignment == null)
      {
        string str = "Null 'alignment' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.textAlignment = alignment;
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    public virtual Paint getBackgroundPaint()
    {
      return this.backgroundPaint;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 7, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackgroundPaint(Paint paint)
    {
      this.backgroundPaint = paint;
      this.notifyListeners(new TitleChangeEvent((Title) this));
    }

    public virtual string getToolTipText()
    {
      return this.toolTipText;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 27, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setToolTipText(string text)
    {
      this.toolTipText = text;
      this.notifyListeners(new TitleChangeEvent((Title) this));
    }

    public virtual string getURLText()
    {
      return this.urlText;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 47, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setURLText(string text)
    {
      this.urlText = text;
      this.notifyListeners(new TitleChangeEvent((Title) this));
    }

    public virtual bool getExpandToFitSpace()
    {
      return this.expandToFitSpace;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 33, (byte) 162, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setExpandToFitSpace(bool expand)
    {
      this.expandToFitSpace = expand;
      this.notifyListeners(new TitleChangeEvent((Title) this));
    }

    public virtual int getMaximumLinesToDisplay()
    {
      return this.maximumLinesToDisplay;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 97, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMaximumLinesToDisplay(int max)
    {
      this.maximumLinesToDisplay = max;
      this.notifyListeners(new TitleChangeEvent((Title) this));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 111, (byte) 104, (byte) 103, (byte) 103, (byte) 98, (byte) 104, (byte) 104, (byte) 141, (byte) 104, (byte) 144, (byte) 107, (byte) 176, (byte) 104, (byte) 104, (byte) 147, (byte) 104, (byte) 185, (byte) 107, (byte) 176, (byte) 104, (byte) 104, (byte) 144, (byte) 104, (byte) 144, (byte) 104, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Size2D arrange(Graphics2D g2, RectangleConstraint constraint)
    {
      RectangleConstraint rectangleConstraint = this.toContentConstraint(constraint);
      LengthConstraintType widthConstraintType = rectangleConstraint.getWidthConstraintType();
      LengthConstraintType heightConstraintType = rectangleConstraint.getHeightConstraintType();
      Size2D size2D = (Size2D) null;
      if (widthConstraintType == LengthConstraintType.__\u003C\u003ENONE)
      {
        if (heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
          size2D = this.arrangeNN(g2);
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
      }
      else if (widthConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
      {
        if (heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
          size2D = this.arrangeRN(g2, rectangleConstraint.getWidthRange());
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
          size2D = this.arrangeRR(g2, rectangleConstraint.getWidthRange(), rectangleConstraint.getHeightRange());
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
      }
      else if (widthConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
      {
        if (heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
          size2D = this.arrangeFN(g2, rectangleConstraint.getWidth());
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
        {
          string str = "Not yet implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
      }
      return new Size2D(this.calculateTotalWidth(size2D.getWidth()), this.calculateTotalHeight(size2D.getHeight()));
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 49, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area)
    {
      this.draw(g2, area, (object) null);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 206, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is TextTitle))
        return false;
      TextTitle textTitle = (TextTitle) obj;
      if (!ObjectUtilities.equal((object) this.text, (object) textTitle.text) || !ObjectUtilities.equal((object) this.font, (object) textTitle.font) || (!PaintUtilities.equal(this.paint, textTitle.paint) || this.textAlignment != textTitle.textAlignment) || (!PaintUtilities.equal(this.backgroundPaint, textTitle.backgroundPaint) || this.maximumLinesToDisplay != textTitle.maximumLinesToDisplay || (this.expandToFitSpace != textTitle.expandToFitSpace || !ObjectUtilities.equal((object) this.toolTipText, (object) textTitle.toolTipText))) || !ObjectUtilities.equal((object) this.urlText, (object) textTitle.urlText))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 249, (byte) 103, (byte) 124, (byte) 124, (byte) 124, (byte) 156})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int hashCode()
    {
      return 29 * (29 * (29 * (29 * base.hashCode() + (this.text == null ? 0 : String.instancehelper_hashCode(this.text))) + (this.font == null ? 0 : this.font.hashCode())) + (this.paint == null ? 0 : Object.instancehelper_hashCode((object) this.paint))) + (this.backgroundPaint == null ? 0 : Object.instancehelper_hashCode((object) this.backgroundPaint));
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 21, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.paint, obj0);
      SerialUtilities.writePaint(this.backgroundPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 163, (byte) 36, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.paint = SerialUtilities.readPaint(obj0);
      this.backgroundPaint = SerialUtilities.readPaint(obj0);
    }
  }
}
