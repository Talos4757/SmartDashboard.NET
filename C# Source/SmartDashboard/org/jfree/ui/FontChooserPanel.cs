// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.FontChooserPanel
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.lang;
using java.util;
using javax.swing;
using javax.swing.border;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui
{
  [Serializable]
  public class FontChooserPanel : JPanel
  {
    internal static string[] __\u003C\u003ESIZES;
    private JList fontlist;
    private JList sizelist;
    private JCheckBox bold;
    private JCheckBox italic;
    protected internal static ResourceBundle localizationResources;

    [Modifiers]
    public static string[] SIZES
    {
      [HideFromJava] get
      {
        return FontChooserPanel.__\u003C\u003ESIZES;
      }
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 124, (byte) 133, (byte) 255, (byte) 98, (byte) 80})]
    static FontChooserPanel()
    {
      JPanel.__\u003Cclinit\u003E();
      string[] strArray = new string[14];
      int index1 = 0;
      string str1 = "9";
      strArray[index1] = str1;
      int index2 = 1;
      string str2 = "10";
      strArray[index2] = str2;
      int index3 = 2;
      string str3 = "11";
      strArray[index3] = str3;
      int index4 = 3;
      string str4 = "12";
      strArray[index4] = str4;
      int index5 = 4;
      string str5 = "14";
      strArray[index5] = str5;
      int index6 = 5;
      string str6 = "16";
      strArray[index6] = str6;
      int index7 = 6;
      string str7 = "18";
      strArray[index7] = str7;
      int index8 = 7;
      string str8 = "20";
      strArray[index8] = str8;
      int index9 = 8;
      string str9 = "22";
      strArray[index9] = str9;
      int index10 = 9;
      string str10 = "24";
      strArray[index10] = str10;
      int index11 = 10;
      string str11 = "28";
      strArray[index11] = str11;
      int index12 = 11;
      string str12 = "36";
      strArray[index12] = str12;
      int index13 = 12;
      string str13 = "48";
      strArray[index13] = str13;
      int index14 = 13;
      string str14 = "72";
      strArray[index14] = str14;
      FontChooserPanel.__\u003C\u003ESIZES = strArray;
      FontChooserPanel.localizationResources = ResourceBundleWrapper.getBundle("org.jfree.ui.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 49, (byte) 136, (byte) 134, (byte) 135, (byte) 107, (byte) 144, (byte) 113, (byte) 191, (byte) 1, (byte) 108, (byte) 114, (byte) 108, (byte) 106, (byte) 137, (byte) 113, (byte) 191, (byte) 1, (byte) 117, (byte) 114, (byte) 108, (byte) 138, (byte) 115, (byte) 127, (byte) 0, (byte) 127, (byte) 0, (byte) 110, (byte) 110, (byte) 223, (byte) 1, (byte) 109, (byte) 141, (byte) 140, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FontChooserPanel(Font font)
    {
      base.\u002Ector();
      FontChooserPanel fontChooserPanel = this;
      string[] availableFontFamilyNames = GraphicsEnvironment.getLocalGraphicsEnvironment().getAvailableFontFamilyNames();
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel1 = new JPanel((LayoutManager) new BorderLayout());
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel2 = new JPanel((LayoutManager) new BorderLayout());
      ((JComponent) jpanel2).setBorder((Border) BorderFactory.createTitledBorder(BorderFactory.createEtchedBorder(), FontChooserPanel.localizationResources.getString("Font")));
      this.fontlist = new JList((object[]) availableFontFamilyNames);
      JScrollPane.__\u003Cclinit\u003E();
      JScrollPane jscrollPane1 = new JScrollPane((Component) this.fontlist);
      ((JComponent) jscrollPane1).setBorder(BorderFactory.createEtchedBorder());
      ((Container) jpanel2).add((Component) jscrollPane1);
      ((Container) this).add((Component) jpanel2);
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel3 = new JPanel((LayoutManager) new BorderLayout());
      ((JComponent) jpanel3).setBorder((Border) BorderFactory.createTitledBorder(BorderFactory.createEtchedBorder(), FontChooserPanel.localizationResources.getString("Size")));
      JList.__\u003Cclinit\u003E();
      this.sizelist = new JList((object[]) FontChooserPanel.__\u003C\u003ESIZES);
      JScrollPane.__\u003Cclinit\u003E();
      JScrollPane jscrollPane2 = new JScrollPane((Component) this.sizelist);
      ((JComponent) jscrollPane2).setBorder(BorderFactory.createEtchedBorder());
      ((Container) jpanel3).add((Component) jscrollPane2);
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel4 = new JPanel((LayoutManager) new GridLayout(1, 2));
      JCheckBox.__\u003Cclinit\u003E();
      this.bold = new JCheckBox(FontChooserPanel.localizationResources.getString("Bold"));
      JCheckBox.__\u003Cclinit\u003E();
      this.italic = new JCheckBox(FontChooserPanel.localizationResources.getString("Italic"));
      ((Container) jpanel4).add((Component) this.bold);
      ((Container) jpanel4).add((Component) this.italic);
      ((JComponent) jpanel4).setBorder((Border) BorderFactory.createTitledBorder(BorderFactory.createEtchedBorder(), FontChooserPanel.localizationResources.getString("Attributes")));
      ((Container) jpanel1).add((Component) jpanel3, (object) "Center");
      ((Container) jpanel1).add((Component) jpanel4, (object) "South");
      ((Container) this).add((Component) jpanel1, (object) "East");
      this.setSelectedFont(font);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected FontChooserPanel([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable((ushort) 150)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Font getSelectedFont()
    {
      Font.__\u003Cclinit\u003E();
      return new Font(this.getSelectedName(), this.getSelectedStyle(), this.getSelectedSize());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 91, (byte) 99, (byte) 139, (byte) 113, (byte) 145, (byte) 103, (byte) 108, (byte) 107, (byte) 107, (byte) 111, (byte) 108, (byte) 226, (byte) 61, (byte) 230, (byte) 71, (byte) 108, (byte) 108, (byte) 107, (byte) 109, (byte) 112, (byte) 109, (byte) 226, (byte) 61, (byte) 232, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setSelectedFont(Font font)
    {
      if (font == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else
      {
        ((AbstractButton) this.bold).setSelected(font.isBold());
        ((AbstractButton) this.italic).setSelected(font.isItalic());
        string name = font.getName();
        ListModel model1 = this.fontlist.getModel();
        this.fontlist.clearSelection();
        for (int index = 0; index < model1.getSize(); ++index)
        {
          if (String.instancehelper_equals(name, model1.getElementAt(index)))
          {
            this.fontlist.setSelectedIndex(index);
            break;
          }
        }
        string str = String.valueOf(font.getSize());
        ListModel model2 = this.sizelist.getModel();
        this.sizelist.clearSelection();
        for (int index = 0; index < model2.getSize(); ++index)
        {
          if (String.instancehelper_equals(str, model2.getElementAt(index)))
          {
            this.sizelist.setSelectedIndex(index);
            break;
          }
        }
      }
    }

    [LineNumberTable((ushort) 160)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getSelectedName()
    {
      return (string) this.fontlist.getSelectedValue();
    }

    [LineNumberTable(new byte[] {(byte) 119, (byte) 122, (byte) 130, (byte) 109, (byte) 130, (byte) 109, (byte) 162})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getSelectedStyle()
    {
      if (((AbstractButton) this.bold).isSelected() && ((AbstractButton) this.italic).isSelected())
        return 3;
      if (((AbstractButton) this.bold).isSelected())
        return 1;
      return ((AbstractButton) this.italic).isSelected() ? 2 : 0;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 75, (byte) 113, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int getSelectedSize()
    {
      string str = (string) this.sizelist.getSelectedValue();
      if (str == null)
        return 10;
      return Integer.parseInt(str);
    }
  }
}
