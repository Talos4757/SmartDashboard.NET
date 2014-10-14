// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.editor.DefaultColorBarEditor
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing;
using org.jfree.chart.axis;
using org.jfree.chart.plot;
using org.jfree.chart.util;
using org.jfree.layout;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.chart.editor
{
  [Modifiers]
  [Serializable]
  internal sealed class DefaultColorBarEditor : DefaultNumberAxisEditor
  {
    private JCheckBox invertPaletteCheckBox;
    private bool invertPalette;
    private JCheckBox stepPaletteCheckBox;
    private bool stepPalette;
    private PaletteSample currentPalette;
    private PaletteSample[] availablePaletteSamples;
    protected internal new static ResourceBundle localizationResources;

    [LineNumberTable((ushort) 97)]
    static DefaultColorBarEditor()
    {
      DefaultNumberAxisEditor.__\u003Cclinit\u003E();
      DefaultColorBarEditor.localizationResources = ResourceBundleWrapper.getBundle("org.jfree.chart.editor.LocalizationBundle");
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 243, (byte) 39, (byte) 231, (byte) 70, (byte) 231, (byte) 84, (byte) 113, (byte) 113, (byte) 118, (byte) 108, (byte) 151, (byte) 183, (byte) 135, (byte) 113, (byte) 143, (byte) 108, (byte) 223, (byte) 6, (byte) 112, (byte) 108, (byte) 109, (byte) 140, (byte) 108, (byte) 223, (byte) 6, (byte) 112, (byte) 108, (byte) 109, (byte) 140, (byte) 191, (byte) 1, (byte) 154, (byte) 107, (byte) 103, (byte) 109, (byte) 136, (byte) 151})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultColorBarEditor([In] ColorBar obj0)
      : base((NumberAxis) obj0.getAxis())
    {
      DefaultColorBarEditor defaultColorBarEditor = this;
      this.invertPalette = false;
      this.stepPalette = false;
      this.invertPalette = obj0.getColorPalette().isInverse();
      this.stepPalette = obj0.getColorPalette().isStepped();
      PaletteSample.__\u003Cclinit\u003E();
      this.currentPalette = new PaletteSample(obj0.getColorPalette());
      this.availablePaletteSamples = new PaletteSample[2];
      PaletteSample[] paletteSampleArray1 = this.availablePaletteSamples;
      int index1 = 0;
      PaletteSample.__\u003Cclinit\u003E();
      PaletteSample paletteSample1 = new PaletteSample((ColorPalette) new RainbowPalette());
      paletteSampleArray1[index1] = paletteSample1;
      PaletteSample[] paletteSampleArray2 = this.availablePaletteSamples;
      int index2 = 1;
      PaletteSample.__\u003Cclinit\u003E();
      PaletteSample paletteSample2 = new PaletteSample((ColorPalette) new GreyPalette());
      paletteSampleArray2[index2] = paletteSample2;
      JTabbedPane otherTabs = this.getOtherTabs();
      JPanel.__\u003Cclinit\u003E();
      JPanel jpanel1 = new JPanel((LayoutManager) new LCBLayout(4));
      ((JComponent) jpanel1).setBorder(BorderFactory.createEmptyBorder(4, 4, 4, 4));
      ((Container) jpanel1).add((Component) new JPanel());
      JCheckBox.__\u003Cclinit\u003E();
      this.invertPaletteCheckBox = new JCheckBox(DefaultColorBarEditor.localizationResources.getString("Invert_Palette"), this.invertPalette);
      ((AbstractButton) this.invertPaletteCheckBox).setActionCommand("invertPalette");
      ((AbstractButton) this.invertPaletteCheckBox).addActionListener((ActionListener) this);
      ((Container) jpanel1).add((Component) this.invertPaletteCheckBox);
      ((Container) jpanel1).add((Component) new JPanel());
      ((Container) jpanel1).add((Component) new JPanel());
      JCheckBox.__\u003Cclinit\u003E();
      this.stepPaletteCheckBox = new JCheckBox(DefaultColorBarEditor.localizationResources.getString("Step_Palette"), this.stepPalette);
      ((AbstractButton) this.stepPaletteCheckBox).setActionCommand("stepPalette");
      ((AbstractButton) this.stepPaletteCheckBox).addActionListener((ActionListener) this);
      ((Container) jpanel1).add((Component) this.stepPaletteCheckBox);
      ((Container) jpanel1).add((Component) new JPanel());
      JPanel jpanel2 = jpanel1;
      JLabel.__\u003Cclinit\u003E();
      JLabel jlabel = new JLabel(DefaultColorBarEditor.localizationResources.getString("Palette"));
      ((Container) jpanel2).add((Component) jlabel);
      JButton.__\u003Cclinit\u003E();
      JButton jbutton = new JButton(DefaultColorBarEditor.localizationResources.getString("Set_palette..."));
      ((AbstractButton) jbutton).setActionCommand("PaletteChoice");
      ((AbstractButton) jbutton).addActionListener((ActionListener) this);
      ((Container) jpanel1).add((Component) this.currentPalette);
      ((Container) jpanel1).add((Component) jbutton);
      otherTabs.add(DefaultColorBarEditor.localizationResources.getString("Palette"), (Component) jpanel1);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DefaultColorBarEditor([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 67, (byte) 146, (byte) 249, (byte) 69, (byte) 99, (byte) 114, (byte) 114, (byte) 113, (byte) 113, (byte) 147})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void attemptPaletteSelection()
    {
      PaletteChooserPanel.__\u003Cclinit\u003E();
      PaletteChooserPanel paletteChooserPanel = new PaletteChooserPanel((PaletteSample) null, this.availablePaletteSamples);
      if (JOptionPane.showConfirmDialog((Component) this, (object) paletteChooserPanel, DefaultColorBarEditor.localizationResources.getString("Palette_Selection"), 2, -1) != 0)
        return;
      double minZ = this.currentPalette.getPalette().getMinZ();
      double maxZ = this.currentPalette.getPalette().getMaxZ();
      this.currentPalette.setPalette(paletteChooserPanel.getSelectedPalette());
      this.currentPalette.getPalette().setMinZ(minZ);
      this.currentPalette.getPalette().setMaxZ(maxZ);
    }

    [LineNumberTable(new byte[] {(byte) 112, (byte) 103, (byte) 109, (byte) 136, (byte) 109, (byte) 147, (byte) 109, (byte) 179, (byte) 137})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void actionPerformed([In] ActionEvent obj0)
    {
      string actionCommand = obj0.getActionCommand();
      if (String.instancehelper_equals(actionCommand, (object) "PaletteChoice"))
        this.attemptPaletteSelection();
      else if (String.instancehelper_equals(actionCommand, (object) "invertPalette"))
        this.invertPalette = ((AbstractButton) this.invertPaletteCheckBox).isSelected();
      else if (String.instancehelper_equals(actionCommand, (object) "stepPalette"))
        this.stepPalette = ((AbstractButton) this.stepPaletteCheckBox).isSelected();
      else
        base.actionPerformed(obj0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 90, (byte) 108, (byte) 113, (byte) 113, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAxisProperties([In] ColorBar obj0)
    {
      base.setAxisProperties((Axis) obj0.getAxis());
      obj0.setColorPalette(this.currentPalette.getPalette());
      obj0.getColorPalette().setInverse(this.invertPalette);
      obj0.getColorPalette().setStepped(this.stepPalette);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 106, (byte) 99, (byte) 169})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DefaultColorBarEditor getInstance([In] ColorBar obj0)
    {
      if (obj0 == null)
        return (DefaultColorBarEditor) null;
      return new DefaultColorBarEditor(obj0);
    }
  }
}
