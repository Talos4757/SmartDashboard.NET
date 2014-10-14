// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardMenu$5
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.properties;
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
  internal sealed class DashboardMenu\u00245 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal DashboardFrame val\u0024frame;
    [Modifiers]
    internal DashboardMenu this\u00240;

    [LineNumberTable((ushort) 99)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DashboardMenu\u00245([In] DashboardMenu obj0, [In] DashboardFrame obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 51, (byte) 108, (byte) 113, (byte) 107, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      PropertyEditor propertyEditor = this.val\u0024frame.getPropertyEditor();
      propertyEditor.setPropertyHolder((PropertyHolder) this.val\u0024frame.getPrefs());
      ((Dialog) propertyEditor).setTitle("Edit Preferences");
      ((Dialog) propertyEditor).setVisible(true);
    }
  }
}
