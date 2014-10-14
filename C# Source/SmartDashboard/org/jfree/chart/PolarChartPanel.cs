// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.PolarChartPanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using javax.swing;
using org.jfree.chart.plot;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart
{
  [Serializable]
  public class PolarChartPanel : ChartPanel
  {
    private const string POLAR_ZOOM_IN_ACTION_COMMAND = "Polar Zoom In";
    private const string POLAR_ZOOM_OUT_ACTION_COMMAND = "Polar Zoom Out";
    private const string POLAR_AUTO_RANGE_ACTION_COMMAND = "Polar Auto Range";

    [HideFromJava]
    static PolarChartPanel()
    {
      ChartPanel.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 115, (byte) 98, (byte) 106, (byte) 103, (byte) 107, (byte) 107, (byte) 107, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PolarChartPanel(JFreeChart chart, bool useBuffer)
    {
      int num = useBuffer ? 1 : 0;
      // ISSUE: explicit constructor call
      base.\u002Ector(chart, num != 0);
      PolarChartPanel polarChartPanel = this;
      this.checkChart(chart);
      this.setMinimumDrawWidth(200);
      this.setMinimumDrawHeight(200);
      this.setMaximumDrawWidth(2000);
      this.setMaximumDrawHeight(2000);
    }

    [LineNumberTable(new byte[] {(byte) 49, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PolarChartPanel(JFreeChart chart)
      : this(chart, true)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PolarChartPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 112, (byte) 103, (byte) 104, (byte) 144})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void checkChart([In] JFreeChart obj0)
    {
      if (obj0.getPlot() is PolarPlot)
        return;
      string str = "plot is not a PolarPlot";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new IllegalArgumentException(str);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 127, (byte) 98, (byte) 111, (byte) 104, (byte) 104, (byte) 103, (byte) 110, (byte) 226, (byte) 59, (byte) 230, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private int getPopupMenuItem([In] JPopupMenu obj0, [In] string obj1)
    {
      int num = -1;
      for (int index = 0; num == -1 && index < ((Container) obj0).getComponentCount(); ++index)
      {
        Component component = ((Container) obj0).getComponent(index);
        if (component is JMenuItem)
        {
          JMenuItem jmenuItem = (JMenuItem) component;
          if (String.instancehelper_equals(obj1, (object) ((AbstractButton) jmenuItem).getText()))
            num = index;
        }
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 76, (byte) 103, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setChart(JFreeChart chart)
    {
      this.checkChart(chart);
      base.setChart(chart);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 106, (byte) 105, (byte) 108, (byte) 111, (byte) 111, (byte) 111, (byte) 102, (byte) 108, (byte) 108, (byte) 136, (byte) 108, (byte) 108, (byte) 136, (byte) 108, (byte) 108, (byte) 136, (byte) 101, (byte) 171, (byte) 139, (byte) 108, (byte) 101, (byte) 171, (byte) 134, (byte) 108, (byte) 101, (byte) 171, (byte) 134, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override JPopupMenu createPopupMenu(bool properties, bool save, bool print, bool zoom)
    {
      int num1 = properties ? 1 : 0;
      int num2 = save ? 1 : 0;
      int num3 = print ? 1 : 0;
      int num4 = zoom ? 1 : 0;
      JPopupMenu popupMenu = base.createPopupMenu(num1 != 0, num2 != 0, num3 != 0, num4 != 0);
      int num5 = this.getPopupMenuItem(popupMenu, "Zoom In");
      int num6 = this.getPopupMenuItem(popupMenu, "Zoom Out");
      int num7 = this.getPopupMenuItem(popupMenu, "Auto Range");
      if (num4 != 0)
      {
        JMenuItem jmenuItem1 = new JMenuItem("Zoom In");
        ((AbstractButton) jmenuItem1).setActionCommand("Polar Zoom In");
        ((AbstractButton) jmenuItem1).addActionListener((ActionListener) this);
        JMenuItem jmenuItem2 = new JMenuItem("Zoom Out");
        ((AbstractButton) jmenuItem2).setActionCommand("Polar Zoom Out");
        ((AbstractButton) jmenuItem2).addActionListener((ActionListener) this);
        JMenuItem jmenuItem3 = new JMenuItem("Auto Range");
        ((AbstractButton) jmenuItem3).setActionCommand("Polar Auto Range");
        ((AbstractButton) jmenuItem3).addActionListener((ActionListener) this);
        if (num5 != -1)
          popupMenu.remove(num5);
        else
          num5 = ((Container) popupMenu).getComponentCount() - 1;
        ((Container) popupMenu).add((Component) jmenuItem1, num5);
        if (num6 != -1)
          popupMenu.remove(num6);
        else
          num6 = num5 + 1;
        ((Container) popupMenu).add((Component) jmenuItem2, num6);
        if (num7 != -1)
          popupMenu.remove(num7);
        else
          num7 = num6 + 1;
        ((Container) popupMenu).add((Component) jmenuItem3, num7);
      }
      return popupMenu;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 79, (byte) 135, (byte) 109, (byte) 113, (byte) 111, (byte) 101, (byte) 109, (byte) 113, (byte) 111, (byte) 98, (byte) 109, (byte) 113, (byte) 108, (byte) 130, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void actionPerformed(ActionEvent @event)
    {
      string actionCommand = @event.getActionCommand();
      if (String.instancehelper_equals(actionCommand, (object) "Polar Zoom In"))
        ((PolarPlot) this.getChart().getPlot()).zoom(0.5);
      else if (String.instancehelper_equals(actionCommand, (object) "Polar Zoom Out"))
        ((PolarPlot) this.getChart().getPlot()).zoom(2.0);
      else if (String.instancehelper_equals(actionCommand, (object) "Polar Auto Range"))
        ((PolarPlot) this.getChart().getPlot()).getAxis().setAutoRange(true);
      else
        base.actionPerformed(@event);
    }
  }
}
