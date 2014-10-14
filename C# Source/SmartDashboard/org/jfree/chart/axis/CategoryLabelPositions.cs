// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.CategoryLabelPositions
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using org.jfree.text;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class CategoryLabelPositions : Object, Serializable.__Interface, ISerializable
  {
    internal static CategoryLabelPositions __\u003C\u003ESTANDARD = new CategoryLabelPositions(new CategoryLabelPosition(RectangleAnchor.__\u003C\u003EBOTTOM, TextBlockAnchor.__\u003C\u003EBOTTOM_CENTER), new CategoryLabelPosition(RectangleAnchor.__\u003C\u003ETOP, TextBlockAnchor.__\u003C\u003ETOP_CENTER), new CategoryLabelPosition(RectangleAnchor.__\u003C\u003ERIGHT, TextBlockAnchor.__\u003C\u003ECENTER_RIGHT, CategoryLabelWidthType.__\u003C\u003ERANGE, 0.3f), new CategoryLabelPosition(RectangleAnchor.__\u003C\u003ELEFT, TextBlockAnchor.__\u003C\u003ECENTER_LEFT, CategoryLabelWidthType.__\u003C\u003ERANGE, 0.3f));
    internal static CategoryLabelPositions __\u003C\u003EUP_90 = new CategoryLabelPositions(new CategoryLabelPosition(RectangleAnchor.__\u003C\u003EBOTTOM, TextBlockAnchor.__\u003C\u003ECENTER_LEFT, TextAnchor.__\u003C\u003ECENTER_LEFT, -1.0 * Math.PI / 2.0, CategoryLabelWidthType.__\u003C\u003ERANGE, 0.3f), new CategoryLabelPosition(RectangleAnchor.__\u003C\u003ETOP, TextBlockAnchor.__\u003C\u003ECENTER_RIGHT, TextAnchor.__\u003C\u003ECENTER_RIGHT, -1.0 * Math.PI / 2.0, CategoryLabelWidthType.__\u003C\u003ERANGE, 0.3f), new CategoryLabelPosition(RectangleAnchor.__\u003C\u003ERIGHT, TextBlockAnchor.__\u003C\u003EBOTTOM_CENTER, TextAnchor.__\u003C\u003EBOTTOM_CENTER, -1.0 * Math.PI / 2.0, CategoryLabelWidthType.__\u003C\u003ECATEGORY, 0.9f), new CategoryLabelPosition(RectangleAnchor.__\u003C\u003ELEFT, TextBlockAnchor.__\u003C\u003ETOP_CENTER, TextAnchor.__\u003C\u003ETOP_CENTER, -1.0 * Math.PI / 2.0, CategoryLabelWidthType.__\u003C\u003ECATEGORY, 0.9f));
    internal static CategoryLabelPositions __\u003C\u003EDOWN_90 = new CategoryLabelPositions(new CategoryLabelPosition(RectangleAnchor.__\u003C\u003EBOTTOM, TextBlockAnchor.__\u003C\u003ECENTER_RIGHT, TextAnchor.__\u003C\u003ECENTER_RIGHT, Math.PI / 2.0, CategoryLabelWidthType.__\u003C\u003ERANGE, 0.3f), new CategoryLabelPosition(RectangleAnchor.__\u003C\u003ETOP, TextBlockAnchor.__\u003C\u003ECENTER_LEFT, TextAnchor.__\u003C\u003ECENTER_LEFT, Math.PI / 2.0, CategoryLabelWidthType.__\u003C\u003ERANGE, 0.3f), new CategoryLabelPosition(RectangleAnchor.__\u003C\u003ERIGHT, TextBlockAnchor.__\u003C\u003ETOP_CENTER, TextAnchor.__\u003C\u003ETOP_CENTER, Math.PI / 2.0, CategoryLabelWidthType.__\u003C\u003ECATEGORY, 0.9f), new CategoryLabelPosition(RectangleAnchor.__\u003C\u003ELEFT, TextBlockAnchor.__\u003C\u003EBOTTOM_CENTER, TextAnchor.__\u003C\u003EBOTTOM_CENTER, Math.PI / 2.0, CategoryLabelWidthType.__\u003C\u003ECATEGORY, 0.9f));
    internal static CategoryLabelPositions __\u003C\u003EUP_45 = CategoryLabelPositions.createUpRotationLabelPositions(Math.PI / 4.0);
    internal static CategoryLabelPositions __\u003C\u003EDOWN_45 = CategoryLabelPositions.createDownRotationLabelPositions(Math.PI / 4.0);
    private const long serialVersionUID = -8999557901920364580L;
    private CategoryLabelPosition positionForAxisAtTop;
    private CategoryLabelPosition positionForAxisAtBottom;
    private CategoryLabelPosition positionForAxisAtLeft;
    private CategoryLabelPosition positionForAxisAtRight;

    [Modifiers]
    public static CategoryLabelPositions STANDARD
    {
      [HideFromJava] get
      {
        return CategoryLabelPositions.__\u003C\u003ESTANDARD;
      }
    }

    [Modifiers]
    public static CategoryLabelPositions UP_90
    {
      [HideFromJava] get
      {
        return CategoryLabelPositions.__\u003C\u003EUP_90;
      }
    }

    [Modifiers]
    public static CategoryLabelPositions DOWN_90
    {
      [HideFromJava] get
      {
        return CategoryLabelPositions.__\u003C\u003EDOWN_90;
      }
    }

    [Modifiers]
    public static CategoryLabelPositions UP_45
    {
      [HideFromJava] get
      {
        return CategoryLabelPositions.__\u003C\u003EUP_45;
      }
    }

    [Modifiers]
    public static CategoryLabelPositions DOWN_45
    {
      [HideFromJava] get
      {
        return CategoryLabelPositions.__\u003C\u003EDOWN_45;
      }
    }

    [LineNumberTable(new byte[] {(byte) 13, (byte) 255, (byte) 59, (byte) 83, (byte) 255, (byte) 160, (byte) 71, (byte) 89, (byte) 255, (byte) 160, (byte) 71, (byte) 88, (byte) 211})]
    static CategoryLabelPositions()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 141, (byte) 136, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 99, (byte) 144, (byte) 100, (byte) 176, (byte) 103, (byte) 103, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryLabelPositions(CategoryLabelPosition top, CategoryLabelPosition bottom, CategoryLabelPosition left, CategoryLabelPosition right)
    {
      base.\u002Ector();
      CategoryLabelPositions categoryLabelPositions = this;
      if (top == null)
      {
        string str = "Null 'top' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (bottom == null)
      {
        string str = "Null 'bottom' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (left == null)
      {
        string str = "Null 'left' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (right == null)
      {
        string str = "Null 'right' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.positionForAxisAtTop = top;
        this.positionForAxisAtBottom = bottom;
        this.positionForAxisAtLeft = left;
        this.positionForAxisAtRight = right;
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 119, (byte) 104, (byte) 107, (byte) 107, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CategoryLabelPositions()
    {
      base.\u002Ector();
      CategoryLabelPositions categoryLabelPositions = this;
      this.positionForAxisAtTop = new CategoryLabelPosition();
      this.positionForAxisAtBottom = new CategoryLabelPosition();
      this.positionForAxisAtLeft = new CategoryLabelPosition();
      this.positionForAxisAtRight = new CategoryLabelPosition();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CategoryLabelPositions([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CategoryLabelPositions obj0)
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

    [LineNumberTable(new byte[] {(byte) 160, (byte) 172, (byte) 98, (byte) 104, (byte) 137, (byte) 104, (byte) 137, (byte) 104, (byte) 137, (byte) 104, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual CategoryLabelPosition getLabelPosition(RectangleEdge edge)
    {
      CategoryLabelPosition categoryLabelPosition = (CategoryLabelPosition) null;
      if (edge == RectangleEdge.__\u003C\u003ETOP)
        categoryLabelPosition = this.positionForAxisAtTop;
      else if (edge == RectangleEdge.__\u003C\u003EBOTTOM)
        categoryLabelPosition = this.positionForAxisAtBottom;
      else if (edge == RectangleEdge.__\u003C\u003ELEFT)
        categoryLabelPosition = this.positionForAxisAtLeft;
      else if (edge == RectangleEdge.__\u003C\u003ERIGHT)
        categoryLabelPosition = this.positionForAxisAtRight;
      return categoryLabelPosition;
    }

    [LineNumberTable((ushort) 148)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CategoryLabelPositions createUpRotationLabelPositions(double angle)
    {
      return new CategoryLabelPositions(new CategoryLabelPosition(RectangleAnchor.__\u003C\u003EBOTTOM, TextBlockAnchor.__\u003C\u003EBOTTOM_LEFT, TextAnchor.__\u003C\u003EBOTTOM_LEFT, -angle, CategoryLabelWidthType.__\u003C\u003ERANGE, 0.5f), new CategoryLabelPosition(RectangleAnchor.__\u003C\u003ETOP, TextBlockAnchor.__\u003C\u003ETOP_RIGHT, TextAnchor.__\u003C\u003ETOP_RIGHT, -angle, CategoryLabelWidthType.__\u003C\u003ERANGE, 0.5f), new CategoryLabelPosition(RectangleAnchor.__\u003C\u003ERIGHT, TextBlockAnchor.__\u003C\u003EBOTTOM_RIGHT, TextAnchor.__\u003C\u003EBOTTOM_RIGHT, -angle, CategoryLabelWidthType.__\u003C\u003ERANGE, 0.5f), new CategoryLabelPosition(RectangleAnchor.__\u003C\u003ELEFT, TextBlockAnchor.__\u003C\u003ETOP_LEFT, TextAnchor.__\u003C\u003ETOP_LEFT, -angle, CategoryLabelWidthType.__\u003C\u003ERANGE, 0.5f));
    }

    [LineNumberTable((ushort) 182)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CategoryLabelPositions createDownRotationLabelPositions(double angle)
    {
      return new CategoryLabelPositions(new CategoryLabelPosition(RectangleAnchor.__\u003C\u003EBOTTOM, TextBlockAnchor.__\u003C\u003EBOTTOM_RIGHT, TextAnchor.__\u003C\u003EBOTTOM_RIGHT, angle, CategoryLabelWidthType.__\u003C\u003ERANGE, 0.5f), new CategoryLabelPosition(RectangleAnchor.__\u003C\u003ETOP, TextBlockAnchor.__\u003C\u003ETOP_LEFT, TextAnchor.__\u003C\u003ETOP_LEFT, angle, CategoryLabelWidthType.__\u003C\u003ERANGE, 0.5f), new CategoryLabelPosition(RectangleAnchor.__\u003C\u003ERIGHT, TextBlockAnchor.__\u003C\u003ETOP_RIGHT, TextAnchor.__\u003C\u003ETOP_RIGHT, angle, CategoryLabelWidthType.__\u003C\u003ERANGE, 0.5f), new CategoryLabelPosition(RectangleAnchor.__\u003C\u003ELEFT, TextBlockAnchor.__\u003C\u003EBOTTOM_LEFT, TextAnchor.__\u003C\u003EBOTTOM_LEFT, angle, CategoryLabelWidthType.__\u003C\u003ERANGE, 0.5f));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 200, (byte) 99, (byte) 144, (byte) 99, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CategoryLabelPositions replaceTopPosition(CategoryLabelPositions @base, CategoryLabelPosition top)
    {
      if (@base == null)
      {
        string str = "Null 'base' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (top == null)
      {
        string str = "Null 'top' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return new CategoryLabelPositions(top, @base.getLabelPosition(RectangleEdge.__\u003C\u003EBOTTOM), @base.getLabelPosition(RectangleEdge.__\u003C\u003ELEFT), @base.getLabelPosition(RectangleEdge.__\u003C\u003ERIGHT));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 227, (byte) 99, (byte) 144, (byte) 99, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CategoryLabelPositions replaceBottomPosition(CategoryLabelPositions @base, CategoryLabelPosition bottom)
    {
      if (@base == null)
      {
        string str = "Null 'base' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (bottom == null)
      {
        string str = "Null 'bottom' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return new CategoryLabelPositions(@base.getLabelPosition(RectangleEdge.__\u003C\u003ETOP), bottom, @base.getLabelPosition(RectangleEdge.__\u003C\u003ELEFT), @base.getLabelPosition(RectangleEdge.__\u003C\u003ERIGHT));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 254, (byte) 99, (byte) 144, (byte) 99, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CategoryLabelPositions replaceLeftPosition(CategoryLabelPositions @base, CategoryLabelPosition left)
    {
      if (@base == null)
      {
        string str = "Null 'base' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (left == null)
      {
        string str = "Null 'left' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return new CategoryLabelPositions(@base.getLabelPosition(RectangleEdge.__\u003C\u003ETOP), @base.getLabelPosition(RectangleEdge.__\u003C\u003EBOTTOM), left, @base.getLabelPosition(RectangleEdge.__\u003C\u003ERIGHT));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 25, (byte) 99, (byte) 144, (byte) 99, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CategoryLabelPositions replaceRightPosition(CategoryLabelPositions @base, CategoryLabelPosition right)
    {
      if (@base == null)
      {
        string str = "Null 'base' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (right == null)
      {
        string str = "Null 'right' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        return new CategoryLabelPositions(@base.getLabelPosition(RectangleEdge.__\u003C\u003ETOP), @base.getLabelPosition(RectangleEdge.__\u003C\u003EBOTTOM), @base.getLabelPosition(RectangleEdge.__\u003C\u003ELEFT), right);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 50, (byte) 100, (byte) 130, (byte) 104, (byte) 162, (byte) 103, (byte) 115, (byte) 130, (byte) 147, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (this == obj)
        return true;
      if (!(obj is CategoryLabelPositions))
        return false;
      CategoryLabelPositions categoryLabelPositions = (CategoryLabelPositions) obj;
      return this.positionForAxisAtTop.equals((object) categoryLabelPositions.positionForAxisAtTop) && this.positionForAxisAtBottom.equals((object) categoryLabelPositions.positionForAxisAtBottom) && (this.positionForAxisAtLeft.equals((object) categoryLabelPositions.positionForAxisAtLeft) && this.positionForAxisAtRight.equals((object) categoryLabelPositions.positionForAxisAtRight));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 82, (byte) 99, (byte) 113, (byte) 113, (byte) 113, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return 37 * (37 * (37 * (37 * 19 + this.positionForAxisAtTop.hashCode()) + this.positionForAxisAtBottom.hashCode()) + this.positionForAxisAtLeft.hashCode()) + this.positionForAxisAtRight.hashCode();
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
