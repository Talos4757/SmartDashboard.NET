// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.livewindow.elements.ServoController$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using javax.swing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.livewindow.elements
{
  [InnerClass]
  [EnclosingMethod("edu.wpi.first.smartdashboard.livewindow.elements.ServoController", "init", "()V")]
  [SourceFile("ServoController.java")]
  [Modifiers]
  internal sealed class ServoController\u00241 : KeyAdapter
  {
    [Modifiers]
    internal ServoController this\u00240;

    [LineNumberTable((ushort) 56)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ServoController\u00241([In] ServoController obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 9, (byte) 105, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void keyPressed([In] KeyEvent obj0)
    {
      if (obj0.getKeyCode() != 8)
        return;
      ((AbstractButton) ServoController.access\u0024000(this.this\u00240)).doClick();
    }
  }
}
