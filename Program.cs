﻿string  Raça, Cor, Nome, Idade, Espécie;
Console.Write("Digite o Nome do seu Pet....");
Nome = Console.ReadLine ();
Console.Write("Qual a idade do seu Pet: ");
Idade = Console.ReadLine ();
Console.Write("Digite a Espécie do seu Pet:....");
 Espécie = Console.ReadLine();
 Console.Write("Digite a Raça do seu Pet....");
 Raça = Console.ReadLine();
 Console.Write("Qual a Pelagem/cor do seu Pet:");
 Cor = Console.ReadLine ();
 
Console.WriteLine("+=========================================================+");
Console.WriteLine("|                ..Pet Hotel Schiavone..                  |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"Espécie:.....:{Espécie}     |Raça...... {Raça}           |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"| Atende pela nomeclatura de: ................... {Nome} |");
Console.WriteLine($"Idade: {Idade}               Pelagem: {Cor}              |");
Console.WriteLine("+=========================================================+");