using System;
using PluginApp.Core;

namespace ReversePlugin
{
    public class ReversePlugin: IPlugin
    {
        public string Execute(string input) {
            var syms = input.ToCharArray();

            int i=0; 
            int j=syms.Length;

            while(i < j) {
                var temp = syms[i];
                syms[i] = syms[j];
                syms[j] = temp;
                i++;
                j--;
            }

            return new string(syms);
        }
    }
}
