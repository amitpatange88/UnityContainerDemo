using Unity;

namespace UnityContainerDemo
{
    public class RegisterDependency
    {
        public static void Register()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICar, BMW>();
        }
    }
}
