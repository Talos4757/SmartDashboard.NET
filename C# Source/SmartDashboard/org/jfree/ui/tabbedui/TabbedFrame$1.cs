// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.tabbedui.TabbedFrame$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.ui.tabbedui
{
  [InnerClass]
  [SourceFile("TabbedFrame.java")]
  [Modifiers]
  internal sealed class TabbedFrame\u00241 : WindowAdapter
  {
    [Modifiers]
    private TabbedFrame this\u00240;

    [LineNumberTable((ushort) 125)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal TabbedFrame\u00241([In] TabbedFrame obj0)
    {
      base.\u002Ector();
      TabbedFrame\u00241 tabbedFrame1 = this;
      this.this\u00240 = obj0;
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 159, (byte) 5})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void windowClosing([In] WindowEvent obj0)
    {
      ((ActionListener) this.this\u00240.getTabbedUI().getCloseAction()).actionPerformed(new ActionEvent((object) this, 1001, (string) null, 0));
    }
  }
}
