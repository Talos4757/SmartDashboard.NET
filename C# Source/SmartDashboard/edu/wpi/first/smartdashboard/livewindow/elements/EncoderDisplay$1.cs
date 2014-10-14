// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.livewindow.elements.EncoderDisplay$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt.@event;
using java.lang;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.livewindow.elements
{
  [InnerClass]
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.livewindow.elements.EncoderDisplay", "init", "()V")]
  [SourceFile("EncoderDisplay.java")]
  [Modifiers]
  internal sealed class EncoderDisplay\u00241 : Object, ActionListener, EventListener
  {
    [Modifiers]
    internal EncoderDisplay this\u00240;

    [LineNumberTable((ushort) 53)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal EncoderDisplay\u00241([In] EncoderDisplay obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 6, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      EncoderDisplay.access\u0024000(this.this\u00240).setBindableValue(0.0);
    }
  }
}
