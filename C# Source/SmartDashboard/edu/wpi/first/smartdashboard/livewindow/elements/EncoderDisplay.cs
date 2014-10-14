// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.livewindow.elements.EncoderDisplay
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.gui.elements.bindings;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.types;
using edu.wpi.first.smartdashboard.types.named;
using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.livewindow.elements
{
  [Serializable]
  public class EncoderDisplay : AbstractTableWidget
  {
    internal static DataType[] __\u003C\u003ETYPES;
    [Modifiers]
    private JLabel speedTag;
    [Modifiers]
    private JLabel distanceTag;
    [Modifiers]
    private JLabel DPTTag;
    [Modifiers]
    private Widget.UneditableNumberField speed;
    [Modifiers]
    private Widget.UneditableNumberField distance;
    [Modifiers]
    private Widget.BindableNumberField DPT;
    private Widget.BindableBooleanCheckBox reversed;
    private JButton zero;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return EncoderDisplay.__\u003C\u003ETYPES;
      }
    }

    [LineNumberTable((ushort) 28)]
    static EncoderDisplay()
    {
      AbstractTableWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[3];
      int index1 = 0;
      NamedDataType namedDataType1 = QuadratureEncoderType.get();
      dataTypeArray[index1] = (DataType) namedDataType1;
      int index2 = 1;
      NamedDataType namedDataType2 = EncoderType.get();
      dataTypeArray[index2] = (DataType) namedDataType2;
      int index3 = 2;
      NamedDataType namedDataType3 = GearToothSensorType.get();
      dataTypeArray[index3] = (DataType) namedDataType3;
      EncoderDisplay.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 168, (byte) 200, (byte) 112, (byte) 112, (byte) 176, (byte) 139, (byte) 139, (byte) 204})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public EncoderDisplay()
    {
      EncoderDisplay encoderDisplay = this;
      this.speedTag = new JLabel("Speed");
      this.distanceTag = new JLabel("Distance");
      this.DPTTag = new JLabel("Distance per Tick");
      this.speed = new Widget.UneditableNumberField();
      this.distance = new Widget.UneditableNumberField();
      this.DPT = new Widget.BindableNumberField((NumberBindable) null);
      this.zero = new JButton("Zero Distance");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected EncoderDisplay([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    [LineNumberTable((ushort) 26)]
    internal static Widget.UneditableNumberField access\u0024000([In] EncoderDisplay obj0)
    {
      return obj0.distance;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 190, (byte) 149, (byte) 150, (byte) 113, (byte) 241, (byte) 71, (byte) 113, (byte) 113, (byte) 145, (byte) 107, (byte) 102, (byte) 103, (byte) 103, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 108, (byte) 109, (byte) 112, (byte) 109, (byte) 112, (byte) 103, (byte) 103, (byte) 109, (byte) 103, (byte) 109, (byte) 103, (byte) 109, (byte) 103, (byte) 109, (byte) 103, (byte) 108, (byte) 113, (byte) 103, (byte) 112, (byte) 112, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      Widget.BindableBooleanCheckBox.__\u003Cclinit\u003E();
      this.reversed = new Widget.BindableBooleanCheckBox(BooleanBindable.NULL);
      NameTag.__\u003Cclinit\u003E();
      this.nameTag = new NameTag(this.getFieldName());
      this.setBooleanBinding("Reversed", (BooleanBindable) this.reversed);
      ((AbstractButton) this.zero).addActionListener((ActionListener) new EncoderDisplay\u00241(this));
      this.setNumberBinding("Speed", (NumberBindable) this.speed);
      this.setNumberBinding("Distance", (NumberBindable) this.distance);
      this.setNumberBinding("Distance per Tick", (NumberBindable) this.DPT);
      ((Container) this).setLayout((LayoutManager) new GridBagLayout());
      GridBagConstraints gridBagConstraints = new GridBagConstraints();
      gridBagConstraints.fill = (__Null) 1;
      gridBagConstraints.gridx = (__Null) 0;
      gridBagConstraints.weightx = (__Null) 1.0;
      ((Container) this).add((Component) this.nameTag, (object) gridBagConstraints);
      gridBagConstraints.weightx = (__Null) 0.0;
      ((Container) this).add((Component) this.speedTag, (object) gridBagConstraints);
      gridBagConstraints.weightx = (__Null) 1.0;
      ((Container) this).add((Component) this.distanceTag, (object) gridBagConstraints);
      gridBagConstraints.weightx = (__Null) 2.0;
      ((Container) this).add((Component) this.DPTTag, (object) gridBagConstraints);
      gridBagConstraints.weightx = (__Null) 2.0;
      gridBagConstraints.gridx = (__Null) 2;
      gridBagConstraints.gridy = (__Null) 1;
      ((Container) this).add((Component) this.speed, (object) gridBagConstraints);
      gridBagConstraints.gridy = (__Null) 2;
      ((Container) this).add((Component) this.distance, (object) gridBagConstraints);
      gridBagConstraints.gridy = (__Null) 3;
      ((Container) this).add((Component) this.DPT, (object) gridBagConstraints);
      gridBagConstraints.gridy = (__Null) 4;
      ((Container) this).add((Component) this.zero, (object) gridBagConstraints);
      gridBagConstraints.gridx = (__Null) 0;
      gridBagConstraints.weightx = (__Null) 0.0;
      ((Container) this).add((Component) new JLabel("Reversed"), (object) gridBagConstraints);
      gridBagConstraints.gridx = (__Null) 1;
      gridBagConstraints.weightx = (__Null) 10000.0;
      ((JComponent) this.reversed).setAlignmentX(0.0f);
      ((Container) this).add((Component) this.reversed, (object) gridBagConstraints);
    }

    public override void propertyChanged(Property property)
    {
    }
  }
}
