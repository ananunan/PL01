import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PrimeiraLista } from "./tarefa01/primeira-lista/primeira-lista";

@Component({
  selector: 'app-root',
  imports: [PrimeiraLista],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('Tarefa01');
}
