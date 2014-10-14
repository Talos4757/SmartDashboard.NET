// Decompiled with JetBrains decompiler
// Type: org.jfree.base.AbstractBoot
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.net;
using java.util;
using org.jfree.@base;
using org.jfree.@base.config;
using org.jfree.@base.modules;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace org.jfree.@base
{
  [Implements(new string[] {"org.jfree.base.modules.SubSystem"})]
  public abstract class AbstractBoot : Object, SubSystem
  {
    private ExtendedConfigurationWrapper extWrapper;
    private PackageManager packageManager;
    private Configuration globalConfig;
    private bool bootInProgress;
    private bool bootDone;
    internal static Class class\u0024org\u0024jfree\u0024base\u0024config\u0024PropertyFileConfiguration;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 49, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal AbstractBoot()
    {
      base.\u002Ector();
    }

    protected internal abstract Configuration loadConfiguration();

    [MethodImpl(MethodImplOptions.Synchronized)]
    public bool isBootDone()
    {
      return this.bootDone;
    }

    [MethodImpl(MethodImplOptions.Synchronized)]
    public bool isBootInProgress()
    {
      return this.bootInProgress;
    }

    protected internal abstract BootableProjectInfo getProjectInfo();

    [LineNumberTable(new byte[] {(byte) 160, (byte) 120, (byte) 99, (byte) 162, (byte) 146, (byte) 119, (byte) 159, (byte) 17, (byte) 97, (byte) 127, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual AbstractBoot loadBooter(string classname)
    {
      if (classname == null)
        return (AbstractBoot) null;
      AbstractBoot abstractBoot;
      try
      {
        abstractBoot = (AbstractBoot) ObjectUtilities.getClassLoader(Object.instancehelper_getClass((object) this)).loadClass(classname).getMethod("getInstance", (Class[]) null, AbstractBoot.__\u003CGetCallerID\u003E()).invoke((object) null, (object[]) null, AbstractBoot.__\u003CGetCallerID\u003E());
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
        else
          goto label_6;
      }
      return abstractBoot;
label_6:
      Log.info((object) new StringBuffer().append("Unable to boot dependent class: ").append(classname).toString());
      return (AbstractBoot) null;
    }

    [LineNumberTable(new byte[] {(byte) 106, (byte) 104, (byte) 104, (byte) 148, (byte) 136, (byte) 206, (byte) 16, (byte) 129, (byte) 130, (byte) 104, (byte) 136, (byte) 103, (byte) 182, (byte) 103, (byte) 102, (byte) 103, (byte) 106, (byte) 112, (byte) 135, (byte) 106, (byte) 117, (byte) 137, (byte) 207, (byte) 17, (byte) 129, (byte) 130, (byte) 247, (byte) 50, (byte) 233, (byte) 83, (byte) 102, (byte) 131, (byte) 223, (byte) 28, (byte) 191, (byte) 5, (byte) 105, (byte) 103, (byte) 103, (byte) 102, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void start()
    {
      AbstractBoot abstractBoot1;
      Monitor.Enter((object) (abstractBoot1 = this));
      // ISSUE: fault handler
      try
      {
        if (this.isBootDone())
        {
          Monitor.Exit((object) abstractBoot1);
          return;
        }
      }
      __fault
      {
        Monitor.Exit((object) abstractBoot1);
      }
      while (true)
      {
        // ISSUE: fault handler
        try
        {
          if (this.isBootInProgress())
          {
            try
            {
              Object.instancehelper_wait((object) this);
            }
            catch (InterruptedException ex)
            {
            }
          }
          else
            break;
        }
        __fault
        {
          Monitor.Exit((object) abstractBoot1);
        }
      }
      // ISSUE: fault handler
      try
      {
        if (this.isBootDone())
        {
          Monitor.Exit((object) abstractBoot1);
          return;
        }
        else
        {
          this.bootInProgress = true;
          Monitor.Exit((object) abstractBoot1);
        }
      }
      __fault
      {
        Monitor.Exit((object) abstractBoot1);
      }
      BootableProjectInfo projectInfo = this.getProjectInfo();
      if (projectInfo != null)
      {
        foreach (BootableProjectInfo bootableProjectInfo in projectInfo.getDependencies())
        {
          AbstractBoot abstractBoot2 = this.loadBooter(bootableProjectInfo.getBootClass());
          if (abstractBoot2 != null)
          {
            AbstractBoot abstractBoot3;
            Monitor.Enter((object) (abstractBoot3 = abstractBoot2));
            // ISSUE: fault handler
            try
            {
              abstractBoot2.start();
            }
            __fault
            {
              Monitor.Exit((object) abstractBoot3);
            }
            while (true)
            {
              // ISSUE: fault handler
              try
              {
                if (!abstractBoot2.isBootDone())
                {
                  try
                  {
                    Object.instancehelper_wait((object) abstractBoot2);
                  }
                  catch (InterruptedException ex)
                  {
                  }
                }
                else
                  break;
              }
              __fault
              {
                Monitor.Exit((object) abstractBoot3);
              }
            }
            // ISSUE: fault handler
            try
            {
              Monitor.Exit((object) abstractBoot3);
            }
            __fault
            {
              Monitor.Exit((object) abstractBoot3);
            }
          }
        }
      }
      this.performBoot();
      if (projectInfo != null)
        Log.info((object) new StringBuffer().append(projectInfo.getName()).append(" ").append(projectInfo.getVersion()).append(" started.").toString());
      else
        Log.info((object) new StringBuffer().append((object) Object.instancehelper_getClass((object) this)).append(" started.").toString());
      lock (this)
      {
        this.bootInProgress = false;
        this.bootDone = true;
        Object.instancehelper_notifyAll((object) this);
      }
    }

    protected internal abstract void performBoot();

    [LineNumberTable((ushort) 270)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, AbstractBoot.__\u003CGetCallerID\u003E());
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

    [LineNumberTable(new byte[] {(byte) 159, (byte) 71, (byte) 162, (byte) 166, (byte) 99, (byte) 134, (byte) 109, (byte) 103, (byte) 177, (byte) 134, (byte) 109, (byte) 170, (byte) 162, (byte) 147, (byte) 126, (byte) 105, (byte) 142, (byte) 135, (byte) 105, (byte) 105, (byte) 103, (byte) 218, (byte) 31, (byte) 4, (byte) 98, (byte) 159, (byte) 23, (byte) 133, (byte) 112, (byte) 144, (byte) 232, (byte) 61, (byte) 250, (byte) 72, (byte) 2, (byte) 98, (byte) 172, (byte) 99, (byte) 135, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Configuration createDefaultHierarchicalConfiguration(string staticConfig, string userConfig, bool addSysProps, Class source)
    {
      int num1 = addSysProps ? 1 : 0;
      HierarchicalConfiguration hierarchicalConfiguration = new HierarchicalConfiguration();
      if (staticConfig != null)
      {
        PropertyFileConfiguration fileConfiguration = new PropertyFileConfiguration();
        fileConfiguration.load(staticConfig, Object.instancehelper_getClass((object) this));
        hierarchicalConfiguration.insertConfiguration((HierarchicalConfiguration) fileConfiguration);
        hierarchicalConfiguration.insertConfiguration((HierarchicalConfiguration) this.getPackageManager().getPackageConfiguration());
      }
      if (userConfig != null)
      {
        string str = !String.instancehelper_startsWith(userConfig, "/") ? userConfig : String.instancehelper_substring(userConfig, 1);
        Enumeration resources;
        ArrayList arrayList;
        IOException ioException1;
        try
        {
          resources = ObjectUtilities.getClassLoader(Object.instancehelper_getClass((object) this)).getResources(str);
          arrayList = new ArrayList();
          goto label_7;
        }
        catch (IOException ex)
        {
          int num2 = 1;
          ioException1 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num2);
        }
        IOException ioException2 = ioException1;
        goto label_22;
label_7:
        IOException ioException3;
        IOException ioException4;
        while (true)
        {
          URL url;
          IOException ioException5;
          try
          {
            if (resources.hasMoreElements())
            {
              url = (URL) resources.nextElement();
              try
              {
                PropertyFileConfiguration fileConfiguration = new PropertyFileConfiguration();
                InputStream @in = url.openStream();
                fileConfiguration.load(@in);
                @in.close();
                arrayList.add((object) fileConfiguration);
                continue;
              }
              catch (IOException ex)
              {
                int num2 = 1;
                ioException5 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num2);
              }
            }
            else
              goto label_17;
          }
          catch (IOException ex)
          {
            int num2 = 1;
            ioException3 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num2);
            break;
          }
          IOException ioException6 = ioException5;
          try
          {
            IOException ioException7 = ioException6;
            Log.warn((object) new StringBuffer().append("Failed to load the user configuration at ").append((object) url).toString(), (Exception) ioException7);
          }
          catch (IOException ex)
          {
            int num2 = 1;
            ioException4 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num2);
            goto label_16;
          }
        }
        ioException2 = ioException3;
        goto label_22;
label_16:
        ioException2 = ioException4;
        goto label_22;
label_17:
        IOException ioException8;
        try
        {
          int num2 = arrayList.size() - 1;
          while (num2 >= 0)
          {
            PropertyFileConfiguration fileConfiguration = (PropertyFileConfiguration) arrayList.get(num2);
            hierarchicalConfiguration.insertConfiguration((HierarchicalConfiguration) fileConfiguration);
            num2 += -1;
          }
          goto label_23;
        }
        catch (IOException ex)
        {
          int num2 = 1;
          ioException8 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num2);
        }
        ioException2 = ioException8;
label_22:
        Log.warn((object) "Failed to lookup the user configurations.", (Exception) ioException2);
      }
label_23:
      if (num1 != 0)
      {
        SystemPropertyConfiguration propertyConfiguration = new SystemPropertyConfiguration();
        hierarchicalConfiguration.insertConfiguration((HierarchicalConfiguration) propertyConfiguration);
      }
      return (Configuration) hierarchicalConfiguration;
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 104, (byte) 140})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual PackageManager getPackageManager()
    {
      if (this.packageManager == null)
        this.packageManager = PackageManager.createInstance(this);
      return this.packageManager;
    }

    [LineNumberTable(new byte[] {(byte) 70, (byte) 104, (byte) 140})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual Configuration getGlobalConfig()
    {
      if (this.globalConfig == null)
        this.globalConfig = this.loadConfiguration();
      return this.globalConfig;
    }

    [LineNumberTable((ushort) 269)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Configuration createDefaultHierarchicalConfiguration(string staticConfig, string userConfig, bool addSysProps)
    {
      int num = addSysProps ? 1 : 0;
      return this.createDefaultHierarchicalConfiguration(staticConfig, userConfig, num != 0, AbstractBoot.class\u0024org\u0024jfree\u0024base\u0024config\u0024PropertyFileConfiguration != null ? AbstractBoot.class\u0024org\u0024jfree\u0024base\u0024config\u0024PropertyFileConfiguration : (AbstractBoot.class\u0024org\u0024jfree\u0024base\u0024config\u0024PropertyFileConfiguration = AbstractBoot.class\u0024("org.jfree.base.config.PropertyFileConfiguration")));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 236, (byte) 104, (byte) 145})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual ExtendedConfiguration getExtendedConfig()
    {
      if (this.extWrapper == null)
        this.extWrapper = new ExtendedConfigurationWrapper(this.getGlobalConfig());
      return (ExtendedConfiguration) this.extWrapper;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (AbstractBoot.__\u003CcallerID\u003E == null)
        AbstractBoot.__\u003CcallerID\u003E = (CallerID) new AbstractBoot.__\u003CCallerID\u003E();
      return AbstractBoot.__\u003CcallerID\u003E;
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
