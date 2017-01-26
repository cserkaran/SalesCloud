using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sales.Api.Client.Interfaces
{
    /// <summary>
    /// Interface for showing message boxes.
    /// </summary>
    public interface  IMessagingService
    {
        /// <summary>
        /// Show's a message box.
        /// </summary>
        /// <param name="window">The window.</param>
        void ShowMessage(string message);
    }
}
