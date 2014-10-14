// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.annotation.NameAttribute
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
  [Implements(new string[] {"com.googlecode.javacpp.annotation.Name"})]
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
  public sealed class NameAttribute : AnnotationAttributeBase, Name
  {
    [HideFromJava]
    public string suffix
    {
      [HideFromJava] get
      {
        throw new NotImplementedException();
      }
      [HideFromJava] set
      {
        this.setValue("suffix", (object) value);
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public NameAttribute([In] object[] obj0)
      : this()
    {
      this.setDefinition(obj0);
    }

    private NameAttribute()
    {
      base.\u002Ector((Class) ClassLiteral<Name>.Value);
    }

    [HideFromJava]
    public NameAttribute(string value)
      : this()
    {
      this.setValue("value", (object) value);
    }

    string Name.value()
    {
      return (string) this.getValue("value");
    }

    string Name.suffix()
    {
      return (string) this.getValue("suffix");
    }

    [HideFromJava]
    public void set_suffix([In] string obj0)
    {
      this.setValue("suffix", (object) obj0);
    }

    [HideFromJava]
    public string get_suffix()
    {
      throw new NotImplementedException();
    }
  }
}
