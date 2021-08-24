class linha{
	protected string nome{get;set;}
	protected int numero{get;set;}
	protected int anoContratacao{get;set;}
	
	public linha(string nome,int numero,int anoContratacao){
		this.nome = nome;
		this.numero = numero;
		this.anoContratacao = anoContratacao; 
	}
}