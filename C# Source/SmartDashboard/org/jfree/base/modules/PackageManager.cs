// Decompiled with JetBrains decompiler
// Type: org.jfree.base.modules.PackageManager
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using org.jfree.@base;
using org.jfree.@base.config;
using org.jfree.@base.log;
using org.jfree.@base.modules;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.@base.modules
{
  public sealed class PackageManager : Object
  {
    private const int RETURN_MODULE_LOADED = 0;
    private const int RETURN_MODULE_UNKNOWN = 1;
    private const int RETURN_MODULE_ERROR = 2;
    [Modifiers]
    private PackageManager.PackageConfiguration packageConfiguration;
    [Modifiers]
    private ArrayList modules;
    [Modifiers]
    private ArrayList initSections;
    private AbstractBoot booter;
    private static HashMap instances;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 113, (byte) 104, (byte) 99, (byte) 139, (byte) 103, (byte) 107, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private PackageManager([In] AbstractBoot obj0)
    {
      base.\u002Ector();
      PackageManager packageManager = this;
      if (obj0 == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else
      {
        this.booter = obj0;
        this.packageConfiguration = new PackageManager.PackageConfiguration();
        this.modules = new ArrayList();
        this.initSections = new ArrayList();
      }
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 103, (byte) 106, (byte) 103, (byte) 109, (byte) 130, (byte) 113, (byte) 99, (byte) 103, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PackageManager createInstance(AbstractBoot booter)
    {
      if (PackageManager.instances == null)
      {
        PackageManager.instances = new HashMap();
        PackageManager packageManager = new PackageManager(booter);
        PackageManager.instances.put((object) booter, (object) packageManager);
        return packageManager;
      }
      else
      {
        PackageManager packageManager = (PackageManager) PackageManager.instances.get((object) booter);
        if (packageManager == null)
        {
          packageManager = new PackageManager(booter);
          PackageManager.instances.put((object) booter, (object) packageManager);
        }
        return packageManager;
      }
    }

    public virtual PackageManager.PackageConfiguration getPackageConfiguration()
    {
      return this.packageConfiguration;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 142, (byte) 102, (byte) 138, (byte) 112, (byte) 107, (byte) 109, (byte) 18, (byte) 230, (byte) 69})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void addModule(string modClass)
    {
      ArrayList arrayList = new ArrayList();
      if (!this.loadModule((ModuleInfo) new DefaultModuleInfo(modClass, (string) null, (string) null, (string) null), new ArrayList(), arrayList, false))
        return;
      for (int index = 0; index < arrayList.size(); ++index)
        this.modules.add((object) new PackageState((Module) arrayList.get(index)));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 86, (byte) 110, (byte) 129, (byte) 141, (byte) 108, (byte) 104, (byte) 98, (byte) 104, (byte) 108, (byte) 109, (byte) 105, (byte) 110, (byte) 104, (byte) 164, (byte) 98, (byte) 127, (byte) 18})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void load(string modulePrefix)
    {
      if (this.initSections.contains((object) modulePrefix))
        return;
      this.initSections.add((object) modulePrefix);
      Configuration globalConfig = this.booter.getGlobalConfig();
      Iterator propertyKeys = globalConfig.findPropertyKeys(modulePrefix);
      int num = 0;
      while (propertyKeys.hasNext())
      {
        string str = (string) propertyKeys.next();
        if (String.instancehelper_endsWith(str, ".Module"))
        {
          string configProperty = globalConfig.getConfigProperty(str);
          if (configProperty != null && String.instancehelper_length(configProperty) > 0)
          {
            this.addModule(configProperty);
            ++num;
          }
        }
      }
      Log.debug((object) new StringBuffer().append("Loaded a total of ").append(num).append(" modules under prefix: ").append(modulePrefix).toString());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 113, (byte) 139, (byte) 112, (byte) 114, (byte) 110, (byte) 255, (byte) 23, (byte) 61, (byte) 233, (byte) 73, (byte) 112, (byte) 114, (byte) 110, (byte) 255, (byte) 23, (byte) 61, (byte) 233, (byte) 72})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void initializeModules()
    {
      PackageSorter.sort((List) this.modules);
      for (int index = 0; index < this.modules.size(); ++index)
      {
        PackageState packageState = (PackageState) this.modules.get(index);
        if (packageState.configure((SubSystem) this.booter))
          Log.debug((object) new Log.SimpleMessage("Conf: ", (object) new PadMessage((object) packageState.getModule().getModuleClass(), 70), (object) " [", (object) packageState.getModule().getSubSystem(), (object) "]"));
      }
      for (int index = 0; index < this.modules.size(); ++index)
      {
        PackageState packageState = (PackageState) this.modules.get(index);
        if (packageState.initialize((SubSystem) this.booter))
          Log.debug((object) new Log.SimpleMessage("Init: ", (object) new PadMessage((object) packageState.getModule().getModuleClass(), 70), (object) " [", (object) packageState.getModule().getSubSystem(), (object) "]"));
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 59, (byte) 131, (byte) 119, (byte) 145, (byte) 138, (byte) 159, (byte) 37, (byte) 105, (byte) 103, (byte) 168, (byte) 106, (byte) 133, (byte) 127, (byte) 5, (byte) 106, (byte) 104, (byte) 136, (byte) 104, (byte) 137, (byte) 181, (byte) 106, (byte) 104, (byte) 136, (byte) 104, (byte) 104, (byte) 106, (byte) 112, (byte) 127, (byte) 5, (byte) 106, (byte) 104, (byte) 232, (byte) 59, (byte) 232, (byte) 73, (byte) 104, (byte) 106, (byte) 112, (byte) 30, (byte) 232, (byte) 71, (byte) 107, (byte) 136, (byte) 136, (byte) 159, (byte) 28, (byte) 98, (byte) 99, (byte) 181, (byte) 118, (byte) 130, (byte) 98, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool loadModule([In] ModuleInfo obj0, [In] ArrayList obj1, [In] ArrayList obj2, [In] bool obj3)
    {
      int num1 = obj3 ? 1 : 0;
      int num2;
      ClassNotFoundException notFoundException1;
      Exception exception;
      try
      {
        try
        {
          Module module = (Module) ObjectUtilities.getClassLoader(Object.instancehelper_getClass((object) this)).loadClass(obj0.getModuleClass()).newInstance(PackageManager.__\u003CGetCallerID\u003E());
          if (!this.acceptVersion(obj0, module))
          {
            Log.warn((object) new StringBuffer().append("Module ").append(module.getName()).append(": required version: ").append((object) obj0).append(", but found Version: \n").append((object) module).toString());
            this.dropFailedModule(new PackageState(module, -2));
            return false;
          }
          else
          {
            switch (this.containsModule(obj2, (ModuleInfo) module))
            {
              case 2:
                Log.debug((object) new StringBuffer().append("Indicated failure for module: ").append(module.getModuleClass()).toString());
                this.dropFailedModule(new PackageState(module, -2));
                return false;
              case 1:
                if (obj1.contains((object) module))
                {
                  Log.error((object) new Log.SimpleMessage("Circular module reference: This module definition is invalid: ", (object) Object.instancehelper_getClass((object) module)));
                  this.dropFailedModule(new PackageState(module, -2));
                  return false;
                }
                else
                {
                  obj1.add((object) module);
                  foreach (ModuleInfo moduleInfo in module.getRequiredModules())
                  {
                    if (!this.loadModule(moduleInfo, obj1, obj2, true))
                    {
                      Log.debug((object) new StringBuffer().append("Indicated failure for module: ").append(module.getModuleClass()).toString());
                      this.dropFailedModule(new PackageState(module, -2));
                      return false;
                    }
                  }
                  ModuleInfo[] optionalModules = module.getOptionalModules();
                  for (int index = 0; index < optionalModules.Length; ++index)
                  {
                    if (!this.loadModule(optionalModules[index], obj1, obj2, true))
                      Log.debug((object) new Log.SimpleMessage("Optional module: ", (object) optionalModules[index].getModuleClass(), (object) " was not loaded."));
                  }
                  if (this.containsModule(obj2, (ModuleInfo) module) == 1)
                    obj2.add((object) module);
                  obj1.remove((object) module);
                  break;
                }
            }
            num2 = 1;
          }
        }
        catch (ClassNotFoundException ex)
        {
          int num3 = 1;
          notFoundException1 = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num3);
          goto label_26;
        }
      }
      catch (Exception ex)
      {
        int num3 = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num3);
        if (m0 == null)
        {
          throw;
        }
        else
        {
          exception = (Exception) m0;
          goto label_27;
        }
      }
      return num2 != 0;
label_26:
      ClassNotFoundException notFoundException2 = notFoundException1;
      if (num1 != 0)
        Log.warn((object) new Log.SimpleMessage("Unresolved dependency for package: ", (object) obj0.getModuleClass()));
      Log.debug((object) new Log.SimpleMessage("ClassNotFound: ", (object) Throwable.instancehelper_getMessage((Exception) notFoundException2)));
      return false;
label_27:
      Exception e = exception;
      Log.warn((object) new Log.SimpleMessage("Exception while loading module: ", (object) obj0), e);
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 43, (byte) 104, (byte) 130, (byte) 104, (byte) 191, (byte) 17, (byte) 147, (byte) 100, (byte) 130, (byte) 100, (byte) 194, (byte) 104, (byte) 130, (byte) 104, (byte) 191, (byte) 17, (byte) 147, (byte) 100, (byte) 130, (byte) 100, (byte) 194, (byte) 104, (byte) 130, (byte) 104, (byte) 191, (byte) 17, (byte) 149, (byte) 191, (byte) 26, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool acceptVersion([In] ModuleInfo obj0, [In] Module obj1)
    {
      if (obj0.getMajorVersion() == null)
        return true;
      if (obj1.getMajorVersion() == null)
      {
        Log.warn((object) new StringBuffer().append("Module ").append(obj1.getName()).append(" does not define a major version.").toString());
      }
      else
      {
        int num = this.acceptVersion(obj0.getMajorVersion(), obj1.getMajorVersion());
        if (num > 0)
          return false;
        if (num < 0)
          return true;
      }
      if (obj0.getMinorVersion() == null)
        return true;
      if (obj1.getMinorVersion() == null)
      {
        Log.warn((object) new StringBuffer().append("Module ").append(obj1.getName()).append(" does not define a minor version.").toString());
      }
      else
      {
        int num = this.acceptVersion(obj0.getMinorVersion(), obj1.getMinorVersion());
        if (num > 0)
          return false;
        if (num < 0)
          return true;
      }
      if (obj0.getPatchLevel() == null)
        return true;
      if (obj1.getPatchLevel() == null)
        Log.debug((object) new StringBuffer().append("Module ").append(obj1.getName()).append(" does not define a patch level.").toString());
      else if (this.acceptVersion(obj0.getPatchLevel(), obj1.getPatchLevel()) > 0)
      {
        Log.debug((object) new StringBuffer().append("Did not accept patchlevel: ").append(obj0.getPatchLevel()).append(" - ").append(obj1.getPatchLevel()).toString());
        return false;
      }
      return true;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 196, (byte) 110, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void dropFailedModule([In] PackageState obj0)
    {
      if (this.modules.contains((object) obj0))
        return;
      this.modules.add((object) obj0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 163, (byte) 99, (byte) 156, (byte) 103, (byte) 117, (byte) 2, (byte) 230, (byte) 71, (byte) 159, (byte) 7, (byte) 103, (byte) 122, (byte) 108, (byte) 162, (byte) 226, (byte) 58, (byte) 230, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private int containsModule([In] ArrayList obj0, [In] ModuleInfo obj1)
    {
      if (obj0 != null)
      {
        foreach (ModuleInfo moduleInfo in (ModuleInfo[]) obj0.toArray((object[]) new ModuleInfo[obj0.size()]))
        {
          if (String.instancehelper_equals(moduleInfo.getModuleClass(), (object) obj1.getModuleClass()))
            return 0;
        }
      }
      PackageState[] packageStateArray = (PackageState[]) this.modules.toArray((object[]) new PackageState[this.modules.size()]);
      for (int index = 0; index < packageStateArray.Length; ++index)
      {
        if (String.instancehelper_equals(packageStateArray[index].getModule().getModuleClass(), (object) obj1.getModuleClass()))
          return packageStateArray[index].getState() == -2 ? 2 : 0;
      }
      return 1;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 107, (byte) 178, (byte) 110, (byte) 103, (byte) 103, (byte) 110, (byte) 106, (byte) 116, (byte) 101, (byte) 110, (byte) 103, (byte) 103, (byte) 104, (byte) 111, (byte) 108, (byte) 118, (byte) 130, (byte) 103, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private int acceptVersion([In] string obj0, [In] string obj1)
    {
      int length = Math.max(String.instancehelper_length(obj0), String.instancehelper_length(obj1));
      char[] chArray1;
      char[] chArray2;
      if (String.instancehelper_length(obj0) > String.instancehelper_length(obj1))
      {
        chArray1 = String.instancehelper_toCharArray(obj0);
        chArray2 = new char[length];
        int num = String.instancehelper_length(obj0) - String.instancehelper_length(obj1);
        Arrays.fill(chArray2, 0, num, ' ');
        ByteCodeHelper.arraycopy_primitive_2((Array) chArray2, num, (Array) String.instancehelper_toCharArray(obj1), 0, String.instancehelper_length(obj1));
      }
      else if (String.instancehelper_length(obj0) < String.instancehelper_length(obj1))
      {
        chArray2 = String.instancehelper_toCharArray(obj1);
        chArray1 = new char[length];
        char[] chArray3 = new char[length];
        int num = String.instancehelper_length(obj1) - String.instancehelper_length(obj0);
        Arrays.fill(chArray3, 0, num, ' ');
        ByteCodeHelper.arraycopy_primitive_2((Array) chArray3, num, (Array) String.instancehelper_toCharArray(obj0), 0, String.instancehelper_length(obj0));
      }
      else
      {
        chArray2 = String.instancehelper_toCharArray(obj1);
        chArray1 = String.instancehelper_toCharArray(obj0);
      }
      return String.instancehelper_compareTo(String.newhelper(chArray1), String.newhelper(chArray2));
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 151, (byte) 113, (byte) 112, (byte) 114, (byte) 9, (byte) 198})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Module[] getAllModules()
    {
      Module[] moduleArray = new Module[this.modules.size()];
      for (int index = 0; index < this.modules.size(); ++index)
      {
        PackageState packageState = (PackageState) this.modules.get(index);
        moduleArray[index] = packageState.getModule();
      }
      return moduleArray;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 67, (byte) 159, (byte) 7, (byte) 103, (byte) 100, (byte) 120, (byte) 234, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isModuleAvailable(ModuleInfo moduleDescription)
    {
      foreach (PackageState packageState in (PackageState[]) this.modules.toArray((object[]) new PackageState[this.modules.size()]))
      {
        if (String.instancehelper_equals(packageState.getModule().getModuleClass(), (object) moduleDescription.getModuleClass()))
          return packageState.getState() == 2;
      }
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 166, (byte) 102, (byte) 112, (byte) 114, (byte) 105, (byte) 237, (byte) 61, (byte) 230, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Module[] getActiveModules()
    {
      ArrayList arrayList = new ArrayList();
      for (int index = 0; index < this.modules.size(); ++index)
      {
        PackageState packageState = (PackageState) this.modules.get(index);
        if (packageState.getState() == 2)
          arrayList.add((object) packageState.getModule());
      }
      return (Module[]) arrayList.toArray((object[]) new Module[arrayList.size()]);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 182, (byte) 103, (byte) 102, (byte) 134, (byte) 103, (byte) 107, (byte) 172, (byte) 234, (byte) 59, (byte) 230, (byte) 73, (byte) 107, (byte) 108, (byte) 107, (byte) 110, (byte) 110, (byte) 116, (byte) 107, (byte) 109, (byte) 107, (byte) 107, (byte) 109, (byte) 107, (byte) 109, (byte) 107, (byte) 109, (byte) 107, (byte) 109, (byte) 107, (byte) 237, (byte) 49, (byte) 233, (byte) 81})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void printUsedModules(PrintStream p)
    {
      Module[] allModules = this.getAllModules();
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      for (int index = 0; index < allModules.Length; ++index)
      {
        if (this.isModuleAvailable((ModuleInfo) allModules[index]))
          arrayList1.add((object) allModules[index]);
        else
          arrayList2.add((object) allModules[index]);
      }
      p.print("Active modules: ");
      p.println(arrayList1.size());
      p.println("----------------------------------------------------------");
      for (int index = 0; index < arrayList1.size(); ++index)
      {
        Module module = (Module) arrayList1.get(index);
        p.print((object) new PadMessage((object) module.getModuleClass(), 70));
        p.print(" [");
        p.print(module.getSubSystem());
        p.println("]");
        p.print("  Version: ");
        p.print(module.getMajorVersion());
        p.print("-");
        p.print(module.getMinorVersion());
        p.print("-");
        p.print(module.getPatchLevel());
        p.print(" Producer: ");
        p.println(module.getProducer());
        p.print("  Description: ");
        p.println(module.getDescription());
      }
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (PackageManager.__\u003CcallerID\u003E == null)
        PackageManager.__\u003CcallerID\u003E = (CallerID) new PackageManager.__\u003CCallerID\u003E();
      return PackageManager.__\u003CcallerID\u003E;
    }

    [InnerClass]
    [SourceFile("PackageManager.java")]
    [Serializable]
    public class PackageConfiguration : PropertyFileConfiguration
    {
      [LineNumberTable(new byte[] {(byte) 34, (byte) 136})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public PackageConfiguration()
      {
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected PackageConfiguration([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [LineNumberTable(new byte[] {(byte) 45, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void insertConfiguration(HierarchicalConfiguration config)
      {
        base.insertConfiguration(config);
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
