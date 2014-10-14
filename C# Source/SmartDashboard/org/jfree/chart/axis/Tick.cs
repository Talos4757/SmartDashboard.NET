// Decompiled with JetBrains decompiler
// Type: org.jfree.chart.axis.Tick
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using java.io;
using java.lang;
using org.jfree.ui;
using org.jfree.util;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.chart.axis
{
  [Implements(new string[] {"java.io.Serializable", "java.lang.Cloneable"})]
  [Serializable]
  public abstract class Tick : Object, Serializable.__Interface, Cloneable.__Interface, ISerializable
  {
    private const long serialVersionUID = 6668230383875149773L;
    private string text;
    private TextAnchor textAnchor;
    private TextAnchor rotationAnchor;
    private double angle;

    [LineNumberTable(new byte[] {(byte) 33, (byte) 104, (byte) 99, (byte) 144, (byte) 99, (byte) 208, (byte) 103, (byte) 103, (byte) 103, (byte) 106})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Tick(string text, TextAnchor textAnchor, TextAnchor rotationAnchor, double angle)
    {
      base.\u002Ector();
      Tick tick = this;
      if (textAnchor == null)
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
        this.text = text;
        this.textAnchor = textAnchor;
        this.rotationAnchor = rotationAnchor;
        this.angle = angle;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Tick([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] Tick obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] Tick obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    public virtual string getText()
    {
      return this.text;
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

    [LineNumberTable(new byte[] {(byte) 93, (byte) 100, (byte) 130, (byte) 104, (byte) 103, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 115, (byte) 130, (byte) 110, (byte) 130, (byte) 130})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool equals(object obj)
    {
      if (this == obj)
        return true;
      if (!(obj is Tick))
        return false;
      Tick tick = (Tick) obj;
      return ObjectUtilities.equal((object) this.text, (object) tick.text) && ObjectUtilities.equal((object) this.textAnchor, (object) tick.textAnchor) && (ObjectUtilities.equal((object) this.rotationAnchor, (object) tick.rotationAnchor) && this.angle == tick.angle);
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [LineNumberTable(new byte[] {(byte) 123, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return (object) (Tick) base.clone();
    }

    public virtual string toString()
    {
      return this.text;
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
