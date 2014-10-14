// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.about.Contributor
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.ui.about
{
  public class Contributor : Object
  {
    private string name;
    private string email;

    [LineNumberTable(new byte[] {(byte) 18, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Contributor(string name, string email)
    {
      base.\u002Ector();
      Contributor contributor = this;
      this.name = name;
      this.email = email;
    }

    public virtual string getName()
    {
      return this.name;
    }

    public virtual string getEmail()
    {
      return this.email;
    }
  }
}
