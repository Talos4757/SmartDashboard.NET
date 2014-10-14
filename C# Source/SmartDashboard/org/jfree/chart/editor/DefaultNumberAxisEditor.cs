// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.editor.DefaultNumberAxisEditor
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing;
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
  [Implements(new string[] {"java.awt.event.FocusListener"})]
  [Serializable]
  internal class DefaultNumberAxisEditor : DefaultAxisEditor, FocusListener, EventListener
  {
    private bool autoRange;
    private double minimumValue;
    private double maximumValue;
    private JCheckBox autoRangeCheckBox;
    private JTextField minimumRangeValue;
    private JTextField maximumRangeValue;
    private PaintSample gridPaintSample;
    private StrokeSample gridStrokeSample;
    private StrokeSample[] availableStrokeSamples;
    protected internal new static ResourceBundle localizationResources;

    [LineNumberTable((ushort) 110)]
    static DefaultNumberAxisEditor()
    {
      DefaultAxisEditor.__\u003Cclinit\u003E();
      DefaultNumberAxisEditor.localizationResources = ResourceBundleWrapper.getBundle("org.jfree.chart.editor.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 137, (byte) 108, (byte) 109, (byte) 141, (byte) 117, (byte) 154, (byte) 108, (byte) 156, (byte) 156, (byte) 188, (byte) 135, (byte) 113, (byte) 143, (byte) 108, (byte) 159, (byte) 6, (byte) 112, (byte) 108, (byte) 109, (byte) 140, (byte) 159, (byte) 1, (byte) 155, (byte) 119, (byte) 112, (byte) 108, (byte) 108, (byte) 109, (byte) 140, (byte) 159, (byte) 1, (byte) 155, (byte) 119, (byte) 112, (byte) 108, (byte) 108, (byte) 109, (byte) 140, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultNumberAxisEditor([In] NumberAxis obj0)
      : base((Axis) obj0)
    {
      DefaultNumberAxisEditor numberAxisEditor = this;
      this.autoRange = obj0.isAutoRange();
      this.minimumValue = obj0.getLowerBound();
      this.maximumValue = obj0.getUpperBound();
      PaintSample.__\u003Cclinit\u003E();
      this.gridPaintSample = new PaintSample((Paint) Color.blue);
      StrokeSample.__\u003Cclinit\u003E();
      this.gridStrokeSample = new StrokeSample((Stroke) new BasicStroke(1f));
      this.availableStrokeSamples = new StrokeSample[3];
      StrokeSample[] strokeSampleArray1 = this.availableStrokeSamples;
      int index1 = 0;
      StrokeSample.__\u003Cclinit\u003E();
      StrokeSample strokeSample1 = new StrokeSample((Stroke) new BasicStroke(1f));
      strokeSampleArray1[index1] = strokeSample1;
      StrokeSample[] strokeSampleArray2 = this.availableStrokeSamples;
      int index2 = 1;
      StrokeSample.__\u003Cclinit\u003E();
      StrokeSample strokeSample2 = new StrokeSample((Stroke) new BasicStroke(2f));
      strokeSampleArray2[index2] = strokeSample2;
      StrokeSample[] strokeSampleArray3 = this.availableStrokeSamples;
      int index3 = 2;
      StrokeSample.__\u003Cclinit\u003E();
      StrokeSample strokeSample3 = new StrokeSample((Stroke) new BasicStroke(3f));
      strokeSampleArray3[index3] = strokeSample3;
      JTabbedPane otherTabs = this.getOtherTabs();
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel1 = new JPanel((LayoutManager) new LCBLayout(3));
      ((JComponent) jpanel1).setBorder(BorderFactory.createEmptyBorder(4, 4, 4, 4));
      ((Container) jpanel1).add((Component) new JPanel());
      JCheckBox.__\u003Cclinit\u003E();
      this.autoRangeCheckBox = new JCheckBox(DefaultNumberAxisEditor.localizationResources.getString("Auto-adjust_range"), this.autoRange);
      ((AbstractButton) this.autoRangeCheckBox).setActionCommand("AutoRangeOnOff");
      ((AbstractButton) this.autoRangeCheckBox).addActionListener((ActionListener) this);
      ((Container) jpanel1).add((Component) this.autoRangeCheckBox);
      ((Container) jpanel1).add((Component) new JPanel());
      JPanel jpanel2 = jpanel1;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel1 = new JLabel(DefaultNumberAxisEditor.localizationResources.getString("Minimum_range_value"));
      ((Container) jpanel2).add((Component) jlabel1);
      JTextField.__\u003Cclinit\u003E();
      this.minimumRangeValue = new JTextField(Double.toString(this.minimumValue));
      ((JComponent) this.minimumRangeValue).setEnabled(!this.autoRange);
      this.minimumRangeValue.setActionCommand("MinimumRange");
      this.minimumRangeValue.addActionListener((ActionListener) this);
      ((Component) this.minimumRangeValue).addFocusListener((FocusListener) this);
      ((Container) jpanel1).add((Component) this.minimumRangeValue);
      ((Container) jpanel1).add((Component) new JPanel());
      JPanel jpanel3 = jpanel1;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel2 = new JLabel(DefaultNumberAxisEditor.localizationResources.getString("Maximum_range_value"));
      ((Container) jpanel3).add((Component) jlabel2);
      JTextField.__\u003Cclinit\u003E();
      this.maximumRangeValue = new JTextField(Double.toString(this.maximumValue));
      ((JComponent) this.maximumRangeValue).setEnabled(!this.autoRange);
      this.maximumRangeValue.setActionCommand("MaximumRange");
      this.maximumRangeValue.addActionListener((ActionListener) this);
      ((Component) this.maximumRangeValue).addFocusListener((FocusListener) this);
      ((Container) jpanel1).add((Component) this.maximumRangeValue);
      ((Container) jpanel1).add((Component) new JPanel());
      otherTabs.add(DefaultNumberAxisEditor.localizationResources.getString("Range"), (Component) jpanel1);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultNumberAxisEditor([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 121, (byte) 151, (byte) 217, (byte) 99, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void attemptGridStrokeSelection()
    {
      StrokeChooserPanel.__\u003Cclinit\u003E();
      StrokeChooserPanel strokeChooserPanel = new StrokeChooserPanel(this.gridStrokeSample, this.availableStrokeSamples);
      if (JOptionPane.showConfirmDialog((Component) this, (object) strokeChooserPanel, DefaultNumberAxisEditor.localizationResources.getString("Stroke_Selection"), 2, -1) != 0)
        return;
      this.gridStrokeSample.setStroke(strokeChooserPanel.getSelectedStroke());
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 137, (byte) 155, (byte) 99, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void attemptGridPaintSelection()
    {
      Color color = JColorChooser.showDialog((Component) this, DefaultNumberAxisEditor.localizationResources.getString("Grid_Color"), (Color) Color.blue);
      if (color == null)
        return;
      this.gridPaintSample.setPaint((Paint) color);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 171, (byte) 113, (byte) 104, (byte) 118, (byte) 108, (byte) 118, (byte) 174, (byte) 108, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void toggleAutoRange()
    {
      this.autoRange = ((AbstractButton) this.autoRangeCheckBox).isSelected();
      if (this.autoRange)
      {
        ((JTextComponent) this.minimumRangeValue).setText(Double.toString(this.minimumValue));
        ((JComponent) this.minimumRangeValue).setEnabled(false);
        ((JTextComponent) this.maximumRangeValue).setText(Double.toString(this.maximumValue));
        ((JComponent) this.maximumRangeValue).setEnabled(false);
      }
      else
      {
        ((JComponent) this.minimumRangeValue).setEnabled(true);
        ((JComponent) this.maximumRangeValue).setEnabled(true);
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 190, (byte) 114, (byte) 105, (byte) 242, (byte) 69, (byte) 2, (byte) 97, (byte) 167, (byte) 104, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void validateMinimum()
    {
      double num;
      try
      {
        num = Double.parseDouble(((JTextComponent) this.minimumRangeValue).getText());
        if (num >= this.maximumValue)
        {
          num = this.minimumValue;
          goto label_4;
        }
        else
          goto label_4;
      }
      catch (NumberFormatException ex)
      {
      }
      num = this.minimumValue;
label_4:
      this.minimumValue = num;
      ((JTextComponent) this.minimumRangeValue).setText(Double.toString(this.minimumValue));
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 209, (byte) 114, (byte) 105, (byte) 242, (byte) 69, (byte) 2, (byte) 97, (byte) 167, (byte) 104, (byte) 118})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void validateMaximum()
    {
      double num;
      try
      {
        num = Double.parseDouble(((JTextComponent) this.maximumRangeValue).getText());
        if (num <= this.minimumValue)
        {
          num = this.maximumValue;
          goto label_4;
        }
        else
          goto label_4;
      }
      catch (NumberFormatException ex)
      {
      }
      num = this.maximumValue;
label_4:
      this.maximumValue = num;
      ((JTextComponent) this.maximumRangeValue).setText(Double.toString(this.maximumValue));
    }

    public virtual bool isAutoRange()
    {
      return this.autoRange;
    }

    public virtual double getMinimumValue()
    {
      return this.minimumValue;
    }

    public virtual double getMaximumValue()
    {
      return this.maximumValue;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 95, (byte) 103, (byte) 109, (byte) 139, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 136, (byte) 109, (byte) 200, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void actionPerformed([In] ActionEvent obj0)
    {
      string actionCommand = obj0.getActionCommand();
      if (String.instancehelper_equals(actionCommand, (object) "GridStroke"))
        this.attemptGridStrokeSelection();
      else if (String.instancehelper_equals(actionCommand, (object) "GridPaint"))
        this.attemptGridPaintSelection();
      else if (String.instancehelper_equals(actionCommand, (object) "AutoRangeOnOff"))
        this.toggleAutoRange();
      else if (String.instancehelper_equals(actionCommand, (object) "MinimumRange"))
        this.validateMinimum();
      else if (String.instancehelper_equals(actionCommand, (object) "MaximumRange"))
        this.validateMaximum();
      else
        base.actionPerformed(obj0);
    }

    public virtual void focusGained([In] FocusEvent obj0)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 159, (byte) 110, (byte) 136, (byte) 110, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void focusLost([In] FocusEvent obj0)
    {
      if (((EventObject) obj0).getSource() == this.minimumRangeValue)
      {
        this.validateMinimum();
      }
      else
      {
        if (((EventObject) obj0).getSource() != this.maximumRangeValue)
          return;
        this.validateMaximum();
      }
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 229, (byte) 103, (byte) 103, (byte) 108, (byte) 104, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setAxisProperties([In] Axis obj0)
    {
      base.setAxisProperties(obj0);
      NumberAxis numberAxis = (NumberAxis) obj0;
      numberAxis.setAutoRange(this.autoRange);
      if (this.autoRange)
        return;
      numberAxis.setRange(this.minimumValue, this.maximumValue);
    }
  }
}
