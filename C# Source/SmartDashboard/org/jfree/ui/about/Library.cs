// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.about.Library
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.jfree.@base;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.ui.about
{
  [Obsolete]
  public class Library : Library
  {
    [LineNumberTable(new byte[] {(byte) 13, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Library(string name, string version, string licence, string info)
      : base(name, version, licence, info)
    {
    }

    [LineNumberTable(new byte[] {(byte) 23, (byte) 159, (byte) 1})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Library(ProjectInfo project)
      : this(project.getName(), project.getVersion(), project.getLicenceName(), project.getInfo())
    {
    }
  }
}
