// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.bindings.AbstractValueWidget
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.robot;
using IKVM.Attributes;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements.bindings
{
  [Serializable]
  public abstract class AbstractValueWidget : Widget
  {
    private BooleanBindable booleanDisplayer;
    private NumberBindable numberDisplayer;
    private StringBindable stringDisplayer;

    [HideFromJava]
    static AbstractValueWidget()
    {
      Widget.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 151, (byte) 136, (byte) 107, (byte) 107, (byte) 235, (byte) 123})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public AbstractValueWidget()
    {
      AbstractValueWidget abstractValueWidget = this;
      this.booleanDisplayer = BooleanBindable.NULL;
      this.numberDisplayer = NumberBindable.NULL;
      this.stringDisplayer = StringBindable.NULL;
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected AbstractValueWidget([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 132, (byte) 66, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(bool value)
    {
      this.booleanDisplayer.setBindableValue(value);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 185, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(double value)
    {
      this.numberDisplayer.setBindableValue(value);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 188, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setValue(string value)
    {
      this.stringDisplayer.setBindableValue(value);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 159, (byte) 104, (byte) 115, (byte) 104, (byte) 115, (byte) 104, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void setValue(object value)
    {
      if (value is Boolean)
        this.setValue(((Boolean) value).booleanValue());
      else if (value is Double)
      {
        this.setValue(((Double) value).doubleValue());
      }
      else
      {
        if (!(value is string))
          return;
        this.setValue((string) value);
      }
    }

    public virtual void setBooleanBinding(BooleanBindable booleanDisplayer)
    {
      this.booleanDisplayer = booleanDisplayer;
    }

    public virtual void setNumberBinding(NumberBindable numberDisplayer)
    {
      this.numberDisplayer = numberDisplayer;
    }

    public virtual void setStringBinding(StringBindable stringDisplayer)
    {
      this.stringDisplayer = stringDisplayer;
    }

    [InnerClass]
    [SourceFile("AbstractValueWidget.java")]
    [Serializable]
    public class EditableBooleanValueCheckBox : Widget.BindableBooleanCheckBox
    {
      [Modifiers]
      internal AbstractValueWidget this\u00240 = avw;

      [HideFromJava]
      static EditableBooleanValueCheckBox()
      {
        Widget.BindableBooleanCheckBox.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 5, (byte) 103, (byte) 115, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public EditableBooleanValueCheckBox(AbstractValueWidget avw, string key)
        : base((BooleanBindable) new Widget.BindableTableEntry(Robot.getTable(), key))
      {
        AbstractValueWidget.EditableBooleanValueCheckBox booleanValueCheckBox = this;
        avw.setBooleanBinding((BooleanBindable) this);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected EditableBooleanValueCheckBox([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }
    }

    [InnerClass]
    [SourceFile("AbstractValueWidget.java")]
    [Serializable]
    public class EditableBooleanValueField : Widget.BindableBooleanField
    {
      [Modifiers]
      internal AbstractValueWidget this\u00240 = avw;

      [HideFromJava]
      static EditableBooleanValueField()
      {
        Widget.BindableBooleanField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 11, (byte) 103, (byte) 115, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public EditableBooleanValueField(AbstractValueWidget avw, string key)
        : base((BooleanBindable) new Widget.BindableTableEntry(Robot.getTable(), key))
      {
        AbstractValueWidget.EditableBooleanValueField booleanValueField = this;
        avw.setBooleanBinding((BooleanBindable) this);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected EditableBooleanValueField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }
    }

    [InnerClass]
    [SourceFile("AbstractValueWidget.java")]
    [Serializable]
    public class EditableNumberValueField : Widget.BindableNumberField
    {
      [Modifiers]
      internal AbstractValueWidget this\u00240 = avw;

      [HideFromJava]
      static EditableNumberValueField()
      {
        Widget.BindableNumberField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 17, (byte) 103, (byte) 115, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public EditableNumberValueField(AbstractValueWidget avw, string key)
        : base((NumberBindable) new Widget.BindableTableEntry(Robot.getTable(), key))
      {
        AbstractValueWidget.EditableNumberValueField numberValueField = this;
        avw.setNumberBinding((NumberBindable) this);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected EditableNumberValueField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }
    }

    [InnerClass]
    [SourceFile("AbstractValueWidget.java")]
    [Serializable]
    public class EditableStringValueField : Widget.BindableStringField
    {
      [Modifiers]
      internal AbstractValueWidget this\u00240 = avw;

      [HideFromJava]
      static EditableStringValueField()
      {
        Widget.BindableStringField.__\u003Cclinit\u003E();
      }

      [LineNumberTable(new byte[] {(byte) 23, (byte) 103, (byte) 115, (byte) 105})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public EditableStringValueField(AbstractValueWidget avw, string key)
        : base((StringBindable) new Widget.BindableTableEntry(Robot.getTable(), key))
      {
        AbstractValueWidget.EditableStringValueField stringValueField = this;
        avw.setStringBinding((StringBindable) this);
      }

      [HideFromJava]
      [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
      protected EditableStringValueField([In] SerializationInfo obj0, [In] StreamingContext obj1)
        : base(obj0, obj1)
      {
      }

      [SpecialName]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public new static void __\u003Cclinit\u003E()
      {
      }
    }
  }
}
