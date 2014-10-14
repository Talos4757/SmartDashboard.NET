// Decompiled with JetBrains decompiler
// Type: org.jfree.util.WaitingImageObserver
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.image;
using java.io;
using java.lang;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

namespace org.jfree.util
{
  [Implements(new string[] {"java.awt.image.ImageObserver", "java.io.Serializable", "java.lang.Cloneable"})]
  [Serializable]
  public class WaitingImageObserver : Object, ImageObserver, Serializable.__Interface, Cloneable.__Interface, ISerializable
  {
    internal const long serialVersionUID = -807204410581383550L;
    private bool @lock;
    private Image image;
    private bool error;

    [LineNumberTable(new byte[] {(byte) 37, (byte) 104, (byte) 99, (byte) 139, (byte) 103, (byte) 103})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public WaitingImageObserver(Image image)
    {
      base.\u002Ector();
      WaitingImageObserver waitingImageObserver = this;
      if (image == null)
      {
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException();
      }
      else
      {
        this.image = image;
        this.@lock = true;
      }
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected WaitingImageObserver([In] SerializationInfo obj0, [In] StreamingContext obj1)
    {
      base.\u002Ector();
      Serialization.readObject((object) this, obj0);
    }

    [HideFromJava]
    public static implicit operator Serializable([In] WaitingImageObserver obj0)
    {
      Serializable serializable;
      serializable.__\u003Cref\u003E = (__Null) obj0;
      return serializable;
    }

    [HideFromJava]
    public static implicit operator Cloneable([In] WaitingImageObserver obj0)
    {
      Cloneable cloneable;
      cloneable.__\u003Cref\u003E = (__Null) obj0;
      return cloneable;
    }

    [LineNumberTable(new byte[] {(byte) 71, (byte) 104, (byte) 103, (byte) 103, (byte) 102, (byte) 130, (byte) 150, (byte) 103, (byte) 103, (byte) 102, (byte) 162})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual bool imageUpdate(Image img, int infoflags, int x, int y, int width, int height)
    {
      if ((infoflags & 32) == 32)
      {
        this.@lock = false;
        this.error = false;
        Object.instancehelper_notifyAll((object) this);
        return false;
      }
      else
      {
        if ((infoflags & 128) != 128 && (infoflags & 64) != 64)
          return true;
        this.@lock = false;
        this.error = true;
        Object.instancehelper_notifyAll((object) this);
        return false;
      }
    }

    [LineNumberTable(new byte[] {(byte) 94, (byte) 136, (byte) 161, (byte) 169, (byte) 135, (byte) 104, (byte) 159, (byte) 0, (byte) 193, (byte) 254, (byte) 71, (byte) 226, (byte) 59, (byte) 97, (byte) 203, (byte) 133})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual void waitImageLoaded()
    {
      if (!this.@lock)
        return;
      BufferedImage bufferedImage = new BufferedImage(1, 1, 1);
      Graphics graphics = bufferedImage.getGraphics();
      while (this.@lock)
      {
        if (graphics.drawImage(this.image, 0, 0, bufferedImage.getWidth((ImageObserver) this), bufferedImage.getHeight((ImageObserver) this), (ImageObserver) this))
          break;
        InterruptedException interruptedException;
        try
        {
          Object.instancehelper_wait((object) this, 500L);
          continue;
        }
        catch (InterruptedException ex)
        {
          int num = 1;
          interruptedException = (InterruptedException) ByteCodeHelper.MapException<InterruptedException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        }
        Log.info((object) "WaitingImageObserver.waitImageLoaded(): InterruptedException thrown", (Exception) interruptedException);
      }
    }

    [Throws(new string[] {"java.lang.CloneNotSupportedException"})]
    [Obsolete]
    [LineNumberTable((ushort) 181)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual object clone()
    {
      return (object) (WaitingImageObserver) base.clone();
    }

    public virtual bool isLoadingComplete()
    {
      return !this.@lock;
    }

    public virtual bool isError()
    {
      return this.error;
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
