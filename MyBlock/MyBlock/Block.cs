using Blockchain.First.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlock
{
    internal class Block
    {
        public string hash { get; set; }
        public string previousHash { get; set; }
        private string data { get; set; }
        private long timeStamp { get; set; } = 0;

        private int nonce = 0;


        public Block(string data, string previousHash)
        {
            this.data = data;
            this.previousHash = previousHash;
            this.timeStamp = DatetimeHandle.GetTime();
            this.hash = CalculateHash();
        }
        public string CalculateHash()
        {
            HashSha256 sha256 = new HashSha256();
            string calculatedhash = sha256.Hash(
                previousHash +
                timeStamp.ToString() +
                nonce.ToString() +
                data);
            return calculatedhash;
        }
        public void MineBlock(int difficulty)
        {
            string target = new string(new char[difficulty]).Replace('\0', '0'); //Create a string with difficulty * "0" 
            while (!hash.Substring(0, difficulty).Equals(target))
            {
                nonce++;
                hash = CalculateHash();
                //Console.WriteLine(hash);
            }
            Console.WriteLine("Block Mined!!! : " + hash);
        }
    }
}
