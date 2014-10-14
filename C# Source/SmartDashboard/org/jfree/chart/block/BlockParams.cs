// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.block.BlockParams
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.block
{
  [Implements(new string[] {"org.jfree.chart.block.EntityBlockParams"})]
  public class BlockParams : Object, EntityBlockParams
  {
    private bool generateEntities;
    private double translateX;
    private double translateY;

    [LineNumberTable(new byte[] {(byte) 22, (byte) 104, (byte) 108, (byte) 108, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BlockParams()
    {
      base.\u002Ector();
      BlockParams blockParams = this;
      this.translateX = 0.0;
      this.translateY = 0.0;
      this.generateEntities = false;
    }

    public virtual void setGenerateEntities(bool generate)
    {
      this.generateEntities = generate;
    }

    public virtual bool getGenerateEntities()
    {
      return this.generateEntities;
    }

    public virtual double getTranslateX()
    {
      return this.translateX;
    }

    public virtual void setTranslateX(double x)
    {
      this.translateX = x;
    }

    public virtual double getTranslateY()
    {
      return this.translateY;
    }

    public virtual void setTranslateY(double y)
    {
      this.translateY = y;
    }
  }
}
