// Decompiled with JetBrains decompiler
// Type: org.jfree.base.modules.PackageSorter
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using java.util;
using org.jfree.@base.modules;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.@base.modules
{
  public sealed class PackageSorter : Object
  {
    [LineNumberTable(new byte[] {(byte) 160, (byte) 86, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private PackageSorter()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 100, (byte) 102, (byte) 102, (byte) 134, (byte) 139, (byte) 110, (byte) 139, (byte) 203, (byte) 105, (byte) 105, (byte) 245, (byte) 53, (byte) 233, (byte) 79, (byte) 189, (byte) 138, (byte) 103, (byte) 249, (byte) 61, (byte) 232, (byte) 78, (byte) 99, (byte) 132, (byte) 99, (byte) 138, (byte) 103, (byte) 106, (byte) 139, (byte) 105, (byte) 227, (byte) 57, (byte) 234, (byte) 76, (byte) 103, (byte) 102, (byte) 138, (byte) 17, (byte) 200, (byte) 141, (byte) 15, (byte) 200})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void sort(List modules)
    {
      HashMap hashMap = new HashMap();
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      for (int index = 0; index < modules.size(); ++index)
      {
        PackageState packageState = (PackageState) modules.get(index);
        if (packageState.getState() == -2)
        {
          arrayList1.add((object) packageState);
        }
        else
        {
          PackageSorter.SortModule sortModule = new PackageSorter.SortModule(packageState);
          arrayList2.add((object) sortModule);
          hashMap.put((object) packageState.getModule().getModuleClass(), (object) sortModule);
        }
      }
      PackageSorter.SortModule[] sortModuleArray = (PackageSorter.SortModule[]) arrayList2.toArray((object[]) new PackageSorter.SortModule[arrayList2.size()]);
      for (int index = 0; index < sortModuleArray.Length; ++index)
      {
        PackageSorter.SortModule sortModule = sortModuleArray[index];
        sortModule.setDependSubsystems(PackageSorter.collectSubsystemModules(sortModule.getState().getModule(), hashMap));
      }
      int num1 = 1;
label_10:
      while (num1 != 0)
      {
        num1 = 0;
        int index = 0;
        while (true)
        {
          if (index < sortModuleArray.Length)
          {
            PackageSorter.SortModule sortModule = sortModuleArray[index];
            int num2 = PackageSorter.searchModulePosition(sortModule, hashMap);
            if (num2 != sortModule.getPosition())
            {
              sortModule.setPosition(num2);
              num1 = 1;
            }
            ++index;
          }
          else
            goto label_10;
        }
      }
      Arrays.sort((object[]) sortModuleArray);
      modules.clear();
      for (int index = 0; index < sortModuleArray.Length; ++index)
        modules.add((object) sortModuleArray[index].getState());
      for (int index = 0; index < arrayList1.size(); ++index)
        modules.add(arrayList1.get(index));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 46, (byte) 102, (byte) 103, (byte) 135, (byte) 148, (byte) 131, (byte) 215, (byte) 162, (byte) 247, (byte) 51, (byte) 230, (byte) 80, (byte) 103, (byte) 135, (byte) 149, (byte) 132, (byte) 106, (byte) 130, (byte) 238, (byte) 55, (byte) 230, (byte) 75})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static ArrayList collectSubsystemModules([In] Module obj0, [In] HashMap obj1)
    {
      ArrayList arrayList = new ArrayList();
      ModuleInfo[] requiredModules = obj0.getRequiredModules();
      for (int index = 0; index < requiredModules.Length; ++index)
      {
        PackageSorter.SortModule sortModule = (PackageSorter.SortModule) obj1.get((object) requiredModules[index].getModuleClass());
        if (sortModule == null)
          Log.warn((object) new Log.SimpleMessage("A dependent module was not found in the list of known modules.", (object) requiredModules[index].getModuleClass()));
        else
          arrayList.add((object) sortModule.getState().getModule().getSubSystem());
      }
      foreach (ModuleInfo moduleInfo in obj0.getOptionalModules())
      {
        Module module = (Module) obj1.get((object) moduleInfo.getModuleClass());
        if (module == null)
          Log.warn((object) "A dependent module was not found in the list of known modules.");
        else
          arrayList.add((object) module.getSubSystem());
      }
      return arrayList;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 176, (byte) 108, (byte) 226, (byte) 69, (byte) 103, (byte) 135, (byte) 106, (byte) 111, (byte) 132, (byte) 130, (byte) 138, (byte) 234, (byte) 54, (byte) 230, (byte) 82, (byte) 103, (byte) 138, (byte) 106, (byte) 111, (byte) 132, (byte) 127, (byte) 11, (byte) 130, (byte) 138, (byte) 234, (byte) 53, (byte) 233, (byte) 82, (byte) 104, (byte) 109, (byte) 140, (byte) 142, (byte) 175, (byte) 130, (byte) 206, (byte) 176, (byte) 226, (byte) 71, (byte) 244, (byte) 69, (byte) 138, (byte) 138, (byte) 202, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int searchModulePosition([In] PackageSorter.SortModule obj0, [In] HashMap obj1)
    {
      Module module1 = obj0.getState().getModule();
      int num = 0;
      foreach (ModuleInfo moduleInfo in module1.getOptionalModules())
      {
        string moduleClass = moduleInfo.getModuleClass();
        PackageSorter.SortModule sortModule = (PackageSorter.SortModule) obj1.get((object) moduleClass);
        if (sortModule != null && sortModule.getPosition() >= num)
          num = sortModule.getPosition() + 1;
      }
      foreach (ModuleInfo moduleInfo in module1.getRequiredModules())
      {
        string moduleClass = moduleInfo.getModuleClass();
        PackageSorter.SortModule sortModule = (PackageSorter.SortModule) obj1.get((object) moduleClass);
        if (sortModule == null)
          Log.warn((object) new StringBuffer().append("Invalid state: Required dependency of '").append(moduleClass).append("' had an error.").toString());
        else if (sortModule.getPosition() >= num)
          num = sortModule.getPosition() + 1;
      }
      string subSystem = module1.getSubSystem();
      Iterator iterator = obj1.values().iterator();
      while (iterator.hasNext())
      {
        PackageSorter.SortModule sortModule = (PackageSorter.SortModule) iterator.next();
        if (sortModule.getState().getModule() != module1)
        {
          Module module2 = sortModule.getState().getModule();
          if (!String.instancehelper_equals(subSystem, (object) module2.getSubSystem()) && obj0.getDependSubsystems().contains((object) module2.getSubSystem()) && (!PackageSorter.isBaseModule(module2, (ModuleInfo) module1) && sortModule.getPosition() >= num))
            num = sortModule.getPosition() + 1;
        }
      }
      return num;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 16, (byte) 103, (byte) 135, (byte) 149, (byte) 226, (byte) 60, (byte) 230, (byte) 71, (byte) 103, (byte) 135, (byte) 149, (byte) 226, (byte) 60, (byte) 230, (byte) 71})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool isBaseModule([In] Module obj0, [In] ModuleInfo obj1)
    {
      foreach (ModuleInfo moduleInfo in obj0.getRequiredModules())
      {
        if (String.instancehelper_equals(moduleInfo.getModuleClass(), (object) obj1.getModuleClass()))
          return true;
      }
      foreach (ModuleInfo moduleInfo in obj0.getOptionalModules())
      {
        if (String.instancehelper_equals(moduleInfo.getModuleClass(), (object) obj1.getModuleClass()))
          return true;
      }
      return false;
    }

    [InnerClass]
    [Implements(new string[] {"java.lang.Comparable"})]
    [SourceFile("PackageSorter.java")]
    [Modifiers]
    internal sealed class SortModule : Object, Comparable
    {
      private int position;
      [Modifiers]
      private PackageState state;
      private ArrayList dependSubsystems;

      [LineNumberTable(new byte[] {(byte) 42, (byte) 104, (byte) 103, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public SortModule([In] PackageState obj0)
      {
        base.\u002Ector();
        PackageSorter.SortModule sortModule = this;
        this.position = -1;
        this.state = obj0;
      }

      public virtual ArrayList getDependSubsystems()
      {
        return this.dependSubsystems;
      }

      public virtual void setDependSubsystems([In] ArrayList obj0)
      {
        this.dependSubsystems = obj0;
      }

      public virtual int getPosition()
      {
        return this.position;
      }

      public virtual void setPosition([In] int obj0)
      {
        this.position = obj0;
      }

      public virtual PackageState getState()
      {
        return this.state;
      }

      [LineNumberTable(new byte[] {(byte) 111, (byte) 102, (byte) 108, (byte) 109, (byte) 108, (byte) 119, (byte) 108, (byte) 119})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string toString()
      {
        StringBuffer stringBuffer = new StringBuffer();
        stringBuffer.append("SortModule: ");
        stringBuffer.append(this.position);
        stringBuffer.append(" ");
        stringBuffer.append(this.state.getModule().getName());
        stringBuffer.append(" ");
        stringBuffer.append(this.state.getModule().getModuleClass());
        return stringBuffer.toString();
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 70, (byte) 103, (byte) 142, (byte) 130, (byte) 142, (byte) 130})]
      public virtual int compareTo([In] object obj0)
      {
        PackageSorter.SortModule sortModule = (PackageSorter.SortModule) obj0;
        if (this.position > sortModule.position)
          return 1;
        return this.position < sortModule.position ? -1 : 0;
      }

      [HideFromJava]
      int IComparable.java\u002Elang\u002EComparable\u002F\u0028Ljava\u002Elang\u002EObject\u003B\u0029IcompareTo([In] object obj0)
      {
        return this.compareTo(obj0);
      }
    }
  }
}
