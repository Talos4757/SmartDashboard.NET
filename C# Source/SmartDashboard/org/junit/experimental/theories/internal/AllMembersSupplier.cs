// Decompiled with JetBrains decompiler
// Type: org.junit.experimental.theories.internal.AllMembersSupplier
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util;
using org.junit.experimental.theories;
using org.junit.experimental.theories.@internal;
using org.junit.runners.model;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.junit.experimental.theories.@internal
{
  public class AllMembersSupplier : ParameterSupplier
  {
    [Modifiers]
    private TestClass fClass;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 8, (byte) 104, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AllMembersSupplier(TestClass type)
    {
      AllMembersSupplier allMembersSupplier = this;
      this.fClass = type;
    }

    [Signature("(Lorg/junit/experimental/theories/ParameterSignature;Ljava/util/List<Lorg/junit/experimental/theories/PotentialAssignment;>;)V")]
    [LineNumberTable(new byte[] {(byte) 45, (byte) 127, (byte) 7, (byte) 112, (byte) 104, (byte) 151, (byte) 118, (byte) 151, (byte) 249, (byte) 56, (byte) 233, (byte) 77})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void addFields([In] ParameterSignature obj0, [In] List obj1)
    {
      Field[] fields = this.fClass.getJavaClass().getFields(AllMembersSupplier.__\u003CGetCallerID\u003E());
      int length = fields.Length;
      for (int index = 0; index < length; ++index)
      {
        Field field = fields[index];
        if (Modifier.isStatic(field.getModifiers()))
        {
          Class type = field.getType();
          if (obj0.canAcceptArrayType(type) && field.getAnnotation((Class) ClassLiteral<DataPoints>.Value) != null)
            this.addArrayValues(field.getName(), obj1, this.getStaticFieldValue(field));
          else if (obj0.canAcceptType(type) && field.getAnnotation((Class) ClassLiteral<DataPoint>.Value) != null)
            obj1.add((object) PotentialAssignment.forValue(field.getName(), this.getStaticFieldValue(field)));
        }
      }
    }

    [Signature("(Lorg/junit/experimental/theories/ParameterSignature;Ljava/util/List<Lorg/junit/experimental/theories/PotentialAssignment;>;)V")]
    [LineNumberTable(new byte[] {(byte) 36, (byte) 127, (byte) 11, (byte) 103, (byte) 105, (byte) 110, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void addSinglePointMethods([In] ParameterSignature obj0, [In] List obj1)
    {
      Iterator iterator = this.fClass.getAnnotatedMethods((Class) ClassLiteral<DataPoint>.Value).iterator();
      while (iterator.hasNext())
      {
        FrameworkMethod frameworkMethod = (FrameworkMethod) iterator.next();
        Class type = obj0.getType();
        if (frameworkMethod.producesType(type))
          obj1.add((object) new AllMembersSupplier.MethodParameterValue(frameworkMethod, (AllMembersSupplier.\u0031) null));
      }
    }

    [Signature("(Ljava/util/List<Lorg/junit/experimental/theories/PotentialAssignment;>;)V")]
    [LineNumberTable(new byte[] {(byte) 25, (byte) 159, (byte) 11, (byte) 191, (byte) 12, (byte) 2, (byte) 129, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void addMultiPointMethods([In] List obj0)
    {
      Iterator iterator = this.fClass.getAnnotatedMethods((Class) ClassLiteral<DataPoints>.Value).iterator();
      while (iterator.hasNext())
      {
        FrameworkMethod frameworkMethod = (FrameworkMethod) iterator.next();
        try
        {
          this.addArrayValues(frameworkMethod.getName(), obj0, frameworkMethod.invokeExplosively((object) null));
        }
        catch (Exception ex)
        {
          int num = 2;
          ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        }
      }
    }

    [Signature("(Ljava/lang/String;Ljava/util/List<Lorg/junit/experimental/theories/PotentialAssignment;>;Ljava/lang/Object;)V")]
    [LineNumberTable(new byte[] {(byte) 61, (byte) 107, (byte) 63, (byte) 30, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void addArrayValues([In] string obj0, [In] List obj1, [In] object obj2)
    {
      for (int index = 0; index < Array.getLength(obj2); ++index)
        obj1.add((object) PotentialAssignment.forValue(new StringBuilder().append(obj0).append("[").append(index).append("]").toString(), Array.get(obj2, index)));
    }

    [LineNumberTable(new byte[] {(byte) 67, (byte) 127, (byte) 1, (byte) 97, (byte) 144, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private object getStaticFieldValue([In] Field obj0)
    {
      object obj;
      try
      {
        try
        {
          obj = obj0.get((object) null, AllMembersSupplier.__\u003CGetCallerID\u003E());
        }
        catch (IllegalArgumentException ex)
        {
          goto label_4;
        }
      }
      catch (IllegalAccessException ex)
      {
        goto label_5;
      }
      return obj;
label_4:
      string str1 = "unexpected: field from getClass doesn't exist on object";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new RuntimeException(str1);
label_5:
      string str2 = "unexpected: getFields returned an inaccessible field";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new RuntimeException(str2);
    }

    [Signature("(Lorg/junit/experimental/theories/ParameterSignature;)Ljava/util/List<Lorg/junit/experimental/theories/PotentialAssignment;>;")]
    [LineNumberTable(new byte[] {(byte) 14, (byte) 134, (byte) 104, (byte) 104, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override List getValueSources(ParameterSignature sig)
    {
      ArrayList arrayList = new ArrayList();
      this.addFields(sig, (List) arrayList);
      this.addSinglePointMethods(sig, (List) arrayList);
      this.addMultiPointMethods((List) arrayList);
      return (List) arrayList;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (AllMembersSupplier.__\u003CcallerID\u003E == null)
        AllMembersSupplier.__\u003CcallerID\u003E = (CallerID) new AllMembersSupplier.__\u003CCallerID\u003E();
      return AllMembersSupplier.__\u003CcallerID\u003E;
    }

    [InnerClass]
    [EnclosingMethod("org.junit.experimental.theories.internal.AllMembersSupplier", null, null)]
    [SourceFile("AllMembersSupplier.java")]
    [Modifiers]
    internal sealed class \u0031 : Object
    {
      \u0031()
      {
        throw null;
      }
    }

    [InnerClass]
    [SourceFile("AllMembersSupplier.java")]
    [Modifiers]
    internal sealed class MethodParameterValue : PotentialAssignment
    {
      [Modifiers]
      private FrameworkMethod fMethod;

      [Modifiers]
      [LineNumberTable((ushort) 24)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal MethodParameterValue([In] FrameworkMethod obj0, [In] AllMembersSupplier.\u0031 obj1)
        : this(obj0)
      {
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 169, (byte) 104, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private MethodParameterValue([In] FrameworkMethod obj0)
      {
        AllMembersSupplier.MethodParameterValue methodParameterValue = this;
        this.fMethod = obj0;
      }

      [Throws(new string[] {"org.junit.experimental.theories.PotentialAssignment$CouldNotGenerateValueException"})]
      [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 127, (byte) 18, (byte) 97, (byte) 144, (byte) 97, (byte) 144, (byte) 97})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override object getValue()
      {
        object obj;
        try
        {
          try
          {
            try
            {
              obj = this.fMethod.invokeExplosively((object) null);
            }
            catch (IllegalArgumentException ex)
            {
              goto label_5;
            }
          }
          catch (IllegalAccessException ex)
          {
            goto label_6;
          }
        }
        catch (Exception ex)
        {
          int num = 2;
          ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
          goto label_7;
        }
        return obj;
label_5:
        string str1 = "unexpected: argument length is checked";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str1);
label_6:
        string str2 = "unexpected: getMethods returned an inaccessible method";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str2);
label_7:
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new PotentialAssignment.CouldNotGenerateValueException();
      }

      [Throws(new string[] {"org.junit.experimental.theories.PotentialAssignment$CouldNotGenerateValueException"})]
      [LineNumberTable((ushort) 49)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override string getDescription()
      {
        return this.fMethod.getName();
      }
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
