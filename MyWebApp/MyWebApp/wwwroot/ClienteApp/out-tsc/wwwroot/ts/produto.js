"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Produto = /** @class */ (function () {
    function Produto(sigla, preco) {
        this.sigla = sigla;
        this.preco = preco;
    }
    Produto.prototype.exibirSigla = function () {
        alert(this.sigla);
    };
    Produto.prototype.obterNome = function () {
        return this.nome;
    };
    Produto.prototype.ObterId = function () {
        return this.id;
    };
    Object.defineProperty(Produto.prototype, "setNome", {
        set: function (val) {
            this.nome = val;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Produto.prototype, "getNome", {
        get: function () {
            return this.nome;
        },
        enumerable: true,
        configurable: true
    });
    return Produto;
}());
exports.Produto = Produto;
//# sourceMappingURL=produto.js.map