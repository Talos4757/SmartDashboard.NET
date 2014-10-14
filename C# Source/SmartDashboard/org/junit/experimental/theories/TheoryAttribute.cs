// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.TheoryAttribute
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
  [Implements(new string[] {"org.junit.experimental.theories.Theory"})]
  public sealed class TheoryAttribute : AnnotationAttributeBase, Theory
  {
    [HideFromJava]
    public bool nullsAccepted
    {
      [HideFromJava] get
      {
        throw new NotImplementedException();
      }
      [HideFromJava] set
      {
        this.setValue("nullsAccepted", (object) (bool) (value ? 1 : 0));
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public TheoryAttribute([In] object[] obj0)
      : this()
    {
      this.setDefinition(obj0);
    }

    public TheoryAttribute()
    {
      base.\u002Ector((Class) ClassLiteral<Theory>.Value);
    }

    bool Theory.nullsAccepted()
    {
      return this.getBooleanValue("nullsAccepted");
    }

    [HideFromJava]
    public void set_nullsAccepted([In] bool obj0)
    {
      this.setValue("nullsAccepted", (object) (bool) (obj0 ? 1 : 0));
    }

    [HideFromJava]
    public bool get_nullsAccepted()
    {
      throw new NotImplementedException();
    }
  }
}
