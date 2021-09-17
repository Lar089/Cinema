import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-salas',
  templateUrl: './salas.component.html',
  styleUrls: ['./salas.component.css']
})
export class SalasComponent implements OnInit {

  titulo = "Salas";

  public salas = [
    'Sala1',
    'Sala2',
    'Sala3',
  ];

  constructor() { }

  ngOnInit() {
  }

}
