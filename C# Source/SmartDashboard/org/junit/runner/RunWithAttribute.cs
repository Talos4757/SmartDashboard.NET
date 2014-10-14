// Decompiled with JetBrains decompiler
// Type: org.junit.runner.RunWithAttribute
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace org.junit.runner
{
  [Modifiers]
  [InnerClass]
  [Implements(new string[] {"org.junit.runner.RunWith"})]
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
  public sealed class RunWithAttribute : AnnotationAttributeBase, RunWith
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public RunWithAttribute([In] object[] obj0)
      : this()
    {
      this.setDefinition(obj0);
    }

    private RunWithAttribute()
    {
      base.\u002Ector((Class) ClassLiteral<RunWith>.Value);
    }

    [HideFromJava]
    public RunWithAttribute(Type value)
      : this()
    {
      this.setValue("value", (object) value);
    }

    Class RunWith.value()
    {
      return (Class) this.getValue("value");
    }
  }
}
