// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.about.SystemPropertiesPanel$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.ui.about
{
  [InnerClass]
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [SourceFile("SystemPropertiesPanel.java")]
  [Modifiers]
  internal sealed class SystemPropertiesPanel\u00241 : Object, ActionListener, EventListener
  {
    [Modifiers]
    private SystemPropertiesPanel this\u00240;

    [LineNumberTable((ushort) 116)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SystemPropertiesPanel\u00241([In] SystemPropertiesPanel obj0)
    {
      base.\u002Ector();
      SystemPropertiesPanel\u00241 propertiesPanel1 = this;
      this.this\u00240 = obj0;
    }

    [LineNumberTable(new byte[] {(byte) 68, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      this.this\u00240.copySystemPropertiesToClipboard();
    }
  }
}
