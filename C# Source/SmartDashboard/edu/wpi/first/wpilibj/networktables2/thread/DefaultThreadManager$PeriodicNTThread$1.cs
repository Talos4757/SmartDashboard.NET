// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.thread.DefaultThreadManager$PeriodicNTThread$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpilibj.networktables2.thread
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("edu.wpi.first.wpilibj.networktables2.thread.DefaultThreadManager$PeriodicNTThread", "<init>", "(Ledu.wpi.first.wpilibj.networktables2.thread.PeriodicRunnable;Ljava.lang.String;)V")]
  [SourceFile(null)]
  [Modifiers]
  internal sealed class DefaultThreadManager\u0024PeriodicNTThread\u00241 : Object, Runnable
  {
    [Modifiers]
    internal PeriodicRunnable val\u0024r;
    [Modifiers]
    internal DefaultThreadManager.PeriodicNTThread this\u00240;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal DefaultThreadManager\u0024PeriodicNTThread\u00241([In] DefaultThreadManager.PeriodicNTThread obj0, [In] PeriodicRunnable obj1)
    {
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      try
      {
        while (DefaultThreadManager.PeriodicNTThread.access\u0024000(this.this\u00240))
          this.val\u0024r.run();
      }
      catch (InterruptedException ex)
      {
      }
    }
  }
}
