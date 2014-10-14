// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.IntervalCategoryItemLabelGenerator
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
  [Implements(new string[] {"org.jfree.chart.labels.CategoryItemLabelGenerator", "org.jfree.util.PublicCloneable", "java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class IntervalCategoryItemLabelGenerator : StandardCategoryItemLabelGenerator, CategoryItemLabelGenerator, PublicCloneable, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = 5056909225610630529L;
    public new const string DEFAULT_LABEL_FORMAT_STRING = "({0}, {1}) = {3} - {4}";

    [LineNumberTable(new byte[] {(byte) 21, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntervalCategoryItemLabelGenerator()
      : base("({0}, {1}) = {3} - {4}", NumberFormat.getInstance())
    {
    }

    [LineNumberTable(new byte[] {(byte) 33, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntervalCategoryItemLabelGenerator(string labelFormat, NumberFormat formatter)
      : base(labelFormat, formatter)
    {
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntervalCategoryItemLabelGenerator(string labelFormat, DateFormat formatter)
      : base(labelFormat, formatter)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected IntervalCategoryItemLabelGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] IntervalCategoryItemLabelGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] IntervalCategoryItemLabelGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 60, (byte) 103, (byte) 111, (byte) 111, (byte) 105, (byte) 104, (byte) 145, (byte) 104, (byte) 175, (byte) 107, (byte) 103, (byte) 105, (byte) 106, (byte) 104, (byte) 111, (byte) 146, (byte) 104, (byte) 111, (byte) 176})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override object[] createItemArray(CategoryDataset dataset, int row, int column)
    {
      object[] objArray = new object[5];
      objArray[0] = (object) Object.instancehelper_toString((object) dataset.getRowKey(row));
      objArray[1] = (object) Object.instancehelper_toString((object) dataset.getColumnKey(column));
      Number number = dataset.getValue(row, column);
      if (this.getNumberFormat() != null)
        objArray[2] = (object) ((Format) this.getNumberFormat()).format((object) number);
      else if (this.getDateFormat() != null)
        objArray[2] = (object) ((Format) this.getDateFormat()).format((object) number);
      if (dataset is IntervalCategoryDataset)
      {
        IntervalCategoryDataset ntervalCategoryDataset = (IntervalCategoryDataset) dataset;
        Number startValue = ntervalCategoryDataset.getStartValue(row, column);
        Number endValue = ntervalCategoryDataset.getEndValue(row, column);
        if (this.getNumberFormat() != null)
        {
          objArray[3] = (object) ((Format) this.getNumberFormat()).format((object) startValue);
          objArray[4] = (object) ((Format) this.getNumberFormat()).format((object) endValue);
        }
        else if (this.getDateFormat() != null)
        {
          objArray[3] = (object) ((Format) this.getDateFormat()).format((object) startValue);
          objArray[4] = (object) ((Format) this.getDateFormat()).format((object) endValue);
        }
      }
      return objArray;
    }
  }
}
