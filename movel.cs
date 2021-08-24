class movel:linha{
	double saldo{get;set;}
	string mensagem{get;set;}
	bool planoDados{get;set;}
	bool sms{get;set;}

	public movel(string nome,int numero,int anoContratacao,double saldo,bool planoDados,bool sms).base(nome,numero,anoContratacao){
		this.saldo = saldo;
		this.planoDados = planoDados; 
		this.sms = sms;
	}
	public double Recarregar(double valor){
		saldo += valor;
		return saldo;
	}
	public string Navegar(int qtd_mb){
		if(planoDados == true){
				double valor_nav = 0.99*qtd_mb;
				if(saldo>= valor_nav){
					saldo-=valor_nav;
					return $"Valor para consumido para navegar {valor_nav}";
				}
				return "Sem saldo suficiente";
		}
		return "Serviço indisponível";
	}
	public string enviar_sms(movel linha_msg,string msg){
		if(planoDados == true){
				if(saldo>= 0.10){
					saldo-=0.10;
					linha_msg.mensagem = msg;
					return $"Mensagem enviada com sucesso para {linha_msg.numero}";
				}
				return "Sem saldo suficiente";
		}
		return "Serviço indisponível";
	}
}