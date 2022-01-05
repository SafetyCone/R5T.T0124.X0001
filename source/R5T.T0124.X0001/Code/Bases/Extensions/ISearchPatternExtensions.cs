using System;

using R5T.T0124;

using Instances = R5T.T0124.X0001.Instances;


namespace System
{
    public static class ISearchPatternExtensions
    {
        public static string AllSolutionFiles(this ISearchPattern _)
        {
            var output = Instances.SearchPatternOperator.AllFilesWithExtension(
                Instances.FileExtension.Sln());

            return output;
        }
    }
}
