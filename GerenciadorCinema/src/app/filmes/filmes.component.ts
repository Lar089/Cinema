import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Filme } from '../models/Filme';

@Component({
  selector: 'app-filmes',
  templateUrl: './filmes.component.html',
  styleUrls: ['./filmes.component.css']
})
export class FilmesComponent implements OnInit {

  public filmeForm: FormGroup;
  titulo = "Filmes";
  public filmeSelecionado: Filme;
  public filtro: string;
  public adicionar: boolean;
  filesToUpload: Array<File>;

  public filmes = [
    { id: 1, titulo: 'Luca', descricao: 'filme para crianças', duracao: '01:30:00' },
    { id: 2, titulo: 'Alita - Anjo de Combate', descricao: 'filme de ação', duracao: '01:50:00'},
    { id: 3, titulo: 'Coraline', descricao: 'desenho', duracao:  '01:40:00' }
  ];

  constructor(private fb: FormBuilder) { 
    this.criarForm();
   }

  ngOnInit() {
  }

  filmeSelecionar(filme: Filme) {
    this.filmeSelecionado = filme;
    this.filmeForm.patchValue(filme);
  }

  voltar() {
    this.adicionar = false;
    this.filmeSelecionado = null!;
  }

  adicionarFilme(add: boolean) {
    this.adicionar = add;
  }

  criarForm(){
    this.filmeForm = this.fb.group({
      titulo: ['', Validators.required],
      descricao: ['', Validators.required],
      duracao: ['', Validators.required],
    });
  }

  filmeSubmit(){
    console.log(this.filmeForm.value)
  }
}

function ngOnInit() {
  
}

