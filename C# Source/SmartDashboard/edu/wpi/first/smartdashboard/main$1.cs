// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.main$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javax.swing;
using System;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard
{
  [InnerClass]
  [Implements(new string[] {"java.lang.Runnable"})]
  [EnclosingMethod("edu.wpi.first.smartdashboard.main", "main", "([Ljava.lang.String;)V")]
  [SourceFile("main.java")]
  internal sealed class main\u00241 : Object, Runnable
  {
    [LineNumberTable((ushort) 49)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal main\u00241()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 2, (byte) 127, (byte) 0, (byte) 99})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void run()
    {
      try
      {
        UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
      }
    }
  }
}
