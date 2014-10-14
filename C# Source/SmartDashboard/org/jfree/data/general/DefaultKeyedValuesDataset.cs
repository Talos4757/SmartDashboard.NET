// Decompiled with JetBrains decompiler
// Type: org.jfree.data.general.DefaultKeyedValuesDataset
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using org.jfree.data;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.data.general
{
  [Implements(new string[] {"org.jfree.data.general.KeyedValuesDataset"})]
  [Serializable]
  public class DefaultKeyedValuesDataset : DefaultPieDataset, KeyedValuesDataset, PieDataset, KeyedValues, Values, Dataset
  {
    private const long serialVersionUID = 306264413152815781L;

    [LineNumberTable((ushort) 48)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultKeyedValuesDataset()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultKeyedValuesDataset([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }
  }
}
