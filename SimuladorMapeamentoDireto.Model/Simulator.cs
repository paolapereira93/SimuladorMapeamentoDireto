using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorMapeamentoDireto.Model
{
    public class Simulator
    {
        public List<int> Enderecos { get; set; }
        public int CacheSize { get; set; }
        public List<CacheLine> Cache { get; set; }
        public Dictionary<int, string> MainMemory { get; set; }

        public Simulator()
        {
            raffleScript();
            MainMemory = new Dictionary<int, string>();
            initializeCache();
        }

        public void initializeCache()
        {
            CacheSize = 32;
            Cache = new List<CacheLine>();
            for (int i = 0; i < CacheSize; i++)
            {
                Cache.Add(new CacheLine());
            }
        }
        public void raffleScript()
        {
            this.Enderecos = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int end = rnd.Next(0, 1024);
                this.Enderecos.Add(end);
            }
        }

        public bool accessAddress(int address)
        {
            bool hasInCache = false;
            int cacheLine = address % CacheSize;
            int tag = address / CacheSize;
            CacheLine cl = Cache.ElementAt(cacheLine);

            if (cl.Validity)
            {
                if (cl.Tag != tag)
                {
                    cl.Content = accessMainMemory(address);
                    cl.Tag = tag;
                }
                else
                {
                    hasInCache = true;
                }
            }
            else
            {
                cl.Content = accessMainMemory(address);
                cl.Tag = tag;
                cl.Validity = true;
            }

            return hasInCache;
        }


        public string accessMainMemory(int index)
        {
            if (!MainMemory.ContainsKey(index))
                MainMemory.Add(index, Guid.NewGuid().ToString("N").Substring(0, 10));
        
            return MainMemory[index];
        }
    }
}
