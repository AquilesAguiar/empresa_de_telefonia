using System;

class MainClass {
  public static void Main (string[] args) {
		movel Oi = new movel("Aquiles",97653214,2021,0.0,true,true);
    movel Vivo = new movel("NovoAquiles",98776789,2021,0.0,true,true);
		fixo Tim = new fixo("Aquiles",97653214,2021,60.5,50);
    fixo claro = new fixo("NovoAquiles",97653214,2021,60.5,50);

    // Movel-------------------------------------------------------------------------
    // Recarregar
    Console.WriteLine(Oi.Recarregar(60));
    // Enviar msg
    Console.WriteLine(Oi.enviar_sms(Vivo,"E ai"));
    // Ver msg
    Console.WriteLine(Vivo.Mensagem);
    // Navegar
    Console.WriteLine(Vivo.Navegar(20));

    // Fixo-------------------------------------------------------------------------
    Console.WriteLine(Tim.Ligar(32));
    Console.WriteLine(claro.pagarFatura());

  }
}