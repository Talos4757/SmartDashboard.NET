// Decompiled with JetBrains decompiler
// Type: edu.wpi.first.smartdashboard.gui.elements.Image
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using edu.wpi.first.smartdashboard.gui;
using edu.wpi.first.smartdashboard.properties;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.image;
using java.io;
using java.lang;
using javax.imageio;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace edu.wpi.first.smartdashboard.gui.elements
{
  [Serializable]
  public class Image : StaticWidget
  {
    internal FileProperty __\u003C\u003Eimg;
    internal BooleanProperty __\u003C\u003EaspectKept;
    private BufferedImage image;

    [Modifiers]
    public FileProperty img
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003Eimg;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003Eimg = value;
      }
    }

    [Modifiers]
    public BooleanProperty aspectKept
    {
      [HideFromJava] get
      {
        return this.__\u003C\u003EaspectKept;
      }
      [HideFromJava] private set
      {
        this.__\u003C\u003EaspectKept = value;
      }
    }

    [HideFromJava]
    static Image()
    {
      StaticWidget.__\u003Cclinit\u003E();
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 165, (byte) 232, (byte) 60, (byte) 113, (byte) 210, (byte) 105})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public Image()
    {
      Image image = this;
      this.__\u003C\u003Eimg = new FileProperty((PropertyHolder) this, "Image File");
      this.__\u003C\u003EaspectKept = new BooleanProperty((PropertyHolder) this, "Maintain Aspect Ratio", false);
      this.setObstruction(false);
    }

    [HideFromJava]
    [PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
    protected Image([In] SerializationInfo obj0, [In] StreamingContext obj1)
      : base(obj0, obj1)
    {
    }

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public new static void __\u003Cclinit\u003E()
    {
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 171, (byte) 113, (byte) 117, (byte) 117, (byte) 117, (byte) 117, (byte) 117, (byte) 104, (byte) 145})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void init()
    {
      this.update((Property) this.__\u003C\u003Eimg, (object) ".");
      this.__\u003C\u003Eimg.addExtensionFilter("JPEG", ".jpg");
      this.__\u003C\u003Eimg.addExtensionFilter("GIF", ".gif");
      this.__\u003C\u003Eimg.addExtensionFilter("PNG", ".png");
      this.__\u003C\u003Eimg.addExtensionFilter("Bitmap", ".bmp");
      this.__\u003C\u003Eimg.addExtensionFilter("JPEG", ".jpeg");
      if (this.image != null)
        return;
      ((JComponent) this).setPreferredSize(new Dimension(100, 100));
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 184, (byte) 140, (byte) 127, (byte) 6, (byte) 255, (byte) 18, (byte) 69, (byte) 226, (byte) 60, (byte) 97, (byte) 103, (byte) 113, (byte) 143, (byte) 102, (byte) 134})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void propertyChanged(Property property)
    {
      if (property != this.__\u003C\u003Eimg)
        return;
      try
      {
        File.__\u003Cclinit\u003E();
        this.image = ImageIO.read(new File((string) this.__\u003C\u003Eimg.getValue()));
        Dimension.__\u003Cclinit\u003E();
        ((JComponent) this).setPreferredSize(new Dimension(this.image.getWidth(), this.image.getHeight()));
        goto label_5;
      }
      catch (IOException ex)
      {
      }
      this.image = (BufferedImage) null;
      JOptionPane.showMessageDialog((Component) this, (object) "Invalid File Type.", "Input Error", 2);
      ((JComponent) this).setPreferredSize(new Dimension(100, 100));
label_5:
      ((JComponent) this).revalidate();
      ((Component) this).repaint();
    }

    [LineNumberTable(new byte[] {(byte) 8, (byte) 104, (byte) 153, (byte) 122, (byte) 108, (byte) 108, (byte) 127, (byte) 6, (byte) 191, (byte) 111, (byte) 98, (byte) 191, (byte) 21})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual void paintComponent(Graphics g)
    {
      if (this.image == null)
        g.fillRect(0, 0, ((JComponent) this).getWidth(), ((JComponent) this).getHeight());
      else if (((Boolean) this.__\u003C\u003EaspectKept.getValue()).booleanValue())
      {
        int num1 = (int) ((Component) this).getBounds().width;
        int num2 = (int) ((Component) this).getBounds().height;
        double num3 = Math.min((double) num1 / (double) this.image.getWidth(), (double) num2 / (double) this.image.getHeight());
        g.drawImage((Image) this.image, ByteCodeHelper.d2i((double) num1 - num3 * (double) this.image.getWidth()) / 2, ByteCodeHelper.d2i((double) num2 - num3 * (double) this.image.getHeight()) / 2, ByteCodeHelper.d2i(((double) num1 + num3 * (double) this.image.getWidth()) / 2.0), ByteCodeHelper.d2i((double) num2 + num3 * (double) this.image.getHeight()) / 2, 0, 0, this.image.getWidth(), this.image.getHeight(), (ImageObserver) null);
      }
      else
        g.drawImage((Image) this.image, 0, 0, ((JComponent) this).getWidth(), ((JComponent) this).getHeight(), 0, 0, this.image.getWidth(), this.image.getHeight(), (ImageObserver) null);
    }
  }
}
