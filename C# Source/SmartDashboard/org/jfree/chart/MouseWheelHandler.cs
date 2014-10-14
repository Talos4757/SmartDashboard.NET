// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.MouseWheelHandler
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.awt.geom;
using java.io;
using java.lang;
using java.util;
using org.jfree.chart.plot;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart
{
  [Implements(new string[] {"java.awt.event.MouseWheelListener", "java.io.Serializable"})]
  [Modifiers]
  [Serializable]
  internal sealed class MouseWheelHandler : Object, MouseWheelListener, EventListener, Serializable.__Interface, ISerializable
  {
    private ChartPanel chartPanel;
    internal double zoomFactor;

    [LineNumberTable(new byte[] {(byte) 23, (byte) 104, (byte) 103, (byte) 112, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MouseWheelHandler([In] ChartPanel obj0)
    {
      base.\u002Ector();
      MouseWheelHandler mouseWheelHandler = this;
      this.chartPanel = obj0;
      this.zoomFactor = 0.1;
      ((Component) this.chartPanel).addMouseWheelListener((MouseWheelListener) this);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected MouseWheelHandler([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [LineNumberTable(new byte[] {(byte) 79, (byte) 103, (byte) 108, (byte) 103, (byte) 114, (byte) 110, (byte) 129, (byte) 104, (byte) 99, (byte) 101, (byte) 133, (byte) 101, (byte) 163, (byte) 168, (byte) 103, (byte) 111, (byte) 101, (byte) 107, (byte) 141, (byte) 101, (byte) 113, (byte) 177, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void handleZoomable([In] Zoomable obj0, [In] MouseWheelEvent obj1)
    {
      Plot plot = (Plot) obj0;
      PlotRenderingInfo plotInfo = this.chartPanel.getChartRenderingInfo().getPlotInfo();
      Point2D pd = this.chartPanel.translateScreenToJava2D(((MouseEvent) obj1).getPoint());
      if (!((RectangularShape) plotInfo.getDataArea()).contains(pd))
        return;
      int wheelRotation = obj1.getWheelRotation();
      int num1 = 0;
      if (wheelRotation < 0)
        num1 = -1;
      else if (wheelRotation > 0)
        num1 = 1;
      int num2 = plot.isNotify() ? 1 : 0;
      plot.setNotify(false);
      double d = 1.0 + this.zoomFactor;
      if (num1 > 0)
      {
        obj0.zoomDomainAxes(d, plotInfo, pd, true);
        obj0.zoomRangeAxes(d, plotInfo, pd, true);
      }
      else if (num1 < 0)
      {
        obj0.zoomDomainAxes(1.0 / d, plotInfo, pd, true);
        obj0.zoomRangeAxes(1.0 / d, plotInfo, pd, true);
      }
      plot.setNotify(num2 != 0);
    }

    public virtual double getZoomFactor()
    {
      return this.zoomFactor;
    }

    public virtual void setZoomFactor([In] double obj0)
    {
      this.zoomFactor = obj0;
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 108, (byte) 99, (byte) 129, (byte) 103, (byte) 104, (byte) 103, (byte) 234, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mouseWheelMoved([In] MouseWheelEvent obj0)
    {
      JFreeChart chart = this.chartPanel.getChart();
      if (chart == null)
        return;
      Plot plot = chart.getPlot();
      if (!(plot is Zoomable))
        return;
      this.handleZoomable((Zoomable) plot, obj0);
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
