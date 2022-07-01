using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoongWpfStudyProject.Types;

namespace WoongWpfStudyProject.Models.Datas
{
    public class FunctionListitemData
    {
        public FunctionListitemData(FunctionsType type, string name)
        {
            this.Type = type;
            this.Name = name;
        }

        public FunctionsType Type { get; set; }

        public string Name { get; set; }
    }
}
