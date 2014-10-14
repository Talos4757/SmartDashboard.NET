// Decompiled with JetBrains decompiler
// Type: org.junit.runners.model.FrameworkField
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.lang.annotation;
using java.lang.reflect;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runners.model
{
  [Signature("Lorg/junit/runners/model/FrameworkMember<Lorg/junit/runners/model/FrameworkField;>;")]
  public class FrameworkField : FrameworkMember
  {
    [Modifiers]
    private Field fField;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 157, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal FrameworkField([In] Field obj0)
    {
      FrameworkField frameworkField = this;
      this.fField = obj0;
    }

    public virtual Field getField()
    {
      return this.fField;
    }

    [LineNumberTable((ushort) 26)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isShadowedBy(FrameworkField otherMember)
    {
      return (String.instancehelper_equals(otherMember.getField().getName(), (object) this.getField().getName()) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 21)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Annotation[] getAnnotations()
    {
      return ((AccessibleObject) this.fField).getAnnotations();
    }

    [Throws(new string[] {"java.lang.IllegalArgumentException", "java.lang.IllegalAccessException"})]
    [LineNumberTable((ushort) 40)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object get(object target)
    {
      return this.fField.get(target, FrameworkField.__\u003CGetCallerID\u003E());
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 12)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool isShadowedBy(FrameworkMember x0)
    {
      return (this.isShadowedBy((FrameworkField) x0) ? 1 : 0) != 0;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (FrameworkField.__\u003CcallerID\u003E == null)
        FrameworkField.__\u003CcallerID\u003E = (CallerID) new FrameworkField.__\u003CCallerID\u003E();
      return FrameworkField.__\u003CcallerID\u003E;
    }

    [HideFromJava]
    [NameSig("isShadowedBy", "(Lorg.junit.runners.model.FrameworkMember;)Z")]
    public bool \u003Cbridge\u003EisShadowedBy([In] object obj0)
    {
      return this.isShadowedBy((FrameworkMember) obj0);
    }

    [HideFromJava]
    [NameSig("isShadowedBy", "(Lorg.junit.runners.model.FrameworkMember;)Z")]
    protected internal bool \u003Cnonvirtual\u003E0([In] object obj0)
    {
      return this.isShadowedBy((FrameworkMember) obj0);
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
