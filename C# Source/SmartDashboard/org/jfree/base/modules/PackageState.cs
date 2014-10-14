// Decompiled with JetBrains decompiler
// Type: org.jfree.base.modules.PackageState
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using org.jfree.@base.modules;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.@base.modules
{
  public class PackageState : Object
  {
    public const int STATE_NEW = 0;
    public const int STATE_CONFIGURED = 1;
    public const int STATE_INITIALIZED = 2;
    public const int STATE_ERROR = -2;
    [Modifiers]
    private Module module;
    private int state;

    [LineNumberTable(new byte[] {(byte) 31, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PackageState(Module module)
      : this(module, 0)
    {
    }

    [LineNumberTable(new byte[] {(byte) 42, (byte) 104, (byte) 131, (byte) 144, (byte) 176, (byte) 144, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PackageState(Module module, int state)
    {
      base.\u002Ector();
      PackageState packageState = this;
      if (module == null)
      {
        string str = "Module must not be null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else if (state != 1 && state != -2 && (state != 2 && state != 0))
      {
        string str = "State is not valid";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.module = module;
        this.state = state;
      }
    }

    public virtual Module getModule()
    {
      return this.module;
    }

    public virtual int getState()
    {
      return this.state;
    }

    [LineNumberTable(new byte[] {(byte) 66, (byte) 203, (byte) 108, (byte) 103, (byte) 159, (byte) 14, (byte) 129, (byte) 159, (byte) 6, (byte) 232, (byte) 78, (byte) 226, (byte) 52, (byte) 130, (byte) 167, (byte) 159, (byte) 14, (byte) 135, (byte) 159, (byte) 10, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool configure(SubSystem subSystem)
    {
      if (this.state == 0)
      {
        int num1;
        NoClassDefFoundError classDefFoundError;
        Exception exception;
        try
        {
          try
          {
            this.module.configure(subSystem);
            this.state = 1;
            num1 = 1;
          }
          catch (Exception ex)
          {
            int num2 = 0;
            M0 m0 = ByteCodeHelper.MapException<NoClassDefFoundError>(ex, (ByteCodeHelper.MapFlags) num2);
            if (m0 == null)
            {
              throw;
            }
            else
            {
              classDefFoundError = (NoClassDefFoundError) m0;
              goto label_9;
            }
          }
        }
        catch (Exception ex)
        {
          int num2 = 0;
          M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2);
          if (m0 == null)
          {
            throw;
          }
          else
          {
            exception = (Exception) m0;
            goto label_10;
          }
        }
        return num1 != 0;
label_9:
        Log.warn((object) new Log.SimpleMessage("Unable to load module classes for ", (object) this.module.getName(), (object) ":", (object) Throwable.instancehelper_getMessage((Exception) classDefFoundError)));
        this.state = -2;
        goto label_15;
label_10:
        Exception e = exception;
        if (Log.isDebugEnabled())
          Log.warn((object) new StringBuffer().append("Unable to configure the module ").append(this.module.getName()).toString(), e);
        else if (Log.isWarningEnabled())
          Log.warn((object) new StringBuffer().append("Unable to configure the module ").append(this.module.getName()).toString());
        this.state = -2;
      }
label_15:
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 66, (byte) 204, (byte) 108, (byte) 103, (byte) 159, (byte) 29, (byte) 130, (byte) 159, (byte) 7, (byte) 232, (byte) 91, (byte) 229, (byte) 39, (byte) 130, (byte) 167, (byte) 159, (byte) 14, (byte) 135, (byte) 159, (byte) 10, (byte) 232, (byte) 78, (byte) 226, (byte) 52, (byte) 130, (byte) 167, (byte) 159, (byte) 14, (byte) 135, (byte) 159, (byte) 10, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool initialize(SubSystem subSystem)
    {
      if (this.state == 1)
      {
        int num1;
        NoClassDefFoundError classDefFoundError;
        ModuleInitializeException initializeException1;
        Exception exception;
        try
        {
          try
          {
            try
            {
              this.module.initialize(subSystem);
              this.state = 2;
              num1 = 1;
            }
            catch (Exception ex)
            {
              int num2 = 0;
              M0 m0 = ByteCodeHelper.MapException<NoClassDefFoundError>(ex, (ByteCodeHelper.MapFlags) num2);
              if (m0 == null)
              {
                throw;
              }
              else
              {
                classDefFoundError = (NoClassDefFoundError) m0;
                goto label_10;
              }
            }
          }
          catch (ModuleInitializeException ex)
          {
            int num2 = 1;
            initializeException1 = (ModuleInitializeException) ByteCodeHelper.MapException<ModuleInitializeException>((Exception) ex, (ByteCodeHelper.MapFlags) num2);
            goto label_11;
          }
        }
        catch (Exception ex)
        {
          int num2 = 0;
          M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2);
          if (m0 == null)
          {
            throw;
          }
          else
          {
            exception = (Exception) m0;
            goto label_12;
          }
        }
        return num1 != 0;
label_10:
        Log.warn((object) new Log.SimpleMessage("Unable to load module classes for ", (object) this.module.getName(), (object) ":", (object) Throwable.instancehelper_getMessage((Exception) classDefFoundError)));
        this.state = -2;
        goto label_21;
label_11:
        ModuleInitializeException initializeException2 = initializeException1;
        if (Log.isDebugEnabled())
          Log.warn((object) new StringBuffer().append("Unable to initialize the module ").append(this.module.getName()).toString(), (Exception) initializeException2);
        else if (Log.isWarningEnabled())
          Log.warn((object) new StringBuffer().append("Unable to initialize the module ").append(this.module.getName()).toString());
        this.state = -2;
        goto label_21;
label_12:
        Exception e = exception;
        if (Log.isDebugEnabled())
          Log.warn((object) new StringBuffer().append("Unable to initialize the module ").append(this.module.getName()).toString(), e);
        else if (Log.isWarningEnabled())
          Log.warn((object) new StringBuffer().append("Unable to initialize the module ").append(this.module.getName()).toString());
        this.state = -2;
      }
label_21:
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 120, (byte) 132, (byte) 130, (byte) 136, (byte) 162, (byte) 135, (byte) 157, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      return this == o || o is PackageState && String.instancehelper_equals(this.module.getModuleClass(), (object) ((PackageState) o).module.getModuleClass());
    }

    [LineNumberTable((ushort) 261)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return Object.instancehelper_hashCode((object) this.module);
    }
  }
}
