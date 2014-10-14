// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.DashboardMenu$10$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using javax.swing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.DashboardMenu$10", "valueChanged", "(Ledu.wpi.first.wpilibj.tables.ITable;Ljava.lang.String;Ljava.lang.Object;Z)V")]
  [SourceFile("DashboardMenu.java")]
  [Modifiers]
  internal sealed class DashboardMenu\u002410\u00241 : Object, Runnable
  {
    [Modifiers]
    internal bool val\u0024isInLW;
    [Modifiers]
    internal DashboardMenu\u002410 this\u00241;

    [LineNumberTable((ushort) 157)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DashboardMenu\u002410\u00241([In] DashboardMenu\u002410 obj0, [In] bool obj1)
    {
      int num = obj1 ? 1 : 0;
      this.this\u00241 = obj0;
      this.val\u0024isInLW = num != 0;
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 109, (byte) 223, (byte) 5, (byte) 191, (byte) 15, (byte) 104, (byte) 178})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      this.this\u00241.val\u0024frame.setDisplayMode(!this.val\u0024isInLW ? DashboardFrame.DisplayMode.__\u003C\u003ESmartDashboard : DashboardFrame.DisplayMode.__\u003C\u003ELiveWindow);
      this.this\u00241.val\u0024mainPanel.setCurrentPanel(!this.val\u0024isInLW ? MainPanel.getPanel("SmartDashboard") : MainPanel.getPanel("LiveWindow"));
      if (this.val\u0024isInLW)
        return;
      ((AbstractButton) this.this\u00241.val\u0024resetLW).doClick();
    }
  }
}
