using System;
using System.Reflection;
using MethodDecorator.Fody.Interfaces;

namespace Vitorm.Common.Logging.Apm
{
    public class ApmAttribute : Attribute, IMethodDecorator
    {
        public void Init(object instance, MethodBase method, object[] args)
        {
            throw new NotImplementedException();
        }

        public void OnEntry()
        {
            throw new NotImplementedException();
        }

        public void OnExit()
        {
            throw new NotImplementedException();
        }

        public void OnException(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}