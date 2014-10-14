// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.ColumnArrangement
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
  public class ColumnArrangement : Object, Arrangement, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -5315388482898581555L;
    private HorizontalAlignment horizontalAlignment;
    private VerticalAlignment verticalAlignment;
    private double horizontalGap;
    private double verticalGap;

    [LineNumberTable(new byte[] {(byte) 27, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColumnArrangement()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 40, (byte) 104, (byte) 103, (byte) 103, (byte) 105, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColumnArrangement(HorizontalAlignment hAlign, VerticalAlignment vAlign, double hGap, double vGap)
    {
      base.\u002Ector();
      ColumnArrangement columnArrangement = this;
      this.horizontalAlignment = hAlign;
      this.verticalAlignment = vAlign;
      this.horizontalGap = hGap;
      this.verticalGap = vGap;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ColumnArrangement([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ColumnArrangement obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 197, (byte) 102, (byte) 102, (byte) 102, (byte) 103, (byte) 104, (byte) 104, (byte) 109, (byte) 112, (byte) 111, (byte) 114, (byte) 110, (byte) 114, (byte) 255, (byte) 7, (byte) 69, (byte) 245, (byte) 54, (byte) 235, (byte) 76, (byte) 101, (byte) 144, (byte) 109, (byte) 141, (byte) 207, (byte) 237, (byte) 58, (byte) 232, (byte) 77})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeNN(BlockContainer container, Graphics2D g2)
    {
      double num1 = 0.0;
      double height = 0.0;
      double width = 0.0;
      List blocks = container.getBlocks();
      int num2 = blocks.size();
      if (num2 > 0)
      {
        Size2D[] size2DArray = new Size2D[blocks.size()];
        for (int index = 0; index < blocks.size(); ++index)
        {
          Block block = (Block) blocks.get(index);
          size2DArray[index] = block.arrange(g2, RectangleConstraint.__\u003C\u003ENONE);
          height += size2DArray[index].getHeight();
          width = Math.max(size2DArray[index].width, width);
          block.setBounds((Rectangle2D) new Rectangle2D.Double(0.0, num1, size2DArray[index].width, size2DArray[index].height));
          num1 = num1 + size2DArray[index].height + this.verticalGap;
        }
        if (num2 > 1)
          height += this.verticalGap * (double) (num2 - 1);
        if (this.horizontalAlignment != HorizontalAlignment.__\u003C\u003ELEFT)
        {
          for (int index = 0; index < blocks.size(); ++index)
          {
            if (this.horizontalAlignment == HorizontalAlignment.__\u003C\u003ECENTER || this.horizontalAlignment != HorizontalAlignment.__\u003C\u003ERIGHT)
              ;
          }
        }
      }
      return new Size2D(width, height);
    }

    [LineNumberTable((ushort) 179)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeFF(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      return this.arrangeNF(container, g2, constraint);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 175, (byte) 106, (byte) 115, (byte) 162, (byte) 184})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeRF(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      Size2D size2D = this.arrangeNF(container, g2, constraint);
      if (constraint.getWidthRange().contains(size2D.width))
        return size2D;
      RectangleConstraint constraint1 = constraint.toFixedWidth(constraint.getWidthRange().constrain(size2D.getWidth()));
      return this.arrangeFF(container, g2, constraint1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 150, (byte) 105, (byte) 115, (byte) 162, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeRR(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      Size2D size2D = this.arrangeNN(container, g2);
      if (constraint.getHeightRange().contains(size2D.height))
        return size2D;
      RectangleConstraint constraint1 = constraint.toFixedHeight(constraint.getHeightRange().getUpperBound());
      return this.arrangeRF(container, g2, constraint1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 83, (byte) 135, (byte) 104, (byte) 104, (byte) 170, (byte) 102, (byte) 102, (byte) 103, (byte) 103, (byte) 112, (byte) 111, (byte) 111, (byte) 108, (byte) 106, (byte) 188, (byte) 114, (byte) 182, (byte) 137, (byte) 255, (byte) 5, (byte) 69, (byte) 102, (byte) 215, (byte) 103, (byte) 109, (byte) 102, (byte) 105, (byte) 255, (byte) 3, (byte) 69, (byte) 112, (byte) 234, (byte) 30, (byte) 235, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeNF(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      List blocks = container.getBlocks();
      double num1 = constraint.getHeight();
      if (num1 <= 0.0)
        num1 = double.PositiveInfinity;
      double num2 = 0.0;
      double num3 = 0.0;
      double num4 = 0.0;
      ArrayList arrayList = new ArrayList();
      for (int index = 0; index < blocks.size(); ++index)
      {
        Block block = (Block) blocks.get(index);
        Size2D size2D = block.arrange(g2, RectangleConstraint.__\u003C\u003ENONE);
        if (num3 + size2D.height <= num1)
        {
          ((List) arrayList).add((object) block);
          block.setBounds((Rectangle2D) new Rectangle2D.Double(num2, num3, size2D.width, size2D.height));
          num3 = num3 + size2D.height + this.verticalGap;
          num4 = Math.max(num4, size2D.width);
        }
        else if (((List) arrayList).isEmpty())
        {
          block.setBounds((Rectangle2D) new Rectangle2D.Double(num2, num3, size2D.width, Math.min(size2D.height, num1 - num3)));
          num3 = 0.0;
          num2 = num2 + size2D.width + this.horizontalGap;
        }
        else
        {
          ((List) arrayList).clear();
          num2 = num2 + num4 + this.horizontalGap;
          double num5 = 0.0;
          num4 = size2D.width;
          block.setBounds((Rectangle2D) new Rectangle2D.Double(num2, num5, size2D.width, Math.min(size2D.height, num1)));
          num3 = size2D.height + this.verticalGap;
          ((List) arrayList).add((object) block);
        }
      }
      return new Size2D(num2 + num4, constraint.getHeight());
    }

    public virtual void add(Block block, object key)
    {
    }

    [LineNumberTable(new byte[] {(byte) 75, (byte) 103, (byte) 103, (byte) 104, (byte) 104, (byte) 139, (byte) 104, (byte) 144, (byte) 107, (byte) 176, (byte) 104, (byte) 104, (byte) 144, (byte) 104, (byte) 140, (byte) 104, (byte) 176, (byte) 104, (byte) 104, (byte) 144, (byte) 104, (byte) 140, (byte) 104, (byte) 172})]
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
        {
          string str = "Not implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
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
        {
          string str = "Not implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
          return this.arrangeFF(container, g2, constraint);
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
        {
          string str = "Not implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
      }
      else if (widthConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
      {
        if (heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
        {
          string str = "Not implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
          return this.arrangeRF(container, g2, constraint);
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
          return this.arrangeRR(container, g2, constraint);
      }
      return new Size2D();
    }

    public virtual void clear()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 251, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ColumnArrangement))
        return false;
      ColumnArrangement columnArrangement = (ColumnArrangement) obj;
      return this.horizontalAlignment == columnArrangement.horizontalAlignment && this.verticalAlignment == columnArrangement.verticalAlignment && (this.horizontalGap == columnArrangement.horizontalGap && this.verticalGap == columnArrangement.verticalGap);
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
