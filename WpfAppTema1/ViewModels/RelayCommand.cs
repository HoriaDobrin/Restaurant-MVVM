using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppTema1.ViewModels
{
    using System;
    using System.CodeDom.Compiler;
    using System.Windows.Input;

    namespace WpfAppTema1.ViewModels
    {
        public class RelayCommand : ICommand
        {
            private readonly Action _execute;
            private readonly Func<bool> _canExecute;
            private readonly Action<object> _execute_obj;

            public RelayCommand(Action execute)
        : this(execute, null, null)
            {
            }

            public RelayCommand(Action<object> execute)
                : this(null, execute, null)
            {
            }

            public RelayCommand(Action execute, Func<bool> canExecute)
        : this(execute, null, canExecute)
            {
            }

            public RelayCommand(Action<object> execute, Func<bool> canExecute)
        : this(null, execute, canExecute)
            {
            }

            public RelayCommand(Action execute, Action<object> execute_obj, Func<bool> canExecute)
            {
                _execute = execute ;
                _execute_obj = execute_obj;
                _canExecute = canExecute;
            }
            

            public event EventHandler CanExecuteChanged
            {
                add { CommandManager.RequerySuggested += value; }
                remove { CommandManager.RequerySuggested -= value; }
            }

            public bool CanExecute(object parameter)
            {
                return _canExecute?.Invoke() ?? true;
            }

            public void Execute(object parameter)
            {
                if (_execute != null)
                {
                    _execute();
                }
                else if (_execute_obj != null)
                {
                            _execute_obj(parameter);
                }
            }
        }
    }

}
