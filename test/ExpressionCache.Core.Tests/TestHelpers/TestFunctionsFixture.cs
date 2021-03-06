﻿using System.Threading.Tasks;

namespace ExpressionCache.Core.Tests.TestHelpers
{
    public class TestFunctionsFixture
    {
        public string ClassName => GetType().Name;

        public readonly string ReturnResult = "ReturnResult";

        public string FunctionWithoutParameters()
        {
            return ReturnResult;
        }

        public string FunctionWithOneParameter(int number)
        {
            return ReturnResult;
        }

        public string FunctionWithTwoParameters(int number, string text)
        {
            return ReturnResult;
        }

        public string FunctionWithObjectParameter(CacheObject obj)
        {
            return ReturnResult;
        }

        #pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously

        public async Task<string> FunctionWithoutParametersAsync()
        {
            return ReturnResult;
        }

        public async Task<string> FunctionWithOneParameterAsync(int number)
        {
            return ReturnResult;
        }

        public async Task<string> FunctionWithTwoParametersAsync(int number, string text)
        {
            return ReturnResult;
        }

        public string FunctionWithObjectParameterAsync(CacheObject obj)
        {
            return ReturnResult;
        }

        #pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
    }
}
