using SingletonVault;

var vault1 = Vault.Instance();
vault1.generateKey();


var vault2 = Vault.Instance();
vault2.generateKey();