using DependencyInjection.Models;
using System;

namespace DependencyInjection.Infrastructure
{
    public static class TypeBroker
    {
        // the type of repo by default
        private static Type repoType = typeof(MemoryRepository);
        
        // for testing purposes
        private static IRepository testRepo;

        // returns the repo 
        public static IRepository Repository =>
            testRepo ?? Activator.CreateInstance(repoType) as IRepository;

        // changes the type of the repo if the new type is of type IRepository
        public static void SetRepositoryType<T>() where T : IRepository =>
            repoType = typeof(T);
        
        // for testing purposes there is another instance of repo
        public static void SetTestObject(IRepository repo)
        {
            testRepo = repo;
        }
    }
}
