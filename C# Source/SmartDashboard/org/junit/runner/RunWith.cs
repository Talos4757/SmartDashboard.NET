// Decompiled with JetBrains decompiler
// Type: org.junit.runner.RunWith
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.lang.annotation;

namespace org.junit.runner
{
  [Implements(new string[] {"java.lang.annotation.Annotation"})]
  [Modifiers]
  [AnnotationAttribute("org.junit.runner.RunWithAttribute")]
  [Retention(new object[] {(byte) 64, "Ljava/lang/annotation/Retention;", "value", new object[] {(byte) 101, "Ljava/lang/annotation/RetentionPolicy, IKVM/OpenJDK/Core, Version=7/2/4630/5, Culture=neutral, PublicKeyToken=13235d27fcbfff58;", "RUNTIME"}})]
  [Target(new object[] {(byte) 64, "Ljava/lang/annotation/Target;", "value", new object[] {(byte) 91, new object[] {(byte) 101, "Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=7/2/4630/5, Culture=neutral, PublicKeyToken=13235d27fcbfff58;", "TYPE"}}})]
  [Inherited(new object[] {(byte) 64, "Ljava/lang/annotation/Inherited;"})]
  public interface RunWith : Annotation
  {
    [Signature("()Ljava/lang/Class<+Lorg/junit/runner/Runner;>;")]
    Class value();
  }
}
