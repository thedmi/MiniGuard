namespace MiniGuard
{
    using System.Diagnostics;

    using JetBrains.Annotations;

    [DebuggerStepThrough]
    public static class Guard
    {
        [ContractAnnotation("false => halt")]
        public static void Precondition(bool condition)
        {
            ThrowIfViolated(condition, "Precondition violated");
        }

        [ContractAnnotation("condition: false => halt")]
        public static void Precondition(bool condition, string preconditionInfo)
        {
            ThrowIfViolated(condition, $"Precondition violated: {preconditionInfo}");
        }

        [ContractAnnotation("false => halt")]
        public static void Postcondition(bool condition)
        {
            ThrowIfViolated(condition, "Postcondition violated");
        }

        [ContractAnnotation("condition: false => halt")]
        public static void Postcondition(bool condition, string postconditionInfo)
        {
            ThrowIfViolated(condition, $"Postcondition violated: {postconditionInfo}");
        }

        [ContractAnnotation("false => halt")]
        public static void Assertion(bool condition)
        {
            ThrowIfViolated(condition, "Guard violated");
        }

        [ContractAnnotation("condition: false => halt")]
        public static void Assertion(bool condition, string guardInfo)
        {
            ThrowIfViolated(condition, $"Guard violated: {guardInfo}");
        }

        [Conditional("DEBUG")]
        [ContractAnnotation("condition: false => halt")]
        public static void DebugAssertion(bool condition)
        {
            ThrowIfViolated(condition, "Guard violated");
        }

        [Conditional("DEBUG")]
        [ContractAnnotation("condition: false => halt")]
        public static void DebugAssertion(bool condition, string guardInfo)
        {
            ThrowIfViolated(condition, $"Guard violated: {guardInfo}");
        }

        // ReSharper disable once ParameterOnlyUsedForPreconditionCheck.Local
        private static void ThrowIfViolated(bool condition, string exceptionInfo)
        {
            if (!condition)
            {
                throw new GuardException(exceptionInfo);
            }
        }
    }
}
