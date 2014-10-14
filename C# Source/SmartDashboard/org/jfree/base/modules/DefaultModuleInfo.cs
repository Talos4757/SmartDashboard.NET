// Decompiled with JetBrains decompiler
// Type: org.jfree.base.modules.DefaultModuleInfo
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.@base.modules;
using System.Runtime.CompilerServices;

namespace org.jfree.@base.modules
{
  [Implements(new string[] {"org.jfree.base.modules.ModuleInfo"})]
  public class DefaultModuleInfo : Object, ModuleInfo
  {
    private string moduleClass;
    private string majorVersion;
    private string minorVersion;
    private string patchLevel;

    [LineNumberTable(new byte[] {(byte) 15, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultModuleInfo()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 31, (byte) 104, (byte) 131, (byte) 144, (byte) 103, (byte) 103, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultModuleInfo(string moduleClass, string majorVersion, string minorVersion, string patchLevel)
    {
      base.\u002Ector();
      DefaultModuleInfo defaultModuleInfo = this;
      if (moduleClass == null)
      {
        string str = "Module class must not be null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        this.moduleClass = moduleClass;
        this.majorVersion = majorVersion;
        this.minorVersion = minorVersion;
        this.patchLevel = patchLevel;
      }
    }

    public virtual string getModuleClass()
    {
      return this.moduleClass;
    }

    public virtual string getMajorVersion()
    {
      return this.majorVersion;
    }

    public virtual string getMinorVersion()
    {
      return this.minorVersion;
    }

    public virtual string getPatchLevel()
    {
      return this.patchLevel;
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 131, (byte) 139, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setModuleClass(string moduleClass)
    {
      if (moduleClass == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else
        this.moduleClass = moduleClass;
    }

    public virtual void setMajorVersion(string majorVersion)
    {
      this.majorVersion = majorVersion;
    }

    public virtual void setMinorVersion(string minorVersion)
    {
      this.minorVersion = minorVersion;
    }

    public virtual void setPatchLevel(string patchLevel)
    {
      this.patchLevel = patchLevel;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 132, (byte) 130, (byte) 136, (byte) 162, (byte) 135, (byte) 147, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      return this == o || o is DefaultModuleInfo && String.instancehelper_equals(this.moduleClass, (object) ((ModuleInfo) o).getModuleClass());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 111, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return String.instancehelper_hashCode(this.moduleClass);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 124, (byte) 102, (byte) 114, (byte) 108, (byte) 109, (byte) 136, (byte) 108, (byte) 109, (byte) 136, (byte) 108, (byte) 109, (byte) 136, (byte) 108, (byte) 205, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      StringBuffer stringBuffer = new StringBuffer();
      stringBuffer.append(Object.instancehelper_getClass((object) this).getName());
      stringBuffer.append("={ModuleClass=");
      stringBuffer.append(this.getModuleClass());
      if (this.getMajorVersion() != null)
      {
        stringBuffer.append("; Version=");
        stringBuffer.append(this.getMajorVersion());
        if (this.getMinorVersion() != null)
        {
          stringBuffer.append("-");
          stringBuffer.append(this.getMinorVersion());
          if (this.getPatchLevel() != null)
          {
            stringBuffer.append("_");
            stringBuffer.append(this.getPatchLevel());
          }
        }
      }
      stringBuffer.append("}");
      return stringBuffer.toString();
    }
  }
}
