// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.annotation.ByPtrPtrAttribute
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
  [Implements(new string[] {"com.googlecode.javacpp.annotation.ByPtrPtr"})]
  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
  public sealed class ByPtrPtrAttribute : AnnotationAttributeBase, ByPtrPtr
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public ByPtrPtrAttribute([In] object[] obj0)
      : this()
    {
      this.setDefinition(obj0);
    }

    public ByPtrPtrAttribute()
    {
      base.\u002Ector((Class) ClassLiteral<ByPtrPtr>.Value);
    }
  }
}
