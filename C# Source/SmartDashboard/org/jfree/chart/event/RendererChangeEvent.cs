// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.event.RendererChangeEvent
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.jfree.chart.@event;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.@event
{
  [Serializable]
  public class RendererChangeEvent : ChartChangeEvent
  {
    private object renderer;
    private bool seriesVisibilityChanged;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 122, (byte) 130, (byte) 105, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RendererChangeEvent(object renderer, bool seriesVisibilityChanged)
    {
      int num = seriesVisibilityChanged ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector(renderer);
      RendererChangeEvent rendererChangeEvent = this;
      this.renderer = renderer;
      this.seriesVisibilityChanged = num != 0;
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RendererChangeEvent(object renderer)
      : this(renderer, false)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected RendererChangeEvent([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    public virtual object getRenderer()
    {
      return this.renderer;
    }

    public virtual bool getSeriesVisibilityChanged()
    {
      return this.seriesVisibilityChanged;
    }
  }
}
