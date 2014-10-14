// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.BoxAndWhiskerXYToolTipGenerator
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.io;
using java.lang;
using java.text;
using java.util;
using org.jfree.data.statistics;
using org.jfree.data.xy;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"org.jfree.chart.labels.XYToolTipGenerator", "java.lang.Cloneable", "java.io.Serializable"})]
  [Serializable]
  public class BoxAndWhiskerXYToolTipGenerator : StandardXYToolTipGenerator, XYToolTipGenerator, Cloneable.__Interface, Serializable.__Interface
  {
    private const long serialVersionUID = -2648775791161459710L;
    public new const string DEFAULT_TOOL_TIP_FORMAT = "X: {1} Mean: {2} Median: {3} Min: {4} Max: {5} Q1: {6} Q3: {7} ";

    [LineNumberTable(new byte[] {(byte) 43, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoxAndWhiskerXYToolTipGenerator()
      : base("X: {1} Mean: {2} Median: {3} Min: {4} Max: {5} Q1: {6} Q3: {7} ", NumberFormat.getInstance(), NumberFormat.getInstance())
    {
    }

    [LineNumberTable(new byte[] {(byte) 61, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoxAndWhiskerXYToolTipGenerator(string toolTipFormat, DateFormat dateFormat, NumberFormat numberFormat)
      : base(toolTipFormat, dateFormat, numberFormat)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected BoxAndWhiskerXYToolTipGenerator([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] BoxAndWhiskerXYToolTipGenerator obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [HideFromJava]
    public static implicit operator Serializable([In] BoxAndWhiskerXYToolTipGenerator obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [LineNumberTable(new byte[] {(byte) 77, (byte) 103, (byte) 111, (byte) 105, (byte) 104, (byte) 191, (byte) 1, (byte) 143, (byte) 135, (byte) 107, (byte) 103, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override object[] createItemArray(XYDataset dataset, int series, int item)
    {
      object[] objArray1 = new object[8];
      objArray1[0] = (object) Object.instancehelper_toString((object) dataset.getSeriesKey(series));
      Number x = dataset.getX(series, item);
      if (this.getXDateFormat() != null)
      {
        object[] objArray2 = objArray1;
        int index = 1;
        DateFormat xdateFormat = this.getXDateFormat();
        Date.__\u003Cclinit\u003E();
        Date date = new Date(x.longValue());
        string str = xdateFormat.format(date);
        objArray2[index] = (object) str;
      }
      else
        objArray1[1] = (object) ((Format) this.getXFormat()).format((object) x);
      NumberFormat yformat = this.getYFormat();
      if (dataset is BoxAndWhiskerXYDataset)
      {
        BoxAndWhiskerXYDataset whiskerXyDataset = (BoxAndWhiskerXYDataset) dataset;
        objArray1[2] = (object) ((Format) yformat).format((object) whiskerXyDataset.getMeanValue(series, item));
        objArray1[3] = (object) ((Format) yformat).format((object) whiskerXyDataset.getMedianValue(series, item));
        objArray1[4] = (object) ((Format) yformat).format((object) whiskerXyDataset.getMinRegularValue(series, item));
        objArray1[5] = (object) ((Format) yformat).format((object) whiskerXyDataset.getMaxRegularValue(series, item));
        objArray1[6] = (object) ((Format) yformat).format((object) whiskerXyDataset.getQ1Value(series, item));
        objArray1[7] = (object) ((Format) yformat).format((object) whiskerXyDataset.getQ3Value(series, item));
      }
      return objArray1;
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 100, (byte) 130, (byte) 104, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is BoxAndWhiskerXYToolTipGenerator))
        return false;
      return (base.equals(obj) ? 1 : 0) != 0;
    }
  }
}
