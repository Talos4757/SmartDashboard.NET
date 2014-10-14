// Decompiled with JetBrains decompiler
// Type: org.junit.IgnoreAttribute
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace org.junit
{
  [Modifiers]
  [InnerClass]
  [Implements(new string[] {"org.junit.Ignore"})]
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
  public sealed class IgnoreAttribute : AnnotationAttributeBase, Ignore
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public IgnoreAttribute([In] object[] obj0)
      : this()
    {
      this.setDefinition(obj0);
    }

    public IgnoreAttribute()
    {
      base.\u002Ector((Class) ClassLiteral<Ignore>.Value);
    }

    [HideFromJava]
    public IgnoreAttribute(string value)
      : this()
    {
      this.setValue("value", (object) value);
    }

    string Ignore.value()
    {
      return (string) this.getValue("value");
    }
  }
}
