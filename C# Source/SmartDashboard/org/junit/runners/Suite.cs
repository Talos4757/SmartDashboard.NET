// Decompiled with JetBrains decompiler
// Type: org.junit.runners.Suite
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.lang.annotation;
using java.util;
using org.junit.@internal.builders;
using org.junit.runner;
using org.junit.runner.notification;
using org.junit.runners.model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.runners
{
  [Signature("Lorg/junit/runners/ParentRunner<Lorg/junit/runner/Runner;>;")]
  public class Suite : ParentRunner
  {
    [Modifiers]
    [Signature("Ljava/util/List<Lorg/junit/runner/Runner;>;")]
    private List fRunners;

    [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
    [Signature("(Lorg/junit/runners/model/RunnerBuilder;[Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 29, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Suite(RunnerBuilder builder, Class[] classes)
      : this((Class) null, builder.runners((Class) null, classes))
    {
    }

    [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
    [Signature("(Ljava/lang/Class<*>;[Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 39, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Suite(Class klass, Class[] suiteClasses)
      : this((RunnerBuilder) new AllDefaultPossibilitiesBuilder(true), klass, suiteClasses)
    {
    }

    [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
    [Signature("(Lorg/junit/runners/model/RunnerBuilder;Ljava/lang/Class<*>;[Ljava/lang/Class<*>;)V")]
    [LineNumberTable(new byte[] {(byte) 51, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Suite(RunnerBuilder builder, Class klass, Class[] suiteClasses)
      : this(klass, builder.runners(klass, suiteClasses))
    {
    }

    [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
    [Signature("(Ljava/lang/Class<*>;Ljava/util/List<Lorg/junit/runner/Runner;>;)V")]
    [LineNumberTable(new byte[] {(byte) 62, (byte) 105, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal Suite(Class klass, List runners)
      : base(klass)
    {
      Suite suite = this;
      this.fRunners = runners;
    }

    [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
    [Signature("(Ljava/lang/Class<*>;Lorg/junit/runners/model/RunnerBuilder;)V")]
    [LineNumberTable(new byte[] {(byte) 17, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Suite(Class klass, RunnerBuilder builder)
      : this(builder, klass, Suite.getAnnotatedClasses(klass))
    {
    }

    [Throws(new string[] {"org.junit.runners.model.InitializationError"})]
    [Signature("(Ljava/lang/Class<*>;)[Ljava/lang/Class<*>;")]
    [LineNumberTable(new byte[] {(byte) 1, (byte) 113, (byte) 99, (byte) 127, (byte) 5})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Class[] getAnnotatedClasses([In] Class obj0)
    {
      Suite.SuiteClasses suiteClasses = (Suite.SuiteClasses) obj0.getAnnotation((Class) ClassLiteral<Suite.SuiteClasses>.Value);
      if (suiteClasses == null)
      {
        string str = "class '%s' must have a SuiteClasses annotation";
        object[] objArray = new object[1];
        int index = 0;
        string name = obj0.getName();
        objArray[index] = (object) name;
        string @string = String.format(str, objArray);
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new InitializationError(@string);
      }
      else
        return suiteClasses.value();
    }

    [LineNumberTable(new byte[] {(byte) 78, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void runChild(Runner runner, RunNotifier notifier)
    {
      runner.run(notifier);
    }

    [LineNumberTable((ushort) 123)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual Description describeChild(Runner child)
    {
      return child.getDescription();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 172, (byte) 127, (byte) 1, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Runner emptySuite()
    {
      Suite suite;
      try
      {
        suite = new Suite((Class) null, new Class[0]);
      }
      catch (InitializationError ex)
      {
        goto label_3;
      }
      return (Runner) suite;
label_3:
      string str = "This shouldn't be possible";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new RuntimeException(str);
    }

    [Signature("()Ljava/util/List<Lorg/junit/runner/Runner;>;")]
    protected internal override List getChildren()
    {
      return this.fRunners;
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 24)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override void runChild(object x0, RunNotifier x1)
    {
      this.runChild((Runner) x0, x1);
    }

    [Modifiers]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [LineNumberTable((ushort) 24)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override Description describeChild(object x0)
    {
      return this.describeChild((Runner) x0);
    }

    [InnerClass]
    [Implements(new string[] {"java.lang.annotation.Annotation"})]
    [SourceFile("Suite.java")]
    [Modifiers]
    [AnnotationAttribute("org.junit.runners.Suite+SuiteClassesAttribute")]
    [Retention(new object[] {(byte) 64, "Ljava/lang/annotation/Retention;", "value", new object[] {(byte) 101, "Ljava/lang/annotation/RetentionPolicy, IKVM/OpenJDK/Core, Version=7/2/4630/5, Culture=neutral, PublicKeyToken=13235d27fcbfff58;", "RUNTIME"}})]
    [Target(new object[] {(byte) 64, "Ljava/lang/annotation/Target;", "value", new object[] {(byte) 91, new object[] {(byte) 101, "Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=7/2/4630/5, Culture=neutral, PublicKeyToken=13235d27fcbfff58;", "TYPE"}}})]
    [Inherited(new object[] {(byte) 64, "Ljava/lang/annotation/Inherited;"})]
    public interface SuiteClasses : Annotation
    {
      [Signature("()[Ljava/lang/Class<*>;")]
      Class[] value();
    }

    [Modifiers]
    [InnerClass]
    [Implements(new string[] {"org.junit.runners.Suite$SuiteClasses"})]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
    public sealed class SuiteClassesAttribute : AnnotationAttributeBase, Suite.SuiteClasses
    {
      [EditorBrowsable(EditorBrowsableState.Never)]
      public SuiteClassesAttribute([In] object[] obj0)
        : this()
      {
        this.setDefinition(obj0);
      }

      private SuiteClassesAttribute()
      {
        base.\u002Ector((Class) ClassLiteral<Suite.SuiteClasses>.Value);
      }

      [HideFromJava]
      public SuiteClassesAttribute(Type[] value)
        : this()
      {
        this.setValue("value", (object) value);
      }

      Class[] Suite.SuiteClasses.value()
      {
        return (Class[]) this.getValue("value");
      }
    }
  }
}
