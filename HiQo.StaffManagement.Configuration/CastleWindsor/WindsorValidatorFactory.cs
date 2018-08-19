using System;
using Castle.MicroKernel;
using FluentValidation;
using Castle.Windsor;

namespace HiQo.StaffManagement.Configuration.CastleWindsor
{
    public class WindsorValidatorFactory : ValidatorFactoryBase
    {
        private readonly IKernel _kernel;

        public WindsorValidatorFactory(IKernel kernel)
        {
            _kernel = kernel ?? throw new ArgumentNullException(nameof(kernel));
        }

        public override IValidator CreateInstance(Type validatorType)
        {
            return _kernel.HasComponent(validatorType)
                ? (IValidator) _kernel.Resolve(validatorType)
                : null;
        }
    }
}
