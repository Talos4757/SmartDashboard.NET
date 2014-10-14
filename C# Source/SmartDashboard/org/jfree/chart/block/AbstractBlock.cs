// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.AbstractBlock
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.data;
using org.jfree.io;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.block
{
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class AbstractBlock : Object, Cloneable.__Interface, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 7689852412141274563L;
    private string id;
    private RectangleInsets margin;
    private BlockFrame frame;
    private RectangleInsets padding;
    private double width;
    private double height;
    [NonSerialized]
    private Rectangle2D bounds;

    [LineNumberTable(new byte[] {(byte) 57, (byte) 104, (byte) 103, (byte) 108, (byte) 108, (byte) 107, (byte) 107, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractBlock()
    {
      base.\u002Ector();
      AbstractBlock abstractBlock = this;
      this.id = (string) null;
      this.width = 0.0;
      this.height = 0.0;
      this.bounds = (Rectangle2D) new Rectangle2D.Float();
      this.margin = RectangleInsets.__\u003C\u003EZERO_INSETS;
      this.frame = (BlockFrame) BlockBorder.__\u003C\u003ENONE;
      this.padding = RectangleInsets.__\u003C\u003EZERO_INSETS;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractBlock([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] AbstractBlock obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] AbstractBlock obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 93, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMargin(RectangleInsets margin)
    {
      if (margin == null)
      {
        string str = "Null 'margin' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.margin = margin;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 178, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setFrame(BlockFrame frame)
    {
      if (frame == null)
      {
        string str = "Null 'frame' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.frame = frame;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 13, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Size2D arrange(Graphics2D g2, RectangleConstraint constraint)
    {
      Size2D @base = new Size2D(this.getWidth(), this.getHeight());
      return constraint.calculateConstrainedSize(@base);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 11, (byte) 108, (byte) 118, (byte) 109, (byte) 108, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      AbstractBlock abstractBlock = (AbstractBlock) base.clone();
      abstractBlock.bounds = (Rectangle2D) ShapeUtilities.clone((Shape) this.bounds);
      if (this.frame is PublicCloneable)
      {
        PublicCloneable publicCloneable = (PublicCloneable) this.frame;
        abstractBlock.frame = (BlockFrame) publicCloneable.clone();
      }
      return (object) abstractBlock;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 204, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPadding(RectangleInsets padding)
    {
      if (padding == null)
      {
        string str = "Null 'padding' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.padding = padding;
    }

    public virtual double getWidth()
    {
      return this.width;
    }

    public virtual double getHeight()
    {
      return this.height;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 54, (byte) 111, (byte) 115, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double trimToContentWidth(double fixedWidth)
    {
      return Math.max(this.padding.trimWidth(this.frame.getInsets().trimWidth(this.margin.trimWidth(fixedWidth))), 0.0);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 72, (byte) 111, (byte) 115, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double trimToContentHeight(double fixedHeight)
    {
      return Math.max(this.padding.trimHeight(this.frame.getInsets().trimHeight(this.margin.trimHeight(fixedHeight))), 0.0);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 108, (byte) 99, (byte) 130, (byte) 102, (byte) 106, (byte) 109, (byte) 142, (byte) 113, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Range trimToContentWidth([In] Range obj0)
    {
      if (obj0 == null)
        return (Range) null;
      double lower = 0.0;
      double upper = double.PositiveInfinity;
      if (obj0.getLowerBound() > 0.0)
        lower = this.trimToContentWidth(obj0.getLowerBound());
      if (obj0.getUpperBound() < double.PositiveInfinity)
        upper = this.trimToContentWidth(obj0.getUpperBound());
      return new Range(lower, upper);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 123, (byte) 99, (byte) 130, (byte) 102, (byte) 106, (byte) 109, (byte) 142, (byte) 113, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Range trimToContentHeight([In] Range obj0)
    {
      if (obj0 == null)
        return (Range) null;
      double lower = 0.0;
      double upper = double.PositiveInfinity;
      if (obj0.getLowerBound() > 0.0)
        lower = this.trimToContentHeight(obj0.getLowerBound());
      if (obj0.getUpperBound() < double.PositiveInfinity)
        upper = this.trimToContentHeight(obj0.getUpperBound());
      return new Range(lower, upper);
    }

    public virtual string getID()
    {
      return this.id;
    }

    public virtual void setID(string id)
    {
      this.id = id;
    }

    public virtual void setWidth(double width)
    {
      this.width = width;
    }

    public virtual void setHeight(double height)
    {
      this.height = height;
    }

    public virtual RectangleInsets getMargin()
    {
      return this.margin;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 111, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setMargin(double top, double left, double bottom, double right)
    {
      this.setMargin(new RectangleInsets(top, left, bottom, right));
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 122, (byte) 109, (byte) 172})]
    public virtual BlockBorder getBorder()
    {
      if (this.frame is BlockBorder)
        return (BlockBorder) this.frame;
      else
        return (BlockBorder) null;
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 141, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBorder(BlockBorder border)
    {
      this.setFrame((BlockFrame) border);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 154, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBorder(double top, double left, double bottom, double right)
    {
      this.setFrame((BlockFrame) new BlockBorder(top, left, bottom, right));
    }

    public virtual BlockFrame getFrame()
    {
      return this.frame;
    }

    public virtual RectangleInsets getPadding()
    {
      return this.padding;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 220, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setPadding(double top, double left, double bottom, double right)
    {
      this.setPadding(new RectangleInsets(top, left, bottom, right));
    }

    [LineNumberTable((ushort) 345)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getContentXOffset()
    {
      return this.margin.getLeft() + this.frame.getInsets().getLeft() + this.padding.getLeft();
    }

    [LineNumberTable((ushort) 357)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getContentYOffset()
    {
      return this.margin.getTop() + this.frame.getInsets().getTop() + this.padding.getTop();
    }

    [LineNumberTable((ushort) 370)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Size2D arrange(Graphics2D g2)
    {
      return this.arrange(g2, RectangleConstraint.__\u003C\u003ENONE);
    }

    public virtual Rectangle2D getBounds()
    {
      return this.bounds;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 36, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBounds(Rectangle2D bounds)
    {
      if (bounds == null)
      {
        string str = "Null 'bounds' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.bounds = bounds;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 87, (byte) 99, (byte) 144, (byte) 109, (byte) 130, (byte) 104, (byte) 103, (byte) 104, (byte) 103, (byte) 106, (byte) 106, (byte) 105, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual RectangleConstraint toContentConstraint(RectangleConstraint c)
    {
      if (c == null)
      {
        string str = "Null 'c' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        if (Object.instancehelper_equals((object) c, (object) RectangleConstraint.__\u003C\u003ENONE))
          return c;
        double width = c.getWidth();
        Range widthRange1 = c.getWidthRange();
        double height = c.getHeight();
        Range heightRange1 = c.getHeightRange();
        double w = this.trimToContentWidth(width);
        double h = this.trimToContentHeight(height);
        Range widthRange2 = this.trimToContentWidth(widthRange1);
        Range heightRange2 = this.trimToContentHeight(heightRange1);
        RectangleConstraint.__\u003Cclinit\u003E();
        return new RectangleConstraint(w, widthRange2, c.getWidthConstraintType(), h, heightRange2, c.getHeightConstraintType());
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 145, (byte) 99, (byte) 110, (byte) 115, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double calculateTotalWidth(double contentWidth)
    {
      return this.margin.extendWidth(this.frame.getInsets().extendWidth(this.padding.extendWidth(contentWidth)));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 160, (byte) 99, (byte) 110, (byte) 115, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual double calculateTotalHeight(double contentHeight)
    {
      return this.margin.extendHeight(this.frame.getInsets().extendHeight(this.padding.extendHeight(contentHeight)));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 177, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Rectangle2D trimMargin(Rectangle2D area)
    {
      this.margin.trim(area);
      return area;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 191, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Rectangle2D trimBorder(Rectangle2D area)
    {
      this.frame.getInsets().trim(area);
      return area;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 205, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Rectangle2D trimPadding(Rectangle2D area)
    {
      this.padding.trim(area);
      return area;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 216, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void drawBorder(Graphics2D g2, Rectangle2D area)
    {
      this.frame.draw(g2, area);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 227, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is AbstractBlock))
        return false;
      AbstractBlock abstractBlock = (AbstractBlock) obj;
      return ObjectUtilities.equal((object) this.id, (object) abstractBlock.id) && Object.instancehelper_equals((object) this.frame, (object) abstractBlock.frame) && (this.bounds.equals((object) abstractBlock.bounds) && this.margin.equals((object) abstractBlock.margin)) && (this.padding.equals((object) abstractBlock.padding) && this.height == abstractBlock.height && this.width == abstractBlock.width);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 28, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writeShape((Shape) this.bounds, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 42, (byte) 102, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.bounds = (Rectangle2D) SerialUtilities.readShape(obj0);
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
