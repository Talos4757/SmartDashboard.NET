// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.about.ProjectInfo
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using java.util;
using org.jfree.@base;
using System.Runtime.CompilerServices;

namespace org.jfree.ui.about
{
  public class ProjectInfo : BootableProjectInfo
  {
    private Image logo;
    private string licenceText;
    private List contributors;

    [LineNumberTable(new byte[] {(byte) 22, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectInfo()
    {
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 111, (byte) 104, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectInfo(string name, string version, string info, Image logo, string copyright, string licenceName, string licenceText)
      : base(name, version, info, copyright, licenceName)
    {
      ProjectInfo projectInfo = this;
      this.logo = logo;
      this.licenceText = licenceText;
    }

    [LineNumberTable(new byte[] {(byte) 112, (byte) 102, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 109, (byte) 108, (byte) 108, (byte) 107, (byte) 108, (byte) 104, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 98, (byte) 130, (byte) 172, (byte) 108, (byte) 108, (byte) 109, (byte) 108, (byte) 103, (byte) 103, (byte) 108, (byte) 102, (byte) 110, (byte) 108, (byte) 110, (byte) 108, (byte) 110, (byte) 236, (byte) 57, (byte) 237, (byte) 75, (byte) 140, (byte) 108, (byte) 109, (byte) 108, (byte) 108, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      StringBuffer stringBuffer = new StringBuffer();
      stringBuffer.append(this.getName());
      stringBuffer.append(" version ");
      stringBuffer.append(this.getVersion());
      stringBuffer.append(".\n");
      stringBuffer.append(this.getCopyright());
      stringBuffer.append(".\n");
      stringBuffer.append("\n");
      stringBuffer.append("For terms of use, see the licence below.\n");
      stringBuffer.append("\n");
      stringBuffer.append("FURTHER INFORMATION:");
      stringBuffer.append(this.getInfo());
      stringBuffer.append("\n");
      stringBuffer.append("CONTRIBUTORS:");
      if (this.contributors != null)
      {
        Iterator iterator = this.contributors.iterator();
        while (iterator.hasNext())
        {
          Contributor contributor = (Contributor) iterator.next();
          stringBuffer.append(contributor.getName());
          stringBuffer.append(" (");
          stringBuffer.append(contributor.getEmail());
          stringBuffer.append(").");
        }
      }
      else
        stringBuffer.append("None");
      stringBuffer.append("\n");
      stringBuffer.append("OTHER LIBRARIES USED BY ");
      stringBuffer.append(this.getName());
      stringBuffer.append(":");
      Library[] libraries = this.getLibraries();
      if (libraries.Length != 0)
      {
        for (int index = 0; index < libraries.Length; ++index)
        {
          Library library = libraries[index];
          stringBuffer.append(library.getName());
          stringBuffer.append(" ");
          stringBuffer.append(library.getVersion());
          stringBuffer.append(" (");
          stringBuffer.append(library.getInfo());
          stringBuffer.append(").");
        }
      }
      else
        stringBuffer.append("None");
      stringBuffer.append("\n");
      stringBuffer.append(this.getName());
      stringBuffer.append(" LICENCE TERMS:");
      stringBuffer.append("\n");
      stringBuffer.append(this.getLicenceText());
      return stringBuffer.toString();
    }

    public virtual string getLicenceText()
    {
      return this.licenceText;
    }

    public virtual Image getLogo()
    {
      return this.logo;
    }

    public virtual void setLogo(Image logo)
    {
      this.logo = logo;
    }

    public virtual void setLicenceText(string licenceText)
    {
      this.licenceText = licenceText;
    }

    public virtual List getContributors()
    {
      return this.contributors;
    }

    public virtual void setContributors(List contributors)
    {
      this.contributors = contributors;
    }
  }
}
