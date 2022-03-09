using MyBlock_Transaction;
using Newtonsoft.Json;

//For one chain 
//Blockchain phillyCoin = new Blockchain();
//phillyCoin.CreateTransaction(new Transaction("Henry", "MaHesh", 10));
//phillyCoin.ProcessPendingTransactions("Bill");
//Console.WriteLine(JsonConvert.SerializeObject(phillyCoin, Formatting.Indented));

//For two chain with miner award

var startTime = DateTime.Now;

Blockchain phillyCoin = new Blockchain();
phillyCoin.CreateTransaction(new Transaction("Henry", "MaHesh", 10));
phillyCoin.ProcessPendingTransactions("Bill");
Console.WriteLine(JsonConvert.SerializeObject(phillyCoin, Formatting.Indented));

phillyCoin.CreateTransaction(new Transaction("MaHesh", "Henry", 5));
phillyCoin.CreateTransaction(new Transaction("MaHesh", "Henry", 5));
phillyCoin.ProcessPendingTransactions("Jonh");

var endTime = DateTime.Now;

Console.WriteLine($"Duration: {endTime - startTime}");

Console.WriteLine(JsonConvert.SerializeObject(phillyCoin, Formatting.Indented));

Console.ReadKey();