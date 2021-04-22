using System;

namespace OOP20.validator
{
    /// <summary>
    /// This interface allow to concatenate Func
    /// </summary>
    /// <typeparam name="T">The input</typeparam>
    /// <typeparam name="TResult">The output</typeparam>
    public interface IFuncConcatenator<T, TResult>
    {
        /// <param name="function">Func to add in the chain</param>
        /// <returns>a reference to this IFuncConcatenator</returns>
        IFuncConcatenator<T, TResult> Add(Func<T, TResult> function);

        /// <returns>the chained Func</returns>
        Func<T, TResult> Create();
    }
}
