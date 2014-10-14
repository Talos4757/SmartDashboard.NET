// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.BlockContainer
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart.entity;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.block
{
  [Implements(new string[] {"org.jfree.chart.block.Block", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class BlockContainer : AbstractBlock, Block, Drawable, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 8199508075695195293L;
    private List blocks;
    private Arrangement arrangement;

    [LineNumberTable(new byte[] {(byte) 42, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BlockContainer(Arrangement arrangement)
    {
      BlockContainer blockContainer = this;
      if (arrangement == null)
      {
        string str = "Null 'arrangement' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.arrangement = arrangement;
        this.blocks = (List) new ArrayList();
      }
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BlockContainer()
      : this((Arrangement) new BorderArrangement())
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected BlockContainer([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] BlockContainer obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] BlockContainer obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 138)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getBlocks()
    {
      return Collections.unmodifiableList(this.blocks);
    }

    [LineNumberTable(new byte[] {(byte) 107, (byte) 109, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(Block block, object key)
    {
      this.blocks.add((object) block);
      this.arrangement.add(block, key);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 90, (byte) 98, (byte) 98, (byte) 104, (byte) 103, (byte) 104, (byte) 166, (byte) 108, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 108, (byte) 107, (byte) 109, (byte) 105, (byte) 191, (byte) 18, (byte) 109, (byte) 99, (byte) 105, (byte) 105, (byte) 105, (byte) 168, (byte) 101, (byte) 99, (byte) 99, (byte) 103, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object draw(Graphics2D g2, Rectangle2D area, object @params)
    {
      StandardEntityCollection entityCollection1 = (StandardEntityCollection) null;
      if (@params is EntityBlockParams && ((EntityBlockParams) @params).getGenerateEntities())
        entityCollection1 = new StandardEntityCollection();
      Rectangle2D area1 = this.trimMargin((Rectangle2D) ((RectangularShape) area).clone());
      this.drawBorder(g2, area1);
      this.trimPadding(this.trimBorder(area1));
      Iterator iterator = this.blocks.iterator();
      while (iterator.hasNext())
      {
        Block block = (Block) iterator.next();
        Rectangle2D bounds = block.getBounds();
        Rectangle2D.Double @double = new Rectangle2D.Double(((RectangularShape) bounds).getX() + ((RectangularShape) area).getX(), ((RectangularShape) bounds).getY() + ((RectangularShape) area).getY(), ((RectangularShape) bounds).getWidth(), ((RectangularShape) bounds).getHeight());
        object obj = block.draw(g2, (Rectangle2D) @double, @params);
        if (entityCollection1 != null && obj is EntityBlockResult)
        {
          EntityCollection entityCollection2 = ((EntityBlockResult) obj).getEntityCollection();
          entityCollection1.addAll(entityCollection2);
        }
      }
      BlockResult blockResult = (BlockResult) null;
      if (entityCollection1 != null)
      {
        blockResult = new BlockResult();
        blockResult.setEntityCollection((EntityCollection) entityCollection1);
      }
      return (object) blockResult;
    }

    public virtual Arrangement getArrangement()
    {
      return this.arrangement;
    }

    [LineNumberTable(new byte[] {(byte) 65, (byte) 99, (byte) 144, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setArrangement(Arrangement arrangement)
    {
      if (arrangement == null)
      {
        string str = "Null 'arrangement' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
        this.arrangement = arrangement;
    }

    [LineNumberTable((ushort) 128)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isEmpty()
    {
      return (this.blocks.isEmpty() ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 97, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void add(Block block)
    {
      this.add(block, (object) null);
    }

    [LineNumberTable(new byte[] {(byte) 115, (byte) 107, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void clear()
    {
      this.blocks.clear();
      this.arrangement.clear();
    }

    [LineNumberTable((ushort) 179)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Size2D arrange(Graphics2D g2, RectangleConstraint constraint)
    {
      return this.arrangement.arrange(this, g2, constraint);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 75, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void draw(Graphics2D g2, Rectangle2D area)
    {
      this.draw(g2, area, (object) null);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 135, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 105, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is BlockContainer) || !base.equals(obj))
        return false;
      BlockContainer blockContainer = (BlockContainer) obj;
      return Object.instancehelper_equals((object) this.arrangement, (object) blockContainer.arrangement) && Object.instancehelper_equals((object) this.blocks, (object) blockContainer.blocks);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 162, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return (object) (BlockContainer) base.clone();
    }
  }
}
