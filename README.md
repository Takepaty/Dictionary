# Classe Dictionary<TKey,TValue>
Representa uma coleção de chaves e valores.

A classe Dictionary fornece recursos semelhantes a uma Hashtable, mas é fortemente tipada. Isso significa que seu código não precisa converter de objetos genéricos em tipos específicos. Isso também significa que a classe Dictionary garante que seu código passe os tipos corretos de objetos para ele.

# TKey
O tipo das chaves no dicionário.

# TValue
O tipo dos valores no dicionário.

# Observações

A classe genérica Dictionary<TKey,TValue> fornece um mapeamento de um conjunto de chaves para um conjunto de valores. Cada adição ao dicionário consiste em um valor e sua chave associada. Recuperar um valor usando sua chave é muito rápido, próximo a O(1), porque a classe Dictionary<TKey,TValue> é implementada como uma tabela hash.


