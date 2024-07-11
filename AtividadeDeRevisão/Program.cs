using AtividadeDeRevisão;

Automovel a = new Automovel();

GerenciadorGeral ger = new GerenciadorGeral();
ger.ListarAutomovel();

Funcionario f = new Funcionario("matricula", "Veiculo");
f.verificarVeiculo(a);
