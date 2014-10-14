// Decompiled with JetBrains decompiler
// Type: org.hamcrest.FactoryAttribute
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace org.hamcrest
{
  [Modifiers]
  [InnerClass]
  [Implements(new string[] {"org.hamcrest.Factory"})]
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class FactoryAttribute : AnnotationAttributeBase, Factory
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public FactoryAttribute([In] object[] obj0)
      : this()
    {
      this.setDefinition(obj0);
    }

    public FactoryAttribute()
    {
      base.\u002Ector((Class) ClassLiteral<Factory>.Value);
    }
  }
}
