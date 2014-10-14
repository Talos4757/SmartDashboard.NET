// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.annotation.PlatformAttribute
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
  [Implements(new string[] {"com.googlecode.javacpp.annotation.Platform"})]
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
  public sealed class PlatformAttribute : AnnotationAttributeBase, Platform
  {
    [HideFromJava]
    public string[] not
    {
      [HideFromJava] get
      {
        throw new NotImplementedException();
      }
      [HideFromJava] set
      {
        this.setValue("not", (object) value);
      }
    }

    [HideFromJava]
    public string[] define
    {
      [HideFromJava] get
      {
        throw new NotImplementedException();
      }
      [HideFromJava] set
      {
        this.setValue("define", (object) value);
      }
    }

    [HideFromJava]
    public string[] include
    {
      [HideFromJava] get
      {
        throw new NotImplementedException();
      }
      [HideFromJava] set
      {
        this.setValue("include", (object) value);
      }
    }

    [HideFromJava]
    public string[] cinclude
    {
      [HideFromJava] get
      {
        throw new NotImplementedException();
      }
      [HideFromJava] set
      {
        this.setValue("cinclude", (object) value);
      }
    }

    [HideFromJava]
    public string[] includepath
    {
      [HideFromJava] get
      {
        throw new NotImplementedException();
      }
      [HideFromJava] set
      {
        this.setValue("includepath", (object) value);
      }
    }

    [HideFromJava]
    public string[] options
    {
      [HideFromJava] get
      {
        throw new NotImplementedException();
      }
      [HideFromJava] set
      {
        this.setValue("options", (object) value);
      }
    }

    [HideFromJava]
    public string[] linkpath
    {
      [HideFromJava] get
      {
        throw new NotImplementedException();
      }
      [HideFromJava] set
      {
        this.setValue("linkpath", (object) value);
      }
    }

    [HideFromJava]
    public string[] link
    {
      [HideFromJava] get
      {
        throw new NotImplementedException();
      }
      [HideFromJava] set
      {
        this.setValue("link", (object) value);
      }
    }

    [HideFromJava]
    public string[] preloadpath
    {
      [HideFromJava] get
      {
        throw new NotImplementedException();
      }
      [HideFromJava] set
      {
        this.setValue("preloadpath", (object) value);
      }
    }

    [HideFromJava]
    public string[] preload
    {
      [HideFromJava] get
      {
        throw new NotImplementedException();
      }
      [HideFromJava] set
      {
        this.setValue("preload", (object) value);
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public PlatformAttribute([In] object[] obj0)
      : this()
    {
      this.setDefinition(obj0);
    }

    public PlatformAttribute()
    {
      base.\u002Ector((Class) ClassLiteral<Platform>.Value);
    }

    [HideFromJava]
    public PlatformAttribute(string[] value)
      : this()
    {
      this.setValue("value", (object) value);
    }

    string[] Platform.value()
    {
      return (string[]) this.getValue("value");
    }

    string[] Platform.not()
    {
      return (string[]) this.getValue("not");
    }

    [HideFromJava]
    public void set_not([In] string[] obj0)
    {
      this.setValue("not", (object) obj0);
    }

    [HideFromJava]
    public string[] get_not()
    {
      throw new NotImplementedException();
    }

    string[] Platform.define()
    {
      return (string[]) this.getValue("define");
    }

    [HideFromJava]
    public void set_define([In] string[] obj0)
    {
      this.setValue("define", (object) obj0);
    }

    [HideFromJava]
    public string[] get_define()
    {
      throw new NotImplementedException();
    }

    string[] Platform.include()
    {
      return (string[]) this.getValue("include");
    }

    [HideFromJava]
    public void set_include([In] string[] obj0)
    {
      this.setValue("include", (object) obj0);
    }

    [HideFromJava]
    public string[] get_include()
    {
      throw new NotImplementedException();
    }

    string[] Platform.cinclude()
    {
      return (string[]) this.getValue("cinclude");
    }

    [HideFromJava]
    public void set_cinclude([In] string[] obj0)
    {
      this.setValue("cinclude", (object) obj0);
    }

    [HideFromJava]
    public string[] get_cinclude()
    {
      throw new NotImplementedException();
    }

    string[] Platform.includepath()
    {
      return (string[]) this.getValue("includepath");
    }

    [HideFromJava]
    public void set_includepath([In] string[] obj0)
    {
      this.setValue("includepath", (object) obj0);
    }

    [HideFromJava]
    public string[] get_includepath()
    {
      throw new NotImplementedException();
    }

    string[] Platform.options()
    {
      return (string[]) this.getValue("options");
    }

    [HideFromJava]
    public void set_options([In] string[] obj0)
    {
      this.setValue("options", (object) obj0);
    }

    [HideFromJava]
    public string[] get_options()
    {
      throw new NotImplementedException();
    }

    string[] Platform.linkpath()
    {
      return (string[]) this.getValue("linkpath");
    }

    [HideFromJava]
    public void set_linkpath([In] string[] obj0)
    {
      this.setValue("linkpath", (object) obj0);
    }

    [HideFromJava]
    public string[] get_linkpath()
    {
      throw new NotImplementedException();
    }

    string[] Platform.link()
    {
      return (string[]) this.getValue("link");
    }

    [HideFromJava]
    public void set_link([In] string[] obj0)
    {
      this.setValue("link", (object) obj0);
    }

    [HideFromJava]
    public string[] get_link()
    {
      throw new NotImplementedException();
    }

    string[] Platform.preloadpath()
    {
      return (string[]) this.getValue("preloadpath");
    }

    [HideFromJava]
    public void set_preloadpath([In] string[] obj0)
    {
      this.setValue("preloadpath", (object) obj0);
    }

    [HideFromJava]
    public string[] get_preloadpath()
    {
      throw new NotImplementedException();
    }

    string[] Platform.preload()
    {
      return (string[]) this.getValue("preload");
    }

    [HideFromJava]
    public void set_preload([In] string[] obj0)
    {
      this.setValue("preload", (object) obj0);
    }

    [HideFromJava]
    public string[] get_preload()
    {
      throw new NotImplementedException();
    }
  }
}
