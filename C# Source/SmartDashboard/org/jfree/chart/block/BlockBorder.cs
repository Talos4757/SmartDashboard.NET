// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.BlockBorder
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
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
  [Implements(new string[] {"org.jfree.chart.block.BlockFrame", "java.io.Serializable"})]
  [Serializable]
  public class BlockBorder : Object, BlockFrame, Serializable.__Interface, ISerializable
  {
    internal static BlockBorder __\u003C\u003ENONE = new BlockBorder(RectangleInsets.__\u003C\u003EZERO_INSETS, (Paint) Color.white);
    private const long serialVersionUID = 4961579220410228283L;
    private RectangleInsets insets;
    [NonSerialized]
    private Paint paint;

    [Modifiers]
    public static BlockBorder NONE
    {
      [HideFromJava] get
      {
        return BlockBorder.__\u003C\u003ENONE;
      }
    }

    [LineNumberTable((ushort) 70)]
    static BlockBorder()
    {
    }

    [LineNumberTable(new byte[] {(byte) 54, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BlockBorder(double top, double left, double bottom, double right)
      : this(new RectangleInsets(top, left, bottom, right), (Paint) Color.black)
    {
    }

    [LineNumberTable(new byte[] {(byte) 42, (byte) 127, (byte) 3})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BlockBorder(Paint paint)
      : this(new RectangleInsets(1.0, 1.0, 1.0, 1.0), paint)
    {
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BlockBorder(RectangleInsets insets, Paint paint)
    {
      base.\u002Ector();
      BlockBorder blockBorder = this;
      if (insets == null)
      {
        string str = "Null 'insets' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.insets = insets;
        this.paint = paint;
      }
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BlockBorder()
      : this((Paint) Color.black)
    {
    }

    [LineNumberTable(new byte[] {(byte) 68, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BlockBorder(double top, double left, double bottom, double right, Paint paint)
      : this(new RectangleInsets(top, left, bottom, right), paint)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected BlockBorder([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] BlockBorder obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual RectangleInsets getInsets()
    {
      return this.insets;
    }

    public virtual Paint getPaint()
    {
      return this.paint;
    }

    [LineNumberTable(new byte[] {(byte) 115, (byte) 115, (byte) 115, (byte) 115, (byte) 115, (byte) 105, (byte) 105, (byte) 105, (byte) 105, (byte) 108, (byte) 103, (byte) 104, (byte) 110, (byte) 136, (byte) 104, (byte) 115, (byte) 136, (byte) 104, (byte) 110, (byte) 136, (byte) 104, (byte) 115, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, Rectangle2D area)
    {
      double num1 = this.insets.calculateTopInset(((RectangularShape) area).getHeight());
      double num2 = this.insets.calculateBottomInset(((RectangularShape) area).getHeight());
      double num3 = this.insets.calculateLeftInset(((RectangularShape) area).getWidth());
      double num4 = this.insets.calculateRightInset(((RectangularShape) area).getWidth());
      double x = ((RectangularShape) area).getX();
      double y = ((RectangularShape) area).getY();
      double width = ((RectangularShape) area).getWidth();
      double height = ((RectangularShape) area).getHeight();
      g2.setPaint(this.paint);
      Rectangle2D.Double @double = new Rectangle2D.Double();
      if (num1 > 0.0)
      {
        ((Rectangle2D) @double).setRect(x, y, width, num1);
        g2.fill((Shape) @double);
      }
      if (num2 > 0.0)
      {
        ((Rectangle2D) @double).setRect(x, y + height - num2, width, num2);
        g2.fill((Shape) @double);
      }
      if (num3 > 0.0)
      {
        ((Rectangle2D) @double).setRect(x, y, num3, height);
        g2.fill((Shape) @double);
      }
      if (num4 <= 0.0)
        return;
      ((Rectangle2D) @double).setRect(x + width - num4, y, num4, height);
      g2.fill((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 87, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is BlockBorder))
        return false;
      BlockBorder blockBorder = (BlockBorder) obj;
      return this.insets.equals((object) blockBorder.insets) && PaintUtilities.equal(this.paint, blockBorder.paint);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 111, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.paint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 125, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.paint = SerialUtilities.readPaint(obj0);
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
