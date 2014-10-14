// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.properties.ColorProperty$ColorTableCellEditor$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.properties
{
  [InnerClass]
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.properties.ColorProperty$ColorTableCellEditor", "<init>", "(Ledu.wpi.first.smartdashboard.properties.ColorProperty;Ljava.awt.Component;)V")]
  [SourceFile("ColorProperty.java")]
  [Modifiers]
  internal sealed class ColorProperty\u0024ColorTableCellEditor\u00241 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal ColorProperty val\u0024this\u00240;
    [Modifiers]
    internal ColorProperty.ColorTableCellEditor this\u00241;

    [LineNumberTable((ushort) 86)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ColorProperty\u0024ColorTableCellEditor\u00241([In] ColorProperty.ColorTableCellEditor obj0, [In] ColorProperty obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 39, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      this.this\u00241.stopCellEditing();
    }
  }
}
