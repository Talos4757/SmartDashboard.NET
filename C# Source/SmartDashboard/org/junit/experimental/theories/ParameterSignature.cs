// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.ParameterSignature
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.lang.annotation;
using java.lang.reflect;
using java.util;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental.theories
{
  public class ParameterSignature : Object
  {
    [Modifiers]
    [Signature("Ljava/lang/Class<*>;")]
    private Class type;
    [Modifiers]
    private Annotation[] annotations;

    [Signature("(Ljava/lang/Class<*>;[Ljava/lang/annotation/Annotation;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 180, (byte) 104, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private ParameterSignature([In] Class obj0, [In] Annotation[] obj1)
    {
      base.\u002Ector();
      ParameterSignature parameterSignature = this;
      this.type = obj0;
      this.annotations = obj1;
    }

    [Signature("([Ljava/lang/Class<*>;[[Ljava/lang/annotation/Annotation;)Ljava/util/ArrayList<Lorg/junit/experimental/theories/ParameterSignature;>;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 168, (byte) 102, (byte) 103, (byte) 50, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static ArrayList signatures([In] Class[] obj0, [In] Annotation[][] obj1)
    {
      ArrayList arrayList = new ArrayList();
      for (int index = 0; index < obj0.Length; ++index)
        arrayList.add((object) new ParameterSignature(obj0[index], obj1[index]));
      return arrayList;
    }

    [Signature("(Ljava/lang/Class<*>;)Z")]
    [LineNumberTable((ushort) 44)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool canAcceptType(Class candidate)
    {
      return (this.type.isAssignableFrom(candidate) ? 1 : 0) != 0;
    }

    [Signature("<T::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TT;>;)TT;")]
    [LineNumberTable(new byte[] {(byte) 35, (byte) 127, (byte) 1, (byte) 105, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Annotation getAnnotation(Class annotationType)
    {
      Iterator iterator = this.getAnnotations().iterator();
      while (iterator.hasNext())
      {
        Annotation annotation = (Annotation) iterator.next();
        if (annotationType.isInstance((object) annotation))
          return (Annotation) annotationType.cast((object) annotation);
      }
      return (Annotation) null;
    }

    [Signature("<T::Ljava/lang/annotation/Annotation;>([Ljava/lang/annotation/Annotation;Ljava/lang/Class<TT;>;I)TT;")]
    [LineNumberTable(new byte[] {(byte) 20, (byte) 99, (byte) 98, (byte) 111, (byte) 105, (byte) 109, (byte) 151, (byte) 100, (byte) 238, (byte) 58, (byte) 230, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Annotation findDeepAnnotation([In] Annotation[] obj0, [In] Class obj1, [In] int obj2)
    {
      if (obj2 == 0)
        return (Annotation) null;
      Annotation[] annotationArray = obj0;
      int length = annotationArray.Length;
      for (int index = 0; index < length; ++index)
      {
        Annotation annotation = annotationArray[index];
        if (obj1.isInstance((object) annotation))
          return (Annotation) obj1.cast((object) annotation);
        Annotation deepAnnotation = this.findDeepAnnotation(annotation.annotationType().getAnnotations(), obj1, obj2 - 1);
        if (deepAnnotation != null)
          return (Annotation) obj1.cast((object) deepAnnotation);
      }
      return (Annotation) null;
    }

    [Signature("()Ljava/util/List<Ljava/lang/annotation/Annotation;>;")]
    [LineNumberTable((ushort) 52)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getAnnotations()
    {
      return Arrays.asList((object[]) this.annotations);
    }

    [Signature("(Ljava/lang/reflect/Method;)Ljava/util/ArrayList<Lorg/junit/experimental/theories/ParameterSignature;>;")]
    [LineNumberTable((ushort) 15)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ArrayList signatures(Method method)
    {
      return ParameterSignature.signatures(method.getParameterTypes(), method.getParameterAnnotations());
    }

    [Signature("(Ljava/lang/reflect/Constructor<*>;)Ljava/util/List<Lorg/junit/experimental/theories/ParameterSignature;>;")]
    [LineNumberTable((ushort) 20)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List signatures(Constructor constructor)
    {
      return (List) ParameterSignature.signatures(constructor.getParameterTypes(), constructor.getParameterAnnotations());
    }

    [Signature("()Ljava/lang/Class<*>;")]
    public virtual Class getType()
    {
      return this.type;
    }

    [Signature("(Ljava/lang/Class<*>;)Z")]
    [LineNumberTable((ushort) 56)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool canAcceptArrayType(Class type)
    {
      return type.isArray() && this.canAcceptType(type.getComponentType());
    }

    [Signature("(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
    [LineNumberTable((ushort) 60)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool hasAnnotation(Class type)
    {
      return this.getAnnotation(type) != null;
    }

    [Signature("<T::Ljava/lang/annotation/Annotation;>(Ljava/lang/Class<TT;>;)TT;")]
    [LineNumberTable(new byte[] {(byte) 14, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Annotation findDeepAnnotation(Class annotationType)
    {
      return this.findDeepAnnotation(this.annotations, annotationType, 3);
    }
  }
}
