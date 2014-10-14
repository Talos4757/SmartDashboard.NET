// Decompiled with JetBrains decompiler
// Type: org.jfree.base.BootableProjectInfo
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.@base;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.@base
{
  public class BootableProjectInfo : BasicProjectInfo
  {
    private string bootClass;
    private bool autoBoot;

    [LineNumberTable(new byte[] {(byte) 14, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BootableProjectInfo()
    {
      BootableProjectInfo bootableProjectInfo = this;
      this.autoBoot = true;
    }

    [LineNumberTable(new byte[] {(byte) 28, (byte) 104, (byte) 103, (byte) 103, (byte) 103, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BootableProjectInfo(string name, string version, string licence, string info)
      : this()
    {
      BootableProjectInfo bootableProjectInfo = this;
      this.setName(name);
      this.setVersion(version);
      this.setLicenceName(licence);
      this.setInfo(info);
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 104, (byte) 103, (byte) 103, (byte) 104, (byte) 103, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BootableProjectInfo(string name, string version, string info, string copyright, string licenceName)
      : this()
    {
      BootableProjectInfo bootableProjectInfo = this;
      this.setName(name);
      this.setVersion(version);
      this.setLicenceName(licenceName);
      this.setInfo(info);
      this.setCopyright(copyright);
    }

    [LineNumberTable(new byte[] {(byte) 60, (byte) 102, (byte) 103, (byte) 103, (byte) 100, (byte) 104, (byte) 232, (byte) 61, (byte) 230, (byte) 71, (byte) 104, (byte) 106, (byte) 103, (byte) 105, (byte) 233, (byte) 61, (byte) 232, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual BootableProjectInfo[] getDependencies()
    {
      ArrayList arrayList = new ArrayList();
      foreach (Library library in this.getLibraries())
      {
        if (library is BootableProjectInfo)
          arrayList.add((object) library);
      }
      foreach (Library library in this.getOptionalLibraries())
      {
        if (library is BootableProjectInfo)
          arrayList.add((object) library);
      }
      return (BootableProjectInfo[]) arrayList.toArray((object[]) new BootableProjectInfo[arrayList.size()]);
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 87, (byte) 99, (byte) 139, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addDependency(BootableProjectInfo projectInfo)
    {
      if (projectInfo == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else
        this.addLibrary((Library) projectInfo);
    }

    public virtual string getBootClass()
    {
      return this.bootClass;
    }

    public virtual void setBootClass(string bootClass)
    {
      this.bootClass = bootClass;
    }

    public virtual bool isAutoBoot()
    {
      return this.autoBoot;
    }

    public virtual void setAutoBoot(bool autoBoot)
    {
      this.autoBoot = autoBoot;
    }
  }
}
