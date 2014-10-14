// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.tabbedui.TabbedDialog$1
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
  [SourceFile("TabbedDialog.java")]
  [Modifiers]
  internal sealed class TabbedDialog\u00241 : WindowAdapter
  {
    [Modifiers]
    private TabbedDialog this\u00240;

    [LineNumberTable((ushort) 197)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal TabbedDialog\u00241([In] TabbedDialog obj0)
    {
      base.\u002Ector();
      TabbedDialog\u00241 tabbedDialog1 = this;
      this.this\u00240 = obj0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 85, (byte) 159, (byte) 5})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void windowClosing([In] WindowEvent obj0)
    {
      ((ActionListener) this.this\u00240.getTabbedUI().getCloseAction()).actionPerformed(new ActionEvent((object) this, 1001, (string) null, 0));
    }
  }
}
