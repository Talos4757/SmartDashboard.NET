// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.annotation.NoOffsetAttribute
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
  [Implements(new string[] {"com.googlecode.javacpp.annotation.NoOffset"})]
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
  public sealed class NoOffsetAttribute : AnnotationAttributeBase, NoOffset
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public NoOffsetAttribute([In] object[] obj0)
      : this()
    {
      this.setDefinition(obj0);
    }

    public NoOffsetAttribute()
    {
      base.\u002Ector((Class) ClassLiteral<NoOffset>.Value);
    }
  }
}
