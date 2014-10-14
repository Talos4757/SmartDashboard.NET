// Decompiled with JetBrains decompiler
// Type: org.jfree.data.xy.AbstractIntervalXYDataset
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
  [Implements(new string[] {"org.jfree.data.xy.IntervalXYDataset"})]
  [Serializable]
  public abstract class AbstractIntervalXYDataset : AbstractXYDataset, IntervalXYDataset, XYDataset, SeriesDataset, Dataset
  {
    [LineNumberTable((ushort) 51)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AbstractIntervalXYDataset()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractIntervalXYDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromReflection]
    public abstract Number getStartX([In] int obj0, [In] int obj1);

    [HideFromReflection]
    public abstract Number getEndX([In] int obj0, [In] int obj1);

    [HideFromReflection]
    public abstract Number getStartY([In] int obj0, [In] int obj1);

    [HideFromReflection]
    public abstract Number getEndY([In] int obj0, [In] int obj1);

    [LineNumberTable(new byte[] {(byte) 14, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getStartXValue(int series, int item)
    {
      double num = double.NaN;
      Number startX = this.getStartX(series, item);
      if (startX != null)
        num = startX.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getEndXValue(int series, int item)
    {
      double num = double.NaN;
      Number endX = this.getEndX(series, item);
      if (endX != null)
        num = endX.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 50, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getStartYValue(int series, int item)
    {
      double num = double.NaN;
      Number startY = this.getStartY(series, item);
      if (startY != null)
        num = startY.doubleValue();
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 68, (byte) 106, (byte) 105, (byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual double getEndYValue(int series, int item)
    {
      double num = double.NaN;
      Number endY = this.getEndY(series, item);
      if (endY != null)
        num = endY.doubleValue();
      return num;
    }
  }
}
