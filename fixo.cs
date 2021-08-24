class fixo:linha{
	double _mensalidade,_franquia_minutos,_valor_restante;
	bool _fatura;

	public double Mensalidade{
		get =>_mensalidade;
		set =>_mensalidade = value;
	}

	public double FranquiaMinutos{
		get => _franquia_minutos;
		set =>_franquia_minutos = value;
	}
	public double valorRestante{
		get =>_valor_restante;
		set =>_valor_restante = value;
	}
	public bool Fatura{
		get =>_fatura;
		set =>_fatura = value;
	}


	public fixo(string nome,int numero,int anoContratacao,double mensalidade,double franquia_minutos) : base(nome,numero,anoContratacao){
		Mensalidade = mensalidade;
		FranquiaMinutos = franquia_minutos;
		valorRestante = franquia_minutos; 
		Fatura = false;
	}

	public string Ligar(int qtd_min){
		if(Fatura == true){
				if(valorRestante>= qtd_min){
					valorRestante-=qtd_min;
					return $"Valor para consumido da franquia {qtd_min}";
				}
				return "Sem saldo suficiente";
		}
		return "Fatura pendente";
	}

	public string pagarFatura(){
		this.Fatura = false;
		this.valorRestante = this.FranquiaMinutos;
		return "Fatura paga";
	}
}