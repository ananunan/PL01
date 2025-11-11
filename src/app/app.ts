import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { PrimeiraLista } from './tarefa01/primeira-lista/primeira-lista';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [PrimeiraLista, RouterOutlet],
  templateUrl: './app.html',
  styleUrls: ['./app.css']
})
export class App {
  protected readonly title = signal('Tarefa01');
}
