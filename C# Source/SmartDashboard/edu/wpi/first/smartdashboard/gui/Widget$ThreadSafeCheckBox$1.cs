// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.Widget$ThreadSafeCheckBox$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.gui
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.Widget$ThreadSafeCheckBox", "setText", "(Z)V")]
  [SourceFile("Widget.java")]
  [Modifiers]
  internal sealed class Widget\u0024ThreadSafeCheckBox\u00241 : Object, Runnable
  {
    [Modifiers]
    internal bool val\u0024selected;
    [Modifiers]
    internal Widget.ThreadSafeCheckBox this\u00240;

    [LineNumberTable((ushort) 250)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Widget\u0024ThreadSafeCheckBox\u00241([In] Widget.ThreadSafeCheckBox obj0, [In] bool obj1)
    {
      int num = obj1 ? 1 : 0;
      this.this\u00240 = obj0;
      this.val\u0024selected = num != 0;
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 138, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      Widget.ThreadSafeCheckBox.access\u0024101(this.this\u00240, this.val\u0024selected);
    }
  }
}
