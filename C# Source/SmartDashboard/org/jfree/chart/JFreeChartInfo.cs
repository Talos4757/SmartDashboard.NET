// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.JFreeChartInfo
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.awt;
using java.lang;
using java.net;
using java.util;
using javax.swing;
using org.jfree;
using org.jfree.@base;
using org.jfree.chart.util;
using org.jfree.ui.about;
using System.Runtime.CompilerServices;

namespace org.jfree.chart
{
  [SourceFile("JFreeChart.java")]
  [Modifiers]
  internal sealed class JFreeChartInfo : ProjectInfo
  {
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 166, (byte) 99, (byte) 168, (byte) 134, (byte) 167, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 103, (byte) 107, (byte) 144, (byte) 255, (byte) 166, (byte) 164, (byte) 160, (byte) 102, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public JFreeChartInfo()
    {
      JFreeChartInfo jfreeChartInfo = this;
      ResourceBundle bundle = ResourceBundleWrapper.getBundle("org.jfree.chart.resources.JFreeChartResources");
      this.setName(bundle.getString("project.name"));
      this.setVersion(bundle.getString("project.version"));
      this.setInfo(bundle.getString("project.info"));
      this.setCopyright(bundle.getString("project.copyright"));
      this.setLogo((Image) null);
      this.setLicenceName("LGPL");
      this.setLicenceText(Licences.getInstance().getLGPL());
      Contributor[] contributorArray = new Contributor[94];
      int index1 = 0;
      Contributor contributor1 = new Contributor("Eric Alexander", "-");
      contributorArray[index1] = contributor1;
      int index2 = 1;
      Contributor contributor2 = new Contributor("Richard Atkinson", "richard_c_atkinson@ntlworld.com");
      contributorArray[index2] = contributor2;
      int index3 = 2;
      Contributor contributor3 = new Contributor("David Basten", "-");
      contributorArray[index3] = contributor3;
      int index4 = 3;
      Contributor contributor4 = new Contributor("David Berry", "-");
      contributorArray[index4] = contributor4;
      int index5 = 4;
      Contributor contributor5 = new Contributor("Chris Boek", "-");
      contributorArray[index5] = contributor5;
      int index6 = 5;
      Contributor contributor6 = new Contributor("Zoheb Borbora", "-");
      contributorArray[index6] = contributor6;
      int index7 = 6;
      Contributor contributor7 = new Contributor("Anthony Boulestreau", "-");
      contributorArray[index7] = contributor7;
      int index8 = 7;
      Contributor contributor8 = new Contributor("Jeremy Bowman", "-");
      contributorArray[index8] = contributor8;
      int index9 = 8;
      Contributor contributor9 = new Contributor("Nicolas Brodu", "-");
      contributorArray[index9] = contributor9;
      int index10 = 9;
      Contributor contributor10 = new Contributor("Jody Brownell", "-");
      contributorArray[index10] = contributor10;
      int index11 = 10;
      Contributor contributor11 = new Contributor("David Browning", "-");
      contributorArray[index11] = contributor11;
      int index12 = 11;
      Contributor contributor12 = new Contributor("Soren Caspersen", "-");
      contributorArray[index12] = contributor12;
      int index13 = 12;
      Contributor contributor13 = new Contributor("Chuanhao Chiu", "-");
      contributorArray[index13] = contributor13;
      int index14 = 13;
      Contributor contributor14 = new Contributor("Brian Cole", "-");
      contributorArray[index14] = contributor14;
      int index15 = 14;
      Contributor contributor15 = new Contributor("Pascal Collet", "-");
      contributorArray[index15] = contributor15;
      int index16 = 15;
      Contributor contributor16 = new Contributor("Martin Cordova", "-");
      contributorArray[index16] = contributor16;
      int index17 = 16;
      Contributor contributor17 = new Contributor("Paolo Cova", "-");
      contributorArray[index17] = contributor17;
      int index18 = 17;
      Contributor contributor18 = new Contributor("Greg Darke", "-");
      contributorArray[index18] = contributor18;
      int index19 = 18;
      Contributor contributor19 = new Contributor("Mike Duffy", "-");
      contributorArray[index19] = contributor19;
      int index20 = 19;
      Contributor contributor20 = new Contributor("Don Elliott", "-");
      contributorArray[index20] = contributor20;
      int index21 = 20;
      Contributor contributor21 = new Contributor("David Forslund", "-");
      contributorArray[index21] = contributor21;
      int index22 = 21;
      Contributor contributor22 = new Contributor("Jonathan Gabbai", "-");
      contributorArray[index22] = contributor22;
      int index23 = 22;
      Contributor contributor23 = new Contributor("David Gilbert", "david.gilbert@object-refinery.com");
      contributorArray[index23] = contributor23;
      int index24 = 23;
      Contributor contributor24 = new Contributor("Serge V. Grachov", "-");
      contributorArray[index24] = contributor24;
      int index25 = 24;
      Contributor contributor25 = new Contributor("Daniel Gredler", "-");
      contributorArray[index25] = contributor25;
      int index26 = 25;
      Contributor contributor26 = new Contributor("Hans-Jurgen Greiner", "-");
      contributorArray[index26] = contributor26;
      int index27 = 26;
      Contributor contributor27 = new Contributor("Joao Guilherme Del Valle", "-");
      contributorArray[index27] = contributor27;
      int index28 = 27;
      Contributor contributor28 = new Contributor("Aiman Han", "-");
      contributorArray[index28] = contributor28;
      int index29 = 28;
      Contributor contributor29 = new Contributor("Cameron Hayne", "-");
      contributorArray[index29] = contributor29;
      int index30 = 29;
      Contributor contributor30 = new Contributor("Martin Hoeller", "-");
      contributorArray[index30] = contributor30;
      int index31 = 30;
      Contributor contributor31 = new Contributor("Jon Iles", "-");
      contributorArray[index31] = contributor31;
      int index32 = 31;
      Contributor contributor32 = new Contributor("Wolfgang Irler", "-");
      contributorArray[index32] = contributor32;
      int index33 = 32;
      Contributor contributor33 = new Contributor("Sergei Ivanov", "-");
      contributorArray[index33] = contributor33;
      int index34 = 33;
      Contributor contributor34 = new Contributor("Adriaan Joubert", "-");
      contributorArray[index34] = contributor34;
      int index35 = 34;
      Contributor contributor35 = new Contributor("Darren Jung", "-");
      contributorArray[index35] = contributor35;
      int index36 = 35;
      Contributor contributor36 = new Contributor("Xun Kang", "-");
      contributorArray[index36] = contributor36;
      int index37 = 36;
      Contributor contributor37 = new Contributor("Bill Kelemen", "-");
      contributorArray[index37] = contributor37;
      int index38 = 37;
      Contributor contributor38 = new Contributor("Norbert Kiesel", "-");
      contributorArray[index38] = contributor38;
      int index39 = 38;
      Contributor contributor39 = new Contributor("Peter Kolb", "-");
      contributorArray[index39] = contributor39;
      int index40 = 39;
      Contributor contributor40 = new Contributor("Gideon Krause", "-");
      contributorArray[index40] = contributor40;
      int index41 = 40;
      Contributor contributor41 = new Contributor("Pierre-Marie Le Biot", "-");
      contributorArray[index41] = contributor41;
      int index42 = 41;
      Contributor contributor42 = new Contributor("Arnaud Lelievre", "-");
      contributorArray[index42] = contributor42;
      int index43 = 42;
      Contributor contributor43 = new Contributor("Wolfgang Lenhard", "-");
      contributorArray[index43] = contributor43;
      int index44 = 43;
      Contributor contributor44 = new Contributor("David Li", "-");
      contributorArray[index44] = contributor44;
      int index45 = 44;
      Contributor contributor45 = new Contributor("Yan Liu", "-");
      contributorArray[index45] = contributor45;
      int index46 = 45;
      Contributor contributor46 = new Contributor("Tin Luu", "-");
      contributorArray[index46] = contributor46;
      int index47 = 46;
      Contributor contributor47 = new Contributor("Craig MacFarlane", "-");
      contributorArray[index47] = contributor47;
      int index48 = 47;
      Contributor contributor48 = new Contributor("Achilleus Mantzios", "-");
      contributorArray[index48] = contributor48;
      int index49 = 48;
      Contributor contributor49 = new Contributor("Thomas Meier", "-");
      contributorArray[index49] = contributor49;
      int index50 = 49;
      Contributor contributor50 = new Contributor("Jim Moore", "-");
      contributorArray[index50] = contributor50;
      int index51 = 50;
      Contributor contributor51 = new Contributor("Jonathan Nash", "-");
      contributorArray[index51] = contributor51;
      int index52 = 51;
      Contributor contributor52 = new Contributor("Barak Naveh", "-");
      contributorArray[index52] = contributor52;
      int index53 = 52;
      Contributor contributor53 = new Contributor("David M. O'Donnell", "-");
      contributorArray[index53] = contributor53;
      int index54 = 53;
      Contributor contributor54 = new Contributor("Krzysztof Paz", "-");
      contributorArray[index54] = contributor54;
      int index55 = 54;
      Contributor contributor55 = new Contributor("Eric Penfold", "-");
      contributorArray[index55] = contributor55;
      int index56 = 55;
      Contributor contributor56 = new Contributor("Tomer Peretz", "-");
      contributorArray[index56] = contributor56;
      int index57 = 56;
      Contributor contributor57 = new Contributor("Diego Pierangeli", "-");
      contributorArray[index57] = contributor57;
      int index58 = 57;
      Contributor contributor58 = new Contributor("Xavier Poinsard", "-");
      contributorArray[index58] = contributor58;
      int index59 = 58;
      Contributor contributor59 = new Contributor("Andrzej Porebski", "-");
      contributorArray[index59] = contributor59;
      int index60 = 59;
      Contributor contributor60 = new Contributor("Viktor Rajewski", "-");
      contributorArray[index60] = contributor60;
      int index61 = 60;
      Contributor contributor61 = new Contributor("Eduardo Ramalho", "-");
      contributorArray[index61] = contributor61;
      int index62 = 61;
      Contributor contributor62 = new Contributor("Michael Rauch", "-");
      contributorArray[index62] = contributor62;
      int index63 = 62;
      Contributor contributor63 = new Contributor("Cameron Riley", "-");
      contributorArray[index63] = contributor63;
      int index64 = 63;
      Contributor contributor64 = new Contributor("Klaus Rheinwald", "-");
      contributorArray[index64] = contributor64;
      int index65 = 64;
      Contributor contributor65 = new Contributor("Dan Rivett", "d.rivett@ukonline.co.uk");
      contributorArray[index65] = contributor65;
      int index66 = 65;
      Contributor contributor66 = new Contributor("Scott Sams", "-");
      contributorArray[index66] = contributor66;
      int index67 = 66;
      Contributor contributor67 = new Contributor("Michel Santos", "-");
      contributorArray[index67] = contributor67;
      int index68 = 67;
      Contributor contributor68 = new Contributor("Thierry Saura", "-");
      contributorArray[index68] = contributor68;
      int index69 = 68;
      Contributor contributor69 = new Contributor("Andreas Schneider", "-");
      contributorArray[index69] = contributor69;
      int index70 = 69;
      Contributor contributor70 = new Contributor("Jean-Luc SCHWAB", "-");
      contributorArray[index70] = contributor70;
      int index71 = 70;
      Contributor contributor71 = new Contributor("Bryan Scott", "-");
      contributorArray[index71] = contributor71;
      int index72 = 71;
      Contributor contributor72 = new Contributor("Tobias Selb", "-");
      contributorArray[index72] = contributor72;
      int index73 = 72;
      Contributor contributor73 = new Contributor("Darshan Shah", "-");
      contributorArray[index73] = contributor73;
      int index74 = 73;
      Contributor contributor74 = new Contributor("Mofeed Shahin", "-");
      contributorArray[index74] = contributor74;
      int index75 = 74;
      Contributor contributor75 = new Contributor("Michael Siemer", "-");
      contributorArray[index75] = contributor75;
      int index76 = 75;
      Contributor contributor76 = new Contributor("Pady Srinivasan", "-");
      contributorArray[index76] = contributor76;
      int index77 = 76;
      Contributor contributor77 = new Contributor("Greg Steckman", "-");
      contributorArray[index77] = contributor77;
      int index78 = 77;
      Contributor contributor78 = new Contributor("Gerald Struck", "-");
      contributorArray[index78] = contributor78;
      int index79 = 78;
      Contributor contributor79 = new Contributor("Roger Studner", "-");
      contributorArray[index79] = contributor79;
      int index80 = 79;
      Contributor contributor80 = new Contributor("Irv Thomae", "-");
      contributorArray[index80] = contributor80;
      int index81 = 80;
      Contributor contributor81 = new Contributor("Eric Thomas", "-");
      contributorArray[index81] = contributor81;
      int index82 = 81;
      Contributor contributor82 = new Contributor("Rich Unger", "-");
      contributorArray[index82] = contributor82;
      int index83 = 82;
      Contributor contributor83 = new Contributor("Daniel van Enckevort", "-");
      contributorArray[index83] = contributor83;
      int index84 = 83;
      Contributor contributor84 = new Contributor("Laurence Vanhelsuwe", "-");
      contributorArray[index84] = contributor84;
      int index85 = 84;
      Contributor contributor85 = new Contributor("Sylvain Vieujot", "-");
      contributorArray[index85] = contributor85;
      int index86 = 85;
      Contributor contributor86 = new Contributor("Ulrich Voigt", "-");
      contributorArray[index86] = contributor86;
      int index87 = 86;
      Contributor contributor87 = new Contributor("Jelai Wang", "-");
      contributorArray[index87] = contributor87;
      int index88 = 87;
      Contributor contributor88 = new Contributor("Mark Watson", "www.markwatson.com");
      contributorArray[index88] = contributor88;
      int index89 = 88;
      Contributor contributor89 = new Contributor("Alex Weber", "-");
      contributorArray[index89] = contributor89;
      int index90 = 89;
      Contributor contributor90 = new Contributor("Matthew Wright", "-");
      contributorArray[index90] = contributor90;
      int index91 = 90;
      Contributor contributor91 = new Contributor("Benoit Xhenseval", "-");
      contributorArray[index91] = contributor91;
      int index92 = 91;
      Contributor contributor92 = new Contributor("Christian W. Zuckschwerdt", "Christian.Zuckschwerdt@Informatik.Uni-Oldenburg.de");
      contributorArray[index92] = contributor92;
      int index93 = 92;
      Contributor contributor93 = new Contributor("Hari", "-");
      contributorArray[index93] = contributor93;
      int index94 = 93;
      Contributor contributor94 = new Contributor("Sam (oldman)", "-");
      contributorArray[index94] = contributor94;
      this.setContributors(Arrays.asList((object[]) contributorArray));
      this.addLibrary((Library) JCommon.__\u003C\u003EINFO);
    }

    [LineNumberTable(new byte[] {(byte) 166, (byte) 228, (byte) 103, (byte) 99, (byte) 155, (byte) 99, (byte) 135, (byte) 103, (byte) 167})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Image getLogo()
    {
      Image logo = base.getLogo();
      if (logo == null)
      {
        URL resource = Object.instancehelper_getClass((object) this).getClassLoader(JFreeChartInfo.__\u003CGetCallerID\u003E()).getResource("org/jfree/chart/gorilla.jpg");
        if (resource != null)
        {
          logo = new ImageIcon(resource).getImage();
          this.setLogo(logo);
        }
      }
      return logo;
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (JFreeChartInfo.__\u003CcallerID\u003E == null)
        JFreeChartInfo.__\u003CcallerID\u003E = (CallerID) new JFreeChartInfo.__\u003CCallerID\u003E();
      return JFreeChartInfo.__\u003CcallerID\u003E;
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
