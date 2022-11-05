import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EdtitProductComponent } from './edtit-product.component';

describe('EdtitProductComponent', () => {
  let component: EdtitProductComponent;
  let fixture: ComponentFixture<EdtitProductComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EdtitProductComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(EdtitProductComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
