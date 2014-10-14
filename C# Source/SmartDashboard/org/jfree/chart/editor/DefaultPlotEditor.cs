// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.editor.DefaultPlotEditor
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
using org.jfree.chart.axis;
using org.jfree.chart.plot;
using org.jfree.chart.renderer.category;
using org.jfree.chart.renderer.xy;
using org.jfree.layout;
using org.jfree.ui;
using org.jfree.util;
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
  internal sealed class DefaultPlotEditor : JPanel, ActionListener, EventListener
  {
    [Modifiers]
    private static string[] orientationNames;
    private const int ORIENTATION_VERTICAL = 0;
    private const int ORIENTATION_HORIZONTAL = 1;
    private PaintSample backgroundPaintSample;
    private StrokeSample outlineStrokeSample;
    private PaintSample outlinePaintSample;
    private DefaultAxisEditor domainAxisPropertyPanel;
    private DefaultAxisEditor rangeAxisPropertyPanel;
    private DefaultColorBarEditor colorBarAxisPropertyPanel;
    private StrokeSample[] availableStrokeSamples;
    private RectangleInsets plotInsets;
    private PlotOrientation plotOrientation;
    private JComboBox orientationCombo;
    private Boolean drawLines;
    private JCheckBox drawLinesCheckBox;
    private Boolean drawShapes;
    private JCheckBox drawShapesCheckBox;
    protected internal static ResourceBundle localizationResources;

    [LineNumberTable(new byte[] {(byte) 159, (byte) 119, (byte) 69, (byte) 251, (byte) 160, (byte) 68})]
    static DefaultPlotEditor()
    {
      JPanel.__\u003Cclinit\u003E();
      string[] strArray = new string[2];
      int index1 = 0;
      string str1 = "Vertical";
      strArray[index1] = str1;
      int index2 = 1;
      string str2 = "Horizontal";
      strArray[index2] = str2;
      DefaultPlotEditor.orientationNames = strArray;
      DefaultPlotEditor.localizationResources = org.jfree.chart.util.ResourceBundleWrapper.getBundle("org.jfree.chart.editor.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 125, (byte) 104, (byte) 108, (byte) 118, (byte) 118, (byte) 118, (byte) 104, (byte) 147, (byte) 104, (byte) 145, (byte) 104, (byte) 108, (byte) 104, (byte) 103, (byte) 145, (byte) 177, (byte) 98, (byte) 104, (byte) 108, (byte) 104, (byte) 104, (byte) 114, (byte) 242, (byte) 69, (byte) 139, (byte) 108, (byte) 110, (byte) 156, (byte) 156, (byte) 220, (byte) 113, (byte) 223, (byte) 27, (byte) 113, (byte) 187, (byte) 114, (byte) 240, (byte) 78, (byte) 159, (byte) 2, (byte) 155, (byte) 108, (byte) 104, (byte) 110, (byte) 138, (byte) 159, (byte) 2, (byte) 123, (byte) 108, (byte) 104, (byte) 110, (byte) 138, (byte) 159, (byte) 2, (byte) 123, (byte) 108, (byte) 104, (byte) 110, (byte) 138, (byte) 107, (byte) 146, (byte) 138, (byte) 159, (byte) 2, (byte) 117, (byte) 109, (byte) 112, (byte) 108, (byte) 109, (byte) 174, (byte) 107, (byte) 159, (byte) 2, (byte) 107, (byte) 118, (byte) 112, (byte) 108, (byte) 109, (byte) 174, (byte) 107, (byte) 159, (byte) 2, (byte) 107, (byte) 118, (byte) 112, (byte) 108, (byte) 109, (byte) 174, (byte) 142, (byte) 113, (byte) 112, (byte) 142, (byte) 103, (byte) 144, (byte) 99, (byte) 104, (byte) 143, (byte) 104, (byte) 141, (byte) 141, (byte) 104, (byte) 148, (byte) 221, (byte) 99, (byte) 104, (byte) 143, (byte) 104, (byte) 173, (byte) 109, (byte) 104, (byte) 148, (byte) 253, (byte) 69, (byte) 99, (byte) 104, (byte) 173, (byte) 141, (byte) 104, (byte) 148, (byte) 253, (byte) 69, (byte) 121, (byte) 138, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultPlotEditor([In] Plot obj0)
    {
      base.\u002Ector();
      DefaultPlotEditor defaultPlotEditor = this;
      this.plotInsets = obj0.getInsets();
      PaintSample.__\u003Cclinit\u003E();
      this.backgroundPaintSample = new PaintSample(obj0.getBackgroundPaint());
      StrokeSample.__\u003Cclinit\u003E();
      this.outlineStrokeSample = new StrokeSample(obj0.getOutlineStroke());
      PaintSample.__\u003Cclinit\u003E();
      this.outlinePaintSample = new PaintSample(obj0.getOutlinePaint());
      if (obj0 is CategoryPlot)
        this.plotOrientation = ((CategoryPlot) obj0).getOrientation();
      else if (obj0 is XYPlot)
        this.plotOrientation = ((XYPlot) obj0).getOrientation();
      if (obj0 is CategoryPlot)
      {
        CategoryItemRenderer renderer = ((CategoryPlot) obj0).getRenderer();
        if (renderer is LineAndShapeRenderer)
        {
          LineAndShapeRenderer andShapeRenderer = (LineAndShapeRenderer) renderer;
          this.drawLines = BooleanUtilities.valueOf(andShapeRenderer.getBaseLinesVisible());
          this.drawShapes = BooleanUtilities.valueOf(andShapeRenderer.getBaseShapesVisible());
        }
      }
      else if (obj0 is XYPlot)
      {
        XYItemRenderer renderer = ((XYPlot) obj0).getRenderer();
        if (renderer is StandardXYItemRenderer)
        {
          StandardXYItemRenderer standardXyItemRenderer = (StandardXYItemRenderer) renderer;
          this.drawLines = BooleanUtilities.valueOf(standardXyItemRenderer.getPlotLines());
          this.drawShapes = BooleanUtilities.valueOf(standardXyItemRenderer.getBaseShapesVisible());
        }
      }
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      this.availableStrokeSamples = new StrokeSample[4];
      this.availableStrokeSamples[0] = new StrokeSample((Stroke) null);
      StrokeSample[] strokeSampleArray1 = this.availableStrokeSamples;
      int index1 = 1;
      StrokeSample.__\u003Cclinit\u003E();
      StrokeSample strokeSample1 = new StrokeSample((Stroke) new BasicStroke(1f));
      strokeSampleArray1[index1] = strokeSample1;
      StrokeSample[] strokeSampleArray2 = this.availableStrokeSamples;
      int index2 = 2;
      StrokeSample.__\u003Cclinit\u003E();
      StrokeSample strokeSample2 = new StrokeSample((Stroke) new BasicStroke(2f));
      strokeSampleArray2[index2] = strokeSample2;
      StrokeSample[] strokeSampleArray3 = this.availableStrokeSamples;
      int index3 = 3;
      StrokeSample.__\u003Cclinit\u003E();
      StrokeSample strokeSample3 = new StrokeSample((Stroke) new BasicStroke(3f));
      strokeSampleArray3[index3] = strokeSample3;
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel1 = new JPanel((LayoutManager) new BorderLayout());
      ((JComponent) jpanel1).setBorder((Border) BorderFactory.createTitledBorder(BorderFactory.createEtchedBorder(), new StringBuffer().append(obj0.getPlotType()).append(DefaultPlotEditor.localizationResources.getString(":")).toString()));
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel2 = new JPanel((LayoutManager) new BorderLayout());
      ((JComponent) jpanel2).setBorder((Border) BorderFactory.createTitledBorder(DefaultPlotEditor.localizationResources.getString("General")));
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel3 = new JPanel((LayoutManager) new LCBLayout(7));
      ((JComponent) jpanel3).setBorder(BorderFactory.createEmptyBorder(0, 5, 0, 5));
      JPanel jpanel4 = jpanel3;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel1 = new JLabel(DefaultPlotEditor.localizationResources.getString("Outline_stroke"));
      ((Container) jpanel4).add((Component) jlabel1);
      JButton.__\u003Cclinit\u003E();
      JButton jbutton1 = new JButton(DefaultPlotEditor.localizationResources.getString("Select..."));
      ((AbstractButton) jbutton1).setActionCommand("OutlineStroke");
      ((AbstractButton) jbutton1).addActionListener((ActionListener) this);
      ((Container) jpanel3).add((Component) this.outlineStrokeSample);
      ((Container) jpanel3).add((Component) jbutton1);
      JPanel jpanel5 = jpanel3;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel2 = new JLabel(DefaultPlotEditor.localizationResources.getString("Outline_Paint"));
      ((Container) jpanel5).add((Component) jlabel2);
      JButton.__\u003Cclinit\u003E();
      JButton jbutton2 = new JButton(DefaultPlotEditor.localizationResources.getString("Select..."));
      ((AbstractButton) jbutton2).setActionCommand("OutlinePaint");
      ((AbstractButton) jbutton2).addActionListener((ActionListener) this);
      ((Container) jpanel3).add((Component) this.outlinePaintSample);
      ((Container) jpanel3).add((Component) jbutton2);
      JPanel jpanel6 = jpanel3;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel3 = new JLabel(DefaultPlotEditor.localizationResources.getString("Background_paint"));
      ((Container) jpanel6).add((Component) jlabel3);
      JButton.__\u003Cclinit\u003E();
      JButton jbutton3 = new JButton(DefaultPlotEditor.localizationResources.getString("Select..."));
      ((AbstractButton) jbutton3).setActionCommand("BackgroundPaint");
      ((AbstractButton) jbutton3).addActionListener((ActionListener) this);
      ((Container) jpanel3).add((Component) this.backgroundPaintSample);
      ((Container) jpanel3).add((Component) jbutton3);
      if (this.plotOrientation != null)
      {
        int num = !this.plotOrientation.equals((object) PlotOrientation.__\u003C\u003EVERTICAL) ? 1 : 0;
        JPanel jpanel7 = jpanel3;
        JLabel.__\u003Cclinit\u003E();
        JLabel jlabel4 = new JLabel(DefaultPlotEditor.localizationResources.getString("Orientation"));
        ((Container) jpanel7).add((Component) jlabel4);
        JComboBox.__\u003Cclinit\u003E();
        this.orientationCombo = new JComboBox((object[]) DefaultPlotEditor.orientationNames);
        this.orientationCombo.setSelectedIndex(num);
        this.orientationCombo.setActionCommand("Orientation");
        this.orientationCombo.addActionListener((ActionListener) this);
        ((Container) jpanel3).add((Component) new JPanel());
        ((Container) jpanel3).add((Component) this.orientationCombo);
      }
      if (this.drawLines != null)
      {
        JPanel jpanel7 = jpanel3;
        JLabel.__\u003Cclinit\u003E();
        JLabel jlabel4 = new JLabel(DefaultPlotEditor.localizationResources.getString("Draw_lines"));
        ((Container) jpanel7).add((Component) jlabel4);
        this.drawLinesCheckBox = new JCheckBox();
        ((AbstractButton) this.drawLinesCheckBox).setSelected(this.drawLines.booleanValue());
        ((AbstractButton) this.drawLinesCheckBox).setActionCommand("DrawLines");
        ((AbstractButton) this.drawLinesCheckBox).addActionListener((ActionListener) this);
        ((Container) jpanel3).add((Component) new JPanel());
        ((Container) jpanel3).add((Component) this.drawLinesCheckBox);
      }
      if (this.drawShapes != null)
      {
        JPanel jpanel7 = jpanel3;
        JLabel.__\u003Cclinit\u003E();
        JLabel jlabel4 = new JLabel(DefaultPlotEditor.localizationResources.getString("Draw_shapes"));
        ((Container) jpanel7).add((Component) jlabel4);
        this.drawShapesCheckBox = new JCheckBox();
        ((AbstractButton) this.drawShapesCheckBox).setSelected(this.drawShapes.booleanValue());
        ((AbstractButton) this.drawShapesCheckBox).setActionCommand("DrawShapes");
        ((AbstractButton) this.drawShapesCheckBox).addActionListener((ActionListener) this);
        ((Container) jpanel3).add((Component) new JPanel());
        ((Container) jpanel3).add((Component) this.drawShapesCheckBox);
      }
      ((Container) jpanel2).add((Component) jpanel3, (object) "North");
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel8 = new JPanel((LayoutManager) new BorderLayout());
      ((JComponent) jpanel8).setBorder(BorderFactory.createEmptyBorder(2, 2, 2, 2));
      ((Container) jpanel8).add((Component) jpanel2, (object) "North");
      JTabbedPane jtabbedPane = new JTabbedPane();
      ((JComponent) jtabbedPane).setBorder(BorderFactory.createEmptyBorder(0, 5, 0, 5));
      Axis axis = (Axis) null;
      if (obj0 is CategoryPlot)
        axis = (Axis) ((CategoryPlot) obj0).getDomainAxis();
      else if (obj0 is XYPlot)
        axis = (Axis) ((XYPlot) obj0).getDomainAxis();
      this.domainAxisPropertyPanel = DefaultAxisEditor.getInstance(axis);
      if (this.domainAxisPropertyPanel != null)
      {
        ((JComponent) this.domainAxisPropertyPanel).setBorder(BorderFactory.createEmptyBorder(2, 2, 2, 2));
        jtabbedPane.add(DefaultPlotEditor.localizationResources.getString("Domain_Axis"), (Component) this.domainAxisPropertyPanel);
      }
      ValueAxis valueAxis = (ValueAxis) null;
      if (obj0 is CategoryPlot)
        valueAxis = ((CategoryPlot) obj0).getRangeAxis();
      else if (obj0 is XYPlot)
        valueAxis = ((XYPlot) obj0).getRangeAxis();
      this.rangeAxisPropertyPanel = DefaultAxisEditor.getInstance((Axis) valueAxis);
      if (this.rangeAxisPropertyPanel != null)
      {
        ((JComponent) this.rangeAxisPropertyPanel).setBorder(BorderFactory.createEmptyBorder(2, 2, 2, 2));
        jtabbedPane.add(DefaultPlotEditor.localizationResources.getString("Range_Axis"), (Component) this.rangeAxisPropertyPanel);
      }
      ColorBar colorBar = (ColorBar) null;
      if (obj0 is ContourPlot)
        colorBar = ((ContourPlot) obj0).getColorBar();
      this.colorBarAxisPropertyPanel = DefaultColorBarEditor.getInstance(colorBar);
      if (this.colorBarAxisPropertyPanel != null)
      {
        ((JComponent) this.colorBarAxisPropertyPanel).setBorder(BorderFactory.createEmptyBorder(2, 2, 2, 2));
        jtabbedPane.add(DefaultPlotEditor.localizationResources.getString("Color_Bar"), (Component) this.colorBarAxisPropertyPanel);
      }
      jtabbedPane.add(DefaultPlotEditor.localizationResources.getString("Appearance"), (Component) jpanel8);
      ((Container) jpanel1).add((Component) jtabbedPane);
      ((Container) this).add((Component) jpanel1);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultPlotEditor([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 185, (byte) 108, (byte) 108, (byte) 108, (byte) 172, (byte) 104, (byte) 98, (byte) 104, (byte) 103, (byte) 103, (byte) 98, (byte) 104, (byte) 103, (byte) 135, (byte) 99, (byte) 204, (byte) 104, (byte) 98, (byte) 104, (byte) 103, (byte) 103, (byte) 98, (byte) 104, (byte) 103, (byte) 135, (byte) 99, (byte) 204, (byte) 104, (byte) 104, (byte) 104, (byte) 109, (byte) 98, (byte) 104, (byte) 104, (byte) 205, (byte) 107, (byte) 104, (byte) 104, (byte) 105, (byte) 105, (byte) 183, (byte) 98, (byte) 104, (byte) 104, (byte) 105, (byte) 105, (byte) 247, (byte) 70, (byte) 107, (byte) 104, (byte) 104, (byte) 105, (byte) 105, (byte) 183, (byte) 98, (byte) 104, (byte) 104, (byte) 105, (byte) 105, (byte) 247, (byte) 71, (byte) 104, (byte) 99, (byte) 104, (byte) 104, (byte) 137, (byte) 100, (byte) 239, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void updatePlotProperties([In] Plot obj0)
    {
      obj0.setOutlinePaint(this.getOutlinePaint());
      obj0.setOutlineStroke(this.getOutlineStroke());
      obj0.setBackgroundPaint(this.getBackgroundPaint());
      obj0.setInsets(this.getPlotInsets());
      if (this.domainAxisPropertyPanel != null)
      {
        Axis axis = (Axis) null;
        if (obj0 is CategoryPlot)
          axis = (Axis) ((CategoryPlot) obj0).getDomainAxis();
        else if (obj0 is XYPlot)
          axis = (Axis) ((XYPlot) obj0).getDomainAxis();
        if (axis != null)
          this.domainAxisPropertyPanel.setAxisProperties(axis);
      }
      if (this.rangeAxisPropertyPanel != null)
      {
        ValueAxis valueAxis = (ValueAxis) null;
        if (obj0 is CategoryPlot)
          valueAxis = ((CategoryPlot) obj0).getRangeAxis();
        else if (obj0 is XYPlot)
          valueAxis = ((XYPlot) obj0).getRangeAxis();
        if (valueAxis != null)
          this.rangeAxisPropertyPanel.setAxisProperties((Axis) valueAxis);
      }
      if (this.plotOrientation != null)
      {
        if (obj0 is CategoryPlot)
          ((CategoryPlot) obj0).setOrientation(this.plotOrientation);
        else if (obj0 is XYPlot)
          ((XYPlot) obj0).setOrientation(this.plotOrientation);
      }
      if (this.drawLines != null)
      {
        if (obj0 is CategoryPlot)
        {
          CategoryItemRenderer renderer = ((CategoryPlot) obj0).getRenderer();
          if (renderer is LineAndShapeRenderer)
            ((LineAndShapeRenderer) renderer).setLinesVisible(this.drawLines.booleanValue());
        }
        else if (obj0 is XYPlot)
        {
          XYItemRenderer renderer = ((XYPlot) obj0).getRenderer();
          if (renderer is StandardXYItemRenderer)
            ((StandardXYItemRenderer) renderer).setPlotLines(this.drawLines.booleanValue());
        }
      }
      if (this.drawShapes != null)
      {
        if (obj0 is CategoryPlot)
        {
          CategoryItemRenderer renderer = ((CategoryPlot) obj0).getRenderer();
          if (renderer is LineAndShapeRenderer)
            ((LineAndShapeRenderer) renderer).setShapesVisible(this.drawShapes.booleanValue());
        }
        else if (obj0 is XYPlot)
        {
          XYItemRenderer renderer = ((XYPlot) obj0).getRenderer();
          if (renderer is StandardXYItemRenderer)
            ((StandardXYItemRenderer) renderer).setBaseShapesVisible(this.drawShapes.booleanValue());
        }
      }
      if (this.colorBarAxisPropertyPanel == null)
        return;
      ColorBar colorBar = (ColorBar) null;
      if (obj0 is ContourPlot)
        colorBar = ((ContourPlot) obj0).getColorBar();
      if (colorBar == null)
        return;
      this.colorBarAxisPropertyPanel.setAxisProperties(colorBar);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 90, (byte) 155, (byte) 99, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void attemptBackgroundPaintSelection()
    {
      Color color = JColorChooser.showDialog((Component) this, DefaultPlotEditor.localizationResources.getString("Background_Color"), (Color) Color.blue);
      if (color == null)
        return;
      this.backgroundPaintSample.setPaint((Paint) color);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 101, (byte) 151, (byte) 217, (byte) 99, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void attemptOutlineStrokeSelection()
    {
      StrokeChooserPanel.__\u003Cclinit\u003E();
      StrokeChooserPanel strokeChooserPanel = new StrokeChooserPanel(this.outlineStrokeSample, this.availableStrokeSamples);
      if (JOptionPane.showConfirmDialog((Component) this, (object) strokeChooserPanel, DefaultPlotEditor.localizationResources.getString("Stroke_Selection"), 2, -1) != 0)
        return;
      this.outlineStrokeSample.setStroke(strokeChooserPanel.getSelectedStroke());
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 118, (byte) 155, (byte) 99, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void attemptOutlinePaintSelection()
    {
      Color color = JColorChooser.showDialog((Component) this, DefaultPlotEditor.localizationResources.getString("Outline_Color"), (Color) Color.blue);
      if (color == null)
        return;
      this.outlinePaintSample.setPaint((Paint) color);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 148, (byte) 140, (byte) 99, (byte) 173, (byte) 139})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void attemptOrientationSelection()
    {
      if (this.orientationCombo.getSelectedIndex() == 0)
        this.plotOrientation = PlotOrientation.__\u003C\u003EVERTICAL;
      else
        this.plotOrientation = PlotOrientation.__\u003C\u003EHORIZONTAL;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 164, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void attemptDrawLinesSelection()
    {
      this.drawLines = BooleanUtilities.valueOf(((AbstractButton) this.drawLinesCheckBox).isSelected());
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 173, (byte) 150})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void attemptDrawShapesSelection()
    {
      this.drawShapes = BooleanUtilities.valueOf(((AbstractButton) this.drawShapesCheckBox).isSelected());
    }

    [LineNumberTable((ushort) 403)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getOutlinePaint()
    {
      return this.outlinePaintSample.getPaint();
    }

    [LineNumberTable((ushort) 394)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Stroke getOutlineStroke()
    {
      return this.outlineStrokeSample.getStroke();
    }

    [LineNumberTable((ushort) 385)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Paint getBackgroundPaint()
    {
      return this.backgroundPaintSample.getPaint();
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 3, (byte) 104, (byte) 159, (byte) 0})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual RectangleInsets getPlotInsets()
    {
      if (this.plotInsets == null)
        this.plotInsets = new RectangleInsets(0.0, 0.0, 0.0, 0.0);
      return this.plotInsets;
    }

    public virtual DefaultAxisEditor getDomainAxisPropertyEditPanel()
    {
      return this.domainAxisPropertyPanel;
    }

    public virtual DefaultAxisEditor getRangeAxisPropertyEditPanel()
    {
      return this.rangeAxisPropertyPanel;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 61, (byte) 103, (byte) 109, (byte) 139, (byte) 109, (byte) 136, (byte) 109, (byte) 232, (byte) 69, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void actionPerformed([In] ActionEvent obj0)
    {
      string actionCommand = obj0.getActionCommand();
      if (String.instancehelper_equals(actionCommand, (object) "BackgroundPaint"))
        this.attemptBackgroundPaintSelection();
      else if (String.instancehelper_equals(actionCommand, (object) "OutlineStroke"))
        this.attemptOutlineStrokeSelection();
      else if (String.instancehelper_equals(actionCommand, (object) "OutlinePaint"))
        this.attemptOutlinePaintSelection();
      else if (String.instancehelper_equals(actionCommand, (object) "Orientation"))
        this.attemptOrientationSelection();
      else if (String.instancehelper_equals(actionCommand, (object) "DrawLines"))
      {
        this.attemptDrawLinesSelection();
      }
      else
      {
        if (!String.instancehelper_equals(actionCommand, (object) "DrawShapes"))
          return;
        this.attemptDrawShapesSelection();
      }
    }
  }
}
