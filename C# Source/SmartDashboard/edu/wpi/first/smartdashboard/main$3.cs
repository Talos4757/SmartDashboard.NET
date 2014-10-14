// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.main$3
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.io;
using java.lang;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.main", "main", "([Ljava.lang.String;)V")]
  [SourceFile("main.java")]
  internal sealed class main\u00243 : Object, Runnable
  {
    [Modifiers]
    internal ProgressMonitor val\u0024monitor;

    [LineNumberTable((ushort) 119)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal main\u00243([In] ProgressMonitor obj0)
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 73, (byte) 106, (byte) 139, (byte) 112, (byte) 176, (byte) 127, (byte) 5, (byte) 104, (byte) 176, (byte) 255, (byte) 8, (byte) 70, (byte) 226, (byte) 60, (byte) 97, (byte) 134, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      Exception exception;
      try
      {
        ((Window) main.access\u0024000()).pack();
        ((Window) main.access\u0024000()).setVisible(true);
        this.val\u0024monitor.setProgress(750);
        this.val\u0024monitor.setNote("Loading From Save");
        File.__\u003Cclinit\u003E();
        File file = new File((string) main.access\u0024000().getPrefs().__\u003C\u003EsaveFile.getValue());
        if (file.exists())
          main.access\u0024000().load(file.getPath());
        this.val\u0024monitor.setProgress(1000);
        return;
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
          throw;
        else
          exception = (Exception) m0;
      }
      Throwable.instancehelper_printStackTrace((Exception) exception);
      System.exit(1);
    }
  }
}
