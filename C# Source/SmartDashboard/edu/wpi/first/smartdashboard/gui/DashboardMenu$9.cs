// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardMenu$9
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.livewindow.elements;
using IKVM.Attributes;
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
  internal sealed class DashboardMenu\u00249 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal DashboardMenu this\u00240;

    [LineNumberTable((ushort) 140)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DashboardMenu\u00249([In] DashboardMenu obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 127, (byte) 13, (byte) 127, (byte) 1, (byte) 104, (byte) 127, (byte) 10, (byte) 210})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      Iterator iterator1 = MainPanel.getPanel("LiveWindow").getSubsystems().iterator();
label_1:
      while (iterator1.hasNext())
      {
        Iterator iterator2 = ((LWSubsystem) iterator1.next()).getWidgets().iterator();
        while (true)
        {
          Widget widget;
          do
          {
            if (iterator2.hasNext())
              widget = (Widget) iterator2.next();
            else
              goto label_1;
          }
          while (!(widget is Controller));
          System.get_out().println(new StringBuilder().append("\tResetting ").append(widget.getFieldName()).toString());
          ((Controller) widget).reset();
        }
      }
    }
  }
}
