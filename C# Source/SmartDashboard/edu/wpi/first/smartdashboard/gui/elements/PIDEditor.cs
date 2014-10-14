// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.PIDEditor
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui.elements.bindings;
using edu.wpi.first.smartdashboard.livewindow.elements;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.types;
using edu.wpi.first.smartdashboard.types.named;
using IKVM.Attributes;
using java.awt;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [Serializable]
  public class PIDEditor : AbstractTableWidget
  {
    internal static DataType[] __\u003C\u003ETYPES;
    private AbstractTableWidget.NumberTableField pField;
    private AbstractTableWidget.NumberTableField iField;
    private AbstractTableWidget.NumberTableField dField;
    private AbstractTableWidget.NumberTableField fField;
    private AbstractTableWidget.NumberTableField sField;
    private AbstractTableWidget.BooleanTableCheckBox eBox;
    private JLabel pLabel;
    private JLabel iLabel;
    private JLabel dLabel;
    private JLabel fLabel;
    private JLabel sLabel;
    private JLabel eLabel;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return PIDEditor.__\u003C\u003ETYPES;
      }
    }

    [LineNumberTable((ushort) 19)]
    static PIDEditor()
    {
      AbstractTableWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[1];
      int index = 0;
      NamedDataType namedDataType = PIDType.get();
      dataTypeArray[index] = (DataType) namedDataType;
      PIDEditor.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 176, (byte) 104, (byte) 139, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 112, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 140, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 113, (byte) 145, (byte) 99, (byte) 108, (byte) 108, (byte) 108, (byte) 108, (byte) 172, (byte) 166, (byte) 103, (byte) 109, (byte) 103, (byte) 109, (byte) 103, (byte) 109, (byte) 103, (byte) 109, (byte) 103, (byte) 109, (byte) 103, (byte) 141, (byte) 103, (byte) 108, (byte) 103, (byte) 103, (byte) 124, (byte) 108, (byte) 103, (byte) 109, (byte) 103, (byte) 109, (byte) 103, (byte) 109, (byte) 103, (byte) 109, (byte) 103, (byte) 109, (byte) 103, (byte) 141, (byte) 159, (byte) 1, (byte) 102, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PIDEditor()
    {
      PIDEditor pidEditor1 = this;
      ((Container) this).setLayout((LayoutManager) new GridBagLayout());
      this.pLabel = new JLabel("P:");
      this.iLabel = new JLabel("I:");
      this.dLabel = new JLabel("D:");
      this.fLabel = new JLabel("F:");
      this.sLabel = new JLabel("Setpoint:");
      this.eLabel = new JLabel("Enabled:");
      this.pLabel.setHorizontalAlignment(4);
      this.iLabel.setHorizontalAlignment(4);
      this.dLabel.setHorizontalAlignment(4);
      this.fLabel.setHorizontalAlignment(4);
      this.sLabel.setHorizontalAlignment(4);
      this.eLabel.setHorizontalAlignment(4);
      this.pField = new AbstractTableWidget.NumberTableField((AbstractTableWidget) this, "p");
      this.iField = new AbstractTableWidget.NumberTableField((AbstractTableWidget) this, "i");
      this.dField = new AbstractTableWidget.NumberTableField((AbstractTableWidget) this, "d");
      this.fField = new AbstractTableWidget.NumberTableField((AbstractTableWidget) this, "f");
      this.sField = new AbstractTableWidget.NumberTableField((AbstractTableWidget) this, "setpoint");
      this.eBox = new AbstractTableWidget.BooleanTableCheckBox((AbstractTableWidget) this, "enabled");
      int num = 10;
      this.pField.setColumns(num);
      this.iField.setColumns(num);
      this.dField.setColumns(num);
      this.fField.setColumns(num);
      this.sField.setColumns(num);
      GridBagConstraints gridBagConstraints1 = new GridBagConstraints();
      gridBagConstraints1.gridy = (__Null) 1;
      ((Container) this).add((Component) this.pLabel, (object) gridBagConstraints1);
      gridBagConstraints1.gridy = (__Null) 2;
      ((Container) this).add((Component) this.iLabel, (object) gridBagConstraints1);
      gridBagConstraints1.gridy = (__Null) 3;
      ((Container) this).add((Component) this.dLabel, (object) gridBagConstraints1);
      gridBagConstraints1.gridy = (__Null) 4;
      ((Container) this).add((Component) this.fLabel, (object) gridBagConstraints1);
      gridBagConstraints1.gridy = (__Null) 5;
      ((Container) this).add((Component) this.sLabel, (object) gridBagConstraints1);
      gridBagConstraints1.gridy = (__Null) 6;
      ((Container) this).add((Component) this.eLabel, (object) gridBagConstraints1);
      gridBagConstraints1.gridx = (__Null) 1;
      gridBagConstraints1.weightx = (__Null) 1.0;
      gridBagConstraints1.gridy = (__Null) 0;
      gridBagConstraints1.fill = (__Null) 2;
      PIDEditor pidEditor2 = this;
      NameTag nameTag1 = new NameTag("");
      NameTag nameTag2 = nameTag1;
      this.nameTag = nameTag1;
      GridBagConstraints gridBagConstraints2 = gridBagConstraints1;
      ((Container) this).add((Component) nameTag2, (object) gridBagConstraints2);
      this.nameTag.setHorizontalAlignment(2);
      gridBagConstraints1.gridy = (__Null) 1;
      ((Container) this).add((Component) this.pField, (object) gridBagConstraints1);
      gridBagConstraints1.gridy = (__Null) 2;
      ((Container) this).add((Component) this.iField, (object) gridBagConstraints1);
      gridBagConstraints1.gridy = (__Null) 3;
      ((Container) this).add((Component) this.dField, (object) gridBagConstraints1);
      gridBagConstraints1.gridy = (__Null) 4;
      ((Container) this).add((Component) this.fField, (object) gridBagConstraints1);
      gridBagConstraints1.gridy = (__Null) 5;
      ((Container) this).add((Component) this.sField, (object) gridBagConstraints1);
      gridBagConstraints1.gridy = (__Null) 6;
      ((Container) this).add((Component) this.eBox, (object) gridBagConstraints1);
      Dimension.__\u003Cclinit\u003E();
      ((JComponent) this).setMaximumSize(new Dimension(int.MaxValue, (int) ((JComponent) this).getPreferredSize().height));
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected PIDEditor([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 58, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      this.nameTag.setText(this.getFieldName());
    }

    public override void propertyChanged(Property property)
    {
    }
  }
}
