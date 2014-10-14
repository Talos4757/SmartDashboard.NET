// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.RectangleInsets
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class RectangleInsets : Object, Serializable.__Interface, ISerializable
  {
    internal static RectangleInsets __\u003C\u003EZERO_INSETS = new RectangleInsets(UnitType.__\u003C\u003EABSOLUTE, 0.0, 0.0, 0.0, 0.0);
    private const long serialVersionUID = 1902273207559319996L;
    private UnitType unitType;
    private double top;
    private double left;
    private double bottom;
    private double right;

    [Modifiers]
    public static RectangleInsets ZERO_INSETS
    {
      [HideFromJava] get
      {
        return RectangleInsets.__\u003C\u003EZERO_INSETS;
      }
    }

    [LineNumberTable((ushort) 70)]
    static RectangleInsets()
    {
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RectangleInsets(double top, double left, double bottom, double right)
      : this(UnitType.__\u003C\u003EABSOLUTE, top, left, bottom, right)
    {
    }

    [LineNumberTable(new byte[] {(byte) 72, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 105, (byte) 106, (byte) 105, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RectangleInsets(UnitType unitType, double top, double left, double bottom, double right)
    {
      base.\u002Ector();
      RectangleInsets rectangleInsets = this;
      if (unitType == null)
      {
        string str = "Null 'unitType' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.unitType = unitType;
        this.top = top;
        this.bottom = bottom;
        this.left = left;
        this.right = right;
      }
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 124})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RectangleInsets()
      : this(1.0, 1.0, 1.0, 1.0)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected RectangleInsets([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] RectangleInsets obj0)
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

    [LineNumberTable((ushort) 520)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double extendWidth(double width)
    {
      return width + this.calculateLeftOutset(width) + this.calculateRightOutset(width);
    }

    [LineNumberTable((ushort) 543)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double extendHeight(double height)
    {
      return height + this.calculateTopOutset(height) + this.calculateBottomOutset(height);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 79, (byte) 103, (byte) 109, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double calculateLeftInset(double width)
    {
      double num = this.left;
      if (this.unitType == UnitType.__\u003C\u003ERELATIVE)
        num = this.left * width;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 19, (byte) 103, (byte) 109, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double calculateTopInset(double height)
    {
      double num = this.top;
      if (this.unitType == UnitType.__\u003C\u003ERELATIVE)
        num = this.top * height;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 106, (byte) 119, (byte) 125, (byte) 109, (byte) 125, (byte) 109, (byte) 125, (byte) 109, (byte) 125, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      int num1 = this.unitType == null ? 0 : this.unitType.hashCode();
      long num2 = this.top == 0.0 ? 0L : Double.doubleToLongBits(this.top);
      int num3 = 29 * num1 + (int) (num2 ^ (long) ((ulong) num2 >> 32));
      long num4 = this.bottom == 0.0 ? 0L : Double.doubleToLongBits(this.bottom);
      int num5 = 29 * num3 + (int) (num4 ^ (long) ((ulong) num4 >> 32));
      long num6 = this.left == 0.0 ? 0L : Double.doubleToLongBits(this.left);
      int num7 = 29 * num5 + (int) (num6 ^ (long) ((ulong) num6 >> 32));
      long num8 = this.right == 0.0 ? 0L : Double.doubleToLongBits(this.right);
      return 29 * num7 + (int) (num8 ^ (long) ((ulong) num8 >> 32));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 94, (byte) 103, (byte) 109, (byte) 159, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double calculateLeftOutset(double width)
    {
      double num = this.left;
      if (this.unitType == UnitType.__\u003C\u003ERELATIVE)
        num = width / (1.0 - this.left - this.right) * this.left;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 124, (byte) 103, (byte) 109, (byte) 159, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double calculateRightOutset(double width)
    {
      double num = this.right;
      if (this.unitType == UnitType.__\u003C\u003ERELATIVE)
        num = width / (1.0 - this.left - this.right) * this.right;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 109, (byte) 103, (byte) 109, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double calculateRightInset(double width)
    {
      double num = this.right;
      if (this.unitType == UnitType.__\u003C\u003ERELATIVE)
        num = this.right * width;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 34, (byte) 103, (byte) 109, (byte) 159, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double calculateTopOutset(double height)
    {
      double num = this.top;
      if (this.unitType == UnitType.__\u003C\u003ERELATIVE)
        num = height / (1.0 - this.top - this.bottom) * this.top;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 64, (byte) 103, (byte) 109, (byte) 159, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double calculateBottomOutset(double height)
    {
      double num = this.bottom;
      if (this.unitType == UnitType.__\u003C\u003ERELATIVE)
        num = height / (1.0 - this.top - this.bottom) * this.bottom;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 49, (byte) 103, (byte) 109, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double calculateBottomInset(double height)
    {
      double num = this.bottom;
      if (this.unitType == UnitType.__\u003C\u003ERELATIVE)
        num = this.bottom * height;
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 64, (byte) 68, (byte) 99, (byte) 144, (byte) 102, (byte) 102, (byte) 99, (byte) 110, (byte) 142, (byte) 103, (byte) 103, (byte) 99, (byte) 111, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Rectangle2D createInsetRectangle(Rectangle2D @base, bool horizontal, bool vertical)
    {
      int num1 = vertical ? 1 : 0;
      int num2 = horizontal ? 1 : 0;
      if (@base == null)
      {
        string str = "Null 'base' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num3 = 0.0;
        double num4 = 0.0;
        if (num1 != 0)
        {
          num3 = this.calculateTopInset(((RectangularShape) @base).getHeight());
          num4 = this.calculateBottomInset(((RectangularShape) @base).getHeight());
        }
        double num5 = 0.0;
        double num6 = 0.0;
        if (num2 != 0)
        {
          num5 = this.calculateLeftInset(((RectangularShape) @base).getWidth());
          num6 = this.calculateRightInset(((RectangularShape) @base).getWidth());
        }
        return (Rectangle2D) new Rectangle2D.Double(((RectangularShape) @base).getX() + num5, ((RectangularShape) @base).getY() + num3, ((RectangularShape) @base).getWidth() - num5 - num6, ((RectangularShape) @base).getHeight() - num3 - num4);
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 53, (byte) 132, (byte) 99, (byte) 144, (byte) 102, (byte) 102, (byte) 99, (byte) 110, (byte) 142, (byte) 103, (byte) 103, (byte) 99, (byte) 111, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Rectangle2D createOutsetRectangle(Rectangle2D @base, bool horizontal, bool vertical)
    {
      int num1 = vertical ? 1 : 0;
      int num2 = horizontal ? 1 : 0;
      if (@base == null)
      {
        string str = "Null 'base' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double num3 = 0.0;
        double num4 = 0.0;
        if (num1 != 0)
        {
          num3 = this.calculateTopOutset(((RectangularShape) @base).getHeight());
          num4 = this.calculateBottomOutset(((RectangularShape) @base).getHeight());
        }
        double num5 = 0.0;
        double num6 = 0.0;
        if (num2 != 0)
        {
          num5 = this.calculateLeftOutset(((RectangularShape) @base).getWidth());
          num6 = this.calculateRightOutset(((RectangularShape) @base).getWidth());
        }
        return (Rectangle2D) new Rectangle2D.Double(((RectangularShape) @base).getX() - num5, ((RectangularShape) @base).getY() - num3, ((RectangularShape) @base).getWidth() + num5 + num6, ((RectangularShape) @base).getHeight() + num3 + num4);
      }
    }

    public virtual UnitType getUnitType()
    {
      return this.unitType;
    }

    public virtual double getTop()
    {
      return this.top;
    }

    public virtual double getBottom()
    {
      return this.bottom;
    }

    public virtual double getLeft()
    {
      return this.left;
    }

    public virtual double getRight()
    {
      return this.right;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 73, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is RectangleInsets))
        return false;
      RectangleInsets rectangleInsets = (RectangleInsets) obj;
      return rectangleInsets.unitType == this.unitType && this.left == rectangleInsets.left && (this.right == rectangleInsets.right && this.top == rectangleInsets.top) && this.bottom == rectangleInsets.bottom;
    }

    [LineNumberTable((ushort) 239)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      return new StringBuffer().append("RectangleInsets[t=").append(this.top).append(",l=").append(this.left).append(",b=").append(this.bottom).append(",r=").append(this.right).append("]").toString();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 145, (byte) 99, (byte) 144, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 106, (byte) 102, (byte) 110, (byte) 98, (byte) 104, (byte) 106, (byte) 102, (byte) 142, (byte) 104, (byte) 106, (byte) 102, (byte) 110, (byte) 98, (byte) 104, (byte) 106, (byte) 102, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Rectangle2D createAdjustedRectangle(Rectangle2D @base, LengthAdjustmentType horizontal, LengthAdjustmentType vertical)
    {
      if (@base == null)
      {
        string str = "Null 'base' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        double x = ((RectangularShape) @base).getX();
        double y = ((RectangularShape) @base).getY();
        double width = ((RectangularShape) @base).getWidth();
        double height = ((RectangularShape) @base).getHeight();
        if (horizontal == LengthAdjustmentType.__\u003C\u003EEXPAND)
        {
          double num = this.calculateLeftOutset(width);
          x -= num;
          width = width + num + this.calculateRightOutset(width);
        }
        else if (horizontal == LengthAdjustmentType.__\u003C\u003ECONTRACT)
        {
          double num = this.calculateLeftInset(width);
          x += num;
          width = width - num - this.calculateRightInset(width);
        }
        if (vertical == LengthAdjustmentType.__\u003C\u003EEXPAND)
        {
          double num = this.calculateTopOutset(height);
          y -= num;
          height = height + num + this.calculateBottomOutset(height);
        }
        else if (vertical == LengthAdjustmentType.__\u003C\u003ECONTRACT)
        {
          double num = this.calculateTopInset(height);
          y += num;
          height = height - num - this.calculateBottomInset(height);
        }
        return (Rectangle2D) new Rectangle2D.Double(x, y, width, height);
      }
    }

    [LineNumberTable((ushort) 297)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Rectangle2D createInsetRectangle(Rectangle2D @base)
    {
      return this.createInsetRectangle(@base, true, true);
    }

    [LineNumberTable((ushort) 343)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Rectangle2D createOutsetRectangle(Rectangle2D @base)
    {
      return this.createOutsetRectangle(@base, true, true);
    }

    [LineNumberTable((ushort) 509)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double trimWidth(double width)
    {
      return width - this.calculateLeftInset(width) - this.calculateRightInset(width);
    }

    [LineNumberTable((ushort) 531)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double trimHeight(double height)
    {
      return height - this.calculateTopInset(height) - this.calculateBottomInset(height);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 183, (byte) 104, (byte) 104, (byte) 105, (byte) 105, (byte) 106, (byte) 106, (byte) 127, (byte) 6})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void trim(Rectangle2D area)
    {
      double width = ((RectangularShape) area).getWidth();
      double height = ((RectangularShape) area).getHeight();
      double num1 = this.calculateLeftInset(width);
      double num2 = this.calculateRightInset(width);
      double num3 = this.calculateTopInset(height);
      double num4 = this.calculateBottomInset(height);
      area.setRect(((RectangularShape) area).getX() + num1, ((RectangularShape) area).getY() + num3, width - num1 - num2, height - num3 - num4);
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
