class fixa:linha{
	double mensalidade{get;set;}
	double franquia_minutos{get;set;}
	double valor_restante{get;set;}
	bool fatura {get;set;}

	public fixa(string nome,int numero,int anoContratacao,double mensalidade,double franquia_minutos).base(nome,numero,anoContratacao){
		this.mensalidade = mensalidade;
		this.franquia_minutos = franquia_minutos;
		this.valor_restante = franquia_minutos; 
		this.fatura = false;
	}

	public string Ligar(int qtd_min){
		if(fatura == true){
				if(valor_restante>= qtd_min){
					valor_restante-=qtd_min;
					return $"Valor para consumido da franquia {qtd_min}";
				}
				return "Sem saldo suficiente";
		}
		return "Fatura pendente";
	}

	public string pagarFatura(){
		this.fatura = false;
		this.valor_restante = this.franquia_minutos;
	}
}