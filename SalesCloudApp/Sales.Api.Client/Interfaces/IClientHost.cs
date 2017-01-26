namespace Sales.Api.Client.Interfaces
{
    /// <summary>
    /// this is the interface of main ui application exposed to child views.
    /// </summary>
    public interface IClientHost
    {
        /// <summary>
        /// the messaging service.
        /// </summary>
        IMessagingService MessageService { get; }
    }
}
