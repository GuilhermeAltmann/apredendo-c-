import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
//import { HttpClientModule } from "@angular/common/http";
import { HttpModule } from "@angular/http";
import { AppComponent } from './app.component';
import { ListaProduto } from './loja/listaProduto.component';
import { DataServices } from './servicos/dataService';

@NgModule({
  declarations: [
      AppComponent,
      ListaProduto
  ],
  imports: [
      BrowserModule,
      HttpModule
    ],
    providers: [DataServices],
  bootstrap: [AppComponent]
})
export class AppModule { }
