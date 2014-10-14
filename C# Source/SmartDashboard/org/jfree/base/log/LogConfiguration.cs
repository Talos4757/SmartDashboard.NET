// Decompiled with JetBrains decompiler
// Type: org.jfree.base.log.LogConfiguration
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using org.jfree.@base;
using org.jfree.@base.log;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.@base.log
{
  public class LogConfiguration : Object
  {
    internal static string __\u003C\u003ELOGTARGET_DEFAULT = (LogConfiguration.class\u0024org\u0024jfree\u0024util\u0024PrintStreamLogTarget != null ? LogConfiguration.class\u0024org\u0024jfree\u0024util\u0024PrintStreamLogTarget : (LogConfiguration.class\u0024org\u0024jfree\u0024util\u0024PrintStreamLogTarget = LogConfiguration.class\u0024("org.jfree.util.PrintStreamLogTarget"))).getName();
    public const string DISABLE_LOGGING_DEFAULT = "false";
    public const string LOGLEVEL = "org.jfree.base.LogLevel";
    public const string LOGLEVEL_DEFAULT = "Info";
    public const string LOGTARGET = "org.jfree.base.LogTarget";
    public const string DISABLE_LOGGING = "org.jfree.base.NoDefaultDebug";
    internal static Class class\u0024org\u0024jfree\u0024util\u0024PrintStreamLogTarget;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Modifiers]
    public static string LOGTARGET_DEFAULT
    {
      [HideFromJava] get
      {
        return LogConfiguration.__\u003C\u003ELOGTARGET_DEFAULT;
      }
    }

    [LineNumberTable((ushort) 68)]
    static LogConfiguration()
    {
    }

    [LineNumberTable(new byte[] {(byte) 27, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private LogConfiguration()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 109)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getLogLevel()
    {
      return BaseBoot.getInstance().getGlobalConfig().getConfigProperty("org.jfree.base.LogLevel", "Info");
    }

    [LineNumberTable((ushort) 148)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool isDisableLogging()
    {
      return (String.instancehelper_equalsIgnoreCase(BaseBoot.getInstance().getGlobalConfig().getConfigProperty("org.jfree.base.NoDefaultDebug", "false"), "true") ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 88)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getLogTarget()
    {
      return BaseBoot.getInstance().getGlobalConfig().getConfigProperty("org.jfree.base.LogTarget", LogConfiguration.__\u003C\u003ELOGTARGET_DEFAULT);
    }

    [LineNumberTable((ushort) 69)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, LogConfiguration.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        int num = 1;
        notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return @class;
label_3:
      string message = Throwable.instancehelper_getMessage((Exception) notFoundException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoClassDefFoundError(message);
    }

    [LineNumberTable(new byte[] {(byte) 49, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setLogTarget(string logTarget)
    {
      BaseBoot.getConfiguration().setConfigProperty("org.jfree.base.LogTarget", logTarget);
    }

    [LineNumberTable(new byte[] {(byte) 88, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setLogLevel(string level)
    {
      BaseBoot.getConfiguration().setConfigProperty("org.jfree.base.LogLevel", level);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 102, (byte) 162, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setDisableLogging(bool disableLogging)
    {
      BaseBoot.getConfiguration().setConfigProperty("org.jfree.base.NoDefaultDebug", String.valueOf(disableLogging));
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (LogConfiguration.__\u003CcallerID\u003E == null)
        LogConfiguration.__\u003CcallerID\u003E = (CallerID) new LogConfiguration.__\u003CCallerID\u003E();
      return LogConfiguration.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
