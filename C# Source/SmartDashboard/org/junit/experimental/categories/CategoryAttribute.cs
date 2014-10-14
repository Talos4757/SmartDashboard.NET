// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.categories.CategoryAttribute
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace org.junit.experimental.categories
{
  [Modifiers]
  [InnerClass]
  [Implements(new string[] {"org.junit.experimental.categories.Category"})]
  public sealed class CategoryAttribute : AnnotationAttributeBase, Category
  {
    [EditorBrowsable(EditorBrowsableState.Never)]
    public CategoryAttribute([In] object[] obj0)
      : this()
    {
      this.setDefinition(obj0);
    }

    private CategoryAttribute()
    {
      base.\u002Ector((Class) ClassLiteral<Category>.Value);
    }

    [HideFromJava]
    public CategoryAttribute(Type[] value)
      : this()
    {
      this.setValue("value", (object) value);
    }

    Class[] Category.value()
    {
      return (Class[]) this.getValue("value");
    }
  }
}
