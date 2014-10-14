// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.DataPoint
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang.annotation;

namespace org.junit.experimental.theories
{
  [Implements(new string[] {"java.lang.annotation.Annotation"})]
  [Modifiers]
  [AnnotationAttribute("org.junit.experimental.theories.DataPointAttribute")]
  [Retention(new object[] {(byte) 64, "Ljava/lang/annotation/Retention;", "value", new object[] {(byte) 101, "Ljava/lang/annotation/RetentionPolicy, IKVM/OpenJDK/Core, Version=7/2/4630/5, Culture=neutral, PublicKeyToken=13235d27fcbfff58;", "RUNTIME"}})]
  public interface DataPoint : Annotation
  {
  }
}
