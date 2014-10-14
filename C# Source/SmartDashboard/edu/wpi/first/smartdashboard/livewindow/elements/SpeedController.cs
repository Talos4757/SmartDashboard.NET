// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.livewindow.elements.SpeedController
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
using javax.swing.text;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.livewindow.elements
{
  [Implements(new string[] {"edu.wpi.first.smartdashboard.livewindow.elements.Controller"})]
  [Serializable]
  public class SpeedController : AbstractTableWidget, Controller
  {
    internal static DataType[] __\u003C\u003ETYPES;
    private Widget.NumberSlider controller;
    [Modifiers]
    private JButton zeroButton;
    [Modifiers]
    private string defaultText;
    [Modifiers]
    private Widget.UneditableNumberField feedback;
    [Modifiers]
    private NumberBindable valueEntry;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return SpeedController.__\u003C\u003ETYPES;
      }
    }

    [LineNumberTable((ushort) 21)]
    static SpeedController()
    {
      AbstractTableWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[1];
      int index = 0;
      NamedDataType namedDataType = SpeedControllerType.get();
      dataTypeArray[index] = (DataType) namedDataType;
      SpeedController.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 232, (byte) 70, (byte) 144, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SpeedController()
    {
      SpeedController speedController = this;
      this.zeroButton = new JButton("Zero");
      this.defaultText = "0.0";
      this.feedback = new Widget.UneditableNumberField();
      this.valueEntry = (NumberBindable) this.getTableEntryBindable("Value");
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected SpeedController([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    [LineNumberTable((ushort) 19)]
    internal static JButton access\u0024000([In] SpeedController obj0)
    {
      return obj0.zeroButton;
    }

    [LineNumberTable(new byte[] {(byte) 36, (byte) 112, (byte) 114})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void reset()
    {
      this.controller.setBindableValue(0.0);
      this.valueEntry.setBindableValue(0.0);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 175, (byte) 150, (byte) 118, (byte) 116, (byte) 112, (byte) 112, (byte) 108, (byte) 109, (byte) 140, (byte) 112, (byte) 140, (byte) 159, (byte) 0, (byte) 241, (byte) 73, (byte) 108, (byte) 241, (byte) 70, (byte) 107, (byte) 102, (byte) 103, (byte) 103, (byte) 109, (byte) 103, (byte) 108, (byte) 109, (byte) 108, (byte) 103, (byte) 109, (byte) 103, (byte) 109, (byte) 135})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      NameTag.__\u003Cclinit\u003E();
      this.nameTag = new NameTag(this.getFieldName());
      Widget.NumberSlider.__\u003Cclinit\u003E();
      this.controller = new Widget.NumberSlider(this.valueEntry);
      this.controller.setMin(-1.0);
      this.controller.setMax(1.0);
      this.controller.setBindableValue(0.0);
      this.controller.setSnapToTicks(false);
      this.controller.setMajorTickSpacing(50);
      this.controller.setPaintTicks(true);
      this.feedback.setText("0.0");
      this.feedback.setColumns(4);
      string key = "Value";
      NumberBindable[] numberBindableArray = new NumberBindable[1];
      int index = 0;
      Widget.UneditableNumberField uneditableNumberField = this.feedback;
      numberBindableArray[index] = (NumberBindable) uneditableNumberField;
      Widget.NumberMultiBindable numberMultiBindable = new Widget.NumberMultiBindable(numberBindableArray);
      this.setNumberBinding(key, (NumberBindable) numberMultiBindable);
      ((Component) this.controller).addKeyListener((KeyListener) new SpeedController\u00241(this));
      ((JTextComponent) this.feedback).setEditable(false);
      ((AbstractButton) this.zeroButton).addActionListener((ActionListener) new SpeedController\u00242(this));
      ((Container) this).setLayout((LayoutManager) new GridBagLayout());
      GridBagConstraints gridBagConstraints = new GridBagConstraints();
      gridBagConstraints.fill = (__Null) 1;
      gridBagConstraints.gridx = (__Null) 0;
      ((Container) this).add((Component) this.nameTag, (object) gridBagConstraints);
      gridBagConstraints.gridy = (__Null) 1;
      gridBagConstraints.weightx = (__Null) 1.0;
      ((Container) this).add((Component) this.controller, (object) gridBagConstraints);
      gridBagConstraints.weightx = (__Null) 0.0;
      gridBagConstraints.gridx = (__Null) 2;
      ((Container) this).add((Component) this.feedback, (object) gridBagConstraints);
      gridBagConstraints.gridx = (__Null) 3;
      ((Container) this).add((Component) this.zeroButton, (object) gridBagConstraints);
      gridBagConstraints.gridx = (__Null) 4;
    }

    public override void propertyChanged(Property property)
    {
    }
  }
}
