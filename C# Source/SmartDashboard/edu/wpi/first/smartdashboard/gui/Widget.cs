// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.Widget
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui.elements.bindings;
using edu.wpi.first.smartdashboard.types;
using edu.wpi.first.wpilibj.tables;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.@event;
using java.lang;
using java.text;
using java.util;
using javax.swing;
using javax.swing.@event;
using javax.swing.border;
using javax.swing.text;
using org.jfree.data.general;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui
{
  [Serializable]
  public abstract class Widget : DisplayElement
  {
    private string name;
    private DataType type;

    [HideFromJava]
    static Widget()
    {
      DisplayElement.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 165, (byte) 232, (byte) 162, (byte) 41})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Widget()
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Widget([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal new static void __\u003Cclinit\u003E()
    {
    }

    public virtual string getFieldName()
    {
      return this.name;
    }

    public virtual DataType getType()
    {
      return this.type;
    }

    public virtual void setFieldName(string name)
    {
      this.name = name;
    }

    public virtual void setType(DataType type)
    {
      this.type = type;
    }

    public abstract void setValue(object obj);

    [LineNumberTable((ushort) 47)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool supportsType(DataType type)
    {
      return (DisplayElementRegistry.supportsType(Object.instancehelper_getClass((object) this), type) ? 1 : 0) != 0;
    }

    [InnerClass]
    [SourceFile("Widget.java")]
    [Serializable]
    public class BindableBooleanCheckBox : Widget.BooleanCheckBox
    {
      [Modifiers]
      private BooleanBindable bindable;

      [HideFromJava]
      static BindableBooleanCheckBox()
      {
        Widget.BooleanCheckBox.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 91, (byte) 104, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public BindableBooleanCheckBox(BooleanBindable bindable)
      {
        Widget.BindableBooleanCheckBox bindableBooleanCheckBox = this;
        this.bindable = bindable;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected BindableBooleanCheckBox([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 26, (byte) 162, (byte) 108})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal override bool setValue(bool value)
      {
        this.bindable.setBindableValue(value);
        return true;
      }
    }

    [InnerClass]
    [SourceFile("Widget.java")]
    [Serializable]
    public class BindableBooleanField : Widget.BooleanField
    {
      [Modifiers]
      private BooleanBindable bindable;

      [HideFromJava]
      static BindableBooleanField()
      {
        Widget.BooleanField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 106, (byte) 104, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public BindableBooleanField(BooleanBindable bindable)
      {
        Widget.BindableBooleanField bindableBooleanField = this;
        this.bindable = bindable;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected BindableBooleanField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 22, (byte) 130, (byte) 108})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal override bool setValue(bool value)
      {
        this.bindable.setBindableValue(value);
        return true;
      }
    }

    [InnerClass]
    [SourceFile("Widget.java")]
    [Serializable]
    public class BindableNumberField : Widget.NumberField
    {
      [Modifiers]
      private NumberBindable bindable;

      [HideFromJava]
      static BindableNumberField()
      {
        Widget.NumberField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 122, (byte) 104, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public BindableNumberField(NumberBindable bindable)
      {
        Widget.BindableNumberField bindableNumberField = this;
        this.bindable = bindable;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected BindableNumberField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 128, (byte) 109})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal override bool setValue(double value)
      {
        this.bindable.setBindableValue(value);
        return true;
      }
    }

    [InnerClass]
    [SourceFile("Widget.java")]
    [Serializable]
    public class BindableStringField : Widget.StringField
    {
      [Modifiers]
      private StringBindable bindable;

      [HideFromJava]
      static BindableStringField()
      {
        Widget.StringField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 137, (byte) 104, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public BindableStringField(StringBindable bindable)
      {
        Widget.BindableStringField bindableStringField = this;
        this.bindable = bindable;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected BindableStringField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 143, (byte) 108})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal override bool setValue(string value)
      {
        this.bindable.setBindableValue(value);
        return true;
      }
    }

    [InnerClass]
    [Implements(new string[] {"edu.wpi.first.smartdashboard.gui.elements.bindings.BooleanBindable", "edu.wpi.first.smartdashboard.gui.elements.bindings.NumberBindable", "edu.wpi.first.smartdashboard.gui.elements.bindings.StringBindable"})]
    [SourceFile("Widget.java")]
    public class BindableTableEntry : Object, BooleanBindable, NumberBindable, StringBindable
    {
      [Modifiers]
      private ITable table;
      [Modifiers]
      private string key;

      [LineNumberTable(new byte[] {(byte) 161, (byte) 153, (byte) 104, (byte) 103, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public BindableTableEntry(ITable table, string key)
      {
        base.\u002Ector();
        Widget.BindableTableEntry bindableTableEntry = this;
        this.table = table;
        this.key = key;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 160, (byte) 116})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBindableValue(string value)
      {
        this.table.putString(this.key, value);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 165, (byte) 117})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBindableValue(double value)
      {
        this.table.putNumber(this.key, value);
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 7, (byte) 66, (byte) 116})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBindableValue(bool value)
      {
        this.table.putBoolean(this.key, value);
      }
    }

    [InnerClass]
    [Implements(new string[] {"edu.wpi.first.smartdashboard.gui.elements.bindings.BooleanBindable"})]
    [SourceFile("Widget.java")]
    [Serializable]
    public abstract class BooleanCheckBox : Widget.ThreadSafeCheckBox, BooleanBindable
    {
      private bool value;

      [HideFromJava]
      static BooleanCheckBox()
      {
        Widget.ThreadSafeCheckBox.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 148, (byte) 104, (byte) 108, (byte) 238, (byte) 76})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public BooleanCheckBox()
      {
        Widget.BooleanCheckBox booleanCheckBox = this;
        this.value = ((AbstractButton) this).isSelected();
        ((AbstractButton) this).addActionListener((ActionListener) new Widget\u0024BooleanCheckBox\u00241(this));
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected BooleanCheckBox([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal new static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 71, (byte) 66, (byte) 103, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBindableValue(bool value)
      {
        int num = value ? 1 : 0;
        this.value = num != 0;
        ((AbstractButton) this).setSelected(num != 0);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 165, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal virtual void resetValue()
      {
        this.setBindableValue(this.value);
      }

      protected internal abstract bool setValue(bool b);

      [Modifiers]
      [LineNumberTable((ushort) 258)]
      internal static bool access\u0024200([In] Widget.BooleanCheckBox obj0)
      {
        return obj0.value;
      }

      [Modifiers]
      [LineNumberTable((ushort) 258)]
      internal static bool access\u0024202([In] Widget.BooleanCheckBox obj0, [In] bool obj1)
      {
        int num1 = obj1 ? 1 : 0;
        Widget.BooleanCheckBox booleanCheckBox1 = obj0;
        int num2 = num1;
        Widget.BooleanCheckBox booleanCheckBox2 = booleanCheckBox1;
        int num3 = num2;
        booleanCheckBox2.value = num2 != 0;
        return num3 != 0;
      }
    }

    [InnerClass]
    [Implements(new string[] {"edu.wpi.first.smartdashboard.gui.elements.bindings.BooleanBindable"})]
    [SourceFile("Widget.java")]
    [Serializable]
    public abstract class BooleanField : Widget.EditorTextField, BooleanBindable
    {
      private bool value;

      [HideFromJava]
      static BooleanField()
      {
        Widget.EditorTextField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 177, (byte) 136})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public BooleanField()
      {
        Widget.BooleanField booleanField = this;
        this.value = false;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected BooleanField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal new static void __\u003Cclinit\u003E()
      {
      }

      protected internal abstract bool setValue(bool b);

      [LineNumberTable(new byte[] {(byte) 159, (byte) 63, (byte) 66, (byte) 103, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBindableValue(bool value)
      {
        int num = value ? 1 : 0;
        this.value = num != 0;
        this.setText(Boolean.toString(num != 0));
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 197, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal virtual void resetValue()
      {
        this.setBindableValue(this.value);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 182, (byte) 115, (byte) 103, (byte) 105, (byte) 105, (byte) 137, (byte) 168, (byte) 168})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal override void textChanged(string text)
      {
        if (String.instancehelper_equals(Boolean.toString(this.value), (object) text))
          return;
        int num = Boolean.parseBoolean(text) ? 1 : 0;
        if ((this.value ? 1 : 0) != num)
        {
          if (this.setValue(num != 0))
            this.setBindableValue(num != 0);
          else
            this.resetValue();
        }
        else
          this.resetValue();
      }
    }

    [InnerClass]
    [Implements(new string[] {"edu.wpi.first.smartdashboard.gui.elements.bindings.BooleanBindable"})]
    [SourceFile("Widget.java")]
    public class BooleanMultiBindable : Object, BooleanBindable
    {
      [Modifiers]
      private BooleanBindable[] bindables;

      [LineNumberTable(new byte[] {(byte) 161, (byte) 178, (byte) 104, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public BooleanMultiBindable(params BooleanBindable[] bindables)
      {
        base.\u002Ector();
        Widget.BooleanMultiBindable booleanMultiBindable = this;
        this.bindables = bindables;
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 4, (byte) 130, (byte) 117, (byte) 40, (byte) 166})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBindableValue(bool value)
      {
        int num = value ? 1 : 0;
        BooleanBindable[] booleanBindableArray = this.bindables;
        int length = booleanBindableArray.Length;
        for (int index = 0; index < length; ++index)
          booleanBindableArray[index].setBindableValue(num != 0);
      }
    }

    [InnerClass]
    [SourceFile("Widget.java")]
    [Serializable]
    public abstract class EditorTextField : Widget.ThreadSafeTextField
    {
      [HideFromJava]
      static EditorTextField()
      {
        Widget.ThreadSafeTextField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 115, (byte) 104, (byte) 236, (byte) 69, (byte) 236, (byte) 70, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public EditorTextField()
      {
        Widget.EditorTextField editorTextField = this;
        this.addActionListener((ActionListener) new Widget\u0024EditorTextField\u00241(this));
        ((Component) this).addFocusListener((FocusListener) new Widget\u0024EditorTextField\u00242(this));
        this.setHorizontalAlignment(2);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected EditorTextField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal new static void __\u003Cclinit\u003E()
      {
      }

      protected internal abstract void textChanged(string str);
    }

    [InnerClass]
    [Implements(new string[] {"edu.wpi.first.smartdashboard.gui.elements.bindings.BooleanBindable", "edu.wpi.first.smartdashboard.gui.elements.bindings.NumberBindable", "edu.wpi.first.smartdashboard.gui.elements.bindings.StringBindable"})]
    [SourceFile("Widget.java")]
    public interface MultiTypeBindable : BooleanBindable, NumberBindable, StringBindable
    {
    }

    [InnerClass]
    [Implements(new string[] {"edu.wpi.first.smartdashboard.gui.elements.bindings.NumberBindable"})]
    [SourceFile("Widget.java")]
    [Serializable]
    public class NumberDatasetDisplayer : DefaultValueDataset, NumberBindable
    {
      [LineNumberTable(new byte[] {(byte) 160, (byte) 85, (byte) 106})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public NumberDatasetDisplayer(double defaultValue)
        : base(defaultValue)
      {
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected NumberDatasetDisplayer([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 90, (byte) 111})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBindableValue(double value)
      {
        this.setValue((Number) Double.valueOf(value));
      }
    }

    [InnerClass]
    [Implements(new string[] {"edu.wpi.first.smartdashboard.gui.elements.bindings.NumberBindable"})]
    [SourceFile("Widget.java")]
    [Serializable]
    public abstract class NumberField : Widget.EditorTextField, NumberBindable
    {
      private double value;
      private DecimalFormat formatter;

      [HideFromJava]
      static NumberField()
      {
        Widget.EditorTextField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 209, (byte) 136, (byte) 112})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public NumberField()
      {
        Widget.NumberField numberField = this;
        this.value = double.NaN;
        DecimalFormat.__\u003Cclinit\u003E();
        string str = "0.000";
        DecimalFormatSymbols.__\u003Cclinit\u003E();
        DecimalFormatSymbols decimalFormatSymbols = new DecimalFormatSymbols((Locale) Locale.US);
        this.formatter = new DecimalFormat(str, decimalFormatSymbols);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected NumberField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal new static void __\u003Cclinit\u003E()
      {
      }

      protected internal abstract bool setValue(double d);

      [LineNumberTable(new byte[] {(byte) 160, (byte) 230, (byte) 109, (byte) 141, (byte) 142})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal virtual void resetValue()
      {
        if (Double.isNaN(this.value))
          this.setText("");
        else
          this.setBindableValue(this.value);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 239, (byte) 105, (byte) 117})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBindableValue(double value)
      {
        this.value = value;
        this.setText(((NumberFormat) this.formatter).format(value));
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 216, (byte) 104, (byte) 105, (byte) 105, (byte) 138, (byte) 241, (byte) 69, (byte) 2, (byte) 97, (byte) 134})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal override void textChanged(string text)
      {
        try
        {
          double d = Double.parseDouble(text);
          if (this.value == d)
            return;
          if (this.setValue(d))
          {
            this.value = d;
            return;
          }
          else
          {
            this.resetValue();
            return;
          }
        }
        catch (NumberFormatException ex)
        {
        }
        this.resetValue();
      }

      public virtual void setFormatter(DecimalFormat formatter)
      {
        this.formatter = formatter;
      }
    }

    [InnerClass]
    [Implements(new string[] {"edu.wpi.first.smartdashboard.gui.elements.bindings.NumberBindable"})]
    [SourceFile("Widget.java")]
    public class NumberMultiBindable : Object, NumberBindable
    {
      [Modifiers]
      private NumberBindable[] bindables;

      [LineNumberTable(new byte[] {(byte) 161, (byte) 194, (byte) 104, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public NumberMultiBindable(params NumberBindable[] bindables)
      {
        base.\u002Ector();
        Widget.NumberMultiBindable numberMultiBindable = this;
        this.bindables = bindables;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 200, (byte) 116, (byte) 40, (byte) 166})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBindableValue(double value)
      {
        NumberBindable[] numberBindableArray = this.bindables;
        int length = numberBindableArray.Length;
        for (int index = 0; index < length; ++index)
          numberBindableArray[index].setBindableValue(value);
      }
    }

    [InnerClass]
    [Implements(new string[] {"edu.wpi.first.smartdashboard.gui.elements.bindings.NumberBindable", "java.awt.event.ComponentListener"})]
    [SourceFile("Widget.java")]
    [Serializable]
    public class NumberProgressBar : JProgressBar, NumberBindable, ComponentListener, EventListener
    {
      private double min;
      private double max;
      private double value;
      private int pixelWidth;

      [HideFromJava]
      static NumberProgressBar()
      {
        JProgressBar.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 87, (byte) 232, (byte) 59, (byte) 108, (byte) 112, (byte) 108, (byte) 167, (byte) 103, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public NumberProgressBar()
      {
        base.\u002Ector();
        Widget.NumberProgressBar numberProgressBar = this;
        this.min = 0.0;
        this.max = 100.0;
        this.value = 0.0;
        this.pixelWidth = 0;
        ((Component) this).addComponentListener((ComponentListener) this);
        this.calcBounds();
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected NumberProgressBar([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable(new byte[] {(byte) 122, (byte) 108, (byte) 103, (byte) 108, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private void calcBounds()
      {
        this.pixelWidth = ((JComponent) this).getWidth();
        this.setMinimum(0);
        this.setMaximum(this.pixelWidth);
        this.setUnscaledValue(this.value);
      }

      [LineNumberTable(new byte[] {(byte) 101, (byte) 106, (byte) 136, (byte) 106, (byte) 136, (byte) 121, (byte) 118})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private void setUnscaledValue([In] double obj0)
      {
        if (obj0 < this.min)
          obj0 = this.min;
        if (obj0 > this.max)
          obj0 = this.max;
        this.setValue(ByteCodeHelper.d2i((obj0 - this.min) / (this.max - this.min) * (double) this.pixelWidth));
      }

      [LineNumberTable(new byte[] {(byte) 94, (byte) 105, (byte) 104, (byte) 102, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBindableValue(double value)
      {
        this.value = value;
        this.setUnscaledValue(value);
        ((JComponent) this).revalidate();
        ((Component) this).repaint();
      }

      [LineNumberTable(new byte[] {(byte) 112, (byte) 105, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setMin(double min)
      {
        this.min = min;
        this.calcBounds();
      }

      [LineNumberTable(new byte[] {(byte) 117, (byte) 105, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setMax(double max)
      {
        this.max = max;
        this.calcBounds();
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 66, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void componentResized(ComponentEvent e)
      {
        this.calcBounds();
      }

      public virtual void componentMoved(ComponentEvent e)
      {
      }

      public virtual void componentShown(ComponentEvent e)
      {
      }

      public virtual void componentHidden(ComponentEvent e)
      {
      }
    }

    [InnerClass]
    [Implements(new string[] {"edu.wpi.first.smartdashboard.gui.elements.bindings.NumberBindable", "java.awt.event.ComponentListener", "javax.swing.event.ChangeListener"})]
    [SourceFile("Widget.java")]
    [Serializable]
    public class NumberSlider : JSlider, NumberBindable, ComponentListener, EventListener, ChangeListener
    {
      private double min;
      private double max;
      private double value;
      private int pixelWidth;
      [Modifiers]
      private NumberBindable bindable;

      [HideFromJava]
      static NumberSlider()
      {
        JSlider.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 11, (byte) 232, (byte) 58, (byte) 108, (byte) 112, (byte) 108, (byte) 199, (byte) 103, (byte) 103, (byte) 103, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public NumberSlider(NumberBindable bindable)
      {
        base.\u002Ector();
        Widget.NumberSlider numberSlider = this;
        this.min = 0.0;
        this.max = 100.0;
        this.value = 0.0;
        this.pixelWidth = 0;
        this.bindable = bindable;
        ((Component) this).addComponentListener((ComponentListener) this);
        this.addChangeListener((ChangeListener) this);
        this.calcBounds();
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected NumberSlider([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable(new byte[] {(byte) 56, (byte) 108, (byte) 103, (byte) 108, (byte) 110})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private void calcBounds()
      {
        this.pixelWidth = ((JComponent) this).getWidth();
        this.setMinimum(0);
        this.setMaximum(this.pixelWidth);
        this.setUnscaledValue(this.value);
      }

      [LineNumberTable(new byte[] {(byte) 27, (byte) 106, (byte) 136, (byte) 106, (byte) 136, (byte) 121, (byte) 118})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private void setUnscaledValue([In] double obj0)
      {
        if (obj0 < this.min)
          obj0 = this.min;
        if (obj0 > this.max)
          obj0 = this.max;
        this.setValue(ByteCodeHelper.d2i((obj0 - this.min) / (this.max - this.min) * (double) this.pixelWidth));
      }

      [LineNumberTable(new byte[] {(byte) 20, (byte) 105, (byte) 104, (byte) 102, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBindableValue(double value)
      {
        this.value = value;
        this.setUnscaledValue(value);
        ((JComponent) this).revalidate();
        ((Component) this).repaint();
      }

      [LineNumberTable(new byte[] {(byte) 39, (byte) 136, (byte) 159, (byte) 18})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void stateChanged(ChangeEvent e)
      {
        if (this.getValueIsAdjusting())
          return;
        this.bindable.setBindableValue((double) this.getValue() * (this.max - this.min) / (double) this.pixelWidth + this.min);
      }

      [LineNumberTable(new byte[] {(byte) 46, (byte) 105, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setMin(double min)
      {
        this.min = min;
        this.calcBounds();
      }

      [LineNumberTable(new byte[] {(byte) 51, (byte) 105, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setMax(double max)
      {
        this.max = max;
        this.calcBounds();
      }

      [LineNumberTable(new byte[] {(byte) 64, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void componentResized(ComponentEvent e)
      {
        this.calcBounds();
      }

      public virtual void componentMoved(ComponentEvent e)
      {
      }

      public virtual void componentShown(ComponentEvent e)
      {
      }

      public virtual void componentHidden(ComponentEvent e)
      {
      }
    }

    [InnerClass]
    [Implements(new string[] {"edu.wpi.first.smartdashboard.gui.elements.bindings.StringBindable"})]
    [SourceFile("Widget.java")]
    [Serializable]
    public abstract class StringField : Widget.EditorTextField, StringBindable
    {
      private string value;

      [HideFromJava]
      static StringField()
      {
        Widget.EditorTextField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 250, (byte) 136})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public StringField()
      {
        Widget.StringField stringField = this;
        this.value = (string) null;
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected StringField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal new static void __\u003Cclinit\u003E()
      {
      }

      protected internal abstract bool setValue(string str);

      [LineNumberTable(new byte[] {(byte) 161, (byte) 9, (byte) 104, (byte) 141, (byte) 142})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal virtual void resetValue()
      {
        if (this.value == null)
          this.setText("");
        else
          this.setBindableValue(this.value);
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 18, (byte) 103, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBindableValue(string value)
      {
        this.value = value;
        this.setText(value);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 255, (byte) 110, (byte) 105, (byte) 137, (byte) 168})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      protected internal override void textChanged(string newValue)
      {
        if (String.instancehelper_equals(this.value, (object) newValue))
          return;
        if (this.setValue(newValue))
          this.value = newValue;
        else
          this.resetValue();
      }
    }

    [InnerClass]
    [Implements(new string[] {"edu.wpi.first.smartdashboard.gui.elements.bindings.StringBindable"})]
    [SourceFile("Widget.java")]
    public class StringMultiBindable : Object, StringBindable
    {
      [Modifiers]
      private StringBindable[] bindables;

      [LineNumberTable(new byte[] {(byte) 161, (byte) 210, (byte) 104, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public StringMultiBindable(params StringBindable[] bindables)
      {
        base.\u002Ector();
        Widget.StringMultiBindable stringMultiBindable = this;
        this.bindables = bindables;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 216, (byte) 116, (byte) 39, (byte) 166})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBindableValue(string value)
      {
        StringBindable[] stringBindableArray = this.bindables;
        int length = stringBindableArray.Length;
        for (int index = 0; index < length; ++index)
          stringBindableArray[index].setBindableValue(value);
      }
    }

    [InnerClass]
    [SourceFile("Widget.java")]
    [Serializable]
    public class ThreadSafeCheckBox : JCheckBox
    {
      [HideFromJava]
      static ThreadSafeCheckBox()
      {
        JCheckBox.__\u003Cclinit\u003E();
      }

      [LineNumberTable((ushort) 247)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ThreadSafeCheckBox()
      {
        base.\u002Ector();
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected ThreadSafeCheckBox([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable(new byte[] {(byte) 159, (byte) 80, (byte) 130, (byte) 238, (byte) 69})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setText(bool selected)
      {
        SwingUtilities.invokeLater((Runnable) new Widget\u0024ThreadSafeCheckBox\u00241(this, selected));
      }

      [Modifiers]
      [LineNumberTable((ushort) 247)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static void access\u0024101([In] Widget.ThreadSafeCheckBox obj0, [In] bool obj1)
      {
        int num = obj1 ? 1 : 0;
        obj0.__\u003C\u003E(num != 0);
      }

      void __\u003C\u003E([In] bool obj0)
      {
        ((AbstractButton) this).setSelected(obj0);
      }
    }

    [InnerClass]
    [SourceFile("Widget.java")]
    [Serializable]
    public class ThreadSafeTextField : JTextField
    {
      [HideFromJava]
      static ThreadSafeTextField()
      {
        JTextField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 97, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ThreadSafeTextField(string text)
      {
        base.\u002Ector(text);
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 101, (byte) 104})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ThreadSafeTextField()
      {
        base.\u002Ector();
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected ThreadSafeTextField([In] SerializationInfo obj0, [In] StreamingContext obj1)
      {
        base.\u002Ector(obj0, obj1);
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void __\u003Cclinit\u003E()
      {
      }

      [LineNumberTable(new byte[] {(byte) 160, (byte) 105, (byte) 238, (byte) 69})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setText(string text)
      {
        SwingUtilities.invokeLater((Runnable) new Widget\u0024ThreadSafeTextField\u00241(this, text));
      }

      [Modifiers]
      [LineNumberTable((ushort) 208)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal static void access\u0024001([In] Widget.ThreadSafeTextField obj0, [In] string obj1)
      {
        obj0.__\u003C\u003E(obj1);
      }

      void __\u003C\u003E([In] string obj0)
      {
        ((JTextComponent) this).setText(obj0);
      }
    }

    [InnerClass]
    [Implements(new string[] {"edu.wpi.first.smartdashboard.gui.elements.bindings.StringBindable"})]
    [SourceFile("Widget.java")]
    public class TitledBorderStringDisplayer : Object, StringBindable
    {
      [Modifiers]
      private JComponent component;

      [LineNumberTable(new byte[] {(byte) 161, (byte) 77, (byte) 104, (byte) 103})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public TitledBorderStringDisplayer(JComponent component)
      {
        base.\u002Ector();
        Widget.TitledBorderStringDisplayer borderStringDisplayer = this;
        this.component = component;
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 83, (byte) 115})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void setBindableValue(string value)
      {
        this.component.setBorder((Border) BorderFactory.createTitledBorder(value));
      }
    }

    [InnerClass]
    [SourceFile("Widget.java")]
    [Serializable]
    public class UneditableBooleanCheckBox : Widget.BooleanCheckBox
    {
      [HideFromJava]
      static UneditableBooleanCheckBox()
      {
        Widget.BooleanCheckBox.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 25, (byte) 168, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public UneditableBooleanCheckBox()
      {
        Widget.UneditableBooleanCheckBox uneditableBooleanCheckBox = this;
        ((AbstractButton) this).setEnabled(false);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected UneditableBooleanCheckBox([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }

      protected internal override bool setValue(bool value)
      {
        return false;
      }
    }

    [InnerClass]
    [SourceFile("Widget.java")]
    [Serializable]
    public class UneditableBooleanField : Widget.BooleanField
    {
      [HideFromJava]
      static UneditableBooleanField()
      {
        Widget.BooleanField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 37, (byte) 168, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public UneditableBooleanField()
      {
        Widget.UneditableBooleanField uneditableBooleanField = this;
        ((JTextComponent) this).setEditable(false);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected UneditableBooleanField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }

      protected internal override bool setValue(bool value)
      {
        return false;
      }
    }

    [InnerClass]
    [SourceFile("Widget.java")]
    [Serializable]
    public class UneditableNumberField : Widget.NumberField
    {
      [HideFromJava]
      static UneditableNumberField()
      {
        Widget.NumberField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 49, (byte) 168, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public UneditableNumberField()
      {
        Widget.UneditableNumberField uneditableNumberField = this;
        ((JTextComponent) this).setEditable(false);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected UneditableNumberField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }

      protected internal override bool setValue(double value)
      {
        return false;
      }
    }

    [InnerClass]
    [SourceFile("Widget.java")]
    [Serializable]
    public class UneditableStringField : Widget.StringField
    {
      [HideFromJava]
      static UneditableStringField()
      {
        Widget.StringField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 161, (byte) 61, (byte) 168, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public UneditableStringField()
      {
        Widget.UneditableStringField uneditableStringField = this;
        ((JTextComponent) this).setEditable(false);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected UneditableStringField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }

      protected internal override bool setValue(string value)
      {
        return false;
      }
    }
  }
}
