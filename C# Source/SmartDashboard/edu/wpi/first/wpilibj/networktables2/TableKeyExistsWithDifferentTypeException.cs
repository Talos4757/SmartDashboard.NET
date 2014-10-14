﻿// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.wpilibj.networktables2.TableKeyExistsWithDifferentTypeException
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.wpilibj.networktables2.type;
using IKVM.Attributes;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.wpilibj.networktables2
{
  [SourceFile(null)]
  [Serializable]
  public class TableKeyExistsWithDifferentTypeException : RuntimeException
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TableKeyExistsWithDifferentTypeException(string str, NetworkTableEntryType ntet)
      : this(str, ntet, "")
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TableKeyExistsWithDifferentTypeException(string str1, NetworkTableEntryType ntet, string str2)
    {
      base.\u002Ector(new StringBuilder().append("Illegal put - key '").append(str1).append("' exists with type '").append((object) ntet).append("'. ").append(str2).toString());
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected TableKeyExistsWithDifferentTypeException([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }
  }
}
