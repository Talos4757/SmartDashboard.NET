// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.action.ActionRadioButton
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt.@event;
using java.beans;
using java.lang;
using java.util;
using javax.swing;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui.action
{
  [Serializable]
  public class ActionRadioButton : JRadioButton
  {
    private Action action;
    private ActionRadioButton.ActionEnablePropertyChangeHandler propertyChangeHandler;

    [HideFromJava]
    static ActionRadioButton()
    {
      JRadioButton.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 101, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionRadioButton()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 111, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionRadioButton(string text)
    {
      base.\u002Ector(text);
    }

    [LineNumberTable(new byte[] {(byte) 122, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionRadioButton(string text, Icon icon)
    {
      base.\u002Ector(text, icon);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 69, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionRadioButton(Icon icon)
    {
      base.\u002Ector(icon);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 78, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionRadioButton(Action action)
    {
      base.\u002Ector();
      ActionRadioButton actionRadioButton = this;
      this.setAction(action);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ActionRadioButton([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 138, (byte) 103, (byte) 131, (byte) 103, (byte) 140, (byte) 108, (byte) 139, (byte) 103, (byte) 167, (byte) 103, (byte) 139, (byte) 103, (byte) 140, (byte) 123, (byte) 123, (byte) 118, (byte) 145, (byte) 108, (byte) 131, (byte) 136, (byte) 103, (byte) 108, (byte) 98, (byte) 136, (byte) 104, (byte) 173, (byte) 108, (byte) 139, (byte) 103, (byte) 171})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAction(Action newAction)
    {
      Action action = this.getAction();
      if (action != null)
      {
        ((AbstractButton) this).removeActionListener((ActionListener) action);
        action.removePropertyChangeListener((PropertyChangeListener) this.getPropertyChangeHandler());
        object obj = action.getValue("AcceleratorKey");
        if (obj is KeyStroke && obj != null)
          ((JComponent) this).unregisterKeyboardAction((KeyStroke) obj);
      }
      this.action = newAction;
      if (this.action == null)
        return;
      ((AbstractButton) this).addActionListener((ActionListener) newAction);
      newAction.addPropertyChangeListener((PropertyChangeListener) this.getPropertyChangeHandler());
      ((AbstractButton) this).setText((string) newAction.getValue("Name"));
      ((JComponent) this).setToolTipText((string) newAction.getValue("ShortDescription"));
      ((AbstractButton) this).setIcon((Icon) newAction.getValue("SmallIcon"));
      this.setEnabled(this.action.isEnabled());
      object obj1 = newAction.getValue("MnemonicKey");
      if (obj1 != null)
      {
        if (obj1 is Character)
          ((AbstractButton) this).setMnemonic(((Character) obj1).charValue());
        else if (obj1 is Integer)
          ((AbstractButton) this).setMnemonic(((Integer) obj1).intValue());
      }
      object obj2 = newAction.getValue("AcceleratorKey");
      if (!(obj2 is KeyStroke) || obj2 == null)
        return;
      KeyStroke keyStroke = (KeyStroke) obj2;
      ((JComponent) this).registerKeyboardAction((ActionListener) newAction, keyStroke, 2);
    }

    public virtual Action getAction()
    {
      return this.action;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 101, (byte) 136, (byte) 141})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private ActionRadioButton.ActionEnablePropertyChangeHandler getPropertyChangeHandler()
    {
      if (this.propertyChangeHandler == null)
        this.propertyChangeHandler = new ActionRadioButton.ActionEnablePropertyChangeHandler(this, (ActionRadioButton.\u0031) null);
      return this.propertyChangeHandler;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 85, (byte) 130, (byte) 103, (byte) 136, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setEnabled(bool b)
    {
      int num = b ? 1 : 0;
      ((AbstractButton) this).setEnabled(num != 0);
      if (this.getAction() == null)
        return;
      this.getAction().setEnabled(num != 0);
    }

    [InnerClass]
    [SourceFile("ActionRadioButton.java")]
    [Modifiers]
    internal sealed class \u0031 : Object
    {
      \u0031()
      {
        throw null;
      }
    }

    [InnerClass]
    [Implements(new string[] {"java.beans.PropertyChangeListener"})]
    [SourceFile("ActionRadioButton.java")]
    [Modifiers]
    internal sealed class ActionEnablePropertyChangeHandler : Object, PropertyChangeListener, EventListener
    {
      [Modifiers]
      private ActionRadioButton this\u00240;

      [LineNumberTable((ushort) 75)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      internal ActionEnablePropertyChangeHandler([In] ActionRadioButton obj0, [In] ActionRadioButton.\u0031 obj1)
        : this(obj0)
      {
      }

      [LineNumberTable((ushort) 75)]
      [MethodImpl(MethodImplOptions.NoInlining)]
      private ActionEnablePropertyChangeHandler([In] ActionRadioButton obj0)
      {
        base.\u002Ector();
        ActionRadioButton.ActionEnablePropertyChangeHandler propertyChangeHandler = this;
        this.this\u00240 = obj0;
      }

      [LineNumberTable(new byte[] {(byte) 36, (byte) 146, (byte) 159, (byte) 1, (byte) 146, (byte) 159, (byte) 8, (byte) 146, (byte) 191, (byte) 8, (byte) 146, (byte) 223, (byte) 6, (byte) 108, (byte) 146, (byte) 108, (byte) 131, (byte) 172, (byte) 108, (byte) 139, (byte) 103, (byte) 142, (byte) 101, (byte) 149, (byte) 109, (byte) 132, (byte) 137, (byte) 105, (byte) 114, (byte) 98, (byte) 137, (byte) 105, (byte) 255, (byte) 12, (byte) 72, (byte) 226, (byte) 61, (byte) 130, (byte) 140})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void propertyChange([In] PropertyChangeEvent obj0)
      {
        Exception e;
        try
        {
          if (String.instancehelper_equals(obj0.getPropertyName(), (object) "enabled"))
            this.this\u00240.setEnabled(this.this\u00240.getAction().isEnabled());
          else if (String.instancehelper_equals(obj0.getPropertyName(), (object) "SmallIcon"))
            ((AbstractButton) this.this\u00240).setIcon((Icon) this.this\u00240.getAction().getValue("SmallIcon"));
          else if (String.instancehelper_equals(obj0.getPropertyName(), (object) "Name"))
            ((AbstractButton) this.this\u00240).setText((string) this.this\u00240.getAction().getValue("Name"));
          else if (String.instancehelper_equals(obj0.getPropertyName(), (object) "ShortDescription"))
            ((JComponent) this.this\u00240).setToolTipText((string) this.this\u00240.getAction().getValue("ShortDescription"));
          Action action = this.this\u00240.getAction();
          if (String.instancehelper_equals(obj0.getPropertyName(), (object) "AcceleratorKey"))
          {
            KeyStroke keyStroke1 = (KeyStroke) obj0.getOldValue();
            if (keyStroke1 != null)
              ((JComponent) this.this\u00240).unregisterKeyboardAction(keyStroke1);
            object obj = action.getValue("AcceleratorKey");
            if (!(obj is KeyStroke) || obj == null)
              return;
            KeyStroke keyStroke2 = (KeyStroke) obj;
            ((JComponent) this.this\u00240).registerKeyboardAction((ActionListener) action, keyStroke2, 2);
            return;
          }
          else
          {
            if (!String.instancehelper_equals(obj0.getPropertyName(), (object) "MnemonicKey"))
              return;
            object obj = action.getValue("MnemonicKey");
            if (obj == null)
              return;
            if (obj is Character)
            {
              ((AbstractButton) this.this\u00240).setMnemonic(((Character) obj).charValue());
              return;
            }
            else
            {
              if (!(obj is Integer))
                return;
              ((AbstractButton) this.this\u00240).setMnemonic(((Integer) obj).intValue());
              return;
            }
          }
        }
        catch (Exception ex)
        {
          int num = 0;
          M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
          if (m0 == null)
            throw;
          else
            e = (Exception) m0;
        }
        Log.warn((object) "Error on PropertyChange in ActionButton: ", e);
      }
    }
  }
}
