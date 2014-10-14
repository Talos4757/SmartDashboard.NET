// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardMenu$11
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui
{
  [InnerClass]
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.DashboardMenu", "<init>", "(Ledu.wpi.first.smartdashboard.gui.DashboardFrame;Ledu.wpi.first.smartdashboard.gui.MainPanel;)V")]
  [SourceFile("DashboardMenu.java")]
  [Modifiers]
  internal sealed class DashboardMenu\u002411 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal Class val\u0024option;
    [Modifiers]
    internal MainPanel val\u0024mainPanel;
    [Modifiers]
    internal DashboardMenu this\u00240;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable((ushort) 180)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DashboardMenu\u002411([In] DashboardMenu obj0, [In] Class obj1, [In] MainPanel obj2)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 69, (byte) 118, (byte) 191, (byte) 9, (byte) 2, (byte) 129, (byte) 34, (byte) 129})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      try
      {
        try
        {
          StaticWidget staticWidget = (StaticWidget) this.val\u0024option.newInstance(DashboardMenu\u002411.__\u003CGetCallerID\u003E());
          MainPanel mainPanel = this.val\u0024mainPanel;
          MainPanel.getPanel("SmartDashboard").addElement((DisplayElement) staticWidget, (Point) null);
        }
        catch (InstantiationException ex)
        {
        }
      }
      catch (IllegalAccessException ex)
      {
        goto label_4;
      }
      return;
label_4:;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (DashboardMenu\u002411.__\u003CcallerID\u003E == null)
        DashboardMenu\u002411.__\u003CcallerID\u003E = (CallerID) new DashboardMenu\u002411.__\u003CCallerID\u003E();
      return DashboardMenu\u002411.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
