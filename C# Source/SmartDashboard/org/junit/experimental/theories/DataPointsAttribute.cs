// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.DataPointsAttribute
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace org.junit.experimental.theories
{
  [Modifiers]
  [InnerClass]
  [Implements(new string[] {"org.junit.experimental.theories.DataPoints"})]
  public sealed class DataPointsAttribute : AnnotationAttributeBase, DataPoints
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public DataPointsAttribute([In] object[] obj0)
      : this()
    {
      this.setDefinition(obj0);
    }

    public DataPointsAttribute()
    {
      base.\u002Ector((Class) ClassLiteral<DataPoints>.Value);
    }
  }
}
