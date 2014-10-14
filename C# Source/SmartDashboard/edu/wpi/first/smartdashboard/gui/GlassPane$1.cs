// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.GlassPane$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using javax.swing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui
{
  [InnerClass]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.GlassPane", "<init>", "(Ledu.wpi.first.smartdashboard.gui.DashboardFrame;Ledu.wpi.first.smartdashboard.gui.DashboardPanel;)V")]
  [SourceFile("GlassPane.java")]
  [Modifiers]
  internal sealed class GlassPane\u00241 : ComponentAdapter
  {
    [Modifiers]
    internal GlassPane this\u00240;

    [LineNumberTable((ushort) 45)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal GlassPane\u00241([In] GlassPane obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 191, (byte) 107, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void componentShown([In] ComponentEvent obj0)
    {
      ((JComponent) this.this\u00240).requestFocus();
      this.this\u00240.setShowingGrid(false);
    }
  }
}
