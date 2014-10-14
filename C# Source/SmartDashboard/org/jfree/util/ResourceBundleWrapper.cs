// Decompiled with JetBrains decompiler
// Type: org.jfree.util.ResourceBundleWrapper
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.lang;
using java.net;
using java.util;
using System.Runtime.CompilerServices;

namespace org.jfree.util
{
  public class ResourceBundleWrapper : Object
  {
    private static URLClassLoader noCodeBaseClassLoader;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 32, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private ResourceBundleWrapper()
    {
      base.\u002Ector();
    }

    [Modifiers]
    [LineNumberTable(new byte[] {(byte) 72, (byte) 103, (byte) 243, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ResourceBundle getBundle(string baseName)
    {
      if (ResourceBundleWrapper.noCodeBaseClassLoader != null)
        return ResourceBundle.getBundle(baseName, Locale.getDefault(), (ClassLoader) ResourceBundleWrapper.noCodeBaseClassLoader);
      else
        return ResourceBundle.getBundle(baseName, ResourceBundleWrapper.__\u003CGetCallerID\u003E());
    }

    [Modifiers]
    [LineNumberTable(new byte[] {(byte) 96, (byte) 103, (byte) 239, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ResourceBundle getBundle(string baseName, Locale locale)
    {
      if (ResourceBundleWrapper.noCodeBaseClassLoader != null)
        return ResourceBundle.getBundle(baseName, locale, (ClassLoader) ResourceBundleWrapper.noCodeBaseClassLoader);
      else
        return ResourceBundle.getBundle(baseName, locale, ResourceBundleWrapper.__\u003CGetCallerID\u003E());
    }

    [LineNumberTable(new byte[] {(byte) 48, (byte) 134, (byte) 103, (byte) 103, (byte) 107, (byte) 10, (byte) 230, (byte) 70, (byte) 119, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void removeCodeBase(URL codeBase, URLClassLoader urlClassLoader)
    {
      ArrayList arrayList = new ArrayList();
      URL[] urLs = urlClassLoader.getURLs();
      for (int index = 0; index < urLs.Length; ++index)
      {
        if (!urLs[index].sameFile(codeBase))
          ((List) arrayList).add((object) urLs[index]);
      }
      ResourceBundleWrapper.noCodeBaseClassLoader = URLClassLoader.newInstance((URL[]) ((List) arrayList).toArray((object[]) new URL[0]));
    }

    [LineNumberTable((ushort) 168)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ResourceBundle getBundle(string baseName, Locale locale, ClassLoader loader)
    {
      return ResourceBundle.getBundle(baseName, locale, loader);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (ResourceBundleWrapper.__\u003CcallerID\u003E == null)
        ResourceBundleWrapper.__\u003CcallerID\u003E = (CallerID) new ResourceBundleWrapper.__\u003CCallerID\u003E();
      return ResourceBundleWrapper.__\u003CcallerID\u003E;
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
