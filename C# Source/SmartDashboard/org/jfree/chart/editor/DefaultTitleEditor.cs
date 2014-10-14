// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.editor.DefaultTitleEditor
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing;
using javax.swing.border;
using javax.swing.text;
using org.jfree.chart;
using org.jfree.chart.title;
using org.jfree.chart.util;
using org.jfree.layout;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.editor
{
  [Implements(new string[] {"java.awt.event.ActionListener"})]
  [Modifiers]
  [Serializable]
  internal sealed class DefaultTitleEditor : JPanel, ActionListener, EventListener
  {
    private bool showTitle;
    private JCheckBox showTitleCheckBox;
    private JTextField titleField;
    private Font titleFont;
    private JTextField fontfield;
    private JButton selectFontButton;
    private PaintSample titlePaint;
    private JButton selectPaintButton;
    protected internal static ResourceBundle localizationResources;

    [LineNumberTable((ushort) 102)]
    static DefaultTitleEditor()
    {
      JPanel.__\u003Cclinit\u003E();
      DefaultTitleEditor.localizationResources = ResourceBundleWrapper.getBundle("org.jfree.chart.editor.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 62, (byte) 136, (byte) 159, (byte) 6, (byte) 109, (byte) 108, (byte) 118, (byte) 150, (byte) 139, (byte) 112, (byte) 255, (byte) 0, (byte) 71, (byte) 113, (byte) 143, (byte) 127, (byte) 1, (byte) 107, (byte) 113, (byte) 112, (byte) 108, (byte) 108, (byte) 141, (byte) 123, (byte) 105, (byte) 109, (byte) 140, (byte) 123, (byte) 118, (byte) 191, (byte) 0, (byte) 112, (byte) 108, (byte) 105, (byte) 109, (byte) 141, (byte) 187, (byte) 191, (byte) 0, (byte) 112, (byte) 108, (byte) 105, (byte) 109, (byte) 141, (byte) 134, (byte) 104, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultTitleEditor([In] Title obj0)
    {
      base.\u002Ector();
      DefaultTitleEditor defaultTitleEditor = this;
      TextTitle textTitle1;
      if (obj0 != null)
      {
        textTitle1 = (TextTitle) obj0;
      }
      else
      {
        TextTitle.__\u003Cclinit\u003E();
        textTitle1 = new TextTitle(DefaultTitleEditor.localizationResources.getString("Title"));
      }
      TextTitle textTitle2 = textTitle1;
      this.showTitle = obj0 != null;
      this.titleFont = textTitle2.getFont();
      JTextField.__\u003Cclinit\u003E();
      this.titleField = new JTextField(textTitle2.getText());
      PaintSample.__\u003Cclinit\u003E();
      this.titlePaint = new PaintSample(textTitle2.getPaint());
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel1 = new JPanel((LayoutManager) new BorderLayout());
      ((JComponent) jpanel1).setBorder((Border) BorderFactory.createTitledBorder(BorderFactory.createEtchedBorder(), DefaultTitleEditor.localizationResources.getString("General")));
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel2 = new JPanel((LayoutManager) new LCBLayout(4));
      ((JComponent) jpanel2).setBorder(BorderFactory.createEmptyBorder(0, 5, 0, 5));
      JPanel jpanel3 = jpanel2;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel1 = new JLabel(DefaultTitleEditor.localizationResources.getString("Show_Title"));
      ((Container) jpanel3).add((Component) jlabel1);
      this.showTitleCheckBox = new JCheckBox();
      ((AbstractButton) this.showTitleCheckBox).setSelected(this.showTitle);
      ((AbstractButton) this.showTitleCheckBox).setActionCommand("ShowTitle");
      ((AbstractButton) this.showTitleCheckBox).addActionListener((ActionListener) this);
      ((Container) jpanel2).add((Component) new JPanel());
      ((Container) jpanel2).add((Component) this.showTitleCheckBox);
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel2 = new JLabel(DefaultTitleEditor.localizationResources.getString("Text"));
      ((Container) jpanel2).add((Component) jlabel2);
      ((Container) jpanel2).add((Component) this.titleField);
      ((Container) jpanel2).add((Component) new JPanel());
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel3 = new JLabel(DefaultTitleEditor.localizationResources.getString("Font"));
      FontDisplayField.__\u003Cclinit\u003E();
      this.fontfield = (JTextField) new FontDisplayField(this.titleFont);
      JButton.__\u003Cclinit\u003E();
      this.selectFontButton = new JButton(DefaultTitleEditor.localizationResources.getString("Select..."));
      ((AbstractButton) this.selectFontButton).setActionCommand("SelectFont");
      ((AbstractButton) this.selectFontButton).addActionListener((ActionListener) this);
      ((Container) jpanel2).add((Component) jlabel3);
      ((Container) jpanel2).add((Component) this.fontfield);
      ((Container) jpanel2).add((Component) this.selectFontButton);
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel4 = new JLabel(DefaultTitleEditor.localizationResources.getString("Color"));
      JButton.__\u003Cclinit\u003E();
      this.selectPaintButton = new JButton(DefaultTitleEditor.localizationResources.getString("Select..."));
      ((AbstractButton) this.selectPaintButton).setActionCommand("SelectPaint");
      ((AbstractButton) this.selectPaintButton).addActionListener((ActionListener) this);
      ((Container) jpanel2).add((Component) jlabel4);
      ((Container) jpanel2).add((Component) this.titlePaint);
      ((Container) jpanel2).add((Component) this.selectPaintButton);
      this.enableOrDisableControls();
      ((Container) jpanel1).add((Component) jpanel2);
      ((Container) this).add((Component) jpanel1, (object) "North");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultTitleEditor([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 174, (byte) 104, (byte) 103, (byte) 99, (byte) 102, (byte) 135, (byte) 108, (byte) 108, (byte) 108, (byte) 130, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setTitleProperties([In] JFreeChart obj0)
    {
      if (this.showTitle)
      {
        TextTitle title = obj0.getTitle();
        if (title == null)
        {
          title = new TextTitle();
          obj0.setTitle(title);
        }
        title.setText(this.getTitleText());
        title.setFont(this.getTitleFont());
        title.setPaint(this.getTitlePaint());
      }
      else
        obj0.setTitle((TextTitle) null);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 161, (byte) 106, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void enableOrDisableControls()
    {
      int num = this.showTitle ? 1 : 0;
      ((JComponent) this.titleField).setEnabled(num != 0);
      ((AbstractButton) this.selectFontButton).setEnabled(num != 0);
      ((AbstractButton) this.selectPaintButton).setEnabled(num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 115, (byte) 113, (byte) 249, (byte) 70, (byte) 99, (byte) 108, (byte) 223, (byte) 34})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void attemptFontSelection()
    {
      FontChooserPanel.__\u003Cclinit\u003E();
      FontChooserPanel fontChooserPanel = new FontChooserPanel(this.titleFont);
      if (JOptionPane.showConfirmDialog((Component) this, (object) fontChooserPanel, DefaultTitleEditor.localizationResources.getString("Font_Selection"), 2, -1) != 0)
        return;
      this.titleFont = fontChooserPanel.getSelectedFont();
      ((JTextComponent) this.fontfield).setText(new StringBuffer().append(this.titleFont.getFontName()).append(" ").append(this.titleFont.getSize()).toString());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 108, (byte) 118, (byte) 183, (byte) 99, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void attemptPaintSelection()
    {
      Paint paint = this.titlePaint.getPaint();
      Color color1 = !(paint is Color) ? (Color) Color.blue : (Color) paint;
      Color color2 = JColorChooser.showDialog((Component) this, DefaultTitleEditor.localizationResources.getString("Title_Color"), color1);
      if (color2 == null)
        return;
      this.titlePaint.setPaint((Paint) color2);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 152, (byte) 113, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void attemptModifyShowTitle()
    {
      this.showTitle = ((AbstractButton) this.showTitleCheckBox).isSelected();
      this.enableOrDisableControls();
    }

    [LineNumberTable((ushort) 182)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getTitleText()
    {
      return ((JTextComponent) this.titleField).getText();
    }

    public virtual Font getTitleFont()
    {
      return this.titleFont;
    }

    [LineNumberTable((ushort) 200)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getTitlePaint()
    {
      return this.titlePaint.getPaint();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 97, (byte) 135, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      string actionCommand = obj0.getActionCommand();
      if (String.instancehelper_equals(actionCommand, (object) "SelectFont"))
        this.attemptFontSelection();
      else if (String.instancehelper_equals(actionCommand, (object) "SelectPaint"))
      {
        this.attemptPaintSelection();
      }
      else
      {
        if (!String.instancehelper_equals(actionCommand, (object) "ShowTitle"))
          return;
        this.attemptModifyShowTitle();
      }
    }
  }
}
