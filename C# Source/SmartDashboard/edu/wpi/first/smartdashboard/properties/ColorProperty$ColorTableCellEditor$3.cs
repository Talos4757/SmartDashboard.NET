// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.properties.ColorProperty$ColorTableCellEditor$3
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.properties
{
  [InnerClass]
  [EnclosingMethod("edu.wpi.first.smartdashboard.properties.ColorProperty$ColorTableCellEditor", "<init>", "(Ledu.wpi.first.smartdashboard.properties.ColorProperty;Ljava.awt.Component;)V")]
  [SourceFile("ColorProperty.java")]
  [Modifiers]
  internal sealed class ColorProperty\u0024ColorTableCellEditor\u00243 : WindowAdapter
  {
    [Modifiers]
    internal ColorProperty val\u0024this\u00240;
    [Modifiers]
    internal ColorProperty.ColorTableCellEditor this\u00241;

    [LineNumberTable((ushort) 97)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ColorProperty\u0024ColorTableCellEditor\u00243([In] ColorProperty.ColorTableCellEditor obj0, [In] ColorProperty obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 51, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void windowClosing([In] WindowEvent obj0)
    {
      this.this\u00241.cancelCellEditing();
    }
  }
}
