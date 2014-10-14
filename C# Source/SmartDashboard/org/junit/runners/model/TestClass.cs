// Decompiled with JetBrains decompiler
// Type: org.junit.runners.model.TestClass
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.lang.annotation;
using java.lang.reflect;
using java.util;
using org.junit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runners.model
{
  public class TestClass : Object
  {
    [Modifiers]
    [Signature("Ljava/lang/Class<*>;")]
    private Class fClass;
    [Signature("Ljava/util/Map<Ljava/lang/Class<*>;Ljava/util/List<Lorg/junit/runners/model/FrameworkMethod;>;>;")]
    private Map fMethodsForAnnotations;
    [Signature("Ljava/util/Map<Ljava/lang/Class<*>;Ljava/util/List<Lorg/junit/runners/model/FrameworkField;>;>;")]
    private Map fFieldsForAnnotations;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 232, (byte) 54, (byte) 139, (byte) 235, (byte) 73, (byte) 103, (byte) 114, (byte) 176, (byte) 127, (byte) 10, (byte) 127, (byte) 0, (byte) 51, (byte) 168, (byte) 127, (byte) 3, (byte) 51, (byte) 205})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestClass(Class klass)
    {
      base.\u002Ector();
      TestClass testClass = this;
      this.fMethodsForAnnotations = (Map) new HashMap();
      this.fFieldsForAnnotations = (Map) new HashMap();
      this.fClass = klass;
      if (klass != null && klass.getConstructors(TestClass.__\u003CGetCallerID\u003E()).Length > 1)
      {
        string str = "Test class can only have one constructor";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        Iterator iterator = this.getSuperClasses(this.fClass).iterator();
label_3:
        while (iterator.hasNext())
        {
          Class @class = (Class) iterator.next();
          Method[] declaredMethods = @class.getDeclaredMethods(TestClass.__\u003CGetCallerID\u003E());
          int length1 = declaredMethods.Length;
          for (int index = 0; index < length1; ++index)
            this.addToAnnotationLists((FrameworkMember) new FrameworkMethod(declaredMethods[index]), this.fMethodsForAnnotations);
          Field[] declaredFields = @class.getDeclaredFields(TestClass.__\u003CGetCallerID\u003E());
          int length2 = declaredFields.Length;
          int index1 = 0;
          while (true)
          {
            if (index1 < length2)
            {
              this.addToAnnotationLists((FrameworkMember) new FrameworkField(declaredFields[index1]), this.fFieldsForAnnotations);
              ++index1;
            }
            else
              goto label_3;
          }
        }
      }
    }

    [Signature("(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Ljava/util/List<Lorg/junit/runners/model/FrameworkMethod;>;")]
    [LineNumberTable((ushort) 68)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getAnnotatedMethods(Class annotationClass)
    {
      return this.getAnnotatedMembers(this.fMethodsForAnnotations, annotationClass);
    }

    [LineNumberTable(new byte[] {(byte) 63, (byte) 104, (byte) 102})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getName()
    {
      if (this.fClass == null)
        return "null";
      return this.fClass.getName();
    }

    [LineNumberTable(new byte[] {(byte) 83, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Annotation[] getAnnotations()
    {
      if (this.fClass == null)
        return new Annotation[0];
      return this.fClass.getAnnotations();
    }

    [Signature("()Ljava/lang/Class<*>;")]
    public virtual Class getJavaClass()
    {
      return this.fClass;
    }

    [Signature("()Ljava/lang/reflect/Constructor<*>;")]
    [LineNumberTable(new byte[] {(byte) 74, (byte) 113, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Constructor getOnlyConstructor()
    {
      Constructor[] constructors = this.fClass.getConstructors(TestClass.__\u003CGetCallerID\u003E());
      Assert.assertEquals(1L, (long) constructors.Length);
      return constructors[0];
    }

    [Signature("(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Ljava/util/List<Lorg/junit/runners/model/FrameworkField;>;")]
    [LineNumberTable((ushort) 77)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getAnnotatedFields(Class annotationClass)
    {
      return this.getAnnotatedMembers(this.fFieldsForAnnotations, annotationClass);
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/lang/Object;Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;Ljava/lang/Class<TT;>;)Ljava/util/List<TT;>;")]
    [LineNumberTable(new byte[] {(byte) 90, (byte) 102, (byte) 159, (byte) 2, (byte) 223, (byte) 0, (byte) 226, (byte) 61, (byte) 97, (byte) 210})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List getAnnotatedFieldValues(object test, Class annotationClass, Class valueClass)
    {
      ArrayList arrayList = new ArrayList();
      Iterator iterator = this.getAnnotatedFields(annotationClass).iterator();
      while (iterator.hasNext())
      {
        FrameworkField frameworkField = (FrameworkField) iterator.next();
        try
        {
          ((List) arrayList).add(valueClass.cast(frameworkField.get(test)));
          continue;
        }
        catch (IllegalAccessException ex)
        {
        }
        string str = "How did getFields return a field we couldn't access?";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str);
      }
      return (List) arrayList;
    }

    [Signature("(Ljava/lang/Class<*>;)Ljava/util/List<Ljava/lang/Class<*>;>;")]
    [LineNumberTable(new byte[] {(byte) 43, (byte) 102, (byte) 98, (byte) 99, (byte) 104, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private List getSuperClasses([In] Class obj0)
    {
      ArrayList arrayList = new ArrayList();
      for (Class @class = obj0; @class != null; @class = @class.getSuperclass())
        arrayList.add((object) @class);
      return (List) arrayList;
    }

    [Signature("<T:Lorg/junit/runners/model/FrameworkMember<TT;>;>(TT;Ljava/util/Map<Ljava/lang/Class<*>;Ljava/util/List<TT;>;>;)V")]
    [LineNumberTable(new byte[] {(byte) 0, (byte) 116, (byte) 104, (byte) 107, (byte) 106, (byte) 97, (byte) 106, (byte) 139, (byte) 233, (byte) 56, (byte) 230, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void addToAnnotationLists([In] FrameworkMember obj0, [In] Map obj1)
    {
      Annotation[] annotations = obj0.getAnnotations();
      int length = annotations.Length;
      for (int index = 0; index < length; ++index)
      {
        Class @class = annotations[index].annotationType();
        List annotatedMembers = this.getAnnotatedMembers(obj1, @class);
        if (obj0.isShadowedBy(annotatedMembers))
          break;
        if (this.runsTopToBottom(@class))
          annotatedMembers.add(0, (object) obj0);
        else
          annotatedMembers.add((object) obj0);
      }
    }

    [Signature("<T:Ljava/lang/Object;>(Ljava/util/Map<Ljava/lang/Class<*>;Ljava/util/List<TT;>;>;Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Ljava/util/List<TT;>;")]
    [LineNumberTable(new byte[] {(byte) 32, (byte) 105, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private List getAnnotatedMembers([In] Map obj0, [In] Class obj1)
    {
      if (!obj0.containsKey((object) obj1))
        obj0.put((object) obj1, (object) new ArrayList());
      return (List) obj0.get((object) obj1);
    }

    [Signature("(Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;)Z")]
    [LineNumberTable((ushort) 88)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool runsTopToBottom([In] Class obj0)
    {
      return Object.instancehelper_equals((object) obj0, (object) ClassLiteral<Before>.Value) || Object.instancehelper_equals((object) obj0, (object) ClassLiteral<BeforeClass>.Value);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (TestClass.__\u003CcallerID\u003E == null)
        TestClass.__\u003CcallerID\u003E = (CallerID) new TestClass.__\u003CCallerID\u003E();
      return TestClass.__\u003CcallerID\u003E;
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
