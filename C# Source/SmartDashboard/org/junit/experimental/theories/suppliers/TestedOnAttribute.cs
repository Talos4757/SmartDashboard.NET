// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.suppliers.TestedOnAttribute
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace org.junit.experimental.theories.suppliers
{
  [Modifiers]
  [InnerClass]
  [Implements(new string[] {"org.junit.experimental.theories.suppliers.TestedOn"})]
  public sealed class TestedOnAttribute : AnnotationAttributeBase, TestedOn
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public TestedOnAttribute([In] object[] obj0)
      : this()
    {
      this.setDefinition(obj0);
    }

    private TestedOnAttribute()
    {
      base.\u002Ector((Class) ClassLiteral<TestedOn>.Value);
    }

    [HideFromJava]
    public TestedOnAttribute(int[] ints)
      : this()
    {
      this.setValue("ints", (object) ints);
    }

    int[] TestedOn.ints()
    {
      return (int[]) this.getValue("ints");
    }
  }
}
