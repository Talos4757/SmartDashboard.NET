// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.livewindow.elements.GyroDisplay
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.gui.elements;
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
  public class GyroDisplay : AbstractTableWidget
  {
    internal static DataType[] __\u003C\u003ETYPES;
    [Modifiers]
    private Compass compass;
    [Modifiers]
    private Widget.UneditableNumberField feedback;
    [Modifiers]
    private string[] names;
    [Modifiers]
    private JComboBox menu;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return GyroDisplay.__\u003C\u003ETYPES;
      }
    }

    [LineNumberTable((ushort) 26)]
    static GyroDisplay()
    {
      AbstractTableWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[2];
      int index1 = 0;
      NamedDataType namedDataType1 = LWGyroType.get();
      dataTypeArray[index1] = (DataType) namedDataType1;
      int index2 = 1;
      NamedDataType namedDataType2 = CompassType.get();
      dataTypeArray[index2] = (DataType) namedDataType2;
      GyroDisplay.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 166, (byte) 232, (byte) 70, (byte) 139, (byte) 139, (byte) 124})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public GyroDisplay()
    {
      GyroDisplay gyroDisplay = this;
      this.compass = new Compass();
      this.feedback = new Widget.UneditableNumberField();
      string[] strArray = new string[2];
      int index1 = 0;
      string str1 = "Display as Text";
      strArray[index1] = str1;
      int index2 = 1;
      string str2 = "Display as Compass";
      strArray[index2] = str2;
      this.names = strArray;
      JComboBox.__\u003Cclinit\u003E();
      this.menu = new JComboBox((object[]) this.names);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected GyroDisplay([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [Modifiers]
    [LineNumberTable((ushort) 24)]
    internal static string[] access\u0024000([In] GyroDisplay obj0)
    {
      return obj0.names;
    }

    [Modifiers]
    [LineNumberTable((ushort) 24)]
    internal static Widget.UneditableNumberField access\u0024100([In] GyroDisplay obj0)
    {
      return obj0.feedback;
    }

    [Modifiers]
    [LineNumberTable((ushort) 24)]
    internal static Compass access\u0024200([In] GyroDisplay obj0)
    {
      return obj0.compass;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 182, (byte) 107, (byte) 102, (byte) 135, (byte) 98, (byte) 150, (byte) 159, (byte) 9, (byte) 139, (byte) 243, (byte) 89, (byte) 103, (byte) 109, (byte) 103, (byte) 109, (byte) 103, (byte) 112, (byte) 143})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      ((Container) this).setLayout((LayoutManager) new GridBagLayout());
      GridBagConstraints gridBagConstraints = new GridBagConstraints();
      gridBagConstraints.fill = (__Null) 1;
      GyroDisplay gyroDisplay = this;
      NameTag.__\u003Cclinit\u003E();
      this.nameTag = new NameTag(this.getFieldName());
      string key = "Value";
      NumberBindable[] numberBindableArray = new NumberBindable[2];
      int index1 = 0;
      Widget.UneditableNumberField uneditableNumberField = this.feedback;
      numberBindableArray[index1] = (NumberBindable) uneditableNumberField;
      int index2 = 1;
      Compass compass = this.compass;
      numberBindableArray[index2] = (NumberBindable) compass;
      Widget.NumberMultiBindable numberMultiBindable = new Widget.NumberMultiBindable(numberBindableArray);
      this.setNumberBinding(key, (NumberBindable) numberMultiBindable);
      this.compass.init();
      this.menu.addActionListener((ActionListener) new GyroDisplay\u00241(this, gyroDisplay, gridBagConstraints));
      gridBagConstraints.gridx = (__Null) 0;
      ((Container) this).add((Component) this.nameTag, (object) gridBagConstraints);
      gridBagConstraints.gridy = (__Null) 1;
      ((Container) this).add((Component) this.menu, (object) gridBagConstraints);
      gridBagConstraints.gridy = (__Null) 2;
      gridBagConstraints.weightx = (__Null) 2.0;
      ((Container) this).add((Component) this.feedback, (object) gridBagConstraints);
    }

    public override void propertyChanged(Property property)
    {
    }
  }
}
