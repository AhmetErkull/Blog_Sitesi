using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Blog_Sitesi.Extensions
{
    public static class ModelStateExtensions
    {
        public static void RemoveRange(this ModelStateDictionary modelstate,params string[] keys)
        {
            foreach (var key in keys)
            {
                modelstate.Remove(key);
            }
         }
    }
}
