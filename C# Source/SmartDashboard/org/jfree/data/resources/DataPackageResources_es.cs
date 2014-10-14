// Decompiled with JetBrains decompiler
// Type: org.jfree.data.resources.DataPackageResources_es
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.util;
using System.Runtime.CompilerServices;

namespace org.jfree.data.resources
{
  public class DataPackageResources_es : ListResourceBundle
  {
    [Modifiers]
    private static object[][] CONTENTS;

    [LineNumberTable((ushort) 62)]
    static DataPackageResources_es()
    {
      ListResourceBundle.__\u003Cclinit\u003E();
      object[][] objArray1 = new object[2][];
      int index1 = 0;
      object[] objArray2 = new object[2];
      int index2 = 0;
      string str1 = "series.default-prefix";
      objArray2[index2] = (object) str1;
      int index3 = 1;
      string str2 = "Series";
      objArray2[index3] = (object) str2;
      objArray1[index1] = objArray2;
      int index4 = 1;
      object[] objArray3 = new object[2];
      int index5 = 0;
      string str3 = "categories.default-prefix";
      objArray3[index5] = (object) str3;
      int index6 = 1;
      string str4 = "Categor?a";
      objArray3[index6] = (object) str4;
      objArray1[index4] = objArray3;
      DataPackageResources_es.CONTENTS = objArray1;
    }

    [LineNumberTable((ushort) 50)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataPackageResources_es()
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
      return DataPackageResources_es.CONTENTS;
    }
  }
}
