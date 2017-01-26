using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Api.Client.Services
{
    #region UsedNamespaces

    using System;
    using System.Windows.Input;

    #endregion UsedNamespace

    /// <summary>
    /// Parameter less RelayCommand
    /// Please use this class if you want to follow MVVM.
    /// </summary>
    public class RelayCommand : ICommand
    {
        /// <summary>
        /// Execute Action.
        /// </summary>
        private readonly Action execute;

        /// <summary>
        /// CanExecute Predicate.
        /// </summary>
        private readonly Func<bool> canExecute;

        public RelayCommand(Action execute)
            : this(execute, null)
        {
        }

        /// <summary>
        /// Creates a new command.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        /// <param name="canExecute">The execution status logic.</param>
        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            this.execute = execute;
            this.canExecute = canExecute;
        }

        /// <summary>
        /// Can execute logic.
        /// </summary>
        /// <param name="parameter">can execute Parameter.</param>
        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute();
        }

        /// <summary>
        /// Can execute change handler.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Execute.
        /// </summary>
        public void Execute(object parameter)
        {
            execute();
        }
    }
}
