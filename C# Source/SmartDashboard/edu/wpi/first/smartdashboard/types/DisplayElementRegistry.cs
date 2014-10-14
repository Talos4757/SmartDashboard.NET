// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.types.DisplayElementRegistry
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui.elements;
using edu.wpi.first.smartdashboard.livewindow.elements;
using edu.wpi.first.smartdashboard.types.named;
using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace edu.wpi.first.smartdashboard.types
{
  public class DisplayElementRegistry : Object
  {
    [Modifiers]
    internal static bool \u0024assertionsDisabled = !((Class) ClassLiteral<DisplayElementRegistry>.Value).desiredAssertionStatus();
    [Modifiers]
    [Signature("Ljava/util/Set<Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/StaticWidget;>;>;")]
    private static Set staticWidgets = (Set) new LinkedHashSet();
    [Modifiers]
    [Signature("Ljava/util/Map<Ledu/wpi/first/smartdashboard/types/DataType;Ljava/util/Set<Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/Widget;>;>;>;")]
    private static Map map = (Map) new HashMap();
    [Modifiers]
    [Signature("Ljava/util/Map<Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/Widget;>;[Ledu/wpi/first/smartdashboard/types/DataType;>;")]
    private static Map declaredTypes = (Map) new HashMap();
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 164, (byte) 181, (byte) 170, (byte) 170, (byte) 234, (byte) 72, (byte) 101, (byte) 229, (byte) 69, (byte) 102, (byte) 102})]
    static DisplayElementRegistry()
    {
      DefaultDisplayElementRegistrar.init();
      LiveWindowWidgetRegistrar.init();
      PIDCommandType.get();
      PIDSubsystemType.get();
    }

    [LineNumberTable((ushort) 22)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DisplayElementRegistry()
    {
      base.\u002Ector();
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [Signature("(Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/Widget;>;)V")]
    [LineNumberTable(new byte[] {(byte) 39, (byte) 109, (byte) 161, (byte) 162, (byte) 113, (byte) 103, (byte) 104, (byte) 112, (byte) 104, (byte) 144, (byte) 119, (byte) 255, (byte) 30, (byte) 76, (byte) 226, (byte) 53, (byte) 97, (byte) 242, (byte) 74, (byte) 226, (byte) 55, (byte) 97, (byte) 112, (byte) 97, (byte) 112, (byte) 98, (byte) 103, (byte) 97, (byte) 97, (byte) 176, (byte) 99, (byte) 176, (byte) 121, (byte) 115, (byte) 105, (byte) 149, (byte) 255, (byte) 1, (byte) 59, (byte) 235, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void registerWidget(Class clazz)
    {
      if (Modifier.isAbstract(clazz.getModifiers()))
        return;
      DataType[] dataTypeArray1 = (DataType[]) null;
      SecurityException securityException;
      try
      {
        try
        {
          try
          {
            try
            {
              try
              {
                Field declaredField = clazz.getDeclaredField("TYPES", DisplayElementRegistry.__\u003CGetCallerID\u003E());
                int modifiers = declaredField.getModifiers();
                if (!Modifier.isStatic(modifiers))
                {
                  string str = "TYPES must be static";
                  Throwable.__\u003CsuppressFillInStackTrace\u003E();
                  throw new RuntimeException(str);
                }
                else if (!Modifier.isFinal(modifiers))
                {
                  string str = "TYPES must be final";
                  Throwable.__\u003CsuppressFillInStackTrace\u003E();
                  throw new RuntimeException(str);
                }
                else
                {
                  dataTypeArray1 = (DataType[]) declaredField.get((object) null, DisplayElementRegistry.__\u003CGetCallerID\u003E());
                  DisplayElementRegistry.declaredTypes.put((object) clazz, (object) dataTypeArray1);
                  goto label_22;
                }
              }
              catch (IllegalArgumentException ex)
              {
              }
            }
            catch (IllegalAccessException ex)
            {
              goto label_15;
            }
          }
          catch (NoSuchFieldException ex)
          {
            goto label_16;
          }
        }
        catch (SecurityException ex)
        {
          int num = 1;
          securityException = (SecurityException) ByteCodeHelper.MapException<SecurityException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
          goto label_17;
        }
      }
      catch (Exception ex)
      {
        int num = 2;
        if (ByteCodeHelper.MapException<ClassCastException>(ex, (ByteCodeHelper.MapFlags) num) == null)
          throw;
        else
          goto label_18;
      }
      if (!DisplayElementRegistry.\u0024assertionsDisabled)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new AssertionError();
      }
      else
        goto label_22;
label_15:
      string str1 = "TYPES must be public";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new RuntimeException(str1);
label_16:
      string str2 = "Every ValueBasedDisplayElement must have a TYPES static field of type DataType[]";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new RuntimeException(str2);
label_17:
      Throwable.instancehelper_printStackTrace((Exception) securityException);
      return;
label_18:
      string str3 = "TYPES must be of type Type[]";
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new RuntimeException(str3);
label_22:
      if (dataTypeArray1 == null)
      {
        string str4 = "TYPES must not be null";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new RuntimeException(str4);
      }
      else
      {
        DataType[] dataTypeArray2 = dataTypeArray1;
        int length = dataTypeArray2.Length;
        for (int index = 0; index < length; ++index)
        {
          DataType dataType = dataTypeArray2[index];
          object obj1 = (object) (Set) DisplayElementRegistry.map.get((object) dataType);
          if ((Set) obj1 == null)
            DisplayElementRegistry.map.put((object) dataType, (object) (LinkedHashSet) (obj1 = (object) new LinkedHashSet()));
          object obj2 = obj1;
          object obj3 = (object) clazz;
          Set set1;
          if (obj2 != null)
          {
            Set set2 = obj2 as Set;
            if (set2 == null)
              throw new IncompatibleClassChangeError();
            set1 = set2;
          }
          else
            set1 = (Set) null;
          object obj4 = obj3;
          set1.add(obj4);
        }
      }
    }

    [Signature("(Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/StaticWidget;>;)V")]
    [LineNumberTable(new byte[] {(byte) 7, (byte) 109, (byte) 204})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void registerStaticWidget(Class clazz)
    {
      if (Modifier.isAbstract(clazz.getModifiers()))
        return;
      DisplayElementRegistry.staticWidgets.add((object) clazz);
    }

    [Signature("(Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/Widget;>;Ledu/wpi/first/smartdashboard/types/DataType;)Z")]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 89, (byte) 126, (byte) 105, (byte) 2, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool supportsType(Class clazz, DataType type)
    {
      DataType[] dataTypeArray = (DataType[]) DisplayElementRegistry.declaredTypes.get((object) clazz);
      int length = dataTypeArray.Length;
      for (int index = 0; index < length; ++index)
      {
        DataType parent = dataTypeArray[index];
        if (type.isChildOf(parent))
          return true;
      }
      return false;
    }

    [Signature("()Ljava/util/Set<Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/StaticWidget;>;>;")]
    public static Set getStaticWidgets()
    {
      return DisplayElementRegistry.staticWidgets;
    }

    [Signature("(Ledu/wpi/first/smartdashboard/types/DataType;)Ljava/util/Set<Ljava/lang/Class<+Ledu/wpi/first/smartdashboard/gui/Widget;>;>;")]
    [LineNumberTable(new byte[] {(byte) 109, (byte) 113, (byte) 136, (byte) 134, (byte) 123, (byte) 114, (byte) 100, (byte) 104, (byte) 100, (byte) 201, (byte) 98, (byte) 123, (byte) 114, (byte) 100, (byte) 137, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Set getWidgetsForType(DataType type)
    {
      Set set1 = DisplayElementRegistry.generateTypes((Set) new LinkedHashSet(), type.getParents());
      set1.add((object) type);
      LinkedHashSet linkedHashSet = new LinkedHashSet();
      Iterator iterator1 = set1.iterator();
      while (iterator1.hasNext())
      {
        DataType dataType = (DataType) iterator1.next();
        if ((Set) DisplayElementRegistry.map.get((object) dataType) != null)
        {
          Class @default = dataType.getDefault();
          if (@default != null)
            ((Set) linkedHashSet).add((object) @default);
        }
      }
      Iterator iterator2 = set1.iterator();
      while (iterator2.hasNext())
      {
        DataType dataType = (DataType) iterator2.next();
        Set set2 = (Set) DisplayElementRegistry.map.get((object) dataType);
        if (set2 != null)
          ((Set) linkedHashSet).addAll((Collection) set2);
      }
      return (Set) linkedHashSet;
    }

    [Signature("(Ljava/util/Set<Ledu/wpi/first/smartdashboard/types/DataType;>;[Ledu/wpi/first/smartdashboard/types/DataType;)Ljava/util/Set<Ledu/wpi/first/smartdashboard/types/DataType;>;")]
    [LineNumberTable(new byte[] {(byte) 93, (byte) 111, (byte) 105, (byte) 13, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Set generateTypes([In] Set obj0, [In] DataType[] obj1)
    {
      DataType[] dataTypeArray = obj1;
      int length = dataTypeArray.Length;
      for (int index = 0; index < length; ++index)
      {
        DataType dataType = dataTypeArray[index];
        if (obj0.add((object) dataType))
          DisplayElementRegistry.generateTypes(obj0, dataType.getParents());
      }
      return obj0;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (DisplayElementRegistry.__\u003CcallerID\u003E == null)
        DisplayElementRegistry.__\u003CcallerID\u003E = (CallerID) new DisplayElementRegistry.__\u003CCallerID\u003E();
      return DisplayElementRegistry.__\u003CcallerID\u003E;
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
