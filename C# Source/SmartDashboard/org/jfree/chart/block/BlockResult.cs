// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.BlockResult
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.chart.entity;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.block
{
  [Implements(new string[] {"org.jfree.chart.block.EntityBlockResult"})]
  public class BlockResult : Object, EntityBlockResult
  {
    private EntityCollection entities;

    [LineNumberTable(new byte[] {(byte) 7, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BlockResult()
    {
      base.\u002Ector();
      BlockResult blockResult = this;
      this.entities = (EntityCollection) null;
    }

    public virtual void setEntityCollection(EntityCollection entities)
    {
      this.entities = entities;
    }

    public virtual EntityCollection getEntityCollection()
    {
      return this.entities;
    }
  }
}
