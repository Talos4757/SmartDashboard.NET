// Decompiled with JetBrains decompiler
// Type: org.junit.runners.model.FrameworkMethod
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.lang.annotation;
using java.lang.reflect;
using java.util;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runners.model
{
  [Signature("Lorg/junit/runners/model/FrameworkMember<Lorg/junit/runners/model/FrameworkMethod;>;")]
  public class FrameworkMethod : FrameworkMember
  {
    [Modifiers]
    internal Method fMethod;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 165, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FrameworkMethod(Method method)
    {
      FrameworkMethod frameworkMethod = this;
      this.fMethod = method;
    }

    [Signature("(ZLjava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 126, (byte) 130, (byte) 104, (byte) 110, (byte) 127, (byte) 27})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void validatePublicVoidNoArg(bool isStatic, List errors)
    {
      this.validatePublicVoid(isStatic, errors);
      if (this.fMethod.getParameterTypes().Length == 0)
        return;
      errors.add((object) new Exception(new StringBuilder().append("Method ").append(this.fMethod.getName()).append(" should have no parameters").toString()));
    }

    [Signature("<T::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TT;>;)TT;")]
    [LineNumberTable((ushort) 143)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Annotation getAnnotation(Class annotationType)
    {
      return this.fMethod.getAnnotation(annotationType);
    }

    [LineNumberTable((ushort) 135)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Annotation[] getAnnotations()
    {
      return ((AccessibleObject) this.fMethod).getAnnotations();
    }

    [LineNumberTable((ushort) 53)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getName()
    {
      return this.fMethod.getName();
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [LineNumberTable((ushort) 41)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object invokeExplosively(object target, params object[] @params)
    {
      return new FrameworkMethod\u00241(this, target, @params).run();
    }

    public virtual Method getMethod()
    {
      return this.fMethod;
    }

    [Signature("(ZLjava/util/List<Ljava/lang/Throwable;>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 122, (byte) 98, (byte) 115, (byte) 112, (byte) 159, (byte) 43, (byte) 119, (byte) 127, (byte) 32, (byte) 114, (byte) 127, (byte) 27, (byte) 114, (byte) 127, (byte) 27})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void validatePublicVoid(bool isStatic, List errors)
    {
      int num = isStatic ? 1 : 0;
      if ((Modifier.isStatic(this.fMethod.getModifiers()) ? 1 : 0) != num)
      {
        string str = num == 0 ? "should not" : "should";
        errors.add((object) new Exception(new StringBuilder().append("Method ").append(this.fMethod.getName()).append("() ").append(str).append(" be static").toString()));
      }
      if (!Modifier.isPublic(this.fMethod.getDeclaringClass().getModifiers()))
        errors.add((object) new Exception(new StringBuilder().append("Class ").append(this.fMethod.getDeclaringClass().getName()).append(" should be public").toString()));
      if (!Modifier.isPublic(this.fMethod.getModifiers()))
        errors.add((object) new Exception(new StringBuilder().append("Method ").append(this.fMethod.getName()).append("() should be public").toString()));
      if (this.fMethod.getReturnType() == Void.TYPE)
        return;
      errors.add((object) new Exception(new StringBuilder().append("Method ").append(this.fMethod.getName()).append("() should be void").toString()));
    }

    [Signature("(Ljava/lang/Class<*>;)Z")]
    [LineNumberTable((ushort) 122)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool producesType(Class type)
    {
      return this.getParameterTypes().Length == 0 && type.isAssignableFrom(this.fMethod.getReturnType());
    }

    [Signature("()[Ljava/lang/Class<*>;")]
    [LineNumberTable((ushort) 127)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Class[] getParameterTypes()
    {
      return this.fMethod.getParameterTypes();
    }

    [LineNumberTable(new byte[] {(byte) 45, (byte) 115, (byte) 98, (byte) 112, (byte) 98, (byte) 108, (byte) 119, (byte) 2, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isShadowedBy(FrameworkMethod other)
    {
      if (!String.instancehelper_equals(other.getName(), (object) this.getName()) || other.getParameterTypes().Length != this.getParameterTypes().Length)
        return false;
      for (int index = 0; index < other.getParameterTypes().Length; ++index)
      {
        if (!Object.instancehelper_equals((object) other.getParameterTypes()[index], (object) this.getParameterTypes()[index]))
          return false;
      }
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 109, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (!((Class) ClassLiteral<FrameworkMethod>.Value).isInstance(obj))
        return false;
      return (((FrameworkMethod) obj).fMethod.equals((object) this.fMethod) ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 114)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int hashCode()
    {
      return this.fMethod.hashCode();
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 17)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool isShadowedBy(FrameworkMember x0)
    {
      return (this.isShadowedBy((FrameworkMethod) x0) ? 1 : 0) != 0;
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
  }
}
