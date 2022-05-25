using Desafio3.Modelo;

List<Alternativa> alternativasQ1 = new List<Alternativa> { new Alternativa('a', "5", false), new Alternativa('b', "4", true) };
Questao q1 = new Questao("Quanto é 2 + 2?", alternativasQ1);

List<Alternativa> alternativasQ2 = new List<Alternativa> { new Alternativa('a', "4", false), new Alternativa('b', "7", true) };
Questao q2 = new Questao("Quanto é 2 + 5?", alternativasQ2);

List<Alternativa> alternativasQ3 = new List<Alternativa> { new Alternativa('a', "2 ^ 2", true), new Alternativa('b', "- 2 * 2", false), new Alternativa('c', "2 * 2", true), new Alternativa('d', "4 ^ 1", true) };
Questao q3 = new Questao("4 = X. Quais os possível valores de X:", alternativasQ3);

List<Questao> questoes = new List<Questao> { q1, q2, q3 };
Quiz quiz = new Quiz("Quiz", questoes);

quiz.AplicarQuiz();