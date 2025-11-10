import { Component } from '@angular/core';
import { ItemEspecial } from '../item-especial/item-especial';

@Component({
	selector: 'app-primeira-lista',
	imports: [ItemEspecial],
	templateUrl: './primeira-lista.html',
	styleUrl: './primeira-lista.css',
})
export class PrimeiraLista {
	minhaCor3 = 'blue';
	minhaCor4 = 'green';
	minhaEspecial1 = 'purple';
	minhaEspecial2 = 'pink';
}
