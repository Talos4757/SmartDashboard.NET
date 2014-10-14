// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.BoxAndWhiskerToolTipGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using org.jfree.data.category;
using org.jfree.data.statistics;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"org.jfree.chart.labels.CategoryToolTipGenerator", "java.lang.Cloneable", "org.jfree.util.PublicCloneable", "java.io.Serializable"})]
  [Serializable]
  public class BoxAndWhiskerToolTipGenerator : StandardCategoryToolTipGenerator, CategoryToolTipGenerator, Cloneable.__Interface, PublicCloneable, Serializable.__Interface
  {
    private const long serialVersionUID = -6076837753823076334L;
    public const string DEFAULT_TOOL_TIP_FORMAT = "X: {1} Mean: {2} Median: {3} Min: {4} Max: {5} Q1: {6} Q3: {7} ";

    [LineNumberTable(new byte[] {(byte) 36, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoxAndWhiskerToolTipGenerator()
      : base("X: {1} Mean: {2} Median: {3} Min: {4} Max: {5} Q1: {6} Q3: {7} ", NumberFormat.getInstance())
    {
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoxAndWhiskerToolTipGenerator(string format, NumberFormat formatter)
      : base(format, formatter)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected BoxAndWhiskerToolTipGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] BoxAndWhiskerToolTipGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] BoxAndWhiskerToolTipGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 62, (byte) 103, (byte) 106, (byte) 105, (byte) 103, (byte) 106, (byte) 107, (byte) 135, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override object[] createItemArray(CategoryDataset dataset, int series, int item)
    {
      object[] objArray = new object[8];
      objArray[0] = (object) dataset.getRowKey(series);
      Number number = dataset.getValue(series, item);
      NumberFormat numberFormat = this.getNumberFormat();
      objArray[1] = (object) ((Format) numberFormat).format((object) number);
      if (dataset is BoxAndWhiskerCategoryDataset)
      {
        BoxAndWhiskerCategoryDataset whiskerCategoryDataset = (BoxAndWhiskerCategoryDataset) dataset;
        objArray[2] = (object) ((Format) numberFormat).format((object) whiskerCategoryDataset.getMeanValue(series, item));
        objArray[3] = (object) ((Format) numberFormat).format((object) whiskerCategoryDataset.getMedianValue(series, item));
        objArray[4] = (object) ((Format) numberFormat).format((object) whiskerCategoryDataset.getMinRegularValue(series, item));
        objArray[5] = (object) ((Format) numberFormat).format((object) whiskerCategoryDataset.getMaxRegularValue(series, item));
        objArray[6] = (object) ((Format) numberFormat).format((object) whiskerCategoryDataset.getQ1Value(series, item));
        objArray[7] = (object) ((Format) numberFormat).format((object) whiskerCategoryDataset.getQ3Value(series, item));
      }
      return objArray;
    }

    [LineNumberTable(new byte[] {(byte) 88, (byte) 100, (byte) 130, (byte) 104, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is BoxAndWhiskerToolTipGenerator))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }
  }
}
