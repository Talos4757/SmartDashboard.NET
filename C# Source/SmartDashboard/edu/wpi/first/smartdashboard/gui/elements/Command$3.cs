// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.Command$3
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using javax.swing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.elements.Command", "booleanChanged", "(Ledu.wpi.first.wpilibj.tables.ITable;Ljava.lang.String;ZZ)V")]
  [SourceFile("Command.java")]
  [Modifiers]
  internal sealed class Command\u00243 : Object, Runnable
  {
    [Modifiers]
    internal bool val\u0024value;
    [Modifiers]
    internal Command this\u00240;

    [LineNumberTable((ushort) 70)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Command\u00243([In] Command obj0, [In] bool obj1)
    {
      int num = obj1 ? 1 : 0;
      this.this\u00240 = obj0;
      this.val\u0024value = num != 0;
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 22, (byte) 104, (byte) 159, (byte) 3, (byte) 127, (byte) 1, (byte) 107, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      if (this.val\u0024value)
        Command.access\u0024300(this.this\u00240).show((Container) Command.access\u0024200(this.this\u00240), "Cancel");
      else
        Command.access\u0024300(this.this\u00240).show((Container) Command.access\u0024200(this.this\u00240), "Start");
      ((JComponent) this.this\u00240).revalidate();
      ((Component) this.this\u00240).repaint();
    }
  }
}
