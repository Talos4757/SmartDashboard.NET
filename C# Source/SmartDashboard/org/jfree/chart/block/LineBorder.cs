// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.LineBorder
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
  public class LineBorder : Object, BlockFrame, Serializable.__Interface, ISerializable
  {
    internal const long serialVersionUID = 4630356736707233924L;
    [NonSerialized]
    private Paint paint;
    [NonSerialized]
    private Stroke stroke;
    private RectangleInsets insets;

    [LineNumberTable(new byte[] {(byte) 35, (byte) 159, (byte) 17})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LineBorder()
      : this((Paint) Color.black, (Stroke) new BasicStroke(1f), new RectangleInsets(1.0, 1.0, 1.0, 1.0))
    {
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public LineBorder(Paint paint, Stroke stroke, RectangleInsets insets)
    {
      base.\u002Ector();
      LineBorder lineBorder = this;
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (stroke == null)
      {
        string str = "Null 'stroke' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (insets == null)
      {
        string str = "Null 'insets' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.paint = paint;
        this.stroke = stroke;
        this.insets = insets;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected LineBorder([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] LineBorder obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual Paint getPaint()
    {
      return this.paint;
    }

    public virtual Stroke getStroke()
    {
      return this.stroke;
    }

    public virtual RectangleInsets getInsets()
    {
      return this.insets;
    }

    [LineNumberTable(new byte[] {(byte) 95, (byte) 104, (byte) 136, (byte) 112, (byte) 129, (byte) 110, (byte) 110, (byte) 111, (byte) 111, (byte) 105, (byte) 105, (byte) 114, (byte) 116, (byte) 115, (byte) 113, (byte) 108, (byte) 108, (byte) 103, (byte) 104, (byte) 111, (byte) 136, (byte) 104, (byte) 111, (byte) 136, (byte) 105, (byte) 111, (byte) 136, (byte) 105, (byte) 111, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, Rectangle2D area)
    {
      double width = ((RectangularShape) area).getWidth();
      double height = ((RectangularShape) area).getHeight();
      if (width <= 0.0 || height <= 0.0)
        return;
      double num1 = this.insets.calculateTopInset(height);
      double num2 = this.insets.calculateBottomInset(height);
      double num3 = this.insets.calculateLeftInset(width);
      double num4 = this.insets.calculateRightInset(width);
      double x = ((RectangularShape) area).getX();
      double y = ((RectangularShape) area).getY();
      double num5 = x + num3 / 2.0;
      double num6 = x + width - num4 / 2.0;
      double num7 = y + height - num2 / 2.0;
      double num8 = y + num1 / 2.0;
      g2.setPaint(this.getPaint());
      g2.setStroke(this.getStroke());
      Line2D.Double @double = new Line2D.Double();
      if (num1 > 0.0)
      {
        ((Line2D) @double).setLine(num5, num8, num6, num8);
        g2.draw((Shape) @double);
      }
      if (num2 > 0.0)
      {
        ((Line2D) @double).setLine(num5, num7, num6, num7);
        g2.draw((Shape) @double);
      }
      if (num3 > 0.0)
      {
        ((Line2D) @double).setLine(num5, num7, num5, num8);
        g2.draw((Shape) @double);
      }
      if (num4 <= 0.0)
        return;
      ((Line2D) @double).setLine(num6, num7, num6, num8);
      g2.draw((Shape) @double);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 76, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is LineBorder))
        return false;
      LineBorder lineBorder = (LineBorder) obj;
      return PaintUtilities.equal(this.paint, lineBorder.paint) && ObjectUtilities.equal((object) this.stroke, (object) lineBorder.stroke) && this.insets.equals((object) lineBorder.insets);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 103, (byte) 102, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.paint, obj0);
      SerialUtilities.writeStroke(this.stroke, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 118, (byte) 102, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.paint = SerialUtilities.readPaint(obj0);
      this.stroke = SerialUtilities.readStroke(obj0);
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
