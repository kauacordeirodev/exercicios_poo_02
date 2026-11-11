using ExerciciosPOO_Heranca;

// 1

Carro carro1 = new()
{
  Marca = "Chevrolet",
  Modelo = "Monza",
  QuantidadePortas = 4
};

Motocicleta moto1 = new()
{
  Marca = "Honda",
  Modelo = "CG 160",
  Cilindradas = 160
};

carro1.exibirInformacoes();
moto1.exibirInformacoes();

// 2

ProdutoDigital ebook = new Ebook("Noites Brancas", 15, 96);
ProdutoDigital cursoJava = new CursoOnline("Java do Zero", 35, 40);

// 3

JogoDigital jogo1 = new("Pou", "Mobile", "Playstore");
JogoFisico jogo2 = new("PES 6", "Playstation 2", "Playstation Clássicos");

jogo1.apresentarInformacoes();
jogo2.apresentarInformacoes();

// 4

Notificacao notificacaoEmail = new NotificacaoEmail();
Notificacao notificacaoSMS = new NotificacaoSMS();
Notificacao notificacaoPush = new NotificacaoPush();

notificacaoEmail.Enviar();
notificacaoSMS.Enviar();
notificacaoPush.Enviar();

// 5

Entrega entrega1 = new EntregaExpressa()
{
  Distancia = 10
};

Entrega entrega2 = new EntregaEconomica()
{
  Distancia = 10
};

Entrega entrega3 = new RetiradaLocal()
{
  Distancia = 10
};

List<Entrega> entregas = new List<Entrega> {entrega1, entrega2, entrega3};

foreach (Entrega entrega in entregas)
{
  entrega.calcularFrete();
} 

// 6

Relatorio novoRelatorio = new();

novoRelatorio.Imprimir();
novoRelatorio.Exportar();

Contrato contrato = new();

contrato.Imprimir();