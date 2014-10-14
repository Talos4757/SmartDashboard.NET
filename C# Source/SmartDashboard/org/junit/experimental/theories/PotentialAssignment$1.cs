// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.PotentialAssignment$1
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental.theories
{
  [InnerClass]
  [EnclosingMethod("org.junit.experimental.theories.PotentialAssignment", "forValue", "(Ljava.lang.String;Ljava.lang.Object;)Lorg.junit.experimental.theories.PotentialAssignment;")]
  [SourceFile("PotentialAssignment.java")]
  [Modifiers]
  internal sealed class PotentialAssignment\u00241 : PotentialAssignment
  {
    [Modifiers]
    internal object val\u0024value = obj0;
    [Modifiers]
    internal string val\u0024name = obj1;

    [LineNumberTable((ushort) 21)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal PotentialAssignment\u00241([In] object obj0, [In] string obj1)
    {
    }

    [Throws(new string[] {"org.junit.experimental.theories.PotentialAssignment$CouldNotGenerateValueException"})]
    public override object getValue()
    {
      return this.val\u0024value;
    }

    [LineNumberTable((ushort) 17)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string toString()
    {
      string str = "[%s]";
      object[] objArray = new object[1];
      int index = 0;
      object obj = this.val\u0024value;
      objArray[index] = obj;
      return String.format(str, objArray);
    }

    [Throws(new string[] {"org.junit.experimental.theories.PotentialAssignment$CouldNotGenerateValueException"})]
    public override string getDescription()
    {
      return this.val\u0024name;
    }
  }
}
