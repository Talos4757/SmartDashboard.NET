// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.annotation.ByPtrAttribute
// Assembly: javacpp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 045C9A9A-CAC1-44AC-9FF2-036C0A7C9747
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacpp.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace com.googlecode.javacpp.annotation
{
  [Modifiers]
  [InnerClass]
  [Implements(new string[] {"com.googlecode.javacpp.annotation.ByPtr"})]
  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
  public sealed class ByPtrAttribute : AnnotationAttributeBase, ByPtr
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ByPtrAttribute([In] object[] obj0)
      : this()
    {
      this.setDefinition(obj0);
    }

    public ByPtrAttribute()
    {
      base.\u002Ector((Class) ClassLiteral<ByPtr>.Value);
    }
  }
}
