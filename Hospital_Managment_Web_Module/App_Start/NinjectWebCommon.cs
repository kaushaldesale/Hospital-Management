[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Hospital_Managment_Web_Module.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Hospital_Managment_Web_Module.App_Start.NinjectWebCommon), "Stop")]

namespace Hospital_Managment_Web_Module.App_Start
{
    using Hosipital_Managment_Interface_Layer.Common_Function;
    using Hosipital_Managment_Interface_Layer.Master_Interface;
    using Hospital_Managment_Business_Layer.B_Common_Function;
    using Hospital_Managment_Business_Layer.Business_Master;
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject;
    using Ninject.Web.Common;
    using System;
    using System.Web;
    public static class NinjectWebCommon
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IHospital_Information>().To<BHospital_Master_Repository>().InRequestScope();
           
            kernel.Bind<ICls_Drop_Down_List_Function>().To<B_Cls_Drop_Down_List_Functions>().InRequestScope();
            kernel.Bind<IDesignation_Master>().To<BDesignation_Master_Repository>().InRequestScope();
            kernel.Bind<IEmployee_Master>().To<BEmployee_Master_Repository>().InRequestScope();
            kernel.Bind<IUser_Creation>().To<BUser_Master_Repository>().InRequestScope();
            kernel.Bind<IMaterial_Type_Master>().To<BMaterial_Type_Master_Repository>().InRequestScope();
            kernel.Bind<IUnit_Master>().To<BUnit_Master_Repository>().InRequestScope();
            kernel.Bind<IItem_Master>().To<BItem_Master_Repository>().InRequestScope();
        }
    }
}
