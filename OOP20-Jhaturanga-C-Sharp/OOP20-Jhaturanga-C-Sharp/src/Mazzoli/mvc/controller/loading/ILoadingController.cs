namespace OOP20_Jhaturanga_C_Sharp.Mazzoli.mvc.controller.loading
{
    /// <summary>
    /// The controller for the loading page.
    /// </summary>
    public interface ILoadingController : IController
    {
        /// <summary>
        /// Load the application's data. This method should be call on application
        /// startup.
        /// </summary>
        void Load();
    }
}