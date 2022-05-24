// Crie uma nova classe chamada Usuario.
// Deve conter o nome e o e-mail do usuário.
// Crie um método chamado ObterLogin, que deve retornar a parte anterior ao @ no e-mail:
// Exemplo: "douglas.pereira@iteris.com.br", deve retornar somente "douglas.pereira";
// A Lógica de extração da primeira parte do e-mail deve estar dentro da classe Usuario, já que ela é a responsável pela informação;
// O arquivo Program.cs deve ser responsável apenas por:
// Instanciar o Objeto;
// Chamar o método ObterLogin;
using Desafio2;

Usuario user1 = new("Natália Fonseca", "natalia.fonseca@iteris.com.br");

Console.WriteLine("O usuário é: " + user1.ObterLogin());
