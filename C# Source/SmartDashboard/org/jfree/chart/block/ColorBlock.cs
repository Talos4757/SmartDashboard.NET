// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.ColorBlock
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

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
using System.Security.Permissions;

namespace org.jfree.chart.block
{
  [Implements(new string[] {"org.jfree.chart.block.Block"})]
  [Serializable]
  public class ColorBlock : AbstractBlock, Block, Drawable
  {
    internal const long serialVersionUID = 3383866145634010865L;
    [NonSerialized]
    private Paint paint;

    [LineNumberTable(new byte[] {(byte) 27, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 104, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColorBlock(Paint paint, double width, double height)
    {
      ColorBlock colorBlock = this;
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.paint = paint;
        this.setWidth(width);
        this.setHeight(height);
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ColorBlock([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 68, (byte) 105, (byte) 104, (byte) 105, (byte) 105, (byte) 108, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, Rectangle2D area)
    {
      area = this.trimMargin(area);
      this.drawBorder(g2, area);
      area = this.trimBorder(area);
      area = this.trimPadding(area);
      g2.setPaint(this.paint);
      g2.fill((Shape) area);
    }

    public virtual Paint getPaint()
    {
      return this.paint;
    }

    [LineNumberTable((ushort) 107)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Size2D arrange(Graphics2D g2, RectangleConstraint constraint)
    {
      return new Size2D(this.calculateTotalWidth(this.getWidth()), this.calculateTotalHeight(this.getHeight()));
    }

    [LineNumberTable(new byte[] {(byte) 86, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object draw(Graphics2D g2, Rectangle2D area, object @params)
    {
      this.draw(g2, area);
      return (object) null;
    }

    [LineNumberTable(new byte[] {(byte) 98, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ColorBlock) || !PaintUtilities.equal(this.paint, ((ColorBlock) obj).paint))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 119, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.paint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 69, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.paint = SerialUtilities.readPaint(obj0);
    }
  }
}
