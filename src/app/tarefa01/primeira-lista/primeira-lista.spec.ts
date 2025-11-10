import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PrimeiraLista } from './primeira-lista';

describe('PrimeiraLista', () => {
  let component: PrimeiraLista;
  let fixture: ComponentFixture<PrimeiraLista>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PrimeiraLista]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PrimeiraLista);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
