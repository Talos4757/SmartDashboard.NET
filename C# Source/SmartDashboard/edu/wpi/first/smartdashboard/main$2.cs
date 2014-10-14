// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.main$2
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.main", "main", "([Ljava.lang.String;)V")]
  [SourceFile("main.java")]
  internal sealed class main\u00242 : Object, Runnable
  {
    [LineNumberTable((ushort) 77)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal main\u00242()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 29, (byte) 117})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      DashboardFrame.__\u003Cclinit\u003E();
      main.access\u0024002(new DashboardFrame(main.access\u0024100()));
    }
  }
}
