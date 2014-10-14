// Decompiled with JetBrains decompiler
// Type: org.jfree.base.BasicProjectInfo
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using org.jfree.@base;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.@base
{
  public class BasicProjectInfo : Library
  {
    private string copyright;
    private List libraries;
    private List optionalLibraries;

    [LineNumberTable(new byte[] {(byte) 77, (byte) 104, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BasicProjectInfo()
    {
      BasicProjectInfo basicProjectInfo = this;
      this.libraries = (List) new ArrayList();
      this.optionalLibraries = (List) new ArrayList();
    }

    [LineNumberTable(new byte[] {(byte) 92, (byte) 104, (byte) 103, (byte) 103, (byte) 103, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BasicProjectInfo(string name, string version, string licence, string info)
      : this()
    {
      BasicProjectInfo basicProjectInfo = this;
      this.setName(name);
      this.setVersion(version);
      this.setLicenceName(licence);
      this.setInfo(info);
    }

    [LineNumberTable(new byte[] {(byte) 111, (byte) 109, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public BasicProjectInfo(string name, string version, string info, string copyright, string licenceName)
      : this(name, version, licenceName, info)
    {
      BasicProjectInfo basicProjectInfo = this;
      this.setCopyright(copyright);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 93, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setName(string name)
    {
      base.setName(name);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 102, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setVersion(string version)
    {
      base.setVersion(version);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 84, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setLicenceName(string licence)
    {
      base.setLicenceName(licence);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 75, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setInfo(string info)
    {
      base.setInfo(info);
    }

    public virtual void setCopyright(string copyright)
    {
      this.copyright = copyright;
    }

    public virtual string getCopyright()
    {
      return this.copyright;
    }

    [LineNumberTable((ushort) 225)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Library[] getLibraries()
    {
      return (Library[]) this.libraries.toArray((object[]) new Library[this.libraries.size()]);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 121, (byte) 99, (byte) 139, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addLibrary(Library library)
    {
      if (library == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else
        this.libraries.add((object) library);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 133, (byte) 102, (byte) 112, (byte) 146, (byte) 103, (byte) 99, (byte) 232, (byte) 59, (byte) 230, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Library[] getOptionalLibraries()
    {
      ArrayList arrayList = new ArrayList();
      for (int index = 0; index < this.optionalLibraries.size(); ++index)
      {
        Library library = ((BasicProjectInfo.OptionalLibraryHolder) this.optionalLibraries.get(index)).getLibrary();
        if (library != null)
          arrayList.add((object) library);
      }
      return (Library[]) arrayList.toArray((object[]) new Library[arrayList.size()]);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 153, (byte) 99, (byte) 144, (byte) 146})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addOptionalLibrary(string libraryClass)
    {
      if (libraryClass == null)
      {
        string str = "Library classname must be given.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
        this.optionalLibraries.add((object) new BasicProjectInfo.OptionalLibraryHolder(libraryClass));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 169, (byte) 99, (byte) 144, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void addOptionalLibrary(Library library)
    {
      if (library == null)
      {
        string str = "Library must be given.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
        this.optionalLibraries.add((object) new BasicProjectInfo.OptionalLibraryHolder(library));
    }

    [InnerClass]
    [SourceFile("BasicProjectInfo.java")]
    [Modifiers]
    internal sealed class OptionalLibraryHolder : Object
    {
      private string libraryClass;
      [NonSerialized]
      private Library library;
      [SpecialName]
      private static CallerID __\u003CcallerID\u003E;

      [LineNumberTable(new byte[] {(byte) 15, (byte) 104, (byte) 99, (byte) 144, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public OptionalLibraryHolder([In] string obj0)
      {
        base.\u002Ector();
        BasicProjectInfo.OptionalLibraryHolder optionalLibraryHolder = this;
        if (obj0 == null)
        {
          string str = "LibraryClass must not be null.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new NullPointerException(str);
        }
        else
          this.libraryClass = obj0;
      }

      [LineNumberTable(new byte[] {(byte) 22, (byte) 104, (byte) 99, (byte) 144, (byte) 103, (byte) 113})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public OptionalLibraryHolder([In] Library obj0)
      {
        base.\u002Ector();
        BasicProjectInfo.OptionalLibraryHolder optionalLibraryHolder = this;
        if (obj0 == null)
        {
          string str = "Library must not be null.";
          Throwable.__\u003CsuppressFillInStackTrace\u003E();
          throw new NullPointerException(str);
        }
        else
        {
          this.library = obj0;
          this.libraryClass = Object.instancehelper_getClass((object) obj0).getName();
        }
      }

      [LineNumberTable(new byte[] {(byte) 35, (byte) 104, (byte) 146})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual Library getLibrary()
      {
        if (this.library == null)
          this.library = this.loadLibrary(this.libraryClass);
        return this.library;
      }

      [LineNumberTable(new byte[] {(byte) 42, (byte) 99, (byte) 162, (byte) 178, (byte) 119, (byte) 159, (byte) 40, (byte) 161, (byte) 159, (byte) 10, (byte) 161})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal virtual Library loadLibrary([In] string obj0)
      {
        if (obj0 == null)
          return (Library) null;
        Class @class;
        try
        {
          @class = ObjectUtilities.getClassLoader(Object.instancehelper_getClass((object) this)).loadClass(obj0);
          Library library;
          try
          {
            library = (Library) @class.getMethod("getInstance", (Class[]) null, BasicProjectInfo.OptionalLibraryHolder.__\u003CGetCallerID\u003E()).invoke((object) null, (object[]) null, BasicProjectInfo.OptionalLibraryHolder.__\u003CGetCallerID\u003E());
          }
          catch (Exception ex)
          {
            int num = 2;
            if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
              throw;
            else
              goto label_9;
          }
          return library;
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
          else
            goto label_10;
        }
label_9:
        Library library1;
        try
        {
          library1 = (Library) @class.newInstance(BasicProjectInfo.OptionalLibraryHolder.__\u003CGetCallerID\u003E());
        }
        catch (Exception ex)
        {
          int num = 2;
          if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num) == null)
            throw;
          else
            goto label_15;
        }
        return library1;
label_15:
        // ISSUE: variable of the null type
        __Null local = null;
        goto label_16;
label_10:
        local = null;
label_16:
        return (Library) null;
      }

      public virtual string getLibraryClass()
      {
        return this.libraryClass;
      }

      [SpecialName]
      private static CallerID __\u003CGetCallerID\u003E()
      {
        if (BasicProjectInfo.OptionalLibraryHolder.__\u003CcallerID\u003E == null)
          BasicProjectInfo.OptionalLibraryHolder.__\u003CcallerID\u003E = (CallerID) new BasicProjectInfo.OptionalLibraryHolder.__\u003CCallerID\u003E();
        return BasicProjectInfo.OptionalLibraryHolder.__\u003CcallerID\u003E;
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
}
