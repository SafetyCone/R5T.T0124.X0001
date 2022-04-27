using System;

using R5T.T0124;

using Instances = R5T.T0124.X0001.Instances;


namespace System
{
    public static class ISearchPatternExtensions
    {
        public static string AllCSharpProjectFiles(this ISearchPattern _)
        {
            var output = Instances.SearchPatternOperator.AllFilesWithExtension(
                Instances.FileExtension.CSharpProjectFile());

            return output;
        }

        /// <summary>
        /// Chooses <see cref="AllCSharpProjectFiles(ISearchPattern)"/> as the default for projects.
        /// </summary>
        public static string AllProjectFiles(this ISearchPattern _)
        {
            var output = _.AllCSharpProjectFiles();
            return output;
        }

        public static string AllSolutionFiles(this ISearchPattern _)
        {
            var output = Instances.SearchPatternOperator.AllFilesWithExtension(
                Instances.FileExtension.Sln());

            return output;
        }
    }
}
