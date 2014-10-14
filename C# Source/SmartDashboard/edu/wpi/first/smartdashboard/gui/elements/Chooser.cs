// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.Chooser
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui.elements.bindings;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.types;
using edu.wpi.first.smartdashboard.types.named;
using edu.wpi.first.wpilibj.networktables2.type;
using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.tables.ITableListener"})]
  [Serializable]
  public class Chooser : AbstractTableWidget, ITableListener
  {
    private const string DEFAULT = "default";
    private const string SELECTED = "selected";
    private const string OPTIONS = "options";
    internal static DataType[] __\u003C\u003ETYPES;
    internal BooleanProperty __\u003C\u003Eeditable;
    internal BooleanProperty __\u003C\u003EuseRadioButtons;
    private Chooser.Display display;
    private string selection;
    private StringArray choices;

    [Modifiers]
    public static DataType[] TYPES
    {
      [HideFromJava] get
      {
        return Chooser.__\u003C\u003ETYPES;
      }
    }

    [Modifiers]
    public BooleanProperty editable
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Eeditable;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Eeditable = value;
      }
    }

    [Modifiers]
    public BooleanProperty useRadioButtons
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EuseRadioButtons;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EuseRadioButtons = value;
      }
    }

    [LineNumberTable((ushort) 24)]
    static Chooser()
    {
      AbstractTableWidget.__\u003Cclinit\u003E();
      DataType[] dataTypeArray = new DataType[1];
      int index = 0;
      NamedDataType namedDataType = StringChooserType.get();
      dataTypeArray[index] = (DataType) namedDataType;
      Chooser.__\u003C\u003ETYPES = dataTypeArray;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 160, (byte) 232, (byte) 74, (byte) 114, (byte) 178, (byte) 235, (byte) 160, (byte) 183})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Chooser()
    {
      Chooser chooser = this;
      this.__\u003C\u003Eeditable = new BooleanProperty((PropertyHolder) this, "Editable", true);
      this.__\u003C\u003EuseRadioButtons = new BooleanProperty((PropertyHolder) this, "Use Radio Buttons", true);
      this.choices = new StringArray();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Chooser([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 28, (byte) 113, (byte) 127, (byte) 14, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void changeChoices()
    {
      ((Container) this).remove(this.display.getComponent());
      this.display = !((Boolean) this.__\u003C\u003EuseRadioButtons.getValue()).booleanValue() ? (Chooser.Display) new Chooser.ComboBox(this, (Chooser.\u0031) null) : (Chooser.Display) new Chooser.RadioButtons(this, (Chooser.\u0031) null);
      this.display.setChoices(this.choices);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 179, (byte) 135, (byte) 135, (byte) 127, (byte) 14, (byte) 115})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      this.setResizable(false);
      this.selection = (string) null;
      this.display = !((Boolean) this.__\u003C\u003EuseRadioButtons.getValue()).booleanValue() ? (Chooser.Display) new Chooser.ComboBox(this, (Chooser.\u0031) null) : (Chooser.Display) new Chooser.RadioButtons(this, (Chooser.\u0031) null);
      this.display.setChoices(this.choices);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 190, (byte) 141, (byte) 118, (byte) 209, (byte) 141, (byte) 152})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void valueChanged(ITable source, string key, object value, bool isNew)
    {
      if (String.instancehelper_equals(key, (object) "options"))
      {
        this.table.retrieveValue("options", (object) this.choices);
        this.display.setChoices(this.choices);
      }
      if (!String.instancehelper_equals(key, (object) "selected"))
        return;
      this.display.setSelected(source.getString("selected"));
    }

    [LineNumberTable(new byte[] {(byte) 14, (byte) 137, (byte) 168, (byte) 137, (byte) 191, (byte) 3})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void propertyChanged(Property property)
    {
      if (property == this.__\u003C\u003EuseRadioButtons)
      {
        this.changeChoices();
      }
      else
      {
        if (property != this.__\u003C\u003Eeditable)
          return;
        this.display.setEditable(((Boolean) this.__\u003C\u003Eeditable.getValue()).booleanValue());
      }
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static string access\u0024200([In] Chooser obj0)
    {
      return obj0.selection;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static string access\u0024202([In] Chooser obj0, [In] string obj1)
    {
      Chooser chooser1 = obj0;
      string str1 = obj1;
      Chooser chooser2 = chooser1;
      string str2 = str1;
      chooser2.selection = str1;
      return str2;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u0024300([In] Chooser obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u0024400([In] Chooser obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u0024500([In] Chooser obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u0024600([In] Chooser obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u0024700([In] Chooser obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u0024800([In] Chooser obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u0024900([In] Chooser obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u00241000([In] Chooser obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u00241100([In] Chooser obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u00241200([In] Chooser obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u00241300([In] Chooser obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u00241400([In] Chooser obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u00241500([In] Chooser obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u00241600([In] Chooser obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u00241700([In] Chooser obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 18)]
    internal static ITable access\u00241800([In] Chooser obj0)
    {
      return obj0.table;
    }

    [InnerClass]
    [EnclosingMethod("edu.wpi.first.smartdashboard.gui.elements.Chooser", null, null)]
    [SourceFile("Chooser.java")]
    [Modifiers]
    internal sealed class \u0031 : Object
    {
      \u0031()
      {
        throw null;
      }
    }

    [InnerClass]
    [Implements(new string[] {"java.awt.event.ItemListener"})]
    [SourceFile("Chooser.java")]
    [Modifiers]
    internal sealed class ComboBox : Chooser.Display, ItemListener, EventListener
    {
      [Modifiers]
      internal new Chooser this\u00240 = obj0;
      internal JComboBox combo;

      [Modifiers]
      [LineNumberTable((ushort) 215)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal ComboBox([In] Chooser obj0, [In] Chooser.\u0031 obj1)
        : this(obj0)
      {
      }

      [LineNumberTable((ushort) 215)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private ComboBox([In] Chooser obj0)
        : base(obj0)
      {
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 87, (byte) 162, (byte) 136, (byte) 142})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal override void setEditable([In] bool obj0)
      {
        int num = obj0 ? 1 : 0;
        if (this.combo == null)
          return;
        this.combo.setEnabled(num != 0);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 118, (byte) 136, (byte) 113, (byte) 172, (byte) 139, (byte) 146, (byte) 130, (byte) 139, (byte) 104, (byte) 116, (byte) 236, (byte) 60, (byte) 230, (byte) 71, (byte) 131, (byte) 173, (byte) 151, (byte) 191, (byte) 2, (byte) 141, (byte) 118, (byte) 191, (byte) 3, (byte) 151, (byte) 191, (byte) 1, (byte) 143, (byte) 146, (byte) 140, (byte) 159, (byte) 6, (byte) 107, (byte) 139, (byte) 118})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal override void setChoices([In] StringArray obj0)
      {
        if (this.combo != null)
        {
          ((Container) this.panel).remove((Component) this.combo);
          this.combo.removeItemListener((ItemListener) this);
        }
        this.combo = new JComboBox();
        lock (Chooser.access\u00241200(this.this\u00240))
        {
          int local_1 = 0;
          for (int local_2 = 0; local_2 < obj0.size(); ++local_2)
          {
            string local_3 = obj0.get(local_2);
            local_1 |= String.instancehelper_equals(local_3, (object) Chooser.access\u0024200(this.this\u00240)) ? 1 : 0;
            this.combo.addItem((object) local_3);
          }
          if (local_1 == 0)
            Chooser.access\u0024202(this.this\u00240, (string) null);
          if (Chooser.access\u00241300(this.this\u00240).containsKey("selected"))
            Chooser.access\u0024202(this.this\u00240, Chooser.access\u00241400(this.this\u00240).getString("selected"));
          if (Chooser.access\u0024200(this.this\u00240) != null)
          {
            this.combo.setSelectedItem((object) Chooser.access\u0024200(this.this\u00240));
            Chooser.access\u00241500(this.this\u00240).putString("selected", Chooser.access\u0024200(this.this\u00240));
          }
          else if (Chooser.access\u00241600(this.this\u00240).containsKey("default"))
            this.combo.setSelectedItem((object) Chooser.access\u00241700(this.this\u00240).getString("default"));
        }
        ((Container) this.panel).add((Component) this.combo);
        this.combo.addItemListener((ItemListener) this);
        this.combo.setEnabled(((Boolean) this.this\u00240.__\u003C\u003Eeditable.getValue()).booleanValue());
        ((JComponent) this.this\u00240).revalidate();
        ((Component) this.this\u00240).repaint();
        ((Component) this.this\u00240).setSize(((JComponent) this.this\u00240).getPreferredSize());
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 175, (byte) 136, (byte) 142})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal override void setSelected([In] string obj0)
      {
        if (this.combo == null)
          return;
        this.combo.setSelectedItem((object) obj0);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 183, (byte) 137, (byte) 108, (byte) 147, (byte) 109, (byte) 191, (byte) 3})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void itemStateChanged([In] ItemEvent obj0)
      {
        if (obj0.getStateChange() != 1)
          return;
        string str = (string) obj0.getItem();
        if (String.instancehelper_equals(str, (object) Chooser.access\u0024200(this.this\u00240)))
          return;
        Chooser.access\u0024202(this.this\u00240, str);
        Chooser.access\u00241800(this.this\u00240).putString("selected", Chooser.access\u0024200(this.this\u00240));
      }
    }

    [InnerClass]
    [SourceFile("Chooser.java")]
    internal abstract class Display : Object
    {
      internal JPanel panel;
      [Modifiers]
      internal Chooser this\u00240;

      [LineNumberTable(new byte[] {(byte) 39, (byte) 239, (byte) 61, (byte) 203, (byte) 140, (byte) 109})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public Display([In] Chooser obj0)
      {
        base.\u002Ector();
        Chooser.Display display = this;
        this.panel = new JPanel();
        ((JComponent) this.panel).setOpaque(false);
        ((Container) obj0).add((Component) this.panel);
      }

      internal abstract void setChoices([In] StringArray obj0);

      internal abstract void setSelected([In] string obj0);

      internal abstract void setEditable([In] bool obj0);

      internal virtual Component getComponent()
      {
        return (Component) this.panel;
      }
    }

    [InnerClass]
    [Implements(new string[] {"java.awt.event.ActionListener"})]
    [SourceFile("Chooser.java")]
    [Modifiers]
    internal sealed class RadioButtons : Chooser.Display, ActionListener, EventListener
    {
      [Modifiers]
      internal new Chooser this\u00240 = obj0;
      internal JPanel groupPanel;
      internal ButtonGroup group;
      internal JRadioButton selected;
      [Signature("Ljava/util/Map<Ljava/lang/String;Ljavax/swing/JRadioButton;>;")]
      internal Map buttons;

      [Modifiers]
      [LineNumberTable((ushort) 107)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal RadioButtons([In] Chooser obj0, [In] Chooser.\u0031 obj1)
        : this(obj0)
      {
      }

      [LineNumberTable((ushort) 107)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private RadioButtons([In] Chooser obj0)
        : base(obj0)
      {
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 113, (byte) 130, (byte) 159, (byte) 6, (byte) 137})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal override void setEditable([In] bool obj0)
      {
        int num = obj0 ? 1 : 0;
        Iterator iterator = this.buttons.values().iterator();
        while (iterator.hasNext())
          ((AbstractButton) iterator.next()).setEnabled(num != 0);
      }

      [LineNumberTable(new byte[] {(byte) 77, (byte) 136, (byte) 113, (byte) 159, (byte) 6, (byte) 142, (byte) 171, (byte) 107, (byte) 108, (byte) 151, (byte) 139, (byte) 171, (byte) 130, (byte) 142, (byte) 105, (byte) 149, (byte) 105, (byte) 112, (byte) 109, (byte) 110, (byte) 105, (byte) 232, (byte) 54, (byte) 233, (byte) 77, (byte) 131, (byte) 173, (byte) 159, (byte) 5, (byte) 191, (byte) 2, (byte) 154, (byte) 127, (byte) 1, (byte) 127, (byte) 2, (byte) 174, (byte) 159, (byte) 5, (byte) 127, (byte) 12, (byte) 174, (byte) 199, (byte) 159, (byte) 6, (byte) 146, (byte) 107, (byte) 139, (byte) 120})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal override void setChoices([In] StringArray obj0)
      {
        if (this.groupPanel != null)
        {
          ((Container) this.panel).remove((Component) this.groupPanel);
          Iterator iterator = this.buttons.values().iterator();
          while (iterator.hasNext())
            this.group.remove((AbstractButton) iterator.next());
          this.buttons.clear();
        }
        this.groupPanel = new JPanel();
        ((JComponent) this.groupPanel).setOpaque(false);
        ((Container) this.groupPanel).setLayout((LayoutManager) new BoxLayout((Container) this.groupPanel, 1));
        this.group = new ButtonGroup();
        this.buttons = (Map) new HashMap();
        int num = 0;
        for (int i = 0; i < obj0.size(); ++i)
        {
          string str = obj0.get(i);
          num |= String.instancehelper_equals(str, (object) Chooser.access\u0024200(this.this\u00240)) ? 1 : 0;
          JRadioButton jradioButton = new JRadioButton(str);
          this.buttons.put((object) str, (object) jradioButton);
          this.group.add((AbstractButton) jradioButton);
          ((Container) this.groupPanel).add((Component) jradioButton);
          ((AbstractButton) jradioButton).setActionCommand(str);
          ((AbstractButton) jradioButton).addActionListener((ActionListener) this);
        }
        if (num == 0)
          Chooser.access\u0024202(this.this\u00240, (string) null);
        if (Chooser.access\u0024300(this.this\u00240) != null && Chooser.access\u0024400(this.this\u00240).containsKey("selected"))
          Chooser.access\u0024202(this.this\u00240, Chooser.access\u0024500(this.this\u00240).getString("selected"));
        if (Chooser.access\u0024600(this.this\u00240) != null && Chooser.access\u0024200(this.this\u00240) != null)
        {
          Chooser.access\u0024700(this.this\u00240).putString("selected", Chooser.access\u0024200(this.this\u00240));
          this.selected = (JRadioButton) this.buttons.get((object) Chooser.access\u0024200(this.this\u00240));
          ((AbstractButton) this.selected).setSelected(true);
        }
        else if (Chooser.access\u0024800(this.this\u00240) != null && Chooser.access\u0024900(this.this\u00240).containsKey("default"))
        {
          this.selected = (JRadioButton) this.buttons.get((object) Chooser.access\u00241000(this.this\u00240).getString("default"));
          ((AbstractButton) this.selected).setSelected(true);
        }
        else
          this.selected = (JRadioButton) null;
        ((JComponent) this.this\u00240).setEnabled(((Boolean) this.this\u00240.__\u003C\u003Eeditable.getValue()).booleanValue());
        ((Container) this.panel).add((Component) this.groupPanel);
        ((JComponent) this.this\u00240).revalidate();
        ((Component) this.this\u00240).repaint();
        ((Component) this.this\u00240).setSize(((JComponent) this.this\u00240).getPreferredSize());
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 87, (byte) 121})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal override void setSelected([In] string obj0)
      {
        ((AbstractButton) this.buttons.get((object) obj0)).setSelected(true);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 92, (byte) 103, (byte) 159, (byte) 1, (byte) 109, (byte) 159, (byte) 3})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void actionPerformed([In] ActionEvent obj0)
      {
        string actionCommand = obj0.getActionCommand();
        if (Chooser.access\u0024200(this.this\u00240) != null && String.instancehelper_equals(Chooser.access\u0024200(this.this\u00240), (object) actionCommand))
          return;
        Chooser.access\u0024202(this.this\u00240, actionCommand);
        Chooser.access\u00241100(this.this\u00240).putString("selected", Chooser.access\u0024200(this.this\u00240));
      }
    }
  }
}
