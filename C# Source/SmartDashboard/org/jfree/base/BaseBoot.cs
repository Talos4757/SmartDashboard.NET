// Decompiled with JetBrains decompiler
// Type: org.jfree.base.BaseBoot
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using org.jfree;
using org.jfree.@base;
using org.jfree.@base.config;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.@base
{
  public class BaseBoot : AbstractBoot
  {
    private static BaseBoot singleton;
    private BootableProjectInfo bootableProjectInfo;
    internal static Class class\u0024org\u0024jfree\u0024base\u0024BaseBoot;
    internal static Class class\u0024org\u0024jfree\u0024base\u0024log\u0024DefaultLogModule;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 22, (byte) 104, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private BaseBoot()
    {
      BaseBoot baseBoot = this;
      this.bootableProjectInfo = (BootableProjectInfo) JCommon.__\u003C\u003EINFO;
    }

    [Modifiers]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 115, (byte) 108, (byte) 103, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AbstractBoot getInstance()
    {
      lock ((object) ClassLiteral<BaseBoot>.Value)
      {
        if (BaseBoot.singleton == null)
          BaseBoot.singleton = new BaseBoot();
        return (AbstractBoot) BaseBoot.singleton;
      }
    }

    [LineNumberTable((ushort) 100)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal new static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, BaseBoot.__\u003CGetCallerID\u003E());
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

    [LineNumberTable((ushort) 82)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ModifiableConfiguration getConfiguration()
    {
      return (ModifiableConfiguration) BaseBoot.getInstance().getGlobalConfig();
    }

    [LineNumberTable((ushort) 98)]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    protected internal override Configuration loadConfiguration()
    {
      return this.createDefaultHierarchicalConfiguration("/org/jfree/base/jcommon.properties", "/jcommon.properties", true, BaseBoot.class\u0024org\u0024jfree\u0024base\u0024BaseBoot != null ? BaseBoot.class\u0024org\u0024jfree\u0024base\u0024BaseBoot : (BaseBoot.class\u0024org\u0024jfree\u0024base\u0024BaseBoot = BaseBoot.class\u0024("org.jfree.base.BaseBoot")));
    }

    [LineNumberTable(new byte[] {(byte) 70, (byte) 180, (byte) 127, (byte) 15, (byte) 112, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void performBoot()
    {
      ObjectUtilities.setClassLoaderSource(BaseBoot.getConfiguration().getConfigProperty("org.jfree.ClassLoader"));
      this.getPackageManager().addModule((BaseBoot.class\u0024org\u0024jfree\u0024base\u0024log\u0024DefaultLogModule != null ? BaseBoot.class\u0024org\u0024jfree\u0024base\u0024log\u0024DefaultLogModule : (BaseBoot.class\u0024org\u0024jfree\u0024base\u0024log\u0024DefaultLogModule = BaseBoot.class\u0024("org.jfree.base.log.DefaultLogModule"))).getName());
      this.getPackageManager().load("org.jfree.jcommon.modules.");
      this.getPackageManager().initializeModules();
    }

    protected internal override BootableProjectInfo getProjectInfo()
    {
      return this.bootableProjectInfo;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (BaseBoot.__\u003CcallerID\u003E == null)
        BaseBoot.__\u003CcallerID\u003E = (CallerID) new BaseBoot.__\u003CCallerID\u003E();
      return BaseBoot.__\u003CcallerID\u003E;
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
