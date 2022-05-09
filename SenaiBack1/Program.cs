// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using SenaiBack1.Classes;

PessoaFisica metodoPf = new PessoaFisica();

PessoaFisica novaPf = new PessoaFisica();

Endereco novoEnd = new Endereco();

//novaPf.nome = "André";

//Console.WriteLine( "Nome: " + novaPf.nome );

//Console.WriteLine( $"Nome: {novaPf.nome}" );

novaPf.nome = "André";

novaPf.dataNascimento = "01/01/2000";

novaPf.cpf = "123456789";

novaPf.rendimento = 15000.5f;


novoEnd.logradouro = "Alameda Barão de Limeira";

novoEnd.numero = 539;

novoEnd.complemento = "SENAI Informática";

novoEnd.endComercial = true;

novaPf.endereco = novoEnd;

//Console.WriteLine($"Nome: {novaPf.nome}");
//Console.WriteLine($"Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}");

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereco: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de idade: {metodoPf.ValidarDataNascimento( novaPf.dataNascimento )}
");
