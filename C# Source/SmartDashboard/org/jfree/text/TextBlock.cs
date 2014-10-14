// Decompiled with JetBrains decompiler
// Type: org.jfree.text.TextBlock
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
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
  public class TextBlock : Object, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -4333175719424385526L;
    private List lines;
    private HorizontalAlignment lineAlignment;

    [LineNumberTable(new byte[] {(byte) 39, (byte) 104, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TextBlock()
    {
      base.\u002Ector();
      TextBlock textBlock = this;
      this.lines = (List) new ArrayList();
      this.lineAlignment = HorizontalAlignment.__\u003C\u003ECENTER;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TextBlock([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] TextBlock obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 82, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addLine(TextLine line)
    {
      this.lines.add((object) line);
    }

    [LineNumberTable(new byte[] {(byte) 116, (byte) 102, (byte) 102, (byte) 108, (byte) 104, (byte) 108, (byte) 105, (byte) 111, (byte) 107, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Size2D calculateDimensions(Graphics2D g2)
    {
      double width = 0.0;
      double height = 0.0;
      Iterator iterator = this.lines.iterator();
      while (iterator.hasNext())
      {
        Size2D size2D = ((TextLine) iterator.next()).calculateDimensions(g2);
        width = Math.max(width, size2D.getWidth());
        height += size2D.getHeight();
      }
      return new Size2D(width, height);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 168, (byte) 103, (byte) 102, (byte) 134, (byte) 216, (byte) 174, (byte) 216, (byte) 197, (byte) 216, (byte) 168, (byte) 216, (byte) 174, (byte) 216, (byte) 165, (byte) 100, (byte) 100})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private float[] calculateOffsets([In] TextBlockAnchor obj0, [In] double obj1, [In] double obj2)
    {
      float[] numArray = new float[2];
      float num1 = 0.0f;
      float num2 = 0.0f;
      if (obj0 == TextBlockAnchor.__\u003C\u003ETOP_CENTER || obj0 == TextBlockAnchor.__\u003C\u003ECENTER || obj0 == TextBlockAnchor.__\u003C\u003EBOTTOM_CENTER)
        num1 = (float) -obj1 / 2f;
      else if (obj0 == TextBlockAnchor.__\u003C\u003ETOP_RIGHT || obj0 == TextBlockAnchor.__\u003C\u003ECENTER_RIGHT || obj0 == TextBlockAnchor.__\u003C\u003EBOTTOM_RIGHT)
        num1 = (float) -obj1;
      if (obj0 == TextBlockAnchor.__\u003C\u003ETOP_LEFT || obj0 == TextBlockAnchor.__\u003C\u003ETOP_CENTER || obj0 == TextBlockAnchor.__\u003C\u003ETOP_RIGHT)
        num2 = 0.0f;
      else if (obj0 == TextBlockAnchor.__\u003C\u003ECENTER_LEFT || obj0 == TextBlockAnchor.__\u003C\u003ECENTER || obj0 == TextBlockAnchor.__\u003C\u003ECENTER_RIGHT)
        num2 = (float) -obj2 / 2f;
      else if (obj0 == TextBlockAnchor.__\u003C\u003EBOTTOM_LEFT || obj0 == TextBlockAnchor.__\u003C\u003EBOTTOM_CENTER || obj0 == TextBlockAnchor.__\u003C\u003EBOTTOM_RIGHT)
        num2 = (float) -obj2;
      numArray[0] = num1;
      numArray[1] = num2;
      return numArray;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 130, (byte) 104, (byte) 149, (byte) 108, (byte) 102, (byte) 107, (byte) 109, (byte) 106, (byte) 103, (byte) 109, (byte) 186, (byte) 109, (byte) 145, (byte) 223, (byte) 12, (byte) 108, (byte) 133})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, float anchorX, float anchorY, TextBlockAnchor anchor, float rotateX, float rotateY, double angle)
    {
      Size2D size2D1 = this.calculateDimensions(g2);
      float[] numArray = this.calculateOffsets(anchor, size2D1.getWidth(), size2D1.getHeight());
      Iterator iterator = this.lines.iterator();
      float num1 = 0.0f;
      while (iterator.hasNext())
      {
        TextLine textLine = (TextLine) iterator.next();
        Size2D size2D2 = textLine.calculateDimensions(g2);
        float num2 = 0.0f;
        if (this.lineAlignment == HorizontalAlignment.__\u003C\u003ECENTER)
          num2 = (float) (size2D1.getWidth() - size2D2.getWidth()) / 2f;
        else if (this.lineAlignment == HorizontalAlignment.__\u003C\u003ERIGHT)
          num2 = (float) (size2D1.getWidth() - size2D2.getWidth());
        textLine.draw(g2, anchorX + numArray[0] + num2, anchorY + numArray[1] + num1, TextAnchor.__\u003C\u003ETOP_LEFT, rotateX, rotateY, angle);
        num1 += (float) size2D2.getHeight();
      }
    }

    public virtual HorizontalAlignment getLineAlignment()
    {
      return this.lineAlignment;
    }

    [LineNumberTable(new byte[] {(byte) 59, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setLineAlignment(HorizontalAlignment alignment)
    {
      if (alignment == null)
      {
        string str = "Null 'alignment' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.lineAlignment = alignment;
    }

    [LineNumberTable(new byte[] {(byte) 73, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addLine(string text, Font font, Paint paint)
    {
      this.addLine(new TextLine(text, font, paint));
    }

    [LineNumberTable(new byte[] {(byte) 91, (byte) 98, (byte) 110, (byte) 100, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual TextLine getLastLine()
    {
      TextLine textLine = (TextLine) null;
      int num = this.lines.size() - 1;
      if (num >= 0)
        textLine = (TextLine) this.lines.get(num);
      return textLine;
    }

    [LineNumberTable((ushort) 155)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getLines()
    {
      return Collections.unmodifiableList(this.lines);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 83, (byte) 104, (byte) 181, (byte) 223, (byte) 3, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Shape calculateBounds(Graphics2D g2, float anchorX, float anchorY, TextBlockAnchor anchor, float rotateX, float rotateY, double angle)
    {
      Size2D size2D = this.calculateDimensions(g2);
      float[] numArray = this.calculateOffsets(anchor, size2D.getWidth(), size2D.getHeight());
      return ShapeUtilities.rotateShape((Shape) new Rectangle2D.Double((double) (anchorX + numArray[0]), (double) (anchorY + numArray[1]), size2D.getWidth(), size2D.getHeight()), angle, rotateX, rotateY);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 108, (byte) 126})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, float x, float y, TextBlockAnchor anchor)
    {
      this.draw(g2, x, y, anchor, 0.0f, 0.0f, 0.0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 221, (byte) 100, (byte) 130, (byte) 104, (byte) 103, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is TextBlock))
        return false;
      return (Object.instancehelper_equals((object) this.lines, (object) ((TextBlock) obj).lines) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 351)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      if (this.lines != null)
        return Object.instancehelper_hashCode((object) this.lines);
      else
        return 0;
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
