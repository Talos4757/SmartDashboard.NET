// Decompiled with JetBrains decompiler
// Type: org.jfree.base.log.DefaultLogModule
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using org.jfree.@base.log;
using org.jfree.@base.modules;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.@base.log
{
  public class DefaultLogModule : AbstractModule
  {
    internal static Class class\u0024org\u0024jfree\u0024util\u0024PrintStreamLogTarget;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Throws(new string[] {"org.jfree.base.modules.ModuleInitializeException"})]
    [LineNumberTable(new byte[] {(byte) 19, (byte) 104, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultLogModule()
    {
      DefaultLogModule defaultLogModule = this;
      this.loadModuleInfo();
    }

    [LineNumberTable((ushort) 89)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal new static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, DefaultLogModule.__\u003CGetCallerID\u003E());
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

    [Throws(new string[] {"org.jfree.base.modules.ModuleInitializeException"})]
    [LineNumberTable(new byte[] {(byte) 33, (byte) 135, (byte) 161, (byte) 191, (byte) 16, (byte) 101, (byte) 143, (byte) 188, (byte) 138, (byte) 172})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void initialize(SubSystem subSystem)
    {
      if (LogConfiguration.isDisableLogging() || !String.instancehelper_equals(LogConfiguration.getLogTarget(), (object) (DefaultLogModule.class\u0024org\u0024jfree\u0024util\u0024PrintStreamLogTarget != null ? DefaultLogModule.class\u0024org\u0024jfree\u0024util\u0024PrintStreamLogTarget : (DefaultLogModule.class\u0024org\u0024jfree\u0024util\u0024PrintStreamLogTarget = DefaultLogModule.class\u0024("org.jfree.util.PrintStreamLogTarget"))).getName()))
        return;
      DefaultLog.installDefaultLog();
      Log.getInstance().addTarget((LogTarget) new PrintStreamLogTarget());
      if (String.instancehelper_equals("true", (object) subSystem.getGlobalConfig().getConfigProperty("org.jfree.base.LogAutoInit")))
        Log.getInstance().init();
      Log.info((object) "Default log target started ... previous log messages could have been ignored.");
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (DefaultLogModule.__\u003CcallerID\u003E == null)
        DefaultLogModule.__\u003CcallerID\u003E = (CallerID) new DefaultLogModule.__\u003CCallerID\u003E();
      return DefaultLogModule.__\u003CcallerID\u003E;
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
