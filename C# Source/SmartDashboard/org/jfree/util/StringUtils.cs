// Decompiled with JetBrains decompiler
// Type: org.jfree.util.StringUtils
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.util
{
  public class StringUtils : Object
  {
    [LineNumberTable(new byte[] {(byte) 5, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private StringUtils()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool endsWithIgnoreCase(string @base, string end)
    {
      if (String.instancehelper_length(@base) < String.instancehelper_length(end))
        return false;
      return (String.instancehelper_regionMatches(@base, true, String.instancehelper_length(@base) - String.instancehelper_length(end), end, 0, String.instancehelper_length(end)) ? 1 : 0) != 0;
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 159, (byte) 9, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string getLineSeparator()
    {
      string property;
      try
      {
        property = System.getProperty("line.separator", "\n");
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
        else
          goto label_4;
      }
      return property;
label_4:
      return "\n";
    }

    [LineNumberTable(new byte[] {(byte) 17, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool startsWithIgnoreCase(string @base, string start)
    {
      if (String.instancehelper_length(@base) < String.instancehelper_length(start))
        return false;
      return (String.instancehelper_regionMatches(@base, true, 0, start, 0, String.instancehelper_length(start)) ? 1 : 0) != 0;
    }
  }
}
