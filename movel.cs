using System;
class movel:linha{
	
	private double _saldo;
	private string _msg;
	private bool _sms,_planoDados;

	public double Saldo{
		get =>_saldo;
		set =>_saldo = value;
	}

	public string Mensagem{
		get => _msg;
		set =>_msg = value;
	}
	public bool Sms{
		get =>_sms;
		set =>_sms = value;
	}
	public bool planoDados{
		get =>_planoDados;
		set =>_planoDados = value;
	}

	
	public movel(string nome,int numero,int anoContratacao,double saldo,bool planoDados,bool sms): base(nome,numero,anoContratacao){
		Saldo = saldo;
		this.planoDados = planoDados; 
		Sms = sms;
	}
	public double Recarregar(double valor){
		Saldo += valor;
		return Saldo;
	}
	public string Navegar(int qtd_mb){
		if(planoDados == true){
				double valor_nav = 0.99*qtd_mb;
				if(Saldo>= valor_nav){
					Saldo-=valor_nav;
					return $"Valor para consumido para navegar {valor_nav}";
				}
				return "Sem saldo suficiente";
		}
		return "Serviço indisponível";
	}
	public string enviar_sms(movel linha_msg,string msg){
		if(planoDados == true){
				if(Saldo>= 0.10){
					Saldo-=0.10;
					linha_msg.Mensagem = msg;
					return $"Mensagem enviada com sucesso para o numero {linha_msg.Numero}";
				}
				return "Sem saldo suficiente";
		}
		return "Serviço indisponível";
	}



}