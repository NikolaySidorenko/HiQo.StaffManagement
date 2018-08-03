using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Repositories;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Service;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Configuration.CastleWindsor
{
    public class IoCContainer
    {
        private static IWindsorContainer _container;

        public static void Setup(string assemblyName)
        {
            _container = new WindsorContainer();
           
            ControllersInstaller installer=new ControllersInstaller(assemblyName);
            installer.Install(_container,null);

            SetupRepositoryDependencies();
            SetupServiceDependencies();
            SetupDbContextDependencies();
           
            var controllerFactory = new WindsorControllerFactory(_container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }

        private static void SetupRepositoryDependencies()
        {
            _container.Register(Component.For<IUserRepositiry>().ImplementedBy(typeof(UserRepository))
                .LifestylePerWebRequest());
            _container.Register(Component.For<IDepartmentRepositiry>().ImplementedBy(typeof(DepartmentRepository))
                .LifestylePerWebRequest());
            _container.Register(Component.For<ICategoryRepositiry>().ImplementedBy(typeof(CategoryRepository))
                .LifestylePerWebRequest());
            _container.Register(Component.For<IPositionRepositiry>().ImplementedBy(typeof(PositionRepository))
                .LifestylePerWebRequest());
            _container.Register(Component.For<IPositionLevelRepositiry>().ImplementedBy(typeof(PositionLevelRepository))
                .LifestylePerWebRequest());
            _container.Register(Component.For<IRoleRepositiry>().ImplementedBy<RoleRepository>()
                .LifestylePerWebRequest());
        }

        private static void SetupServiceDependencies()
        {
            _container.Register(Component.For<IUserService>().ImplementedBy(typeof(UserService))
                .LifestylePerWebRequest());
            _container.Register(Component.For<IDepartmentService>().ImplementedBy(typeof(DepartmentService))
                .LifestylePerWebRequest());
            _container.Register(Component.For<ICategoryService>().ImplementedBy(typeof(CategoryService))
                .LifestylePerWebRequest());
            _container.Register(Component.For<IPositionService>().ImplementedBy(typeof(PostionService))
                .LifestylePerWebRequest());
            _container.Register(Component.For<IGradeService>().ImplementedBy(typeof(GradeService))
                .LifestylePerWebRequest());
            _container.Register(Component.For<IRoleSerivice>().ImplementedBy(typeof(RoleService))
                .LifestylePerWebRequest());
            _container.Register(Component.For<IUpsertUserService>().ImplementedBy(typeof(UpsertUserService))
                .LifestylePerWebRequest());
            _container.Register(Component.For<ISharedService>().ImplementedBy(typeof(SharedService))
                .LifestylePerWebRequest());
        }

        private static void SetupDbContextDependencies()
        {
            _container.Register(Component.For<CompanyContext>().LifestylePerWebRequest());
        }
    }
}
