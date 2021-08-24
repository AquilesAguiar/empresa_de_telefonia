using System;

class MainClass {
  public static void Main (string[] args) {
		movel Oi = new movel("Aquiles",97653214,2021,0.0,true,true);
    movel Vivo = new movel("NovoAquiles",98776789,2021,0.0,true,true);
		fixa Tim = new fixa("Aquiles",97653214,2021,60.5,50);

    // Movel 
    Oi.enviar_sms(Vivo,"E ai");
    Console.WriteLine(Vivo.mensagem);
  }
}