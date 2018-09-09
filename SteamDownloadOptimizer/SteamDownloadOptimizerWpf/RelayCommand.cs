using System;
using System.Windows.Input;

namespace SteamDownloadOptimizerWpf
{
  public class RelayCommand : ICommand
  {
    private Action m_Action;

    public RelayCommand(Action action)
    {
      m_Action = action;
    }

    public void Execute(object parameter)
    {
      if (m_Action != null)
      {
        m_Action();
      }
    }

    public bool CanExecute(object parameter)
    {
      return true;
    }

    public event EventHandler CanExecuteChanged;
  }
}
