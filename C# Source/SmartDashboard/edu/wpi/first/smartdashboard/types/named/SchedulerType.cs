﻿// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.types.named.SchedulerType
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.types;
using IKVM.Attributes;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.types.named
{
  public class SchedulerType : NamedDataType
  {
    public const string LABEL = "Scheduler";

    [HideFromJava]
    static SchedulerType()
    {
      NamedDataType.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 156, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private SchedulerType()
      : base("Scheduler")
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 160, (byte) 108, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static NamedDataType get()
    {
      if (NamedDataType.get("Scheduler") != null)
        return NamedDataType.get("Scheduler");
      else
        return (NamedDataType) new SchedulerType();
    }
  }
}
