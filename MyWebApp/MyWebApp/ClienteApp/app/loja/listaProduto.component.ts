import { Component } from '@angular/core';
import { DataServices } from '../servicos/dataService';
import { OnInit } from '@angular/core/src/metadata/lifecycle_hooks';
import { Produto } from '../modelos/produto';

@Component({
    selector: 'lista-produto',
    templateUrl: "./listaProduto.component.html",
    styleUrls: []
})
export class ListaProduto implements OnInit{

    constructor(private data: DataServices) {

        this.produtos = data.produtos;
    }

    ngOnInit(): void {
        this.data.carregarProdutos()
            .subscribe(() => this.produtos = this.data.produtos);
    }
    public produtos: Produto[];
}
