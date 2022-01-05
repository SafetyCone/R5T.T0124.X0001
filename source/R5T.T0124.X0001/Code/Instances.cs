using System;

using R5T.T0032;
using R5T.T0124;


namespace R5T.T0124.X0001
{
    public static class Instances
    {
        public static IFileExtension FileExtension { get; } = T0032.FileExtension.Instance;
        public static ISearchPatternOperator SearchPatternOperator { get; } = T0124.SearchPatternOperator.Instance;
    }
}
