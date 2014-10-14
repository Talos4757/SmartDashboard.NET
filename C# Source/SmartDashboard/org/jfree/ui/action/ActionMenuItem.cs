// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.action.ActionMenuItem
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
  public class ActionMenuItem : JMenuItem
  {
    private Action action;
    private ActionMenuItem.ActionEnablePropertyChangeHandler propertyChangeHandler;

    [HideFromJava]
    static ActionMenuItem()
    {
      JMenuItem.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 99, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionMenuItem()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 110, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionMenuItem(Icon icon)
    {
      base.\u002Ector(icon);
    }

    [LineNumberTable(new byte[] {(byte) 120, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionMenuItem(string text)
    {
      base.\u002Ector(text);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 67, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionMenuItem(string text, Icon icon)
    {
      base.\u002Ector(text, icon);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 78, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionMenuItem(string text, int i)
    {
      base.\u002Ector(text, i);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 87, (byte) 104, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionMenuItem(Action action)
    {
      base.\u002Ector();
      ActionMenuItem actionMenuItem = this;
      this.setAction(action);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ActionMenuItem([In] SerializationInfo obj0, [In] StreamingContext obj1)
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

    [LineNumberTable(new byte[] {(byte) 159, (byte) 83, (byte) 162, (byte) 103, (byte) 136, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setEnabled(bool b)
    {
      int num = b ? 1 : 0;
      base.setEnabled(num != 0);
      if (this.getAction() == null)
        return;
      this.getAction().setEnabled(num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 145, (byte) 103, (byte) 131, (byte) 103, (byte) 108, (byte) 135, (byte) 103, (byte) 139, (byte) 103, (byte) 140, (byte) 123, (byte) 123, (byte) 118, (byte) 145, (byte) 108, (byte) 131, (byte) 136, (byte) 103, (byte) 108, (byte) 98, (byte) 136, (byte) 103, (byte) 108, (byte) 194, (byte) 199, (byte) 108, (byte) 136, (byte) 174})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setAction(Action newAction)
    {
      Action action = this.getAction();
      if (action != null)
      {
        ((AbstractButton) this).removeActionListener((ActionListener) action);
        action.removePropertyChangeListener((PropertyChangeListener) this.getPropertyChangeHandler());
        this.setAccelerator((KeyStroke) null);
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
      else
        ((AbstractButton) this).setMnemonic(0);
      object obj2 = newAction.getValue("AcceleratorKey");
      if (!(obj2 is KeyStroke))
        return;
      this.setAccelerator((KeyStroke) obj2);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 110, (byte) 136, (byte) 140})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private ActionMenuItem.ActionEnablePropertyChangeHandler getPropertyChangeHandler()
    {
      if (this.propertyChangeHandler == null)
        this.propertyChangeHandler = new ActionMenuItem.ActionEnablePropertyChangeHandler(this);
      return this.propertyChangeHandler;
    }

    [InnerClass]
    [Implements(new string[] {"java.beans.PropertyChangeListener"})]
    [SourceFile("ActionMenuItem.java")]
    [Modifiers]
    internal sealed class ActionEnablePropertyChangeHandler : Object, PropertyChangeListener, EventListener
    {
      [Modifiers]
      private ActionMenuItem this\u00240;

      [LineNumberTable(new byte[] {(byte) 33, (byte) 111})]
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ActionEnablePropertyChangeHandler([In] ActionMenuItem obj0)
      {
        base.\u002Ector();
        ActionMenuItem.ActionEnablePropertyChangeHandler propertyChangeHandler = this;
        this.this\u00240 = obj0;
      }

      [LineNumberTable(new byte[] {(byte) 45, (byte) 146, (byte) 159, (byte) 1, (byte) 146, (byte) 159, (byte) 8, (byte) 146, (byte) 159, (byte) 8, (byte) 146, (byte) 223, (byte) 6, (byte) 108, (byte) 146, (byte) 159, (byte) 1, (byte) 149, (byte) 108, (byte) 131, (byte) 136, (byte) 103, (byte) 113, (byte) 98, (byte) 136, (byte) 103, (byte) 113, (byte) 194, (byte) 255, (byte) 6, (byte) 71, (byte) 226, (byte) 61, (byte) 130, (byte) 140})]
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
            this.this\u00240.setAccelerator((KeyStroke) action.getValue("AcceleratorKey"));
            return;
          }
          else
          {
            if (!String.instancehelper_equals(obj0.getPropertyName(), (object) "MnemonicKey"))
              return;
            object obj = action.getValue("MnemonicKey");
            if (obj != null)
            {
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
            else
            {
              ((AbstractButton) this.this\u00240).setMnemonic(0);
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
