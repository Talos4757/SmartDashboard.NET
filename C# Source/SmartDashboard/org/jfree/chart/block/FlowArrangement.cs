// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.FlowArrangement
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
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.block
{
  [Implements(new string[] {"org.jfree.chart.block.Arrangement", "java.io.Serializable"})]
  [Serializable]
  public class FlowArrangement : Object, Arrangement, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 4543632485478613800L;
    private HorizontalAlignment horizontalAlignment;
    private VerticalAlignment verticalAlignment;
    private double horizontalGap;
    private double verticalGap;

    [LineNumberTable(new byte[] {(byte) 41, (byte) 104, (byte) 103, (byte) 103, (byte) 105, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlowArrangement(HorizontalAlignment hAlign, VerticalAlignment vAlign, double hGap, double vGap)
    {
      base.\u002Ector();
      FlowArrangement flowArrangement = this;
      this.horizontalAlignment = hAlign;
      this.verticalAlignment = vAlign;
      this.horizontalGap = hGap;
      this.verticalGap = vGap;
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 127, (byte) 5})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlowArrangement()
      : this(HorizontalAlignment.__\u003C\u003ECENTER, VerticalAlignment.__\u003C\u003ECENTER, 2.0, 2.0)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected FlowArrangement([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] FlowArrangement obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 242, (byte) 102, (byte) 102, (byte) 102, (byte) 103, (byte) 104, (byte) 104, (byte) 109, (byte) 112, (byte) 111, (byte) 114, (byte) 110, (byte) 114, (byte) 255, (byte) 7, (byte) 69, (byte) 245, (byte) 54, (byte) 235, (byte) 76, (byte) 101, (byte) 144, (byte) 109, (byte) 141, (byte) 175, (byte) 237, (byte) 59, (byte) 232, (byte) 76})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeNN(BlockContainer container, Graphics2D g2)
    {
      double num1 = 0.0;
      double width = 0.0;
      double height = 0.0;
      List blocks = container.getBlocks();
      int num2 = blocks.size();
      if (num2 > 0)
      {
        Size2D[] size2DArray = new Size2D[blocks.size()];
        for (int index = 0; index < blocks.size(); ++index)
        {
          Block block = (Block) blocks.get(index);
          size2DArray[index] = block.arrange(g2, RectangleConstraint.__\u003C\u003ENONE);
          width += size2DArray[index].getWidth();
          height = Math.max(size2DArray[index].height, height);
          block.setBounds((Rectangle2D) new Rectangle2D.Double(num1, 0.0, size2DArray[index].width, size2DArray[index].height));
          num1 = num1 + size2DArray[index].width + this.horizontalGap;
        }
        if (num2 > 1)
          width += this.horizontalGap * (double) (num2 - 1);
        if (this.verticalAlignment != VerticalAlignment.__\u003C\u003ETOP)
        {
          for (int index = 0; index < blocks.size(); ++index)
          {
            if (this.verticalAlignment == VerticalAlignment.__\u003C\u003ECENTER || this.verticalAlignment != VerticalAlignment.__\u003C\u003EBOTTOM)
              ;
          }
        }
      }
      return new Size2D(width, height);
    }

    [LineNumberTable((ushort) 407)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeNF(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      return this.arrangeNN(container, g2);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 64, (byte) 103, (byte) 136, (byte) 102, (byte) 102, (byte) 103, (byte) 103, (byte) 112, (byte) 111, (byte) 111, (byte) 108, (byte) 106, (byte) 188, (byte) 114, (byte) 182, (byte) 137, (byte) 255, (byte) 5, (byte) 69, (byte) 102, (byte) 215, (byte) 103, (byte) 102, (byte) 109, (byte) 105, (byte) 255, (byte) 3, (byte) 69, (byte) 112, (byte) 234, (byte) 30, (byte) 235, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeFN(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      List blocks = container.getBlocks();
      double width = constraint.getWidth();
      double num1 = 0.0;
      double num2 = 0.0;
      double num3 = 0.0;
      ArrayList arrayList = new ArrayList();
      for (int index = 0; index < blocks.size(); ++index)
      {
        Block block = (Block) blocks.get(index);
        Size2D size2D = block.arrange(g2, RectangleConstraint.__\u003C\u003ENONE);
        if (num1 + size2D.width <= width)
        {
          ((List) arrayList).add((object) block);
          block.setBounds((Rectangle2D) new Rectangle2D.Double(num1, num2, size2D.width, size2D.height));
          num1 = num1 + size2D.width + this.horizontalGap;
          num3 = Math.max(num3, size2D.height);
        }
        else if (((List) arrayList).isEmpty())
        {
          block.setBounds((Rectangle2D) new Rectangle2D.Double(num1, num2, Math.min(size2D.width, width - num1), size2D.height));
          num1 = 0.0;
          num2 = num2 + size2D.height + this.verticalGap;
        }
        else
        {
          ((List) arrayList).clear();
          double num4 = 0.0;
          num2 = num2 + num3 + this.verticalGap;
          num3 = size2D.height;
          block.setBounds((Rectangle2D) new Rectangle2D.Double(num4, num2, Math.min(size2D.width, width), size2D.height));
          num1 = size2D.width + this.horizontalGap;
          ((List) arrayList).add((object) block);
        }
      }
      return new Size2D(constraint.getWidth(), num2 + num3);
    }

    [LineNumberTable((ushort) 265)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeFF(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      return this.arrangeFN(container, g2, constraint);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 125, (byte) 106, (byte) 115, (byte) 162, (byte) 184})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeFR(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      Size2D size2D = this.arrangeFN(container, g2, constraint);
      if (constraint.getHeightRange().contains(size2D.height))
        return size2D;
      RectangleConstraint constraint1 = constraint.toFixedHeight(constraint.getHeightRange().constrain(size2D.getHeight()));
      return this.arrangeFF(container, g2, constraint1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 220, (byte) 105, (byte) 115, (byte) 162, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeRN(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      Size2D size2D = this.arrangeNN(container, g2);
      if (constraint.getWidthRange().contains(size2D.width))
        return size2D;
      RectangleConstraint constraint1 = constraint.toFixedWidth(constraint.getWidthRange().getUpperBound());
      return this.arrangeFN(container, g2, constraint1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 194, (byte) 106, (byte) 115, (byte) 162, (byte) 184})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeRF(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      Size2D size2D = this.arrangeNF(container, g2, constraint);
      if (constraint.getWidthRange().contains(size2D.width))
        return size2D;
      RectangleConstraint constraint1 = constraint.toFixedWidth(constraint.getWidthRange().constrain(size2D.getWidth()));
      return this.arrangeFF(container, g2, constraint1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 169, (byte) 105, (byte) 115, (byte) 162, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeRR(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      Size2D size2D = this.arrangeNN(container, g2);
      if (constraint.getWidthRange().contains(size2D.width))
        return size2D;
      RectangleConstraint constraint1 = constraint.toFixedWidth(constraint.getWidthRange().getUpperBound());
      return this.arrangeFR(container, g2, constraint1);
    }

    public virtual void add(Block block, object key)
    {
    }

    [LineNumberTable(new byte[] {(byte) 76, (byte) 103, (byte) 103, (byte) 104, (byte) 104, (byte) 139, (byte) 104, (byte) 140, (byte) 107, (byte) 176, (byte) 104, (byte) 104, (byte) 140, (byte) 104, (byte) 140, (byte) 104, (byte) 172, (byte) 104, (byte) 104, (byte) 140, (byte) 104, (byte) 140, (byte) 104, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Size2D arrange(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      LengthConstraintType widthConstraintType = constraint.getWidthConstraintType();
      LengthConstraintType heightConstraintType = constraint.getHeightConstraintType();
      if (widthConstraintType == LengthConstraintType.__\u003C\u003ENONE)
      {
        if (heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
          return this.arrangeNN(container, g2);
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
          return this.arrangeNF(container, g2, constraint);
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
        {
          string str = "Not implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
      }
      else if (widthConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
      {
        if (heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
          return this.arrangeFN(container, g2, constraint);
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
          return this.arrangeFF(container, g2, constraint);
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
          return this.arrangeFR(container, g2, constraint);
      }
      else if (widthConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
      {
        if (heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
          return this.arrangeRN(container, g2, constraint);
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
          return this.arrangeRF(container, g2, constraint);
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
          return this.arrangeRR(container, g2, constraint);
      }
      string str1 = "Unrecognised constraint type.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new RuntimeException(str1);
    }

    public virtual void clear()
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 55, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is FlowArrangement))
        return false;
      FlowArrangement flowArrangement = (FlowArrangement) obj;
      return this.horizontalAlignment == flowArrangement.horizontalAlignment && this.verticalAlignment == flowArrangement.verticalAlignment && (this.horizontalGap == flowArrangement.horizontalGap && this.verticalGap == flowArrangement.verticalGap);
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
