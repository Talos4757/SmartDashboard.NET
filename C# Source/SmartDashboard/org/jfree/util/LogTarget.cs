// Decompiled with JetBrains decompiler
// Type: org.jfree.util.LogTarget
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;

namespace org.jfree.util
{
  public interface LogTarget
  {
    const int ERROR = 0;
    const int WARN = 1;
    const int INFO = 2;
    const int DEBUG = 3;
    static readonly string[] LEVELS;

    [LineNumberTable((ushort) 75)]
    static LogTarget()
    {
      string[] strArray = new string[4];
      int index1 = 0;
      string str1 = "ERROR: ";
      strArray[index1] = str1;
      int index2 = 1;
      string str2 = "WARN:  ";
      strArray[index2] = str2;
      int index3 = 2;
      string str3 = "INFO:  ";
      strArray[index3] = str3;
      int index4 = 3;
      string str4 = "DEBUG: ";
      strArray[index4] = str4;
      LogTarget.LEVELS = strArray;
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    void __\u003Cclinit\u003E()
    {
    }

    void log(int i, object obj);

    void log(int i, object obj, Exception e);

    [HideFromJava]
    static class __Fields
    {
      public static readonly string[] LEVELS = LogTarget.LEVELS;
      public const int ERROR = 0;
      public const int WARN = 1;
      public const int INFO = 2;
      public const int DEBUG = 3;
    }
  }
}
