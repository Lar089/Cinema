import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-sessoes',
  templateUrl: './sessoes.component.html',
  styleUrls: ['./sessoes.component.css']
})
export class SessoesComponent implements OnInit {

  titulo = "Sessões";

  public sessoes = [
    'Sessão 1',
    'Sessão 2',
    'Sessão 3',
  ];
  
  constructor() { }

  ngOnInit() {
  }

}
