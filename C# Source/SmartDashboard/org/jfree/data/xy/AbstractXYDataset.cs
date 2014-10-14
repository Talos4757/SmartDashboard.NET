// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.AbstractXYDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using org.jfree.data;
using org.jfree.data.general;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.xy
{
  [Implements(new string[] {"org.jfree.data.xy.XYDataset"})]
  [Serializable]
  public abstract class AbstractXYDataset : AbstractSeriesDataset, XYDataset, SeriesDataset, Dataset
  {
    [LineNumberTable((ushort) 53)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AbstractXYDataset()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractXYDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromReflection]
    public abstract Number getX([In] int obj0, [In] int obj1);

    [HideFromReflection]
    public abstract Number getY([In] int obj0, [In] int obj1);

    [LineNumberTable((ushort) 62)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DomainOrder getDomainOrder()
    {
      return DomainOrder.__\u003C\u003ENONE;
    }

    [LineNumberTable(new byte[] {(byte) 24, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getXValue(int series, int item)
    {
      double num = double.NaN;
      Number x = this.getX(series, item);
      if (x != null)
        num = x.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 41, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getYValue(int series, int item)
    {
      double num = double.NaN;
      Number y = this.getY(series, item);
      if (y != null)
        num = y.doubleValue();
      return num;
    }

    [HideFromReflection]
    public abstract int getItemCount([In] int obj0);
  }
}
