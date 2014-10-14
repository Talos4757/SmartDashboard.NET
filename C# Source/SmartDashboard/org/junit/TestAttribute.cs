// Decompiled with JetBrains decompiler
// Type: org.junit.TestAttribute
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
  [Implements(new string[] {"org.junit.Test"})]
  [AttributeUsage(AttributeTargets.Method)]
  public sealed class TestAttribute : AnnotationAttributeBase, Test
  {
    [HideFromJava]
    public Type expected
    {
      [HideFromJava] get
      {
        throw new NotImplementedException();
      }
      [HideFromJava] set
      {
        this.setValue("expected", (object) value);
      }
    }

    [HideFromJava]
    public long timeout
    {
      [HideFromJava] get
      {
        throw new NotImplementedException();
      }
      [HideFromJava] set
      {
        this.setValue("timeout", (object) value);
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public TestAttribute([In] object[] obj0)
      : this()
    {
      this.setDefinition(obj0);
    }

    public TestAttribute()
    {
      base.\u002Ector((Class) ClassLiteral<Test>.Value);
    }

    Class Test.expected()
    {
      return (Class) this.getValue("expected");
    }

    [HideFromJava]
    public void set_expected([In] Type obj0)
    {
      this.setValue("expected", (object) obj0);
    }

    [HideFromJava]
    public Type get_expected()
    {
      throw new NotImplementedException();
    }

    long Test.timeout()
    {
      return this.getLongValue("timeout");
    }

    [HideFromJava]
    public void set_timeout([In] long obj0)
    {
      this.setValue("timeout", (object) obj0);
    }

    [HideFromJava]
    public long get_timeout()
    {
      throw new NotImplementedException();
    }
  }
}
