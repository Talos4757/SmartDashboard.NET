// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.UIUtilities
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using IKVM.Attributes;
using IKVM.Runtime;
using java.awt;
using java.lang;
using javax.swing;
using javax.swing.border;
using javax.swing.plaf;
using System;
using System.Runtime.CompilerServices;

namespace org.jfree.ui
{
  public class UIUtilities : Object
  {
    [LineNumberTable(new byte[] {(byte) 12, (byte) 104})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private UIUtilities()
    {
      base.\u002Ector();
    }

    [LineNumberTable(new byte[] {(byte) 20, (byte) 102, (byte) 221, (byte) 2, (byte) 97, (byte) 166, (byte) 134, (byte) 255, (byte) 9, (byte) 72, (byte) 112, (byte) 118, (byte) 139, (byte) 139, (byte) 110, (byte) 110, (byte) 110, (byte) 110, (byte) 110, (byte) 110, (byte) 142})]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void setupUI()
    {
      Exception exception;
      try
      {
        UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
        goto label_5;
      }
      catch (Exception ex)
      {
        int num = 0;
        M0 m0 = ByteCodeHelper.MapException<Exception>(ex, (ByteCodeHelper.MapFlags) num);
        if (m0 == null)
          throw;
        else
          exception = (Exception) m0;
      }
      Throwable.instancehelper_printStackTrace((Exception) exception);
label_5:
      UIDefaults defaults = UIManager.getDefaults();
      defaults.put((object) "PopupMenu.border", (object) new BorderUIResource.EtchedBorderUIResource(0, defaults.getColor((object) "controlShadow"), defaults.getColor((object) "controlLtHighlight")));
      MatteBorder matteBorder = new MatteBorder(1, 1, 1, 1, (Color) Color.black);
      BorderUIResource.CompoundBorderUIResource borderUiResource1 = new BorderUIResource.CompoundBorderUIResource((Border) new MatteBorder(2, 2, 2, 2, defaults.getColor((object) "control")), (Border) matteBorder);
      BorderUIResource.EmptyBorderUIResource borderUiResource2 = new BorderUIResource.EmptyBorderUIResource(0, 0, 0, 0);
      defaults.put((object) "SplitPane.border", (object) borderUiResource2);
      defaults.put((object) "Table.scrollPaneBorder", (object) borderUiResource2);
      defaults.put((object) "ComboBox.border", (object) borderUiResource1);
      defaults.put((object) "TextField.border", (object) borderUiResource1);
      defaults.put((object) "TextArea.border", (object) borderUiResource1);
      defaults.put((object) "CheckBox.border", (object) borderUiResource1);
      defaults.put((object) "ScrollPane.border", (object) borderUiResource2);
    }
  }
}
