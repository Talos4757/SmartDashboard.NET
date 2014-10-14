// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.GridArrangement
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
  public class GridArrangement : Object, Arrangement, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -2563758090144655938L;
    private int rows;
    private int columns;

    [LineNumberTable(new byte[] {(byte) 23, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public GridArrangement(int rows, int columns)
    {
      base.\u002Ector();
      GridArrangement gridArrangement = this;
      this.rows = rows;
      this.columns = columns;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected GridArrangement([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] GridArrangement obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 106, (byte) 102, (byte) 102, (byte) 103, (byte) 103, (byte) 104, (byte) 109, (byte) 100, (byte) 111, (byte) 111, (byte) 143, (byte) 98, (byte) 108, (byte) 108, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeNN(BlockContainer container, Graphics2D g2)
    {
      double num1 = 0.0;
      double num2 = 0.0;
      Iterator iterator = container.getBlocks().iterator();
      while (iterator.hasNext())
      {
        Block block = (Block) iterator.next();
        if (block != null)
        {
          Size2D size2D = block.arrange(g2, RectangleConstraint.__\u003C\u003ENONE);
          num1 = Math.max(num1, size2D.width);
          num2 = Math.max(num2, size2D.height);
        }
      }
      RectangleConstraint constraint = new RectangleConstraint((double) this.columns * num1, (double) this.rows * num2);
      return this.arrangeFF(container, g2, constraint);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 27, (byte) 112, (byte) 104, (byte) 103, (byte) 102, (byte) 112, (byte) 112, (byte) 110, (byte) 106, (byte) 130, (byte) 111, (byte) 100, (byte) 107, (byte) 239, (byte) 56, (byte) 43, (byte) 235, (byte) 77, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeNF(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      double height = constraint.getHeight() / (double) this.rows;
      RectangleConstraint rc = constraint.toFixedHeight(height);
      List blocks = container.getBlocks();
      double num1 = 0.0;
      for (int index1 = 0; index1 < this.rows; ++index1)
      {
        for (int index2 = 0; index2 < this.columns; ++index2)
        {
          int num2 = index1 * this.columns + index2;
          if (num2 < blocks.size())
          {
            Block block = (Block) blocks.get(num2);
            if (block != null)
            {
              Size2D size2D = block.arrange(g2, rc);
              num1 = Math.max(num1, size2D.getWidth());
            }
          }
          else
            break;
        }
      }
      RectangleConstraint constraint1 = constraint.toFixedWidth(num1 * (double) this.columns);
      return this.arrange(container, g2, constraint1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 177, (byte) 103, (byte) 138, (byte) 115, (byte) 162, (byte) 115, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeNR(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      RectangleConstraint constraint1 = constraint.toUnconstrainedHeight();
      Size2D size2D = this.arrange(container, g2, constraint1);
      if (constraint.getHeightRange().contains(size2D.getHeight()))
        return size2D;
      double height = constraint.getHeightRange().constrain(size2D.getHeight());
      RectangleConstraint constraint2 = constraint.toFixedHeight(height);
      return this.arrange(container, g2, constraint2);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 250, (byte) 112, (byte) 104, (byte) 103, (byte) 102, (byte) 112, (byte) 112, (byte) 110, (byte) 106, (byte) 130, (byte) 111, (byte) 100, (byte) 107, (byte) 239, (byte) 56, (byte) 43, (byte) 235, (byte) 77, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeFN(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      double width = constraint.getWidth() / (double) this.columns;
      RectangleConstraint rc = constraint.toFixedWidth(width);
      List blocks = container.getBlocks();
      double num1 = 0.0;
      for (int index1 = 0; index1 < this.rows; ++index1)
      {
        for (int index2 = 0; index2 < this.columns; ++index2)
        {
          int num2 = index1 * this.columns + index2;
          if (num2 < blocks.size())
          {
            Block block = (Block) blocks.get(num2);
            if (block != null)
            {
              Size2D size2D = block.arrange(g2, rc);
              num1 = Math.max(num1, size2D.getHeight());
            }
          }
          else
            break;
        }
      }
      RectangleConstraint constraint1 = constraint.toFixedHeight(num1 * (double) this.rows);
      return this.arrange(container, g2, constraint1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 71, (byte) 112, (byte) 112, (byte) 103, (byte) 110, (byte) 112, (byte) 109, (byte) 106, (byte) 130, (byte) 111, (byte) 100, (byte) 247, (byte) 57, (byte) 43, (byte) 233, (byte) 77})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeFF(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      double num1 = constraint.getWidth() / (double) this.columns;
      double num2 = constraint.getHeight() / (double) this.rows;
      List blocks = container.getBlocks();
      for (int index1 = 0; index1 < this.columns; ++index1)
      {
        for (int index2 = 0; index2 < this.rows; ++index2)
        {
          int num3 = index2 * this.columns + index1;
          if (num3 < blocks.size())
          {
            Block block = (Block) blocks.get(num3);
            if (block != null)
              block.setBounds((Rectangle2D) new Rectangle2D.Double((double) index1 * num1, (double) index2 * num2, num1, num2));
          }
          else
            break;
        }
      }
      return new Size2D((double) this.columns * num1, (double) this.rows * num2);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 102, (byte) 103, (byte) 138, (byte) 115, (byte) 162, (byte) 115, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeFR(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      RectangleConstraint constraint1 = constraint.toUnconstrainedHeight();
      Size2D size2D = this.arrange(container, g2, constraint1);
      if (constraint.getHeightRange().contains(size2D.getHeight()))
        return size2D;
      double height = constraint.getHeightRange().constrain(size2D.getHeight());
      RectangleConstraint constraint2 = constraint.toFixedHeight(height);
      return this.arrange(container, g2, constraint2);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 152, (byte) 103, (byte) 138, (byte) 115, (byte) 162, (byte) 115, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeRN(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      RectangleConstraint constraint1 = constraint.toUnconstrainedWidth();
      Size2D size2D = this.arrange(container, g2, constraint1);
      if (constraint.getWidthRange().contains(size2D.getWidth()))
        return size2D;
      double width = constraint.getWidthRange().constrain(size2D.getWidth());
      RectangleConstraint constraint2 = constraint.toFixedWidth(width);
      return this.arrange(container, g2, constraint2);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 127, (byte) 103, (byte) 138, (byte) 115, (byte) 162, (byte) 115, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeRF(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      RectangleConstraint constraint1 = constraint.toUnconstrainedWidth();
      Size2D size2D = this.arrange(container, g2, constraint1);
      if (constraint.getWidthRange().contains(size2D.getWidth()))
        return size2D;
      double width = constraint.getWidthRange().constrain(size2D.getWidth());
      RectangleConstraint constraint2 = constraint.toFixedWidth(width);
      return this.arrange(container, g2, constraint2);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 202, (byte) 142, (byte) 115, (byte) 115, (byte) 194, (byte) 147, (byte) 146, (byte) 204, (byte) 147, (byte) 147, (byte) 146, (byte) 204, (byte) 147, (byte) 147, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeRR(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      Size2D size2D = this.arrange(container, g2, RectangleConstraint.__\u003C\u003ENONE);
      if (constraint.getWidthRange().contains(size2D.getWidth()))
      {
        if (constraint.getHeightRange().contains(size2D.getHeight()))
          return size2D;
        double h = constraint.getHeightRange().constrain(size2D.getHeight());
        RectangleConstraint.__\u003Cclinit\u003E();
        RectangleConstraint constraint1 = new RectangleConstraint(size2D.getWidth(), h);
        return this.arrangeFF(container, g2, constraint1);
      }
      else if (constraint.getHeightRange().contains(size2D.getHeight()))
      {
        double w = constraint.getWidthRange().constrain(size2D.getWidth());
        RectangleConstraint.__\u003Cclinit\u003E();
        RectangleConstraint constraint1 = new RectangleConstraint(w, size2D.getHeight());
        return this.arrangeFF(container, g2, constraint1);
      }
      else
      {
        RectangleConstraint constraint1 = new RectangleConstraint(constraint.getWidthRange().constrain(size2D.getWidth()), constraint.getHeightRange().constrain(size2D.getHeight()));
        return this.arrangeFF(container, g2, constraint1);
      }
    }

    [LineNumberTable(new byte[] {(byte) 53, (byte) 103, (byte) 103, (byte) 104, (byte) 104, (byte) 139, (byte) 104, (byte) 140, (byte) 139, (byte) 172, (byte) 104, (byte) 136, (byte) 140, (byte) 104, (byte) 140, (byte) 136, (byte) 172, (byte) 136, (byte) 136, (byte) 140, (byte) 136, (byte) 140, (byte) 104, (byte) 172})]
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
          return this.arrangeNR(container, g2, constraint);
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
      string str = "Should never get to here!";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new RuntimeException(str);
    }

    public virtual void add(Block block, object key)
    {
    }

    public virtual void clear()
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 63, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 110, (byte) 130, (byte) 110, (byte) 130})]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is GridArrangement))
        return false;
      GridArrangement gridArrangement = (GridArrangement) obj;
      return this.columns == gridArrangement.columns && this.rows == gridArrangement.rows;
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
