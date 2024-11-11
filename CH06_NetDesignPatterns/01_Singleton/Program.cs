using SingletonVault;
var vault1 = Vault.Instance();
vault1.GenerateKey();
var vault2 = Vault.Instance();
vault2.GenerateKey();

Console.ReadKey();