namespace CoffeeSharp
{
    using System;
    using System.IO;
    using System.Web;
    using System.Web.Optimization;

    public class CoffeeScriptMinify : IBundleTransform
    {
        public void Process(BundleContext context, BundleResponse response)
        {
            var coffeeScriptEngine = new CoffeeScriptEngine();
            string compiledCoffeeScript = String.Empty;
            foreach (var file in response.Files)
            {
                using (var reader = new StreamReader(file.VirtualFile.Open()))
                {
                    compiledCoffeeScript += coffeeScriptEngine.Compile(reader.ReadToEnd());
                    reader.Close();
                }
            }
            response.Content = compiledCoffeeScript;
            response.ContentType = "text/javascript";
            response.Cacheability = HttpCacheability.Public;
        }
    }
}
