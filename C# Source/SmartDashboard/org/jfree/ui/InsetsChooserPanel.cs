// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.InsetsChooserPanel
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

namespace org.jfree.ui
{
  [Serializable]
  public class InsetsChooserPanel : JPanel
  {
    private JTextField topValueEditor;
    private JTextField leftValueEditor;
    private JTextField bottomValueEditor;
    private JTextField rightValueEditor;
    protected internal static ResourceBundle localizationResources;

    [LineNumberTable((ushort) 87)]
    static InsetsChooserPanel()
    {
      JPanel.__\u003Cclinit\u003E();
      InsetsChooserPanel.localizationResources = ResourceBundleWrapper.getBundle("org.jfree.ui.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 55, (byte) 104, (byte) 145, (byte) 159, (byte) 22, (byte) 159, (byte) 22, (byte) 159, (byte) 22, (byte) 191, (byte) 22, (byte) 112, (byte) 218, (byte) 255, (byte) 33, (byte) 70, (byte) 191, (byte) 20, (byte) 191, (byte) 14, (byte) 255, (byte) 20, (byte) 69, (byte) 223, (byte) 33, (byte) 191, (byte) 14, (byte) 191, (byte) 20, (byte) 191, (byte) 14, (byte) 255, (byte) 33, (byte) 70, (byte) 255, (byte) 14, (byte) 69, (byte) 223, (byte) 33, (byte) 107, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public InsetsChooserPanel(Insets current)
    {
      base.\u002Ector();
      InsetsChooserPanel insetsChooserPanel = this;
      current = current != null ? current : new Insets(0, 0, 0, 0);
      JTextField.__\u003Cclinit\u003E();
      this.topValueEditor = new JTextField((Document) new IntegerDocument(), new StringBuffer().append("").append((int) current.top).toString(), 0);
      JTextField.__\u003Cclinit\u003E();
      this.leftValueEditor = new JTextField((Document) new IntegerDocument(), new StringBuffer().append("").append((int) current.left).toString(), 0);
      JTextField.__\u003Cclinit\u003E();
      this.bottomValueEditor = new JTextField((Document) new IntegerDocument(), new StringBuffer().append("").append((int) current.bottom).toString(), 0);
      JTextField.__\u003Cclinit\u003E();
      this.rightValueEditor = new JTextField((Document) new IntegerDocument(), new StringBuffer().append("").append((int) current.right).toString(), 0);
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel1 = new JPanel((LayoutManager) new GridBagLayout());
      ((JComponent) jpanel1).setBorder((Border) new TitledBorder(InsetsChooserPanel.localizationResources.getString("Insets")));
      JPanel jpanel2 = jpanel1;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel1 = new JLabel(InsetsChooserPanel.localizationResources.getString("Top"));
      GridBagConstraints gridBagConstraints1 = new GridBagConstraints(1, 0, 3, 1, 0.0, 0.0, 10, 0, new Insets(0, 0, 0, 0), 0, 0);
      ((Container) jpanel2).add((Component) jlabel1, (object) gridBagConstraints1);
      ((Container) jpanel1).add((Component) new JLabel(" "), (object) new GridBagConstraints(1, 1, 1, 1, 0.0, 0.0, 10, 1, new Insets(0, 12, 0, 12), 8, 0));
      ((Container) jpanel1).add((Component) this.topValueEditor, (object) new GridBagConstraints(2, 1, 1, 1, 0.0, 0.0, 10, 2, new Insets(0, 0, 0, 0), 0, 0));
      ((Container) jpanel1).add((Component) new JLabel(" "), (object) new GridBagConstraints(3, 1, 1, 1, 0.0, 0.0, 10, 1, new Insets(0, 12, 0, 11), 8, 0));
      JPanel jpanel3 = jpanel1;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel2 = new JLabel(InsetsChooserPanel.localizationResources.getString("Left"));
      GridBagConstraints gridBagConstraints2 = new GridBagConstraints(0, 2, 1, 1, 0.0, 0.0, 10, 1, new Insets(0, 4, 0, 4), 0, 0);
      ((Container) jpanel3).add((Component) jlabel2, (object) gridBagConstraints2);
      ((Container) jpanel1).add((Component) this.leftValueEditor, (object) new GridBagConstraints(1, 2, 1, 1, 0.0, 0.0, 10, 1, new Insets(0, 0, 0, 0), 0, 0));
      ((Container) jpanel1).add((Component) new JLabel(" "), (object) new GridBagConstraints(2, 2, 1, 1, 0.0, 0.0, 10, 0, new Insets(0, 12, 0, 12), 8, 0));
      ((Container) jpanel1).add((Component) this.rightValueEditor, (object) new GridBagConstraints(3, 2, 1, 1, 0.0, 0.0, 10, 2, new Insets(0, 0, 0, 0), 0, 0));
      JPanel jpanel4 = jpanel1;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel3 = new JLabel(InsetsChooserPanel.localizationResources.getString("Right"));
      GridBagConstraints gridBagConstraints3 = new GridBagConstraints(4, 2, 1, 1, 0.0, 0.0, 10, 0, new Insets(0, 4, 0, 4), 0, 0);
      ((Container) jpanel4).add((Component) jlabel3, (object) gridBagConstraints3);
      ((Container) jpanel1).add((Component) this.bottomValueEditor, (object) new GridBagConstraints(2, 3, 1, 1, 0.0, 0.0, 10, 2, new Insets(0, 0, 0, 0), 0, 0));
      JPanel jpanel5 = jpanel1;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel4 = new JLabel(InsetsChooserPanel.localizationResources.getString("Bottom"));
      GridBagConstraints gridBagConstraints4 = new GridBagConstraints(1, 4, 3, 1, 0.0, 0.0, 10, 0, new Insets(0, 0, 0, 0), 0, 0);
      ((Container) jpanel5).add((Component) jlabel4, (object) gridBagConstraints4);
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      ((Container) this).add((Component) jpanel1, (object) "Center");
    }

    [LineNumberTable(new byte[] {(byte) 46, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public InsetsChooserPanel()
      : this(new Insets(0, 0, 0, 0))
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected InsetsChooserPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 82, (byte) 104, (byte) 104, (byte) 194, (byte) 149, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual int stringToInt(string value)
    {
      value = String.instancehelper_trim(value);
      if (String.instancehelper_length(value) == 0)
        return 0;
      int num;
      try
      {
        num = Integer.parseInt(value);
      }
      catch (NumberFormatException ex)
      {
        goto label_5;
      }
      return num;
label_5:
      return 0;
    }

    [LineNumberTable((ushort) 179)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Insets getInsetsValue()
    {
      Insets.__\u003Cclinit\u003E();
      return new Insets(Math.abs(this.stringToInt(((JTextComponent) this.topValueEditor).getText())), Math.abs(this.stringToInt(((JTextComponent) this.leftValueEditor).getText())), Math.abs(this.stringToInt(((JTextComponent) this.bottomValueEditor).getText())), Math.abs(this.stringToInt(((JTextComponent) this.rightValueEditor).getText())));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 100, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void removeNotify()
    {
      ((JComponent) this).removeNotify();
      ((Container) this).removeAll();
    }
  }
}
