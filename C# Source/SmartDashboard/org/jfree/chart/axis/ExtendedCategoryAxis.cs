// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.ExtendedCategoryAxis
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart.@event;
using org.jfree.io;
using org.jfree.text;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Serializable]
  public class ExtendedCategoryAxis : CategoryAxis
  {
    internal const long serialVersionUID = -3004429093959826567L;
    private Map sublabels;
    private Font sublabelFont;
    [NonSerialized]
    private Paint sublabelPaint;

    [HideFromJava]
    static ExtendedCategoryAxis()
    {
      CategoryAxis.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 39, (byte) 105, (byte) 107, (byte) 115, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExtendedCategoryAxis(string label)
      : base(label)
    {
      ExtendedCategoryAxis extendedCategoryAxis = this;
      this.sublabels = (Map) new HashMap();
      this.sublabelFont = new Font("SansSerif", 0, 10);
      this.sublabelPaint = (Paint) Color.black;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ExtendedCategoryAxis([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    public virtual Font getSubLabelFont()
    {
      return this.sublabelFont;
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSubLabelFont(Font font)
    {
      if (font == null)
      {
        string str = "Null 'font' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.sublabelFont = font;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    public virtual Paint getSubLabelPaint()
    {
      return this.sublabelPaint;
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 99, (byte) 144, (byte) 103, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSubLabelPaint(Paint paint)
    {
      if (paint == null)
      {
        string str = "Null 'paint' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.sublabelPaint = paint;
        this.notifyListeners(new AxisChangeEvent((Axis) this));
      }
    }

    [LineNumberTable(new byte[] {(byte) 106, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addSubLabel(IComparable category, string label)
    {
      this.sublabels.put((object) category, (object) label);
    }

    [LineNumberTable(new byte[] {(byte) 122, (byte) 109, (byte) 114, (byte) 102, (byte) 112, (byte) 147, (byte) 103, (byte) 98, (byte) 144, (byte) 103, (byte) 99, (byte) 255, (byte) 23, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override TextBlock createLabel(IComparable category, float width, RectangleEdge edge, Graphics2D g2)
    {
      TextBlock label = base.createLabel(category, width, edge, g2);
      string text = (string) this.sublabels.get((object) category);
      if (text != null)
      {
        if (edge == RectangleEdge.__\u003C\u003ETOP || edge == RectangleEdge.__\u003C\u003EBOTTOM)
        {
          TextLine line = new TextLine(text, this.sublabelFont, this.sublabelPaint);
          label.addLine(line);
        }
        else if (edge == RectangleEdge.__\u003C\u003ELEFT || edge == RectangleEdge.__\u003C\u003ERIGHT)
        {
          TextLine lastLine = label.getLastLine();
          if (lastLine != null)
          {
            TextLine textLine = lastLine;
            TextFragment.__\u003Cclinit\u003E();
            TextFragment fragment = new TextFragment(new StringBuffer().append("  ").append(text).toString(), this.sublabelFont, this.sublabelPaint);
            textLine.addFragment(fragment);
          }
        }
      }
      return label;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 86, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ExtendedCategoryAxis))
        return false;
      ExtendedCategoryAxis extendedCategoryAxis = (ExtendedCategoryAxis) obj;
      if (!this.sublabelFont.equals((object) extendedCategoryAxis.sublabelFont) || !PaintUtilities.equal(this.sublabelPaint, extendedCategoryAxis.sublabelPaint) || !Object.instancehelper_equals((object) this.sublabels, (object) extendedCategoryAxis.sublabels))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 113, (byte) 108, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      ExtendedCategoryAxis extendedCategoryAxis = (ExtendedCategoryAxis) base.clone();
      extendedCategoryAxis.sublabels = (Map) new HashMap(this.sublabels);
      return (object) extendedCategoryAxis;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 102, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void writeObject([In] ObjectOutputStream obj0)
    {
      obj0.defaultWriteObject();
      SerialUtilities.writePaint(this.sublabelPaint, obj0);
    }

    [Throws(new string[] {"java.io.IOException", "java.lang.ClassNotFoundException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 140, (byte) 102, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readObject([In] ObjectInputStream obj0)
    {
      obj0.defaultReadObject();
      this.sublabelPaint = SerialUtilities.readPaint(obj0);
    }
  }
}
