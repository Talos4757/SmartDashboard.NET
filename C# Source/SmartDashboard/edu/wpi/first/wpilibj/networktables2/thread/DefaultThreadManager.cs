// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.thread.DefaultThreadManager
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.wpilibj.networktables2.thread
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.thread.NTThreadManager"})]
  [SourceFile(null)]
  public class DefaultThreadManager : Object, NTThreadManager
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultThreadManager()
    {
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual NTThread newBlockingPeriodicThread(PeriodicRunnable pr, string str)
    {
      return (NTThread) new DefaultThreadManager.PeriodicNTThread(pr, str);
    }

    [InnerClass]
    [Implements(new string[] {"edu.wpi.first.wpilibj.networktables2.thread.NTThread"})]
    [SourceFile(null)]
    [Modifiers]
    internal sealed class PeriodicNTThread : Object, NTThread
    {
      [Modifiers]
      private Thread thread;
      private bool run;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PeriodicNTThread([In] PeriodicRunnable obj0, [In] string obj1)
      {
        base.\u002Ector();
        DefaultThreadManager.PeriodicNTThread periodicNtThread = this;
        this.run = true;
        Thread.__\u003Cclinit\u003E();
        this.thread = new Thread((Runnable) new DefaultThreadManager\u0024PeriodicNTThread\u00241(this, obj0), obj1);
        this.thread.start();
      }

      [Modifiers]
      internal static bool access\u0024000([In] DefaultThreadManager.PeriodicNTThread obj0)
      {
        return obj0.run;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void stop()
      {
        this.run = false;
        this.thread.interrupt();
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool isRunning()
      {
        return (this.thread.isAlive() ? 1 : 0) != 0;
      }
    }
  }
}
