﻿// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.AbstractXYZDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data.general;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"org.jfree.data.xy.XYZDataset"})]
  [Serializable]
  public abstract class AbstractXYZDataset : AbstractXYDataset, XYZDataset, XYDataset, SeriesDataset, Dataset
  {
    [LineNumberTable((ushort) 48)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AbstractXYZDataset()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractXYZDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromReflection]
    public abstract Number getZ([In] int obj0, [In] int obj1);

    [LineNumberTable(new byte[] {(byte) 10, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getZValue(int series, int item)
    {
      double num = double.NaN;
      Number z = this.getZ(series, item);
      if (z != null)
        num = z.doubleValue();
      return num;
    }
  }
}
