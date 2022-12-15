Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

Console.WriteLine("Chaves e Valores cadastrados.");

foreach (var item in estados)
{
  Console.WriteLine($"Chave: {item.Key} Valor:{item.Value}");
}
Console.WriteLine("-----------------------");
Console.WriteLine("Removendo estado.");

estados.Remove("BA");

foreach (var item in estados)
{
  Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
}

Console.WriteLine("-----------------------");
Console.WriteLine("Alterando valor.");

estados["SP"] = "Grande São Paulo";

foreach (var item in estados)
{
  Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}.");
}
Console.WriteLine();
Console.WriteLine("-----------------------");
String chave = "BA";
Console.WriteLine($"Verificando o elemento {chave}");

if (estados.ContainsKey(chave))
{
  Console.WriteLine($"Chave: {chave} existente!");
}
else
{
  Console.WriteLine($"Chave {} não existente! É seguro adicionar.");
}