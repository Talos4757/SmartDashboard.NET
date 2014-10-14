// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.title.ImageTitle
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.geom;
using java.awt.image;
using java.lang;
using org.jfree.chart.@event;
using org.jfree.chart.block;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.title
{
  [Serializable]
  public class ImageTitle : Title
  {
    private Image image;

    [HideFromJava]
    static ImageTitle()
    {
      Title.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 91, (byte) 112, (byte) 99, (byte) 144, (byte) 103, (byte) 104, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ImageTitle(Image image, int height, int width, RectangleEdge position, HorizontalAlignment horizontalAlignment, VerticalAlignment verticalAlignment, RectangleInsets padding)
      : base(position, horizontalAlignment, verticalAlignment, padding)
    {
      ImageTitle imageTitle = this;
      if (image == null)
      {
        string str = "Null 'image' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        this.image = image;
        this.setHeight((double) height);
        this.setWidth((double) width);
      }
    }

    [LineNumberTable(new byte[] {(byte) 50, (byte) 191, (byte) 12})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ImageTitle(Image image)
      : this(image, image.getHeight((ImageObserver) null), image.getWidth((ImageObserver) null), Title.__\u003C\u003EDEFAULT_POSITION, Title.__\u003C\u003EDEFAULT_HORIZONTAL_ALIGNMENT, Title.__\u003C\u003EDEFAULT_VERTICAL_ALIGNMENT, Title.__\u003C\u003EDEFAULT_PADDING)
    {
    }

    [LineNumberTable(new byte[] {(byte) 67, (byte) 191, (byte) 1})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ImageTitle(Image image, RectangleEdge position, HorizontalAlignment horizontalAlignment, VerticalAlignment verticalAlignment)
      : this(image, image.getHeight((ImageObserver) null), image.getWidth((ImageObserver) null), position, horizontalAlignment, verticalAlignment, Title.__\u003C\u003EDEFAULT_PADDING)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ImageTitle([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 109, (byte) 102, (byte) 102, (byte) 102, (byte) 102, (byte) 134, (byte) 104, (byte) 104, (byte) 103, (byte) 105, (byte) 106, (byte) 106, (byte) 138, (byte) 109, (byte) 173, (byte) 213, (byte) 104, (byte) 103, (byte) 105, (byte) 191, (byte) 12, (byte) 105, (byte) 142, (byte) 105, (byte) 149, (byte) 191, (byte) 9})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D drawHorizontal(Graphics2D g2, Rectangle2D chartArea)
    {
      double width = this.getWidth();
      double height = this.getHeight();
      RectangleInsets padding = this.getPadding();
      double num1 = padding.calculateTopOutset(height);
      double num2 = padding.calculateBottomOutset(height);
      double num3 = padding.calculateLeftOutset(width);
      double num4 = padding.calculateRightOutset(width);
      double num5 = this.getPosition() != RectangleEdge.__\u003C\u003ETOP ? ((RectangularShape) chartArea).getY() + ((RectangularShape) chartArea).getHeight() - num2 - height : ((RectangularShape) chartArea).getY() + num1;
      HorizontalAlignment horizontalAlignment = this.getHorizontalAlignment();
      double num6 = 0.0;
      if (horizontalAlignment == HorizontalAlignment.__\u003C\u003ECENTER)
        num6 = ((RectangularShape) chartArea).getX() + num3 + ((RectangularShape) chartArea).getWidth() / 2.0 - width / 2.0;
      else if (horizontalAlignment == HorizontalAlignment.__\u003C\u003ELEFT)
        num6 = ((RectangularShape) chartArea).getX() + num3;
      else if (horizontalAlignment == HorizontalAlignment.__\u003C\u003ERIGHT)
        num6 = ((RectangularShape) chartArea).getX() + ((RectangularShape) chartArea).getWidth() - num4 - width;
      ((Graphics) g2).drawImage(this.image, ByteCodeHelper.d2i(num6), ByteCodeHelper.d2i(num5), ByteCodeHelper.d2i(width), ByteCodeHelper.d2i(height), (ImageObserver) null);
      return new Size2D(((RectangularShape) chartArea).getWidth() + num3 + num4, height + num1 + num2);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 163, (byte) 102, (byte) 102, (byte) 102, (byte) 102, (byte) 134, (byte) 105, (byte) 137, (byte) 104, (byte) 100, (byte) 107, (byte) 107, (byte) 107, (byte) 171, (byte) 109, (byte) 173, (byte) 206, (byte) 104, (byte) 103, (byte) 105, (byte) 191, (byte) 12, (byte) 105, (byte) 141, (byte) 105, (byte) 174, (byte) 191, (byte) 11})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D drawVertical(Graphics2D g2, Rectangle2D chartArea)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      double num4 = 0.0;
      double width = this.getWidth();
      double height = this.getHeight();
      RectangleInsets padding = this.getPadding();
      if (padding != null)
      {
        num1 = padding.calculateTopOutset(height);
        num2 = padding.calculateBottomOutset(height);
        num3 = padding.calculateLeftOutset(width);
        num4 = padding.calculateRightOutset(width);
      }
      double num5 = this.getPosition() != RectangleEdge.__\u003C\u003ELEFT ? ((RectangularShape) chartArea).getMaxX() - num4 - width : ((RectangularShape) chartArea).getX() + num3;
      VerticalAlignment verticalAlignment = this.getVerticalAlignment();
      double num6 = 0.0;
      if (verticalAlignment == VerticalAlignment.__\u003C\u003ECENTER)
        num6 = ((RectangularShape) chartArea).getMinY() + num1 + ((RectangularShape) chartArea).getHeight() / 2.0 - height / 2.0;
      else if (verticalAlignment == VerticalAlignment.__\u003C\u003ETOP)
        num6 = ((RectangularShape) chartArea).getMinY() + num1;
      else if (verticalAlignment == VerticalAlignment.__\u003C\u003EBOTTOM)
        num6 = ((RectangularShape) chartArea).getMaxY() - num2 - height;
      ((Graphics) g2).drawImage(this.image, ByteCodeHelper.d2i(num5), ByteCodeHelper.d2i(num6), ByteCodeHelper.d2i(width), ByteCodeHelper.d2i(height), (ImageObserver) null);
      return new Size2D(((RectangularShape) chartArea).getWidth() + num3 + num4, height + num1 + num2);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 103, (byte) 112, (byte) 139, (byte) 144, (byte) 171, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area)
    {
      RectangleEdge position = this.getPosition();
      if (position == RectangleEdge.__\u003C\u003ETOP || position == RectangleEdge.__\u003C\u003EBOTTOM)
        this.drawHorizontal(g2, area);
      else if (position == RectangleEdge.__\u003C\u003ELEFT || position == RectangleEdge.__\u003C\u003ERIGHT)
      {
        this.drawVertical(g2, area);
      }
      else
      {
        string str = "Invalid title position.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
    }

    public virtual Image getImage()
    {
      return this.image;
    }

    [LineNumberTable(new byte[] {(byte) 117, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setImage(Image image)
    {
      if (image == null)
      {
        string str = "Null 'image' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        this.image = image;
        this.notifyListeners(new TitleChangeEvent((Title) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 70, (byte) 159, (byte) 1})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Size2D arrange(Graphics2D g2, RectangleConstraint constraint)
    {
      Size2D size2D = new Size2D((double) this.image.getWidth((ImageObserver) null), (double) this.image.getHeight((ImageObserver) null));
      return new Size2D(this.calculateTotalWidth(size2D.getWidth()), this.calculateTotalHeight(size2D.getHeight()));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 219, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object draw(Graphics2D g2, Rectangle2D area, object @params)
    {
      this.draw(g2, area);
      return (object) null;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 238, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ImageTitle) || !ObjectUtilities.equal((object) this.image, (object) ((ImageTitle) obj).image))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }
  }
}
