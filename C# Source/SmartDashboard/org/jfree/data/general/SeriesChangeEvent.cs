﻿// Decompiled with JetBrains decompiler
// Type: org.jfree.data.general.SeriesChangeEvent
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.general
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class SeriesChangeEvent : EventObject, Serializable.__Interface
  {
    private const long serialVersionUID = 1593866085210089052L;

    [LineNumberTable(new byte[] {(byte) 11, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SeriesChangeEvent(object source)
    {
      base.\u002Ector(source);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SeriesChangeEvent([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] SeriesChangeEvent obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }
  }
}
