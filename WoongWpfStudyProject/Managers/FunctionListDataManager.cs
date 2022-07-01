using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoongWpfStudyProject.Models.Datas;
using WoongWpfStudyProject.Types;

namespace WoongWpfStudyProject.Managers
{
    internal class FunctionListDataManager
    {
        private static FunctionListDataManager _instance;
        public static FunctionListDataManager Instance => _instance ?? (_instance = new FunctionListDataManager());

        private IEnumerable<FunctionListitemData> _items = null;
        
        public IEnumerable<FunctionListitemData> GetFunctionListData()
        {
            if (_items != null)
            {
                return _items;
            }

            var items = new List<FunctionListitemData>();

            items.Add(new FunctionListitemData(FunctionsType.test,"테스트입니다."));

            return items;
        }

    }
}
