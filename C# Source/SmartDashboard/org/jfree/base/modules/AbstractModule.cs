// Decompiled with JetBrains decompiler
// Type: org.jfree.base.modules.AbstractModule
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using org.jfree.@base.modules;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.@base.modules
{
  [Implements(new string[] {"org.jfree.base.modules.Module"})]
  public abstract class AbstractModule : DefaultModuleInfo, Module, ModuleInfo
  {
    private ModuleInfo[] requiredModules;
    private ModuleInfo[] optionalModules;
    private string name;
    private string description;
    private string producer;
    private string subsystem;
    internal static Class class\u0024org\u0024jfree\u0024base\u0024modules\u0024AbstractModule;
    internal static Class class\u0024org\u0024jfree\u0024base\u0024modules\u0024ModuleInitializer;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 160, (byte) 93, (byte) 104, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AbstractModule()
    {
      AbstractModule abstractModule = this;
      this.setModuleClass(Object.instancehelper_getClass((object) this).getName());
    }

    [Throws(new string[] {"org.jfree.base.modules.ModuleInitializeException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 126, (byte) 131, (byte) 240, (byte) 70, (byte) 102, (byte) 102, (byte) 214, (byte) 139, (byte) 103, (byte) 141, (byte) 137, (byte) 141, (byte) 144, (byte) 141, (byte) 238, (byte) 71, (byte) 211, (byte) 102, (byte) 63, (byte) 0, (byte) 190, (byte) 191, (byte) 2, (byte) 255, (byte) 22, (byte) 70, (byte) 226, (byte) 61, (byte) 130, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void loadModuleInfo(InputStream @in)
    {
      if (@in == null)
      {
        string str = "Given InputStream is null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        ArrayList arrayList1;
        ArrayList arrayList2;
        AbstractModule.ReaderHelper readerHelper;
        Exception exception1;
        IOException ioException1;
        try
        {
          arrayList1 = new ArrayList();
          arrayList2 = new ArrayList();
          readerHelper = new AbstractModule.ReaderHelper(new BufferedReader((Reader) new InputStreamReader(@in, "ISO-8859-1")));
          try
          {
            while (readerHelper.hasNext())
            {
              string str = readerHelper.next();
              if (String.instancehelper_startsWith(str, "module-info:"))
                this.readModuleInfo(readerHelper);
              else if (String.instancehelper_startsWith(str, "depends:"))
                arrayList2.add((object) this.readExternalModule(readerHelper));
              else if (String.instancehelper_startsWith(str, "optional:"))
                arrayList1.add((object) this.readExternalModule(readerHelper));
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            exception1 = (Exception) ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
            goto label_13;
          }
          readerHelper.close();
          goto label_18;
        }
        catch (IOException ex)
        {
          int num = 1;
          ioException1 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
          goto label_14;
        }
label_13:
        Exception exception2 = exception1;
        IOException ioException2;
        try
        {
          Exception exception3 = exception2;
          readerHelper.close();
          throw Throwable.__\u003Cunmap\u003E(exception3);
        }
        catch (IOException ex)
        {
          int num = 1;
          ioException2 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
        IOException ioException3 = ioException2;
        goto label_21;
label_14:
        ioException3 = ioException1;
        goto label_21;
label_18:
        IOException ioException4;
        try
        {
          this.optionalModules = (ModuleInfo[]) arrayList1.toArray((object[]) new ModuleInfo[arrayList1.size()]);
          this.requiredModules = (ModuleInfo[]) arrayList2.toArray((object[]) new ModuleInfo[arrayList2.size()]);
          return;
        }
        catch (IOException ex)
        {
          int num = 1;
          ioException4 = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
        ioException3 = ioException4;
label_21:
        IOException ioException5 = ioException3;
        string s = "Failed to load properties";
        IOException ioException6 = ioException5;
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new ModuleInitializeException(s, (Exception) ioException6);
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 250, (byte) 139, (byte) 135, (byte) 174, (byte) 105, (byte) 161, (byte) 103, (byte) 104, (byte) 166, (byte) 148, (byte) 141, (byte) 140, (byte) 141, (byte) 140, (byte) 141, (byte) 140, (byte) 141, (byte) 137, (byte) 141, (byte) 137, (byte) 141, (byte) 137, (byte) 141, (byte) 167, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void readModuleInfo([In] AbstractModule.ReaderHelper obj0)
    {
      while (obj0.hasNext())
      {
        string str1 = obj0.next();
        if (!Character.isWhitespace(String.instancehelper_charAt(str1, 0)))
        {
          obj0.pushBack(str1);
          break;
        }
        else
        {
          string str2 = String.instancehelper_trim(str1);
          string str3 = this.parseKey(str2);
          if (str3 != null)
          {
            string str4 = this.readValue(obj0, this.parseValue(String.instancehelper_trim(str2)));
            if (String.instancehelper_equals("name", (object) str3))
              this.setName(str4);
            else if (String.instancehelper_equals("producer", (object) str3))
              this.setProducer(str4);
            else if (String.instancehelper_equals("description", (object) str3))
              this.setDescription(str4);
            else if (String.instancehelper_equals("subsystem", (object) str3))
              this.setSubSystem(str4);
            else if (String.instancehelper_equals("version.major", (object) str3))
              this.setMajorVersion(str4);
            else if (String.instancehelper_equals("version.minor", (object) str3))
              this.setMinorVersion(str4);
            else if (String.instancehelper_equals("version.patchlevel", (object) str3))
              this.setPatchLevel(str4);
          }
        }
      }
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 161, (byte) 92, (byte) 134, (byte) 139, (byte) 135, (byte) 174, (byte) 103, (byte) 162, (byte) 103, (byte) 104, (byte) 134, (byte) 112, (byte) 141, (byte) 138, (byte) 141, (byte) 138, (byte) 141, (byte) 138, (byte) 141, (byte) 168, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private DefaultModuleInfo readExternalModule([In] AbstractModule.ReaderHelper obj0)
    {
      DefaultModuleInfo defaultModuleInfo = new DefaultModuleInfo();
      while (obj0.hasNext())
      {
        string str1 = obj0.next();
        if (!Character.isWhitespace(String.instancehelper_charAt(str1, 0)))
        {
          obj0.pushBack(str1);
          return defaultModuleInfo;
        }
        else
        {
          string str2 = String.instancehelper_trim(str1);
          string str3 = this.parseKey(str2);
          if (str3 != null)
          {
            string str4 = this.readValue(obj0, this.parseValue(str2));
            if (String.instancehelper_equals("module", (object) str3))
              defaultModuleInfo.setModuleClass(str4);
            else if (String.instancehelper_equals("version.major", (object) str3))
              defaultModuleInfo.setMajorVersion(str4);
            else if (String.instancehelper_equals("version.minor", (object) str3))
              defaultModuleInfo.setMinorVersion(str4);
            else if (String.instancehelper_equals("version.patchlevel", (object) str3))
              defaultModuleInfo.setPatchLevel(str4);
          }
        }
      }
      return defaultModuleInfo;
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 223, (byte) 136, (byte) 130, (byte) 103, (byte) 131, (byte) 130, (byte) 137, (byte) 103, (byte) 130, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool isNextLineValueLine([In] AbstractModule.ReaderHelper obj0)
    {
      if (!obj0.hasNext())
        return false;
      string str = obj0.next();
      if (str == null)
        return false;
      if (this.parseKey(str) != null)
      {
        obj0.pushBack(str);
        return false;
      }
      else
      {
        obj0.pushBack(str);
        return true;
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 69, (byte) 105, (byte) 132, (byte) 130, (byte) 139, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private string parseValue([In] string obj0)
    {
      int num = String.instancehelper_indexOf(obj0, 58);
      if (num == -1)
        return obj0;
      if (num + 1 == String.instancehelper_length(obj0))
        return "";
      return String.instancehelper_substring(obj0, num + 1);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 53, (byte) 105, (byte) 132, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private string parseKey([In] string obj0)
    {
      int num = String.instancehelper_indexOf(obj0, 58);
      if (num == -1)
        return (string) null;
      return String.instancehelper_substring(obj0, 0, num);
    }

    [Throws(new string[] {"java.io.IOException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 190, (byte) 113, (byte) 98, (byte) 137, (byte) 104, (byte) 103, (byte) 139, (byte) 108, (byte) 196, (byte) 131, (byte) 140, (byte) 110, (byte) 130, (byte) 101})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private string readValue([In] AbstractModule.ReaderHelper obj0, [In] string obj1)
    {
      StringBuffer.__\u003Cclinit\u003E();
      StringBuffer stringBuffer = new StringBuffer(String.instancehelper_trim(obj1));
      int num = 1;
      while (this.isNextLineValueLine(obj0))
      {
        obj1 = obj0.next();
        string str = String.instancehelper_trim(obj1);
        if (String.instancehelper_length(str) == 0 && num == 0)
        {
          stringBuffer.append("\n");
          num = 1;
        }
        else
        {
          if (num == 0)
            stringBuffer.append(" ");
          stringBuffer.append(this.parseValue(str));
          num = 0;
        }
      }
      return stringBuffer.toString();
    }

    protected internal virtual void setName(string name)
    {
      this.name = name;
    }

    protected internal virtual void setProducer(string producer)
    {
      this.producer = producer;
    }

    protected internal virtual void setDescription(string description)
    {
      this.description = description;
    }

    protected internal virtual void setSubSystem(string name)
    {
      this.subsystem = name;
    }

    public virtual string getName()
    {
      return this.name;
    }

    public virtual string getProducer()
    {
      return this.producer;
    }

    public virtual string getDescription()
    {
      return this.description;
    }

    [LineNumberTable((ushort) 659)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, AbstractModule.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        int num = 1;
        notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return @class;
label_3:
      string message = Throwable.instancehelper_getMessage((Exception) notFoundException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoClassDefFoundError(message);
    }

    [Throws(new string[] {"org.jfree.base.modules.ModuleInitializeException"})]
    [LineNumberTable(new byte[] {(byte) 160, (byte) 105, (byte) 145, (byte) 131, (byte) 208, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void loadModuleInfo()
    {
      InputStream relativeAsStream = ObjectUtilities.getResourceRelativeAsStream("module.properties", Object.instancehelper_getClass((object) this));
      if (relativeAsStream == null)
      {
        string s = "File 'module.properties' not found in module package.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new ModuleInitializeException(s);
      }
      else
        this.loadModuleInfo(relativeAsStream);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 205, (byte) 109, (byte) 117})]
    public virtual ModuleInfo[] getRequiredModules()
    {
      ModuleInfo[] moduleInfoArray = new ModuleInfo[this.requiredModules.Length];
      ByteCodeHelper.arraycopy((object) this.requiredModules, 0, (object) moduleInfoArray, 0, this.requiredModules.Length);
      return moduleInfoArray;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 219, (byte) 109, (byte) 117})]
    public virtual ModuleInfo[] getOptionalModules()
    {
      ModuleInfo[] moduleInfoArray = new ModuleInfo[this.optionalModules.Length];
      ByteCodeHelper.arraycopy((object) this.optionalModules, 0, (object) moduleInfoArray, 0, this.optionalModules.Length);
      return moduleInfoArray;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 231, (byte) 109, (byte) 114})]
    protected internal virtual void setRequiredModules(ModuleInfo[] requiredModules)
    {
      this.requiredModules = new ModuleInfo[requiredModules.Length];
      ByteCodeHelper.arraycopy((object) requiredModules, 0, (object) this.requiredModules, 0, requiredModules.Length);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 242, (byte) 109, (byte) 114})]
    public virtual void setOptionalModules(ModuleInfo[] optionalModules)
    {
      this.optionalModules = new ModuleInfo[optionalModules.Length];
      ByteCodeHelper.arraycopy((object) optionalModules, 0, (object) this.optionalModules, 0, optionalModules.Length);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 254, (byte) 102, (byte) 108, (byte) 109, (byte) 108, (byte) 108, (byte) 109, (byte) 108, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 108, (byte) 109, (byte) 108, (byte) 108, (byte) 109, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string toString()
    {
      StringBuffer stringBuffer = new StringBuffer();
      stringBuffer.append("Module : ");
      stringBuffer.append(this.getName());
      stringBuffer.append("\n");
      stringBuffer.append("ModuleClass : ");
      stringBuffer.append(this.getModuleClass());
      stringBuffer.append("\n");
      stringBuffer.append("Version: ");
      stringBuffer.append(this.getMajorVersion());
      stringBuffer.append(".");
      stringBuffer.append(this.getMinorVersion());
      stringBuffer.append(".");
      stringBuffer.append(this.getPatchLevel());
      stringBuffer.append("\n");
      stringBuffer.append("Producer: ");
      stringBuffer.append(this.getProducer());
      stringBuffer.append("\n");
      stringBuffer.append("Description: ");
      stringBuffer.append(this.getDescription());
      stringBuffer.append("\n");
      return stringBuffer.toString();
    }

    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 33, (byte) 127, (byte) 5, (byte) 163, (byte) 132, (byte) 104, (byte) 156, (byte) 129})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static bool isClassLoadable(string name)
    {
      int num1;
      try
      {
        ClassLoader classLoader = ObjectUtilities.getClassLoader(AbstractModule.class\u0024org\u0024jfree\u0024base\u0024modules\u0024AbstractModule != null ? AbstractModule.class\u0024org\u0024jfree\u0024base\u0024modules\u0024AbstractModule : (AbstractModule.class\u0024org\u0024jfree\u0024base\u0024modules\u0024AbstractModule = AbstractModule.class\u0024("org.jfree.base.modules.AbstractModule")));
        if (classLoader == null)
          return false;
        classLoader.loadClass(name);
        num1 = 1;
      }
      catch (Exception ex)
      {
        int num2 = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2) == null)
          throw;
        else
          goto label_6;
      }
      return num1 != 0;
label_6:
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 60, (byte) 109, (byte) 154, (byte) 129})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static bool isClassLoadable(string name, Class context)
    {
      int num1;
      try
      {
        ObjectUtilities.getClassLoader(context).loadClass(name);
        num1 = 1;
      }
      catch (Exception ex)
      {
        int num2 = 2;
        if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2) == null)
          throw;
        else
          goto label_4;
      }
      return num1 != 0;
label_4:
      return false;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 77, (byte) 145, (byte) 131, (byte) 193, (byte) 245, (byte) 70, (byte) 241, (byte) 69, (byte) 226, (byte) 61, (byte) 161, (byte) 227, (byte) 59, (byte) 241, (byte) 69, (byte) 226, (byte) 61, (byte) 193, (byte) 98})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void configure(SubSystem subSystem)
    {
      InputStream relativeAsStream = ObjectUtilities.getResourceRelativeAsStream("configuration.properties", Object.instancehelper_getClass((object) this));
      if (relativeAsStream == null)
        return;
      // ISSUE: fault handler
      try
      {
        subSystem.getPackageManager().getPackageConfiguration().load(relativeAsStream);
      }
      __fault
      {
        try
        {
          relativeAsStream.close();
          goto label_5;
        }
        catch (IOException exception_1)
        {
        }
label_5:;
      }
      try
      {
        relativeAsStream.close();
      }
      catch (IOException ex)
      {
      }
    }

    [Throws(new string[] {"org.jfree.base.modules.ModuleInitializeException"})]
    [Obsolete]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 113, (byte) 159, (byte) 41, (byte) 131, (byte) 144, (byte) 255, (byte) 10, (byte) 73, (byte) 226, (byte) 57, (byte) 129, (byte) 135, (byte) 130, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void performExternalInitialize(string classname)
    {
      ModuleInitializeException initializeException;
      Exception exception1;
      try
      {
        try
        {
          ModuleInitializer moduleInitializer = (ModuleInitializer) ObjectUtilities.loadAndInstantiate(classname, AbstractModule.class\u0024org\u0024jfree\u0024base\u0024modules\u0024AbstractModule != null ? AbstractModule.class\u0024org\u0024jfree\u0024base\u0024modules\u0024AbstractModule : (AbstractModule.class\u0024org\u0024jfree\u0024base\u0024modules\u0024AbstractModule = AbstractModule.class\u0024("org.jfree.base.modules.AbstractModule")), AbstractModule.class\u0024org\u0024jfree\u0024base\u0024modules\u0024ModuleInitializer != null ? AbstractModule.class\u0024org\u0024jfree\u0024base\u0024modules\u0024ModuleInitializer : (AbstractModule.class\u0024org\u0024jfree\u0024base\u0024modules\u0024ModuleInitializer = AbstractModule.class\u0024("org.jfree.base.modules.ModuleInitializer")));
          if (moduleInitializer == null)
          {
            string s = "Failed to load specified initializer class.";
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new ModuleInitializeException(s);
          }
          else
          {
            moduleInitializer.performInit();
            return;
          }
        }
        catch (ModuleInitializeException ex)
        {
          int num = 1;
          initializeException = (ModuleInitializeException) ByteCodeHelper.MapException<ModuleInitializeException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
        {
          throw;
        }
        else
        {
          exception1 = (Exception) m0;
          goto label_8;
        }
      }
      throw Throwable.__\u003Cunmap\u003E((Exception) initializeException);
label_8:
      Exception exception2 = exception1;
      string s1 = "Failed to load specified initializer class.";
      Exception e = exception2;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new ModuleInitializeException(s1, e);
    }

    [Throws(new string[] {"org.jfree.base.modules.ModuleInitializeException"})]
    [LineNumberTable(new byte[] {(byte) 162, (byte) 143, (byte) 159, (byte) 12, (byte) 131, (byte) 144, (byte) 255, (byte) 10, (byte) 73, (byte) 226, (byte) 57, (byte) 129, (byte) 135, (byte) 130, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void performExternalInitialize(string classname, Class context)
    {
      ModuleInitializeException initializeException;
      Exception exception1;
      try
      {
        try
        {
          ModuleInitializer moduleInitializer = (ModuleInitializer) ObjectUtilities.loadAndInstantiate(classname, context, AbstractModule.class\u0024org\u0024jfree\u0024base\u0024modules\u0024ModuleInitializer != null ? AbstractModule.class\u0024org\u0024jfree\u0024base\u0024modules\u0024ModuleInitializer : (AbstractModule.class\u0024org\u0024jfree\u0024base\u0024modules\u0024ModuleInitializer = AbstractModule.class\u0024("org.jfree.base.modules.ModuleInitializer")));
          if (moduleInitializer == null)
          {
            string s = "Failed to load specified initializer class.";
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new ModuleInitializeException(s);
          }
          else
          {
            moduleInitializer.performInit();
            return;
          }
        }
        catch (ModuleInitializeException ex)
        {
          int num = 1;
          initializeException = (ModuleInitializeException) ByteCodeHelper.MapException<ModuleInitializeException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
        {
          throw;
        }
        else
        {
          exception1 = (Exception) m0;
          goto label_8;
        }
      }
      throw Throwable.__\u003Cunmap\u003E((Exception) initializeException);
label_8:
      Exception exception2 = exception1;
      string s1 = "Failed to load specified initializer class.";
      Exception e = exception2;
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new ModuleInitializeException(s1, e);
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 169, (byte) 136, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getSubSystem()
    {
      if (this.subsystem != null)
        return this.subsystem;
      return this.getName();
    }

    [HideFromReflection]
    public abstract void initialize([In] SubSystem obj0);

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (AbstractModule.__\u003CcallerID\u003E == null)
        AbstractModule.__\u003CcallerID\u003E = (CallerID) new AbstractModule.__\u003CCallerID\u003E();
      return AbstractModule.__\u003CcallerID\u003E;
    }

    [InnerClass]
    [SourceFile("AbstractModule.java")]
    [Modifiers]
    internal sealed class ReaderHelper : Object
    {
      private string buffer;
      [Modifiers]
      private BufferedReader reader;

      [LineNumberTable(new byte[] {(byte) 68, (byte) 104, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal ReaderHelper([In] BufferedReader obj0)
      {
        base.\u002Ector();
        AbstractModule.ReaderHelper readerHelper = this;
        this.reader = obj0;
      }

      [Throws(new string[] {"java.io.IOException"})]
      [LineNumberTable(new byte[] {(byte) 81, (byte) 136, (byte) 140})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool hasNext()
      {
        if (this.buffer == null)
          this.buffer = this.readLine();
        return this.buffer != null;
      }

      public virtual string next()
      {
        string str = this.buffer;
        this.buffer = (string) null;
        return str;
      }

      [Throws(new string[] {"java.io.IOException"})]
      [LineNumberTable(new byte[] {(byte) 160, (byte) 71, (byte) 109})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void close()
      {
        this.reader.close();
      }

      public virtual void pushBack([In] string obj0)
      {
        this.buffer = obj0;
      }

      [Throws(new string[] {"java.io.IOException"})]
      [LineNumberTable(new byte[] {(byte) 119, (byte) 108, (byte) 184, (byte) 142})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal virtual string readLine()
      {
        string str = this.reader.readLine();
        while (str != null && (String.instancehelper_length(str) == 0 || String.instancehelper_startsWith(str, "#")))
          str = this.reader.readLine();
        return str;
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
