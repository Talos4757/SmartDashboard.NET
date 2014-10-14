// Decompiled with JetBrains decompiler
// Type: org.jfree.base.log.DefaultLog
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.@base.log;
using org.jfree.util;
using System.Runtime.CompilerServices;

namespace org.jfree.@base.log
{
  public class DefaultLog : Log
  {
    [Modifiers]
    private static PrintStreamLogTarget DEFAULT_LOG_TARGET = new PrintStreamLogTarget();
    [Modifiers]
    private static DefaultLog defaultLogInstance = new DefaultLog();

    [LineNumberTable(new byte[] {(byte) 8, (byte) 234, (byte) 78, (byte) 106, (byte) 207, (byte) 112, (byte) 109, (byte) 173, (byte) 246, (byte) 69, (byte) 2, (byte) 97, (byte) 139})]
    static DefaultLog()
    {
      DefaultLog.defaultLogInstance.addTarget((LogTarget) DefaultLog.DEFAULT_LOG_TARGET);
      try
      {
        if (Boolean.valueOf(System.getProperty("org.jfree.DebugDefault", "false")).booleanValue())
        {
          DefaultLog.defaultLogInstance.setDebuglevel(3);
          return;
        }
        else
        {
          DefaultLog.defaultLogInstance.setDebuglevel(1);
          return;
        }
      }
      catch (SecurityException ex)
      {
      }
      DefaultLog.defaultLogInstance.setDebuglevel(1);
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal DefaultLog()
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 199, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public override void addTarget(LogTarget target)
    {
      base.addTarget(target);
      if (target == DefaultLog.DEFAULT_LOG_TARGET)
        return;
      this.removeTarget((LogTarget) DefaultLog.DEFAULT_LOG_TARGET);
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 107, (byte) 102, (byte) 109, (byte) 137, (byte) 109, (byte) 137, (byte) 109, (byte) 137, (byte) 109, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      this.removeTarget((LogTarget) DefaultLog.DEFAULT_LOG_TARGET);
      string logLevel = LogConfiguration.getLogLevel();
      if (String.instancehelper_equalsIgnoreCase(logLevel, "error"))
        this.setDebuglevel(0);
      else if (String.instancehelper_equalsIgnoreCase(logLevel, "warn"))
        this.setDebuglevel(1);
      else if (String.instancehelper_equalsIgnoreCase(logLevel, "info"))
      {
        this.setDebuglevel(2);
      }
      else
      {
        if (!String.instancehelper_equalsIgnoreCase(logLevel, "debug"))
          return;
        this.setDebuglevel(3);
      }
    }

    public static DefaultLog getDefaultLog()
    {
      return DefaultLog.defaultLogInstance;
    }

    [LineNumberTable(new byte[] {(byte) 91, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void installDefaultLog()
    {
      Log.defineLog((Log) DefaultLog.defaultLogInstance);
    }
  }
}
