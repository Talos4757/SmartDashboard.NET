// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.action.ActionButton
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
  public class ActionButton : JButton
  {
    private Action action;
    private ActionButton.ActionEnablePropertyChangeHandler propertyChangeHandler;

    [HideFromJava]
    static ActionButton()
    {
      JButton.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 95, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionButton()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionButton(string text)
    {
      base.\u002Ector(text);
    }

    [LineNumberTable(new byte[] {(byte) 114, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionButton(string text, Icon icon)
    {
      base.\u002Ector(text, icon);
    }

    [LineNumberTable(new byte[] {(byte) 124, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionButton(Icon icon)
    {
      base.\u002Ector(icon);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 68, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionButton(Action action)
    {
      base.\u002Ector();
      ActionButton actionButton = this;
      this.setAction(action);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ActionButton([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void __\u003Cclinit\u003E()
    {
    }

    public virtual Action getAction()
    {
      return this.action;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 88, (byte) 66, (byte) 103, (byte) 104, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setEnabled(bool b)
    {
      int num = b ? 1 : 0;
      ((AbstractButton) this).setEnabled(num != 0);
      if (this.getAction() == null)
        return;
      this.getAction().setEnabled(num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 122, (byte) 103, (byte) 99, (byte) 103, (byte) 140, (byte) 108, (byte) 104, (byte) 103, (byte) 167, (byte) 103, (byte) 107, (byte) 103, (byte) 140, (byte) 123, (byte) 123, (byte) 118, (byte) 145, (byte) 108, (byte) 99, (byte) 104, (byte) 103, (byte) 108, (byte) 98, (byte) 104, (byte) 104, (byte) 173, (byte) 108, (byte) 104, (byte) 103, (byte) 171})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAction(Action newAction)
    {
      Action action = this.getAction();
      if (action != null)
      {
        ((AbstractButton) this).removeActionListener((ActionListener) action);
        action.removePropertyChangeListener((PropertyChangeListener) this.getPropertyChangeHandler());
        object obj = action.getValue("AcceleratorKey");
        if (obj is KeyStroke)
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
      if (!(obj2 is KeyStroke))
        return;
      KeyStroke keyStroke = (KeyStroke) obj2;
      ((JComponent) this).registerKeyboardAction((ActionListener) newAction, keyStroke, 2);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 89, (byte) 104, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private ActionButton.ActionEnablePropertyChangeHandler getPropertyChangeHandler()
    {
      if (this.propertyChangeHandler == null)
        this.propertyChangeHandler = new ActionButton.ActionEnablePropertyChangeHandler(this);
      return this.propertyChangeHandler;
    }

    [InnerClass]
    [Implements(new string[] {"java.beans.PropertyChangeListener"})]
    [SourceFile("ActionButton.java")]
    [Modifiers]
    internal sealed class ActionEnablePropertyChangeHandler : Object, PropertyChangeListener, EventListener
    {
      [Modifiers]
      private ActionButton this\u00240;

      [LineNumberTable(new byte[] {(byte) 34, (byte) 111})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ActionEnablePropertyChangeHandler([In] ActionButton obj0)
      {
        base.\u002Ector();
        ActionButton.ActionEnablePropertyChangeHandler propertyChangeHandler = this;
        this.this\u00240 = obj0;
      }

      [LineNumberTable(new byte[] {(byte) 44, (byte) 114, (byte) 159, (byte) 1, (byte) 114, (byte) 159, (byte) 8, (byte) 114, (byte) 191, (byte) 8, (byte) 114, (byte) 223, (byte) 6, (byte) 108, (byte) 114, (byte) 108, (byte) 99, (byte) 140, (byte) 108, (byte) 104, (byte) 103, (byte) 142, (byte) 101, (byte) 117, (byte) 109, (byte) 100, (byte) 105, (byte) 105, (byte) 114, (byte) 98, (byte) 105, (byte) 105, (byte) 255, (byte) 12, (byte) 71, (byte) 2, (byte) 98, (byte) 140})]
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
            if (!(obj is KeyStroke))
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
