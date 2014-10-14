// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.GlassPane$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui
{
  [InnerClass]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.GlassPane", "<init>", "(Ledu.wpi.first.smartdashboard.gui.DashboardFrame;Ledu.wpi.first.smartdashboard.gui.DashboardPanel;)V")]
  [SourceFile("GlassPane.java")]
  [Modifiers]
  internal sealed class GlassPane\u00242 : KeyAdapter
  {
    [Modifiers]
    internal GlassPane this\u00240;

    [LineNumberTable((ushort) 54)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal GlassPane\u00242([In] GlassPane obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 8, (byte) 106, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void keyPressed([In] KeyEvent obj0)
    {
      if (obj0.getKeyCode() != 16)
        return;
      this.this\u00240.setShowingGrid(true);
    }

    [LineNumberTable(new byte[] {(byte) 15, (byte) 106, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void keyReleased([In] KeyEvent obj0)
    {
      if (obj0.getKeyCode() != 16)
        return;
      this.this\u00240.setShowingGrid(false);
    }
  }
}
