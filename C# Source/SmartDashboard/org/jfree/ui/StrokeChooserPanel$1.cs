// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.StrokeChooserPanel$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.ui
{
  [InnerClass]
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [SourceFile("StrokeChooserPanel.java")]
  [Modifiers]
  internal sealed class StrokeChooserPanel\u00241 : Object, ActionListener, EventListener
  {
    [Modifiers]
    private StrokeChooserPanel this\u00240;

    [LineNumberTable((ushort) 89)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal StrokeChooserPanel\u00241([In] StrokeChooserPanel obj0)
    {
      base.\u002Ector();
      StrokeChooserPanel\u00241 strokeChooserPanel1 = this;
      this.this\u00240 = obj0;
    }

    [LineNumberTable(new byte[] {(byte) 41, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      ((Component) this.this\u00240.getSelector()).transferFocus();
    }
  }
}
