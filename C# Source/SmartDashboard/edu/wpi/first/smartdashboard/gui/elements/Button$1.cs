// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.Button$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [InnerClass]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.elements.Button", "init", "()V")]
  [SourceFile("Button.java")]
  [Modifiers]
  internal sealed class Button\u00241 : MouseAdapter
  {
    [Modifiers]
    internal Button this\u00240;

    [LineNumberTable((ushort) 26)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Button\u00241([In] Button obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 171, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mousePressed([In] MouseEvent obj0)
    {
      Button.access\u0024000(this.this\u00240).putBoolean("pressed", true);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 120})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void mouseReleased([In] MouseEvent obj0)
    {
      Button.access\u0024100(this.this\u00240).putBoolean("pressed", false);
    }
  }
}
