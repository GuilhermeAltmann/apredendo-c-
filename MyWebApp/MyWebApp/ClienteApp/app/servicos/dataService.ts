import { Http, Response } from "@angular/http";
import { Produto } from "../modelos/produto";
import { Injectable } from "@angular/core";
import 'rxjs/add/operator/map';
import { Observable } from "rxjs/Observable";

@Injectable()
export class DataServices{

    public produtos: Produto[];
    constructor(private http: Http) {


    }

    carregarProdutos(): Observable<Produto[]> {
        return this.http.get("/api/produto")
            .map((result: Response) => this.produtos = result.json());
    }
    
}