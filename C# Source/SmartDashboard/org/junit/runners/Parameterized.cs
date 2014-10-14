// Decompiled with JetBrains decompiler
// Type: org.junit.runners.Parameterized
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.annotation;
using java.lang.reflect;
using java.util;
using org.junit.runner.notification;
using org.junit.runners.model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runners
{
  public class Parameterized : Suite
  {
    [Modifiers]
    [Signature("Ljava/util/ArrayList<Lorg/junit/runner/Runner;>;")]
    private ArrayList runners;

    [Throws(new string[] {"java.lang.Throwable"})]
    [Signature("(Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 79, (byte) 238, (byte) 58, (byte) 235, (byte) 71, (byte) 109, (byte) 107, (byte) 63, (byte) 0, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Parameterized(Class klass)
      : base(klass, Collections.emptyList())
    {
      Parameterized parameterized = this;
      this.runners = new ArrayList();
      List parametersList = this.getParametersList(this.getTestClass());
      for (int index = 0; index < parametersList.size(); ++index)
        this.runners.add((object) new Parameterized.TestClassRunnerForParameters(this, this.getTestClass().getJavaClass(), parametersList, index));
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 100, (byte) 140, (byte) 123, (byte) 108, (byte) 112, (byte) 98, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private FrameworkMethod getParametersMethod([In] TestClass obj0)
    {
      Iterator iterator = obj0.getAnnotatedMethods((Class) ClassLiteral<Parameterized.Parameters>.Value).iterator();
      while (iterator.hasNext())
      {
        FrameworkMethod frameworkMethod = (FrameworkMethod) iterator.next();
        int modifiers = frameworkMethod.getMethod().getModifiers();
        if (Modifier.isStatic(modifiers) && Modifier.isPublic(modifiers))
          return frameworkMethod;
      }
      string str = new StringBuilder().append("No public static parameters method on class ").append(obj0.getName()).toString();
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new Exception(str);
    }

    [Throws(new string[] {"java.lang.Throwable"})]
    [Signature("(Lorg/junit/runners/model/TestClass;)Ljava/util/List<[Ljava/lang/Object;>;")]
    [LineNumberTable((ushort) 144)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private List getParametersList([In] TestClass obj0)
    {
      return (List) this.getParametersMethod(obj0).invokeExplosively((object) null);
    }

    [Signature("()Ljava/util/List<Lorg/junit/runner/Runner;>;")]
    protected internal override List getChildren()
    {
      return (List) this.runners;
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [Modifiers]
    [LineNumberTable((ushort) 61)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static FrameworkMethod access\u0024000([In] Parameterized obj0, [In] TestClass obj1)
    {
      return obj0.getParametersMethod(obj1);
    }

    [InnerClass]
    [Implements(new string[] {"java.lang.annotation.Annotation"})]
    [SourceFile("Parameterized.java")]
    [Modifiers]
    [AnnotationAttribute("org.junit.runners.Parameterized+ParametersAttribute")]
    [Retention(new object[] {(byte) 64, "Ljava/lang/annotation/Retention;", "value", new object[] {(byte) 101, "Ljava/lang/annotation/RetentionPolicy, IKVM/OpenJDK/Core, Version=7/2/4630/5, Culture=neutral, PublicKeyToken=13235d27fcbfff58;", "RUNTIME"}})]
    [Target(new object[] {(byte) 64, "Ljava/lang/annotation/Target;", "value", new object[] {(byte) 91, new object[] {(byte) 101, "Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=7/2/4630/5, Culture=neutral, PublicKeyToken=13235d27fcbfff58;", "METHOD"}}})]
    public interface Parameters : Annotation
    {
    }

    [InnerClass]
    [SourceFile("Parameterized.java")]
    [Modifiers]
    internal sealed class TestClassRunnerForParameters : BlockJUnit4ClassRunner
    {
      [Modifiers]
      internal Parameterized this\u00240 = obj0;
      [Modifiers]
      private int fParameterSetNumber;
      [Modifiers]
      [Signature("Ljava/util/List<[Ljava/lang/Object;>;")]
      private List fParameterList;
      [SpecialName]
      private static CallerID __\u003CcallerID\u003E;

      [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
      [Signature("(Ljava/lang/Class<*>;Ljava/util/List<[Ljava/lang/Object;>;I)V")]
      [LineNumberTable(new byte[] {(byte) 28, (byte) 103, (byte) 105, (byte) 103, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal TestClassRunnerForParameters([In] Parameterized obj0, [In] Class obj1, [In] List obj2, [In] int obj3)
        : base(obj1)
      {
        Parameterized.TestClassRunnerForParameters runnerForParameters = this;
        this.fParameterList = obj2;
        this.fParameterSetNumber = obj3;
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable(new byte[] {(byte) 42, (byte) 127, (byte) 16, (byte) 97})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private object[] computeParams()
      {
        object[] objArray1;
        try
        {
          objArray1 = (object[]) this.fParameterList.get(this.fParameterSetNumber);
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<ClassCastException>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
          else
            goto label_4;
        }
        return objArray1;
label_4:
        string str1 = "%s.%s() must return a Collection of arrays.";
        object[] objArray2 = new object[2];
        int index1 = 0;
        string name1 = this.getTestClass().getName();
        objArray2[index1] = (object) name1;
        int index2 = 1;
        string name2 = Parameterized.access\u0024000(this.this\u00240, this.getTestClass()).getName();
        objArray2[index2] = (object) name2;
        string str2 = String.format(str1, objArray2);
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new Exception(str2);
      }

      [Throws(new string[] {"java.lang.Exception"})]
      [LineNumberTable((ushort) 86)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override object createTest()
      {
        return this.getTestClass().getOnlyConstructor().newInstance(this.computeParams(), Parameterized.TestClassRunnerForParameters.__\u003CGetCallerID\u003E());
      }

      [LineNumberTable((ushort) 103)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal override string getName()
      {
        string str = "[%s]";
        object[] objArray = new object[1];
        int index = 0;
        Integer integer = Integer.valueOf(this.fParameterSetNumber);
        objArray[index] = (object) integer;
        return String.format(str, objArray);
      }

      [LineNumberTable((ushort) 108)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal override string testName([In] FrameworkMethod obj0)
      {
        string str = "%s[%s]";
        object[] objArray = new object[2];
        int index1 = 0;
        string name = obj0.getName();
        objArray[index1] = (object) name;
        int index2 = 1;
        Integer integer = Integer.valueOf(this.fParameterSetNumber);
        objArray[index2] = (object) integer;
        return String.format(str, objArray);
      }

      [Signature("(Ljava/util/List<Ljava/lang/Throwable;>;)V")]
      [LineNumberTable(new byte[] {(byte) 64, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal override void validateConstructor([In] List obj0)
      {
        this.validateOnlyOneConstructor(obj0);
      }

      [LineNumberTable((ushort) 119)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal override Statement classBlock([In] RunNotifier obj0)
      {
        return this.childrenInvoker(obj0);
      }

      [SpecialName]
      private static CallerID __\u003CGetCallerID\u003E()
      {
        if (Parameterized.TestClassRunnerForParameters.__\u003CcallerID\u003E == null)
          Parameterized.TestClassRunnerForParameters.__\u003CcallerID\u003E = (CallerID) new Parameterized.TestClassRunnerForParameters.__\u003CCallerID\u003E();
        return Parameterized.TestClassRunnerForParameters.__\u003CcallerID\u003E;
      }

      private sealed class __\u003CCallerID\u003E : CallerID
      {
        internal __\u003CCallerID\u003E()
        {
          base.\u002Ector();
        }
      }
    }

    [Modifiers]
    [InnerClass]
    [Implements(new string[] {"org.junit.runners.Parameterized$Parameters"})]
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class ParametersAttribute : AnnotationAttributeBase, Parameterized.Parameters
    {
      [EditorBrowsable(EditorBrowsableState.Never)]
      public ParametersAttribute([In] object[] obj0)
        : this()
      {
        this.setDefinition(obj0);
      }

      public ParametersAttribute()
      {
        base.\u002Ector((Class) ClassLiteral<Parameterized.Parameters>.Value);
      }
    }
  }
}
