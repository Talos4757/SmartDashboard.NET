// Decompiled with JetBrains decompiler
// Type: org.jfree.util.ResourceBundleSupport
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using ikvm.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.awt.image;
using java.lang;
using java.net;
using java.text;
using java.util;
using javax.swing;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace org.jfree.util
{
  public class ResourceBundleSupport : Object
  {
    private ResourceBundle resources;
    private TreeMap cache;
    private TreeSet lookupPath;
    private string resourceBase;
    private Locale locale;
    internal static Class class\u0024org\u0024jfree\u0024util\u0024ResourceBundleSupport;
    internal static Class class\u0024java\u0024awt\u0024event\u0024KeyEvent;
    [SpecialName]
    private static CallerID __\u003CcallerID\u003E;

    [LineNumberTable(new byte[] {(byte) 84, (byte) 104, (byte) 131, (byte) 144, (byte) 131, (byte) 144, (byte) 131, (byte) 144, (byte) 103, (byte) 103, (byte) 103, (byte) 107, (byte) 107})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal ResourceBundleSupport(Locale locale, ResourceBundle resourceBundle, string baseName)
    {
      base.\u002Ector();
      ResourceBundleSupport resourceBundleSupport = this;
      if (locale == null)
      {
        string str = "Locale must not be null";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else if (resourceBundle == null)
      {
        string str = "Resources must not be null";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else if (baseName == null)
      {
        string str = "BaseName must not be null";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else
      {
        this.locale = locale;
        this.resources = resourceBundle;
        this.resourceBase = baseName;
        this.cache = new TreeMap();
        this.lookupPath = new TreeSet();
      }
    }

    [LineNumberTable(new byte[] {(byte) 69, (byte) 113})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceBundleSupport(Locale locale, string baseName)
      : this(locale, ResourceBundleWrapper.getBundle(baseName, locale), baseName)
    {
    }

    [LineNumberTable(new byte[] {(byte) 114, (byte) 112})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceBundleSupport(Locale locale, ResourceBundle resourceBundle)
      : this(locale, resourceBundle, Object.instancehelper_toString((object) resourceBundle))
    {
    }

    [LineNumberTable(new byte[] {(byte) 125, (byte) 148})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceBundleSupport(string baseName)
      : this(Locale.getDefault(), ResourceBundleWrapper.getBundle(baseName), baseName)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 75, (byte) 111})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal ResourceBundleSupport(ResourceBundle resourceBundle, string baseName)
      : this(Locale.getDefault(), resourceBundle, baseName)
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 85, (byte) 116})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceBundleSupport(ResourceBundle resourceBundle)
      : this(Locale.getDefault(), resourceBundle, Object.instancehelper_toString((object) resourceBundle))
    {
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 131, (byte) 142, (byte) 223, (byte) 2, (byte) 109, (byte) 176, (byte) 106, (byte) 132, (byte) 247, (byte) 69, (byte) 142, (byte) 159, (byte) 13, (byte) 130, (byte) 108, (byte) 215, (byte) 173, (byte) 105, (byte) 109, (byte) 138, (byte) 111, (byte) 195, (byte) 110})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal virtual string internalGetString(string key)
    {
      if (this.lookupPath.contains((object) key))
      {
        string str1 = "InfiniteLoop in resource lookup";
        string resourceBase = this.getResourceBase();
        string str2 = ((AbstractCollection) this.lookupPath).toString();
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new MissingResourceException(str1, resourceBase, str2);
      }
      else
      {
        string string1 = this.resources.getString(key);
        if (String.instancehelper_startsWith(string1, "@@"))
        {
          int num1 = String.instancehelper_indexOf(string1, 64, 2);
          if (num1 == -1)
          {
            string str1 = "Invalid format for global lookup key.";
            string resourceBase = this.getResourceBase();
            string str2 = key;
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new MissingResourceException(str1, resourceBase, str2);
          }
          else
          {
            string string2;
            Exception e;
            try
            {
              string2 = ResourceBundleWrapper.getBundle(String.instancehelper_substring(string1, 2, num1)).getString(String.instancehelper_substring(string1, num1 + 1));
            }
            catch (Exception ex)
            {
              int num2 = 0;
              M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2);
              if (m0 == null)
              {
                throw;
              }
              else
              {
                e = (Exception) m0;
                goto label_10;
              }
            }
            return string2;
label_10:
            Log.error((object) "Error during global lookup", e);
            string str1 = "Error during global lookup";
            string resourceBase = this.getResourceBase();
            string str2 = key;
            Throwable.__\u003CsuppressFillInStackTrace\u003E();
            throw new MissingResourceException(str1, resourceBase, str2);
          }
        }
        else if (String.instancehelper_startsWith(string1, "@"))
        {
          string key1 = String.instancehelper_substring(string1, 1);
          this.lookupPath.add((object) key);
          string string2 = this.internalGetString(key1);
          this.cache.put((object) key, (object) string2);
          return string2;
        }
        else
        {
          this.cache.put((object) key, (object) string1);
          return string1;
        }
      }
    }

    protected internal string getResourceBase()
    {
      return this.resourceBase;
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 113, (byte) 114, (byte) 131, (byte) 130, (byte) 107})]
    [MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
    public virtual string getString(string key)
    {
      string str = (string) this.cache.get((object) key);
      if (str != null)
        return str;
      this.lookupPath.clear();
      return this.internalGetString(key);
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 16, (byte) 132, (byte) 159, (byte) 6, (byte) 131, (byte) 127, (byte) 0, (byte) 149, (byte) 108, (byte) 131, (byte) 127, (byte) 0, (byte) 149, (byte) 131, (byte) 131, (byte) 152, (byte) 152})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private ImageIcon createIcon([In] string obj0, [In] bool obj1, [In] bool obj2)
    {
      int num1 = obj1 ? 1 : 0;
      int num2 = obj2 ? 1 : 0;
      URL resource = ObjectUtilities.getResource(obj0, ResourceBundleSupport.class\u0024org\u0024jfree\u0024util\u0024ResourceBundleSupport != null ? ResourceBundleSupport.class\u0024org\u0024jfree\u0024util\u0024ResourceBundleSupport : (ResourceBundleSupport.class\u0024org\u0024jfree\u0024util\u0024ResourceBundleSupport = ResourceBundleSupport.class\u0024("org.jfree.util.ResourceBundleSupport")));
      if (resource == null)
      {
        Log.warn((object) new StringBuffer().append("Unable to find file in the class path: ").append(obj0).toString());
        ImageIcon.__\u003Cclinit\u003E();
        return new ImageIcon((Image) this.createTransparentImage(1, 1));
      }
      else
      {
        Image image = Toolkit.getDefaultToolkit().createImage(resource);
        if (image == null)
        {
          Log.warn((object) new StringBuffer().append("Unable to instantiate the image: ").append(obj0).toString());
          ImageIcon.__\u003Cclinit\u003E();
          return new ImageIcon((Image) this.createTransparentImage(1, 1));
        }
        else if (num1 != 0)
        {
          if (num2 != 0)
          {
            ImageIcon.__\u003Cclinit\u003E();
            return new ImageIcon(image.getScaledInstance(24, 24, 4));
          }
          else
          {
            ImageIcon.__\u003Cclinit\u003E();
            return new ImageIcon(image.getScaledInstance(16, 16, 4));
          }
        }
        else
          return new ImageIcon(image);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 169, (byte) 131, (byte) 144, (byte) 136, (byte) 144, (byte) 104, (byte) 208, (byte) 127, (byte) 11, (byte) 114, (byte) 252, (byte) 69, (byte) 226, (byte) 61, (byte) 225, (byte) 69})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private Integer createMnemonic([In] string obj0)
    {
      if (obj0 == null)
      {
        string str = "Key is null.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new NullPointerException(str);
      }
      else if (String.instancehelper_length(obj0) == 0)
      {
        string str = "Key is empty.";
        Throwable.__\u003CsuppressFillInStackTrace\u003E();
        throw new IllegalArgumentException(str);
      }
      else
      {
        int num1 = (int) String.instancehelper_charAt(obj0, 0);
        if (String.instancehelper_startsWith(obj0, "VK_"))
        {
          try
          {
            num1 = ((Integer) (ResourceBundleSupport.class\u0024java\u0024awt\u0024event\u0024KeyEvent != null ? ResourceBundleSupport.class\u0024java\u0024awt\u0024event\u0024KeyEvent : (ResourceBundleSupport.class\u0024java\u0024awt\u0024event\u0024KeyEvent = ResourceBundleSupport.class\u0024("java.awt.event.KeyEvent"))).getField(obj0, ResourceBundleSupport.__\u003CGetCallerID\u003E()).get((object) null, ResourceBundleSupport.__\u003CGetCallerID\u003E())).intValue();
            goto label_9;
          }
          catch (Exception ex)
          {
            int num2 = 2;
            if (ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num2) == null)
              throw;
          }
        }
label_9:
        return new Integer(num1);
      }
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 203, (byte) 153, (byte) 193})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private int getMenuKeyMask()
    {
      int menuShortcutKeyMask;
      try
      {
        menuShortcutKeyMask = Toolkit.getDefaultToolkit().getMenuShortcutKeyMask();
      }
      catch (UnsupportedOperationException ex)
      {
        goto label_3;
      }
      return menuShortcutKeyMask;
label_3:
      return 2;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 46, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual KeyStroke getKeyStroke(string key, int mask)
    {
      return KeyStroke.getKeyStroke(this.createMnemonic(this.getString(key)).intValue(), mask);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 60, (byte) 136, (byte) 140, (byte) 149})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual KeyStroke getOptionalKeyStroke(string key, int mask)
    {
      string @string = this.getString(key);
      if (@string == null || String.instancehelper_length(@string) <= 0)
        return (KeyStroke) null;
      return KeyStroke.getKeyStroke(this.createMnemonic(@string).intValue(), mask);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 220, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Integer getMnemonic(string key)
    {
      return this.createMnemonic(this.getString(key));
    }

    [LineNumberTable((ushort) 483)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Class class\u0024([In] string obj0)
    {
      Class @class;
      ClassNotFoundException notFoundException;
      try
      {
        @class = Class.forName(obj0, ResourceBundleSupport.__\u003CGetCallerID\u003E());
      }
      catch (ClassNotFoundException ex)
      {
        int num = 1;
        notFoundException = (ClassNotFoundException) ByteCodeHelper.MapException<ClassNotFoundException>((Exception) ex, (ByteCodeHelper.MapFlags) num);
        goto label_3;
      }
      return @class;
label_3:
      string message = Throwable.instancehelper_getMessage((Exception) notFoundException);
      Throwable.__\u003CsuppressFillInStackTrace\u003E();
      throw new NoClassDefFoundError(message);
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 223, (byte) 105, (byte) 110, (byte) 103, (byte) 109})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private BufferedImage createTransparentImage([In] int obj0, [In] int obj1)
    {
      BufferedImage bufferedImage = new BufferedImage(obj0, obj1, 2);
      int[] rgb = bufferedImage.getRGB(0, 0, obj0, obj1, (int[]) null, 0, obj0);
      Arrays.fill(rgb, 0);
      bufferedImage.setRGB(0, 0, obj0, obj1, rgb, 0, obj0);
      return bufferedImage;
    }

    [LineNumberTable(new byte[] {(byte) 162, (byte) 26, (byte) 114, (byte) 108})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string formatMessage(string key, object[] parameters)
    {
      MessageFormat.__\u003Cclinit\u003E();
      MessageFormat messageFormat = new MessageFormat(this.getString(key));
      messageFormat.setLocale(this.getLocale());
      return ((Format) messageFormat).format((object) parameters);
    }

    public virtual Locale getLocale()
    {
      return this.locale;
    }

    [LineNumberTable(new byte[] {(byte) 159, (byte) 67, (byte) 98, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Icon getIcon(string key, bool large)
    {
      int num = large ? 1 : 0;
      return (Icon) this.createIcon(this.getString(key), true, num != 0);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 199, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Icon getIcon(string key)
    {
      return (Icon) this.createIcon(this.getString(key), false, false);
    }

    [LineNumberTable(new byte[] {(byte) 160, (byte) 233, (byte) 104, (byte) 140, (byte) 138})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Integer getOptionalMnemonic(string key)
    {
      string @string = this.getString(key);
      if (@string == null || String.instancehelper_length(@string) <= 0)
        return (Integer) null;
      return this.createMnemonic(@string);
    }

    [LineNumberTable((ushort) 377)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual KeyStroke getKeyStroke(string key)
    {
      return this.getKeyStroke(key, this.getMenuKeyMask());
    }

    [LineNumberTable((ushort) 389)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual KeyStroke getOptionalKeyStroke(string key)
    {
      return this.getOptionalKeyStroke(key, this.getMenuKeyMask());
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 90, (byte) 102, (byte) 127, (byte) 7, (byte) 127, (byte) 12})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual JMenu createMenu(string keyPrefix)
    {
      JMenu jmenu = new JMenu();
      ((AbstractButton) jmenu).setText(this.getString(new StringBuffer().append(keyPrefix).append(".name").toString()));
      ((AbstractButton) jmenu).setMnemonic(this.getMnemonic(new StringBuffer().append(keyPrefix).append(".mnemonic").toString()).intValue());
      return jmenu;
    }

    [LineNumberTable(new byte[] {(byte) 161, (byte) 112, (byte) 104, (byte) 127, (byte) 6, (byte) 131, (byte) 159, (byte) 16})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual URL getResourceURL(string key)
    {
      string @string = this.getString(key);
      URL resource = ObjectUtilities.getResource(@string, ResourceBundleSupport.class\u0024org\u0024jfree\u0024util\u0024ResourceBundleSupport != null ? ResourceBundleSupport.class\u0024org\u0024jfree\u0024util\u0024ResourceBundleSupport : (ResourceBundleSupport.class\u0024org\u0024jfree\u0024util\u0024ResourceBundleSupport = ResourceBundleSupport.class\u0024("org.jfree.util.ResourceBundleSupport")));
      if (resource == null)
        Log.warn((object) new StringBuffer().append("Unable to find file in the class path: ").append(@string).append("; key=").append(key).toString());
      return resource;
    }

    [LineNumberTable((ushort) 610)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Icon createTransparentIcon(int width, int height)
    {
      ImageIcon.__\u003Cclinit\u003E();
      return (Icon) new ImageIcon((Image) this.createTransparentImage(width, height));
    }

    [LineNumberTable((ushort) 623)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string formatMessage(string key, object parameter)
    {
      string key1 = key;
      object[] parameters = new object[1];
      int index = 0;
      object obj = parameter;
      parameters[index] = obj;
      return this.formatMessage(key1, parameters);
    }

    [LineNumberTable((ushort) 639)]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual string formatMessage(string key, object par1, object par2)
    {
      string key1 = key;
      object[] parameters = new object[2];
      int index1 = 0;
      object obj1 = par1;
      parameters[index1] = obj1;
      int index2 = 1;
      object obj2 = par2;
      parameters[index2] = obj2;
      return this.formatMessage(key1, parameters);
    }

    [SpecialName]
    private static CallerID __\u003CGetCallerID\u003E()
    {
      if (ResourceBundleSupport.__\u003CcallerID\u003E == null)
        ResourceBundleSupport.__\u003CcallerID\u003E = (CallerID) new ResourceBundleSupport.__\u003CCallerID\u003E();
      return ResourceBundleSupport.__\u003CcallerID\u003E;
    }

    private sealed class __\u003CCallerID\u003E : CallerID
    {
      internal __\u003CCallerID\u003E()
      {
        base.\u002Ector();
      }
    }
  }
}
