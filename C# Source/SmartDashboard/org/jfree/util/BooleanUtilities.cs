// Decompiled with JetBrains decompiler
// Type: org.jfree.util.BooleanUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.util
{
  public class BooleanUtilities : Object
  {
    [LineNumberTable(new byte[] {(byte) 6, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private BooleanUtilities()
    {
      base.\u002Ector();
    }

    [LineNumberTable((ushort) 70)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Boolean valueOf(bool b)
    {
      if (b)
        return (Boolean) Boolean.TRUE;
      else
        return (Boolean) Boolean.FALSE;
    }
  }
}
