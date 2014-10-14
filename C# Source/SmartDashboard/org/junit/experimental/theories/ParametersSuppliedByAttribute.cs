// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.ParametersSuppliedByAttribute
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace org.junit.experimental.theories
{
  [Modifiers]
  [InnerClass]
  [Implements(new string[] {"org.junit.experimental.theories.ParametersSuppliedBy"})]
  public sealed class ParametersSuppliedByAttribute : AnnotationAttributeBase, ParametersSuppliedBy
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ParametersSuppliedByAttribute([In] object[] obj0)
      : this()
    {
      this.setDefinition(obj0);
    }

    private ParametersSuppliedByAttribute()
    {
      base.\u002Ector((Class) ClassLiteral<ParametersSuppliedBy>.Value);
    }

    [HideFromJava]
    public ParametersSuppliedByAttribute(Type value)
      : this()
    {
      this.setValue("value", (object) value);
    }

    Class ParametersSuppliedBy.value()
    {
      return (Class) this.getValue("value");
    }
  }
}
