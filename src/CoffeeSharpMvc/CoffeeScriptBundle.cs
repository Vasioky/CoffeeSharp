namespace CoffeeSharp
{
    using System.Web.Optimization;

    public class CoffeeScriptBundle : Bundle
    {
        public CoffeeScriptBundle(string virtualPath)
            : base(virtualPath, new CoffeeScriptMinify())
        {
        }

        public CoffeeScriptBundle(string virtualPath, string cdnPath)
            : base(virtualPath, cdnPath, new CoffeeScriptMinify())
        {
        }
    }
}