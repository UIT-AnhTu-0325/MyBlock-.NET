using MyBlock_Proof_of_work;
using Newtonsoft.Json;

var startTime = DateTime.Now;

Blockchain phillyCoin = new Blockchain();
phillyCoin.AddBlock(new Block(DateTime.Now, null, "{sender:Henry,receiver:MaHesh,amount:10}"));
phillyCoin.AddBlock(new Block(DateTime.Now, null, "{sender:MaHesh,receiver:Henry,amount:5}"));
phillyCoin.AddBlock(new Block(DateTime.Now, null, "{sender:Mahesh,receiver:Henry,amount:5}"));

var endTime = DateTime.Now;

Console.WriteLine($"Duration: {endTime - startTime}");

Console.WriteLine(JsonConvert.SerializeObject(phillyCoin, Formatting.Indented));