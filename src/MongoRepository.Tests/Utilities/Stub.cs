﻿using System;
using Rhino.Mocks;

namespace MongoRepository.Tests.Utilities
{
    public static class Stub<T> where T : class
    {
        public static T Create()
        {
            return Create(x => { });
        }

        public static T Create(Action<T> setup)
        {
            var stub = MockRepository.GenerateStub<T>();

            setup(stub);

            return stub;
        }
    }
}
