// Decompiled with JetBrains decompiler
// Type: com.googlecode.javacpp.annotation.Function
// Assembly: javacpp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 045C9A9A-CAC1-44AC-9FF2-036C0A7C9747
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\javacpp.dll

using IKVM.Attributes;
using java.lang.annotation;

namespace com.googlecode.javacpp.annotation
{
  [Implements(new string[] {"java.lang.annotation.Annotation"})]
  [Modifiers]
  [AnnotationAttribute("com.googlecode.javacpp.annotation.FunctionAttribute")]
  [Retention(new object[] {(byte) 64, "Ljava/lang/annotation/Retention;", "value", new object[] {(byte) 101, "Ljava/lang/annotation/RetentionPolicy, IKVM/OpenJDK/Core, Version=7/2/4630/5, Culture=neutral, PublicKeyToken=13235d27fcbfff58;", "RUNTIME"}})]
  [Target(new object[] {(byte) 64, "Ljava/lang/annotation/Target;", "value", new object[] {(byte) 91, new object[] {(byte) 101, "Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=7/2/4630/5, Culture=neutral, PublicKeyToken=13235d27fcbfff58;", "METHOD"}}})]
  public interface Function : Annotation
  {
  }
}
