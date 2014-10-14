// Decompiled with JetBrains decompiler
// Type: org.jfree.ui.tabbedui.RootEditor
// Assembly: SmartDashboard, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9F306A9B-2142-4463-973F-A516156E3EE9
// Assembly location: C:\Users\Matan\Documents\Repositories\SmartDashboard.NET\DLLs\SmartDashboard.dll

using java.beans;
using javax.swing;

namespace org.jfree.ui.tabbedui
{
  public interface RootEditor
  {
    JMenu[] getMenus();

    string getEditorName();

    JComponent getMainPanel();

    void addPropertyChangeListener(string str, PropertyChangeListener pcl);

    bool isActive();

    void setActive(bool b);

    JComponent getToolbar();

    bool isEnabled();

    void removePropertyChangeListener(string str, PropertyChangeListener pcl);

    void addPropertyChangeListener(PropertyChangeListener pcl);

    void removePropertyChangeListener(PropertyChangeListener pcl);
  }
}
