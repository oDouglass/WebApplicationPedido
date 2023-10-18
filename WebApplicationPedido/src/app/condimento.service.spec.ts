import { TestBed } from '@angular/core/testing';

import { CondimentoService } from './condimento.service';

describe('CondimentoService', () => {
  let service: CondimentoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CondimentoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
