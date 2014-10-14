// Decompiled with JetBrains decompiler
// Type: org.jfree.base.Library
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.@base;
using System.Runtime.CompilerServices;

namespace org.jfree.@base
{
  public class Library : Object
  {
    private string name;
    private string version;
    private string licenceName;
    private string info;

    [LineNumberTable(new byte[] {(byte) 28, (byte) 136, (byte) 103, (byte) 103, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Library(string name, string version, string licence, string info)
    {
      base.\u002Ector();
      Library library = this;
      this.name = name;
      this.version = version;
      this.licenceName = licence;
      this.info = info;
    }

    [LineNumberTable(new byte[] {(byte) 39, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Library()
    {
      base.\u002Ector();
    }

    public virtual string getName()
    {
      return this.name;
    }

    public virtual string getVersion()
    {
      return this.version;
    }

    public virtual string getLicenceName()
    {
      return this.licenceName;
    }

    public virtual string getInfo()
    {
      return this.info;
    }

    protected internal virtual void setInfo(string info)
    {
      this.info = info;
    }

    protected internal virtual void setLicenceName(string licenceName)
    {
      this.licenceName = licenceName;
    }

    protected internal virtual void setName(string name)
    {
      this.name = name;
    }

    protected internal virtual void setVersion(string version)
    {
      this.version = version;
    }

    [LineNumberTable(new byte[] {(byte) 124, (byte) 132, (byte) 130, (byte) 145, (byte) 162, (byte) 135, (byte) 159, (byte) 6, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object o)
    {
      if (this == o)
        return true;
      if (o == null || ((object) this).GetType() != o.GetType())
        return false;
      Library library = (Library) o;
      if (this.name != null)
      {
        if (String.instancehelper_equals(this.name, (object) library.name))
          goto label_8;
      }
      else if (library.name == null)
        goto label_8;
      return false;
label_8:
      return true;
    }

    [LineNumberTable((ushort) 200)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      if (this.name != null)
        return String.instancehelper_hashCode(this.name);
      else
        return 0;
    }
  }
}
