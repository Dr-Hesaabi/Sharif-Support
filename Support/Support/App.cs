using Support.Helpers;
using Support.Interfaces;
using Support.Services;
using Support.Model;

namespace Support
{
    public partial class App
    {
        public App()
        {
        }

        public static void Initialize()
        {
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
        }
    }
}