// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.CenterArrangement
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
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
  public class CenterArrangement : Object, Arrangement, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = -353308149220382047L;

    [LineNumberTable(new byte[] {(byte) 13, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CenterArrangement()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected CenterArrangement([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] CenterArrangement obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 168, (byte) 103, (byte) 109, (byte) 109, (byte) 127, (byte) 2})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeNN(BlockContainer container, Graphics2D g2)
    {
      Block block = (Block) container.getBlocks().get(0);
      Size2D size2D = block.arrange(g2, RectangleConstraint.__\u003C\u003ENONE);
      block.setBounds((Rectangle2D) new Rectangle2D.Double(0.0, 0.0, size2D.width, size2D.height));
      return new Size2D(size2D.width, size2D.height);
    }

    [LineNumberTable(new byte[] {(byte) 96, (byte) 103, (byte) 109, (byte) 109, (byte) 104, (byte) 159, (byte) 11, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeFN(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      Block block = (Block) container.getBlocks().get(0);
      Size2D size2D = block.arrange(g2, RectangleConstraint.__\u003C\u003ENONE);
      double width = constraint.getWidth();
      Rectangle2D.Double @double = new Rectangle2D.Double((width - size2D.width) / 2.0, 0.0, size2D.width, size2D.height);
      block.setBounds((Rectangle2D) @double);
      return new Size2D((width - size2D.width) / 2.0, size2D.height);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 147, (byte) 105, (byte) 115, (byte) 162, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeRN(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      Size2D size2D = this.arrangeNN(container, g2);
      if (constraint.getWidthRange().contains(size2D.width))
        return size2D;
      RectangleConstraint constraint1 = constraint.toFixedWidth(constraint.getWidthRange().getUpperBound());
      return this.arrangeFN(container, g2, constraint1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 122, (byte) 106, (byte) 115, (byte) 162, (byte) 152})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeRF(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      Size2D size2D = this.arrangeNF(container, g2, constraint);
      if (constraint.getWidthRange().contains(size2D.width))
        return size2D;
      RectangleConstraint constraint1 = constraint.toFixedWidth(constraint.getWidthRange().constrain(size2D.getWidth()));
      return this.arrangeFF(container, g2, constraint1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 98, (byte) 105, (byte) 115, (byte) 162, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeRR(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      Size2D size2D = this.arrangeNN(container, g2);
      if (constraint.getWidthRange().contains(size2D.width))
        return size2D;
      RectangleConstraint constraint1 = constraint.toFixedWidth(constraint.getWidthRange().getUpperBound());
      return this.arrangeFR(container, g2, constraint1);
    }

    [LineNumberTable((ushort) 194)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeFF(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      return this.arrangeFN(container, g2, constraint);
    }

    [LineNumberTable(new byte[] {(byte) 119, (byte) 106, (byte) 115, (byte) 162, (byte) 152})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeFR(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      Size2D size2D = this.arrangeFN(container, g2, constraint);
      if (constraint.getHeightRange().contains(size2D.height))
        return size2D;
      RectangleConstraint constraint1 = constraint.toFixedHeight(constraint.getHeightRange().constrain(size2D.getHeight()));
      return this.arrangeFF(container, g2, constraint1);
    }

    [LineNumberTable((ushort) 302)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeNF(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      return this.arrangeNN(container, g2);
    }

    public virtual void add(Block block, object key)
    {
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 103, (byte) 103, (byte) 104, (byte) 104, (byte) 139, (byte) 104, (byte) 144, (byte) 107, (byte) 176, (byte) 104, (byte) 104, (byte) 140, (byte) 104, (byte) 144, (byte) 104, (byte) 176, (byte) 104, (byte) 104, (byte) 140, (byte) 104, (byte) 140, (byte) 104, (byte) 172})]
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
          return this.arrangeFN(container, g2, constraint);
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
      else if (widthConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
      {
        if (heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
          return this.arrangeRN(container, g2, constraint);
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
          return this.arrangeRF(container, g2, constraint);
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
          return this.arrangeRR(container, g2, constraint);
      }
      string str1 = "Unknown LengthConstraintType.";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str1);
    }

    public virtual void clear()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 206, (byte) 100, (byte) 130, (byte) 104, (byte) 130})]
    public virtual bool equals(object obj)
    {
      return obj == this || obj is CenterArrangement;
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
