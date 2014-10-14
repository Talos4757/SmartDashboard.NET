// Decompiled with JetBrains decompiler
// Type: junit.runner.Version
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace junit.runner
{
  public class Version : Object
  {
    [LineNumberTable(new byte[] {(byte) 159, (byte) 149, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Version()
    {
      base.\u002Ector();
    }

    public static string id()
    {
      return "4.8.2";
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 158, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void main(string[] args)
    {
      System.get_out().println(Version.id());
    }
  }
}
