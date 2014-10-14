// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.StandardXYItemLabelGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using org.jfree.data.xy;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"org.jfree.chart.labels.XYItemLabelGenerator", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class StandardXYItemLabelGenerator : AbstractXYItemLabelGenerator, XYItemLabelGenerator, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 7807668053171837925L;
    public const string DEFAULT_ITEM_LABEL_FORMAT = "{2}";

    [LineNumberTable(new byte[] {(byte) 55, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardXYItemLabelGenerator(string formatString, NumberFormat xFormat, NumberFormat yFormat)
      : base(formatString, xFormat, yFormat)
    {
    }

    [LineNumberTable(new byte[] {(byte) 37, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardXYItemLabelGenerator()
      : this("{2}", NumberFormat.getNumberInstance(), NumberFormat.getNumberInstance())
    {
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardXYItemLabelGenerator(string formatString, DateFormat xFormat, NumberFormat yFormat)
      : base(formatString, xFormat, yFormat)
    {
    }

    [LineNumberTable(new byte[] {(byte) 91, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardXYItemLabelGenerator(string formatString, NumberFormat xFormat, DateFormat yFormat)
      : base(formatString, xFormat, yFormat)
    {
    }

    [LineNumberTable(new byte[] {(byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardXYItemLabelGenerator(string formatString, DateFormat xFormat, DateFormat yFormat)
      : base(formatString, xFormat, yFormat)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardXYItemLabelGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StandardXYItemLabelGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardXYItemLabelGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 170)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateLabel(XYDataset dataset, int series, int item)
    {
      return this.generateLabelString(dataset, series, item);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable((ushort) 181)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object clone()
    {
      return base.clone();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 78, (byte) 100, (byte) 130, (byte) 104, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StandardXYItemLabelGenerator))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }
  }
}
