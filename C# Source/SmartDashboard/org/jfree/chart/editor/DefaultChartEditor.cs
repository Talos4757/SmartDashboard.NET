// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.editor.DefaultChartEditor
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
using org.jfree.chart;
using org.jfree.chart.plot;
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
  [Implements(new string[] {"java.awt.event.ActionListener", "org.jfree.chart.editor.ChartEditor"})]
  [Modifiers]
  [Serializable]
  internal sealed class DefaultChartEditor : JPanel, ActionListener, EventListener, ChartEditor
  {
    private DefaultTitleEditor titleEditor;
    private DefaultPlotEditor plotEditor;
    private JCheckBox antialias;
    private PaintSample background;
    protected internal static ResourceBundle localizationResources;

    [LineNumberTable((ushort) 91)]
    static DefaultChartEditor()
    {
      JPanel.__\u003Cclinit\u003E();
      DefaultChartEditor.localizationResources = ResourceBundleWrapper.getBundle("org.jfree.chart.editor.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 51, (byte) 104, (byte) 139, (byte) 112, (byte) 143, (byte) 112, (byte) 223, (byte) 0, (byte) 113, (byte) 143, (byte) 159, (byte) 0, (byte) 113, (byte) 109, (byte) 113, (byte) 113, (byte) 159, (byte) 1, (byte) 118, (byte) 109, (byte) 155, (byte) 108, (byte) 104, (byte) 137, (byte) 159, (byte) 1, (byte) 155, (byte) 104, (byte) 105, (byte) 123, (byte) 104, (byte) 137, (byte) 159, (byte) 1, (byte) 155, (byte) 104, (byte) 105, (byte) 123, (byte) 104, (byte) 137, (byte) 159, (byte) 1, (byte) 155, (byte) 104, (byte) 105, (byte) 123, (byte) 104, (byte) 137, (byte) 159, (byte) 1, (byte) 155, (byte) 104, (byte) 105, (byte) 123, (byte) 104, (byte) 137, (byte) 108, (byte) 140, (byte) 145, (byte) 104, (byte) 136, (byte) 135, (byte) 109, (byte) 116, (byte) 156, (byte) 109, (byte) 116, (byte) 156, (byte) 120, (byte) 110, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultChartEditor([In] JFreeChart obj0)
    {
      base.\u002Ector();
      DefaultChartEditor defaultChartEditor = this;
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel1 = new JPanel((LayoutManager) new BorderLayout());
      ((JComponent) jpanel1).setBorder(BorderFactory.createEmptyBorder(2, 2, 2, 2));
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel2 = new JPanel((LayoutManager) new BorderLayout());
      ((JComponent) jpanel2).setBorder((Border) BorderFactory.createTitledBorder(BorderFactory.createEtchedBorder(), DefaultChartEditor.localizationResources.getString("General")));
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel3 = new JPanel((LayoutManager) new LCBLayout(6));
      ((JComponent) jpanel3).setBorder(BorderFactory.createEmptyBorder(0, 5, 0, 5));
      JCheckBox.__\u003Cclinit\u003E();
      this.antialias = new JCheckBox(DefaultChartEditor.localizationResources.getString("Draw_anti-aliased"));
      ((AbstractButton) this.antialias).setSelected(obj0.getAntiAlias());
      ((Container) jpanel3).add((Component) this.antialias);
      ((Container) jpanel3).add((Component) new JLabel(""));
      ((Container) jpanel3).add((Component) new JLabel(""));
      JPanel jpanel4 = jpanel3;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel1 = new JLabel(DefaultChartEditor.localizationResources.getString("Background_paint"));
      ((Container) jpanel4).add((Component) jlabel1);
      PaintSample.__\u003Cclinit\u003E();
      this.background = new PaintSample(obj0.getBackgroundPaint());
      ((Container) jpanel3).add((Component) this.background);
      JButton.__\u003Cclinit\u003E();
      JButton jbutton1 = new JButton(DefaultChartEditor.localizationResources.getString("Select..."));
      ((AbstractButton) jbutton1).setActionCommand("BackgroundPaint");
      ((AbstractButton) jbutton1).addActionListener((ActionListener) this);
      ((Container) jpanel3).add((Component) jbutton1);
      JPanel jpanel5 = jpanel3;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel2 = new JLabel(DefaultChartEditor.localizationResources.getString("Series_Paint"));
      ((Container) jpanel5).add((Component) jlabel2);
      JTextField.__\u003Cclinit\u003E();
      JTextField jtextField1 = new JTextField(DefaultChartEditor.localizationResources.getString("No_editor_implemented"));
      ((JComponent) jtextField1).setEnabled(false);
      ((Container) jpanel3).add((Component) jtextField1);
      JButton.__\u003Cclinit\u003E();
      JButton jbutton2 = new JButton(DefaultChartEditor.localizationResources.getString("Edit..."));
      ((AbstractButton) jbutton2).setEnabled(false);
      ((Container) jpanel3).add((Component) jbutton2);
      JPanel jpanel6 = jpanel3;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel3 = new JLabel(DefaultChartEditor.localizationResources.getString("Series_Stroke"));
      ((Container) jpanel6).add((Component) jlabel3);
      JTextField.__\u003Cclinit\u003E();
      JTextField jtextField2 = new JTextField(DefaultChartEditor.localizationResources.getString("No_editor_implemented"));
      ((JComponent) jtextField2).setEnabled(false);
      ((Container) jpanel3).add((Component) jtextField2);
      JButton.__\u003Cclinit\u003E();
      JButton jbutton3 = new JButton(DefaultChartEditor.localizationResources.getString("Edit..."));
      ((AbstractButton) jbutton3).setEnabled(false);
      ((Container) jpanel3).add((Component) jbutton3);
      JPanel jpanel7 = jpanel3;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel4 = new JLabel(DefaultChartEditor.localizationResources.getString("Series_Outline_Paint"));
      ((Container) jpanel7).add((Component) jlabel4);
      JTextField.__\u003Cclinit\u003E();
      JTextField jtextField3 = new JTextField(DefaultChartEditor.localizationResources.getString("No_editor_implemented"));
      ((JComponent) jtextField3).setEnabled(false);
      ((Container) jpanel3).add((Component) jtextField3);
      JButton.__\u003Cclinit\u003E();
      JButton jbutton4 = new JButton(DefaultChartEditor.localizationResources.getString("Edit..."));
      ((AbstractButton) jbutton4).setEnabled(false);
      ((Container) jpanel3).add((Component) jbutton4);
      JPanel jpanel8 = jpanel3;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel5 = new JLabel(DefaultChartEditor.localizationResources.getString("Series_Outline_Stroke"));
      ((Container) jpanel8).add((Component) jlabel5);
      JTextField.__\u003Cclinit\u003E();
      JTextField jtextField4 = new JTextField(DefaultChartEditor.localizationResources.getString("No_editor_implemented"));
      ((JComponent) jtextField4).setEnabled(false);
      ((Container) jpanel3).add((Component) jtextField4);
      JButton.__\u003Cclinit\u003E();
      JButton jbutton5 = new JButton(DefaultChartEditor.localizationResources.getString("Edit..."));
      ((AbstractButton) jbutton5).setEnabled(false);
      ((Container) jpanel3).add((Component) jbutton5);
      ((Container) jpanel2).add((Component) jpanel3, (object) "North");
      ((Container) jpanel1).add((Component) jpanel2, (object) "North");
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel9 = new JPanel((LayoutManager) new BorderLayout());
      TextTitle title = obj0.getTitle();
      Plot plot = obj0.getPlot();
      JTabbedPane jtabbedPane = new JTabbedPane();
      this.titleEditor = new DefaultTitleEditor((Title) title);
      ((JComponent) this.titleEditor).setBorder(BorderFactory.createEmptyBorder(2, 2, 2, 2));
      jtabbedPane.addTab(DefaultChartEditor.localizationResources.getString("Title"), (Component) this.titleEditor);
      this.plotEditor = new DefaultPlotEditor(plot);
      ((JComponent) this.plotEditor).setBorder(BorderFactory.createEmptyBorder(2, 2, 2, 2));
      jtabbedPane.addTab(DefaultChartEditor.localizationResources.getString("Plot"), (Component) this.plotEditor);
      jtabbedPane.add(DefaultChartEditor.localizationResources.getString("Other"), (Component) jpanel1);
      ((Container) jpanel9).add((Component) jtabbedPane, (object) "North");
      ((Container) this).add((Component) jpanel9);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultChartEditor([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 135, (byte) 155, (byte) 99, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void attemptModifyBackgroundPaint()
    {
      Color color = JColorChooser.showDialog((Component) this, DefaultChartEditor.localizationResources.getString("Background_Color"), (Color) Color.blue);
      if (color == null)
        return;
      this.background.setPaint((Paint) color);
    }

    [LineNumberTable((ushort) 218)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool getAntiAlias()
    {
      return (((AbstractButton) this.antialias).isSelected() ? 1 : 0) != 0;
    }

    [LineNumberTable((ushort) 227)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getBackgroundPaint()
    {
      return this.background.getPaint();
    }

    public virtual DefaultTitleEditor getTitleEditor()
    {
      return this.titleEditor;
    }

    public virtual DefaultPlotEditor getPlotEditor()
    {
      return this.plotEditor;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 122, (byte) 103, (byte) 109, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      if (!String.instancehelper_equals(obj0.getActionCommand(), (object) "BackgroundPaint"))
        return;
      this.attemptModifyBackgroundPaint();
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 150, (byte) 108, (byte) 145, (byte) 108, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void updateChart([In] JFreeChart obj0)
    {
      this.titleEditor.setTitleProperties(obj0);
      this.plotEditor.updatePlotProperties(obj0.getPlot());
      obj0.setAntiAlias(this.getAntiAlias());
      obj0.setBackgroundPaint(this.getBackgroundPaint());
    }
  }
}
