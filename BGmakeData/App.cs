using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace BGmakeData
{
    class App
    {
        public App() 
        {
            //Console.WriteLine("BGmakeData");

            string data = File.ReadAllText("./Bgmakelist.json");
            //Console.WriteLine(data);

            BGmakeData[] bGmakeDatas = JsonConvert.DeserializeObject<BGmakeData[]>(data);

            Dictionary<int, BGmakeData> dicbgmakedata = new Dictionary<int, BGmakeData>();

            foreach(BGmakeData bGmake in bGmakeDatas)
            {
                dicbgmakedata.Add(bGmake.id,bGmake);
            }

            foreach(KeyValuePair<int,BGmakeData> kv in dicbgmakedata)
            {
                Console.WriteLine
                    ("\nID:{0},\n이름:{1},\n만들기정보:{2},\n실내버전:{3},\n파괴버전:{4},\n중요:{5},\n설명:{6}",
                    kv.Key,kv.Value.name,kv.Value.mkinfo,kv.Value.insidever,kv.Value.destroyver,kv.Value.important,kv.Value.explain
                    );
            }
        }
    }
}
