using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleEffects
{
    /// <summary>
    /// I can't seem to come up with a good way to unit test console ui, so this is my workaround.
    /// </summary>
    public class JoggerDiagnostics
    {
        public JoggerDiagnostics()
        {
            Type type = typeof(Jogger);
            foreach (var method in type.GetMethods())
            {
                //UGh.
                var parameters = method.GetParameters();
                method.Invoke(null, parameters);
            }
        }
    }
}
