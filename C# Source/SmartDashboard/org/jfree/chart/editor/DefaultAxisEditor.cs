// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.editor.DefaultAxisEditor
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
using org.jfree.chart.axis;
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
  [Serializable]
  internal class DefaultAxisEditor : JPanel, ActionListener, EventListener
  {
    private JTextField label;
    private Font labelFont;
    private PaintSample labelPaintSample;
    private JTextField labelFontField;
    private Font tickLabelFont;
    private JTextField tickLabelFontField;
    private PaintSample tickLabelPaintSample;
    private JPanel slot1;
    private JPanel slot2;
    private JCheckBox showTickLabelsCheckBox;
    private JCheckBox showTickMarksCheckBox;
    private RectangleInsets tickLabelInsets;
    private RectangleInsets labelInsets;
    private JTabbedPane otherTabs;
    protected internal static ResourceBundle localizationResources;

    [LineNumberTable((ushort) 136)]
    static DefaultAxisEditor()
    {
      JPanel.__\u003Cclinit\u003E();
      DefaultAxisEditor.localizationResources = ResourceBundleWrapper.getBundle("org.jfree.chart.editor.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 124, (byte) 136, (byte) 108, (byte) 118, (byte) 108, (byte) 182, (byte) 108, (byte) 140, (byte) 139, (byte) 112, (byte) 255, (byte) 0, (byte) 71, (byte) 113, (byte) 111, (byte) 127, (byte) 1, (byte) 118, (byte) 109, (byte) 140, (byte) 127, (byte) 1, (byte) 118, (byte) 109, (byte) 122, (byte) 107, (byte) 103, (byte) 136, (byte) 127, (byte) 1, (byte) 109, (byte) 122, (byte) 107, (byte) 103, (byte) 232, (byte) 87, (byte) 136, (byte) 140, (byte) 149, (byte) 113, (byte) 223, (byte) 1, (byte) 107, (byte) 148, (byte) 114, (byte) 144, (byte) 223, (byte) 6, (byte) 110, (byte) 109, (byte) 141, (byte) 191, (byte) 2, (byte) 118, (byte) 110, (byte) 122, (byte) 107, (byte) 103, (byte) 137, (byte) 223, (byte) 6, (byte) 110, (byte) 109, (byte) 141, (byte) 157, (byte) 142, (byte) 142, (byte) 117, (byte) 118, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultAxisEditor([In] Axis obj0)
    {
      base.\u002Ector();
      DefaultAxisEditor defaultAxisEditor = this;
      this.labelFont = obj0.getLabelFont();
      PaintSample.__\u003Cclinit\u003E();
      this.labelPaintSample = new PaintSample(obj0.getLabelPaint());
      this.tickLabelFont = obj0.getTickLabelFont();
      PaintSample.__\u003Cclinit\u003E();
      this.tickLabelPaintSample = new PaintSample(obj0.getTickLabelPaint());
      this.tickLabelInsets = obj0.getTickLabelInsets();
      this.labelInsets = obj0.getLabelInsets();
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel1 = new JPanel((LayoutManager) new BorderLayout());
      ((JComponent) jpanel1).setBorder((Border) BorderFactory.createTitledBorder(BorderFactory.createEtchedBorder(), DefaultAxisEditor.localizationResources.getString("General")));
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel2 = new JPanel((LayoutManager) new LCBLayout(5));
      ((JComponent) jpanel2).setBorder(BorderFactory.createEmptyBorder(0, 5, 0, 5));
      JPanel jpanel3 = jpanel2;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel1 = new JLabel(DefaultAxisEditor.localizationResources.getString("Label"));
      ((Container) jpanel3).add((Component) jlabel1);
      JTextField.__\u003Cclinit\u003E();
      this.label = new JTextField(obj0.getLabel());
      ((Container) jpanel2).add((Component) this.label);
      ((Container) jpanel2).add((Component) new JPanel());
      JPanel jpanel4 = jpanel2;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel2 = new JLabel(DefaultAxisEditor.localizationResources.getString("Font"));
      ((Container) jpanel4).add((Component) jlabel2);
      FontDisplayField.__\u003Cclinit\u003E();
      this.labelFontField = (JTextField) new FontDisplayField(this.labelFont);
      ((Container) jpanel2).add((Component) this.labelFontField);
      JButton.__\u003Cclinit\u003E();
      JButton jbutton1 = new JButton(DefaultAxisEditor.localizationResources.getString("Select..."));
      ((AbstractButton) jbutton1).setActionCommand("SelectLabelFont");
      ((AbstractButton) jbutton1).addActionListener((ActionListener) this);
      ((Container) jpanel2).add((Component) jbutton1);
      JPanel jpanel5 = jpanel2;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel3 = new JLabel(DefaultAxisEditor.localizationResources.getString("Paint"));
      ((Container) jpanel5).add((Component) jlabel3);
      ((Container) jpanel2).add((Component) this.labelPaintSample);
      JButton.__\u003Cclinit\u003E();
      JButton jbutton2 = new JButton(DefaultAxisEditor.localizationResources.getString("Select..."));
      ((AbstractButton) jbutton2).setActionCommand("SelectLabelPaint");
      ((AbstractButton) jbutton2).addActionListener((ActionListener) this);
      ((Container) jpanel2).add((Component) jbutton2);
      ((Container) jpanel1).add((Component) jpanel2);
      ((Container) this).add((Component) jpanel1, (object) "North");
      JPanel.__\u003Cclinit\u003E();
      this.slot1 = new JPanel((LayoutManager) new BorderLayout());
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel6 = new JPanel((LayoutManager) new BorderLayout());
      ((JComponent) jpanel6).setBorder((Border) BorderFactory.createTitledBorder(BorderFactory.createEtchedBorder(), DefaultAxisEditor.localizationResources.getString("Other")));
      this.otherTabs = new JTabbedPane();
      ((JComponent) this.otherTabs).setBorder(BorderFactory.createEmptyBorder(0, 5, 0, 5));
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel7 = new JPanel((LayoutManager) new LCBLayout(3));
      ((JComponent) jpanel7).setBorder(BorderFactory.createEmptyBorder(4, 4, 4, 4));
      JCheckBox.__\u003Cclinit\u003E();
      this.showTickLabelsCheckBox = new JCheckBox(DefaultAxisEditor.localizationResources.getString("Show_tick_labels"), obj0.isTickLabelsVisible());
      ((Container) jpanel7).add((Component) this.showTickLabelsCheckBox);
      ((Container) jpanel7).add((Component) new JPanel());
      ((Container) jpanel7).add((Component) new JPanel());
      JPanel jpanel8 = jpanel7;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel4 = new JLabel(DefaultAxisEditor.localizationResources.getString("Tick_label_font"));
      ((Container) jpanel8).add((Component) jlabel4);
      FontDisplayField.__\u003Cclinit\u003E();
      this.tickLabelFontField = (JTextField) new FontDisplayField(this.tickLabelFont);
      ((Container) jpanel7).add((Component) this.tickLabelFontField);
      JButton.__\u003Cclinit\u003E();
      JButton jbutton3 = new JButton(DefaultAxisEditor.localizationResources.getString("Select..."));
      ((AbstractButton) jbutton3).setActionCommand("SelectTickLabelFont");
      ((AbstractButton) jbutton3).addActionListener((ActionListener) this);
      ((Container) jpanel7).add((Component) jbutton3);
      JCheckBox.__\u003Cclinit\u003E();
      this.showTickMarksCheckBox = new JCheckBox(DefaultAxisEditor.localizationResources.getString("Show_tick_marks"), obj0.isTickMarksVisible());
      ((Container) jpanel7).add((Component) this.showTickMarksCheckBox);
      ((Container) jpanel7).add((Component) new JPanel());
      ((Container) jpanel7).add((Component) new JPanel());
      this.otherTabs.add(DefaultAxisEditor.localizationResources.getString("Ticks"), (Component) jpanel7);
      ((Container) jpanel6).add((Component) this.otherTabs);
      ((Container) this.slot1).add((Component) jpanel6);
      JPanel.__\u003Cclinit\u003E();
      this.slot2 = new JPanel((LayoutManager) new BorderLayout());
      ((Container) this.slot2).add((Component) this.slot1, (object) "North");
      ((Container) this).add((Component) this.slot2);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultAxisEditor([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 47, (byte) 113, (byte) 217, (byte) 99, (byte) 108, (byte) 255, (byte) 34, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void attemptLabelFontSelection()
    {
      FontChooserPanel.__\u003Cclinit\u003E();
      FontChooserPanel fontChooserPanel = new FontChooserPanel(this.labelFont);
      if (JOptionPane.showConfirmDialog((Component) this, (object) fontChooserPanel, DefaultAxisEditor.localizationResources.getString("Font_Selection"), 2, -1) != 0)
        return;
      this.labelFont = fontChooserPanel.getSelectedFont();
      ((JTextComponent) this.labelFontField).setText(new StringBuffer().append(this.labelFont.getFontName()).append(" ").append(this.labelFont.getSize()).toString());
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 66, (byte) 187, (byte) 99, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void attemptModifyLabelPaint()
    {
      Color color = JColorChooser.showDialog((Component) this, DefaultAxisEditor.localizationResources.getString("Label_Color"), (Color) Color.blue);
      if (color == null)
        return;
      this.labelPaintSample.setPaint((Paint) color);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 79, (byte) 113, (byte) 217, (byte) 99, (byte) 108, (byte) 255, (byte) 34, (byte) 70})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void attemptTickLabelFontSelection()
    {
      FontChooserPanel.__\u003Cclinit\u003E();
      FontChooserPanel fontChooserPanel = new FontChooserPanel(this.tickLabelFont);
      if (JOptionPane.showConfirmDialog((Component) this, (object) fontChooserPanel, DefaultAxisEditor.localizationResources.getString("Font_Selection"), 2, -1) != 0)
        return;
      this.tickLabelFont = fontChooserPanel.getSelectedFont();
      ((JTextComponent) this.tickLabelFontField).setText(new StringBuffer().append(this.tickLabelFont.getFontName()).append(" ").append(this.tickLabelFont.getSize()).toString());
    }

    [LineNumberTable((ushort) 299)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string getLabel()
    {
      return ((JTextComponent) this.label).getText();
    }

    public virtual Font getLabelFont()
    {
      return this.labelFont;
    }

    [LineNumberTable((ushort) 317)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getLabelPaint()
    {
      return this.labelPaintSample.getPaint();
    }

    [LineNumberTable((ushort) 354)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isTickMarksVisible()
    {
      return (((AbstractButton) this.showTickMarksCheckBox).isSelected() ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 326)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool isTickLabelsVisible()
    {
      return (((AbstractButton) this.showTickLabelsCheckBox).isSelected() ? 1 : 0) != 0;
    }

    public virtual Font getTickLabelFont()
    {
      return this.tickLabelFont;
    }

    [LineNumberTable((ushort) 344)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getTickLabelPaint()
    {
      return this.tickLabelPaintSample.getPaint();
    }

    [LineNumberTable((ushort) 363)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleInsets getTickLabelInsets()
    {
      if (this.tickLabelInsets == null)
        return new RectangleInsets(0.0, 0.0, 0.0, 0.0);
      else
        return this.tickLabelInsets;
    }

    [LineNumberTable((ushort) 374)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleInsets getLabelInsets()
    {
      if (this.labelInsets == null)
        return new RectangleInsets(0.0, 0.0, 0.0, 0.0);
      else
        return this.labelInsets;
    }

    [LineNumberTable(new byte[] {(byte) 101, (byte) 163, (byte) 104, (byte) 179, (byte) 201})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DefaultAxisEditor getInstance([In] Axis obj0)
    {
      if (obj0 == null)
        return (DefaultAxisEditor) null;
      if (obj0 is NumberAxis)
      {
        DefaultNumberAxisEditor.__\u003Cclinit\u003E();
        return (DefaultAxisEditor) new DefaultNumberAxisEditor((NumberAxis) obj0);
      }
      else
        return new DefaultAxisEditor(obj0);
    }

    public virtual JTabbedPane getOtherTabs()
    {
      return this.otherTabs;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 24, (byte) 103, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 232, (byte) 72})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      string actionCommand = obj0.getActionCommand();
      if (String.instancehelper_equals(actionCommand, (object) "SelectLabelFont"))
        this.attemptLabelFontSelection();
      else if (String.instancehelper_equals(actionCommand, (object) "SelectLabelPaint"))
      {
        this.attemptModifyLabelPaint();
      }
      else
      {
        if (!String.instancehelper_equals(actionCommand, (object) "SelectTickLabelFont"))
          return;
        this.attemptTickLabelFontSelection();
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 138, (byte) 108, (byte) 108, (byte) 108, (byte) 140, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAxisProperties([In] Axis obj0)
    {
      obj0.setLabel(this.getLabel());
      obj0.setLabelFont(this.getLabelFont());
      obj0.setLabelPaint(this.getLabelPaint());
      obj0.setTickMarksVisible(this.isTickMarksVisible());
      obj0.setTickLabelsVisible(this.isTickLabelsVisible());
      obj0.setTickLabelFont(this.getTickLabelFont());
      obj0.setTickLabelPaint(this.getTickLabelPaint());
      obj0.setTickLabelInsets(this.getTickLabelInsets());
      obj0.setLabelInsets(this.getLabelInsets());
    }
  }
}
