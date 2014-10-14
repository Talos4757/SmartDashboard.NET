// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.internal.Assignments
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using java.util;
using org.junit.experimental.theories;
using org.junit.experimental.theories.@internal;
using org.junit.runners.model;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental.theories.@internal
{
  public class Assignments : Object
  {
    [Signature("Ljava/util/List<Lorg/junit/experimental/theories/PotentialAssignment;>;")]
    private List fAssigned;
    [Modifiers]
    [Signature("Ljava/util/List<Lorg/junit/experimental/theories/ParameterSignature;>;")]
    private List fUnassigned;
    [Modifiers]
    private TestClass fClass;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [Signature("(Ljava/util/List<Lorg/junit/experimental/theories/PotentialAssignment;>;Ljava/util/List<Lorg/junit/experimental/theories/ParameterSignature;>;Lorg/junit/runners/model/TestClass;)V")]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 171, (byte) 104, (byte) 103, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Assignments([In] List obj0, [In] List obj1, [In] TestClass obj2)
    {
      base.\u002Ector();
      Assignments assignments = this;
      this.fUnassigned = obj1;
      this.fAssigned = obj0;
      this.fClass = obj2;
    }

    [Throws(new string[] {"org.junit.experimental.theories.PotentialAssignment$CouldNotGenerateValueException"})]
    [LineNumberTable(new byte[] {(byte) 77, (byte) 113, (byte) 103, (byte) 57, (byte) 166})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object[] getArgumentStrings(bool nullsOk)
    {
      object[] objArray = new object[this.fAssigned.size()];
      for (int index = 0; index < objArray.Length; ++index)
        objArray[index] = (object) ((PotentialAssignment) this.fAssigned.get(index)).getDescription();
      return objArray;
    }

    [Throws(new string[] {"org.junit.experimental.theories.PotentialAssignment$CouldNotGenerateValueException"})]
    [LineNumberTable((ushort) 104)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object[] getConstructorArguments(bool nullsOk)
    {
      return this.getActualValues(0, this.getConstructorParameterCount(), nullsOk);
    }

    [Throws(new string[] {"org.junit.experimental.theories.PotentialAssignment$CouldNotGenerateValueException"})]
    [LineNumberTable((ushort) 109)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object[] getMethodArguments(bool nullsOk)
    {
      return this.getActualValues(this.getConstructorParameterCount(), this.fAssigned.size(), nullsOk);
    }

    [Throws(new string[] {"java.lang.Exception"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 184, (byte) 140, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Assignments allUnassigned(Method testMethod, TestClass testClass)
    {
      List list = ParameterSignature.signatures(testClass.getOnlyConstructor());
      list.addAll((Collection) ParameterSignature.signatures(testMethod));
      return new Assignments((List) new ArrayList(), list, testClass);
    }

    [LineNumberTable((ushort) 50)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isComplete()
    {
      return this.fUnassigned.size() == 0;
    }

    [Throws(new string[] {"java.lang.InstantiationException", "java.lang.IllegalAccessException"})]
    [Signature("()Ljava/util/List<Lorg/junit/experimental/theories/PotentialAssignment;>;")]
    [LineNumberTable(new byte[] {(byte) 30, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual List potentialsForNextUnassigned()
    {
      ParameterSignature parameterSignature = this.nextUnassigned();
      return this.getSupplier(parameterSignature).getValueSources(parameterSignature);
    }

    [LineNumberTable(new byte[] {(byte) 8, (byte) 140, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Assignments assignNext(PotentialAssignment source)
    {
      ArrayList arrayList = new ArrayList((Collection) this.fAssigned);
      ((List) arrayList).add((object) source);
      return new Assignments((List) arrayList, this.fUnassigned.subList(1, this.fUnassigned.size()), this.fClass);
    }

    [LineNumberTable((ushort) 54)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ParameterSignature nextUnassigned()
    {
      return (ParameterSignature) this.fUnassigned.get(0);
    }

    [Throws(new string[] {"java.lang.InstantiationException", "java.lang.IllegalAccessException"})]
    [LineNumberTable(new byte[] {(byte) 36, (byte) 104, (byte) 99, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ParameterSupplier getSupplier(ParameterSignature unassigned)
    {
      ParameterSupplier annotatedSupplier = this.getAnnotatedSupplier(unassigned);
      if (annotatedSupplier != null)
        return annotatedSupplier;
      return (ParameterSupplier) new AllMembersSupplier(this.fClass);
    }

    [Throws(new string[] {"java.lang.InstantiationException", "java.lang.IllegalAccessException"})]
    [LineNumberTable(new byte[] {(byte) 45, (byte) 145, (byte) 99, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual ParameterSupplier getAnnotatedSupplier(ParameterSignature unassigned)
    {
      ParametersSuppliedBy parametersSuppliedBy = (ParametersSuppliedBy) unassigned.findDeepAnnotation((Class) ClassLiteral<ParametersSuppliedBy>.Value);
      if (parametersSuppliedBy == null)
        return (ParameterSupplier) null;
      else
        return (ParameterSupplier) parametersSuppliedBy.value().newInstance(Assignments.__\u003CGetCallerID\u003E());
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 145, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private int getConstructorParameterCount()
    {
      return ParameterSignature.signatures(this.fClass.getOnlyConstructor()).size();
    }

    [Throws(new string[] {"org.junit.experimental.theories.PotentialAssignment$CouldNotGenerateValueException"})]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 125, (byte) 66, (byte) 105, (byte) 102, (byte) 119, (byte) 102, (byte) 107, (byte) 230, (byte) 60, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object[] getActualValues(int start, int stop, bool nullsOk)
    {
      int num = nullsOk ? 1 : 0;
      object[] objArray = new object[stop - start];
      for (int index = start; index < stop; ++index)
      {
        object obj = ((PotentialAssignment) this.fAssigned.get(index)).getValue();
        if (obj == null && num == 0)
        {
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new PotentialAssignment.CouldNotGenerateValueException();
        }
        else
          objArray[index - start] = obj;
      }
      return objArray;
    }

    [Throws(new string[] {"org.junit.experimental.theories.PotentialAssignment$CouldNotGenerateValueException"})]
    [LineNumberTable((ushort) 115)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object[] getAllArguments(bool nullsOk)
    {
      return this.getActualValues(0, this.fAssigned.size(), nullsOk);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (Assignments.__\u003CcallerID\u003E == null)
        Assignments.__\u003CcallerID\u003E = (CallerID) new Assignments.__\u003CCallerID\u003E();
      return Assignments.__\u003CcallerID\u003E;
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
