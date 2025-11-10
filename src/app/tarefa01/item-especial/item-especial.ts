import { Component, Input } from '@angular/core';

@Component({
	selector: 'app-item-especial',
	standalone: true,
	imports: [],
	templateUrl: './item-especial.html',
	styleUrl: './item-especial.css',
})
export class ItemEspecial {
	@Input({ required: true }) cor!: string;
}
