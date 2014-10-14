// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.Widget$EditorTextField$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing.text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui
{
  [InnerClass]
  [Implements(new string[] {"java.awt.event.FocusListener"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.Widget$EditorTextField", "<init>", "()V")]
  [SourceFile("Widget.java")]
  [Modifiers]
  internal sealed class Widget\u0024EditorTextField\u00242 : Object, FocusListener, EventListener
  {
    [Modifiers]
    internal Widget.EditorTextField this\u00240;

    [LineNumberTable((ushort) 235)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Widget\u0024EditorTextField\u00242([In] Widget.EditorTextField obj0)
    {
      base.\u002Ector();
    }

    public virtual void focusGained([In] FocusEvent obj0)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 124, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void focusLost([In] FocusEvent obj0)
    {
      this.this\u00240.textChanged(((JTextComponent) this.this\u00240).getText());
    }
  }
}
