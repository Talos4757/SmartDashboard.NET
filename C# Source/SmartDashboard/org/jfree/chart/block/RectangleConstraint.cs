// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.RectangleConstraint
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data;
using org.jfree.ui;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.block
{
  public class RectangleConstraint : Object
  {
    internal static RectangleConstraint __\u003C\u003ENONE = new RectangleConstraint(0.0, (Range) null, LengthConstraintType.__\u003C\u003ENONE, 0.0, (Range) null, LengthConstraintType.__\u003C\u003ENONE);
    private double width;
    private Range widthRange;
    private LengthConstraintType widthConstraintType;
    private double height;
    private Range heightRange;
    private LengthConstraintType heightConstraintType;

    [Modifiers]
    public static RectangleConstraint NONE
    {
      [HideFromJava] get
      {
        return RectangleConstraint.__\u003C\u003ENONE;
      }
    }

    [LineNumberTable((ushort) 59)]
    static RectangleConstraint()
    {
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 104, (byte) 99, (byte) 144, (byte) 100, (byte) 144, (byte) 105, (byte) 103, (byte) 103, (byte) 106, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RectangleConstraint(double w, Range widthRange, LengthConstraintType widthConstraintType, double h, Range heightRange, LengthConstraintType heightConstraintType)
    {
      base.\u002Ector();
      RectangleConstraint rectangleConstraint = this;
      if (widthConstraintType == null)
      {
        string str = "Null 'widthType' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (heightConstraintType == null)
      {
        string str = "Null 'heightType' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.width = w;
        this.widthRange = widthRange;
        this.widthConstraintType = widthConstraintType;
        this.height = h;
        this.heightRange = heightRange;
        this.heightConstraintType = heightConstraintType;
      }
    }

    [LineNumberTable(new byte[] {(byte) 48, (byte) 158})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RectangleConstraint(Range w, Range h)
      : this(0.0, w, LengthConstraintType.__\u003C\u003ERANGE, 0.0, h, LengthConstraintType.__\u003C\u003ERANGE)
    {
    }

    [LineNumberTable(new byte[] {(byte) 37, (byte) 152})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RectangleConstraint(double w, double h)
      : this(w, (Range) null, LengthConstraintType.__\u003C\u003EFIXED, h, (Range) null, LengthConstraintType.__\u003C\u003EFIXED)
    {
    }

    [LineNumberTable(new byte[] {(byte) 60, (byte) 155})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RectangleConstraint(Range w, double h)
      : this(0.0, w, LengthConstraintType.__\u003C\u003ERANGE, h, (Range) null, LengthConstraintType.__\u003C\u003EFIXED)
    {
    }

    [LineNumberTable(new byte[] {(byte) 72, (byte) 155})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RectangleConstraint(double w, Range h)
      : this(w, (Range) null, LengthConstraintType.__\u003C\u003EFIXED, 0.0, h, LengthConstraintType.__\u003C\u003ERANGE)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 211, (byte) 102, (byte) 112, (byte) 109, (byte) 109, (byte) 146, (byte) 109, (byte) 157, (byte) 112, (byte) 178, (byte) 112, (byte) 120, (byte) 109, (byte) 146, (byte) 109, (byte) 157, (byte) 112, (byte) 178, (byte) 112, (byte) 109, (byte) 109, (byte) 143, (byte) 109, (byte) 154, (byte) 109, (byte) 173})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Size2D calculateConstrainedSize(Size2D @base)
    {
      Size2D size2D = new Size2D();
      if (this.widthConstraintType == LengthConstraintType.__\u003C\u003ENONE)
      {
        size2D.width = @base.width;
        if (this.heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
          size2D.height = @base.height;
        else if (this.heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
          size2D.height = this.heightRange.constrain(@base.height);
        else if (this.heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
          size2D.height = this.height;
      }
      else if (this.widthConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
      {
        size2D.width = this.widthRange.constrain(@base.width);
        if (this.heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
          size2D.height = @base.height;
        else if (this.heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
          size2D.height = this.heightRange.constrain(@base.height);
        else if (this.heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
          size2D.height = this.height;
      }
      else if (this.widthConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
      {
        size2D.width = this.width;
        if (this.heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
          size2D.height = @base.height;
        else if (this.heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
          size2D.height = this.heightRange.constrain(@base.height);
        else if (this.heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
          size2D.height = this.height;
      }
      return size2D;
    }

    public virtual double getWidth()
    {
      return this.width;
    }

    public virtual Range getWidthRange()
    {
      return this.widthRange;
    }

    public virtual double getHeight()
    {
      return this.height;
    }

    public virtual Range getHeightRange()
    {
      return this.heightRange;
    }

    public virtual LengthConstraintType getWidthConstraintType()
    {
      return this.widthConstraintType;
    }

    public virtual LengthConstraintType getHeightConstraintType()
    {
      return this.heightConstraintType;
    }

    [LineNumberTable((ushort) 265)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleConstraint toFixedHeight(double height)
    {
      return new RectangleConstraint(this.width, this.widthRange, this.widthConstraintType, height, this.heightRange, LengthConstraintType.__\u003C\u003EFIXED);
    }

    [LineNumberTable((ushort) 251)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleConstraint toFixedWidth(double width)
    {
      return new RectangleConstraint(width, this.widthRange, LengthConstraintType.__\u003C\u003EFIXED, this.height, this.heightRange, this.heightConstraintType);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 118, (byte) 109, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleConstraint toUnconstrainedHeight()
    {
      if (this.heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
        return this;
      return new RectangleConstraint(this.width, this.widthRange, this.widthConstraintType, 0.0, this.heightRange, LengthConstraintType.__\u003C\u003ENONE);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 101, (byte) 109, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleConstraint toUnconstrainedWidth()
    {
      if (this.widthConstraintType == LengthConstraintType.__\u003C\u003ENONE)
        return this;
      return new RectangleConstraint(this.width, this.widthRange, LengthConstraintType.__\u003C\u003ENONE, this.height, this.heightRange, this.heightConstraintType);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 165, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleConstraint toRangeWidth(Range range)
    {
      if (range == null)
      {
        string str = "Null 'range' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return new RectangleConstraint(range.getUpperBound(), range, LengthConstraintType.__\u003C\u003ERANGE, this.height, this.heightRange, this.heightConstraintType);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 182, (byte) 99, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleConstraint toRangeHeight(Range range)
    {
      if (range == null)
      {
        string str = "Null 'range' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return new RectangleConstraint(this.width, this.widthRange, this.widthConstraintType, range.getUpperBound(), range, LengthConstraintType.__\u003C\u003ERANGE);
    }

    [LineNumberTable((ushort) 311)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append("RectangleConstraint[").append(this.widthConstraintType.toString()).append(": width=").append(this.width).append(", height=").append(this.height).append("]").toString();
    }
  }
}
