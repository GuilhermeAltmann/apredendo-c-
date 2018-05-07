"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var ListaProduto = /** @class */ (function () {
    function ListaProduto() {
        this.produtos = [
            {
                titulo: "Primeiro Produto",
                preco: 10
            },
            {
                titulo: "Segundo Produto",
                preco: 20
            },
            {
                titulo: "Terceiro Produto",
                preco: 30
            },
        ];
    }
    ListaProduto = __decorate([
        core_1.Component({
            selector: 'lista-produto',
            templateUrl: "./listProduto.component.html",
            styleUrls: []
        })
    ], ListaProduto);
    return ListaProduto;
}());
exports.ListaProduto = ListaProduto;
//# sourceMappingURL=listaProduto.component.js.map