// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.Scheduler$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.lang;
using javax.swing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [InnerClass]
  [Implements(new string[] {"edu.wpi.first.wpilibj.tables.ITableListener"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.elements.Scheduler", null, null)]
  [SourceFile("Scheduler.java")]
  [Modifiers]
  internal sealed class Scheduler\u00241 : Object, ITableListener
  {
    internal bool running;
    [Modifiers]
    internal Scheduler this\u00240;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 185, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Scheduler\u00241([In] Scheduler obj0)
    {
      base.\u002Ector();
      Scheduler\u00241 scheduler1 = this;
      this.running = false;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 191, (byte) 104, (byte) 129, (byte) 103, (byte) 237, (byte) 117})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void valueChanged([In] ITable obj0, [In] string obj1, [In] object obj2, [In] bool obj3)
    {
      if (this.running)
        return;
      this.running = true;
      SwingUtilities.invokeLater((Runnable) new Scheduler\u00241\u00241(this));
    }
  }
}
