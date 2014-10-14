// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.Widget$ThreadSafeTextField$1
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
  [EnclosingMethod("edu.wpi.first.smartdashboard.gui.Widget$ThreadSafeTextField", "setText", "(Ljava.lang.String;)V")]
  [SourceFile("Widget.java")]
  [Modifiers]
  internal sealed class Widget\u0024ThreadSafeTextField\u00241 : Object, Runnable
  {
    [Modifiers]
    internal string val\u0024text;
    [Modifiers]
    internal Widget.ThreadSafeTextField this\u00240;

    [LineNumberTable((ushort) 219)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Widget\u0024ThreadSafeTextField\u00241([In] Widget.ThreadSafeTextField obj0, [In] string obj1)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 107, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      Widget.ThreadSafeTextField.access\u0024001(this.this\u00240, this.val\u0024text);
    }
  }
}
