// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.BorderArrangement
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using org.jfree.data;
using org.jfree.ui;
using org.jfree.util;
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
  public class BorderArrangement : Object, Arrangement, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 506071142274883745L;
    private Block centerBlock;
    private Block topBlock;
    private Block bottomBlock;
    private Block leftBlock;
    private Block rightBlock;

    [LineNumberTable(new byte[] {(byte) 35, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BorderArrangement()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected BorderArrangement([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] BorderArrangement obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 68, (byte) 103, (byte) 103, (byte) 104, (byte) 114, (byte) 105, (byte) 137, (byte) 104, (byte) 146, (byte) 105, (byte) 137, (byte) 104, (byte) 114, (byte) 105, (byte) 137, (byte) 104, (byte) 114, (byte) 105, (byte) 169, (byte) 111, (byte) 134, (byte) 104, (byte) 146, (byte) 105, (byte) 137, (byte) 125, (byte) 118, (byte) 109, (byte) 104, (byte) 190, (byte) 104, (byte) 191, (byte) 0, (byte) 104, (byte) 189, (byte) 104, (byte) 221, (byte) 104, (byte) 191, (byte) 2})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeNN(BlockContainer container, Graphics2D g2)
    {
      double[] numArray1 = new double[5];
      double[] numArray2 = new double[5];
      if (this.topBlock != null)
      {
        Size2D size2D = this.topBlock.arrange(g2, RectangleConstraint.__\u003C\u003ENONE);
        numArray1[0] = size2D.width;
        numArray2[0] = size2D.height;
      }
      if (this.bottomBlock != null)
      {
        Size2D size2D = this.bottomBlock.arrange(g2, RectangleConstraint.__\u003C\u003ENONE);
        numArray1[1] = size2D.width;
        numArray2[1] = size2D.height;
      }
      if (this.leftBlock != null)
      {
        Size2D size2D = this.leftBlock.arrange(g2, RectangleConstraint.__\u003C\u003ENONE);
        numArray1[2] = size2D.width;
        numArray2[2] = size2D.height;
      }
      if (this.rightBlock != null)
      {
        Size2D size2D = this.rightBlock.arrange(g2, RectangleConstraint.__\u003C\u003ENONE);
        numArray1[3] = size2D.width;
        numArray2[3] = size2D.height;
      }
      numArray2[2] = Math.max(numArray2[2], numArray2[3]);
      numArray2[3] = numArray2[2];
      if (this.centerBlock != null)
      {
        Size2D size2D = this.centerBlock.arrange(g2, RectangleConstraint.__\u003C\u003ENONE);
        numArray1[4] = size2D.width;
        numArray2[4] = size2D.height;
      }
      double width = Math.max(numArray1[0], Math.max(numArray1[1], numArray1[2] + numArray1[4] + numArray1[3]));
      double num = Math.max(numArray2[2], Math.max(numArray2[3], numArray2[4]));
      double height = numArray2[0] + numArray2[1] + num;
      if (this.topBlock != null)
        this.topBlock.setBounds((Rectangle2D) new Rectangle2D.Double(0.0, 0.0, width, numArray2[0]));
      if (this.bottomBlock != null)
        this.bottomBlock.setBounds((Rectangle2D) new Rectangle2D.Double(0.0, height - numArray2[1], width, numArray2[1]));
      if (this.leftBlock != null)
        this.leftBlock.setBounds((Rectangle2D) new Rectangle2D.Double(0.0, numArray2[0], numArray1[2], num));
      if (this.rightBlock != null)
        this.rightBlock.setBounds((Rectangle2D) new Rectangle2D.Double(width - numArray1[3], numArray2[0], numArray1[3], num));
      if (this.centerBlock != null)
        this.centerBlock.setBounds((Rectangle2D) new Rectangle2D.Double(numArray1[2], numArray2[0], width - numArray1[2] - numArray1[3], num));
      return new Size2D(width, height);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 162, (byte) 103, (byte) 103, (byte) 190, (byte) 104, (byte) 110, (byte) 105, (byte) 137, (byte) 104, (byte) 110, (byte) 105, (byte) 137, (byte) 191, (byte) 14, (byte) 104, (byte) 112, (byte) 106, (byte) 138, (byte) 107, (byte) 115, (byte) 223, (byte) 19, (byte) 112, (byte) 106, (byte) 170, (byte) 111, (byte) 134, (byte) 104, (byte) 191, (byte) 8, (byte) 112, (byte) 106, (byte) 138, (byte) 126})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeFN(BlockContainer container, Graphics2D g2, double width)
    {
      double[] numArray1 = new double[5];
      double[] numArray2 = new double[5];
      RectangleConstraint.__\u003Cclinit\u003E();
      RectangleConstraint rc1 = new RectangleConstraint(width, (Range) null, LengthConstraintType.__\u003C\u003EFIXED, 0.0, (Range) null, LengthConstraintType.__\u003C\u003ENONE);
      if (this.topBlock != null)
      {
        Size2D size2D = this.topBlock.arrange(g2, rc1);
        numArray1[0] = size2D.width;
        numArray2[0] = size2D.height;
      }
      if (this.bottomBlock != null)
      {
        Size2D size2D = this.bottomBlock.arrange(g2, rc1);
        numArray1[1] = size2D.width;
        numArray2[1] = size2D.height;
      }
      RectangleConstraint.__\u003Cclinit\u003E();
      RectangleConstraint rc2 = new RectangleConstraint(0.0, new Range(0.0, width), LengthConstraintType.__\u003C\u003ERANGE, 0.0, (Range) null, LengthConstraintType.__\u003C\u003ENONE);
      if (this.leftBlock != null)
      {
        Size2D size2D = this.leftBlock.arrange(g2, rc2);
        numArray1[2] = size2D.width;
        numArray2[2] = size2D.height;
      }
      if (this.rightBlock != null)
      {
        double upper = Math.max(width - numArray1[2], 0.0);
        RectangleConstraint.__\u003Cclinit\u003E();
        RectangleConstraint rc3 = new RectangleConstraint(0.0, new Range(Math.min(numArray1[2], upper), upper), LengthConstraintType.__\u003C\u003ERANGE, 0.0, (Range) null, LengthConstraintType.__\u003C\u003ENONE);
        Size2D size2D = this.rightBlock.arrange(g2, rc3);
        numArray1[3] = size2D.width;
        numArray2[3] = size2D.height;
      }
      numArray2[2] = Math.max(numArray2[2], numArray2[3]);
      numArray2[3] = numArray2[2];
      if (this.centerBlock != null)
      {
        RectangleConstraint.__\u003Cclinit\u003E();
        RectangleConstraint rc3 = new RectangleConstraint(width - numArray1[2] - numArray1[3], (Range) null, LengthConstraintType.__\u003C\u003EFIXED, 0.0, (Range) null, LengthConstraintType.__\u003C\u003ENONE);
        Size2D size2D = this.centerBlock.arrange(g2, rc3);
        numArray1[4] = size2D.width;
        numArray2[4] = size2D.height;
      }
      double h = numArray2[0] + numArray2[1] + Math.max(numArray2[2], Math.max(numArray2[3], numArray2[4]));
      return this.arrange(container, g2, new RectangleConstraint(width, h));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 50, (byte) 103, (byte) 103, (byte) 106, (byte) 104, (byte) 223, (byte) 15, (byte) 110, (byte) 137, (byte) 102, (byte) 104, (byte) 191, (byte) 19, (byte) 110, (byte) 137, (byte) 114, (byte) 104, (byte) 223, (byte) 15, (byte) 110, (byte) 137, (byte) 102, (byte) 104, (byte) 223, (byte) 29, (byte) 110, (byte) 137, (byte) 102, (byte) 114, (byte) 113, (byte) 104, (byte) 174, (byte) 104, (byte) 191, (byte) 1, (byte) 104, (byte) 191, (byte) 3, (byte) 104, (byte) 190, (byte) 104, (byte) 191, (byte) 1, (byte) 104, (byte) 188})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeFF(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      double[] numArray1 = new double[5];
      double[] numArray2 = new double[5];
      numArray1[0] = constraint.getWidth();
      if (this.topBlock != null)
      {
        RectangleConstraint.__\u003Cclinit\u003E();
        RectangleConstraint rc = new RectangleConstraint(numArray1[0], (Range) null, LengthConstraintType.__\u003C\u003EFIXED, 0.0, new Range(0.0, constraint.getHeight()), LengthConstraintType.__\u003C\u003ERANGE);
        Size2D size2D = this.topBlock.arrange(g2, rc);
        numArray2[0] = size2D.height;
      }
      numArray1[1] = numArray1[0];
      if (this.bottomBlock != null)
      {
        RectangleConstraint.__\u003Cclinit\u003E();
        RectangleConstraint rc = new RectangleConstraint(numArray1[0], (Range) null, LengthConstraintType.__\u003C\u003EFIXED, 0.0, new Range(0.0, constraint.getHeight() - numArray2[0]), LengthConstraintType.__\u003C\u003ERANGE);
        Size2D size2D = this.bottomBlock.arrange(g2, rc);
        numArray2[1] = size2D.height;
      }
      numArray2[2] = constraint.getHeight() - numArray2[1] - numArray2[0];
      if (this.leftBlock != null)
      {
        RectangleConstraint.__\u003Cclinit\u003E();
        RectangleConstraint rc = new RectangleConstraint(0.0, new Range(0.0, constraint.getWidth()), LengthConstraintType.__\u003C\u003ERANGE, numArray2[2], (Range) null, LengthConstraintType.__\u003C\u003EFIXED);
        Size2D size2D = this.leftBlock.arrange(g2, rc);
        numArray1[2] = size2D.width;
      }
      numArray2[3] = numArray2[2];
      if (this.rightBlock != null)
      {
        RectangleConstraint.__\u003Cclinit\u003E();
        RectangleConstraint rc = new RectangleConstraint(0.0, new Range(0.0, Math.max(constraint.getWidth() - numArray1[2], 0.0)), LengthConstraintType.__\u003C\u003ERANGE, numArray2[2], (Range) null, LengthConstraintType.__\u003C\u003EFIXED);
        Size2D size2D = this.rightBlock.arrange(g2, rc);
        numArray1[3] = size2D.width;
      }
      numArray2[4] = numArray2[2];
      numArray1[4] = constraint.getWidth() - numArray1[3] - numArray1[2];
      RectangleConstraint.__\u003Cclinit\u003E();
      RectangleConstraint rc1 = new RectangleConstraint(numArray1[4], numArray2[4]);
      if (this.centerBlock != null)
        this.centerBlock.arrange(g2, rc1);
      if (this.topBlock != null)
        this.topBlock.setBounds((Rectangle2D) new Rectangle2D.Double(0.0, 0.0, numArray1[0], numArray2[0]));
      if (this.bottomBlock != null)
        this.bottomBlock.setBounds((Rectangle2D) new Rectangle2D.Double(0.0, numArray2[0] + numArray2[2], numArray1[1], numArray2[1]));
      if (this.leftBlock != null)
        this.leftBlock.setBounds((Rectangle2D) new Rectangle2D.Double(0.0, numArray2[0], numArray1[2], numArray2[2]));
      if (this.rightBlock != null)
        this.rightBlock.setBounds((Rectangle2D) new Rectangle2D.Double(numArray1[2] + numArray1[4], numArray2[0], numArray1[3], numArray2[3]));
      if (this.centerBlock != null)
        this.centerBlock.setBounds((Rectangle2D) new Rectangle2D.Double(numArray1[2], numArray2[0], numArray1[4], numArray2[4]));
      return new Size2D(constraint.getWidth(), constraint.getHeight());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 139, (byte) 111, (byte) 115, (byte) 162, (byte) 115, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeFR(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      Size2D size2D = this.arrangeFN(container, g2, constraint.getWidth());
      if (constraint.getHeightRange().contains(size2D.getHeight()))
        return size2D;
      double height = constraint.getHeightRange().constrain(size2D.getHeight());
      RectangleConstraint constraint1 = constraint.toFixedHeight(height);
      return this.arrange(container, g2, constraint1);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 225, (byte) 103, (byte) 103, (byte) 104, (byte) 136, (byte) 111, (byte) 105, (byte) 137, (byte) 104, (byte) 109, (byte) 138, (byte) 113, (byte) 106, (byte) 138, (byte) 112, (byte) 104, (byte) 138, (byte) 113, (byte) 106, (byte) 138, (byte) 109, (byte) 104, (byte) 139, (byte) 113, (byte) 106, (byte) 170, (byte) 111, (byte) 102, (byte) 113, (byte) 104, (byte) 139, (byte) 113, (byte) 106, (byte) 138, (byte) 126, (byte) 126, (byte) 104, (byte) 191, (byte) 0, (byte) 104, (byte) 191, (byte) 1, (byte) 104, (byte) 190, (byte) 104, (byte) 223, (byte) 0, (byte) 104, (byte) 191, (byte) 11})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Size2D arrangeRR(BlockContainer container, Range widthRange, Range heightRange, Graphics2D g2)
    {
      double[] numArray1 = new double[5];
      double[] numArray2 = new double[5];
      if (this.topBlock != null)
      {
        RectangleConstraint rc = new RectangleConstraint(widthRange, heightRange);
        Size2D size2D = this.topBlock.arrange(g2, rc);
        numArray1[0] = size2D.width;
        numArray2[0] = size2D.height;
      }
      if (this.bottomBlock != null)
      {
        Range h = Range.shift(heightRange, -numArray2[0], false);
        RectangleConstraint rc = new RectangleConstraint(widthRange, h);
        Size2D size2D = this.bottomBlock.arrange(g2, rc);
        numArray1[1] = size2D.width;
        numArray2[1] = size2D.height;
      }
      Range h1 = Range.shift(heightRange, -(numArray2[0] + numArray2[1]));
      if (this.leftBlock != null)
      {
        RectangleConstraint rc = new RectangleConstraint(widthRange, h1);
        Size2D size2D = this.leftBlock.arrange(g2, rc);
        numArray1[2] = size2D.width;
        numArray2[2] = size2D.height;
      }
      Range w1 = Range.shift(widthRange, -numArray1[2], false);
      if (this.rightBlock != null)
      {
        RectangleConstraint rc = new RectangleConstraint(w1, h1);
        Size2D size2D = this.rightBlock.arrange(g2, rc);
        numArray1[3] = size2D.width;
        numArray2[3] = size2D.height;
      }
      numArray2[2] = Math.max(numArray2[2], numArray2[3]);
      numArray2[3] = numArray2[2];
      Range w2 = Range.shift(widthRange, -(numArray1[2] + numArray1[3]), false);
      if (this.centerBlock != null)
      {
        RectangleConstraint rc = new RectangleConstraint(w2, h1);
        Size2D size2D = this.centerBlock.arrange(g2, rc);
        numArray1[4] = size2D.width;
        numArray2[4] = size2D.height;
      }
      double width = Math.max(numArray1[0], Math.max(numArray1[1], numArray1[2] + numArray1[4] + numArray1[3]));
      double height = numArray2[0] + numArray2[1] + Math.max(numArray2[2], Math.max(numArray2[3], numArray2[4]));
      if (this.topBlock != null)
        this.topBlock.setBounds((Rectangle2D) new Rectangle2D.Double(0.0, 0.0, width, numArray2[0]));
      if (this.bottomBlock != null)
        this.bottomBlock.setBounds((Rectangle2D) new Rectangle2D.Double(0.0, height - numArray2[1], width, numArray2[1]));
      if (this.leftBlock != null)
        this.leftBlock.setBounds((Rectangle2D) new Rectangle2D.Double(0.0, numArray2[0], numArray1[2], numArray2[2]));
      if (this.rightBlock != null)
        this.rightBlock.setBounds((Rectangle2D) new Rectangle2D.Double(width - numArray1[3], numArray2[0], numArray1[3], numArray2[3]));
      if (this.centerBlock != null)
        this.centerBlock.setBounds((Rectangle2D) new Rectangle2D.Double(numArray1[2], numArray2[0], width - numArray1[2] - numArray1[3], height - numArray2[0] - numArray2[1]));
      return new Size2D(width, height);
    }

    [LineNumberTable(new byte[] {(byte) 80, (byte) 136, (byte) 98, (byte) 103, (byte) 103, (byte) 104, (byte) 104, (byte) 142, (byte) 104, (byte) 144, (byte) 107, (byte) 176, (byte) 104, (byte) 104, (byte) 148, (byte) 104, (byte) 143, (byte) 107, (byte) 172, (byte) 104, (byte) 104, (byte) 144, (byte) 104, (byte) 144, (byte) 104, (byte) 213})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Size2D arrange(BlockContainer container, Graphics2D g2, RectangleConstraint constraint)
    {
      RectangleConstraint rectangleConstraint = container.toContentConstraint(constraint);
      Size2D size2D = (Size2D) null;
      LengthConstraintType widthConstraintType = rectangleConstraint.getWidthConstraintType();
      LengthConstraintType heightConstraintType = rectangleConstraint.getHeightConstraintType();
      if (widthConstraintType == LengthConstraintType.__\u003C\u003ENONE)
      {
        if (heightConstraintType == LengthConstraintType.__\u003C\u003ENONE)
          size2D = this.arrangeNN(container, g2);
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
          size2D = this.arrangeFN(container, g2, constraint.getWidth());
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003EFIXED)
          size2D = this.arrangeFF(container, g2, constraint);
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
          size2D = this.arrangeFR(container, g2, constraint);
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
        {
          string str = "Not implemented.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new RuntimeException(str);
        }
        else if (heightConstraintType == LengthConstraintType.__\u003C\u003ERANGE)
          size2D = this.arrangeRR(container, constraint.getWidthRange(), constraint.getHeightRange(), g2);
      }
      return new Size2D(container.calculateTotalWidth(size2D.getWidth()), container.calculateTotalHeight(size2D.getHeight()));
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 99, (byte) 169, (byte) 103, (byte) 104, (byte) 137, (byte) 104, (byte) 137, (byte) 104, (byte) 137, (byte) 104, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(Block block, object key)
    {
      if (key == null)
      {
        this.centerBlock = block;
      }
      else
      {
        RectangleEdge rectangleEdge = (RectangleEdge) key;
        if (rectangleEdge == RectangleEdge.__\u003C\u003ETOP)
          this.topBlock = block;
        else if (rectangleEdge == RectangleEdge.__\u003C\u003EBOTTOM)
          this.bottomBlock = block;
        else if (rectangleEdge == RectangleEdge.__\u003C\u003ELEFT)
        {
          this.leftBlock = block;
        }
        else
        {
          if (rectangleEdge != RectangleEdge.__\u003C\u003ERIGHT)
            return;
          this.rightBlock = block;
        }
      }
    }

    public virtual void clear()
    {
      this.centerBlock = (Block) null;
      this.topBlock = (Block) null;
      this.bottomBlock = (Block) null;
      this.leftBlock = (Block) null;
      this.rightBlock = (Block) null;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 136, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is BorderArrangement))
        return false;
      BorderArrangement borderArrangement = (BorderArrangement) obj;
      return ObjectUtilities.equal((object) this.topBlock, (object) borderArrangement.topBlock) && ObjectUtilities.equal((object) this.bottomBlock, (object) borderArrangement.bottomBlock) && (ObjectUtilities.equal((object) this.leftBlock, (object) borderArrangement.leftBlock) && ObjectUtilities.equal((object) this.rightBlock, (object) borderArrangement.rightBlock)) && ObjectUtilities.equal((object) this.centerBlock, (object) borderArrangement.centerBlock);
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
