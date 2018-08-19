using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using FluentValidation;
using HiQo.StaffManagement.Web.Core.FluentValidators;

namespace HiQo.StaffManagement.Configuration.CastleWindsor
{
    public class ValidatorInstaller:IWindsorInstaller
    {

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IValidatorFactory>().ImplementedBy<WindsorValidatorFactory>());

            AssemblyScanner.FindValidatorsInAssemblyContaining<UserValidator>()
                .ForEach(result =>
                {
                    container.Register(Component.For(result.InterfaceType)
                        .ImplementedBy(result.ValidatorType).LifestylePerWebRequest());
                });
        }
    }
}
