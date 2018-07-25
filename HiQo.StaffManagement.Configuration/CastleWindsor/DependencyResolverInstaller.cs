using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using HiQo.StaffManagement.DAL.Database;
using HiQo.StaffManagement.DAL.Database.Entities;
using HiQo.StaffManagement.DAL.Repositories;
using HiQo.StaffManagement.Domain.Repositories;
using HiQo.StaffManagement.Domain.Service;
using HiQo.StaffManagement.Domain.Service.Interfaces;

namespace HiQo.StaffManagement.Configuration.CastleWindsor
{
    public class DependencyResolverInstaller:IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IUserRepositiry>().ImplementedBy(typeof(UserRepository))
                .LifestylePerWebRequest());
            container.Register(Component.For<IDepartmentRepositiry>().ImplementedBy(typeof(DepartmentRepository))
                .LifestylePerWebRequest());
            container.Register(Component.For<ICategoryRepositiry>().ImplementedBy(typeof(CategoryRepository))
                .LifestylePerWebRequest());
            container.Register(Component.For<IPositionRepositiry>().ImplementedBy(typeof(PositionRepository))
                .LifestylePerWebRequest());
            container.Register(Component.For<IPositionLevelRepositiry>().ImplementedBy(typeof(PositionLevelRepository))
                .LifestylePerWebRequest());
            container.Register(Component.For<IRoleRepositiry>().ImplementedBy<RoleRepository>()
                .LifestylePerWebRequest());

            container.Register(Component.For<IUserService>().ImplementedBy(typeof(UserService))
                .LifestylePerWebRequest());
            container.Register(Component.For<IDepartmentService>().ImplementedBy(typeof(DepartmentService))
                .LifestylePerWebRequest());
            container.Register(Component.For<ICategoryService>().ImplementedBy(typeof(CategoryService))
                .LifestylePerWebRequest());
            container.Register(Component.For<IPositionService>().ImplementedBy(typeof(PostionService))
                .LifestylePerWebRequest());
            container.Register(Component.For<IGradeService>().ImplementedBy(typeof(GradeService))
                .LifestylePerWebRequest());
            container.Register(Component.For<IRoleSrivice>().ImplementedBy(typeof(RoleService))
                .LifestylePerWebRequest());

            container.Register(Component.For<CompanyContext>().LifestylePerWebRequest());

        }
    }
}
