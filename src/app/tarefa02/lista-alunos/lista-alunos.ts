import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

interface Aluno {
  id: number;
  nome: string;
  notaFinal: number;
}

@Component({
  selector: 'app-lista-alunos',
  imports: [CommonModule],
  templateUrl: './lista-alunos.html',
  styleUrls: ['./lista-alunos.css'],
})

export class ListaAlunosComponent {
alunos: Aluno[] = [
	{ id: 1, nome: 'Ana Luisa', notaFinal: 18 },
	{ id: 2, nome: 'Catarina', notaFinal: 15 },
	{ id: 3, nome: 'Ana Isabel', notaFinal: 8 },
	{ id: 4, nome: 'Maria Eduarda', notaFinal: 12 },
	{ id: 5, nome: 'Fábio', notaFinal: 9 },
	{ id: 6, nome: 'João Pires', notaFinal: 17 },
	{ id: 7, nome: 'João Pereira', notaFinal: 14 },
	{ id: 8, nome: 'Rui Duarte', notaFinal: 6 },
	{ id: 9, nome: 'José Filipe', notaFinal: 19 },
	{ id: 10, nome: 'Diogo', notaFinal: 16 }
  ];

get totalAlunos(): number {
	return this.alunos.length;
  }

  get notaMaxima(): number {
	return Math.max(...this.alunos.map(aluno => aluno.notaFinal));
  }

  get notaMinima(): number {
	return Math.min(...this.alunos.map(aluno => aluno.notaFinal));
  }

  get media(): number {
	const soma = this.alunos.reduce((i, aluno) => i + aluno.notaFinal, 0);
	return soma / this.alunos.length;
  }
} 