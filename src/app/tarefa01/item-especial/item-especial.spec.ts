import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ItemEspecial } from './item-especial';

describe('ItemEspecial', () => {
  let component: ItemEspecial;
  let fixture: ComponentFixture<ItemEspecial>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ItemEspecial]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ItemEspecial);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
