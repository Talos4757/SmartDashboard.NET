// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.SymbolicXYItemLabelGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using org.jfree.data.time;
using org.jfree.data.xy;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"org.jfree.chart.labels.XYItemLabelGenerator", "org.jfree.chart.labels.XYToolTipGenerator", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class SymbolicXYItemLabelGenerator : Object, XYItemLabelGenerator, XYToolTipGenerator, Cloneable.__Interface, PublicCloneable, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 3963400354475494395L;

    [LineNumberTable((ushort) 65)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymbolicXYItemLabelGenerator()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SymbolicXYItemLabelGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] SymbolicXYItemLabelGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] SymbolicXYItemLabelGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 79, (byte) 100, (byte) 148, (byte) 114, (byte) 117})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double round([In] double obj0, [In] int obj1)
    {
      if (obj1 <= 0)
      {
        return Math.floor(obj0 + 0.5);
      }
      else
      {
        double num = Math.pow(10.0, (double) obj1);
        return Math.floor(obj0 * num + 0.5) / num;
      }
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 104, (byte) 176, (byte) 106, (byte) 141, (byte) 104, (byte) 144, (byte) 104, (byte) 179, (byte) 103, (byte) 130, (byte) 106, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateToolTip(XYDataset data, int series, int item)
    {
      string str = !(data is YisSymbolic) ? Double.toString(SymbolicXYItemLabelGenerator.round(data.getYValue(series, item), 2)) : ((YisSymbolic) data).getYSymbolicValue(series, item);
      return new StringBuffer().append("X: ").append(!(data is XisSymbolic) ? (!(data is TimeSeriesCollection) ? Double.toString(SymbolicXYItemLabelGenerator.round(data.getXValue(series, item), 2)) : ((TimeSeriesCollection) data).getSeries(series).getTimePeriod(item).toString()) : ((XisSymbolic) data).getXSymbolicValue(series, item)).append(", Y: ").append(str).toString();
    }

    public virtual string generateLabel(XYDataset dataset, int series, int category)
    {
      return (string) null;
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 145)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return base.clone();
    }

    [LineNumberTable(new byte[] {(byte) 106, (byte) 100, (byte) 130, (byte) 104, (byte) 130})]
    public virtual bool equals(object obj)
    {
      return obj == this || obj is SymbolicXYItemLabelGenerator;
    }

    public virtual int hashCode()
    {
      return (int) sbyte.MaxValue;
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
