// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardMenu$12
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using javax.swing;
using javax.swing.@event;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui
{
  [InnerClass]
  [Implements(new string[] {"javax.swing.event.MenuListener"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.DashboardMenu", "<init>", "(Ledu.wpi.first.smartdashboard.gui.DashboardFrame;Ledu.wpi.first.smartdashboard.gui.MainPanel;)V")]
  [SourceFile("DashboardMenu.java")]
  [Modifiers]
  internal sealed class DashboardMenu\u002412 : Object, MenuListener, EventListener
  {
    [Modifiers]
    internal JMenu val\u0024revealMenu;
    [Modifiers]
    internal MainPanel val\u0024mainPanel;
    [Modifiers]
    internal DashboardMenu this\u00240;

    [LineNumberTable((ushort) 198)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DashboardMenu\u002412([In] DashboardMenu obj0, [In] JMenu obj1, [In] MainPanel obj2)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 86, (byte) 139, (byte) 98, (byte) 127, (byte) 17, (byte) 126, (byte) 100, (byte) 255, (byte) 1, (byte) 72, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void menuSelected([In] MenuEvent obj0)
    {
      this.val\u0024revealMenu.removeAll();
      int num = 0;
      MainPanel mainPanel1 = this.val\u0024mainPanel;
      Iterator iterator = MainPanel.getPanel("SmartDashboard").getHiddenFields().iterator();
      while (iterator.hasNext())
      {
        string str = (string) iterator.next();
        MainPanel mainPanel2 = this.val\u0024mainPanel;
        if (MainPanel.getPanel("SmartDashboard").getTable().containsKey(str))
        {
          ++num;
          JMenu jmenu = this.val\u0024revealMenu;
          JMenuItem.__\u003Cclinit\u003E();
          JMenuItem jmenuItem = new JMenuItem((Action) new DashboardMenu\u002412\u00241(this, str, str));
          jmenu.add(jmenuItem);
        }
      }
      ((JMenuItem) this.val\u0024revealMenu).setEnabled(num != 0);
    }

    public virtual void menuDeselected([In] MenuEvent obj0)
    {
    }

    public virtual void menuCanceled([In] MenuEvent obj0)
    {
    }
  }
}
