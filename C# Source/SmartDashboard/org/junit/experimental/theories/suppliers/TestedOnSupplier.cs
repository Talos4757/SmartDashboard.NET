// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.suppliers.TestedOnSupplier
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.util;
using org.junit.experimental.theories;
using System.Runtime.CompilerServices;

namespace org.junit.experimental.theories.suppliers
{
  public class TestedOnSupplier : ParameterSupplier
  {
    [LineNumberTable((ushort) 13)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestedOnSupplier()
    {
    }

    [Signature("(Lorg/junit/experimental/theories/ParameterSignature;)Ljava/util/List<Lorg/junit/experimental/theories/PotentialAssignment;>;")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 157, (byte) 102, (byte) 113, (byte) 103, (byte) 117, (byte) 63, (byte) 8, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override List getValueSources(ParameterSignature sig)
    {
      ArrayList arrayList1 = new ArrayList();
      int[] numArray1 = ((TestedOn) sig.getAnnotation((Class) ClassLiteral<TestedOn>.Value)).ints();
      int[] numArray2 = numArray1;
      int length = numArray2.Length;
      for (int index1 = 0; index1 < length; ++index1)
      {
        int num = numArray2[index1];
        ArrayList arrayList2 = arrayList1;
        int[][] numArray3 = new int[1][];
        int index2 = 0;
        int[] numArray4 = numArray1;
        numArray3[index2] = numArray4;
        PotentialAssignment potentialAssignment = PotentialAssignment.forValue(Object.instancehelper_toString((object) Arrays.asList((object[]) numArray3)), (object) Integer.valueOf(num));
        ((List) arrayList2).add((object) potentialAssignment);
      }
      return (List) arrayList1;
    }
  }
}
