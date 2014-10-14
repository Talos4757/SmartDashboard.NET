// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.title.CompositeTitle
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
  [Implements(new string[] {"java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class CompositeTitle : Title, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -6770854036232562290L;
    [NonSerialized]
    private Paint backgroundPaint;
    private BlockContainer container;

    [HideFromJava]
    static CompositeTitle()
    {
      Title.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CompositeTitle(BlockContainer container)
    {
      CompositeTitle compositeTitle = this;
      if (container == null)
      {
        string str = "Null 'container' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.container = container;
        this.backgroundPaint = (Paint) null;
      }
    }

    [LineNumberTable(new byte[] {(byte) 38, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CompositeTitle()
      : this(new BlockContainer((Arrangement) new BorderArrangement()))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CompositeTitle([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] CompositeTitle obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CompositeTitle obj0)
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

    public virtual BlockContainer getContainer()
    {
      return this.container;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 73, (byte) 105, (byte) 104, (byte) 105, (byte) 104, (byte) 108, (byte) 135, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object draw(Graphics2D g2, Rectangle2D area, object @params)
    {
      area = this.trimMargin(area);
      this.drawBorder(g2, area);
      area = this.trimBorder(area);
      if (this.backgroundPaint != null)
      {
        g2.setPaint(this.backgroundPaint);
        g2.fill((Shape) area);
      }
      area = this.trimPadding(area);
      return this.container.draw(g2, area, @params);
    }

    public virtual Paint getBackgroundPaint()
    {
      return this.backgroundPaint;
    }

    [LineNumberTable(new byte[] {(byte) 75, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setBackgroundPaint(Paint paint)
    {
      this.backgroundPaint = paint;
      this.notifyListeners(new TitleChangeEvent((Title) this));
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTitleContainer(BlockContainer container)
    {
      if (container == null)
      {
        string str = "Null 'container' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.container = container;
    }

    [LineNumberTable(new byte[] {(byte) 110, (byte) 104, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Size2D arrange(Graphics2D g2, RectangleConstraint constraint)
    {
      RectangleConstraint constraint1 = this.toContentConstraint(constraint);
      Size2D size2D = this.container.arrange(g2, constraint1);
      return new Size2D(this.calculateTotalWidth(size2D.getWidth()), this.calculateTotalHeight(size2D.getHeight()));
    }

    [LineNumberTable(new byte[] {(byte) 124, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void draw(Graphics2D g2, Rectangle2D area)
    {
      this.draw(g2, area, (object) null);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 92, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is CompositeTitle))
        return false;
      CompositeTitle compositeTitle = (CompositeTitle) obj;
      if (!this.container.equals((object) compositeTitle.container) || !PaintUtilities.equal(this.backgroundPaint, compositeTitle.backgroundPaint))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 116, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.backgroundPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 130, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.backgroundPaint = SerialUtilities.readPaint(obj0);
    }
  }
}
