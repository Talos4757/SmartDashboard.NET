// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.title.ShortTextTitle
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.lang;
using org.jfree.chart.block;
using org.jfree.data;
using org.jfree.text;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.title
{
  [Serializable]
  public class ShortTextTitle : TextTitle
  {
    [HideFromJava]
    static ShortTextTitle()
    {
      TextTitle.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShortTextTitle(string text)
    {
      ShortTextTitle shortTextTitle = this;
      this.setText(text);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ShortTextTitle([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override Size2D arrangeNN(Graphics2D g2)
    {
      Range range = new Range(0.0, 3.40282346638529E+38);
      return this.arrangeRR(g2, range, range);
    }

    [LineNumberTable(new byte[] {(byte) 106, (byte) 104, (byte) 110, (byte) 130, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override Size2D arrangeRN(Graphics2D g2, Range widthRange)
    {
      Size2D size2D = this.arrangeNN(g2);
      if (widthRange.contains(size2D.getWidth()))
        return size2D;
      double w = widthRange.constrain(size2D.getWidth());
      return this.arrangeFN(g2, w);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 85, (byte) 108, (byte) 109, (byte) 110, (byte) 156, (byte) 180})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override Size2D arrangeRR(Graphics2D g2, Range widthRange, Range heightRange)
    {
      ((Graphics) g2).setFont(this.getFont());
      FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics(this.getFont());
      Rectangle2D textBounds = TextUtilities.getTextBounds(this.getText(), g2, fontMetrics);
      if (((RectangularShape) textBounds).getWidth() <= widthRange.getUpperBound() && ((RectangularShape) textBounds).getHeight() <= heightRange.getUpperBound())
        return new Size2D(((RectangularShape) textBounds).getWidth(), ((RectangularShape) textBounds).getHeight());
      else
        return new Size2D(0.0, 0.0);
    }

    [LineNumberTable(new byte[] {(byte) 126, (byte) 108, (byte) 109, (byte) 110, (byte) 106, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override Size2D arrangeFN(Graphics2D g2, double w)
    {
      ((Graphics) g2).setFont(this.getFont());
      FontMetrics fontMetrics = ((Graphics) g2).getFontMetrics(this.getFont());
      Rectangle2D textBounds = TextUtilities.getTextBounds(this.getText(), g2, fontMetrics);
      if (((RectangularShape) textBounds).getWidth() <= w)
        return new Size2D(w, ((RectangularShape) textBounds).getHeight());
      else
        return new Size2D(0.0, 0.0);
    }

    [LineNumberTable(new byte[] {(byte) 36, (byte) 104, (byte) 103, (byte) 103, (byte) 98, (byte) 104, (byte) 104, (byte) 141, (byte) 104, (byte) 144, (byte) 107, (byte) 176, (byte) 104, (byte) 104, (byte) 147, (byte) 104, (byte) 185, (byte) 107, (byte) 176, (byte) 104, (byte) 104, (byte) 144, (byte) 104, (byte) 144, (byte) 104, (byte) 176, (byte) 122, (byte) 178})]
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
      if (size2D.width <= 0.0 || size2D.height <= 0.0)
        return new Size2D(0.0, 0.0);
      else
        return new Size2D(this.calculateTotalWidth(size2D.getWidth()), this.calculateTotalHeight(size2D.getHeight()));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 107, (byte) 104, (byte) 130, (byte) 105, (byte) 104, (byte) 105, (byte) 105, (byte) 108, (byte) 108, (byte) 191, (byte) 1})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object draw(Graphics2D g2, Rectangle2D area, object @params)
    {
      if (((RectangularShape) area).isEmpty())
        return (object) null;
      area = this.trimMargin(area);
      this.drawBorder(g2, area);
      area = this.trimBorder(area);
      area = this.trimPadding(area);
      ((Graphics) g2).setFont(this.getFont());
      g2.setPaint(this.getPaint());
      TextUtilities.drawAlignedString(this.getText(), g2, (float) ((RectangularShape) area).getMinX(), (float) ((RectangularShape) area).getMinY(), TextAnchor.__\u003C\u003ETOP_LEFT);
      return (object) null;
    }
  }
}
