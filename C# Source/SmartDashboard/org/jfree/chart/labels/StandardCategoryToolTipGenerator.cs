// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.StandardCategoryToolTipGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.text;
using org.jfree.data.category;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"org.jfree.chart.labels.CategoryToolTipGenerator", "java.io.Serializable"})]
  [Serializable]
  public class StandardCategoryToolTipGenerator : AbstractCategoryItemLabelGenerator, CategoryToolTipGenerator, Serializable.__Interface
  {
    private const long serialVersionUID = -6768806592218710764L;
    public const string DEFAULT_TOOL_TIP_FORMAT_STRING = "({0}, {1}) = {2}";

    [LineNumberTable(new byte[] {(byte) 20, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardCategoryToolTipGenerator()
      : base("({0}, {1}) = {2}", NumberFormat.getInstance())
    {
    }

    [LineNumberTable(new byte[] {(byte) 32, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardCategoryToolTipGenerator(string labelFormat, NumberFormat formatter)
      : base(labelFormat, formatter)
    {
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardCategoryToolTipGenerator(string labelFormat, DateFormat formatter)
      : base(labelFormat, formatter)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardCategoryToolTipGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardCategoryToolTipGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 110)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateToolTip(CategoryDataset dataset, int row, int column)
    {
      return this.generateLabelString(dataset, row, column);
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 100, (byte) 130, (byte) 104, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StandardCategoryToolTipGenerator))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }
  }
}
