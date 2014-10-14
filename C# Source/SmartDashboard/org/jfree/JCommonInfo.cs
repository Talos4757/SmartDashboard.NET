// Decompiled with JetBrains decompiler
// Type: org.jfree.JCommonInfo
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using org.jfree.@base;
using org.jfree.ui.about;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree
{
  public class JCommonInfo : ProjectInfo
  {
    private static JCommonInfo singleton;
    internal static Class class\u0024org\u0024jfree\u0024base\u0024BaseBoot;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 33, (byte) 168, (byte) 102, (byte) 171, (byte) 113, (byte) 113, (byte) 113, (byte) 145, (byte) 107, (byte) 144, (byte) 255, (byte) 160, (byte) 237, (byte) 87, (byte) 191, (byte) 0, (byte) 127, (byte) 12})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private JCommonInfo()
    {
      JCommonInfo jcommonInfo = this;
      ResourceBundle bundle = ResourceBundleWrapper.getBundle("org.jfree.resources.JCommonResources");
      this.setName(bundle.getString("project.name"));
      this.setVersion(bundle.getString("project.version"));
      this.setInfo(bundle.getString("project.info"));
      this.setCopyright(bundle.getString("project.copyright"));
      this.setLicenceName("LGPL");
      this.setLicenceText(Licences.getInstance().getLGPL());
      Contributor[] contributorArray = new Contributor[17];
      int index1 = 0;
      Contributor contributor1 = new Contributor("Anthony Boulestreau", "-");
      contributorArray[index1] = contributor1;
      int index2 = 1;
      Contributor contributor2 = new Contributor("Jeremy Bowman", "-");
      contributorArray[index2] = contributor2;
      int index3 = 2;
      Contributor contributor3 = new Contributor("J. David Eisenberg", "-");
      contributorArray[index3] = contributor3;
      int index4 = 3;
      Contributor contributor4 = new Contributor("Paul English", "-");
      contributorArray[index4] = contributor4;
      int index5 = 4;
      Contributor contributor5 = new Contributor("David Gilbert", "david.gilbert@object-refinery.com");
      contributorArray[index5] = contributor5;
      int index6 = 5;
      Contributor contributor6 = new Contributor("Hans-Jurgen Greiner", "-");
      contributorArray[index6] = contributor6;
      int index7 = 6;
      Contributor contributor7 = new Contributor("Arik Levin", "-");
      contributorArray[index7] = contributor7;
      int index8 = 7;
      Contributor contributor8 = new Contributor("Achilleus Mantzios", "-");
      contributorArray[index8] = contributor8;
      int index9 = 8;
      Contributor contributor9 = new Contributor("Thomas Meier", "-");
      contributorArray[index9] = contributor9;
      int index10 = 9;
      Contributor contributor10 = new Contributor("Aaron Metzger", "-");
      contributorArray[index10] = contributor10;
      int index11 = 10;
      Contributor contributor11 = new Contributor("Thomas Morgner", "-");
      contributorArray[index11] = contributor11;
      int index12 = 11;
      Contributor contributor12 = new Contributor("Krzysztof Paz", "-");
      contributorArray[index12] = contributor12;
      int index13 = 12;
      Contributor contributor13 = new Contributor("Nabuo Tamemasa", "-");
      contributorArray[index13] = contributor13;
      int index14 = 13;
      Contributor contributor14 = new Contributor("Mark Watson", "-");
      contributorArray[index14] = contributor14;
      int index15 = 14;
      Contributor contributor15 = new Contributor("Matthew Wright", "-");
      contributorArray[index15] = contributor15;
      int index16 = 15;
      Contributor contributor16 = new Contributor("Hari", "-");
      contributorArray[index16] = contributor16;
      int index17 = 16;
      Contributor contributor17 = new Contributor("Sam (oldman)", "-");
      contributorArray[index17] = contributor17;
      this.setContributors(Arrays.asList((object[]) contributorArray));
      this.addOptionalLibrary(new Library("JUnit", "3.8", "IBM Public Licence", "http://www.junit.org/"));
      this.setBootClass((JCommonInfo.class\u0024org\u0024jfree\u0024base\u0024BaseBoot != null ? JCommonInfo.class\u0024org\u0024jfree\u0024base\u0024BaseBoot : (JCommonInfo.class\u0024org\u0024jfree\u0024base\u0024BaseBoot = JCommonInfo.class\u0024("org.jfree.base.BaseBoot"))).getName());
    }

    [Modifiers]
    [LineNumberTable(new byte[] {(byte) 159, (byte) 124, (byte) 140, (byte) 103, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static JCommonInfo getInstance()
    {
      lock ((object) ClassLiteral<JCommonInfo>.Value)
      {
        if (JCommonInfo.singleton == null)
          JCommonInfo.singleton = new JCommonInfo();
        return JCommonInfo.singleton;
      }
    }

    [LineNumberTable((ushort) 124)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, JCommonInfo.__\u003CGetCallerID\u003E());
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

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (JCommonInfo.__\u003CcallerID\u003E == null)
        JCommonInfo.__\u003CcallerID\u003E = (CallerID) new JCommonInfo.__\u003CCallerID\u003E();
      return JCommonInfo.__\u003CcallerID\u003E;
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
