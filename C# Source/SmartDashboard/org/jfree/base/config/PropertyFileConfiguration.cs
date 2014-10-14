// Decompiled with JetBrains decompiler
// Type: org.jfree.base.config.PropertyFileConfiguration
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using org.jfree.@base.config;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.@base.config
{
  [Serializable]
  public class PropertyFileConfiguration : HierarchicalConfiguration
  {
    internal static Class class\u0024org\u0024jfree\u0024base\u0024config\u0024PropertyFileConfiguration;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 11, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyFileConfiguration()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PropertyFileConfiguration([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [LineNumberTable(new byte[] {(byte) 35, (byte) 136, (byte) 195, (byte) 235, (byte) 70, (byte) 241, (byte) 69, (byte) 226, (byte) 61, (byte) 161, (byte) 227, (byte) 59, (byte) 241, (byte) 69, (byte) 226, (byte) 61, (byte) 193, (byte) 196, (byte) 191, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void load(string resourceName, Class resourceSource)
    {
      InputStream relativeAsStream = ObjectUtilities.getResourceRelativeAsStream(resourceName, resourceSource);
      if (relativeAsStream != null)
      {
        // ISSUE: fault handler
        try
        {
          this.load(relativeAsStream);
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
      else
        Log.debug((object) new StringBuffer().append("Configuration file not found in the classpath: ").append(resourceName).toString());
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 131, (byte) 235, (byte) 69, (byte) 103, (byte) 102, (byte) 103, (byte) 108, (byte) 248, (byte) 69, (byte) 226, (byte) 61, (byte) 129, (byte) 171})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void load(InputStream @in)
    {
      if (@in == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else
      {
        IOException ioException;
        try
        {
          BufferedInputStream bufferedInputStream = new BufferedInputStream(@in);
          Properties properties = new Properties();
          properties.load((InputStream) bufferedInputStream);
          ((Hashtable) this.getConfiguration()).putAll((Map) properties);
          bufferedInputStream.close();
          return;
        }
        catch (IOException ex)
        {
          int num = 1;
          ioException = (IOException) ByteCodeHelper.MapException<IOException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
        Log.warn((object) "Unable to read configuration", (Exception) ioException);
      }
    }

    [LineNumberTable((ushort) 72)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, PropertyFileConfiguration.__\u003CGetCallerID\u003E());
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

    [LineNumberTable(new byte[] {(byte) 22, (byte) 127, (byte) 8})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void load(string resourceName)
    {
      this.load(resourceName, PropertyFileConfiguration.class\u0024org\u0024jfree\u0024base\u0024config\u0024PropertyFileConfiguration != null ? PropertyFileConfiguration.class\u0024org\u0024jfree\u0024base\u0024config\u0024PropertyFileConfiguration : (PropertyFileConfiguration.class\u0024org\u0024jfree\u0024base\u0024config\u0024PropertyFileConfiguration = PropertyFileConfiguration.class\u0024("org.jfree.base.config.PropertyFileConfiguration")));
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (PropertyFileConfiguration.__\u003CcallerID\u003E == null)
        PropertyFileConfiguration.__\u003CcallerID\u003E = (CallerID) new PropertyFileConfiguration.__\u003CCallerID\u003E();
      return PropertyFileConfiguration.__\u003CcallerID\u003E;
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
