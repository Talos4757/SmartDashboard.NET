// Decompiled with JetBrains decompiler
// Type: org.jfree.text.TextBox
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

namespace org.jfree.text
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class TextBox : Object, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 3360220213180203706L;
    [NonSerialized]
    private Paint outlinePaint;
    [NonSerialized]
    private Stroke outlineStroke;
    private RectangleInsets interiorGap;
    [NonSerialized]
    private Paint backgroundPaint;
    [NonSerialized]
    private Paint shadowPaint;
    private double shadowXOffset;
    private double shadowYOffset;
    private TextBlock textBlock;

    [LineNumberTable(new byte[] {(byte) 80, (byte) 232, (byte) 28, (byte) 176, (byte) 240, (byte) 98, (byte) 107, (byte) 112, (byte) 127, (byte) 8, (byte) 122, (byte) 107, (byte) 112, (byte) 112, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextBox(TextBlock block)
    {
      base.\u002Ector();
      TextBox textBox = this;
      this.shadowXOffset = 2.0;
      this.shadowYOffset = 2.0;
      this.outlinePaint = (Paint) Color.black;
      this.outlineStroke = (Stroke) new BasicStroke(1f);
      this.interiorGap = new RectangleInsets(1.0, 3.0, 1.0, 3.0);
      this.backgroundPaint = (Paint) new Color((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.shadowPaint = (Paint) Color.gray;
      this.shadowXOffset = 2.0;
      this.shadowYOffset = 2.0;
      this.textBlock = block;
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextBox()
      : this((TextBlock) null)
    {
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 110, (byte) 99, (byte) 107, (byte) 255, (byte) 1, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextBox(string text)
      : this((TextBlock) null)
    {
      TextBox textBox = this;
      if (text == null)
        return;
      this.textBlock = new TextBlock();
      this.textBlock.addLine(text, new Font("SansSerif", 0, 10), (Paint) Color.black);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TextBox([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TextBox obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual Paint getOutlinePaint()
    {
      return this.outlinePaint;
    }

    public virtual void setOutlinePaint(Paint paint)
    {
      this.outlinePaint = paint;
    }

    public virtual Stroke getOutlineStroke()
    {
      return this.outlineStroke;
    }

    public virtual void setOutlineStroke(Stroke stroke)
    {
      this.outlineStroke = stroke;
    }

    public virtual RectangleInsets getInteriorGap()
    {
      return this.interiorGap;
    }

    public virtual void setInteriorGap(RectangleInsets gap)
    {
      this.interiorGap = gap;
    }

    public virtual Paint getBackgroundPaint()
    {
      return this.backgroundPaint;
    }

    public virtual void setBackgroundPaint(Paint paint)
    {
      this.backgroundPaint = paint;
    }

    public virtual Paint getShadowPaint()
    {
      return this.shadowPaint;
    }

    public virtual void setShadowPaint(Paint paint)
    {
      this.shadowPaint = paint;
    }

    public virtual double getShadowXOffset()
    {
      return this.shadowXOffset;
    }

    public virtual void setShadowXOffset(double offset)
    {
      this.shadowXOffset = offset;
    }

    public virtual double getShadowYOffset()
    {
      return this.shadowYOffset;
    }

    public virtual void setShadowYOffset(double offset)
    {
      this.shadowYOffset = offset;
    }

    public virtual TextBlock getTextBlock()
    {
      return this.textBlock;
    }

    public virtual void setTextBlock(TextBlock block)
    {
      this.textBlock = block;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 182, (byte) 109, (byte) 115, (byte) 115, (byte) 104, (byte) 144, (byte) 106, (byte) 138, (byte) 104, (byte) 191, (byte) 8, (byte) 108, (byte) 136, (byte) 104, (byte) 108, (byte) 168, (byte) 112, (byte) 108, (byte) 108, (byte) 168, (byte) 255, (byte) 20, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, float x, float y, RectangleAnchor anchor)
    {
      Size2D size2D = this.textBlock.calculateDimensions(g2);
      double width = this.interiorGap.extendWidth(size2D.getWidth());
      double height = this.interiorGap.extendHeight(size2D.getHeight());
      Rectangle2D rectangle = RectangleAnchor.createRectangle(new Size2D(width, height), (double) x, (double) y, anchor);
      double x1 = ((RectangularShape) rectangle).getX();
      double y1 = ((RectangularShape) rectangle).getY();
      if (this.shadowPaint != null)
      {
        Rectangle2D.Double @double = new Rectangle2D.Double(x1 + this.shadowXOffset, y1 + this.shadowYOffset, ((RectangularShape) rectangle).getWidth(), ((RectangularShape) rectangle).getHeight());
        g2.setPaint(this.shadowPaint);
        g2.fill((Shape) @double);
      }
      if (this.backgroundPaint != null)
      {
        g2.setPaint(this.backgroundPaint);
        g2.fill((Shape) rectangle);
      }
      if (this.outlinePaint != null && this.outlineStroke != null)
      {
        g2.setPaint(this.outlinePaint);
        g2.setStroke(this.outlineStroke);
        g2.draw((Shape) rectangle);
      }
      this.textBlock.draw(g2, (float) (x1 + this.interiorGap.calculateLeftInset(width)), (float) (y1 + this.interiorGap.calculateTopInset(height)), TextBlockAnchor.__\u003C\u003ETOP_LEFT);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 224, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getHeight(Graphics2D g2)
    {
      return this.interiorGap.extendHeight(this.textBlock.calculateDimensions(g2).getHeight());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 236, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is TextBox))
        return false;
      TextBox textBox = (TextBox) obj;
      return ObjectUtilities.equal((object) this.outlinePaint, (object) textBox.outlinePaint) && ObjectUtilities.equal((object) this.outlineStroke, (object) textBox.outlineStroke) && (ObjectUtilities.equal((object) this.interiorGap, (object) textBox.interiorGap) && ObjectUtilities.equal((object) this.backgroundPaint, (object) textBox.backgroundPaint)) && (ObjectUtilities.equal((object) this.shadowPaint, (object) textBox.shadowPaint) && this.shadowXOffset == textBox.shadowXOffset && (this.shadowYOffset == textBox.shadowYOffset && ObjectUtilities.equal((object) this.textBlock, (object) textBox.textBlock)));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 24, (byte) 119, (byte) 156, (byte) 156, (byte) 156, (byte) 156, (byte) 157, (byte) 109, (byte) 157, (byte) 109, (byte) 156})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      int num1 = 29 * (29 * (29 * (29 * (this.outlinePaint == null ? 0 : Object.instancehelper_hashCode((object) this.outlinePaint)) + (this.outlineStroke == null ? 0 : Object.instancehelper_hashCode((object) this.outlineStroke))) + (this.interiorGap == null ? 0 : this.interiorGap.hashCode())) + (this.backgroundPaint == null ? 0 : Object.instancehelper_hashCode((object) this.backgroundPaint))) + (this.shadowPaint == null ? 0 : Object.instancehelper_hashCode((object) this.shadowPaint));
      long num2 = this.shadowXOffset == 0.0 ? 0L : Double.doubleToLongBits(this.shadowXOffset);
      int num3 = 29 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32));
      long num4 = this.shadowYOffset == 0.0 ? 0L : Double.doubleToLongBits(this.shadowYOffset);
      return 29 * (29 * num3 + (int) (num4 ^ (long) ((ulong) num4 >> 32))) + (this.textBlock == null ? 0 : this.textBlock.hashCode());
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 53, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.outlinePaint, obj0);
      SerialUtilities.writeStroke(this.outlineStroke, obj0);
      SerialUtilities.writePaint(this.backgroundPaint, obj0);
      SerialUtilities.writePaint(this.shadowPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 70, (byte) 102, (byte) 108, (byte) 108, (byte) 108, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.outlinePaint = SerialUtilities.readPaint(obj0);
      this.outlineStroke = SerialUtilities.readStroke(obj0);
      this.backgroundPaint = SerialUtilities.readPaint(obj0);
      this.shadowPaint = SerialUtilities.readPaint(obj0);
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
