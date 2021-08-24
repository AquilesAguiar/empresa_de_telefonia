class linha{
	protected string _nome;
	protected int _numero;
	protected int _anoContratacao;

	public string Nome{
		get =>_nome;
		set =>_nome = value;
	}

	public int Numero{
		get => _numero;
		set =>_numero = value;
	}
	public int anoContratacao{
		get =>_anoContratacao;
		set =>_anoContratacao = value;
	}
	public linha(string nome,int numero,int anoContratacao){
		this.Nome = nome;
		this.Numero = numero;
		this.anoContratacao = anoContratacao; 
	}
}