﻿// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.types.named.PIDCommandType
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.types;
using IKVM.Attributes;
using System.Runtime.CompilerServices;

namespace edu.wpi.first.smartdashboard.types.named
{
  public class PIDCommandType : NamedDataType
  {
    public const string LABEL = "PIDCommand";

    [HideFromJava]
    static PIDCommandType()
    {
      NamedDataType.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 156, (byte) 127, (byte) 4})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private PIDCommandType()
    {
      string name = "PIDCommand";
      DataType[] dataTypeArray = new DataType[2];
      int index1 = 0;
      NamedDataType namedDataType1 = CommandType.get();
      dataTypeArray[index1] = (DataType) namedDataType1;
      int index2 = 1;
      NamedDataType namedDataType2 = PIDType.get();
      dataTypeArray[index2] = (DataType) namedDataType2;
      // ISSUE: explicit constructor call
      base.\u002Ector(name, dataTypeArray);
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
      if (NamedDataType.get("PIDCommand") != null)
        return NamedDataType.get("PIDCommand");
      else
        return (NamedDataType) new PIDCommandType();
    }
  }
}
