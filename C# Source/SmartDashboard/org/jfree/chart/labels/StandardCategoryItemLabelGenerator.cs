// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.StandardCategoryItemLabelGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using org.jfree.data.category;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"org.jfree.chart.labels.CategoryItemLabelGenerator", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class StandardCategoryItemLabelGenerator : AbstractCategoryItemLabelGenerator, CategoryItemLabelGenerator, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = 3499701401211412882L;
    public const string DEFAULT_LABEL_FORMAT_STRING = "{2}";

    [LineNumberTable(new byte[] {(byte) 22, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardCategoryItemLabelGenerator()
      : base("{2}", NumberFormat.getInstance())
    {
    }

    [LineNumberTable(new byte[] {(byte) 34, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardCategoryItemLabelGenerator(string labelFormat, NumberFormat formatter)
      : base(labelFormat, formatter)
    {
    }

    [LineNumberTable(new byte[] {(byte) 50, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardCategoryItemLabelGenerator(string labelFormat, NumberFormat formatter, NumberFormat percentFormatter)
      : base(labelFormat, formatter, percentFormatter)
    {
    }

    [LineNumberTable(new byte[] {(byte) 62, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public StandardCategoryItemLabelGenerator(string labelFormat, DateFormat formatter)
      : base(labelFormat, formatter)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected StandardCategoryItemLabelGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] StandardCategoryItemLabelGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] StandardCategoryItemLabelGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable((ushort) 127)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string generateLabel(CategoryDataset dataset, int row, int column)
    {
      return this.generateLabelString(dataset, row, column);
    }

    [LineNumberTable(new byte[] {(byte) 89, (byte) 100, (byte) 130, (byte) 104, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is StandardCategoryItemLabelGenerator))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }
  }
}
