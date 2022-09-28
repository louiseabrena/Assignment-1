using System;
using System.Reflection;

namespace N01282172MaryLouiseAnhanceAbrena_Assignment1.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}