// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.ConnectionIndicator$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.elements.ConnectionIndicator", null, null)]
  [SourceFile("ConnectionIndicator.java")]
  [Modifiers]
  internal sealed class ConnectionIndicator\u00241 : Object, Runnable
  {
    [Modifiers]
    internal ConnectionIndicator this\u00240;

    [LineNumberTable((ushort) 28)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal ConnectionIndicator\u00241([In] ConnectionIndicator obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 173, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      ((Component) this.this\u00240).repaint();
    }
  }
}
