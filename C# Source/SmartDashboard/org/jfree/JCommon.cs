// Decompiled with JetBrains decompiler
// Type: org.jfree.JCommon
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.ui.about;
using System.Runtime.CompilerServices;

namespace org.jfree
{
  public sealed class JCommon : Object
  {
    internal static ProjectInfo __\u003C\u003EINFO = (ProjectInfo) JCommonInfo.getInstance();

    [Modifiers]
    public static ProjectInfo INFO
    {
      [HideFromJava] get
      {
        return JCommon.__\u003C\u003EINFO;
      }
    }

    [LineNumberTable((ushort) 63)]
    static JCommon()
    {
    }

    [LineNumberTable(new byte[] {(byte) 19, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private JCommon()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 28, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void main(string[] args)
    {
      System.get_out().println(JCommon.__\u003C\u003EINFO.toString());
    }
  }
}
