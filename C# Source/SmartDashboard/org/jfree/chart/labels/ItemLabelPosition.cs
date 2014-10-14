// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.labels.ItemLabelPosition
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using org.jfree.ui;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.labels
{
  [Implements(new string[] {"java.io.Serializable"})]
  [Serializable]
  public class ItemLabelPosition : Object, Serializable.__Interface, ISerializable
  {
    private const long serialVersionUID = 5845390630157034499L;
    private ItemLabelAnchor itemLabelAnchor;
    private TextAnchor textAnchor;
    private TextAnchor rotationAnchor;
    private double angle;

    [LineNumberTable(new byte[] {(byte) 38, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ItemLabelPosition(ItemLabelAnchor itemLabelAnchor, TextAnchor textAnchor)
      : this(itemLabelAnchor, textAnchor, TextAnchor.__\u003C\u003ECENTER, 0.0)
    {
    }

    [LineNumberTable(new byte[] {(byte) 57, (byte) 136, (byte) 99, (byte) 176, (byte) 99, (byte) 144, (byte) 99, (byte) 208, (byte) 103, (byte) 103, (byte) 103, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ItemLabelPosition(ItemLabelAnchor itemLabelAnchor, TextAnchor textAnchor, TextAnchor rotationAnchor, double angle)
    {
      base.\u002Ector();
      ItemLabelPosition itemLabelPosition = this;
      if (itemLabelAnchor == null)
      {
        string str = "Null 'itemLabelAnchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (textAnchor == null)
      {
        string str = "Null 'textAnchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else if (rotationAnchor == null)
      {
        string str = "Null 'rotationAnchor' argument.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        this.itemLabelAnchor = itemLabelAnchor;
        this.textAnchor = textAnchor;
        this.rotationAnchor = rotationAnchor;
        this.angle = angle;
      }
    }

    [LineNumberTable(new byte[] {(byte) 25, (byte) 156})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ItemLabelPosition()
      : this(ItemLabelAnchor.__\u003C\u003EOUTSIDE12, TextAnchor.__\u003C\u003EBOTTOM_CENTER, TextAnchor.__\u003C\u003ECENTER, 0.0)
    {
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected ItemLabelPosition([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] ItemLabelPosition obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    public virtual ItemLabelAnchor getItemLabelAnchor()
    {
      return this.itemLabelAnchor;
    }

    public virtual TextAnchor getTextAnchor()
    {
      return this.textAnchor;
    }

    public virtual TextAnchor getRotationAnchor()
    {
      return this.rotationAnchor;
    }

    public virtual double getAngle()
    {
      return this.angle;
    }

    [LineNumberTable(new byte[] {(byte) 122, (byte) 100, (byte) 130, (byte) 104, (byte) 130, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (obj == this)
        return true;
      if (!(obj is ItemLabelPosition))
        return false;
      ItemLabelPosition itemLabelPosition = (ItemLabelPosition) obj;
      return this.itemLabelAnchor.equals((object) itemLabelPosition.itemLabelAnchor) && this.textAnchor.equals((object) itemLabelPosition.textAnchor) && (this.rotationAnchor.equals((object) itemLabelPosition.rotationAnchor) && this.angle == itemLabelPosition.angle);
    }

    [SecurityCritical]
    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    void ISerializable.GetObjectData([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      Serialization.writeObject((object) this, obj0);
    }
  }
}
