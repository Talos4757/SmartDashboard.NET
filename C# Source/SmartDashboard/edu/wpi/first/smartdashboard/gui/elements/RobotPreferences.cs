// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.RobotPreferences
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.properties;
using edu.wpi.first.smartdashboard.robot;
using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.@event;
using java.lang;
using java.util;
using javax.swing;
using javax.swing.table;
using javax.swing.text;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [Implements(new string[] {"edu.wpi.first.wpilibj.tables.ITableListener"})]
  [Serializable]
  public class RobotPreferences : StaticWidget, ITableListener
  {
    public const string DELETED_VALUE = "\"";
    public const string NAME = "Robot Preferences";
    private JTable table;
    private RobotPreferences.PreferenceTableModel model;
    [Signature("Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
    private Map values;
    private JButton save;
    private JButton add;
    private JButton remove;

    [HideFromJava]
    static RobotPreferences()
    {
      StaticWidget.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 161, (byte) 232, (byte) 160, (byte) 204})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public RobotPreferences()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected RobotPreferences([In] SerializationInfo obj0, [In] StreamingContext obj1)
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
    internal static JButton access\u0024000([In] RobotPreferences obj0)
    {
      return obj0.remove;
    }

    [Modifiers]
    [LineNumberTable((ushort) 19)]
    internal static RobotPreferences.PreferenceTableModel access\u0024100([In] RobotPreferences obj0)
    {
      return obj0.model;
    }

    [Modifiers]
    [LineNumberTable((ushort) 19)]
    internal static JTable access\u0024200([In] RobotPreferences obj0)
    {
      return obj0.table;
    }

    [Modifiers]
    [LineNumberTable((ushort) 19)]
    internal static Map access\u0024400([In] RobotPreferences obj0)
    {
      return obj0.values;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 174, (byte) 112, (byte) 241, (byte) 75, (byte) 112, (byte) 241, (byte) 77, (byte) 112, (byte) 241, (byte) 71, (byte) 139, (byte) 140, (byte) 141, (byte) 118, (byte) 108, (byte) 177, (byte) 102, (byte) 109, (byte) 109, (byte) 141, (byte) 102, (byte) 107, (byte) 108, (byte) 145, (byte) 107, (byte) 117, (byte) 108, (byte) 140, (byte) 119})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      this.add = new JButton("Add");
      ((AbstractButton) this.add).addActionListener((ActionListener) new RobotPreferences\u00241(this));
      this.remove = new JButton("Remove");
      ((AbstractButton) this.remove).addActionListener((ActionListener) new RobotPreferences\u00242(this));
      this.save = new JButton("Save");
      ((AbstractButton) this.save).addActionListener((ActionListener) new RobotPreferences\u00243(this));
      this.values = (Map) new LinkedHashMap();
      Robot.getPreferences().addTableListener((ITableListener) this, true);
      this.model = new RobotPreferences.PreferenceTableModel(this, (RobotPreferences\u00241) null);
      JTable.__\u003Cclinit\u003E();
      this.table = new JTable((TableModel) this.model);
      this.table.setSelectionMode(0);
      this.table.getTableHeader().setReorderingAllowed(false);
      JPanel jpanel1 = new JPanel();
      ((Container) jpanel1).setLayout((LayoutManager) new GridLayout(0, 2));
      ((Container) jpanel1).add((Component) this.add);
      ((Container) jpanel1).add((Component) this.remove);
      JPanel jpanel2 = new JPanel();
      ((Container) jpanel2).setLayout((LayoutManager) new BorderLayout());
      ((Container) jpanel2).add((Component) jpanel1, (object) "North");
      ((Container) jpanel2).add((Component) this.save, (object) "South");
      ((Container) this).setLayout((LayoutManager) new BorderLayout());
      JScrollPane.__\u003Cclinit\u003E();
      ((Container) this).add((Component) new JScrollPane((Component) this.table, 20, 31), (object) "Center");
      ((Container) this).add((Component) jpanel2, (object) "South");
      ((JComponent) this).setPreferredSize(new Dimension(300, 200));
    }

    [LineNumberTable(new byte[] {(byte) 47, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void disconnect()
    {
      Robot.getPreferences().removeTableListener((ITableListener) this);
    }

    public override void propertyChanged(Property property)
    {
    }

    [LineNumberTable(new byte[] {(byte) 56, (byte) 109, (byte) 158, (byte) 114, (byte) 143, (byte) 211, (byte) 104, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void valueChanged(ITable source, string key, object value, bool isNew)
    {
      if (String.instancehelper_equals(key, (object) "~S A V E~"))
        ((AbstractButton) this.save).setEnabled(!((Boolean) value).booleanValue());
      else if (String.instancehelper_equals("\"", (object) Object.instancehelper_toString(value)))
        this.values.remove((object) key);
      else
        this.values.put((object) key, (object) Object.instancehelper_toString(value));
      if (this.model == null)
        return;
      this.model.fireTableDataChanged();
    }

    [InnerClass]
    [SourceFile("RobotPreferences.java")]
    [Modifiers]
    [Serializable]
    internal sealed class NewPreferenceEntryDialog : JDialog
    {
      private JTextField keyField;
      private JTextField valueField;
      private JButton addButton;
      private JButton cancelButton;
      internal bool canceled;
      [Modifiers]
      internal RobotPreferences this\u00240;

      [HideFromJava]
      static NewPreferenceEntryDialog()
      {
        JDialog.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 117, (byte) 15, (byte) 167, (byte) 107, (byte) 103, (byte) 103, (byte) 153, (byte) 107, (byte) 134, (byte) 113, (byte) 103, (byte) 153, (byte) 103, (byte) 103, (byte) 113, (byte) 103, (byte) 153, (byte) 102, (byte) 109, (byte) 127, (byte) 0, (byte) 242, (byte) 77, (byte) 145, (byte) 127, (byte) 0, (byte) 242, (byte) 71, (byte) 103, (byte) 103, (byte) 103, (byte) 136, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public NewPreferenceEntryDialog([In] RobotPreferences obj0)
      {
        base.\u002Ector();
        RobotPreferences.NewPreferenceEntryDialog preferenceEntryDialog1 = this;
        this.canceled = true;
        ((Dialog) this).setTitle("New Preference Entry");
        ((Dialog) this).setModal(true);
        ((Dialog) this).setResizable(false);
        ((JComponent) this.getContentPane()).setBorder(BorderFactory.createEmptyBorder(7, 7, 7, 7));
        this.setLayout((LayoutManager) new GridBagLayout());
        GridBagConstraints gridBagConstraints1 = new GridBagConstraints();
        ((Container) this).add((Component) new JLabel("Key: "), (object) gridBagConstraints1);
        gridBagConstraints1.gridx = (__Null) 1;
        RobotPreferences.NewPreferenceEntryDialog preferenceEntryDialog2 = this;
        JTextField jtextField1 = new JTextField(10);
        JTextField jtextField2 = jtextField1;
        this.keyField = jtextField1;
        GridBagConstraints gridBagConstraints2 = gridBagConstraints1;
        ((Container) this).add((Component) jtextField2, (object) gridBagConstraints2);
        gridBagConstraints1.gridx = (__Null) 0;
        gridBagConstraints1.gridy = (__Null) 1;
        ((Container) this).add((Component) new JLabel("Value: "), (object) gridBagConstraints1);
        gridBagConstraints1.gridx = (__Null) 1;
        RobotPreferences.NewPreferenceEntryDialog preferenceEntryDialog3 = this;
        JTextField jtextField3 = new JTextField(10);
        JTextField jtextField4 = jtextField3;
        this.valueField = jtextField3;
        GridBagConstraints gridBagConstraints3 = gridBagConstraints1;
        ((Container) this).add((Component) jtextField4, (object) gridBagConstraints3);
        JPanel jpanel1 = new JPanel();
        ((Container) jpanel1).setLayout((LayoutManager) new GridLayout(0, 2));
        JPanel jpanel2 = jpanel1;
        RobotPreferences.NewPreferenceEntryDialog preferenceEntryDialog4 = this;
        JButton jbutton1 = new JButton("Add");
        JButton jbutton2 = jbutton1;
        this.addButton = jbutton1;
        GridBagConstraints gridBagConstraints4 = gridBagConstraints1;
        ((Container) jpanel2).add((Component) jbutton2, (object) gridBagConstraints4);
        ((AbstractButton) this.addButton).addActionListener((ActionListener) new RobotPreferences\u0024NewPreferenceEntryDialog\u00241(this, obj0));
        this.getRootPane().setDefaultButton(this.addButton);
        JPanel jpanel3 = jpanel1;
        RobotPreferences.NewPreferenceEntryDialog preferenceEntryDialog5 = this;
        JButton jbutton3 = new JButton("Cancel");
        JButton jbutton4 = jbutton3;
        this.cancelButton = jbutton3;
        GridBagConstraints gridBagConstraints5 = gridBagConstraints1;
        ((Container) jpanel3).add((Component) jbutton4, (object) gridBagConstraints5);
        ((AbstractButton) this.cancelButton).addActionListener((ActionListener) new RobotPreferences\u0024NewPreferenceEntryDialog\u00242(this, obj0));
        gridBagConstraints1.gridx = (__Null) 0;
        gridBagConstraints1.gridy = (__Null) 2;
        gridBagConstraints1.gridwidth = (__Null) 2;
        ((Container) this).add((Component) jpanel1, (object) gridBagConstraints1);
        ((Window) this).pack();
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected NewPreferenceEntryDialog([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 171, (byte) 127, (byte) 17, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void show([In] Point obj0)
      {
        ((Window) this).setLocation(ByteCodeHelper.d2i(obj0.getX() - (double) (((Component) this).getWidth() / 2)), ByteCodeHelper.d2i(obj0.getY() - (double) (((Component) this).getHeight() / 2)));
        ((Dialog) this).setVisible(true);
      }

      public virtual bool isCanceled()
      {
        return this.canceled;
      }

      [LineNumberTable((ushort) 294)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getKey()
      {
        return ((JTextComponent) this.keyField).getText();
      }

      [LineNumberTable((ushort) 298)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual string getValue()
      {
        return ((JTextComponent) this.valueField).getText();
      }
    }

    [InnerClass]
    [SourceFile("RobotPreferences.java")]
    [Modifiers]
    [Serializable]
    internal sealed class PreferenceTableModel : AbstractTableModel
    {
      [Modifiers]
      internal RobotPreferences this\u00240;

      [Modifiers]
      [LineNumberTable((ushort) 122)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal PreferenceTableModel([In] RobotPreferences obj0, [In] RobotPreferences\u00241 obj1)
        : this(obj0)
      {
      }

      [LineNumberTable((ushort) 122)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private PreferenceTableModel([In] RobotPreferences obj0)
      {
        base.\u002Ector();
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected PreferenceTableModel([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [LineNumberTable(new byte[] {(byte) 104, (byte) 114, (byte) 108, (byte) 130})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool put([In] string obj0, [In] string obj1)
      {
        if (!this.validateKey(obj0) || !this.validateValue(obj1))
          return false;
        Robot.getPreferences().putString(obj0, obj1);
        return true;
      }

      [Signature("(I)Ljava/util/Map$Entry<Ljava/lang/String;Ljava/lang/String;>;")]
      [LineNumberTable(new byte[] {(byte) 94, (byte) 98, (byte) 127, (byte) 11, (byte) 104, (byte) 164})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual Map.Entry getRow([In] int obj0)
      {
        int num1 = 0;
        Iterator iterator = RobotPreferences.access\u0024400(this.this\u00240).entrySet().iterator();
        while (iterator.hasNext())
        {
          Map.Entry entry = (Map.Entry) iterator.next();
          int num2 = num1;
          ++num1;
          int num3 = obj0;
          if (num2 == num3)
            return entry;
        }
        return (Map.Entry) null;
      }

      [LineNumberTable(new byte[] {(byte) 112, (byte) 114})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void delete([In] string obj0)
      {
        Robot.getPreferences().putString(obj0, "\"");
      }

      [LineNumberTable(new byte[] {(byte) 116, (byte) 104, (byte) 118, (byte) 130, (byte) 127, (byte) 120, (byte) 118, (byte) 130})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool validateKey([In] string obj0)
      {
        if (String.instancehelper_isEmpty(obj0))
        {
          JOptionPane.showMessageDialog((Component) this.this\u00240, (object) "The key cannot be empty", "Bad Key", 0);
          return false;
        }
        else
        {
          string str1 = obj0;
          object obj1 = (object) " ";
          CharSequence charSequence1;
          charSequence1.__\u003Cref\u003E = (__Null) obj1;
          CharSequence charSequence2 = charSequence1;
          if (!String.instancehelper_contains(str1, charSequence2))
          {
            string str2 = obj0;
            object obj2 = (object) "=";
            charSequence1.__\u003Cref\u003E = (__Null) obj2;
            CharSequence charSequence3 = charSequence1;
            if (!String.instancehelper_contains(str2, charSequence3))
            {
              string str3 = obj0;
              object obj3 = (object) "\t";
              charSequence1.__\u003Cref\u003E = (__Null) obj3;
              CharSequence charSequence4 = charSequence1;
              if (!String.instancehelper_contains(str3, charSequence4))
              {
                string str4 = obj0;
                object obj4 = (object) "\r";
                charSequence1.__\u003Cref\u003E = (__Null) obj4;
                CharSequence charSequence5 = charSequence1;
                if (!String.instancehelper_contains(str4, charSequence5))
                {
                  string str5 = obj0;
                  object obj5 = (object) "\n";
                  charSequence1.__\u003Cref\u003E = (__Null) obj5;
                  CharSequence charSequence6 = charSequence1;
                  if (!String.instancehelper_contains(str5, charSequence6))
                    return true;
                }
              }
            }
          }
          JOptionPane.showMessageDialog((Component) this.this\u00240, (object) "The key cannot containt ' ', '=', tabs or newlines", "Bad Key", 0);
          return false;
        }
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 64, (byte) 125, (byte) 118, (byte) 130})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual bool validateValue([In] string obj0)
      {
        string str = obj0;
        object obj = (object) "\"";
        CharSequence charSequence1;
        charSequence1.__\u003Cref\u003E = (__Null) obj;
        CharSequence charSequence2 = charSequence1;
        if (!String.instancehelper_contains(str, charSequence2))
          return true;
        JOptionPane.showMessageDialog((Component) this.this\u00240, (object) "The value cannot contain '\"'", "Bad Value", 0);
        return false;
      }

      [LineNumberTable((ushort) 125)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int getRowCount()
      {
        return RobotPreferences.access\u0024400(this.this\u00240).size();
      }

      public virtual int getColumnCount()
      {
        return 2;
      }

      public virtual string getColumnName([In] int obj0)
      {
        if (obj0 == 0)
          return "Key";
        return obj0 == 1 ? "Value" : "ERROR";
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 73, (byte) 102, (byte) 104, (byte) 102, (byte) 108, (byte) 108, (byte) 110, (byte) 120, (byte) 111, (byte) 137, (byte) 223, (byte) 22, (byte) 98, (byte) 104, (byte) 99, (byte) 184})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setValueAt([In] object obj0, [In] int obj1, [In] int obj2)
      {
        if (obj2 == 0)
        {
          Map.Entry row = this.getRow(obj1);
          if (row == null)
            return;
          string str1 = (string) row.getKey();
          string str2 = (string) row.getValue();
          if (String.instancehelper_equals(str1, (object) Object.instancehelper_toString(obj0)))
            return;
          if (!RobotPreferences.access\u0024400(this.this\u00240).containsKey((object) Object.instancehelper_toString(obj0)))
          {
            if (!this.put(Object.instancehelper_toString(obj0), str2))
              return;
            this.delete(str1);
          }
          else
            JOptionPane.showMessageDialog((Component) this.this\u00240, (object) new StringBuilder().append("An entry with the key ").append(obj0).append(" already exists").toString(), "Duplicate Key", 0);
        }
        else
        {
          Map.Entry row = this.getRow(obj1);
          if (row == null)
            return;
          this.put((string) row.getKey(), Object.instancehelper_toString(obj0));
        }
      }

      public virtual bool isCellEditable([In] int obj0, [In] int obj1)
      {
        return obj0 >= 0;
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 101, (byte) 104, (byte) 99, (byte) 156})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual object getValueAt([In] int obj0, [In] int obj1)
      {
        Map.Entry row = this.getRow(obj0);
        if (row == null)
          return (object) "ERROR";
        if (obj1 == 0)
          return (object) (string) row.getKey();
        else
          return (object) (string) row.getValue();
      }
    }
  }
}
