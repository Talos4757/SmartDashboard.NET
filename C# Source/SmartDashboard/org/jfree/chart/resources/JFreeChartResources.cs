// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.resources.JFreeChartResources
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.util;
using System.Runtime.CompilerServices;

namespace org.jfree.chart.resources
{
  public class JFreeChartResources : ListResourceBundle
  {
    [Modifiers]
    private static object[][] CONTENTS;

    [LineNumberTable((ushort) 56)]
    static JFreeChartResources()
    {
      ListResourceBundle.__\u003Cclinit\u003E();
      object[][] objArray1 = new object[4][];
      int index1 = 0;
      object[] objArray2 = new object[2];
      int index2 = 0;
      string str1 = "project.name";
      objArray2[index2] = (object) str1;
      int index3 = 1;
      string str2 = "JFreeChart";
      objArray2[index3] = (object) str2;
      objArray1[index1] = objArray2;
      int index4 = 1;
      object[] objArray3 = new object[2];
      int index5 = 0;
      string str3 = "project.version";
      objArray3[index5] = (object) str3;
      int index6 = 1;
      string str4 = "1.0.13";
      objArray3[index6] = (object) str4;
      objArray1[index4] = objArray3;
      int index7 = 2;
      object[] objArray4 = new object[2];
      int index8 = 0;
      string str5 = "project.info";
      objArray4[index8] = (object) str5;
      int index9 = 1;
      string str6 = "http://www.jfree.org/jfreechart/index.html";
      objArray4[index9] = (object) str6;
      objArray1[index7] = objArray4;
      int index10 = 3;
      object[] objArray5 = new object[2];
      int index11 = 0;
      string str7 = "project.copyright";
      objArray5[index11] = (object) str7;
      int index12 = 1;
      string str8 = "(C)opyright 2000-2009, by Object Refinery Limited and Contributors";
      objArray5[index12] = (object) str8;
      objArray1[index10] = objArray5;
      JFreeChartResources.CONTENTS = objArray1;
    }

    [LineNumberTable((ushort) 44)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JFreeChartResources()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual object[][] getContents()
    {
      return JFreeChartResources.CONTENTS;
    }
  }
}
