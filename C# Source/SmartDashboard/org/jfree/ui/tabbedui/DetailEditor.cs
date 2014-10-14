// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.tabbedui.DetailEditor
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using java.lang;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace org.jfree.ui.tabbedui
{
  [Serializable]
  public abstract class DetailEditor : JComponent
  {
    private object @object;
    private bool confirmed;

    [HideFromJava]
    static DetailEditor()
    {
      JComponent.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 12, (byte) 136})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DetailEditor()
    {
      base.\u002Ector();
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected DetailEditor([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector(obj0, obj1);
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static void __\u003Cclinit\u003E()
    {
    }

    protected internal abstract void updateObject(object obj);

    [LineNumberTable(new byte[] {(byte) 159, (byte) 104, (byte) 98, (byte) 103, (byte) 103, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void setConfirmed(bool confirmed)
    {
      int num1 = confirmed ? 1 : 0;
      int num2 = this.confirmed ? 1 : 0;
      this.confirmed = num1 != 0;
      this.firePropertyChange("confirmed", num2 != 0, num1 != 0);
    }

    protected internal abstract void fillObject();

    [LineNumberTable(new byte[] {(byte) 20, (byte) 104, (byte) 171, (byte) 140, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void update()
    {
      if (this.@object == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalStateException();
      }
      else
      {
        this.updateObject(this.@object);
        this.setConfirmed(false);
      }
    }

    public virtual object getObject()
    {
      return this.@object;
    }

    [LineNumberTable(new byte[] {(byte) 44, (byte) 99, (byte) 139, (byte) 103, (byte) 103, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void setObject(object @object)
    {
      if (@object == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else
      {
        this.@object = @object;
        this.setConfirmed(false);
        this.fillObject();
      }
    }

    [LineNumberTable(new byte[] {(byte) 63, (byte) 149, (byte) 97})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal static int parseInt(string text, int def)
    {
      int num;
      try
      {
        num = Integer.parseInt(text);
      }
      catch (NumberFormatException ex)
      {
        goto label_3;
      }
      return num;
label_3:
      return def;
    }

    public abstract void clear();

    public virtual bool isConfirmed()
    {
      return this.confirmed;
    }
  }
}
