class moveis:linha{
	double saldo{get;set}
	string mensagem{get;set}
	bool planoDados{get;set}
	bool sms{get;set}

	public moveis(string nome,int numero,int anoContratacao,double saldo,string mensagem,bool planoDados,bool sms).base(nome,numero,anoContratacao){
		this.saldo = saldo;
		this.mensagem = mensagem;
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
	public string enviar_sms(int numero_msg,string msg){
		if(planoDados == true){
				if(saldo>= 0.10){
					saldo-=0.10;
					return $"Mensagem enviada com sucesso para {numero_msg}";
				}
				return "Sem saldo suficiente";
		}
		return "Serviço indisponível";
	}



}