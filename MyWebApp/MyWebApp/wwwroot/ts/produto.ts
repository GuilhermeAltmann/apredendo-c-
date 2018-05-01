export class Produto {

    public id: number;
    public nome: string;

    constructor(private sigla:string, private preco:number) {


    }

    public exibirSigla() {

        alert(this.sigla);
    }

    public obterNome():string {

        return this.nome;
    }

    public ObterId(): number {

        return this.id;
    }

    set setNome(val) {

        this.nome = val;
    }

    get getNome() {

        return this.nome;
    }
}