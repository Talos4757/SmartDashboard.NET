// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.renderer.RendererState
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.chart;
using org.jfree.chart.entity;
using org.jfree.chart.plot;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.renderer
{
  public class RendererState : Object
  {
    private PlotRenderingInfo info;

    [LineNumberTable(new byte[] {(byte) 12, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RendererState(PlotRenderingInfo info)
    {
      base.\u002Ector();
      RendererState rendererState = this;
      this.info = info;
    }

    public virtual PlotRenderingInfo getInfo()
    {
      return this.info;
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 98, (byte) 104, (byte) 108, (byte) 99, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual EntityCollection getEntityCollection()
    {
      EntityCollection entityCollection = (EntityCollection) null;
      if (this.info != null)
      {
        ChartRenderingInfo owner = this.info.getOwner();
        if (owner != null)
          entityCollection = owner.getEntityCollection();
      }
      return entityCollection;
    }
  }
}
