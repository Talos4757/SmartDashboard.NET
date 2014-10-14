// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.about.AboutDialog
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using java.util;
using javax.swing;
using javax.swing.border;
using javax.swing.text;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui.about
{
  [Serializable]
  public class AboutDialog : JDialog
  {
    internal static Dimension __\u003C\u003EPREFERRED_SIZE;
    internal static Border __\u003C\u003ESTANDARD_BORDER;
    private ResourceBundle resources;
    private string application;
    private string version;
    private string copyright;
    private string info;
    private Image logo;
    private List contributors;
    private string licence;

    [Modifiers]
    public static Dimension PREFERRED_SIZE
    {
      [HideFromJava] get
      {
        return AboutDialog.__\u003C\u003EPREFERRED_SIZE;
      }
    }

    [Modifiers]
    public static Border STANDARD_BORDER
    {
      [HideFromJava] get
      {
        return AboutDialog.__\u003C\u003ESTANDARD_BORDER;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 124, (byte) 69, (byte) 180})]
    static AboutDialog()
    {
      JDialog.__\u003Cclinit\u003E();
      AboutDialog.__\u003C\u003EPREFERRED_SIZE = new Dimension(560, 360);
      AboutDialog.__\u003C\u003ESTANDARD_BORDER = BorderFactory.createEmptyBorder(5, 5, 5, 5);
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 136, (byte) 255, (byte) 46, (byte) 74})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AboutDialog(string title, ProjectInfo project)
    {
      base.\u002Ector();
      AboutDialog aboutDialog = this;
      this.init(title, project.getName(), new StringBuffer().append("Version ").append(project.getVersion()).toString(), project.getInfo(), project.getLogo(), project.getCopyright(), project.getLicenceText(), project.getContributors(), project);
    }

    [LineNumberTable(new byte[] {(byte) 84, (byte) 105, (byte) 255, (byte) 46, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AboutDialog(Frame owner, string title, ProjectInfo project)
    {
      base.\u002Ector(owner);
      AboutDialog aboutDialog = this;
      this.init(title, project.getName(), new StringBuffer().append("Version ").append(project.getVersion()).toString(), project.getInfo(), project.getLogo(), project.getCopyright(), project.getLicenceText(), project.getContributors(), project);
    }

    [LineNumberTable(new byte[] {(byte) 108, (byte) 105, (byte) 255, (byte) 46, (byte) 73})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AboutDialog(Dialog owner, string title, ProjectInfo project)
    {
      base.\u002Ector(owner);
      AboutDialog aboutDialog = this;
      this.init(title, project.getName(), new StringBuffer().append("Version ").append(project.getVersion()).toString(), project.getInfo(), project.getLogo(), project.getCopyright(), project.getLicenceText(), project.getContributors(), project);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AboutDialog([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 79, (byte) 135, (byte) 103, (byte) 103, (byte) 104, (byte) 104, (byte) 104, (byte) 104, (byte) 136, (byte) 102, (byte) 144, (byte) 112, (byte) 139, (byte) 105, (byte) 104, (byte) 135, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void init([In] string obj0, [In] string obj1, [In] string obj2, [In] string obj3, [In] Image obj4, [In] string obj5, [In] string obj6, [In] List obj7, [In] ProjectInfo obj8)
    {
      ((Dialog) this).setTitle(obj0);
      this.application = obj1;
      this.version = obj2;
      this.copyright = obj5;
      this.info = obj3;
      this.logo = obj4;
      this.contributors = obj7;
      this.licence = obj6;
      this.resources = ResourceBundleWrapper.getBundle("org.jfree.ui.about.resources.AboutResources");
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel = new JPanel((LayoutManager) new BorderLayout());
      ((JComponent) jpanel).setBorder(AboutDialog.__\u003C\u003ESTANDARD_BORDER);
      JTabbedPane tabs = this.createTabs(obj8);
      ((Container) jpanel).add((Component) tabs);
      this.setContentPane((Container) jpanel);
      ((Window) this).pack();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 122, (byte) 134, (byte) 104, (byte) 107, (byte) 145, (byte) 137, (byte) 102, (byte) 107, (byte) 146, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private JTabbedPane createTabs([In] ProjectInfo obj0)
    {
      JTabbedPane jtabbedPane = new JTabbedPane();
      JPanel aboutPanel = this.createAboutPanel(obj0);
      ((JComponent) aboutPanel).setBorder(AboutDialog.__\u003C\u003ESTANDARD_BORDER);
      string string1 = this.resources.getString("about-frame.tab.about");
      jtabbedPane.add(string1, (Component) aboutPanel);
      SystemPropertiesPanel systemPropertiesPanel = new SystemPropertiesPanel();
      ((JComponent) systemPropertiesPanel).setBorder(AboutDialog.__\u003C\u003ESTANDARD_BORDER);
      string string2 = this.resources.getString("about-frame.tab.system");
      jtabbedPane.add(string2, (Component) systemPropertiesPanel);
      return jtabbedPane;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 151, (byte) 144, (byte) 191, (byte) 10, (byte) 98, (byte) 134, (byte) 104, (byte) 146, (byte) 108, (byte) 146, (byte) 107, (byte) 162, (byte) 104, (byte) 104, (byte) 108, (byte) 146, (byte) 107, (byte) 162, (byte) 99, (byte) 104, (byte) 108, (byte) 146, (byte) 107, (byte) 162, (byte) 108, (byte) 99, (byte) 168})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private JPanel createAboutPanel([In] ProjectInfo obj0)
    {
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel = new JPanel((LayoutManager) new BorderLayout());
      AboutPanel.__\u003Cclinit\u003E();
      AboutPanel aboutPanel = new AboutPanel(this.application, this.version, this.copyright, this.info, this.logo);
      int num = 0;
      JTabbedPane jtabbedPane = new JTabbedPane();
      if (this.contributors != null)
      {
        ContributorsPanel.__\u003Cclinit\u003E();
        ContributorsPanel contributorsPanel = new ContributorsPanel(this.contributors);
        ((JComponent) contributorsPanel).setBorder(AboutDialog.__\u003C\u003ESTANDARD_BORDER);
        string @string = this.resources.getString("about-frame.tab.contributors");
        jtabbedPane.add(@string, (Component) contributorsPanel);
        num = 1;
      }
      if (this.licence != null)
      {
        JPanel licencePanel = this.createLicencePanel();
        ((JComponent) licencePanel).setBorder(AboutDialog.__\u003C\u003ESTANDARD_BORDER);
        string @string = this.resources.getString("about-frame.tab.licence");
        jtabbedPane.add(@string, (Component) licencePanel);
        num = 1;
      }
      if (obj0 != null)
      {
        LibraryPanel libraryPanel = new LibraryPanel(obj0);
        ((JComponent) libraryPanel).setBorder(AboutDialog.__\u003C\u003ESTANDARD_BORDER);
        string @string = this.resources.getString("about-frame.tab.libraries");
        jtabbedPane.add(@string, (Component) libraryPanel);
        num = 1;
      }
      ((Container) jpanel).add((Component) aboutPanel, (object) "North");
      if (num != 0)
        ((Container) jpanel).add((Component) jtabbedPane);
      return jpanel;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 203, (byte) 112, (byte) 113, (byte) 103, (byte) 103, (byte) 103, (byte) 103, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private JPanel createLicencePanel()
    {
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel = new JPanel((LayoutManager) new BorderLayout());
      JTextArea.__\u003Cclinit\u003E();
      JTextArea jtextArea = new JTextArea(this.licence);
      jtextArea.setLineWrap(true);
      jtextArea.setWrapStyleWord(true);
      ((JTextComponent) jtextArea).setCaretPosition(0);
      ((JTextComponent) jtextArea).setEditable(false);
      ((Container) jpanel).add((Component) new JScrollPane((Component) jtextArea));
      return jpanel;
    }

    public virtual Dimension getPreferredSize()
    {
      return AboutDialog.__\u003C\u003EPREFERRED_SIZE;
    }
  }
}
